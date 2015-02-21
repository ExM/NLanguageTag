using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public struct ExtensionSubtagCollection : IEnumerable<ExtensionSubtag>, IEquatable<ExtensionSubtagCollection>
	{
		private List<ExtensionSubtag> _sortedList;

		public override bool Equals(object obj)
		{
			return obj is ExtensionSubtagCollection &&
				Equals((ExtensionSubtagCollection)obj);
		}

		internal void Append(ExtensionSubtag extSubtag)
		{
			if (_sortedList == null)
				_sortedList = new List<ExtensionSubtag>();

			var index = _sortedList.BinarySearch(extSubtag, ExtensionSubtag.SingletonComparer);
			if (index >= 0)
				throw new FormatException("duplicate extenson subtag with singletone `" + extSubtag.Singleton + "'");
			
			_sortedList.Insert(~index, extSubtag);
		}

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
	}
}
