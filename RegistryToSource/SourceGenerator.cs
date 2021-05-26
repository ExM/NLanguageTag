using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

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
			context.AddSource("LanguageTag.take.cs", new LanguageTag_Take().TransformText());
		}
	}
}

