using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	internal static class InternalExtensions
	{
		public static bool IsSet(this LanguageTagField checking, LanguageTagField test)
		{
			return (checking & test) == test;
		}

		public static bool IsEquivalent(this IList<Variant> x, IList<Variant> y)
		{
			if (x == null)
				return y == null;

			if (y == null)
				return false;

			if (x.Count != y.Count)
				return false;

			for (int i = 0; i < x.Count; i++)
				if (x[i] != y[i])
					return false;

			return true;
		}

	}
}
