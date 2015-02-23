using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public struct LanguageTag : IEquatable<LanguageTag>
	{
		internal const char TagSeparator = '-';

		public Field Fields { get; private set; }

		private Language? _language;

		public Language? Language
		{
			get { return _language; }
			private set
			{
				if (!value.HasValue) return;
				_language = value;
				Fields |= Field.Language;
			}
		}

		private Script? _script;

		public Script? Script
		{
			get { return _script; }
			private set
			{
				if (!value.HasValue) return;
				
				if (Language.HasValue &&
					Language.Value.GetSupressScript() == value)
					return;

				_script = value;
				Fields |= Field.Script;
			}
		}

		private Region? _region;

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

		public ExtensionSubtagCollection Extensions { get { return _extensions; } }

		private void Set(ExtensionSubtag extSubtag)
		{
			_extensions.Append(extSubtag);
			Fields |= Field.Extensions;
		}

		private PrivateUseSubtags _privateUse;

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

		public LanguageTag(Language lang)
			: this()
		{
			Language = lang;
		}

		public LanguageTag(Language lang, Script? script)
			: this(lang)
		{
			Script = script;
		}

		public LanguageTag(Language lang, Region? region)
			: this(lang)
		{
			Region = region;
		}

		public LanguageTag(Language lang, Script? script, Region? region)
			: this(lang, script)
		{
			Region = region;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants)
			: this(lang, script, region)
		{
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);

			Variants = builder.ToCollection();
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

			if (text.StartsWith("x-", StringComparison.InvariantCultureIgnoreCase))
			{
				PrivateUse = PrivateUseSubtags.Parse(text);
				return;
			}

			int tokenIndex;
			Language = text.ParseFromLanguageToken(out tokenIndex);

			if (text.Length == tokenIndex)
				return;

			Script = text.TryParseFromScriptToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return;

			Region = text.TryParseFromRegionToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return;

			var variant = text.TryParseFromVariantToken(ref tokenIndex);
			if (variant.HasValue)
			{
				var builder = new VariantCollection.Builder();

				do
				{
					builder.Append(Language, Script, variant.Value);
					variant = text.TryParseFromVariantToken(ref tokenIndex);
				}
				while (variant.HasValue);

				Variants = builder.ToCollection();
			}

			if (text.Length == tokenIndex)
				return;

			var extSubtag = text.TryParseFromExtensionSubtagToken(ref tokenIndex);
			while(extSubtag.HasValue)
			{
				Set(extSubtag.Value);
				extSubtag = text.TryParseFromExtensionSubtagToken(ref tokenIndex);
			}

			if (text.Length == tokenIndex)
				return;

			PrivateUse = PrivateUseSubtags.Parse(text, tokenIndex);
		}

		public bool Contains(LanguageTag other)
		{
			if (other.Language.HasValue && other.Language != Language)
				return false;

			if (other.Script.HasValue && other.Script != Script)
				return false;

			if (other.Region.HasValue && other.Region != Region)
				return false;

			if (other.Variants.Except(Variants).Any())
				return false;

			//TODO: check Extension

			if (!other.PrivateUse.IsEmpty && other.PrivateUse != PrivateUse)
				return false;

			return true;
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

		public override string ToString()
		{
			return string.Join(TagSeparator.ToString(), SubtagsAsText());
		}

		public bool Equals(LanguageTag other)
		{
			return Language == other.Language &&
				Script == other.Script &&
				Region == other.Region &&
				Variants == other.Variants &&
				Extensions == other.Extensions &&
				PrivateUse == other.PrivateUse;
		}

		public override bool Equals(object obj)
		{
			return obj is LanguageTag &&
				Equals((LanguageTag)obj);
		}

		public override int GetHashCode()
		{
			return Language.GetHashCode() ^
				Script.GetHashCode() ^
				Region.GetHashCode() ^
				Variants.GetHashCode() ^
				Extensions.GetHashCode() ^
				PrivateUse.GetHashCode();
		}

		public static bool operator ==(LanguageTag a, LanguageTag b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(LanguageTag a, LanguageTag b)
		{
			return !(a == b);
		}

		[Flags]
		public enum Field : byte
		{
			None = 0x00,
			Language = 0x01,
			Script = 0x02,
			Region = 0x04,
			Variants = 0x08,
			Extensions = 0x10,
			PrivateUse = 0x20,

			Primary = Language | Script | Region,
			Published = Primary | Variants,
			All = Published | Extensions | PrivateUse
		}
	}
}
