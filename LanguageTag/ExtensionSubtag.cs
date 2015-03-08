using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
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

		public IEnumerator<string> GetEnumerator()
		{
			if (_sequence == null)
				return Enumerable.Empty<string>().GetEnumerator();
			else
				return _sequence.AsEnumerable().GetEnumerator();
		}

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

		public bool Equals(ExtensionSubtag other)
		{
			return Singleton == other.Singleton &&
				_sequence.IsEquivalent(other._sequence);
		}

		public override int GetHashCode()
		{
			return Singleton.GetHashCode() ^ _sequence.GetHashCodeOfSequence();
		}

		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtag &&
				Equals((ExtensionSubtag)obj);
		}

		public static bool operator ==(ExtensionSubtag x, ExtensionSubtag y)
		{
			return x.Equals(y);
		}

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

		public override string ToString()
		{
			return string.Join(LanguageTag.TagSeparator.ToString(), SubtagElements());
		}

		public static readonly IComparer<ExtensionSubtag> SingletonComparer = new SingletonComparerImpl();

		private class SingletonComparerImpl: IComparer<ExtensionSubtag>
		{
			public int Compare(ExtensionSubtag x, ExtensionSubtag y)
			{
				return x.Singleton.CompareTo(y.Singleton);
			}
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
