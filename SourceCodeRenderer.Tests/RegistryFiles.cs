using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class RegistryFiles
	{
		private const string _prefix = "NLanguageTag.SourceCodeRenderer.registries.";
		private static readonly Assembly _asm;

		static RegistryFiles()
		{
			_asm = typeof(RegistryFiles).Assembly;
			AllRevisions = _asm.GetManifestResourceNames()
				.Where(_ => _.StartsWith(_prefix, StringComparison.Ordinal))
				.Select(_ => _.Substring(_prefix.Length))
				.ToList();
		}

		public static Stream? Read(string fileRevision)
		{
			return _asm.GetManifestResourceStream(_prefix + fileRevision);
		}

		public static IReadOnlyList<string> AllRevisions { get; }

		[Test]
		public void KnownRegistriesCount()
		{
			Assert.AreEqual(3, AllRevisions.Count);
		}
	}
}
