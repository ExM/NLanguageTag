using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class LanguageTagTests
	{
		[Test]
		public void Playground()
		{
			var en = Language.EN; // English language
			var zh = Language.ZH; // Chinese language

			var latn = Script.Latn; // Latin script
			var hans = Script.Hans; // Han (Simplified variant)

			var tw = Region.TW; // Taiwan, Province of China

			// tag zh-Hans-TW
			var tag1 = new LanguageTag(zh, hans, tw);

			// tag zh-Latn-TW-Pinyin
			var tag2 = new LanguageTag(zh, latn, tw, new []{ Variant.Pinyin });

			// tag en-US-x-twain
			var tag3 = new LanguageTag(en, Region.US, ExtensionSubtag.ForPrivateUse("twain"));
			
			// tag de-DE-u-co-phonebk
			var tag4 = new LanguageTag(Language.DE, Region.DE, new []{ new ExtensionSubtag('u', "co", "phonebk") });

			var tag5 = LanguageTag.Parse("ru");
			var tag6 = LanguageTag.Parse("zh-Hans-TW");
			var tag7 = LanguageTag.Parse("en-GB-scotland");
			
			Assert.That(tag1 == tag6, Is.True);
			
			// zh-Hans-TW -> zh-Hans
			var tag8 = tag6.Take(LanguageTag.Field.Language | LanguageTag.Field.Script);
			
			// zh-Hans is subset of zh-Hans-TW
			Assert.That(tag8.IsSubsetOf(tag6), Is.True);
		}
		
		[TestCaseSource(nameof(SimpleParseCases))]
		public void SimpleParse(string text, Language langEx, Script scrEx, Region regionEx)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Language, Is.EqualTo(langEx));
			Assert.That(tag.Script, Is.EqualTo(scrEx));
			Assert.That(tag.Region, Is.EqualTo(regionEx));
			Assert.That(tag.Variants, Is.Empty);
			Assert.That(tag.Extensions, Is.Empty);
			Assert.That(tag.PrivateUse, Is.Empty);
		}

		internal static IEnumerable<TestCaseData> SimpleParseCases()
		{
			yield return new TestCaseData("en", Language.EN, null, null);
			yield return new TestCaseData("qaa", Language.Parse("qaa"), null, null);
			yield return new TestCaseData("en-Latn", Language.EN, null, null);
			yield return new TestCaseData("ru-Latn", Language.RU, Script.Latn, null);
			yield return new TestCaseData("qaa-Latn", Language.Parse("qaa"), Script.Latn, null);
			yield return new TestCaseData("afb", Language.AFB, null, null);
			yield return new TestCaseData("ar-afb", Language.AFB, null, null);
			yield return new TestCaseData("yue", Language.YUE, null, null);
			yield return new TestCaseData("zh-yue", Language.YUE, null, null);
			yield return new TestCaseData("ru-Latn", Language.RU, Script.Latn, null);
			yield return new TestCaseData("zh-Hans", Language.ZH, Script.Hans, null);
			yield return new TestCaseData("zh-TW", Language.ZH, null, Region.TW);
			yield return new TestCaseData("zh-QM", Language.ZH, null, Region.Parse("QM"));
			yield return new TestCaseData("zh-Hans-TW", Language.ZH, Script.Hans, Region.TW);
			yield return new TestCaseData("zh-Qabx-TW", Language.ZH, Script.Parse("Qabx"), Region.TW);
		}

		[TestCaseSource(nameof(containsPrivateUseSubtagsCases))]
		public void ContainsPrivateUseSubtags(string text, bool expected)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.ContainsPrivateUseSubtags, Is.EqualTo(expected));
		}

		internal static IEnumerable<TestCaseData> containsPrivateUseSubtagsCases()
		{
			yield return new TestCaseData("en", false);
			yield return new TestCaseData("qaa", true);
			yield return new TestCaseData("en-Latn", false);
			yield return new TestCaseData("qaa-Latn", true);
			yield return new TestCaseData("zh-TW", false);
			yield return new TestCaseData("zh-QM", true);
			yield return new TestCaseData("zh-Hans-TW", false);
			yield return new TestCaseData("zh-Qabx-TW", true);
			yield return new TestCaseData("zh-Hans-TW-x-aaa", true);
		}

		[TestCaseSource(nameof(containsDeprecatedSubtagsCases))]
		public void ContainsDeprecatedSubtags(string text, bool expected)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.ContainsDeprecatedSubtags, Is.EqualTo(expected));
		}

		internal static IEnumerable<TestCaseData> containsDeprecatedSubtagsCases()
		{
			yield return new TestCaseData("en", false);
			yield return new TestCaseData("ais", true);
			yield return new TestCaseData("en-Latn", false);
			yield return new TestCaseData("ais-Latn", true);
			yield return new TestCaseData("zh-TW", false);
			yield return new TestCaseData("zh-AN", true);
			yield return new TestCaseData("hy", false);
			yield return new TestCaseData("hy-Arevela", true);
		}

		[TestCase("en", new string[]{})]
		[TestCase("en-scotland", new[] { "scotland" })]
		[TestCase("en-GB-scotland", new[] { "scotland" })]
		[TestCase("sl-rozaj", new[] { "rozaj" })]
		[TestCase("sl-rozaj-biske", new[] { "rozaj", "biske" })]
		[TestCase("sl-rozaj-biske-1994", new[] { "rozaj", "biske", "1994" })]
		[TestCase("sl-rozaj-1994", new[] { "rozaj", "1994" })]
		[TestCase("sl-rozaj-biske-1994-fonipa", new[] { "rozaj", "biske", "1994", "fonipa" })]
		[TestCase("sl-rozaj-biske-1994-fonipa-fonipa", new[] { "rozaj", "biske", "1994", "fonipa" })]
		public void ParseWithVariants(string text, string[] variantsEx)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Variants, Is.EquivalentTo(variantsEx.Select(_ => _.TryParseVariant())));
		}

		[TestCase("sl-rozaj-a-bbb-ccc", new[]{ 'a'})]
		[TestCase("sl-rozaj-a-bbb-ccc-b-aaa", new[] { 'a', 'b' })]
		[TestCase("sl-rozaj-b-bbb-ccc-a-aaa", new[] { 'a', 'b' })]
		public void ParseWithExtensions(string text, char[] singletones)
		{
			var tag = LanguageTag.Parse(text);
			Assert.That(tag.Extensions.Select(_ => _.Singleton), Is.EquivalentTo(singletones));
		}

		[TestCase("en", "en-scotland", true)]
		[TestCase("sl-rozaj-biske-1994", "sl-US-rozaj-biske-1994-fonipa", true)]
		[TestCase("en-scotland", "en-GB", false)]
		[TestCase("it", "en-GB", false)]
		[TestCase("en-a-aaa", "en-a-aaa-b-bbb", true)]
		[TestCase("en-b-bbb", "en-a-aaa-b-bbb", true)]
		[TestCase("en-a-aaa-b-bbb", "en-a-aaa-b-bbb", true)]
		[TestCase("en-a-aaa-b-bbb", "en-b-bbb", false)]
		[TestCase("en-a-aaa-b-bbb", "en-a-aaa-b-ccc", false)]
		public void IsSubsetOf(string x, string y, bool expected)
		{
			var xTag = LanguageTag.Parse(x);
			var yTag = LanguageTag.Parse(y);

			Assert.That(xTag.IsSubsetOf(yTag), Is.EqualTo(expected));
		}

		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.All ^ LanguageTag.Field.PrivateUse, "ru-Latn-RU-Petr1708-a-aaa")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.Primary, "ru-Latn-RU")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.Language, "ru")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.Language | LanguageTag.Field.Region, "ru-RU")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.Enumerated, "ru-Latn-RU-Petr1708")]
		[TestCase("x-aaa", LanguageTag.Field.PrivateUse, "x-aaa")]
		[TestCase("en-x-aaa", LanguageTag.Field.PrivateUse, "x-aaa")]
		public void Take(string tagSource, LanguageTag.Field fields, string expected)
		{
			Assert.That(LanguageTag.Parse(tagSource).Take(fields), Is.EqualTo(LanguageTag.Parse(expected)));
		}

		[TestCase("x-aaa", LanguageTag.Field.Language)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", (byte)255)]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa", LanguageTag.Field.None)]
		public void TakeNone(string tagSource, LanguageTag.Field fields)
		{
			Assert.That(LanguageTag.Parse(tagSource).Take(fields), Is.EqualTo(new LanguageTag()));
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
					Assert.That(y.IsSubsetOf(x), Is.EqualTo(expected));
					break;
				case "<=":
					Assert.That(x.IsSubsetOf(y), Is.EqualTo(expected));
					break;
				case "==":
					Assert.That(x == y, Is.EqualTo(expected));
					break;
				case "!=":
					Assert.That(x != y, Is.EqualTo(expected));
					break;
				default:
					throw new ApplicationException("Invalid test case");
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
		[TestCase("en-fonipa-")]
		[TestCase("en-GB-")]
		[TestCase("-en-GB")]
		[TestCase("-x-aaa")]
		[TestCase("en-Latn-")]
		[TestCase("sl-rozaj-a-b")]
		[TestCase("sl-rozaj-a-aaa-b")]
		[TestCase("sl-rozaj-a-aaa-a-bbb")]
		[TestCase("x-aaa-")]
		[TestCase("x-aaa-?")]
		[TestCase("en-x-aaa-")]
		[TestCase("en-x-aaa-?")]
		[TestCase("en-?-aaa")]
		public void Parse_Fail(string text)
		{
			Assert.Throws<FormatException>(() => LanguageTag.Parse(text));
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

		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa-")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-x-aaa-?")]
		[TestCase("ru-Latn-RU-Petr1708-a-aaa-b-?")]
		[TestCase("ru-Latn-RU-Petr1708-?")]
		[TestCase("ru-Latn-RU-?")]
		[TestCase("ru-Latn-?")]
		[TestCase("ru-?")]
		public void TryParse_Fail(string text)
		{
			Assert.That(LanguageTag.TryParse(text).HasValue, Is.False);

			var result = LanguageTag.TryParse(text, out var tag);

			Assert.That(result, Is.False);
			Assert.That(tag, Is.EqualTo(default(LanguageTag)));
		}

		[TestCase("zh-CHS", "zh-Hans")]
		[TestCase("zh-CHT", "zh-Hant")]
		public void ParseAdditionalGrandfathered(string text, string expected)
		{
			Assert.That(LanguageTag.Parse(text), Is.EqualTo(LanguageTag.Parse(expected)));
		}

		[TestCaseSource(typeof(TestContent), nameof(TestContent.GetGrandfathered))]
		public void ParseGrandfathered(string grandfathered)
		{
			Assert.That(LanguageTag.Parse(grandfathered).Language, Is.Not.Null);
		}

		[TestCaseSource(typeof(TestContent), nameof(TestContent.GetGrandfatheredNotSupported))]
		public void GrandfatheredNotSupported(string grandfathered)
		{
			Assert.Throws<NotSupportedException>(() => LanguageTag.Parse(grandfathered));
		}

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
			Assert.That(LanguageTag.Parse(source).ToString(), Is.EqualTo(expected));
		}

		[Test]
		public void EmptyToString()
		{
			Assert.That(new LanguageTag().ToString(), Is.Empty);
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
			var tag = new LanguageTag(new ExtensionSubtag('x', "aaa"));
			var expected = LanguageTag.Parse("x-aaa");
			Assert.That(tag, Is.EqualTo(expected));
		}

		[TestCase("")]
		[TestCase(" ")]
		public void ParsingEmptyString(string text)
		{
			Assert.Throws<FormatException>(() => LanguageTag.Parse(text));
		}

		[Test]
		public void ParsingNullString()
		{
			Assert.Throws<ArgumentNullException>(() => LanguageTag.Parse(null));
		}

		[Test]
		public void DefaultConstructor()
		{
			var tag = new LanguageTag();
			Assert.That(tag.Fields, Is.EqualTo(LanguageTag.Field.None));
		}
	}
}