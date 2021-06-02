﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.SourceCodeRenderer
{
	public class Program
	{
		static void Main(string[] args)
		{
			var outputPath = args.Length > 0
				? args[0]
				: Environment.CurrentDirectory;

			if (!Path.IsPathRooted(outputPath))
				outputPath = Path.Combine(Environment.CurrentDirectory, outputPath);

			if (!Directory.Exists(outputPath))
				Directory.CreateDirectory(outputPath);

			//UNDONE cleanup old *.cs files

			var registry = Registry.ReadCurrent();

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

					"LanguageTag.Ctors",
					"LanguageTag.Take",
				}
				.Select(x => new Template(x, CodeTemplateManager.Read(x)))
				.ToList();

			AddTxt(templates, "Subtag.Summary");

			if (registry.PrimaryLanguages.Count > FixedNumbers.LanguageCode.Count)
				AddCsv(templates, "LanguageCode.newNumbers");

			if (registry.Regions.Count > FixedNumbers.RegionCode.Count)
				AddCsv(templates, "RegionCode.newNumbers");

			if (registry.Scripts.Count > FixedNumbers.ScriptCode.Count)
				AddCsv(templates, "ScriptCode.newNumbers");

			if (registry.Variants.Count > FixedNumbers.VariantCode.Count)
				AddCsv(templates, "VariantCode.newNumbers");



			var assembly = Template.Emit(templates);

			foreach (var template in templates)
			{
				var fileName = Path.Combine(outputPath, template.FileName);
				var content = template.Render(assembly, registry);
				File.WriteAllText(fileName, content);
			}
		}

		private static void AddCsv(List<Template> templates, string name)
		{
			var content = CodeTemplateManager.Read(name);
			templates.Add(new Template(name, content, "csv"));
		}

		private static void AddTxt(List<Template> templates, string name)
		{
			var content = CodeTemplateManager.Read(name);
			templates.Add(new Template(name, content, "txt"));
		}
	}
}