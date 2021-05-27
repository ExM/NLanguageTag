using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using NLanguageTag.RegistryToSource.CodeTemplates;

namespace NLanguageTag.RegistryToSource
{
	[Generator]
	public class SourceGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
			context.AddSource("LanguageTag.ctors.cs", new LanguageTag_Ctors().TransformText());
			//context.AddSource("LanguageTag.take.cs", new LanguageTag_Take().TransformText());

			context.AddSource("LanguageTag.take.cs", RenderFromTemplate("LanguageTag.Take"));
		}

		public static string RenderFromTemplate(string name)
		{
			var content = Resources.Read(name);
			return TemplateRenderer.Render(name, content);
		}
	}
}

