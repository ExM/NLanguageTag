using System;
using System.Linq;
using System.Text;

namespace NLanguageTag
{
	/// <summary>
	/// Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication.
	/// Language tag syntax is defined by the IETF's BCP 47 (https://tools.ietf.org/html/bcp47)
	/// and corresponds to the IANA Language Subtag T4Tools (http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry) of 2016-10-12
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
		public ExtensionSubtag PrivateUse { get; }

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		private LanguageTag(
			Language? language,
			Script? script,
			Region? region,
			VariantCollection variants,
			ExtensionSubtagCollection extensions,
			ExtensionSubtag privateUse)
		{
			if (language != null && script != null)
			{
				var suppressScript = language.SuppressScript;
				if (suppressScript != null && suppressScript == script)
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
			if (language != null)
			{
				fields |= Field.Language;
			}
			if (script != null)
			{
				fields |= Field.Script;
			}
			if (region !=  null)
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
				if(!privateUse.PrivateUse)
					throw new ArgumentOutOfRangeException(nameof(privateUse), "must be a private use subtag");
				fields |= Field.PrivateUse;
			}

			Fields = fields;
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		public LanguageTag(ExtensionSubtag privateUseSubtags)
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
			if(text == null)
				throw new ArgumentNullException(nameof(text));
			var tokens = new TokenEnumerator(Grandfathered.GetPreferredValue(text) ?? text);

			if (tokens.TokenIsPrivateUseSingleton())
			{
				// This tag starts with private use subtags
				var immediatePrivateUseResult = ExtensionSubtag.Parse(tokens, true);

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
			if (language == null)
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

			var privateUseResult = ExtensionSubtag.Parse(tokens, true);
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
			if (Language != null && other.Language != Language)
				return false;

			if (Script != null && other.Script != Script)
				return false;

			if (Region!= null && other.Region != Region)
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

			if (Language != null)
				appendSubtag(result, Language.TextCode);

			if (Script != null)
				appendSubtag(result, Script.TextCode);

			if (Region != null)
				appendSubtag(result, Region.TextCode);

			foreach (var v in Variants)
				appendSubtag(result, v.TextCode);

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
		public override bool Equals(object obj)
		{
			return obj is LanguageTag languageTag && Equals(languageTag);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		public override int GetHashCode()
		{
			return (Language == null ? 0 : Language.GetHashCode()) ^
				(Script == null ? 0 : Script.GetHashCode()) ^
				(Region == null ? 0 : Region.GetHashCode()) ^
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

		/// <summary>
		/// Contains is any private use subtags
		/// </summary>
		public bool ContainsPrivateUseSubtags =>
			(Language != null && Language.PrivateUse)
			|| (Script != null && Script.PrivateUse)
			|| (Region != null && Region.PrivateUse)
			|| !PrivateUse.IsEmpty;

		/// <summary>
		/// Contains is any deprecated subtags
		/// </summary>
		public bool ContainsDeprecatedSubtags =>
			(Language != null && Language.Deprecated)
			|| Variants.ContainsDeprecatedSubtags
			|| (Region != null && Region.Deprecated);
	}
}
