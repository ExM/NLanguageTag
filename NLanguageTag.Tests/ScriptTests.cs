using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ScriptTests
	{
		[Test]
		public void CheckParseSwitches()
		{
			foreach (var text in TestContent.GetScripts())
			{
				var script = text.TryParseScript();
				Assert.NotNull(script);
			}
		}

		[Test]
		public void CheckPublicCodes()
		{
			foreach (var code in Enum.GetValues(typeof(ScriptCode)).Cast<ScriptCode>()
				.Where(_ => _ != ScriptCode.PrivateUse))
			{
				var script = Script.ByCode(code);
				Assert.IsFalse(script.PrivateUse);
				Assert.AreEqual(code, script.EnumCode);
			}
		}

		[TestCaseSource(nameof(parseCases))]
		public void ParseFromScript(string text, Script expected)
		{
			Assert.AreEqual(expected, text.TryParseScript());
		}

		internal static IEnumerable<TestCaseData> parseCases()
		{
			yield return new TestCaseData("xxx", null);
			yield return new TestCaseData("Hant", Script.Hant);
			yield return new TestCaseData("Hans", Script.Hans);
		}

		[TestCase("Qaaa")]
		[TestCase("Qabx")]
		[TestCase("Qaaz")]
		[TestCase("qaaa")]
		[TestCase("QAAA")]
		public void ParsePrivateUse(string text)
		{
			var script = text.TryParseScript();

			Assert.IsTrue(script.PrivateUse);
			Assert.AreEqual(ScriptCode.PrivateUse, script.EnumCode);
			Assert.AreEqual(script, text.TryParseScript());
		}
	}
}
