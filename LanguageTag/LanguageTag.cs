using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	/// <summary>
	/// Language tags are used to help identify languages, whether spoken, written, signed, or otherwise signaled, for the purpose of communication.
	/// Language tag syntax is defined by the IETF's BCP 47 (https://tools.ietf.org/html/bcp47) 
	/// and corresponds to the IANA Language Subtag Registry (http://www.iana.org/assignments/language-subtag-registry/language-subtag-registry) of 2016-06-10
	/// </summary>
	public partial struct LanguageTag : IEquatable<LanguageTag>
	{
		internal const char TagSeparator = '-';

		/// <summary>
		/// Assigned properties of language subtag
		/// </summary>
		public Field Fields { get; private set; }

		private Language? _language;

		/// <summary>
		/// The primary language subtag is the first subtag in a language tag.
		/// </summary>
		public Language? Language
		{
			get { return _language; }
			private set
			{
				_language = value;
				Fields |= Field.Language;
			}
		}

		private Script? _script;
		
		/// <summary>
		/// Script subtags are used to indicate the script or writing system variations
		/// that distinguish the written forms of a language or its dialects
		/// </summary>
		public Script? Script
		{
			get { return _script; }
			private set
			{
				if (!value.HasValue) return;
				if (Language.Value.GetSupressScript() == value) return;
				_script = value;
				Fields |= Field.Script;
			}
		}

		private Region? _region;

		/// <summary>
		/// Region subtags are used to indicate linguistic variations associated
		/// with or appropriate to a specific country, territory, or region.
		/// </summary>
		public Region? Region
		{
			get { return _region; }
			private set
			{
				if (!value.HasValue) return;
				_region = value;
				Fields |= Field.Region;
			}
		}

		private VariantCollection _variants;

		/// <summary>
		/// Variant subtags are used to indicate additional, well-recognized variations that define a
		/// language or its dialects that are not covered by other available subtags.
		/// </summary>
		public VariantCollection Variants
		{
			get { return _variants; }
			private set
			{
				if (value.IsEmpty) return;
				_variants = value;
				Fields |= Field.Variants;
			}
		}

		private ExtensionSubtagCollection _extensions;

		/// <summary>
		/// Extensions provide a mechanism for extending language tags for use in various applications.
		/// </summary>
		public ExtensionSubtagCollection Extensions
		{
			get { return _extensions; }
			private set
			{
				if (value.IsEmpty)
					return;

				_extensions = value;
				Fields |= Field.Extensions;
			}
		}

		private PrivateUseSubtags _privateUse;

		/// <summary>
		/// Private use subtags are used to indicate distinctions in language
		/// that are important in a given context by private agreement.
		/// </summary>
		public PrivateUseSubtags PrivateUse
		{
			get { return _privateUse; }
			private set
			{
				if (value.IsEmpty)
					return;

				_privateUse = value;
				Fields |= Field.PrivateUse;
			}
		}

		public LanguageTag(PrivateUseSubtags privateUseSubtags)
			: this()
		{
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(string text)
			: this()
		{
			try
			{
				InternalParse(text);
			}
			catch (FormatException ex)
			{
				throw new FormatException("unexpected language tag '" + text + "'", ex);
			}
		}

		public static LanguageTag Parse(string text)
		{
			return new LanguageTag(text);
		}

		public static bool TryParse(string text, out LanguageTag result)
		{
			result = new LanguageTag();
			try
			{
				result.InternalParse(text);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public static LanguageTag? TryParse(string text)
		{
			var result = new LanguageTag();

			try
			{
				result.InternalParse(text);
				return result;
			}
			catch(FormatException)
			{
				return null;
			}
		}

		private void InternalParse(string text)
		{
			if (text == null)
				throw new ArgumentNullException("text");

			if (text.Length == 0)
				return;

			var gf = Grandfathered.GetPreferredValue(text);
			if (gf != null)
				text = gf;

			var tokens = new TokenEnumerator(text);

			if (tokens.TokenIs(PrivateUseSubtags.Singleton))
			{
				PrivateUse = PrivateUseSubtags.Parse(tokens);
				return;
			}

			Language = tokens.ParseLanguage();

			if(!tokens.CurrentTokenAvailable)
				return;

			Script = tokens.TryParseScript();

			if (!tokens.CurrentTokenAvailable)
				return;

			Region = tokens.TryParseRegion();

			if (!tokens.CurrentTokenAvailable)
				return;

			Variants = VariantCollection.TryParse(Language, Script, tokens);

			if (!tokens.CurrentTokenAvailable)
				return;

			Extensions = ExtensionSubtagCollection.TryParse(tokens);

			if (!tokens.CurrentTokenAvailable)
				return;

			PrivateUse = PrivateUseSubtags.Parse(tokens);
		}

		public bool Included(LanguageTag other)
		{
			if (other.Language.HasValue && other.Language != Language)
				return false;

			if (other.Script.HasValue && other.Script != Script)
				return false;

			if (other.Region.HasValue && other.Region != Region)
				return false;

			if (other.Variants.Except(Variants).Any())
				return false;

			if (other.Extensions.Except(Extensions).Any())
				return false;

			if (!other.PrivateUse.IsEmpty && other.PrivateUse != PrivateUse)
				return false;

			return true;
		}

		public static bool operator >=(LanguageTag a, LanguageTag b)
		{
			return a.Included(b);
		}

		public static bool operator <=(LanguageTag a, LanguageTag b)
		{
			return b.Included(a);
		}

		private IEnumerable<string> SubtagsAsText()
		{
			if (Language.HasValue)
				yield return Language.Value.ToText();

			if (Script.HasValue)
				yield return Script.Value.ToText();

			if (Region.HasValue)
				yield return Region.Value.ToText();

			foreach (var v in Variants)
				yield return v.ToText();

			foreach (var ext in _extensions)
				foreach(var subtag in ext.SubtagElements())
					yield return subtag;

			foreach (var subtag in PrivateUse.SubtagElements())
					yield return subtag;
		}

		/// <summary>
		/// Returns a string that represents the current language tag.
		/// </summary>
		public override string ToString()
		{
			return string.Join(TagSeparator.ToString(), SubtagsAsText());
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
			return obj is LanguageTag &&
				Equals((LanguageTag)obj);
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
		/// Not equality operator
		/// </summary>
		public static bool operator !=(LanguageTag a, LanguageTag b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Assigned properties of language subtag
		/// </summary>
		[Flags]
		public enum Field : byte
		{
			/// <summary>
			/// Nothing
			/// </summary>
			None = 0x00,

			/// <summary>
			/// Primary language subtag
			/// </summary>
			Language = 0x01,

			/// <summary>
			/// Script subtag
			/// </summary>
			Script = 0x02,

			/// <summary>
			/// Region subtag
			/// </summary>
			Region = 0x04,

			/// <summary>
			/// Variant subtags
			/// </summary>
			Variants = 0x08,

			/// <summary>
			/// Extension subtags
			/// </summary>
			Extensions = 0x10,

			/// <summary>
			/// Private use subtags
			/// </summary>
			PrivateUse = 0x20,

			/// <summary>
			/// Most commonly used (Language, Script, Region)
			/// </summary>
			Primary = Language | Script | Region,

			/// <summary>
			/// Subtags enumerated in the BCP47 (Language, Script, Region, Variants)
			/// </summary>
			Enumerated = Primary | Variants,

			/// <summary>
			/// All subtags
			/// </summary>
			All = Enumerated | Extensions | PrivateUse
		}

		internal class TokenEnumerator
		{
			public TokenEnumerator(string text)
			{
				Source = text;
				CurrentTokenPosition = 0;

				if (string.IsNullOrEmpty(text))
				{
					Token = string.Empty;
					NextTokenPosition = null;
				}
				else
				{
					NextTokenPosition = 0;
					ToNextToken();
				}
			}

			public string Source { get; private set; }

			public string Token { get; private set; }

			public bool TokenIs(string token)
			{
				return string.Equals(Token, token, StringComparison.OrdinalIgnoreCase);
			}

			public int CurrentTokenPosition { get; private set; }

			public int? NextTokenPosition { get; private set; }

			public bool NextTokenAvailable { get { return NextTokenPosition.HasValue; } }

			public bool CurrentTokenAvailable { get { return Token != null; } }

			public void ToNextToken()
			{
				if (!NextTokenPosition.HasValue)
				{
					Token = null;
					CurrentTokenPosition = Source.Length;
					return;
				}

				int pos = Source.IndexOf(LanguageTag.TagSeparator, NextTokenPosition.Value);

				CurrentTokenPosition = NextTokenPosition.Value;

				if (pos == -1)
				{
					Token = Source.Substring(NextTokenPosition.Value);
					NextTokenPosition = null;
				}
				else
				{
					Token = Source.Substring(NextTokenPosition.Value, pos - NextTokenPosition.Value);
					NextTokenPosition = pos + 1;
				}
			}
		}
	}
}
