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
			var result = text.TryParseFromLanguageToken(out nextToken);
			if (result.HasValue && text.Length == nextToken)
				return result.Value;

			throw new FormatException("unexpected language '" + text + "'");
		}

		public static Language? TryParseFromLanguageToken(this string text, out int nextToken)
		{
			int pos = text.IndexOf(LanguageTag.TagSeparator);
			if (pos == -1)
			{
				nextToken = text.Length;
				return text.TryParseFromLanguage();
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				return null;

			var firstToken = text.Substring(0, pos);
			var lang = firstToken.TryParseFromLanguage();
			if(lang == null)
				return null;

			if(!lang.Value.ExtLanguageAvailable())
				return lang;

			pos = text.IndexOf(LanguageTag.TagSeparator, nextToken);

			var extLangText = (pos == -1) ?
				text.Substring(nextToken) :
				text.Substring(nextToken, pos - nextToken);

			var extLang = extLangText.TryParseFromExtLanguage(lang.Value);
			if (extLang == null)
				return lang;

			if (pos == -1)
			{
				nextToken = text.Length;
				return extLang;
			}

			nextToken = pos + 1;
			if (nextToken == text.Length)
				return null;

			return extLang;
		}
	}
}
