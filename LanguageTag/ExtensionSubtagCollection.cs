using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public struct ExtensionSubtagCollection : IEnumerable<ExtensionSubtag>, IEquatable<ExtensionSubtagCollection>
	{
		private List<ExtensionSubtag> _sortedList;

		public ExtensionSubtagCollection(params ExtensionSubtag[] subtags)
			:this()
		{
			if (subtags == null || subtags.Length == 0)
				return;

			_sortedList = new List<ExtensionSubtag>(subtags.Length);
			foreach (var extSubtag in subtags)
				Append(extSubtag);
		}

		public ExtensionSubtagCollection(IEnumerable<ExtensionSubtag> subtags)
			: this(subtags.ToArray())
		{
		}

		public bool IsEmpty
		{
			get
			{
				return _sortedList == null;
			}
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtagCollection &&
				Equals((ExtensionSubtagCollection)obj);
		}

		private void Append(ExtensionSubtag extSubtag)
		{
			var index = _sortedList.BinarySearch(extSubtag, ExtensionSubtag.SingletonComparer);
			if (index >= 0)
				throw new FormatException("duplicate extenson subtag with singletone `" + extSubtag.Singleton + "'");
			
			_sortedList.Insert(~index, extSubtag);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(ExtensionSubtagCollection other)
		{
			return _sortedList.IsEquivalent(other._sortedList);
		}

		public static bool operator ==(ExtensionSubtagCollection a, ExtensionSubtagCollection b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(ExtensionSubtagCollection a, ExtensionSubtagCollection b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _sortedList.GetHashCodeOfSequence();
		}

		public IEnumerator<ExtensionSubtag> GetEnumerator()
		{
			if (_sortedList == null)
				return Enumerable.Empty<ExtensionSubtag>().GetEnumerator();
			else
				return _sortedList.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static ExtensionSubtagCollection TryParse(LanguageTag.TokenEnumerator tokens)
		{
			var result = new ExtensionSubtagCollection();
			var subtag = ExtensionSubtag.TryParse(tokens);

			if (subtag.HasValue)
			{
				result._sortedList = new List<ExtensionSubtag>();
				do
				{
					result.Append(subtag.Value);
					subtag = ExtensionSubtag.TryParse(tokens);
				}
				while (subtag.HasValue);
			}

			return result;
		}
	}
}
