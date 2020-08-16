using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Variant subtags are used to indicate additional, well-recognized variations that define a
	/// language or its dialects that are not covered by other available subtags.
	/// </summary>
	public partial class Variant: IEquatable<Variant>, IComparable<Variant>
	{
		private readonly string _tag;
		private readonly Lazy<IReadOnlyCollection<LanguageTag>> _lazyPrefixes;

		private static readonly Lazy<IReadOnlyCollection<LanguageTag>> _emptyPrefixes =
			new Lazy<IReadOnlyCollection<LanguageTag>>(() => Enumerable.Empty<LanguageTag>().ToList());

		private Variant(string tag, string[] prefixes, bool deprecated)
		{
			_tag = tag;
			_lazyPrefixes = prefixes.Any()
				? new Lazy<IReadOnlyCollection<LanguageTag>>(() => prefixes.Select(LanguageTag.Parse).ToList())
				: _emptyPrefixes;
			Deprecated = deprecated;
		}

		/// <summary>
		/// Returns language tags that can be appended by given variant
		/// </summary>
		public IReadOnlyCollection<LanguageTag> Prefixes => _lazyPrefixes.Value;

		/// <summary>
		/// Subtag is deprecated
		/// </summary>
		public bool Deprecated { get; }

		/// <inheritdoc />
		public override string ToString()
		{
			return _tag;
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _tag.GetHashCode();
		}

		/// <inheritdoc />
		public int CompareTo(Variant other)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(_tag, other._tag);
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return ReferenceEquals(this, obj);
		}

		/// <inheritdoc />
		public bool Equals(Variant? other)
		{
			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(Variant? a, Variant? b)
		{
			return ReferenceEquals(a, null)
				? ReferenceEquals(b, null)
				: a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(Variant? a, Variant? b)
		{
			return !(a == b);
		}

		internal bool? RestrictiveAcceptableFor(Language? language, Script? script, IReadOnlyList<Variant>? variants)
		{
			var tags = Prefixes;
			if (tags.Count == 0)
				return false;

			var checkingFields = LanguageTag.Field.None;
			foreach (var tag in tags)
				checkingFields |= tag.Fields;

			foreach (var tag in tags)
			{
				if (prefixEquals(language, script, variants, tag, checkingFields))
					return true;
			}

			return null;
		}

		private static bool prefixEquals(
			Language? lang,
			Script? script,
			IEnumerable<Variant>? variants,
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
	}
}
