using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Private use subtags are used to indicate distinctions in language
	/// that are important in a given context by private agreement.
	/// </summary>
	public struct PrivateUseSubtags : IEnumerable<string>, IEquatable<PrivateUseSubtags>
	{
		private string[] _subtags;

		public static readonly string Singleton = "x";

		public PrivateUseSubtags(params string[] subtags)
			: this()
		{
			if (subtags == null || subtags.Length == 0)
				throw new FormatException("private use subtags not contain elements");

			_subtags = new string[subtags.Length];
			for (int i = 0; i < subtags.Length; i++)
				_subtags[i] = ValidateSubtag(subtags[i]);
		}

		internal static PrivateUseSubtags Parse(LanguageTag.TokenEnumerator tokens)
		{
			var result = new PrivateUseSubtags();

			if (!tokens.TokenIs(Singleton))
				throw new FormatException("unexpected subtag '" + tokens.Token + "'");

			var subtags = new List<string>();

			while (tokens.NextTokenAvailable) // get all subtags
			{
				tokens.ToNextToken();
				subtags.Add(ValidateSubtag(tokens.Token));
			}

			if (subtags.Count == 0)
				throw new FormatException("private use subtags not contain elements");

			result._subtags = subtags.ToArray();
			return result;
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static PrivateUseSubtags Parse(string text)
		{
			return Parse(new LanguageTag.TokenEnumerator(text));
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		/// <returns>true if s was converted successfully; otherwise, false.</returns>
		public static bool TryParse(string text, out PrivateUseSubtags result)
		{
			try
			{
				result = Parse(text);
				return true;
			}
			catch (FormatException)
			{
				result = new PrivateUseSubtags();
				return false;
			}
		}

		/// <summary>
		/// Converts the string representation of a private use subtags
		/// </summary>
		public static PrivateUseSubtags? TryParse(string text)
		{
			try
			{
				return Parse(text);
			}
			catch (FormatException)
			{
				return null;
			}
		}

		private static string ValidateSubtag(string text)
		{
			if (text.Length < 1 || 8 < text.Length)
				throw new FormatException("private use subtag must be from 1 to 8 characters");

			if (!text.All(ch => Char.IsLetterOrDigit(ch) && (int)ch < 127))
				throw new FormatException("private use subtag must consist only of numbers or letters in ASCII");

			return text.ToLowerInvariant();
		}

		/// <summary>
		/// This collection not contain elements
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				return _subtags == null;
			}
		}

		/// <summary>
		/// Determines whether a sequence contains a specified element
		/// </summary>
		public bool Contains(string subtag)
		{
			if (_subtags == null)
				return false;

			return _subtags.Contains(subtag, StringComparer.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(PrivateUseSubtags other)
		{
			return _subtags.IsEquivalent(other._subtags);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _subtags.GetHashCodeOfSequence();
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is PrivateUseSubtags &&
				Equals((PrivateUseSubtags)obj);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(PrivateUseSubtags x, PrivateUseSubtags y)
		{
			return x.Equals(y);
		}

		/// <summary>
		/// Not equality operator
		/// </summary>
		public static bool operator !=(PrivateUseSubtags x, PrivateUseSubtags y)
		{
			return !(x == y);
		}

		public IEnumerable<string> SubtagElements()
		{
			if (_subtags == null)
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
			return string.Join(LanguageTag.TagSeparator.ToString(), SubtagElements());
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<string> GetEnumerator()
		{
			if (_subtags == null)
				return Enumerable.Empty<string>().GetEnumerator();
			else
				return _subtags.AsEnumerable().GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
