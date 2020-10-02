using System.Collections.Generic;

namespace NLanguageTag
{
	/// <summary>
	/// Extension methods for processing language tags and subtags
	/// </summary>
	public static partial class LanguageTagExtensions
	{
		/// <summary>
		/// Returns language tags that can be appended by given variant
		/// </summary>
		public static IReadOnlyCollection<LanguageTag> GetPrefixes(this Variant v)
		{
			return VariantPrefixCache.GetPrefixes(v);
		}

		/// <summary>
		/// Converts given language subtag to combination of language subtag and extlang subtag, where possible
		/// (and simply converts language tag to string where not possible)
		/// </summary>
		public static string ToExtLanguage(this Language lang)
		{
			var prefix = lang.GetPrefix();
			return prefix.HasValue
				? prefix.Value.ToText() + LanguageTag.TagSeparator + lang.ToText()
				: lang.ToText();
		}
	}
}