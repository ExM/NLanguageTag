using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using McMaster.Extensions.CommandLineUtils;
using NLanguageTag.SourceCodeRenderer.FixedCodes;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.SourceCodeRenderer;

public static class Program
{
	public static int Main(string[] args)
	{
		var app = new CommandLineApplication();

		app.HelpOption();

		var inputPath = app
			.Option<string>("-i|--input <path>", "Set path to data files", CommandOptionType.SingleValue)
			.IsRequired();

		var outputPath = app
			.Option<string>("-o|--output <path>", "Set path to generated source files", CommandOptionType.SingleValue)
			.IsRequired();

		var update = app.Option<bool>("-u|--update", "Upload last language-subtag-registry", CommandOptionType.NoValue);
		
		var newCodes = app.Option<bool>("-n|--newCodes", "Generate new codes for new subtags", CommandOptionType.NoValue);

		app.OnExecute(() => Execute(inputPath.ParsedValue, outputPath.ParsedValue, update.ParsedValue, newCodes.ParsedValue));

		return app.Execute(args);
	}
	
	public static void Execute(string inputPath, string outputPath, bool updateSpecification, bool generateNewCodes)
	{
		if (!Path.IsPathRooted(inputPath))
			inputPath = Path.Combine(Environment.CurrentDirectory, inputPath);

		if (!Path.IsPathRooted(outputPath))
			outputPath = Path.Combine(Environment.CurrentDirectory, outputPath);

		if (!Directory.Exists(outputPath))
			Directory.CreateDirectory(outputPath);

		//TODO cleanup old *.cs files

		var registryFilePath = Path.Combine(inputPath, "language-subtag-registry");

		if (updateSpecification)
			UpdateRegistry(registryFilePath);

		var registry = Registry.Read(File.OpenRead(registryFilePath));
		var languageCode = new CodeMap(Path.Combine(inputPath, "LanguageCodes.csv"));
		var regionCode = new CodeMap(Path.Combine(inputPath, "RegionCodes.csv"));
		var scriptCode = new CodeMap(Path.Combine(inputPath, "ScriptCodes.csv"));
		var variantCode = new CodeMap(Path.Combine(inputPath, "VariantCodes.csv"));

		var templates = new[]
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

		if (generateNewCodes)
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

		using var client = new HttpClient();
		client.DefaultRequestHeaders.UserAgent.ParseAdd("Code generation for NLanguageTag");

		using var s = client.GetStreamAsync(registryUri).Result;
		using var fs = new FileStream(registryFilePath, FileMode.Truncate);

		s.CopyTo(fs);
	}

	private static void AddTxt(List<Template> templates, string name)
	{
		var content = CodeTemplateManager.Read(name);
		templates.Add(new Template(name, content, "txt"));
	}
}

