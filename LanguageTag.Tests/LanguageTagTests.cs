using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class LanguageTagTests
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
		public void Contains(string x, string y, bool expected)
		{
			Assert.That(LanguageTag.Parse(x).Contains(LanguageTag.Parse(y)), Is.EqualTo(expected));
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
		[ExpectedException(typeof(FormatException))]
		public void Parse_Fail(string text)
		{
			LanguageTag.Parse(text);
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

	}
}
