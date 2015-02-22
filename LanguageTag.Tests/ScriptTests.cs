using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	[TestFixture]
	public class ScriptTests
	{
		[TestCaseSource("allScripts")]
		public void ToString_Parse(Script script)
		{
			var text = script.ToText();
			Assert.AreEqual(script, text.ParseFromScript());
		}

		private IEnumerable<Script> allScripts()
		{
			return Enum.GetValues(typeof(Script)).Cast<Script>();
		}

		[TestCase("Hant", Script.Hant)]
		[TestCase("Hans", Script.Hans)]
		public void ParseFromScript(string text, Script expected)
		{
			Assert.AreEqual(expected, text.ParseFromScript());
		}

		[TestCase("xxx")]
		[TestCase("xxx-xxx")]
		[TestCase("xxx-")]
		[ExpectedException(typeof(FormatException))]
		public void ParseFromScript_Fail(string text)
		{
			text.ParseFromScript();
		}

		[TestCase("???-xxx-xx", 4, null, 4)]
		[TestCase("???-Hans", 4, Script.Hans, 8)]
		[TestCase("???-Hans-", 4, Script.Hans, 9)]
		[TestCase("???-Hans-xx", 4, Script.Hans, 9)]
		public void TryParseFromLanguageToken(string text, int begin, Script? expected, int expNextToken)
		{
			int nextToken = begin;
			Assert.AreEqual(expected, text.TryParseFromScriptToken(ref nextToken));
			Assert.AreEqual(expNextToken, nextToken);
		}
	}
}
