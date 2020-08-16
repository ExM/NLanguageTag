using System;
using System.Collections.Concurrent;

namespace NLanguageTag
{
	/// <summary>
	/// Region subtags are used to indicate linguistic variations associated
	/// with or appropriate to a specific country, territory, or region.
	/// </summary>
	public partial class Region : IEquatable<Region>, IComparable<Region>
	{
		/// <summary>
		/// Subtag for private use only
		/// </summary>
		public bool PrivateUse { get; }

		/// <summary>
		/// Subtag is deprecated
		/// </summary>
		public bool Deprecated { get; }

		private readonly string _tag;

		private Region(string tag, bool deprecated, bool privateUse)
		{
			PrivateUse = privateUse;
			_tag = tag;
			Deprecated = deprecated;
		}

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
		public int CompareTo(Region other)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(_tag, other._tag);
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return ReferenceEquals(this, obj);
		}

		/// <inheritdoc />
		public bool Equals(Region? other)
		{
			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(Region? a, Region? b)
		{
			return ReferenceEquals(a, null)
				? ReferenceEquals(b, null)
				: a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(Region? a, Region? b)
		{
			return !(a == b);
		}

		private static readonly ConcurrentDictionary<string, Region> _privateUse =
			new ConcurrentDictionary<string, Region>(StringComparer.OrdinalIgnoreCase);

		private static readonly Func<string, Region> _regionCreator = (tag) => new Region(tag.ToUpperInvariant(), false, true);

		private static Region forPrivateUse(string text)
		{
			return _privateUse.GetOrAdd(text, _regionCreator);
		}

		/// <summary>
		/// Parses region subtag from its string representation
		/// </summary>
		public static Region Parse(string text)
		{
			return TryParse(text) ?? throw new FormatException("Invalid region subtag string: " + text);
		}

		/// <summary>
		/// Parses region subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Region? TryParse(string text)
		{
			if(text == null)
				throw new ArgumentNullException(nameof(text));
			return TryParse(new StringSpan(text.ToLowerInvariant()));
		}
	}
}
