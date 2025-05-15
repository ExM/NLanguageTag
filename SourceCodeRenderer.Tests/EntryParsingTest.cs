using System.Collections.Generic;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;
using NUnit.Framework;

namespace NLanguageTag.SourceCodeRenderer
{
	public class EntryParsingTest
	{
		[Test]
		public void Grandfathered()
		{
			var entry = parse<GrandfatheredEntry>(@"Type: grandfathered
Tag: zh-min-nan
Description: Minnan, Hokkien, Amoy, Taiwanese, Southern Min, Southern
  Fujian, Hoklo, Southern Fukien, Ho-lo
Added: 2001-03-26
Deprecated: 2009-07-29
Preferred-Value: nan");

			Assert.Multiple(() => {
				Assert.That(entry.Comments, Is.Null);
				Assert.That(entry.Tag, Is.EqualTo("zh-min-nan"));
				Assert.That(entry.Added, Is.EqualTo("2001-03-26"));
				Assert.That(entry.Deprecated, Is.EqualTo("2009-07-29"));
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Minnan, Hokkien, Amoy, Taiwanese, Southern Min, Southern Fujian, Hoklo, Southern Fukien, Ho-lo" }));
				Assert.That(entry.Type, Is.EqualTo("grandfathered"));
				Assert.That(entry.PreferredValue, Is.EqualTo("nan"));
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}

		[Test]
		public void Redundant()
		{
			var entry = parse<RedundantEntry>(@"Type: redundant
Tag: de-DE-1901
Description: German, German variant, traditional orthography
Added: 2001-07-17");

			Assert.Multiple(() => {
				Assert.That(entry.Tag, Is.EqualTo("de-DE-1901"));
				Assert.That(entry.Added, Is.EqualTo("2001-07-17"));
				Assert.That(entry.Deprecated, Is.Null);
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "German, German variant, traditional orthography" }));
				Assert.That(entry.Type, Is.EqualTo("redundant"));
				Assert.That(entry.PreferredValue, Is.Null);
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}

		[Test]
		public void Variant()
		{
			var entry = parse<VariantEntry>(@"Type: variant
Subtag: vivaraup
Description: Vivaro-Alpine
Added: 2018-04-22
Prefix: oc
Comments: Occitan variant spoken in northeastern Occitania");

			Assert.Multiple(() => {
				Assert.That(entry.Subtag, Is.EqualTo("vivaraup"));
				Assert.That(entry.Prefixes, Is.EquivalentTo(new [] { "oc" }));
				Assert.That(entry.Added, Is.EqualTo("2018-04-22"));
				Assert.That(entry.Comments, Is.EqualTo("Occitan variant spoken in northeastern Occitania"));
				Assert.That(entry.Deprecated, Is.Null);
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Vivaro-Alpine" }));
				Assert.That(entry.Type, Is.EqualTo("variant"));
				Assert.That(entry.PreferredValue, Is.Null);
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}
		
		[Test]
		public void Variant_with_many_comments()
		{
			var entry = parse<VariantEntry>(@"Type: variant
Subtag: vaidika
Description: Vedic Sanskrit
Added: 2010-07-28
Deprecated: 2024-06-08
Prefix: sa
Comments: The most ancient dialect of Sanskrit used in verse and prose
  composed until about the 4th century B.C.E.
Comments: Preferred tag is vsn");

			Assert.That(entry.Comments, Is.EqualTo("The most ancient dialect of Sanskrit used in verse and prose composed until about the 4th century B.C.E. Preferred tag is vsn"));
		}

		[Test]
		public void Region()
		{
			var entry = parse<RegionEntry>(@"Type: region
Subtag: YU
Description: Yugoslavia
Added: 2005-10-16
Deprecated: 2003-07-23
Comments: see BA, HR, ME, MK, RS, or SI");

			Assert.Multiple(() => {
				Assert.That(entry.Subtag, Is.EqualTo("YU"));
				Assert.That(entry.Added, Is.EqualTo("2005-10-16"));
				Assert.That(entry.Comments, Is.EqualTo("see BA, HR, ME, MK, RS, or SI"));
				Assert.That(entry.Deprecated, Is.EqualTo("2003-07-23"));
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Yugoslavia" }));
				Assert.That(entry.Type, Is.EqualTo("region"));
				Assert.That(entry.PreferredValue, Is.Null);
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}

		[Test]
		public void ScriptEntry()
		{
			var entry = parse<ScriptEntry>(@"Type: script
Subtag: Tfng
Description: Tifinagh
Description: Berber
Added: 2005-10-16");

			Assert.Multiple(() => {
				Assert.That(entry.Subtag, Is.EqualTo("Tfng"));
				Assert.That(entry.Added, Is.EqualTo("2005-10-16"));
				Assert.That(entry.Comments, Is.Null);
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Tifinagh", "Berber" }));
				Assert.That(entry.Type, Is.EqualTo("script"));
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}

		[Test]
		public void Extlang()
		{
			var entry = parse<ExtlangEntry>(@"Type: extlang
Subtag: zmi
Description: Negeri Sembilan Malay
Added: 2009-07-29
Preferred-Value: zmi
Prefix: ms
Macrolanguage: ms");

			Assert.Multiple(() => {
				Assert.That(entry.Subtag, Is.EqualTo("zmi"));
				Assert.That(entry.Added, Is.EqualTo("2009-07-29"));
				Assert.That(entry.Prefix, Is.EqualTo("ms"));
				Assert.That(entry.Macrolanguage, Is.EqualTo("ms"));
				Assert.That(entry.Deprecated, Is.Null);
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Negeri Sembilan Malay" }));
				Assert.That(entry.Type, Is.EqualTo("extlang"));
				Assert.That(entry.PreferredValue, Is.EqualTo("zmi"));
				Assert.That(entry.IsPrivateUse, Is.False);
			});
		}

		[Test]
		public void Language()
		{
			var entry = parse<LanguageEntry>(@"Type: language
Subtag: qaa..qtz
Description: Private use
Added: 2005-10-16
Scope: private-use");

			Assert.Multiple(() => {
				Assert.That(entry.Subtag, Is.EqualTo("qaa..qtz"));
				Assert.That(entry.Added, Is.EqualTo("2005-10-16"));
				Assert.That(entry.Macrolanguage, Is.Null);
				Assert.That(entry.Deprecated, Is.Null);
				Assert.That(entry.Descriptions, Is.EquivalentTo(new []{ "Private use" }));
				Assert.That(entry.Type, Is.EqualTo("language"));
				Assert.That(entry.PreferredValue, Is.Null);
				Assert.That(entry.IsPrivateUse, Is.True);
			});
		}

		private T parse<T>(string text) where T : RegEntry
		{
			var entry = RegEntry.Parse(text.Replace("\r\n", "\n"));
			Assert.That(entry, Is.TypeOf<T>());
			return (T) entry;
		}
	}
}
