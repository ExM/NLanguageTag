using NUnit.Framework;
using System;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class LanguageTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetLanguages())
			{
				var lang = text.ParseFromLanguage();

				lang.GetSupressScript();
				lang.GetMacrolanguage();
				lang.GetPrefix();
				lang.GetScope();

				Assert.NotNull(lang.ToText());
			}

			foreach (var text in TestContent.GetExtLanguages())
			{
				var lang = text.ParseFromLanguage();

				Assert.AreEqual(text, lang.ToExtLanguage());
			}

			Assert.IsFalse("xxx".TryParseFromExtLanguage((Language)(-1)).HasValue);
		}

		[Test]
		public void ToTextFail()
		{
			Assert.Throws<NotImplementedException>(() =>
			{
				var en = (Language)(-1);
				en.ToText();
			});
		}

		[TestCase("afb", Language.AFB)]
		[TestCase("ar-afb", Language.AFB)]
		[TestCase("yue", Language.YUE)]
		[TestCase("zh-yue", Language.YUE)]
		[TestCase("ccq", Language.RKI)]
		[TestCase("iw", Language.HE)]
		public void ParseFromLanguage(string text, Language expected)
		{
			Assert.AreEqual(expected, text.ParseFromLanguage());
		}

		[TestCase(Language.AFB, "afb")]
		[TestCase(Language.YUE, "yue")]
		[TestCase(Language.RKI, "rki")]
		[TestCase(Language.HE, "he")]
		public void ParseFromLanguage(Language lang, string expected)
		{
			Assert.AreEqual(expected, lang.ToText());
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
			Assert.Throws<FormatException>(() => text.ParseFromLanguage());
		}

		[TestCase(Language.AFB, "ar-afb")]
		[TestCase(Language.YUE, "zh-yue")]
		[TestCase(Language.EN, "en")]
		public void ToExtLanguage(Language lang, string expExtLang)
		{
			Assert.AreEqual(expExtLang, lang.ToExtLanguage());
		}
	}
}
