using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class LanguageTests
	{
		[Test]
		public void CheckParseSwitches()
		{
			foreach (var text in TestContent.GetLanguages())
			{
				var lang = parseLanguage(text);
				Assert.That(lang, Is.Not.Null);
			}

			foreach (var text in TestContent.GetExtLanguages())
			{
				var lang = parseLanguage(text);
				Assert.That(lang.ToExtLanguage(), Is.EqualTo(text));
			}
		}

		[Test]
		public void CheckPublicCodes()
		{
			foreach (var code in Enum.GetValues(typeof(LanguageCode)).Cast<LanguageCode>()
				.Where(_ => _ != LanguageCode.PrivateUse))
			{
				var lang = Language.ByCode(code);
				Assert.That(lang.PrivateUse, Is.False);
				Assert.That(lang.EnumCode, Is.EqualTo(code));
			}
		}

		internal static IEnumerable<TestCaseData> parseFromLanguageCases()
		{
			yield return new TestCaseData("afb", Language.AFB);
			yield return new TestCaseData("ar-afb", Language.AFB);
			yield return new TestCaseData("yue", Language.YUE);
			yield return new TestCaseData("zh-yue", Language.YUE);
			yield return new TestCaseData("ccq", Language.RKI);
			yield return new TestCaseData("iw", Language.HE);
		}

		[TestCaseSource(nameof(parseFromLanguageCases))]
		public void ParseFromLanguage(string text, Language expected)
		{
			Assert.That(parseLanguage(text), Is.EqualTo(expected));
		}

		internal static IEnumerable<TestCaseData> languageToStringCases()
		{
			yield return new TestCaseData(Language.AFB, "afb");
			yield return new TestCaseData(Language.YUE, "yue");
			yield return new TestCaseData(Language.RKI, "rki");
			yield return new TestCaseData(Language.HE, "he");
		}

		[TestCaseSource(nameof(languageToStringCases))]
		public void LanguageToString(Language lang, string expected)
		{
			Assert.That(lang.ToString(), Is.EqualTo(expected));
		}

		[TestCase("")]
		[TestCase("xxx")]
		[TestCase("-xxx")]
		[TestCase("xxx-")]
		[TestCase("ar-")]
		[TestCase("ar-xxx")]
		[TestCase("ar-xxx-")]
		[TestCase("xx-xxx-")]
		[TestCase("afb-xxx")]
		[TestCase("ar-afb-")]
		[TestCase("ar-afb-xxx")]
		[TestCase("sgn-xxx")]
		[TestCase("ms-xxx")]
		[TestCase("zh-xxx")]
		[TestCase("kok-xxx")]
		[TestCase("lv-xxx")]
		[TestCase("sw-xxx")]
		[TestCase("uz-xxx")]
		[TestCase("en-xxx")]
		[TestCase("zh-yue-Hans")]
		public void ParseFromLanguage_Fail(string text)
		{
			Assert.Throws<FormatException>(() => parseLanguage(text));
		}

		[TestCase("qaa")]
		[TestCase("qtz")]
		[TestCase("qba")]
		[TestCase("qBa")]
		[TestCase("Qba")]
		public void ParsePrivateUse(string text)
		{
			var lang = Language.Parse(text);

			Assert.That(lang.PrivateUse, Is.True);
			Assert.That(lang.EnumCode, Is.EqualTo(LanguageCode.PrivateUse));
			Assert.That(Language.Parse(text), Is.EqualTo(lang));
		}

		internal static IEnumerable<TestCaseData> toExtLanguageCases()
		{
			yield return new TestCaseData(Language.AFB, "ar-afb");
			yield return new TestCaseData(Language.YUE, "zh-yue");
			yield return new TestCaseData(Language.EN, "en");
		}

		[TestCaseSource(nameof(toExtLanguageCases))]
		public void ToExtLanguage(Language lang, string expExtLang)
		{
			Assert.That(lang.ToExtLanguage(), Is.EqualTo(expExtLang));
		}

		private static Language parseLanguage(string text)
		{
			if (!LanguageTag.TryParse(text, out var languageTag))
				throw new FormatException($"Cannot parse language from `{text}'");

			if ((languageTag.Fields & ~LanguageTag.Field.Language) != 0)
				throw new FormatException($"Tag contains more than just language `{text}'");

			if (languageTag.Language != null)
				return languageTag.Language;

			throw new FormatException($"Tag does not contain language `{text}'");
		}
	}
}