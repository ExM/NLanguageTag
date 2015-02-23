using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class VariantTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetVariants())
			{
				var variant = text.ParseFromVariant();
				variant.GetPrefixes();
				Assert.NotNull(variant.ToText());
			}
		}

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
		[TestCase("sr-Hans", Variant.Ekavsk, null)]
		[TestCase("en", Variant.Ekavsk, null)]
		[TestCase("sr", Variant.Fonipa, false)]
		[TestCase("sr-Cyrl", Variant.Fonipa, false)]
		[TestCase("sr-Hans", Variant.Fonipa, false)]
		[TestCase("az", Variant.Baku1926, true)]
		[TestCase("en", Variant.Baku1926, null)]
		[TestCase("sl", Variant.V1994, null)]
		[TestCase("en-scotland", Variant.Fonipa, false)]
		[TestCase("sl-rozaj-biske-fonipa", Variant.V1994, null)]
		[TestCase("sl-rozaj-biske", Variant.V1994, true)]
		public void RestrictiveAcceptableFor(string tagText, Variant variant, bool? expected)
		{
			var tag = new LanguageTag(tagText);
			Assert.AreEqual(expected, variant.RestrictiveAcceptableFor(tag.Language, tag.Script, tag.Variants));
		}
	}
}
