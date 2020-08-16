using System;
using System.Collections.Generic;

namespace NLanguageTag
{
	public partial struct LanguageTag
	{

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		public LanguageTag(Language lang)
			: this(
			lang,
			null,
			null,
			default,
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			null,
			default,
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			null,
			null,
			default,
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			null,
			default,
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, IEnumerable<Variant>? variants)
			: this(
			lang,
			null,
			null,
			VariantCollection.Create(lang, null, variants),
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<Variant>? variants, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			null,
			VariantCollection.Create(lang, null, variants),
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			null,
			null,
			VariantCollection.Create(lang, null, variants),
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			null,
			VariantCollection.Create(lang, null, variants),
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		public LanguageTag(Language lang, Region? region)
			: this(
			lang,
			null,
			region,
			default,
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			region,
			default,
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			null,
			region,
			default,
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			region,
			default,
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant>? variants)
			: this(
			lang,
			null,
			region,
			VariantCollection.Create(lang, null, variants),
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant>? variants, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			region,
			VariantCollection.Create(lang, null, variants),
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			null,
			region,
			VariantCollection.Create(lang, null, variants),
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			null,
			region,
			VariantCollection.Create(lang, null, variants),
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		public LanguageTag(Language lang, Script? script)
			: this(
			lang,
			script,
			null,
			default,
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			null,
			default,
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			script,
			null,
			default,
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			null,
			default,
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant>? variants)
			: this(
			lang,
			script,
			null,
			VariantCollection.Create(lang, script, variants),
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant>? variants, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			null,
			VariantCollection.Create(lang, script, variants),
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			script,
			null,
			VariantCollection.Create(lang, script, variants),
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			null,
			VariantCollection.Create(lang, script, variants),
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region)
			: this(
			lang,
			script,
			region,
			default,
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			region,
			default,
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			script,
			region,
			default,
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			region,
			default,
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant>? variants)
			: this(
			lang,
			script,
			region,
			VariantCollection.Create(lang, script, variants),
			default,
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant>? variants, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			region,
			VariantCollection.Create(lang, script, variants),
			default,
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags)
			: this(
			lang,
			script,
			region,
			VariantCollection.Create(lang, script, variants),
			new ExtensionSubtagCollection(extSubtags),
			default)
		{
		}

		/// <summary>
		/// Initializes new value of <see cref="LanguageTag"/>
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant>? variants, IEnumerable<ExtensionSubtag>? extSubtags, ExtensionSubtag privateUseSubtags)
			: this(
			lang,
			script,
			region,
			VariantCollection.Create(lang, script, variants),
			new ExtensionSubtagCollection(extSubtags),
			privateUseSubtags)
		{
		}

		/// <summary>
		/// Creates language tag that consists of specified fields of this language tag
		/// </summary>
		public LanguageTag Take(Field fields)
		{
			if (fields == Field.All)
				return this;

			if (Language == null)
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
