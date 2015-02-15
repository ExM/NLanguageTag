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

		public Language? Language { get; private set; }
		public Script? Script { get; private set; }
		public Region? Region { get; private set; }

		private VariantCollection _variants;

		public VariantCollection Variants
		{
			get
			{
				return _variants ?? VariantCollection.Empty;
			}
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
			Fields = LanguageTagField.Language;
			Language = lang;
		}

		public LanguageTag(Language lang, Script script)
			: this()
		{
			Fields = LanguageTagField.Language | LanguageTagField.Script;
			Language = lang;
			Script = script;
		}

		public LanguageTag(Language lang, Region region)
			: this()
		{
			Fields = LanguageTagField.Language | LanguageTagField.Region;
			Language = lang;
			Region = region;
		}

		public LanguageTag(Language lang, Script script, Region region)
			: this()
		{
			Fields = LanguageTagField.Language | LanguageTagField.Script | LanguageTagField.Region;
			Language = lang;
			Script = script;
			Region = region;
		}

		public LanguageTag(Language lang, Script script, Region region, IEnumerable<Variant> variants)
			: this()
		{
			Fields = LanguageTagField.Language | LanguageTagField.Script | LanguageTagField.Region;
			Language = lang;
			Script = script;
			Region = region;

			_variants = new VariantCollection(variants); //TODO: verify prefix
			if (_variants.Any())
				Fields |= LanguageTagField.Variant;
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

			if (Language.HasValue)
				Fields = LanguageTagField.Language;
			else
				return new FormatException("unexpected language '" + text.Substring(0, tokenIndex - 1) + "'");

			if (text.Length == tokenIndex)
				return null;

			Script = text.TryParseFromScriptToken(ref tokenIndex);
			if (Script.HasValue)
				Fields |= LanguageTagField.Script;

			if (text.Length == tokenIndex)
				return null;

			Region = text.TryParseFromRegionToken(ref tokenIndex);
			if (Region.HasValue)
				Fields |= LanguageTagField.Region;

			if (text.Length == tokenIndex)
				return null;

			var variant = text.TryParseFromVariantToken(ref tokenIndex);
			if (variant.HasValue)
			{
				if (!this.IsPrefixFor(variant.Value))
					throw new FormatException("variant subtag '" + variant.Value + "' is unacceptable");

				_variants = new VariantCollection();
				_variants.Append(variant.Value);
				Fields |= LanguageTagField.Variant;
				variant = text.TryParseFromVariantToken(ref tokenIndex);

				while (variant.HasValue)
				{
					if (!this.IsPrefixFor(variant.Value))
						throw new FormatException("variant subtag '" + variant.Value + "' is unacceptable");

					_variants.Append(variant.Value);
					variant = text.TryParseFromVariantToken(ref tokenIndex);
				}
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
				Variants != other.Variants) //TODO: equal variants
				return false;

			//TODO: check Extension and PrivateUse

			return true;
		}
	}
}
