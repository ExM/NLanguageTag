using System;
using System.Collections.Generic;

namespace NLanguageTag
{
	public readonly partial struct LanguageTag
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
	}
}
