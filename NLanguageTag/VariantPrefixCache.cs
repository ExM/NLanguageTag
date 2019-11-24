using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	internal static class VariantPrefixCache
	{
		public static IReadOnlyCollection<LanguageTag> GetPrefixes(this Variant v)
		{
			return _prefixCache.GetOrAdd(v, _createPrefixes);
		}

		internal static bool? RestrictiveAcceptableFor(
			this Variant variant,
			Language? language,
			Script? script,
			IReadOnlyList<Variant> variants)
		{
			var acceptabilityChecker = _acceptabilityCheckersCache.GetOrAdd(variant, _createAcceptabilityChecker);
			return acceptabilityChecker(language, script, variants);
		}

		private static AcceptabilityChecker createAcceptabilityChecker(Variant variant)
		{
			var tags = GetPrefixes(variant);
			if (tags.Count == 0)
				return (l, s, vs) => false;

			var checkingFields = LanguageTag.Field.None;
			foreach (var tag in tags)
				checkingFields |= tag.Fields;

			return delegate(Language? language, Script? script, IReadOnlyList<Variant> variants)
			{
				foreach (var tag in tags)
				{
					if (prefixEquals(language, script, variants, tag, checkingFields))
						return true;
				}

				return null;
			};
		}

		private static bool prefixEquals(
			Language? lang,
			Script? script,
			IEnumerable<Variant> variants,
			LanguageTag prefix,
			LanguageTag.Field checking)
		{
			if (checking.HasFlag(LanguageTag.Field.Language) && lang != prefix.Language)
				return false;

			if (checking.HasFlag(LanguageTag.Field.Script) && script != prefix.Script)
				return false;

			if (checking.HasFlag(LanguageTag.Field.Variants) && !variants.IsEquivalentTo(prefix.Variants))
				return false;

			return true;
		}

		private static readonly ConcurrentDictionary<Variant, IReadOnlyCollection<LanguageTag>> _prefixCache
			= new ConcurrentDictionary<Variant, IReadOnlyCollection<LanguageTag>>();

		private static readonly ConcurrentDictionary<Variant, AcceptabilityChecker> _acceptabilityCheckersCache
			= new ConcurrentDictionary<Variant, AcceptabilityChecker>();

		private static readonly Func<Variant, IReadOnlyCollection<LanguageTag>> _createPrefixes =
			v => v.GetTextPrefixes().Select(LanguageTag.Parse).ToArray();

		private static readonly Func<Variant, AcceptabilityChecker> _createAcceptabilityChecker =
			createAcceptabilityChecker;

		private delegate bool? AcceptabilityChecker(
			Language? language,
			Script? script,
			IReadOnlyList<Variant> variants);
	}
}