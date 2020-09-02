using System.Collections.Generic;

namespace NLanguageTag
{
	/// <summary>
	/// Extension methods for processing language tags and subtags
	/// </summary>
	public static class LanguageTagExtensions
	{
		/// <summary>
		/// Converts given language subtag to combination of language subtag and extlang subtag, where possible
		/// (and simply converts language tag to string where not possible)
		/// </summary>
		public static string ToExtLanguage(this Language lang)
		{
			var prefix = lang.Prefix;
			if (prefix == null)
				return lang.ToString();

			return prefix.TextCode + LanguageTag.TagSeparator + lang.TextCode;
		}

		/// <summary>
		/// Parses region subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Region? TryParseRegion(this string text)
		{
			return Region.TryParse(text);
		}

		/// <summary>
		/// Parses script subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Script? TryParseScript(this string text)
		{
			return Script.TryParse(text);
		}

		/// <summary>
		/// Parses variant subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Variant? TryParseVariant(this string text)
		{
			return Variant.TryParse(new StringSpan(text.ToLowerInvariant()));
		}

		/// <summary>
		/// Determines the proper language subtag that should be used instead of given combination of
		/// language subtag and extlang subtag
		/// </summary>
		/// <param name="text">text that can possibly be extlang subtag</param>
		/// <param name="prefix">the main language subtag</param>
		public static Language? TryParseFromExtLanguage(this string text, Language prefix)
		{
			return prefix.TryParseFromExtLanguage(new StringSpan(text.ToLowerInvariant()));
		}
	}
}
