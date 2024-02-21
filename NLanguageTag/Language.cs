using System;
using System.Collections.Concurrent;

namespace NLanguageTag
{
	/// <summary>
	/// The primary language subtag is the first subtag in a language tag.
	/// </summary>
	public partial class Language : IEquatable<Language>, IComparable<Language>
	{
		private readonly string _tag;
		private readonly Func<StringSpan, Language?>? _extLanguageParser;

		private Language(
			string tag,
			LanguageCode code,
			Script? suppressScript,
			Language? macrolanguage,
			LanguageScope? scope,
			Func<StringSpan, Language?>? extLanguageParser,
			Language? prefix,
			bool deprecated)
		{
			_tag = tag;
			EnumCode = code;
			_extLanguageParser = extLanguageParser;
			SuppressScript = suppressScript;
			Macrolanguage = macrolanguage;
			Scope = scope;
			Prefix = prefix;
			Deprecated = deprecated;
		}

		/// <summary>
		/// subtag as text
		/// </summary>
		public string TextCode => _tag;

		/// <summary>
		/// Enum code to use as constants in C#
		/// </summary>
		public LanguageCode EnumCode { get; }

		/// <summary>
		/// Returns script (if such exists) used to write the overwhelming majority of documents for the
		/// given language. The subtag for such a script therefore adds no distinguishing information to
		/// a language tag and thus SHOULD NOT be used for most documents in that language.
		/// </summary>
		public Script? SuppressScript { get; }

		/// <summary>
		/// Returns macrolanguage for the given specific language
		/// </summary>
		public Language? Macrolanguage { get; }

		/// <summary>
		/// specifies the language that must precede the extlang subtag
		/// </summary>
		public Language? Prefix { get; }

		/// <summary>
		/// Returns the scope of the given language subtag (on null if the subtag represents an invididual language)
		/// </summary>
		public LanguageScope? Scope { get; }

		/// <summary>
		/// Determines the possible presence of extlang subtag
		/// </summary>
		public bool ExtLanguageAvailable => _extLanguageParser != null;

		/// <summary>
		/// Subtag for private use only
		/// </summary>
		public bool PrivateUse => EnumCode == LanguageCode.PrivateUse;

		/// <summary>
		/// Subtag is deprecated
		/// </summary>
		public bool Deprecated { get; }

		/// <summary>
		/// Determines the proper language subtag that should be used instead of given combination of
		/// language subtag and extlang subtag
		/// </summary>
		internal Language? TryParseExtLanguage(StringSpan span)
		{
			return _extLanguageParser is null
				? null
				: _extLanguageParser(span);
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
		public int CompareTo(Language? other)
		{
			if (other is null)
				throw new ArgumentNullException(nameof(other));
			return StringComparer.OrdinalIgnoreCase.Compare(_tag, other._tag);
		}

		/// <inheritdoc />
		public override bool Equals(object? obj)
		{
			return ReferenceEquals(this, obj);
		}

		/// <inheritdoc />
		public bool Equals(Language? other)
		{
			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(Language? a, Language? b)
		{
			return ReferenceEquals(a, null)
				? ReferenceEquals(b, null)
				: a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(Language? a, Language? b)
		{
			return !(a == b);
		}

		private static readonly ConcurrentDictionary<string, Language> _privateUse =
			new ConcurrentDictionary<string, Language>(StringComparer.OrdinalIgnoreCase);

		private static readonly Func<string, Language> _langCreator = (tag) =>
			new Language(tag.ToLowerInvariant(), LanguageCode.PrivateUse, null, null, null, null, null, false);

		private static Language forPrivateUse(string text)
		{
			return _privateUse.GetOrAdd(text, _langCreator);
		}

		/// <summary>
		/// Converts the string representation of a primary language subtag
		/// </summary>
		public static Language Parse(string? text)
		{
			return TryParse(text) ?? throw new FormatException("Invalid primary language subtag string: " + text);
		}

		/// <summary>
		/// Converts the string representation of a primary language subtag
		/// </summary>
		public static Language? TryParse(string? text)
		{
			if(text is null)
				throw new ArgumentNullException(nameof(text));
			return TryParse(new StringSpan(text.ToLowerInvariant()));
		}
	}
}