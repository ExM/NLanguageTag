using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public static partial class RegionExtensions
	{
		public static Region ParseFromRegion(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromRegionToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected region '" + text + "'");
		}

		public static Region? TryParseFromRegionToken(this string text, ref int tokenIndex)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator, tokenIndex);
			
			var token = (pos == -1) ?
				text.Substring(tokenIndex) :
				text.Substring(tokenIndex, pos - tokenIndex);

			var script = token.TryParseFromRegion();

			if (script != null)
				tokenIndex = (pos == -1) ? text.Length : pos + 1;

			return script;
		}
	}
}
