namespace NLanguageTag
{
	internal static class TokenEnumeratorUtils
	{
		public static Language? TryParseLanguage(this TokenEnumerator tokens)
		{
			if (!tokens.NextTokenAvailable)
			{
				// No other tokens — try parsing current and return whatever we got
				var result = Language.TryParse(tokens.CurrentToken);

				if (result != null)
					tokens.ToNextToken();

				return result;
			}

			// Try parsing main language tag

			var baseLanguage = Language.TryParse(tokens.CurrentToken);

			if (baseLanguage == null)
				return null;

			tokens.ToNextToken();

			if (!baseLanguage.ExtLanguageAvailable)
				return baseLanguage;

			// There may be extlang subtag here
			var correctedLanguage = baseLanguage.TryParseFromExtLanguage(tokens.CurrentToken);
			if (correctedLanguage == null)
				return baseLanguage;

			// There is, indeed, extlang subtag. Skip the reader over it and return proper language
			tokens.ToNextToken();
			return correctedLanguage;
		}

		public static Script? TryParseScript(this TokenEnumerator tokens)
		{
			var script = Script.TryParse(tokens.CurrentToken);

			if (script != null)
				tokens.ToNextToken();

			return script;
		}

		public static Region? TryParseRegion(this TokenEnumerator tokens)
		{
			var region = Region.TryParse(tokens.CurrentToken);

			if (region != null)
				tokens.ToNextToken();

			return region;
		}

		public static Variant? TryParseVariant(this TokenEnumerator tokens)
		{
			var variant = Variant.TryParse(tokens.CurrentToken);

			if (variant != null)
				tokens.ToNextToken();

			return variant;
		}
	}
}
