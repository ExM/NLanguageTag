using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	[TestFixture]
	public class VariantTests
	{
		[TestCase("aluku", Variant.Aluku)]
		[TestCase("1901", Variant.V1901)]
		public void ParseFromVariant(string text, Variant expected)
		{
			Assert.AreEqual(expected, text.ParseFromVariant());
		}

		[TestCase("xxx")]
		[TestCase("xxx-xxx")]
		[TestCase("xxx-")]
		[ExpectedException(typeof(FormatException))]
		public void ParseFromVariant_Fail(string text)
		{
			text.ParseFromVariant();
		}

		[TestCase("???-xxx-xx", 4, null, 4)]
		[TestCase("???-1996", 4, Variant.V1996, 8)]
		[TestCase("???-1996-", 4, Variant.V1996, 9)]
		[TestCase("???-1996-xx", 4, Variant.V1996, 9)]
		public void TryParseFromVariantToken(string text, int begin, Variant? expected, int expNextToken)
		{
			int nextToken = begin;
			Assert.AreEqual(expected, text.TryParseFromVariantToken(ref nextToken));
			Assert.AreEqual(expNextToken, nextToken);
		}

		[TestCase("sr", Variant.Ekavsk, true)]
		[TestCase("sr-Cyrl", Variant.Ekavsk, true)]
		[TestCase("sr-Hans", Variant.Ekavsk, false)]
		[TestCase("en", Variant.Ekavsk, false)]
		[TestCase("sr", Variant.Fonipa, true)]
		[TestCase("sr-Cyrl", Variant.Fonipa, true)]
		[TestCase("sr-Hans", Variant.Fonipa, true)]
		[TestCase("az", Variant.Baku1926, true)]
		[TestCase("en", Variant.Baku1926, false)]
		[TestCase("sl", Variant.V1994, false)]
		public void IsPrefixFor(string tag, Variant variant, bool expected)
		{
			Assert.AreEqual(expected, new LanguageTag(tag).IsPrefixFor(variant));
		}
	}
}
