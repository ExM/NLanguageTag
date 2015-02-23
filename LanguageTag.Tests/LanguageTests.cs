using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
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

		[TestCase("afb", Language.AFB, 3)]
		[TestCase("en-GB", Language.EN, 3)]
		[TestCase("ar-afb", Language.AFB, 6)]
		[TestCase("yue", Language.YUE, 3)]
		[TestCase("yue-GB", Language.YUE, 4)]
		[TestCase("zh-yue", Language.YUE, 6)]
		[TestCase("zh-yue-Hans", Language.YUE, 7)]
		public void TryParseFromLanguageToken(string text, Language expected, int expNextToken)
		{
			int nextToken;
			Assert.AreEqual(expected, text.ParseFromLanguageToken(out nextToken));
			Assert.AreEqual(expNextToken, nextToken);
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
		[ExpectedException(typeof(FormatException))]
		public void ParseFromLanguage_Fail(string text)
		{
			text.ParseFromLanguage();
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
