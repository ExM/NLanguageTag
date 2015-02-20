using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public struct LanguageTag
	{
		internal const char TagSeparator = '-';

		private static readonly ISet<string> _emptyPrivateUse = new HashSet<string>(); //TODO implement read only collection

		public LanguageTagField Fields { get; private set; }

		private Language? _language;

		public Language? Language
		{
			get { return _language; }
			private set
			{
				if (!value.HasValue) return;
				_language = value;
				Fields |= LanguageTagField.Language;
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
				Fields |= LanguageTagField.Script;
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
				Fields |= LanguageTagField.Region;
			}
		}

		private VariantCollection _variants;

		public VariantCollection Variants { get { return _variants ?? VariantCollection.Empty; } }

		private void Set(Variant variant)
		{
			var restrictive = this.IsRestrictivePrefixFor(variant);
			if (!restrictive.HasValue)
				throw new FormatException("variant subtag '" + variant + "' is unacceptable");

			if (_variants == null)
			{
				_variants = new VariantCollection();
				Fields |= LanguageTagField.Variants;
			}

			_variants.Append(variant, restrictive.Value);
		}

		private ExtensionSubtagCollection _extensions;

		public ExtensionSubtagCollection Extensions { get { return _extensions; } }

		private void Set(ExtensionSubtag extSubtag)
		{
			_extensions.Append(extSubtag);
			Fields |= LanguageTagField.Extensions;
		}

		private ISet<string> _privateUse;

		public ISet<string> PrivateUse
		{
			get
			{
				return _privateUse ?? _emptyPrivateUse;
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
			foreach (var v in variants)
				Set(v);
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

			if (text.StartsWith("x-", StringComparison.Ordinal))
			{
				ParsePrivateUse(text, 0);
				return;
			}

			int tokenIndex;
			Language = text.TryParseFromLanguageToken(out tokenIndex);

			if (!Language.HasValue)
				throw new FormatException("unexpected language '" + text.Substring(0, tokenIndex - 1) + "'");

			if (text.Length == tokenIndex)
				return;

			Script = text.TryParseFromScriptToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return;

			Region = text.TryParseFromRegionToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return;

			var variant = text.TryParseFromVariantToken(ref tokenIndex);
			while (variant.HasValue)
			{
				Set(variant.Value);
				variant = text.TryParseFromVariantToken(ref tokenIndex);
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

			ParsePrivateUse(text, tokenIndex);
		}

		private void ParsePrivateUse(string text, int nextToken)
		{

			//TODO ParsePrivateUse
			throw new NotImplementedException();
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


			//TODO: check Extension and PrivateUse

			return true;
		}

		public bool Equals(LanguageTag other, LanguageTagField checking)
		{
			if (checking.IsSet(LanguageTagField.Language) &&
				Language != other.Language)
				return false;

			if (checking.IsSet(LanguageTagField.Script) &&
				Script != other.Script)
				return false;

			if (checking.IsSet(LanguageTagField.Region) &&
				Region != other.Region)
				return false;

			if (checking.IsSet(LanguageTagField.Variants) &&
				Variants != other.Variants)
				return false;

			if (checking.IsSet(LanguageTagField.Extensions) &&
				Extensions != other.Extensions)
				return false;
			
			//TODO: check PrivateUse

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

			//TODO: check PrivateUse
		}

		public override string ToString()
		{
			return string.Join(TagSeparator.ToString(), SubtagsAsText());
		}
	}
}
