using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace NLanguageTag.RegistryToSource
{
	public static class GeneratorExecutionContextExtensions
	{
		public static void AddSource(this GeneratorExecutionContext context, string fileName, SourceBuilder builder)
		{
			context.AddSource(fileName, SourceText.From(builder.Build(), Encoding.UTF8));
		}
		
		public static void AddSource(this GeneratorExecutionContext context, string fileName, string sourceCode)
		{
			context.AddSource(fileName, SourceText.From(sourceCode, Encoding.UTF8));
		}
	}
}
