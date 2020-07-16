namespace NLanguageTag
{
	/// <summary>
	/// Represents a set of Unicode characters
	/// </summary>
	public interface IUnicodeSet
	{
		/// <summary>
		/// Determines whether given character belongs to the set
		/// </summary>
		/// <param name="codePoint">Unicode code point of the character</param>
		bool ContainsCodePoint(int codePoint);
	}
}