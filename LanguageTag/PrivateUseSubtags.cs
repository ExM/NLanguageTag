using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public struct PrivateUseSubtags : IEnumerable<string>, IEquatable<PrivateUseSubtags>
	{
		private string[] _subtags;

		public static readonly string Singleton = "x";

		public PrivateUseSubtags(params string[] subtags)
			: this()
		{
			if (subtags == null || subtags.Length == 0)
				return;

			_subtags = new string[subtags.Length];
			for (int i = 0; i < subtags.Length; i++)
			{
				ValidateSubtag(subtags[i]);
				_subtags[i] = subtags[i].ToLowerInvariant();
			}
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

				ValidateSubtag(tokens.Token);
				subtags.Add(tokens.Token.ToLowerInvariant());
			}

			if (subtags.Count == 0)
				throw new FormatException("private use subtags not contain elements");

			result._subtags = subtags.ToArray();
			return result;
		}

		public static PrivateUseSubtags Parse(string text)
		{
			return Parse(new LanguageTag.TokenEnumerator(text));
		}

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

		private static void ValidateSubtag(string text)
		{
			if (text.Length < 1 || 8 < text.Length)
				throw new FormatException("private use subtag must be from 1 to 8 characters");

			if (!text.All(ch => Char.IsLetterOrDigit(ch) && (int)ch < 127))
				throw new FormatException("private use subtag must consist only of numbers or letters in ASCII");
		}

		public bool IsEmpty
		{
			get
			{
				return _subtags == null;
			}
		}

		public bool Contains(string subtag)
		{
			if (_subtags == null)
				return false;

			return _subtags.Contains(subtag, StringComparer.OrdinalIgnoreCase);
		}

		public bool Equals(PrivateUseSubtags other)
		{
			return _subtags.IsEquivalent(other._subtags);
		}

		public override int GetHashCode()
		{
			return _subtags.GetHashCodeOfSequence();
		}

		public override bool Equals(object obj)
		{
			return obj is PrivateUseSubtags &&
				Equals((PrivateUseSubtags)obj);
		}

		public static bool operator ==(PrivateUseSubtags x, PrivateUseSubtags y)
		{
			return x.Equals(y);
		}

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

		public override string ToString()
		{
			return string.Join(LanguageTag.TagSeparator.ToString(), SubtagElements());
		}

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
