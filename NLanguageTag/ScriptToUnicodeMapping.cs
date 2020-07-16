using System.Collections.Generic;

namespace NLanguageTag
{
	/// <summary>
	/// Mapping of scripts to Unicode characters
	/// </summary>
	public static class ScriptToUnicodeMapping
	{
		/// <summary>
		/// Tries to get Unicode set that corresponds to the given script. Success is not guaranteed, neither is
		/// a perfect mapping.
		/// </summary>
		/// <param name="script">the script</param>
		/// <param name="result">the Unicode set corresponding to the script, if the operations succeeded</param>
		/// <returns>true, if the operation succeeded; otherwise false</returns>
		public static bool TryGet(Script script, out IUnicodeSet result)
		{
			return _sets.TryGetValue(script, out result);
		}

		private static readonly Dictionary<Script, IUnicodeSet> _sets = new Dictionary<Script, IUnicodeSet>
		{
			[Script.Armn] = new ArmenianSet(),
			[Script.Cyrl] = new CyrillicSet(),
			[Script.Geor] = new GeorgianSet(),
			[Script.Grek] = new GreekSet(),
			[Script.Latn] = new LatinSet(),
			[Script.Ethi] = new EthiopicSet(),
			[Script.Arab] = new ArabicSet(),
			[Script.Hebr] = new HebrewSet(),
			[Script.Hans] = new HanSet(),
			[Script.Hant] = new HanSet(),
			[Script.Jpan] = new JapaneseSet(),
			[Script.Kore] = new KoreanSet(),
			[Script.Tibt] = new TibetanSet(),
			[Script.Beng] = new BengaliSet(),
			[Script.Deva] = new DevanagariSet(),
			[Script.Gujr] = new GujaratiSet(),
			[Script.Guru] = new GurmukhiSet(),
			[Script.Knda] = new KannadaSet(),
			[Script.Mlym] = new MalayalamSet(),
			[Script.Sinh] = new SinhaleseSet(),
			[Script.Taml] = new TamilSet(),
			[Script.Telu] = new TeluguSet(),
			[Script.Khmr] = new KhmerSet(),
			[Script.Laoo] = new LaoSet(),
			[Script.Thai] = new ThaiSet()
		};

		// The following was made by looking at https://unicode.org/charts/ and despairing

		private sealed class ArmenianSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x530 <= codePoint && codePoint <= 0x58f // Armenian
					|| 0xfb13 <= codePoint && codePoint <= 0xfb17; // Armenian ligatures
			}
		}

		private sealed class CyrillicSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0400 <= codePoint && codePoint <= 0x04FF // Cyrillic
					|| 0x0500 <= codePoint && codePoint <= 0x052F // Cyrillic Supplement
					|| 0x2de0 <= codePoint && codePoint <= 0x2dff // Cyrillic Extended-A
					|| 0xa640 <= codePoint && codePoint <= 0xa69f // Cyrillic Extended-B
					|| 0x1c80 <= codePoint && codePoint <= 0x1c8f; // Cyrillic Extended-C
			}
		}

		private sealed class GeorgianSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x10a0 <= codePoint && codePoint <= 0x10ff // Georgian
					|| 0x1c90 <= codePoint && codePoint <= 0x1cbf // Georgian Extended
					|| 0x2d00 <= codePoint && codePoint <= 0x2d2f; // Georgian Supplement
			}
		}

		private sealed class GreekSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0370 <= codePoint && codePoint <= 0x03e1 // Greek and Coptic, before Coptic
					|| 0x03f0 <= codePoint && codePoint <= 0x03ff // Greek and Coptic, after Coptic
					|| 0x1f00 <= codePoint && codePoint <= 0x1fff; // Greek Extended
			}
		}

		private sealed class LatinSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0000 <= codePoint && codePoint <= 0x024f // Controls, Basic Latin, Latin-1, Latin Extended-A+B
					|| 0x1e00 <= codePoint && codePoint <= 0x1eff // Latin Extended Additional
					|| 0x2c60 <= codePoint && codePoint <= 0x2c7f // Latin Extended-C
					|| 0xa720 <= codePoint && codePoint <= 0xa7ff // Latin Extended-D
					|| 0xab30 <= codePoint && codePoint <= 0xab6f // Latin Extended-E
					|| 0xfb00 <= codePoint && codePoint <= 0xfb06; // Latin ligatures
			}
		}

		private sealed class EthiopicSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x1200 <= codePoint && codePoint <= 0x139f // Ethiopic, Ethiopic Supplement
					|| 0x2d80 <= codePoint && codePoint <= 0x2ddf // Ethiopic Extended
					|| 0xab00 <= codePoint && codePoint <= 0xab2f; // Ethiopic Extended-A
			}
		}

		private sealed class ArabicSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0600 <= codePoint && codePoint <= 0x06ff // Arabic
					|| 0x0750 <= codePoint && codePoint <= 0x077f // Arabic Supplement
					|| 0x08a0 <= codePoint && codePoint <= 0x08ff // Arabic Extended-A
					|| 0xfb50 <= codePoint && codePoint <= 0xfdff // Arabic Presentation Forms-A
					|| 0xfe70 <= codePoint && codePoint <= 0xfeff; // Arabic Presentation Forms-B
			}
		}

		private sealed class HebrewSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0590 <= codePoint && codePoint <= 0x05ff // Hebrew
					|| 0xdb1d <= codePoint && codePoint <= 0xdb4f; // Hebrew presentation forms
			}
		}

		private abstract class CjkSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return ContainsNonHanCodePoint(codePoint)
					|| 0x4e00 <= codePoint && codePoint <= 0x9ffc // CJK Unified Ideographs
					|| 0x2e80 <= codePoint && codePoint <= 0x2fdf // CJK Radicals Supplement, Kangxi Radicals
					|| 0x2ff0 <= codePoint && codePoint <= 0x2fff // Ideographic Description Characters
					|| 0x3000 <= codePoint && codePoint <= 0x303f // CJK Symbols and Punctuation
					|| 0x31c0 <= codePoint && codePoint <= 0x31ef // CJK Strokes
					|| 0x3400 <= codePoint && codePoint <= 0x4dbf // CJK Unified Ideographs Extension A
					|| 0xf900 <= codePoint && codePoint <= 0xfaff // CJK Compatibility Ideographs
					|| 0xff01 <= codePoint && codePoint <= 0xff20 // Fullwidth digits and punctuation
					|| 0xff5b <= codePoint && codePoint <= 0xff64 // Fullwidth and halfwidth punctuation
					|| 0x20000 <= codePoint && codePoint <= 0x2a6dd // CJK Unified Ideographs Extension B
					|| 0x2a700 <= codePoint && codePoint <= 0x2b734 // CJK Unified Ideographs Extension C
					|| 0x2b740 <= codePoint && codePoint <= 0x2b81d // CJK Unified Ideographs Extension D
					|| 0x2b820 <= codePoint && codePoint <= 0x2cea1 // CJK Unified Ideographs Extension E
					|| 0x2ceb0 <= codePoint && codePoint <= 0x2ebe0 // CJK Unified Ideographs Extension F
					|| 0x2f800 <= codePoint && codePoint <= 0x2fa1f // CJK Compatibility Ideographs Supplement
					|| 0x30000 <= codePoint && codePoint <= 0x3134a; // CJK Unified Ideographs Extension G
			}

			protected abstract bool ContainsNonHanCodePoint(int codePoint);
		}

		private sealed class HanSet : CjkSet
		{
			protected override bool ContainsNonHanCodePoint(int codePoint)
			{
				return false;
			}
		}

		private sealed class JapaneseSet : CjkSet
		{
			protected override bool ContainsNonHanCodePoint(int codePoint)
			{
				return 0x3040 <= codePoint && codePoint <= 0x30ff // Hiragana, Katakana
					|| 0x3190 <= codePoint && codePoint <= 0x319f // Kanbun
					|| 0x31f0 <= codePoint && codePoint <= 0x31ff // Katakana Phonetic Extensions
					|| 0xff65 <= codePoint && codePoint <= 0xff9f // Halfwidth Katakana variants
					|| 0x1b000 <= codePoint && codePoint <= 0x1b16f; // Kana Supplement, Kana Extended-A, Small Kana Extension
			}
		}

		private sealed class KoreanSet : CjkSet
		{
			protected override bool ContainsNonHanCodePoint(int codePoint)
			{
				return 0x1100 <= codePoint && codePoint <= 0x11ff // Hangul Jamo
					|| 0x3130 <= codePoint && codePoint <= 0x318f // Hangul Compatibility Jamo
					|| 0xa960 <= codePoint && codePoint <= 0xa97f // Hangul Jamo Extended-A
					|| 0xac00 <= codePoint && codePoint <= 0xd7af // Hangul Syllables
					|| 0xd7b0 <= codePoint && codePoint <= 0xd7ff; // Hangul Jamo Extended-B
			}
		}

		private sealed class TibetanSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0f00 <= codePoint && codePoint <= 0x0fff;
			}
		}

		private sealed class BengaliSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0980 <= codePoint && codePoint <= 0x9ff;
			}
		}

		private sealed class DevanagariSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0900 <= codePoint && codePoint <= 0x097f // Devanagari
					|| 0xa8e0 <= codePoint && codePoint <= 0xa8ff; // Devanagari Extended
			}
		}

		private sealed class GujaratiSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0a80 <= codePoint && codePoint <= 0x0aff;
			}
		}

		private sealed class GurmukhiSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0a00 <= codePoint && codePoint <= 0x0a7f;
			}
		}

		private sealed class KannadaSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0c80 <= codePoint && codePoint <= 0x0cff;
			}
		}

		private sealed class MalayalamSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0d00 <= codePoint && codePoint <= 0x0d7f;
			}
		}

		private sealed class SinhaleseSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0d80 <= codePoint && codePoint <= 0x0dff;
			}
		}

		private sealed class TamilSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0b80 <= codePoint && codePoint <= 0x0bff;
			}
		}

		private sealed class TeluguSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0c00 <= codePoint && codePoint <= 0x0c7f;
			}
		}

		private sealed class KhmerSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x1780 <= codePoint && codePoint <= 0x17ff // Khmer
					|| 0x19e0 <= codePoint && codePoint <= 0x19ff; // Khmer Symbols
			}
		}

		private sealed class LaoSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0e80 <= codePoint && codePoint <= 0x0eff;
			}
		}

		private sealed class ThaiSet : IUnicodeSet
		{
			public bool ContainsCodePoint(int codePoint)
			{
				return 0x0e00 <= codePoint && codePoint <= 0x0e7f;
			}
		}
	}
}