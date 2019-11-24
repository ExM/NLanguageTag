namespace NLanguageTag
{
	/// <summary>
	/// Scope of a language that is not an individual language
	/// </summary>
	public enum LanguageScope
	{
		/// <summary>
		/// A macrolanguage as defined by ISO 639-3: a cluster of closely related languages that are sometimes
		/// considered to be a single language.
		/// </summary>
		Macrolanguage,

		/// <summary>
		/// A collection of languages, typically related by some type of historical, geographical, or linguistic
		/// association. Unlike a macrolanguage, a collection can contain languages that are only loosely related
		/// and a collection cannot be used interchangeably with languages that belong to it.
		/// </summary>
		Collection,

		/// <summary>
		/// A special language code. These are subtags used for identifying linguistic attributes not particularly
		/// associated with a concrete language. These include codes for when the language is undetermined or for
		/// non-linguistic content.
		/// </summary>
		Special
	}
}