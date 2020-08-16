using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ScriptTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetScripts())
			{
				var script = text.TryParseScript();
				Assert.NotNull(script);
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
			Assert.AreEqual(script, text.TryParseScript());
		}
	}
}