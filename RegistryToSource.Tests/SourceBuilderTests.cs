using System;
using NUnit.Framework;

namespace NLanguageTag.RegistryToSource
{
	public class SourceBuilderTests
	{
		[Test]
		public void Constructors()
		{
			Console.WriteLine(new LanguageTag_Ctors().TransformText());
		}

		[Test]
		public void Take()
		{
			Console.WriteLine(SourceGenerator.RenderFromTemplate("LanguageTag.Take"));
		}
	}
}
