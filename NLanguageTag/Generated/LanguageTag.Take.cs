using System;

namespace NLanguageTag
{
	public readonly partial struct LanguageTag
	{
		/// <summary>
		/// Creates language tag that consists of specified fields of this language tag
		/// </summary>
		public LanguageTag Take(Field fields)
		{
			if (fields == Field.All)
				return this;

			if (Language is null)
			{
				return fields.HasFlag(Field.PrivateUse)
					? new LanguageTag(PrivateUse)
					: new LanguageTag(null, null, null, default, default, default);
			}

			switch(fields)
			{
				case Field.Language:
					return new LanguageTag(Language);
				case Field.Language | Field.PrivateUse:
					return new LanguageTag(Language, PrivateUse);
				case Field.Language | Field.Extensions:
					return new LanguageTag(Language, Extensions);
				case Field.Language | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Extensions, PrivateUse);
				case Field.Language | Field.Variants:
					return new LanguageTag(Language, Variants);
				case Field.Language | Field.Variants | Field.PrivateUse:
					return new LanguageTag(Language, Variants, PrivateUse);
				case Field.Language | Field.Variants | Field.Extensions:
					return new LanguageTag(Language, Variants, Extensions);
				case Field.Language | Field.Variants | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Variants, Extensions, PrivateUse);
				case Field.Language | Field.Region:
					return new LanguageTag(Language, Region);
				case Field.Language | Field.Region | Field.PrivateUse:
					return new LanguageTag(Language, Region, PrivateUse);
				case Field.Language | Field.Region | Field.Extensions:
					return new LanguageTag(Language, Region, Extensions);
				case Field.Language | Field.Region | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Region, Extensions, PrivateUse);
				case Field.Language | Field.Region | Field.Variants:
					return new LanguageTag(Language, Region, Variants);
				case Field.Language | Field.Region | Field.Variants | Field.PrivateUse:
					return new LanguageTag(Language, Region, Variants, PrivateUse);
				case Field.Language | Field.Region | Field.Variants | Field.Extensions:
					return new LanguageTag(Language, Region, Variants, Extensions);
				case Field.Language | Field.Region | Field.Variants | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Region, Variants, Extensions, PrivateUse);
				case Field.Language | Field.Script:
					return new LanguageTag(Language, Script);
				case Field.Language | Field.Script | Field.PrivateUse:
					return new LanguageTag(Language, Script, PrivateUse);
				case Field.Language | Field.Script | Field.Extensions:
					return new LanguageTag(Language, Script, Extensions);
				case Field.Language | Field.Script | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Script, Extensions, PrivateUse);
				case Field.Language | Field.Script | Field.Variants:
					return new LanguageTag(Language, Script, Variants);
				case Field.Language | Field.Script | Field.Variants | Field.PrivateUse:
					return new LanguageTag(Language, Script, Variants, PrivateUse);
				case Field.Language | Field.Script | Field.Variants | Field.Extensions:
					return new LanguageTag(Language, Script, Variants, Extensions);
				case Field.Language | Field.Script | Field.Variants | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Script, Variants, Extensions, PrivateUse);
				case Field.Language | Field.Script | Field.Region:
					return new LanguageTag(Language, Script, Region);
				case Field.Language | Field.Script | Field.Region | Field.PrivateUse:
					return new LanguageTag(Language, Script, Region, PrivateUse);
				case Field.Language | Field.Script | Field.Region | Field.Extensions:
					return new LanguageTag(Language, Script, Region, Extensions);
				case Field.Language | Field.Script | Field.Region | Field.Extensions | Field.PrivateUse:
					return new LanguageTag(Language, Script, Region, Extensions, PrivateUse);
				case Field.Language | Field.Script | Field.Region | Field.Variants:
					return new LanguageTag(Language, Script, Region, Variants);
				case Field.Language | Field.Script | Field.Region | Field.Variants | Field.PrivateUse:
					return new LanguageTag(Language, Script, Region, Variants, PrivateUse);
				case Field.Language | Field.Script | Field.Region | Field.Variants | Field.Extensions:
					return new LanguageTag(Language, Script, Region, Variants, Extensions);
				case Field.Language | Field.Script | Field.Region | Field.Variants | Field.Extensions | Field.PrivateUse:
					throw new ApplicationException("This should never happen");
				case Field.PrivateUse:
					return new LanguageTag(PrivateUse);
				default:
					return new LanguageTag();
			}
		}
	}
}
