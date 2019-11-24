using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Extensions provide a mechanism for extending language tags for use in various applications
	/// </summary>
	public struct ExtensionSubtag : IEquatable<ExtensionSubtag>, IEnumerable<string>
	{
		/// <summary>
		/// Single-character subtag, introducing this extension subtag
		/// </summary>
		public char Singleton => _singleton != 0 ? _singleton : throw getNotInitializedException();

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

			if (sequence == null || sequence.Count == 0)
				throw new FormatException("Extension subtag '" + singleton + "' contains no elements");

			_sequence = new string[sequence.Count];
			for (var i = 0; i < sequence.Count; i++)
				_sequence[i] = validateElement(sequence[i]);
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<string> GetEnumerator()
		{
			IEnumerable<string> sequence = _sequence ?? throw getNotInitializedException();
			return sequence.GetEnumerator();
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
			return Singleton == other.Singleton && _sequence.IsEquivalentTo(other._sequence);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _sequence != null
				? Singleton.GetHashCode() ^ _sequence.GetHashCodeOfSequence()
				: throw getNotInitializedException();
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
				throw getNotInitializedException();

			yield return Singleton.ToString();

			foreach (var element in _sequence)
				yield return element;
		}

		/// <summary>
		/// Converts the value of this instance to its equivalent string representation.
		/// </summary>
		public override string ToString()
		{
			return string.Join(LanguageTag.TagSeparator.ToString(), GetSubtagElements());
		}

		internal static PartialParseResult<ExtensionSubtag> Parse(TokenEnumerator tokens)
		{
			// Get the singleton
			if (!tokens.CurrentTokenAvailable)
				return PartialParseResult<ExtensionSubtag>.Empty;

			if (tokens.Token.Length != 1 || tokens.TokenIs(PrivateUseSubtags.Singleton))
				return PartialParseResult<ExtensionSubtag>.Empty;

			var singleton = tokens.Token[0];
			if (!isAsciiLetterOrDigit(singleton))
				return PartialParseResult<ExtensionSubtag>.Error;

			if (!tokens.NextTokenAvailable)
				return PartialParseResult<ExtensionSubtag>.Error;

			var sequence = new List<string>();

			tokens.ToNextToken();

			if (!isValidElement(tokens.Token))
				return PartialParseResult<ExtensionSubtag>.Error;

			sequence.Add(tokens.Token);

			// Get remaining elements
			tokens.ToNextToken();

			while (tokens.CurrentTokenAvailable)
			{
				if (tokens.Token.Length == 1) // next extension subtag or private use
					break;

				if (!isValidElement(tokens.Token))
					return PartialParseResult<ExtensionSubtag>.Error;

				sequence.Add(tokens.Token);
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

		private static string validateElement(string text)
		{
			if (text.Length < 2 || 8 < text.Length)
				throw new FormatException("Extension subtag must be from 2 to 8 characters");

			if (!text.All(isAsciiLetterOrDigit))
				throw new FormatException("Element must consist only of numbers or letters in ASCII");

			return text.ToLowerInvariant();
		}

		private static bool isValidElement(string text)
		{
			return text.Length >= 2 && text.Length <= 8 && text.All(isAsciiLetterOrDigit);
		}

		private static bool isAsciiLetterOrDigit(char value)
		{
			return value < 127 && char.IsLetterOrDigit(value);
		}

		private static InvalidOperationException getNotInitializedException()
		{
			return new InvalidOperationException("This value was not initialized");
		}

		// Since this is value type, there is no way to prevent it being in the default state.
		// There is no reasonable meaning for the default state.
		// Thus when accessing the fields we will throw exception if they are in the default state.
		private readonly char _singleton;
		private readonly string[] _sequence;
	}
}