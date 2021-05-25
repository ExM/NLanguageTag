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
			context.AddSource("LanguageTag.ctors.cs", BuilderFactory.Ctors());
			context.AddSource("LanguageTag.take.cs", BuilderFactory.Take());
		}
	}
}

