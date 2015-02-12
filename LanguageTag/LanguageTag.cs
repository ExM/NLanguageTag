using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public struct LanguageTag
	{
		internal const char TagSeparator = '-';

		private static readonly ISet<Variant> _emptyVariant = new HashSet<Variant>(); //TODO implement read only collection
		private static readonly IReadOnlyDictionary<Char, ISet<string>> _emptyExtensions = new Dictionary<Char, ISet<string>>(); //TODO implement read only collection
		private static readonly ISet<string> _emptyPrivateUse = new HashSet<string>(); //TODO implement read only collection

		public Language? Language { get; private set; }
		public Script? Script { get; private set; }
		public Region? Region { get; private set; }


		private ISet<Variant> _variant;

		public ISet<Variant> Variant
		{
			get
			{
				return _variant ?? _emptyVariant;
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
			Language = lang;
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

			//TODO parse tail
			throw new NotImplementedException();
		}

		private Exception ParsePrivateUse(string text, int nextToken)
		{

			//TODO ParsePrivateUse
			throw new NotImplementedException();
		}
	}
}
