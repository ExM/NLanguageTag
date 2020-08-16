using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Extensions provide a mechanism for extending language tags for use in various applications
	/// </summary>
	public readonly struct ExtensionSubtag : IEquatable<ExtensionSubtag>, IEnumerable<string>
	{
		/// <summary>
		/// Single-character subtag, introducing this extension subtag
		/// </summary>
		public char Singleton => _sequence != null ? _singleton : throw new InvalidOperationException("This value was not initialized");

		/// <summary>
		/// Subtag for private use only
		/// </summary>
		public bool PrivateUse => _singleton == _privateUseSingleton;

		/// <summary>
		/// Initializes new instance of <see cref="ExtensionSubtag"/> with values of the singleton and
		/// following elements sequence
		/// </summary>
		public ExtensionSubtag(char singleton, params string[] sequence)
			: this(singleton, sequence as IReadOnlyList<string>)
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="ExtensionSubtag"/> with values of the singleton and
		/// following elements sequence
		/// </summary>
		public ExtensionSubtag(char singleton, IReadOnlyList<string> sequence)
		{
			_singleton = validateSingleton(singleton);
			var privateUse = _singleton == _privateUseSingleton;

			if (sequence == null || sequence.Count == 0)
				throw new FormatException("Extension subtag '" + singleton + "' contains no elements");

			_sequence = new string[sequence.Count];
			for (var i = 0; i < sequence.Count; i++)
				_sequence[i] = validateElement(sequence[i], privateUse);
		}

		/// <summary>
		/// Initializes new value for private use
		/// </summary>
		public static ExtensionSubtag ForPrivateUse(params string[] sequence)
		{
			return ForPrivateUse(sequence as IReadOnlyList<string>);
		}

		/// <summary>
		/// Initializes new value for private use
		/// </summary>
		public static ExtensionSubtag ForPrivateUse(IReadOnlyList<string> sequence)
		{
			return new ExtensionSubtag(_privateUseSingleton, sequence);
		}

		/// <summary>
		/// Indicates whether this collection contains no elements
		/// </summary>
		public bool IsEmpty => _sequence == null;

		/// <summary>
		/// Determines whether a sequence contains a specified element
		/// </summary>
		public bool Contains(string subtag)
		{
			if (_sequence == null)
				return false;

			return _sequence.Contains(subtag, StringComparer.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<string> GetEnumerator()
		{
			var subtags = _sequence ?? Enumerable.Empty<string>();
			return subtags.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(ExtensionSubtag other)
		{
			return _singleton == other._singleton && _sequence.IsEquivalentTo(other._sequence);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _sequence != null
				? Singleton.GetHashCode() ^ _sequence.GetHashCodeOfClassSequence()
				: 0;
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtag extensionSubtag && Equals(extensionSubtag);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(ExtensionSubtag x, ExtensionSubtag y)
		{
			return x.Equals(y);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(ExtensionSubtag x, ExtensionSubtag y)
		{
			return !(x == y);
		}

		/// <summary>
		/// Returns all elements of this subtag as they appear in full language tag
		/// </summary>
		public IEnumerable<string> GetSubtagElements()
		{
			if (_sequence == null)
				yield break;

			yield return Singleton.ToString();

			foreach (var el in _sequence)
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
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static ExtensionSubtag Parse(string text)
		{
			return TryParse(text, out var result)
				? result
				: throw new FormatException("Invalid private use subtags string: " + text);
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		/// <returns>true if s was converted successfully; otherwise, false.</returns>
		public static bool TryParse(string text, out ExtensionSubtag result)
		{
			if(text == null)
				throw new ArgumentNullException(nameof(text));
			var tokens = new TokenEnumerator(text);

			if (!tokens.CurrentTokenAvailable)
			{
				result = default;
				return false;
			}

			var parseResult = Parse(tokens, tokens.TokenIsPrivateUseSingleton());
			if (parseResult.ErrorOccured
				|| parseResult.NothingToParse
				|| tokens.CurrentTokenAvailable)
			{
				result = default;
				return false;
			}

			result = parseResult.Result;
			return true;
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static ExtensionSubtag? TryParse(string text)
		{
			return TryParse(text, out var result) ? result : (ExtensionSubtag?)null;
		}

		internal static PartialParseResult<ExtensionSubtag> Parse(TokenEnumerator tokens, bool privateUse)
		{
			// Get the singleton
			if (!tokens.CurrentTokenAvailable)
				return PartialParseResult<ExtensionSubtag>.Empty;

			if (privateUse)
			{
				if (!tokens.TokenIsPrivateUseSingleton())
					return PartialParseResult<ExtensionSubtag>.Empty;
			}
			else
			{
				if (tokens.CurrentToken.Length != 1 || tokens.TokenIsPrivateUseSingleton())
					return PartialParseResult<ExtensionSubtag>.Empty;
			}

			var singleton = tokens.CurrentToken[0];
			if (!isAsciiLetterOrDigit(singleton))
				return PartialParseResult<ExtensionSubtag>.Error;

			if (!tokens.NextTokenAvailable)
				return PartialParseResult<ExtensionSubtag>.Error;

			var sequence = new List<string>();

			tokens.ToNextToken();

			var token = tokens.CurrentToken.AsText();

			if (!isValidElement(token, privateUse))
				return PartialParseResult<ExtensionSubtag>.Error;

			sequence.Add(token);

			// Get remaining elements
			tokens.ToNextToken();

			while (tokens.CurrentTokenAvailable)
			{
				if (tokens.CurrentToken.Length == 1) // next extension subtag or private use
					break;

				token = tokens.CurrentToken.AsText();

				if (!isValidElement(token, privateUse))
					return PartialParseResult<ExtensionSubtag>.Error;

				sequence.Add(token);
				tokens.ToNextToken();
			}

			return PartialParseResult<ExtensionSubtag>.Success(new ExtensionSubtag(singleton, sequence));
		}

		private static char validateSingleton(char ch)
		{
			if (isAsciiLetterOrDigit(ch))
				return char.ToLowerInvariant(ch);

			throw new FormatException("Singleton must be a letter or digit in ASCII");
		}

		private static string validateElement(string text, bool privateUse)
		{
			if (privateUse)
			{
				if (text.Length < 1 || 8 < text.Length)
					throw new FormatException("Private use subtag must be from 1 to 8 characters");
			}
			else
			{
				if (text.Length < 2 || 8 < text.Length)
					throw new FormatException("Extension subtag must be from 2 to 8 characters");
			}

			if (!text.All(isAsciiLetterOrDigit))
				throw new FormatException("Element must consist only of numbers or letters in ASCII");

			return text.ToLowerInvariant();
		}

		private static bool isValidElement(string text, bool privateUse)
		{
			if (privateUse)
				return text.Length >= 1 && text.Length <= 8 && text.All(isAsciiLetterOrDigit);
			else
				return text.Length >= 2 && text.Length <= 8 && text.All(isAsciiLetterOrDigit);
		}

		private static bool isAsciiLetterOrDigit(char value)
		{
			return value < 127 && char.IsLetterOrDigit(value);
		}

		// Since this is value type, there is no way to prevent it being in the default state.
		// The natural meaning for the default state is an empty collection.
		// We will treat this field being null as empty collection, and also store null here if this value
		// is initialized as empty collection.
		private readonly char _singleton;
		private readonly string[]? _sequence;

		private const char _privateUseSingleton = 'x';
	}
}
