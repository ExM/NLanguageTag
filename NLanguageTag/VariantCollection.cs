using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AbbyyLS.Globalization.Bcp47
{
	/// <summary>
	/// Collection of variant subtags
	/// </summary>
	public struct VariantCollection : IEnumerable<Variant>, IEquatable<VariantCollection>
	{
		private Variant[] _variants;

		/// <summary>
		/// Create collection of variant subtags
		/// </summary>
		public VariantCollection(params Variant[] variants)
			:this()
		{
			if (variants.Length != 0)
				_variants = variants;
		}

		public static VariantCollection Create(Language? lang, Script? script, IEnumerable<Variant> variants)
		{
			VariantCollection.Builder builder = null;
			foreach(var variant in variants)
			{
				if (builder == null)
					builder = new VariantCollection.Builder(lang, script);
				
				builder.Append(variant);
			}

			return (builder == null) ? new VariantCollection() : builder.ToCollection();
		}

		/// <summary>
		/// This collection not contain elements
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				return _variants == null;
			}
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object other)
		{
			return other is VariantCollection &&
				Equals((VariantCollection)other);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
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

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(VariantCollection a, VariantCollection b)
		{
			return a.Equals(b);
		}

		/// <summary>
		/// Not equality operator
		/// </summary>
		public static bool operator !=(VariantCollection a, VariantCollection b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return _variants.GetHashCodeOfSequence();
		}

		/// <summary>
		/// Determines whether a sequence contains a specified element
		/// </summary>
		public bool Contains(Variant item)
		{
			if (_variants == null)
				return false;
			return _variants.Contains(item);
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
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

		internal static VariantCollection TryParse(Language? lang, Script? script, LanguageTag.TokenEnumerator tokens)
		{
			var variant = tokens.TryParseVariant();
			if (!variant.HasValue)
				return new VariantCollection();
			
			var builder = new VariantCollection.Builder(lang, script);

			do
			{
				builder.Append(variant.Value);
				variant = tokens.TryParseVariant();
			}
			while (variant.HasValue);

			return builder.ToCollection();
		}

		private class Builder: IEnumerable<Variant>
		{
			private Language? _lang;
			private Script? _script;

			private List<Variant> _prefix = new List<Variant>();
			private List<Variant> _options = new List<Variant>();

			public Builder(Language? lang, Script? script)
			{
				_lang = lang;
				_script = script;
			}

			public void Append(Variant item)
			{
				var restrictive = item.RestrictiveAcceptableFor(_lang, _script, this);
				if (!restrictive.HasValue)
					throw new FormatException("variant subtag '" + item + "' is unacceptable");

				if (restrictive.Value)
				{
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
				foreach (var v in _prefix)
					yield return v;

				foreach (var v in _options)
					yield return v;
			}

			public VariantCollection ToCollection()
			{
				var count = _prefix.Count + _options.Count;
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
