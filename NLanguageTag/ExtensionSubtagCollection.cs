using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Collection of extension subtags
	/// </summary>
	public struct ExtensionSubtagCollection : IEnumerable<ExtensionSubtag>, IEquatable<ExtensionSubtagCollection>
	{
		/// <summary>
		/// Initializes new instance of <see cref="ExtensionSubtagCollection"/> with provided subtags
		/// </summary>
		public ExtensionSubtagCollection(params ExtensionSubtag[] subtags)
			: this(subtags as IReadOnlyCollection<ExtensionSubtag>)
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="ExtensionSubtagCollection"/> with provided subtags
		/// </summary>
		public ExtensionSubtagCollection(IReadOnlyCollection<ExtensionSubtag> subtags)
		{
			if (subtags == null || subtags.Count == 0)
			{
				_sortedCollection = null;
				return;
			}

			var collection = new ExtensionSubtag[subtags.Count];
			var i = 0;
			foreach (var subtag in subtags)
			{
				collection[i] = subtag;
				i++;
			}

			// Sorting subtags by their singletons
			Array.Sort(collection, _singletonComparer);

			// Checking that all subtags singletons are unieuq
			for (i = 1; i < collection.Length; i++)
			{
				if (collection[i - 1].Singleton == collection[i].Singleton)
				{
					throw new ArgumentException(
						$"Two or more subtags have the same singleton `{collection[i].Singleton}'",
						nameof(subtags));
				}
			}

			_sortedCollection = collection;
		}

		/// <summary>
		/// Initializes new instance of <see cref="ExtensionSubtagCollection"/> with provided subtags
		/// </summary>
		public ExtensionSubtagCollection(IEnumerable<ExtensionSubtag> subtags)
			: this(safeConvert(subtags))
		{
		}

		/// <summary>
		/// Indicates whether this collection contains no elements
		/// </summary>
		public bool IsEmpty => _sortedCollection == null;

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtagCollection extensionSubtagCollection && Equals(extensionSubtagCollection);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(ExtensionSubtagCollection other)
		{
			return _sortedCollection.IsEquivalentTo(other._sortedCollection);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(ExtensionSubtagCollection a, ExtensionSubtagCollection b)
		{
			return a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(ExtensionSubtagCollection a, ExtensionSubtagCollection b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _sortedCollection.GetHashCodeOfSequence();
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection
		/// </summary>
		public IEnumerator<ExtensionSubtag> GetEnumerator()
		{
			var enumerable = _sortedCollection ?? Enumerable.Empty<ExtensionSubtag>();
			return enumerable.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static PartialParseResult<ExtensionSubtagCollection> Parse(TokenEnumerator tokens)
		{
			var subtagResult = ExtensionSubtag.Parse(tokens);

			if (subtagResult.NothingToParse)
				return PartialParseResult<ExtensionSubtagCollection>.Empty;

			if (subtagResult.ErrorOccured)
				return PartialParseResult<ExtensionSubtagCollection>.Error;

			var resultCollection = new List<ExtensionSubtag>();
			var usedSingletons = new bool[128];

			while (true)
			{
				var subtag = subtagResult.Result;
				if (usedSingletons[subtag.Singleton])
					return PartialParseResult<ExtensionSubtagCollection>.Error;

				usedSingletons[subtag.Singleton] = true;
				resultCollection.Add(subtag);
				subtagResult = ExtensionSubtag.Parse(tokens);

				if (subtagResult.NothingToParse)
					return PartialParseResult<ExtensionSubtagCollection>.Success(
						new ExtensionSubtagCollection(resultCollection));

				if (subtagResult.ErrorOccured)
					return PartialParseResult<ExtensionSubtagCollection>.Error;
			}
		}

		private static IReadOnlyCollection<ExtensionSubtag> safeConvert(IEnumerable<ExtensionSubtag> subtags)
		{
			if (subtags == null)
			{
				return null;
			}

			return subtags as IReadOnlyCollection<ExtensionSubtag> ?? subtags.ToArray();
		}

		// Since this is value type, there is no way to prevent it being in the default state.
		// The natural meaning for the default state is an empty collection.
		// We will treat this field being null as empty collection, and also store null here if this value
		// is initialized as empty collection.
		private readonly ExtensionSubtag[] _sortedCollection;

		private static readonly IComparer<ExtensionSubtag> _singletonComparer = new SingletonComparer();

		private sealed class SingletonComparer : IComparer<ExtensionSubtag>
		{
			public int Compare(ExtensionSubtag x, ExtensionSubtag y)
			{
				return x.Singleton.CompareTo(y.Singleton);
			}
		}
	}
}