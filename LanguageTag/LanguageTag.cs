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

		private static readonly IReadOnlyDictionary<Char, ISet<string>> _emptyExtensions = new Dictionary<Char, ISet<string>>(); //TODO implement read only collection
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
			if(!this.IsPrefixFor(variant))
				throw new FormatException("variant subtag '" + variant + "' is unacceptable");

			if (_variants == null)
			{
				_variants = new VariantCollection();
				Fields |= LanguageTagField.Variant;
			}

			_variants.Append(variant);
		}

		private IReadOnlyDictionary<Char, ISet<string>> _extensions;

		public IReadOnlyDictionary<Char, ISet<string>> Extensions
		{
			get
			{
				return _extensions ?? _emptyExtensions;
			}
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

		public LanguageTag(Language lang, Script script, Region region, IEnumerable<Variant> variants)
			: this(lang, script, region)
		{
			foreach (var v in variants)
				Set(v);
		}


		public LanguageTag(string text)
			: this()
		{
			var ex = InternalParse(text);
			if(ex != null)
				throw new FormatException("unexpected language tag '" + text + "'", ex);
		}


		public static LanguageTag Parse(string text)
		{
			return new LanguageTag(text);
		}

		public static bool TryParse(string text, out LanguageTag result)
		{
			result = new LanguageTag();
			return result.InternalParse(text) == null;
		}

		public static LanguageTag? TryParse(string text)
		{
			var result = new LanguageTag();

			if (result.InternalParse(text) == null)
				return result;
			else
				return null;
		}

		private Exception InternalParse(string text)
		{
			if (text == null)
				throw new ArgumentNullException("text");

			if (text.Length == 0)
				return null;

			var gf = Grandfathered.GetPreferredValue(text);
			if (gf != null)
				text = gf;

			if (text.StartsWith("x-", StringComparison.Ordinal))
				return ParsePrivateUse(text, 2);

			int tokenIndex;
			Language = text.TryParseFromLanguageToken(out tokenIndex);

			if (!Language.HasValue)
				return new FormatException("unexpected language '" + text.Substring(0, tokenIndex - 1) + "'");

			if (text.Length == tokenIndex)
				return null;

			Script = text.TryParseFromScriptToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return null;

			Region = text.TryParseFromRegionToken(ref tokenIndex);

			if (text.Length == tokenIndex)
				return null;

			var variant = text.TryParseFromVariantToken(ref tokenIndex);
			while (variant.HasValue)
			{
				Set(variant.Value);
				variant = text.TryParseFromVariantToken(ref tokenIndex);
			}

			if (text.Length == tokenIndex)
				return null;

			//TODO parse tail
			throw new NotImplementedException();
		}

		private Exception ParsePrivateUse(string text, int nextToken)
		{

			//TODO ParsePrivateUse
			throw new NotImplementedException();
		}

		public bool Equals(LanguageTag other, LanguageTagField checking)
		{
			if ((checking & LanguageTagField.Language) == LanguageTagField.Language &&
				Language != other.Language)
				return false;

			if ((checking & LanguageTagField.Script) == LanguageTagField.Script &&
				Script != other.Script)
				return false;

			if ((checking & LanguageTagField.Region) == LanguageTagField.Region &&
				Region != other.Region)
				return false;

			if ((checking & LanguageTagField.Variant) == LanguageTagField.Variant &&
				Variants != other.Variants)
				return false;

			//TODO: check Extension and PrivateUse

			return true;
		}
	}
}
