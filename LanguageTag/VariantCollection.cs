using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public struct VariantCollection : IEnumerable<Variant>, IEquatable<VariantCollection>
	{
		private Variant[] _variants;

		public VariantCollection(params Variant[] variants)
			:this()
		{
			if (variants.Length != 0)
				_variants = variants;
		}

		public bool IsEmpty
		{
			get
			{
				return _variants == null;
			}
		}

		public override bool Equals(object other)
		{
			return other is VariantCollection &&
				Equals((VariantCollection)other);
		}

		public bool Equals(VariantCollection other)
		{
			if (_variants == null)
				return other._variants == null;

			if (other._variants == null)
				return false;

			if (_variants.Length != other._variants.Length)
				return false;

			for (int i = 0; i < _variants.Length; i++)
				if (_variants[i] != other._variants[i])
					return false;

			return true;
		}

		public static bool operator ==(VariantCollection a, VariantCollection b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(VariantCollection a, VariantCollection b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return _variants.GetHashCodeOfSequence();
		}

		public bool Contains(Variant item)
		{
			if (_variants == null)
				return false;
			return _variants.Contains(item);
		}

		public IEnumerator<Variant> GetEnumerator()
		{
			if (_variants == null)
				return Enumerable.Empty<Variant>().GetEnumerator();
			return _variants.AsEnumerable().GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal class Builder: IEnumerable<Variant>
		{
			private List<Variant> _prefix = new List<Variant>();
			private List<Variant> _options = new List<Variant>();

			public Builder()
			{
			}

			public void Append(Language? lang, Script? script, Variant item)
			{
				var restrictive = item.RestrictiveAcceptableFor(lang, script, this);
				if (!restrictive.HasValue)
					throw new FormatException("variant subtag '" + item + "' is unacceptable");

				if (restrictive.Value)
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

			public IEnumerator<Variant> GetEnumerator()
			{
				return _prefix.Union(_options).GetEnumerator();
			}

			public VariantCollection ToCollection()
			{
				var count = _prefix.Count + _options.Count;
				if (count == 0)
					return new VariantCollection();

				var variants = new Variant[count];

				_prefix.CopyTo(variants);
				_options.CopyTo(variants, _prefix.Count);
				
				return new VariantCollection(variants);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}
		}
	}
}
