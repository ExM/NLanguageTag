using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ScriptToUnicodeMappingTests
	{
		[Test, TestCaseSource(nameof(getTestCases))]
		public void CharactersAreInSet(Script script, string characters)
		{
			Assert.IsTrue(ScriptToUnicodeMapping.TryGet(script, out var set));

			for (var i = 0; i < characters.Length; i++)
			{
				if (char.IsSurrogatePair(characters, i))
				{
					Assert.IsTrue(set.ContainsCharacterDefinedBySurrogatePair(characters[i], characters[i + 1]));
					i++;
				}
				else
				{
					Assert.IsTrue(
						set.ContainsCharacter(characters[i]),
						$"Character U+{(int)characters[i]:x4} ({characters[i]}) is not in the '{script}' set");
				}
			}
		}

		[Test]
		public void CharactersBelongToOnlyOneSetExceptExceptions()
		{
			var scripts = (Script[])Enum.GetValues(typeof(Script));

			for (var i = 0; i < 0x10000; i++)
			{
				var scriptsOfCharacter = new List<Script>();

				foreach (var script in scripts)
				{
					if (ScriptToUnicodeMapping.TryGet(script, out var set))
					{
						if (set.ContainsCodePoint(i))
						{
							scriptsOfCharacter.Add(script);
						}
					}
				}

				Assert.IsTrue(
					scriptsOfCharacter.Count <= 1 || isHanAndDerived(scriptsOfCharacter),
					$"Character U+{i:x4} ({(char)i}) belongs simultaneously to {string.Join(", ", scriptsOfCharacter.Select(s => s.ToString()))}");
			}
		}

		private static bool isHanAndDerived(IReadOnlyCollection<Script> scripts)
		{
			Script[] han = { Script.Hans, Script.Hant };
			if (scripts.Intersect(han).Distinct().Count() != han.Length)
			{
				return false;
			}

			foreach (var rest in scripts.Except(han))
			{
				switch (rest)
				{
					case Script.Jpan:
					case Script.Kore:
						break;
					default:
						return false;
				}
			}

			return true;
		}

		private static IEnumerable<ITestCaseData> getTestCases()
		{
			return new ITestCaseData[]
			{
				new TestCaseData(Script.Armn, "Հայաստան"),
				new TestCaseData(Script.Cyrl, "Автомотовелофототелерадиолюбитель"),
				new TestCaseData(Script.Geor, "საქართველო"),
				new TestCaseData(Script.Grek, "ΒασιλείαῬωμαίων"),
				new TestCaseData(Script.Latn, "The quick brown fox jumps over a lazy dog."),
				new TestCaseData(Script.Ethi, "ኢትዮጵያ"),
				new TestCaseData(Script.Arab, "\u0627\u0644\u062e\u0648\u0627\u0631\u0632\u0645\u064a"),
				new TestCaseData(Script.Hebr, "\u05d9\u05b4\u05e9\u05b0\u05c2\u05e8\u05b8\u05d0\u05b5\u05dc"),
				new TestCaseData(Script.Hans, "孫子曰：兵者，國之大事，死生之地，存亡之道，不可不察也。"),
				new TestCaseData(Script.Hant, "廣義的絲綢之路指從上古開始陸續形成的。"),
				new TestCaseData(Script.Jpan, "片仮名（かたかな）"),
				new TestCaseData(Script.Kore, "한국韓國조선朝鮮"),
				new TestCaseData(Script.Tibt, "བོད་ཡུལ།"),
				new TestCaseData(Script.Beng, "বাংলাদেশ"),
				new TestCaseData(Script.Deva, "विजयनगर"),
				new TestCaseData(Script.Gujr, "ગુજરાત"),
				new TestCaseData(Script.Guru, "ਪਾਕਿਸਤਾਨ"),
				new TestCaseData(Script.Knda, "ವಿಜಯನಗರ"),
				new TestCaseData(Script.Mlym, "വിജയനഗര"),
				new TestCaseData(Script.Sinh, "ලංකාව"),
				new TestCaseData(Script.Taml, "தமிழகம்"),
				new TestCaseData(Script.Telu, "విజయనగర"),
				new TestCaseData(Script.Khmr, "ព្រះរាជាណាចក្រកម្ពុជា"),
				new TestCaseData(Script.Laoo, "ປະເທດລາວ"),
				new TestCaseData(Script.Thai, "ประเทศไทย"),
				new TestCaseData(Script.Hans, "\ud86e\udc20\ud873\udeb0\ud884\udf4a")
			};
		}
	}
}