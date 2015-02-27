using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public static partial class LanguageTagExtensions
	{
		public static Script ParseFromScript(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromScriptToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected script code '" + text + "'");
		}

		public static Script? TryParseFromScriptToken(this string text, ref int tokenIndex)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator, tokenIndex);

			var token = (pos == -1) ?
				text.Substring(tokenIndex) :
				text.Substring(tokenIndex, pos - tokenIndex);

			var script = token.TryParseFromScript();

			if (script != null)
				tokenIndex = (pos == -1) ? text.Length : pos + 1;

			return script;
		}

		public static Region ParseFromRegion(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromRegionToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected region '" + text + "'");
		}

		public static Region? TryParseFromRegionToken(this string text, ref int tokenIndex)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator, tokenIndex);

			var token = (pos == -1) ?
				text.Substring(tokenIndex) :
				text.Substring(tokenIndex, pos - tokenIndex);

			var script = token.TryParseFromRegion();

			if (script != null)
				tokenIndex = (pos == -1) ? text.Length : pos + 1;

			return script;
		}

		public static Variant ParseFromVariant(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromVariantToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected variant code '" + text + "'");
		}

		public static Variant? TryParseFromVariantToken(this string text, ref int tokenIndex)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator, tokenIndex);

			var token = (pos == -1) ?
				text.Substring(tokenIndex) :
				text.Substring(tokenIndex, pos - tokenIndex);

			var result = token.TryParseFromVariant();

			if (result != null)
				tokenIndex = (pos == -1) ? text.Length : pos + 1;

			return result;
		}

		private static readonly ConcurrentDictionary<Variant, LanguageTag[]> _prefixCache = new ConcurrentDictionary<Variant, LanguageTag[]>();

		private static readonly Func<Variant, LanguageTag[]> _prefixesCreater = PrefixesCreater;

		public static LanguageTag[] GetPrefixes(this Variant v)
		{
			return _prefixCache.GetOrAdd(v, _prefixesCreater);
		}

		private static LanguageTag[] PrefixesCreater(Variant v)
		{
			return v.GetTextPrefixes().Select(_ => LanguageTag.Parse(_)).ToArray();
		}

		private static readonly ConcurrentDictionary<Variant, Func<Language?, Script?, IEnumerable<Variant>, bool?>> _isPrefixForCache = new ConcurrentDictionary<Variant, Func<Language?, Script?, IEnumerable<Variant>, bool?>>();

		private static readonly Func<Variant, Func<Language?, Script?, IEnumerable<Variant>, bool?>> _isPrefixForCreater = PrefixForCreater;

		public static bool? RestrictiveAcceptableFor(this Variant v, Language? lang, Script? script, IEnumerable<Variant> variants)
		{
			return _isPrefixForCache.GetOrAdd(v, _isPrefixForCreater)(lang, script, variants);
		}

		private static Func<Language?, Script?, IEnumerable<Variant>, bool?> PrefixForCreater(Variant variant)
		{
			var tags = variant.GetPrefixes();
			if (!tags.Any())
				return (l, s, vs) => false;

			var checkingFields = LanguageTag.Field.None;
			foreach (var tag in tags)
				checkingFields |= tag.Fields;

			return (l, s, vs) =>
			{
				foreach (var tag in tags)
				{
					if (PrefixEquals(l, s, vs, tag, checkingFields))
						return true;
				}

				return null;
			};
		}

		private static bool PrefixEquals(Language? lang, Script? script, IEnumerable<Variant> variants, LanguageTag prefix, LanguageTag.Field checking)
		{
			if (checking.IsSet(LanguageTag.Field.Language) &&
				lang != prefix.Language)
				return false;

			if (checking.IsSet(LanguageTag.Field.Script) &&
				script != prefix.Script)
				return false;

			if (checking.IsSet(LanguageTag.Field.Variants) &&
				!variants.IsEquivalent(prefix.Variants))
				return false;

			return true;
		}

		public static string ToExtLanguage(this Language lang)
		{
			var prefix = lang.GetPrefix();
			if (prefix == null)
				return lang.ToText();

			return prefix.Value.ToText() + LanguageTag.TagSeparator + lang.ToText();
		}

		public static Language ParseFromLanguage(this string text)
		{
			int nextToken;
			var result = text.ParseFromLanguageToken(out nextToken);
			if (text.Length == nextToken)
				return result;

			throw new FormatException("unexpected language '" + text + "'");
		}

		public static Language ParseFromLanguageToken(this string text, out int nextToken)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator);
			if (pos == -1)
			{
				nextToken = text.Length;
				var result = text.TryParseFromLanguage();
				if (!result.HasValue)
					throw new FormatException("unexpected language '" + text + "'");

				return result.Value;
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				throw new FormatException("unexpected language '" + text + "'");

			var firstToken = text.Substring(0, pos);
			var lang = firstToken.TryParseFromLanguage();
			if (lang == null)
				throw new FormatException("unexpected language '" + text + "'");

			if (!lang.Value.ExtLanguageAvailable())
				return lang.Value;

			pos = text.IndexOf(LanguageTag.TagSeparator, nextToken);

			var extLangText = (pos == -1) ?
				text.Substring(nextToken) :
				text.Substring(nextToken, pos - nextToken);

			var extLang = extLangText.TryParseFromExtLanguage(lang.Value);
			if (extLang == null)
				return lang.Value;

			if (pos == -1)
			{
				nextToken = text.Length;
				return extLang.Value;
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				throw new FormatException("unexpected language '" + text + "'");

			return extLang.Value;
		}

		public static ExtensionSubtag ParseFromExtensionSubtag(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromExtensionSubtagToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected extension subtag '" + text + "'");
		}

		public static ExtensionSubtag? TryParseFromExtensionSubtagToken(this string text, ref int tokenIndex)
		{
			var tokenSequence = text.GetTokenSequense(tokenIndex);
			if (!tokenSequence.MoveNext()) // get singletone
				return null;

			if (tokenSequence.Token.Length != 1)
				return null;

			char singletone = Char.ToLowerInvariant(tokenSequence.Token[0]);

			if (singletone == 'x')
				return null;

			if (!tokenSequence.MoveNext()) // get first subtag
				throw new FormatException("extension subtag '" + singletone + "' not contain elements");

			ValidateExtensionSubtagElement(tokenSequence.Token);

			var result = new ExtensionSubtag(singletone, tokenSequence.Token);
			tokenIndex = tokenSequence.NextTokenPosition ?? text.Length;

			while (tokenSequence.MoveNext()) // get remaining elements
			{
				if (tokenSequence.Token.Length == 1) // next extension subtag or private use
					break;

				ValidateExtensionSubtagElement(tokenSequence.Token);
				result.Append(tokenSequence.Token);
				tokenIndex = tokenSequence.NextTokenPosition ?? text.Length;
			}

			return result;
		}

		private static void ValidateExtensionSubtagElement(string text)
		{
			if (text.Length < 2 || 8 < text.Length)
				throw new FormatException("extension subtag must be from 2 to 8 characters");

			if (!text.All(ch => Char.IsLetterOrDigit(ch) && (int)ch < 127))
				throw new FormatException("element must consist only of numbers or letters in ASCII");
		}

		internal static bool IsSet(this LanguageTag.Field checking, LanguageTag.Field test)
		{
			return (checking & test) == test;
		}

		internal static int GetHashCodeOfSequence<T>(this IEnumerable<T> items)
		{
			if (items == null)
				return 0;

			unchecked
			{
				int hash = 19;
				foreach (var i in items)
				{
					hash = hash * 31 + i.GetHashCode();
				}
				return hash;
			}
		}

		internal static bool IsEquivalent<T>(this IList<T> x, IList<T> y) where T : IEquatable<T>
		{
			if (x == null)
				return y == null;

			if (y == null)
				return false;

			if (x.Count != y.Count)
				return false;

			for (int i = 0; i < x.Count; i++)
				if (!x[i].Equals(y[i]))
					return false;

			return true;
		}

		internal static bool IsEquivalent(this IEnumerable<Variant> x, IEnumerable<Variant> y)
		{
			var xEn = x.GetEnumerator();
			var yEn = y.GetEnumerator();

			while (true)
			{
				if(!xEn.MoveNext())
					return !yEn.MoveNext();

				if(!yEn.MoveNext())
					return false;

				if(xEn.Current != yEn.Current)
					return false;
			}
		}

		internal static LanguageTagTokenEnumerator GetTokenSequense(this string text, int start)
		{
			return new LanguageTagTokenEnumerator(text, start);
		}

		internal class LanguageTagTokenEnumerator
		{
			private string _text;

			public LanguageTagTokenEnumerator(string text, int start)
			{
				_text = text;
				NextTokenPosition = start;
				CurrentTokenPosition = start;
			}

			public string Token { get; private set; }

			public int CurrentTokenPosition { get; private set; }

			public int? NextTokenPosition { get; private set; }

			public bool MoveNext()
			{
				if (!NextTokenPosition.HasValue)
					return false;

				int pos = _text.IndexOf(LanguageTag.TagSeparator, NextTokenPosition.Value);

				CurrentTokenPosition = NextTokenPosition.Value;

				if(pos == -1)
				{
					Token = _text.Substring(NextTokenPosition.Value);
					NextTokenPosition = null;
				}
				else
				{
					Token = _text.Substring(NextTokenPosition.Value, pos - NextTokenPosition.Value);
					NextTokenPosition = pos + 1;
				}
				return true;
			}
		}
	}
}
