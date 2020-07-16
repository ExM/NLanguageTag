namespace NLanguageTag
{
	/// <summary>
	/// Contains extension methods for <see cref="IUnicodeSet"/>
	/// </summary>
	public static class UnicodeSetUtils
	{
		/// <summary>
		/// Determines whether given character belongs to the set
		/// </summary>
		/// <param name="unicodeSet">the set</param>
		/// <param name="c">the character</param>
		public static bool ContainsCharacter(this IUnicodeSet unicodeSet, char c)
		{
			return !char.IsSurrogate(c) && unicodeSet.ContainsCodePoint(c);
		}

		/// <summary>
		/// Determines whether a character defined by given surrogate pair belongs to the set
		/// </summary>
		/// <param name="unicodeSet">the set</param>
		/// <param name="highSurrogate">the high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF)</param>
		/// <param name="lowSurrogate">the low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF)</param>
		public static bool ContainsCharacterDefinedBySurrogatePair(
			this IUnicodeSet unicodeSet,
			char highSurrogate,
			char lowSurrogate)
		{
			return unicodeSet.ContainsCodePoint(char.ConvertToUtf32(highSurrogate, lowSurrogate));
		}
	}
}