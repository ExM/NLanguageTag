using System;

namespace NLanguageTag
{
	public readonly partial struct LanguageTag
	{
		/// <summary>
		/// Assigned properties of language subtag
		/// </summary>
		[Flags]
		public enum Field : byte
		{
			/// <summary>
			/// Nothing
			/// </summary>
			None = 0x00,

			/// <summary>
			/// Primary language subtag
			/// </summary>
			Language = 0x01,

			/// <summary>
			/// Script subtag
			/// </summary>
			Script = 0x02,

			/// <summary>
			/// Region subtag
			/// </summary>
			Region = 0x04,

			/// <summary>
			/// Variant subtags
			/// </summary>
			Variants = 0x08,

			/// <summary>
			/// Extension subtags
			/// </summary>
			Extensions = 0x10,

			/// <summary>
			/// Private use subtags
			/// </summary>
			PrivateUse = 0x20,

			/// <summary>
			/// Most commonly used (Language, Script, Region)
			/// </summary>
			Primary = Language | Script | Region,

			/// <summary>
			/// Subtags enumerated in the BCP47 (Language, Script, Region, Variants)
			/// </summary>
			Enumerated = Primary | Variants,

			/// <summary>
			/// All subtags
			/// </summary>
			All = Enumerated | Extensions | PrivateUse
		}
	}
}