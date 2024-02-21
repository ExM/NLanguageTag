using System.Collections.Generic;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class RegistryParsingTest
	{
		[TestCase("language-subtag-registry", "2023-10-16")]
		[TestCase("2019-09-16", "2019-09-16")]
		[TestCase("2020-07-17", "2020-07-17")]
		public void FileDate(string fileName, string date)
		{
			var reg = Registry.Read(RegistryFiles.Read(fileName)!);
			Assert.That(date, Is.EqualTo(reg.FileDate));
		}

		public static IReadOnlyList<string> GetAllRevisions() => RegistryFiles.AllRevisions;
	}
}
