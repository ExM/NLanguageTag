using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public static partial class LanguageExtensions
	{
		public static string ToExtLanguage(this Language lang)
		{
			var prefix = lang.GetPrefix();
			if (prefix == null)
				return lang.ToText();

			return prefix.Value.ToText() + LanguageTag.TagSeparator + lang.ToText();
		}

		public static Language ParseFromLanguage(this string text)
		{
			int nextToken;
			var result = text.ParseFromLanguageToken(out nextToken);
			if(text.Length == nextToken)
				return result;

			throw new FormatException("unexpected language '" + text + "'");
		}

		public static Language ParseFromLanguageToken(this string text, out int nextToken)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator);
			if (pos == -1)
			{
				nextToken = text.Length;
				var result = text.TryParseFromLanguage();
				if (!result.HasValue)
					throw new FormatException("unexpected language '" + text + "'");

				return result.Value;
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				throw new FormatException("unexpected language '" + text + "'");

			var firstToken = text.Substring(0, pos);
			var lang = firstToken.TryParseFromLanguage();
			if(lang == null)
				throw new FormatException("unexpected language '" + text + "'");

			if(!lang.Value.ExtLanguageAvailable())
				return lang.Value;

			pos = text.IndexOf(LanguageTag.TagSeparator, nextToken);

			var extLangText = (pos == -1) ?
				text.Substring(nextToken) :
				text.Substring(nextToken, pos - nextToken);

			var extLang = extLangText.TryParseFromExtLanguage(lang.Value);
			if (extLang == null)
				return lang.Value;

			if (pos == -1)
			{
				nextToken = text.Length;
				return extLang.Value;
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				throw new FormatException("unexpected language '" + text + "'");

			return extLang.Value;
		}
	}
}
