using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	public partial struct LanguageTag
	{

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		public LanguageTag(Language lang)
			: this()
		{
			Language = lang;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		public LanguageTag(Language lang, Region? region)
			: this()
		{
			Language = lang;
			Region = region;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		public LanguageTag(Language lang, Script? script)
			: this()
		{
			Language = lang;
			Script = script;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		/// <summary>
		/// Create the LanguageTag instance
		/// </summary>
		/// <param name="lang">primary language</param>
		/// <param name="script">script subtag</param>
		/// <param name="region">region subtag</param>
		/// <param name="variants">enumarate of variant subtags</param>
		/// <param name="extSubtags">enumarate of extensions subtags</param>
		/// <param name="privateUseSubtags">private use subtag</param>
		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}
	}
}