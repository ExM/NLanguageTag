using System;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class TemplatePlaygrounds
	{
		[TestCase("LanguageTag.Ctors")]
		[TestCase("LanguageTag.Take")]
		public void Render(string templateName)
		{
			Console.WriteLine(Program.RenderFromTemplate(templateName));
		}
	}
}
