using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	internal static class InternalExtensions
	{
		public static bool IsSet(this LanguageTagField checking, LanguageTagField test)
		{
			return (checking & test) == test;
		}

		public static int GetHashCodeOfSequence<T>(this IEnumerable<T> items)
		{
			if (items == null)
				return 0;

			unchecked
			{
				int hash = 19;
				foreach (var i in items)
				{
					hash = hash * 31 + i.GetHashCode();
				}
				return hash;
			}
		}

		public static bool IsEquivalent<T>(this IList<T> x, IList<T> y) where T : IEquatable<T>
		{
			if (x == null)
				return y == null;

			if (y == null)
				return false;

			if (x.Count != y.Count)
				return false;

			for (int i = 0; i < x.Count; i++)
				if (!x[i].Equals(y[i]))
					return false;

			return true;
		}

		public static bool IsEquivalent(this IList<Variant> x, IList<Variant> y)
		{
			if (x == null)
				return y == null;

			if (y == null)
				return false;

			if (x.Count != y.Count)
				return false;

			for (int i = 0; i < x.Count; i++)
				if (x[i] != y[i])
					return false;

			return true;
		}

		public static LanguageTagTokenEnumerator GetTokenSequense(this string text, int start)
		{
			return new LanguageTagTokenEnumerator(text, start);
		}

		internal class LanguageTagTokenEnumerator
		{
			private string _text;

			public LanguageTagTokenEnumerator(string text, int start)
			{
				_text = text;
				NextTokenPosition = start;
				CurrentTokenPosition = start;
			}

			public string Token { get; private set; }

			public int CurrentTokenPosition { get; private set; }

			public int NextTokenPosition { get; private set; }

			public bool MoveNext()
			{
				if (NextTokenPosition == _text.Length)
					return false;

				int pos = _text.IndexOf(LanguageTag.TagSeparator, NextTokenPosition);

				CurrentTokenPosition = NextTokenPosition;

				if(pos == -1)
				{
					Token = _text.Substring(NextTokenPosition);
					NextTokenPosition = _text.Length;
				}
				else
				{
					Token = _text.Substring(NextTokenPosition, pos - NextTokenPosition);
					NextTokenPosition = pos + 1;
				}
				return true;
			}
		}

	}
}
