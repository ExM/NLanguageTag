using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Mono.TextTemplating;

namespace NLanguageTag.SourceCodeRenderer
{
	public class TemplateRenderer
	{
		public static string Render(string templateName, string templateString)
		{
			var gen = new TemplateGenerator();

			string templateSourceCode;
			string[] references;



			var preprocessResult = gen.PreprocessTemplate(templateName + ".tt", "MyTemplateClass", "MyTemplateNs", templateString, out _, out references, out templateSourceCode);

			//UNDONE show warnings
			if (!preprocessResult)
				throw new AggregateException(gen.Errors.Cast<CompilerError>().Select(x => new Exception(x.ToString())));

			//UNDONE trace template code
			//Console.WriteLine(templateSourceCode);

			var sourceReferences = references.Select(x => MetadataReference.CreateFromFile(x)).ToList();
			sourceReferences.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
			sourceReferences.Add(
				MetadataReference.CreateFromFile(typeof(System.CodeDom.CodeObject).Assembly.Location));

			sourceReferences.Add(
				MetadataReference.CreateFromFile(typeof(System.Collections.Generic.Stack<>).Assembly.Location));

			sourceReferences.Add(
				MetadataReference.CreateFromFile(typeof(CollectionBase).Assembly.Location));

			//sourceReferences.Add(
			//	MetadataReference.CreateFromFile(typeof(RegistryContainer).Assembly.Location));

			var netstandardPath = AppDomain.CurrentDomain.GetAssemblies().Single(a => a.GetName().Name == "netstandard").Location;

			sourceReferences.Add(MetadataReference.CreateFromFile(netstandardPath));

			sourceReferences.Add(
				MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies().Single(a => a.GetName().Name == "System.Runtime").Location));

			var syntaxTree = CSharpSyntaxTree.ParseText(templateSourceCode, CSharpParseOptions.Default, templateName + ".cs", Encoding.UTF8);

			var compilation = CSharpCompilation.Create(
				"assemblyName",
				new[] { syntaxTree },
				sourceReferences,
				new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

			var asm = Emit(compilation);

			var t = asm.GetType("MyTemplateNs.MyTemplateClass");

			var mi = t.GetMethod("TransformText");
			var inst = Activator.CreateInstance(t);
			var result = (string) mi.Invoke(inst, new object?[0]);

			return result;
		}

		public static Assembly Emit(CSharpCompilation compilation)
		{
			using var dllStream = new MemoryStream();
			using var pdbStream = new MemoryStream();

			var emitResult = compilation.Emit(dllStream, pdbStream);
			if (!emitResult.Success)
				throw new AggregateException(emitResult.Diagnostics.Select(x => new Exception(x.ToString())));

			return Assembly.Load(dllStream.ToArray(), pdbStream.ToArray());
		}
	}
}
