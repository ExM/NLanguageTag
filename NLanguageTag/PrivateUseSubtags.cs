using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Private use subtags are used to indicate distinctions in language
	/// that are important in a given context by private agreement.
	/// </summary>
	public readonly struct PrivateUseSubtags : IEnumerable<string>, IEquatable<PrivateUseSubtags>
	{
		/// <summary>
		/// Subtag that identifies start of private-use subtags
		/// </summary>
		public static string Singleton => "x";

		/// <summary>
		/// Initializes new value of <see cref="PrivateUseSubtags"/>
		/// </summary>
		public PrivateUseSubtags(params string[]? subtags)
			: this(subtags as IReadOnlyList<string>)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="PrivateUseSubtags"/>
		/// </summary>
		public PrivateUseSubtags(IReadOnlyList<string>? subtags)
		{
			if (subtags is null || subtags.Count == 0)
			{
				_subtags = null;
				return;
			}

			_subtags = new string[subtags.Count];
			for (var i = 0; i < subtags.Count; i++)
				_subtags[i] = validateSubtag(subtags[i]);
		}

		internal static PartialParseResult<PrivateUseSubtags> Parse(TokenEnumerator tokens)
		{
			if (!tokens.TokenIs(Singleton))
				return PartialParseResult<PrivateUseSubtags>.Empty;

			tokens.ToNextToken();

			var subtags = new List<string>();

			while (tokens.CurrentTokenAvailable)
			{
				if (!isValidSubtag(tokens.Token))
					return PartialParseResult<PrivateUseSubtags>.Error;

				subtags.Add(tokens.Token);
				tokens.ToNextToken();
			}

			if (subtags.Count == 0)
				return PartialParseResult<PrivateUseSubtags>.Error;

			return PartialParseResult<PrivateUseSubtags>.Success(new PrivateUseSubtags(subtags));
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static PrivateUseSubtags Parse(string text)
		{
			return TryParse(text, out var result)
				? result
				: throw new FormatException("Invalid private use subtags string: " + text);
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		/// <returns>true if s was converted successfully; otherwise, false.</returns>
		public static bool TryParse(string text, out PrivateUseSubtags result)
		{
			var parseResult = Parse(new TokenEnumerator(text));
			if (parseResult.ErrorOccured)
			{
				result = default;
				return false;
			}

			result = parseResult.NothingToParse ? default : parseResult.Result;
			return true;
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static PrivateUseSubtags? TryParse(string text)
		{
			return TryParse(text, out var result) ? result : (PrivateUseSubtags?)null;
		}

		private static string validateSubtag(string text)
		{
			if (text.Length < 1 || 8 < text.Length)
				throw new FormatException("Private use subtag must be from 1 to 8 characters");

			if (!text.All(isAsciiLetterOrDigit))
				throw new FormatException("Private use subtag must consist only of numbers or letters in ASCII");

			return text.ToLowerInvariant();
		}

		private static bool isValidSubtag(string text)
		{
			return text.Length >= 1 && text.Length <= 8 && text.All(isAsciiLetterOrDigit);
		}

		private static bool isAsciiLetterOrDigit(char value)
		{
			return value < 127 && char.IsLetterOrDigit(value);
		}

		/// <summary>
		/// Indicates whether this collection contains no elements
		/// </summary>
		public bool IsEmpty => _subtags is null;

		/// <summary>
		/// Determines whether a sequence contains a specified element
		/// </summary>
		public bool Contains(string subtag)
		{
			return _subtags != null && _subtags.Contains(subtag, StringComparer.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(PrivateUseSubtags other)
		{
			return _subtags.IsEquivalentTo(other._subtags);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _subtags.GetHashCodeOfClassSequence();
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object? obj)
		{
			return obj is PrivateUseSubtags privateUseSubtags && Equals(privateUseSubtags);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(PrivateUseSubtags x, PrivateUseSubtags y)
		{
			return x.Equals(y);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(PrivateUseSubtags x, PrivateUseSubtags y)
		{
			return !(x == y);
		}

		/// <summary>
		/// Returns all elements of this subtag as they appear in full language tag
		/// </summary>
		public IEnumerable<string> GetSubtagElements()
		{
			if (_subtags is null)
				yield break;

			yield return Singleton;

			foreach (var el in _subtags)
				yield return el;
		}

		/// <summary>
		/// Converts the value of this instance to its equivalent string representation.
		/// </summary>
		public override string ToString()
		{
			return string.Join(LanguageTag.TagSeparator.ToString(), GetSubtagElements());
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<string> GetEnumerator()
		{
			var subtags = _subtags ?? Enumerable.Empty<string>();
			return subtags.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		// Since this is value type, there is no way to prevent it being in the default state.
		// The natural meaning for the default state is an empty collection.
		// We will treat this field being null as empty collection, and also store null here if this value
		// is initialized as empty collection.
		private readonly string[]? _subtags;
	}
}