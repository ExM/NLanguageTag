﻿using System.Collections.Generic;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class RegistryParsingTest
	{
		[TestCase("language-subtag-registry", "2021-05-11")]
		[TestCase("2019-09-16", "2019-09-16")]
		[TestCase("2020-07-17", "2020-07-17")]
		public void FileDate(string fileName, string date)
		{
			var reg = Registry.Read(RegistryFiles.Read(fileName)!);
			Assert.AreEqual(date, reg.FileDate);
		}

		public static IReadOnlyList<string> GetAllRevisions() => RegistryFiles.AllRevisions;
	}
}
