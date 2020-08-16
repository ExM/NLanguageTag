using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace NLanguageTag.T4Tools
{
	public class RegistryParsingTest
	{
		[TestCaseSource(nameof(GetAllRevisions))]
		public void FileDate(string fileRevision)
		{
			var reg = Registry.Read(RegistryFiles.Read(fileRevision));
			Assert.AreEqual(fileRevision, reg.FileDate);
		}

		public static IReadOnlyList<string> GetAllRevisions() => RegistryFiles.AllRevisions;
	}
}
