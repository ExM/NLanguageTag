using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public struct ExtensionSubtag : IEquatable<ExtensionSubtag>
	{
		private List<string> _sequence;

		public Char Singleton { get; private set; }

		public IEnumerable<string> Sequence
		{
			get
			{
				if (_sequence == null)
					return Enumerable.Empty<string>();
				else
					return _sequence.AsEnumerable();
			}
		}

		public ExtensionSubtag(Char singleton, string firstSubtag)
			:this()
		{
			Singleton = singleton;
			_sequence = new List<string>();
			Append(firstSubtag);
		}

		public ExtensionSubtag(Char singleton, params string[] subtags)
			: this()
		{
			Singleton = singleton;
			_sequence = new List<string>();

			foreach (var s in subtags)
				Append(s);
		}

		internal void Append(string subtag)
		{
			_sequence.Add(subtag.ToLowerInvariant());
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
	}
}
