using System;
using System.Collections.Concurrent;

namespace NLanguageTag
{
	/// <summary>
	/// Script subtags are used to indicate the script or writing system variations
	/// that distinguish the written forms of a language or its dialects
	/// </summary>
	public partial class Script : IEquatable<Script>, IComparable<Script>
	{
		/// <summary>
		/// For private use only
		/// </summary>
		public bool PrivateUse => EnumCode == ScriptCode.PrivateUse;

		private readonly string _tag;

		/// <summary>
		/// subtag as text
		/// </summary>
		public string TextCode => _tag;

		/// <summary>
		/// Enum code to use as constants in C#
		/// </summary>
		public ScriptCode EnumCode { get; }

		private Script(string tag, ScriptCode enumCode)
		{
			_tag = tag;
			EnumCode = enumCode;
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
		public int CompareTo(Script other)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(_tag, other._tag);
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return ReferenceEquals(this, obj);
		}

		/// <inheritdoc />
		public bool Equals(Script? other)
		{
			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(Script? a, Script? b)
		{
			return ReferenceEquals(a, null)
				? ReferenceEquals(b, null)
				: a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(Script? a, Script? b)
		{
			return !(a == b);
		}

		private static readonly ConcurrentDictionary<string, Script> _privateUse =
			new ConcurrentDictionary<string, Script>(StringComparer.OrdinalIgnoreCase);

		private static readonly Func<string, Script> _regionCreator = (tag) => new Script(char.ToUpper(tag[0]) + tag.Substring(1), ScriptCode.PrivateUse);

		private static Script forPrivateUse(string text)
		{
			return _privateUse.GetOrAdd(text, _regionCreator);
		}

		/// <summary>
		/// Parses script subtag from its string representation
		/// </summary>
		public static Script Parse(string text)
		{
			return TryParse(text) ?? throw new FormatException("Invalid script subtag string: " + text);
		}

		/// <summary>
		/// Parses script subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Script? TryParse(string text)
		{
			if(text == null)
				throw new ArgumentNullException(nameof(text));
			return TryParse(new StringSpan(text.ToLowerInvariant()));
		}
	}
}
