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
			if (prefix is null)
				return lang.ToString();

			return prefix.TextCode + LanguageTag.TagSeparator + lang.TextCode;
		}

		/// <summary>
		/// Parses language subtag from its string representation, returns null if parsing was not successful
		/// </summary>
		public static Language? TryParseLanguage(this string text)
		{
			return Language.TryParse(text);
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
	}
}