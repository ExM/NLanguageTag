using System;
using System.Collections.Generic;

namespace NLanguageTag
{
	internal static class CollectionUtils
	{
		internal static int GetHashCodeOfStructSequence<T>(this IEnumerable<T>? items) where T : struct
		{
			if (items is null)
				return 0;

			unchecked
			{
				var hash = 19;
				foreach (var i in items)
				{
					hash = hash * 31 + i.GetHashCode();
				}
				return hash;
			}
		}

		internal static int GetHashCodeOfClassSequence<T>(this IEnumerable<T>? items) where T : class
		{
			if (items is null)
				return 0;

			unchecked
			{
				var hash = 19;
				foreach (var i in items)
				{
					hash = hash * 31 + (i?.GetHashCode() ?? 0);
				}
				return hash;
			}
		}

		internal static bool IsEquivalentTo<T>(this IReadOnlyList<T>? x, IReadOnlyList<T>? y) where T : IEquatable<T>
		{
			if (ReferenceEquals(x, y))
				return true;

			if (x is null || y is null)
				return false;

			if (x.Count != y.Count)
				return false;

			for (var i = 0; i < x.Count; i++)
			{
				if (!x[i].Equals(y[i]))
					return false;
			}

			return true;
		}

		internal static bool IsEquivalentTo(this IEnumerable<Variant>? x, IEnumerable<Variant>? y)
		{
			if (ReferenceEquals(x, y))
				return true;

			if (x is null || y is null)
				return false;

			using var xEn = x.GetEnumerator();
			using var yEn = y.GetEnumerator();

			while (true)
			{
				if (!xEn.MoveNext())
					return !yEn.MoveNext();

				if (!yEn.MoveNext())
					return false;

				if (xEn.Current != yEn.Current)
					return false;
			}
		}
	}
}