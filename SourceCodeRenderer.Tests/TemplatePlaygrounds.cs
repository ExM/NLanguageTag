using System;
using System.Linq;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class TemplatePlaygrounds
	{
		private static Registry? _registry;

		[OneTimeSetUp]
		public void SetUp()
		{
			_registry = Registry.ReadCurrent();
		}

		[TestCase("LanguageTag.Ctors")]
		[TestCase("LanguageTag.Take")]
		[TestCase("LanguageCode.newNumbers")]
		public void Render(string templateName)
		{
			var template = new Template(templateName, CodeTemplateManager.Read(templateName));
			var assembly = Template.Emit(new [] { template });
			var content = template.Render(assembly, _registry!);

			Console.WriteLine(content);
		}
	}
}
