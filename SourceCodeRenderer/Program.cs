using System;
using System.IO;

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

			WriteFile(outputPath, "LanguageTag.Ctors");
			WriteFile(outputPath, "LanguageTag.Take");
		}

		private static void WriteFile(string outputPath, string templateName)
		{
			var fileName = Path.Combine(outputPath, $"{templateName}.cs");
			File.WriteAllText(fileName, RenderFromTemplate(templateName));
		}

		public static string RenderFromTemplate(string name)
		{
			var content = CodeTemplateManager.Read(name);
			return TemplateRenderer.Render(name, content);
		}
	}
}
