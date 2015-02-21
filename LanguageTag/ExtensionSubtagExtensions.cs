using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	public static class ExtensionSubtagExtensions
	{
		public static ExtensionSubtag ParseFromExtensionSubtag(this string text)
		{
			int tokenIndex = 0;
			var result = text.TryParseFromExtensionSubtagToken(ref tokenIndex);
			if (result.HasValue && text.Length == tokenIndex)
				return result.Value;

			throw new FormatException("unexpected extension subtag '" + text + "'");
		}

		public static ExtensionSubtag? TryParseFromExtensionSubtagToken(this string text, ref int tokenIndex)
		{
			var tokenSequence = text.GetTokenSequense(tokenIndex);
			if (!tokenSequence.MoveNext()) // get singletone
				return null;

			if(tokenSequence.Token.Length != 1)
				return null;

			char singletone = Char.ToLowerInvariant(tokenSequence.Token[0]);

			if(singletone == 'x')
				return null;

			if (!tokenSequence.MoveNext()) // get first subtag
				throw new FormatException("extension subtag '" + singletone + "' not contain elements");

			ValidateElement(tokenSequence.Token);

			var result = new ExtensionSubtag(singletone, tokenSequence.Token);
			tokenIndex = tokenSequence.NextTokenPosition;

			while (tokenSequence.MoveNext()) // get remaining elements
			{
				if (tokenSequence.Token.Length == 1) // next extension subtag or private use
					break;

				ValidateElement(tokenSequence.Token);
				result.Append(tokenSequence.Token);
				tokenIndex = tokenSequence.NextTokenPosition;
			}

			return result;
		}

		private static void ValidateElement(string text)
		{
			if (text.Length < 2 || 8 < text.Length)
				throw new FormatException("extension subtag must be from 2 to 8 characters");

			if(!text.All(ch => Char.IsLetterOrDigit(ch) && (int)ch < 127))
				throw new FormatException("element must consist only of numbers or letters in ASCII");
		}
	}
}
