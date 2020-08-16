using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.T4Tools
{
	public static class RegEntryExtensions
	{
		public static (string minKey, string maxKey) AsInterval(this IHaveSubtag entry)
		{
			var parts = entry.Subtag.Split(new string[] {".."}, StringSplitOptions.None);
			if(parts.Length != 2)
				return (null, null);

			return (parts[0], parts[1]);
		}

		private static string asPublicProperty(string text)
		{
			if(text == null || text.Length < 2)
				throw new NotSupportedException($"text {text} is too small");
			if (text.Length <= 2)
				return text.ToUpperInvariant();

			return char.ToUpper(text[0]) + text.Substring(1);
		}

		public static string CSharp_Name<T>(this T entry) where T : RegEntry, IHaveSubtag
		{
			if (entry is LanguageEntry)
				return entry.Subtag.ToUpperInvariant();

			return asPublicProperty(entry.FixDigitStart(entry.Subtag));
		}

		public static string CSharp_Preferred<T>(this T entry) where T : RegEntry, IHaveSubtag, IHavePreferredValue
		{
			if (entry.Subtag == null)
				throw new Exception("can't contain subtag");

			if (entry is LanguageEntry)
				return (entry.PreferredValue ?? entry.Subtag).ToUpperInvariant();

			return asPublicProperty(entry.FixDigitStart(entry.PreferredValue ?? entry.Subtag));
		}

		public static string CSharp_LanguageScope(this LanguageEntry entry)
		{
			if (entry.Scope == null)
				throw new Exception("can't contain subtag");

			return asPublicProperty(entry.Scope);

		}

		public static string CSharp_Macrolanguage(this LanguageEntry entry)
		{
			if (entry.Macrolanguage == null)
				throw new Exception("can't contain subtag");

			return asPublicProperty(entry.Macrolanguage.ToUpperInvariant());
		}

		public static IEnumerable<string> CSharp_Summary<T>(this T entry) where T : RegEntry, IHaveComments
		{
			IEnumerable<string> result = entry.Descriptions;
			if (entry.Comments != null)
				result = result.Append(entry.Comments);
			result = result.Append($"added: {entry.Added}");
			return result;
		}
	}
}