namespace NLanguageTag
{
	internal static class TokenEnumeratorUtils
	{
		public static Language? TryParseLanguage(this TokenEnumerator tokens)
		{
			if (!tokens.NextTokenAvailable)
			{
				// No other tokens — try parsing current and return whatever we got
				if (!tokens.CurrentTokenAvailable)
					return null;

				var result = tokens.Token.TryParseLanguage();
				if (result.HasValue)
					tokens.ToNextToken();

				return result;
			}

			// Try parsing main language tag
			var baseLanguage = tokens.Token.TryParseLanguage();
			if (!baseLanguage.HasValue)
				return null;

			tokens.ToNextToken();

			if (!baseLanguage.Value.ExtLanguageAvailable())
				return baseLanguage.Value;

			// There may be extlang subtag here
			var correctedLanguage = tokens.Token.TryParseFromExtLanguage(baseLanguage.Value);
			if (!correctedLanguage.HasValue)
				return baseLanguage.Value;

			// There is, indeed, extlang subtag. Skip the reader over it and return proper language
			tokens.ToNextToken();
			return correctedLanguage.Value;
		}

		public static Script? TryParseScript(this TokenEnumerator tokens)
		{
			if (!tokens.CurrentTokenAvailable)
				return null;

			var script = tokens.Token.TryParseScript();

			if (script != null)
				tokens.ToNextToken();

			return script;
		}

		public static Region? TryParseRegion(this TokenEnumerator tokens)
		{
			if (!tokens.CurrentTokenAvailable)
				return null;

			var region = tokens.Token.TryParseRegion();

			if (region != null)
				tokens.ToNextToken();

			return region;
		}

		public static Variant? TryParseVariant(this TokenEnumerator tokens)
		{
			if (!tokens.CurrentTokenAvailable)
				return null;

			var variant = tokens.Token.TryParseVariant();

			if (variant != null)
				tokens.ToNextToken();

			return variant;
		}
	}
}