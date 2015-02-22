using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public static partial class VariantExtensions
	{
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
			if(!tags.Any())
				return (l,s,vs) => false;

			var checkingFields = LanguageTagField.None;
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

		private static bool PrefixEquals(Language? lang, Script? script, IEnumerable<Variant> variants, LanguageTag prefix, LanguageTagField checking)
		{
			if (checking.IsSet(LanguageTagField.Language) &&
				lang != prefix.Language)
				return false;

			if (checking.IsSet(LanguageTagField.Script) &&
				script != prefix.Script)
				return false;

			if (checking.IsSet(LanguageTagField.Variants) &&
				!variants.IsEquivalent(prefix.Variants))
				return false;

			return true;
		}
	}
}
