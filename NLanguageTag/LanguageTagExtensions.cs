using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// 
	/// </summary>
	public static partial class LanguageTagExtensions
	{
		internal static Script? TryParseScript(this LanguageTag.TokenEnumerator tokens)
		{
			var script = tokens.Token.TryParseFromScript();

			if (script != null)
				tokens.ToNextToken();

			return script;
		}

		internal static Region? TryParseRegion(this LanguageTag.TokenEnumerator tokens)
		{
			var region = tokens.Token.TryParseFromRegion();

			if (region != null)
				tokens.ToNextToken();

			return region;
		}

		internal static Variant? TryParseVariant(this LanguageTag.TokenEnumerator tokens)
		{
			if (!tokens.CurrentTokenAvailable)
				return null;

			var variant = tokens.Token.TryParseFromVariant();

			if (variant != null)
				tokens.ToNextToken();

			return variant;
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

		internal static bool? RestrictiveAcceptableFor(this Variant v, Language? lang, Script? script, IEnumerable<Variant> variants)
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
			try
			{
				var tokens = new LanguageTag.TokenEnumerator(text);
				var result = ParseLanguage(tokens);
				if(tokens.CurrentTokenAvailable)
					throw new FormatException("unexpected language '" + tokens.Token + "'");

				return result;
			}
			catch(FormatException ex)
			{
				throw new FormatException("unexpected language '" + text + "'", ex);
			}
		}

		internal static Language ParseLanguage(this LanguageTag.TokenEnumerator tokens)
		{
			if (!tokens.NextTokenAvailable)
			{
				var result = tokens.Token.TryParseFromLanguage();
				if (!result.HasValue)
					throw new FormatException("unexpected language '" + tokens.Token + "'");

				tokens.ToNextToken();
				return result.Value;
			}

			var lang = tokens.Token.TryParseFromLanguage();
			if (lang == null)
				throw new FormatException("unexpected language '" + tokens.Token + "'");

			tokens.ToNextToken();

			if (!lang.Value.ExtLanguageAvailable())
				return lang.Value;

			var extLang = tokens.Token.TryParseFromExtLanguage(lang.Value);
			if (extLang == null)
				return lang.Value;

			tokens.ToNextToken();
			return extLang.Value;
		}

		public static ExtensionSubtag ParseFromExtensionSubtag(this string text)
		{
			var result = ExtensionSubtag.TryParse(new LanguageTag.TokenEnumerator(text));
			if (result.HasValue)
				return result.Value;

			throw new FormatException("unexpected extension subtag '" + text + "'");
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
	}
}
