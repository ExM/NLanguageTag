using NUnit.Framework;
using System;

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
				Assert.NotNull(script!.Value.ToText());
			}
		}

		[Test]
		public void ToTextFail()
		{
			Assert.Throws<NotImplementedException>(() =>
			{
				var en = (Script)(-1);
				en.ToText();
			});
		}

		[TestCase("xxx", null)]
		[TestCase("Hant", Script.Hant)]
		[TestCase("Hans", Script.Hans)]
		public void ParseFromScript(string text, Script? expected)
		{
			Assert.AreEqual(expected, text.TryParseScript());
		}
	}
}