using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public class VariantCollection : IList<Variant>
	{
		public static readonly VariantCollection Empty = new VariantCollection();

		private List<Variant> _list = new List<Variant>();

		public VariantCollection()
		{
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as VariantCollection);
		}

		public bool Equals(VariantCollection other)
		{
			if (object.ReferenceEquals(null, other))
				return false;

			if (object.ReferenceEquals(this, other))
				return true;

			if (Count != other.Count)
				return false;

			var contain = new HashSet<Variant>(_list);
			contain.ExceptWith(other);

			return !contain.Any();
		}

		public static bool operator ==(VariantCollection a, VariantCollection b)
		{
			if (object.ReferenceEquals(null, a))
				return object.ReferenceEquals(null, b);

			return a.Equals(b);
		}

		public static bool operator !=(VariantCollection a, VariantCollection b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			var result = 0;
			foreach (var v in _list)
				result ^= v.GetHashCode();
			return result;
		}

		public VariantCollection(IEnumerable<Variant> variants)
		{
			foreach (var v in variants)
				Append(v);
		}

		internal void Append(Variant item)
		{
			if (_list.Contains(item))
				return;

			_list.Add(item);
		}

		public int IndexOf(Variant item)
		{
			return _list.IndexOf(item);
		}

		public void Insert(int index, Variant item)
		{
			throw new NotSupportedException("this is readonly collection");
		}

		public void RemoveAt(int index)
		{
			throw new NotSupportedException("this is readonly collection");
		}

		public Variant this[int index]
		{
			get
			{
				return _list[index];
			}
			set
			{
				throw new NotSupportedException("this is readonly collection");
			}
		}

		public void Add(Variant item)
		{
			throw new NotSupportedException("this is readonly collection");
		}

		public void Clear()
		{
			throw new NotSupportedException("this is readonly collection");
		}

		public bool Contains(Variant item)
		{
			return _list.Contains(item);
		}

		public void CopyTo(Variant[] array, int arrayIndex)
		{
			_list.CopyTo(array, arrayIndex);
		}

		public int Count
		{
			get { return _list.Count; }
		}

		public bool IsReadOnly
		{
			get { return true; }
		}

		public bool Remove(Variant item)
		{
			throw new NotSupportedException("this is readonly collection");
		}

		public IEnumerator<Variant> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)_list).GetEnumerator();
		}
	}
}
