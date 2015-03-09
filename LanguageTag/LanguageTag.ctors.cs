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

		public LanguageTag(Language lang)
			: this()
		{
			Language = lang;
		}

		public LanguageTag(Language lang, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region)
			: this()
		{
			Language = lang;
			Region = region;
		}

		public LanguageTag(Language lang, Region? region, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script)
			: this()
		{
			Language = lang;
			Script = script;
		}

		public LanguageTag(Language lang, Script? script, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
		}

		public LanguageTag(Language lang, Script? script, Region? region, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Extensions = new ExtensionSubtagCollection(extSubtags);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			Variants = VariantCollection.Create(Language, Script, variants);
			Extensions = new ExtensionSubtagCollection(extSubtags);
		}

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