using System;
using System.Collections.Generic;
using System.Linq;
using NLanguageTag.SourceCodeRenderer.FixedCodes;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class TemplatePlaygrounds
	{
		private static Registry? _registry;
		private static ICodeMap? _scriptCode;

		[OneTimeSetUp]
		public void SetUp()
		{
			_registry = Registry.Read(
				typeof(TemplatePlaygrounds).Assembly.GetManifestResourceStream("NLanguageTag.SourceCodeRenderer.registries.language-subtag-registry")!);
			_scriptCode = new CodeMapStub();
		}

		[TestCase("LanguageTag.Ctors")]
		[TestCase("LanguageTag.Take")]
		[TestCase("Script.list")]
		[TestCase("ScriptCode")]
		public void Render(string templateName)
		{
			var template = new Template(templateName, CodeTemplateManager.Read(templateName));
			var assembly = Template.Emit(new [] { template });
			var content = template.Render(assembly, ctx =>
			{
				ctx.Registry = _registry!;
				ctx.ScriptCode = _scriptCode!;
			});

			Assert.That(content, Is.Not.Empty);
			//Console.WriteLine(content);
		}

		public class CodeMapStub : ICodeMap
		{
			public int? TryGet(string subtag)
			{
				return null;
			}

			public void Update(IEnumerable<string> subtags)
			{
			}
		}
	}
}
