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
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
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
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
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
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Script? script, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
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
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			PrivateUse = privateUseSubtags;
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
		}

		public LanguageTag(Language lang, Script? script, Region? region, IEnumerable<Variant> variants, IEnumerable<ExtensionSubtag> extSubtags, PrivateUseSubtags privateUseSubtags)
			: this()
		{
			Language = lang;
			Script = script;
			Region = region;
			var builder = new VariantCollection.Builder();
			foreach (var v in variants)
				builder.Append(Language, Script, v);
			Variants = builder.ToCollection();
			foreach(var extSubtag in extSubtags)
				Set(extSubtag);
			PrivateUse = privateUseSubtags;
		}
	}
}