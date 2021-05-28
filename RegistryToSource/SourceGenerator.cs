using System;
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
			try
			{
				context.ReportDiagnostic(Diagnostic.Create(new DiagnosticDescriptor(
					"1",
					"Runtime version",
					$"Runtime version: {Environment.Version}",
					"Category demo",
					DiagnosticSeverity.Warning,
					isEnabledByDefault: true), Location.None));


				context.AddSource("LanguageTag.ctors.cs", new LanguageTag_Ctors().TransformText());
				//context.AddSource("LanguageTag.take.cs", new LanguageTag_Take().TransformText());

				context.AddSource("LanguageTag.take.cs", RenderFromTemplate("LanguageTag.Take"));
			}
			catch (Exception e)
			{
				context.ReportDiagnostic(Diagnostic.Create(new DiagnosticDescriptor(
					"1",
					"Runtime error",
					$"Runtime version: {Environment.Version} ### " + e.ToString().Replace("\r\n", "{br}"),
					"Category demo",
					DiagnosticSeverity.Error,
					isEnabledByDefault: true), Location.None));
				//throw;
			}
		}

		public static string RenderFromTemplate(string name)
		{
			var content = Resources.Read(name);
			return TemplateRenderer.Render(name, content);
		}
	}
}

