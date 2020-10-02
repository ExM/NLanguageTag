using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag
{
	/// <summary>
	/// Collection of variant subtags
	/// </summary>
	public readonly struct VariantCollection : IEnumerable<Variant>, IEquatable<VariantCollection>
	{
		private VariantCollection(Variant[] variants)
		{
			_variants = variants.Length > 0 ? variants : null;
		}

		/// <summary>
		/// Creates new variant collection from the specified variants, while checking their applicability to
		/// the specified language and script
		/// </summary>
		public static VariantCollection Create(Language? language, Script? script, IEnumerable<Variant>? variants)
		{
			if (variants is null)
				return default;

			Builder? builder = null;

			foreach (var variant in variants)
			{
				if (builder is null)
					builder = new Builder(language, script);

				if (!builder.TryAppend(variant))
					throw new FormatException("Invalid variants for given language and script");
			}

			return builder is null ? default : builder.ToCollection();
		}

		/// <summary>
		/// Indicates whether this collection contains no elements
		/// </summary>
		public bool IsEmpty => _variants is null;

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object? other)
		{
			return other is VariantCollection variantCollection && Equals(variantCollection);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(VariantCollection other)
		{
			var v1 = _variants;
			var v2 = other._variants;

			if (ReferenceEquals(v1, v2))
				return true;

			if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null))
				return false;

			if (v1.Length != v2.Length)
				return false;

			for (var i = 0; i < v1.Length; i++)
				if (v1[i] != v2[i])
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
		/// Inequality operator
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
			return _variants.GetHashCodeOfStructSequence();
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		public IEnumerator<Variant> GetEnumerator()
		{
			var variants = _variants ?? Enumerable.Empty<Variant>();
			return variants.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static PartialParseResult<VariantCollection> Parse(
			Language? lang,
			Script? script,
			TokenEnumerator tokens)
		{
			var variant = tokens.TryParseVariant();
			if (!variant.HasValue)
				return PartialParseResult<VariantCollection>.Empty;

			var builder = new Builder(lang, script);

			do
			{
				if (!builder.TryAppend(variant.Value))
				{
					return PartialParseResult<VariantCollection>.Error;
				}

				variant = tokens.TryParseVariant();
			}
			while (variant.HasValue);

			return PartialParseResult<VariantCollection>.Success(builder.ToCollection());
		}

		// Since this is value type, there is no way to prevent it being in the default state.
		// The natural meaning for the default state is an empty collection.
		// We will treat this field being null as empty collection, and also store null here if this value
		// is initialized as empty collection.
		private readonly Variant[]? _variants;

		private sealed class Builder : IReadOnlyList<Variant>
		{
			public Builder(Language? lang, Script? script)
			{
				_lang = lang;
				_script = script;
			}

			public bool TryAppend(Variant item)
			{
				var restrictive = item.RestrictiveAcceptableFor(_lang, _script, this);
				if (!restrictive.HasValue)
					return false;

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

				return true;
			}

			public VariantCollection ToCollection()
			{
				var count = _prefix.Count + _options.Count;
				var variants = new Variant[count];

				_prefix.CopyTo(variants);
				_options.CopyTo(variants, _prefix.Count);

				return new VariantCollection(variants);
			}

			public int Count => _prefix.Count + _options.Count;

			public Variant this[int index] => index < _prefix.Count
				? _prefix[index]
				: _options[index - _prefix.Count];

			public IEnumerator<Variant> GetEnumerator()
			{
				foreach (var v in _prefix)
					yield return v;

				foreach (var v in _options)
					yield return v;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			private readonly Language? _lang;
			private readonly Script? _script;

			private readonly List<Variant> _prefix = new List<Variant>();
			private readonly List<Variant> _options = new List<Variant>();
		}
	}
}