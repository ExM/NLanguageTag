using System;
using System.Linq;
using System.Text;

namespace NLanguageTag
{
	/// <summary>
	/// Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication.
	/// Language tag syntax is defined by the IETF's BCP 47 (https://tools.ietf.org/html/bcp47)
	/// and corresponds to the IANA Language Subtag Registry (http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry) of 2016-10-12
	/// </summary>
	public readonly partial struct LanguageTag : IEquatable<LanguageTag>
	{
		internal const char TagSeparator = '-';

		/// <summary>
		/// Assigned properties of language subtag
		/// </summary>
		public Field Fields { get; }

		/// <summary>
		/// The primary language subtag is the first subtag in a language tag
		/// </summary>
		public Language? Language { get; }

		/// <summary>
		/// Script subtags are used to indicate the script or writing system variations
		/// that distinguish the written forms of a language or its dialects
		/// </summary>
		public Script? Script { get; }

		/// <summary>
		/// Region subtags are used to indicate linguistic variations associated
		/// with or appropriate to a specific country, territory, or region.
		/// </summary>
		public Region? Region { get; }

		/// <summary>
		/// Variant subtags are used to indicate additional, well-recognized variations that define a
		/// language or its dialects that are not covered by other available subtags.
		/// </summary>
		public VariantCollection Variants { get; }

		/// <summary>
		/// Extensions provide a mechanism for extending language tags for use in various applications.
		/// </summary>
		public ExtensionSubtagCollection Extensions { get; }

		/// <summary>
		/// Private use subtags are used to indicate distinctions in language
		/// that are important in a given context by private agreement.
		/// </summary>
		public PrivateUseSubtags PrivateUse { get; }

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		private LanguageTag(
			Language? language,
			Script? script,
			Region? region,
			VariantCollection variants,
			ExtensionSubtagCollection extensions,
			PrivateUseSubtags privateUse)
		{
			if (language.HasValue && script.HasValue)
			{
				var suppressScript = language.Value.GetSuppressScript();
				if (suppressScript.HasValue && suppressScript.Value == script.Value)
				{
					script = null;
				}
			}

			Language = language;
			Script = script;
			Region = region;
			Variants = variants;
			Extensions = extensions;
			PrivateUse = privateUse;

			var fields = Field.None;
			if (language.HasValue)
			{
				fields |= Field.Language;
			}
			if (script.HasValue)
			{
				fields |= Field.Script;
			}
			if (region.HasValue)
			{
				fields |= Field.Region;
			}
			if (!variants.IsEmpty)
			{
				fields |= Field.Variants;
			}
			if (!extensions.IsEmpty)
			{
				fields |= Field.Extensions;
			}
			if (!privateUse.IsEmpty)
			{
				fields |= Field.PrivateUse;
			}

			Fields = fields;
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		public LanguageTag(PrivateUseSubtags privateUseSubtags)
			: this(null, null, null, default, default, privateUseSubtags)
		{
		}

		/// <summary>
		/// Parses <see cref="LanguageTag"/> value from its text representation
		/// </summary>
		/// <param name="text">text representation of language tag</param>
		/// <exception cref="FormatException">
		/// the text was not a correct text representation of a language tag
		/// </exception>
		public static LanguageTag Parse(string text)
		{
			if (TryParse(text, out var result))
			{
				return result;
			}

			throw new FormatException($"Invalid language tag: {text}");
		}

		/// <summary>
		/// Tries to parse <see cref="LanguageTag"/> value from its text representation
		/// </summary>
		/// <param name="text">text representation of language tag</param>
		/// <param name="result">parsed value</param>
		/// <returns>true if parsing was successful, false otherwise</returns>
		public static bool TryParse(string text, out LanguageTag result)
		{
			var tokens = new TokenEnumerator(Grandfathered.GetPreferredValue(text) ?? text);

			if (tokens.TokenIs(PrivateUseSubtags.Singleton))
			{
				// This tag starts with private use subtags
				var immediatePrivateUseResult = PrivateUseSubtags.Parse(tokens);

				var error = immediatePrivateUseResult.NothingToParse || immediatePrivateUseResult.ErrorOccured ||
					tokens.CurrentTokenAvailable;

				if (error)
				{
					// But they are invalid
					result = default;
					return false;
				}

				result = new LanguageTag(immediatePrivateUseResult.Result);
				return true;
			}

			var language = tokens.TryParseLanguage();
			if (!language.HasValue)
			{
				// If language tag is not entirely private use subtags, it must contain language
				result = default;
				return false;
			}

			// These two cannot produce error during parsing
			var script = tokens.TryParseScript();
			var region = tokens.TryParseRegion();

			// These three can
			var variantsResult = VariantCollection.Parse(language, script, tokens);
			if (variantsResult.ErrorOccured)
			{
				result = default;
				return false;
			}

			var extensionsResult = ExtensionSubtagCollection.Parse(tokens);
			if (extensionsResult.ErrorOccured)
			{
				result = default;
				return false;
			}

			var privateUseResult = PrivateUseSubtags.Parse(tokens);
			if (privateUseResult.ErrorOccured)
			{
				result = default;
				return false;
			}

			if (tokens.CurrentTokenAvailable)
			{
				// Something left unparsed
				result = default;
				return false;
			}

			var variants = variantsResult.NothingToParse ? default : variantsResult.Result;
			var extensions = extensionsResult.NothingToParse ? default : extensionsResult.Result;
			var privateUse = privateUseResult.NothingToParse ? default : privateUseResult.Result;

			result = new LanguageTag(language, script, region, variants, extensions, privateUse);
			return true;
		}

		/// <summary>
		/// Tries to parse <see cref="LanguageTag"/> value from its text representation
		/// </summary>
		/// <param name="text">text representation of language tag</param>
		/// <returns>parsed value if parsing was successful, null otherwise</returns>
		public static LanguageTag? TryParse(string text)
		{
			return TryParse(text, out var result) ? result : (LanguageTag?)null;
		}

		/// <summary>
		/// Determines whether this tag is subset of <paramref name="other"/>
		/// (meaning each subtag of this tag is also subtag of <paramref name="other"/>)
		/// </summary>
		public bool IsSubsetOf(LanguageTag other)
		{
			if (Language.HasValue && other.Language != Language)
				return false;

			if (Script.HasValue && other.Script != Script)
				return false;

			if (Region.HasValue && other.Region != Region)
				return false;

			if (Variants.Except(other.Variants).Any())
				return false;

			if (Extensions.Except(other.Extensions).Any())
				return false;

			return PrivateUse.IsEmpty || other.PrivateUse == PrivateUse;
		}

		/// <summary>
		/// Returns a string that represents the current language tag.
		/// </summary>
		public override string ToString()
		{
			var result = new StringBuilder(16);

			if (Language.HasValue)
				appendSubtag(result, Language.Value.ToText());

			if (Script.HasValue)
				appendSubtag(result, Script.Value.ToText());

			if (Region.HasValue)
				appendSubtag(result, Region.Value.ToText());

			foreach (var v in Variants)
				appendSubtag(result, v.ToText());

			foreach (var ext in Extensions)
				foreach (var subtag in ext.GetSubtagElements())
					appendSubtag(result, subtag);

			foreach (var subtag in PrivateUse.GetSubtagElements())
				appendSubtag(result, subtag);

			return result.ToString();
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		public bool Equals(LanguageTag other)
		{
			return Language == other.Language &&
				Script == other.Script &&
				Region == other.Region &&
				Variants == other.Variants &&
				Extensions == other.Extensions &&
				PrivateUse == other.PrivateUse;
		}

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		public override bool Equals(object? obj)
		{
			return obj is LanguageTag languageTag && Equals(languageTag);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return Language.GetHashCode() ^
				Script.GetHashCode() ^
				Region.GetHashCode() ^
				Variants.GetHashCode() ^
				Extensions.GetHashCode() ^
				PrivateUse.GetHashCode();
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		public static bool operator ==(LanguageTag a, LanguageTag b)
		{
			return a.Equals(b);
		}

		/// <summary>
		/// Inequality operator
		/// </summary>
		public static bool operator !=(LanguageTag a, LanguageTag b)
		{
			return !(a == b);
		}

		private static void appendSubtag(StringBuilder builder, string subtag)
		{
			if (builder.Length > 0)
				builder.Append(TagSeparator);

			builder.Append(subtag);
		}
	}
}