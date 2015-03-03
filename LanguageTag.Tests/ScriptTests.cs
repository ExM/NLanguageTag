using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class ScriptTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetScripts())
			{
				var script = text.TryParseFromScript().Value;
				Assert.NotNull(script.ToText());
			}
		}

		[Test]
		[ExpectedException(typeof(NotImplementedException))]
		public void ToTextFail()
		{
			var en = (Script)(-1);
			en.ToText();
		}

		[TestCase("xxx", null)]
		[TestCase("Hant", Script.Hant)]
		[TestCase("Hans", Script.Hans)]
		public void ParseFromScript(string text, Script? expected)
		{
			Assert.AreEqual(expected, text.TryParseFromScript());
		}
	}
}
