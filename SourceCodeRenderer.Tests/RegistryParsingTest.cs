using System.Collections.Generic;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class RegistryParsingTest
	{
		[TestCaseSource(nameof(GetAllRevisions))]
		public void FileDate(string fileRevision)
		{
			var reg = Registry.Read(RegistryFiles.Read(fileRevision)!);
			Assert.AreEqual(fileRevision, reg.FileDate);
		}

		public static IReadOnlyList<string> GetAllRevisions() => RegistryFiles.AllRevisions;
	}
}
