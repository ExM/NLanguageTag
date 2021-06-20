using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using CommandLine;
using NLanguageTag.SourceCodeRenderer.FixedCodes;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.SourceCodeRenderer
{
	public class Program
	{
		public class Options
		{
			[Option('i', "input", Required = true, HelpText = "Set path to data files")]
			public string? InputPath { get; set; }

			[Option('o', "output", Required = true, HelpText = "Set path to generated source files")]
			public string? OutputPath { get; set; }

			[Option('u', "update", Required = false, HelpText = "Upload last language-subtag-registry")]
			public bool UpdateRegistry { get; set; }

			[Option('n', "newCodes", Required = false, HelpText = "Generate new codes for new subtags")]
			public bool NewCodes { get; set; }
		}

		static void Main(string[] args)
		{
			Parser.Default
				.ParseArguments<Options>(args)
				.WithParsed(RunOptions);
		}

		static void RunOptions(Options opts)
		{
			var inputPath = opts.InputPath!;
			var outputPath = opts.OutputPath!;

			if (!Path.IsPathRooted(inputPath))
				inputPath = Path.Combine(Environment.CurrentDirectory, inputPath);

			if (!Path.IsPathRooted(outputPath))
				outputPath = Path.Combine(Environment.CurrentDirectory, outputPath);

			if (!Directory.Exists(outputPath))
				Directory.CreateDirectory(outputPath);

			//TODO cleanup old *.cs files

			var registryFilePath = Path.Combine(inputPath, "language-subtag-registry");

			if (opts.UpdateRegistry)
				UpdateRegistry(registryFilePath);

			var registry = Registry.Read(File.OpenRead(registryFilePath));
			var languageCode = new CodeMap(Path.Combine(inputPath, "LanguageCodes.csv"));
			var regionCode = new CodeMap(Path.Combine(inputPath, "RegionCodes.csv"));
			var scriptCode = new CodeMap(Path.Combine(inputPath, "ScriptCodes.csv"));
			var variantCode = new CodeMap(Path.Combine(inputPath, "VariantCodes.csv"));

			var templates = new []
				{
					"Grandfathered",
					"Language.byCode",
					"Language.extLang",
					"Language.list",
					"Language.parsing",
					"LanguageCode",
					"Region.byCode",
					"Region.list",
					"Region.parsing",
					"RegionCode",
					"Script.byCode",
					"Script.list",
					"Script.parsing",
					"ScriptCode",
					"Variant.byCode",
					"Variant.list",
					"Variant.parsing",
					"VariantCode",

					"LanguageTag.Summary",
					"LanguageTag.Ctors",
					"LanguageTag.Take",
				}
				.Select(x => new Template(x, CodeTemplateManager.Read(x)))
				.ToList();

			AddTxt(templates, "Subtag.Summary");

			if (opts.NewCodes)
			{
				languageCode.Update(registry.PrimaryLanguages.Select(x => x.Subtag));
				regionCode.Update(registry.Regions.Select(x => x.Subtag));
				scriptCode.Update(registry.Scripts.Select(x => x.Subtag));
				variantCode.Update(registry.Variants.Select(x => x.Subtag));
			}

			var assembly = Template.Emit(templates);

			foreach (var template in templates)
			{
				var fileName = Path.Combine(outputPath, template.FileName);
				var content = template.Render(assembly, ctx =>
				{
					ctx.Registry = registry;
					ctx.LanguageCode = languageCode;
					ctx.RegionCode = regionCode;
					ctx.ScriptCode = scriptCode;
					ctx.VariantCode = variantCode;
				});
				File.WriteAllText(fileName, content);
			}
		}

		private static void UpdateRegistry(string registryFilePath)
		{
			var registryUri = "https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry";
			Console.WriteLine($"Update language subtag registry from {registryUri}");

			var client = new WebClient ();
			client.Headers.Add(HttpRequestHeader.UserAgent, "https://github.com/ExM/NLanguageTag");
			client.DownloadFile(registryUri, registryFilePath);
		}

		private static void AddTxt(List<Template> templates, string name)
		{
			var content = CodeTemplateManager.Read(name);
			templates.Add(new Template(name, content, "txt"));
		}
	}
}
