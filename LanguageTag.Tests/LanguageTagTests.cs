using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public partial class LanguageTagTests
	{
		[TestCase("", null, null, null)]
		[TestCase("en", Language.EN, null, null)]
		[TestCase("en-Latn", Language.EN, null, null)]
		[TestCase("ru-Latn", Language.RU, Script.Latn, null)]
		[TestCase("afb", Language.AFB, null, null)]
		[TestCase("ar-afb", Language.AFB, null, null)]
		[TestCase("yue", Language.YUE, null, null)]
		[TestCase("zh-yue", Language.YUE, null, null)]
		[TestCase("ru-Latn", Language.RU, Script.Latn, null)]
		[TestCase("zh-Hans", Language.ZH, Script.Hans, null)]
		[TestCase("zh-TW", Language.ZH, null, Region.TW)]
		[TestCase("zh-Hans-TW", Language.ZH, Script.Hans, Region.TW)]
		public void SimpleParse(string text, Language? langEx, Script? scrEx, Region? regionEx)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Language, Is.EqualTo(langEx));
			Assert.That(tag.Script, Is.EqualTo(scrEx));
			Assert.That(tag.Region, Is.EqualTo(regionEx));
			Assert.That(tag.Variants, Is.Empty);
			Assert.That(tag.Extensions, Is.Empty);
			Assert.That(tag.PrivateUse, Is.Empty);
		}

		[TestCase("en", new Variant[]{})]
		[TestCase("en-scotland", new Variant[] { Variant.Scotland })]
		[TestCase("en-GB-scotland", new Variant[] { Variant.Scotland })]
		[TestCase("sl-rozaj", new Variant[] { Variant.Rozaj })]
		[TestCase("sl-rozaj-biske", new Variant[] { Variant.Rozaj, Variant.Biske })]
		[TestCase("sl-rozaj-biske-1994", new Variant[] { Variant.Rozaj, Variant.Biske, Variant.V1994 })]
		[TestCase("sl-rozaj-1994", new Variant[] { Variant.Rozaj, Variant.V1994 })]
		[TestCase("sl-rozaj-biske-1994-fonipa", new Variant[] { Variant.Rozaj, Variant.Biske, Variant.V1994, Variant.Fonipa })]
		public void ParseWithVariants(string text, Variant[] variantsEx)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Variants, Is.EquivalentTo(variantsEx));
		}

		[TestCase("sl-rozaj-a-bbb-ccc", new char[]{ 'a'})]
		[TestCase("sl-rozaj-a-bbb-ccc-b-aaa", new char[] { 'a', 'b' })]
		[TestCase("sl-rozaj-b-bbb-ccc-a-aaa", new char[] { 'a', 'b' })]
		public void ParseWithExtensions(string text, char[] singletones)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Extensions.Select(_ => _.Singleton), Is.EquivalentTo(singletones));
		}

		[TestCase("en-scotland", "en", true)]
		[TestCase("sl-US-rozaj-biske-1994-fonipa", "sl-rozaj-biske-1994", true)]
		[TestCase("en-GB", "en-scotland", false)]
		[TestCase("en-GB", "it", false)]
		[TestCase("en-a-aaa-b-bbb", "en-a-aaa", true)]
		[TestCase("en-a-aaa-b-bbb", "en-b-bbb", true)]
		[TestCase("en-a-aaa-b-bbb", "en-a-aaa-b-bbb", true)]
		[TestCase("en-b-bbb", "en-a-aaa-b-bbb", false)]
		[TestCase("en-a-aaa-b-ccc", "en-a-aaa-b-bbb", false)]
		public void Contains(string x, string y, bool expected)
		{
			var xTag = LanguageTag.Parse(x);
			var yTag = LanguageTag.Parse(y);

			Assert.That(xTag.Contains(yTag), Is.EqualTo(expected));
		}

		[TestCase("en-scotland", ">=", "en", true)]
		[TestCase("en-scotland", "<=", "en", false)]
		[TestCase("en-scotland", "==", "en", false)]
		[TestCase("en-scotland", "!=", "en", true)]
		[TestCase("en", ">=", "en", true)]
		[TestCase("en", "<=", "en", true)]
		[TestCase("en", "==", "en", true)]
		[TestCase("en", "!=", "en", false)]
		[TestCase("sl-US-rozaj-biske-1994-fonipa", ">=", "sl-rozaj-biske-1994", true)]
		[TestCase("sl-US-rozaj-biske-1994-fonipa", "<=", "sl-rozaj-biske-1994", false)]
		[TestCase("sl-US-rozaj-biske-1994-fonipa", "==", "sl-rozaj-biske-1994", false)]
		[TestCase("sl-US-rozaj-biske-1994-fonipa", "!=", "sl-rozaj-biske-1994", true)]
		[TestCase("en-GB", "!=", "en-scotland", true)]
		[TestCase("en-GB", "==", "en-scotland", false)]
		[TestCase("en-GB", ">=", "en-scotland", false)]
		[TestCase("en-GB", "<=", "en-scotland", false)]
		[TestCase("en-GB", "!=", "it", true)]
		[TestCase("en-a-aaa-b-bbb", ">=", "en-b-bbb", true)]
		[TestCase("x-aaa", "<=", "en-x-aaa", true)]
		[TestCase("x-aaa", ">=", "en-x-aaa", false)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", "==", "ru-Latn-RU-Petr1708-a-aaa-x-aaa", true)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", "!=", "ru-Latn-RU-Petr1708-a-aaa-x-bbb", true)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", "<=", "ru-Latn-RU-Petr1708-a-aaa-x-bbb", false)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", ">=", "ru-Latn-RU-Petr1708-a-aaa-x-bbb", false)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", "!=", "ru-Latn-RU-Petr1708-a-aaa", true)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa", "==", "ru-Latn-RU-Petr1708-a-aaa", true)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa", "!=", "ru-Latn-RU-Petr1708-a-bbb", true)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa", "!=", "ru-Latn-RU-Petr1708", true)]
		[TestCase("ru-Latn-RU-Petr1708", "==", "ru-Latn-RU-Petr1708", true)]
		[TestCase("ru-Latn-RU-Petr1708", "!=", "ru-Latn-RU-Luna1918", true)]
		[TestCase("ru-Latn-RU-Petr1708", "!=", "ru-Latn-RU", true)]
		[TestCase("ru-Latn-RU", "==", "ru-Latn-RU", true)]
		[TestCase("ru-Latn-RU", "!=", "ru-Latn-US", true)]
		[TestCase("ru-Latn-RU", "<=", "ru-Latn-US", false)]
		[TestCase("ru-Latn-RU", ">=", "ru-Latn-US", false)]
		[TestCase("ru-Latn-RU", "!=", "ru-Latn", true)]
		[TestCase("ru-Latn", "==", "ru-Latn", true)]
		[TestCase("ru-Latn", "!=", "ru-Zzzz", true)]
		[TestCase("ru-Latn", "<=", "ru-Zzzz", false)]
		[TestCase("ru-Latn", ">=", "ru-Zzzz", false)]
		[TestCase("ru-Latn", "!=", "ru", true)]
		[TestCase("ru-Latn", ">=", "ru", true)]
		[TestCase("ru-Latn", "<=", "ru", false)]
		public void Operators(string xText, string operatorText, string yText, bool expected)
		{
			var x = LanguageTag.Parse(xText);
			var y = LanguageTag.Parse(yText);

			switch(operatorText)
			{
				case ">=":
					Assert.That(x >= y, Is.EqualTo(expected));
					break;
				case "<=":
					Assert.That(x <= y, Is.EqualTo(expected));
					break;
				case "==":
					Assert.That(x == y, Is.EqualTo(expected));
					break;
				case "!=":
					Assert.That(x != y, Is.EqualTo(expected));
					break;
				default:
					throw new NotImplementedException();
			}
		}

		[TestCase("xxx")]
		[TestCase("xxx-")]
		[TestCase("ar-")]
		[TestCase("ar-xxx")]
		[TestCase("ar-xxx-")]
		[TestCase("xx-xxx-")]
		[TestCase("afb-xxx")]
		[TestCase("ar-afb-")]
		[TestCase("ar-afb-xxx")]
		[TestCase("sl-rozaj-biske-1996")]
		[TestCase("sl-1994")]
		[TestCase("sl-rozaj-fonipa-biske-1994")]
		[TestCase("sl-rozaj-a")]
		[TestCase("sl-rozaj-a-")]
		[TestCase("sl-rozaj-a-b")]
		[TestCase("sl-rozaj-a-aaa-b")]
		[TestCase("sl-rozaj-a-aaa-a-bbb")]
		[TestCase("x-aaa-")]
		[TestCase("x-aaa-?")]
		[TestCase("en-x-aaa-")]
		[TestCase("en-x-aaa-?")]
		[ExpectedException(typeof(FormatException))]
		public void Parse_Fail(string text)
		{
			LanguageTag.Parse(text);
		}

		[Test]
		public void TryParse_Success()
		{
			LanguageTag? tag1 = LanguageTag.TryParse("en-GB");

			LanguageTag tag2;
			var result = LanguageTag.TryParse("en-GB", out tag2);

			Assert.That(result, Is.True);
			Assert.That(tag1, Is.EqualTo(tag2));
		}

		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa-", "ru-Latn-RU-Petr1708-a-aaa")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa-?", "ru-Latn-RU-Petr1708-a-aaa")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-b-?", "ru-Latn-RU-Petr1708-a-aaa")]
		[TestCase("ru-Latn-RU-Petr1708-?", "ru-Latn-RU-Petr1708")]
		[TestCase("ru-Latn-RU-?", "ru-Latn-RU")]
		[TestCase("ru-Latn-?", "ru-Latn")]
		[TestCase("ru-?", "ru")]
		public void TryParse_Fail(string text, string expected)
		{
			Assert.That(LanguageTag.TryParse(text).HasValue, Is.False);

			LanguageTag tag;
			var result = LanguageTag.TryParse(text, out tag);

			Assert.That(result, Is.False);
			Assert.That(tag, Is.EqualTo(LanguageTag.Parse(expected)));
		}

		[TestCase("zh-CHS", "zh-Hans")]
		[TestCase("zh-CHT", "zh-Hant")]
		public void ParseAdditionalGrandfathered(string text, string expected)
		{
			Assert.AreEqual(new LanguageTag(expected), new LanguageTag(text));
		}

		[TestCaseSource(typeof(TestContent), "GetGrandfathered")]
		public void ParseGrandfathered(string grandfathered)
		{
			Assert.True(new LanguageTag(grandfathered).Language.HasValue);
		}

		[TestCaseSource(typeof(TestContent), "GetGrandfatheredNotSupported")]
		[ExpectedException(typeof(NotSupportedException))]
		public void GrandfatheredNotSupported(string grandfathered)
		{
			LanguageTag.Parse(grandfathered);
		}

		[TestCase("", "")]
		[TestCase("zh-CHS", "zh-Hans")]
		[TestCase("sl-rozaj-biske-1994-fonipa", "sl-rozaj-biske-1994-fonipa")]
		[TestCase("SL-rozaj-fonipa-alalc97", "sl-rozaj-alalc97-fonipa")]
		[TestCase("EN-LATN-GB", "en-GB")]
		[TestCase("Ru-Cyrl-ru", "ru-RU")]
		[TestCase("en-BU", "en-MM")]
		[TestCase("en-BU", "en-MM")]
		[TestCase("en-R-Extended-SEQUENCE", "en-r-extended-sequence")]
		[TestCase("en-a-aaa-b-bbb", "en-a-aaa-b-bbb")]
		[TestCase("en-b-bbb-a-aaa", "en-a-aaa-b-bbb")]
		[TestCase("en-x-AAA", "en-x-aaa")]
		[TestCase("X-AaA", "x-aaa")]
		public void ToString(string source, string expected)
		{
			Assert.AreEqual(expected, LanguageTag.Parse(source).ToString());
		}

		[Test]
		public void EqualsAndHashCode()
		{
			var tag1 = LanguageTag.Parse("ru-Latn-RU-Petr1708-a-aaa-x-aaa");
			var tag1c = tag1;

			var tag2 = LanguageTag.Parse("x-bbb");


			Assert.That(tag1, Is.EqualTo(tag1));
			Assert.That(tag1, Is.EqualTo(tag1c));
			Assert.That(tag1.Equals((object)tag1), Is.True);

			Assert.That(tag1, Is.Not.EqualTo(tag2));
			Assert.That(tag1.Equals((object)tag2), Is.False);
			Assert.That(tag1.Equals(null), Is.False);

			Assert.That(tag1.GetHashCode(), Is.EqualTo(tag1.GetHashCode()));
			Assert.That(tag1.GetHashCode(), Is.EqualTo(tag1c.GetHashCode()));
			Assert.That(tag1.GetHashCode(), Is.Not.EqualTo(tag2.GetHashCode()));
		}

		[Test]
		public void Constructor_Pr()
		{
			var tag = new LanguageTag(new PrivateUseSubtags("aaa"));
			var expected = LanguageTag.Parse("x-aaa");
			Assert.That(tag, Is.EqualTo(expected));
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructorString_ArgumentNullException()
		{
			new LanguageTag((string)null);
		}
	}
}
