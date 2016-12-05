using System;
using System.Collections.Generic;
using System.Linq;

namespace AbbyyLS.Globalization.Bcp47
{
	/// <summary>
	/// Extensions provide a mechanism for extending language tags for use in various applications.
	/// </summary>
	public struct ExtensionSubtag : IEquatable<ExtensionSubtag>, IEnumerable<string>
	{
		private string[] _sequence;

		public Char Singleton { get; private set; }

		public ExtensionSubtag(Char singleton, params string[] sequence)
			: this()
		{
			Singleton = ValidateSingleton(singleton);

			if (sequence == null || sequence.Length == 0)
				throw new FormatException("extension subtag '" + singleton + "' not contain elements");

			_sequence = new string[sequence.Length];
			for (int i = 0; i < sequence.Length; i++)
				_sequence[i] = ValidateElement(sequence[i]);
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<string> GetEnumerator()
		{
			if (_sequence == null)
				return Enumerable.Empty<string>().GetEnumerator();
			else
				return _sequence.AsEnumerable().GetEnumerator();
		}

		/// <summary>
		/// This collection not contain elements
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				return _sequence == null;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(ExtensionSubtag other)
		{
			return Singleton == other.Singleton &&
				_sequence.IsEquivalent(other._sequence);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return Singleton.GetHashCode() ^ _sequence.GetHashCodeOfSequence();
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtag &&
				Equals((ExtensionSubtag)obj);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(ExtensionSubtag x, ExtensionSubtag y)
		{
			return x.Equals(y);
		}

		/// <summary>
		/// Not equality operator
		/// </summary>
		public static bool operator !=(ExtensionSubtag x, ExtensionSubtag y)
		{
			return !(x == y);
		}

		public IEnumerable<string> SubtagElements()
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
		/// <returns></returns>
		public override string ToString()
		{
			return string.Join(LanguageTag.TagSeparator.ToString(), SubtagElements());
		}

		internal static ExtensionSubtag? TryParse(LanguageTag.TokenEnumerator tokens)
		{
			if (!tokens.CurrentTokenAvailable) // get singletone
				return null;

			if (tokens.Token.Length != 1)
				return null;

			if (tokens.TokenIs(PrivateUseSubtags.Singleton))
				return null;

			char singleton = ValidateSingleton(tokens.Token[0]);

			if (!tokens.NextTokenAvailable)
				throw new FormatException("extension subtag '" + singleton + "' not contain elements");

			var sequence = new List<string>();

			tokens.ToNextToken();

			sequence.Add(ValidateElement(tokens.Token));
			tokens.ToNextToken(); // get remaining elements

			while (tokens.CurrentTokenAvailable)
			{
				if (tokens.Token.Length == 1) // next extension subtag or private use
					break;

				sequence.Add(ValidateElement(tokens.Token));
				tokens.ToNextToken();
			}

			var result = new ExtensionSubtag();
			result.Singleton = singleton;
			result._sequence = sequence.ToArray();

			return result;
		}

		private static char ValidateSingleton(char ch)
		{
			if (Char.IsLetterOrDigit(ch) && (int)ch < 127)
				return Char.ToLowerInvariant(ch);

			throw new FormatException("singletone must consist only of number or letter in ASCII");
		}

		private static string ValidateElement(string text)
		{
			if (text.Length < 2 || 8 < text.Length)
				throw new FormatException("extension subtag must be from 2 to 8 characters");

			if (!text.All(ch => Char.IsLetterOrDigit(ch) && (int)ch < 127))
				throw new FormatException("element must consist only of numbers or letters in ASCII");

			return text.ToLowerInvariant();
		}
	}
}
