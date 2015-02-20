using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public class VariantCollection : IEnumerable<Variant>
	{
		public static readonly VariantCollection Empty = new VariantCollection();

		private List<Variant> _prefix = new List<Variant>();
		private List<Variant> _options = new List<Variant>();

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

			return _prefix.IsEquivalent(other._prefix) &&
				_options.IsEquivalent(other._options);
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
			return _prefix.GetHashCodeOfSequence() ^
				_options.GetHashCodeOfSequence();
		}

		internal void Append(Variant item, bool restrictive)
		{
			if (restrictive)
			{
				if (_prefix.Contains(item))
					return;

				_prefix.Add(item);
			}
			else
			{
				var index = _options.BinarySearch(item);
				if (index < 0)
				{
					_options.Insert(~index, item);
				}
			}
		}

		public bool Contains(Variant item)
		{
			return _prefix.Contains(item) ||
				_options.Contains(item);
		}

		public IEnumerator<Variant> GetEnumerator()
		{
			return _prefix.Union(_options).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.IEnumerable)_prefix.Union(_options)).GetEnumerator();
		}
	}
}
