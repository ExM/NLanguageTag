using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class ExtensionSubtagTests
	{
		[TestCase("a-bbb-ccc-x", 'a', new string[] { "bbb", "ccc" }, 0, 10)]
		[TestCase("a-bbb-ccc-?", 'a', new string[] { "bbb", "ccc" }, 0, 10)]
		[TestCase("???-a-bbb-ccc-?", 'a', new string[] { "bbb", "ccc" }, 4, 14)]
		public void TryParseFromExtensionSubtagToken(string text, char singleton, string[] subtags, int begin, int next)
		{
			int tokenIndex = begin;
			Assert.AreEqual(new ExtensionSubtag(singleton, subtags), text.TryParseFromExtensionSubtagToken(ref tokenIndex).Value);
			Assert.AreEqual(next, tokenIndex);
		}

		[TestCase("a-bbb", 'a', new string[] { "bbb" })]
		[TestCase("a-bbb-ccc", 'a', new string[] { "bbb", "ccc" })]
		public void ParseFromExtensionSubtag(string text, char singleton, string[] subtags)
		{
			Assert.AreEqual(new ExtensionSubtag(singleton, subtags), text.ParseFromExtensionSubtag());
		}
	}
}
