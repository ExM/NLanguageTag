using System;

namespace NLanguageTag
{
	public partial class Script
	{
		/// <summary>
		/// Adlam
		/// added: 2014-12-11
		/// </summary>
		public static Script Adlm => AdlmCache.Instance;

		private static class AdlmCache
		{
			public static readonly Script Instance = new Script("Adlm", ScriptCode.Adlm);
		}

		/// <summary>
		/// Afaka
		/// added: 2011-01-07
		/// </summary>
		public static Script Afak => AfakCache.Instance;

		private static class AfakCache
		{
			public static readonly Script Instance = new Script("Afak", ScriptCode.Afak);
		}

		/// <summary>
		/// Caucasian Albanian
		/// added: 2012-11-01
		/// </summary>
		public static Script Aghb => AghbCache.Instance;

		private static class AghbCache
		{
			public static readonly Script Instance = new Script("Aghb", ScriptCode.Aghb);
		}

		/// <summary>
		/// Ahom
		/// Tai Ahom
		/// added: 2013-12-02
		/// </summary>
		public static Script Ahom => AhomCache.Instance;

		private static class AhomCache
		{
			public static readonly Script Instance = new Script("Ahom", ScriptCode.Ahom);
		}

		/// <summary>
		/// Arabic
		/// added: 2005-10-16
		/// </summary>
		public static Script Arab => ArabCache.Instance;

		private static class ArabCache
		{
			public static readonly Script Instance = new Script("Arab", ScriptCode.Arab);
		}

		/// <summary>
		/// Arabic (Nastaliq variant)
		/// added: 2014-12-11
		/// </summary>
		public static Script Aran => AranCache.Instance;

		private static class AranCache
		{
			public static readonly Script Instance = new Script("Aran", ScriptCode.Aran);
		}

		/// <summary>
		/// Imperial Aramaic
		/// added: 2007-12-05
		/// </summary>
		public static Script Armi => ArmiCache.Instance;

		private static class ArmiCache
		{
			public static readonly Script Instance = new Script("Armi", ScriptCode.Armi);
		}

		/// <summary>
		/// Armenian
		/// added: 2005-10-16
		/// </summary>
		public static Script Armn => ArmnCache.Instance;

		private static class ArmnCache
		{
			public static readonly Script Instance = new Script("Armn", ScriptCode.Armn);
		}

		/// <summary>
		/// Avestan
		/// added: 2007-07-28
		/// </summary>
		public static Script Avst => AvstCache.Instance;

		private static class AvstCache
		{
			public static readonly Script Instance = new Script("Avst", ScriptCode.Avst);
		}

		/// <summary>
		/// Balinese
		/// added: 2005-10-16
		/// </summary>
		public static Script Bali => BaliCache.Instance;

		private static class BaliCache
		{
			public static readonly Script Instance = new Script("Bali", ScriptCode.Bali);
		}

		/// <summary>
		/// Bamum
		/// added: 2009-07-30
		/// </summary>
		public static Script Bamu => BamuCache.Instance;

		private static class BamuCache
		{
			public static readonly Script Instance = new Script("Bamu", ScriptCode.Bamu);
		}

		/// <summary>
		/// Bassa Vah
		/// added: 2010-04-10
		/// </summary>
		public static Script Bass => BassCache.Instance;

		private static class BassCache
		{
			public static readonly Script Instance = new Script("Bass", ScriptCode.Bass);
		}

		/// <summary>
		/// Batak
		/// added: 2005-10-16
		/// </summary>
		public static Script Batk => BatkCache.Instance;

		private static class BatkCache
		{
			public static readonly Script Instance = new Script("Batk", ScriptCode.Batk);
		}

		/// <summary>
		/// Bengali
		/// Bangla
		/// added: 2005-10-16
		/// </summary>
		public static Script Beng => BengCache.Instance;

		private static class BengCache
		{
			public static readonly Script Instance = new Script("Beng", ScriptCode.Beng);
		}

		/// <summary>
		/// Bhaiksuki
		/// added: 2015-07-24
		/// </summary>
		public static Script Bhks => BhksCache.Instance;

		private static class BhksCache
		{
			public static readonly Script Instance = new Script("Bhks", ScriptCode.Bhks);
		}

		/// <summary>
		/// Blissymbols
		/// added: 2005-10-16
		/// </summary>
		public static Script Blis => BlisCache.Instance;

		private static class BlisCache
		{
			public static readonly Script Instance = new Script("Blis", ScriptCode.Blis);
		}

		/// <summary>
		/// Bopomofo
		/// added: 2005-10-16
		/// </summary>
		public static Script Bopo => BopoCache.Instance;

		private static class BopoCache
		{
			public static readonly Script Instance = new Script("Bopo", ScriptCode.Bopo);
		}

		/// <summary>
		/// Brahmi
		/// added: 2005-10-16
		/// </summary>
		public static Script Brah => BrahCache.Instance;

		private static class BrahCache
		{
			public static readonly Script Instance = new Script("Brah", ScriptCode.Brah);
		}

		/// <summary>
		/// Braille
		/// added: 2005-10-16
		/// </summary>
		public static Script Brai => BraiCache.Instance;

		private static class BraiCache
		{
			public static readonly Script Instance = new Script("Brai", ScriptCode.Brai);
		}

		/// <summary>
		/// Buginese
		/// added: 2005-10-16
		/// </summary>
		public static Script Bugi => BugiCache.Instance;

		private static class BugiCache
		{
			public static readonly Script Instance = new Script("Bugi", ScriptCode.Bugi);
		}

		/// <summary>
		/// Buhid
		/// added: 2005-10-16
		/// </summary>
		public static Script Buhd => BuhdCache.Instance;

		private static class BuhdCache
		{
			public static readonly Script Instance = new Script("Buhd", ScriptCode.Buhd);
		}

		/// <summary>
		/// Chakma
		/// added: 2007-12-05
		/// </summary>
		public static Script Cakm => CakmCache.Instance;

		private static class CakmCache
		{
			public static readonly Script Instance = new Script("Cakm", ScriptCode.Cakm);
		}

		/// <summary>
		/// Unified Canadian Aboriginal Syllabics
		/// added: 2005-10-16
		/// </summary>
		public static Script Cans => CansCache.Instance;

		private static class CansCache
		{
			public static readonly Script Instance = new Script("Cans", ScriptCode.Cans);
		}

		/// <summary>
		/// Carian
		/// added: 2006-07-21
		/// </summary>
		public static Script Cari => CariCache.Instance;

		private static class CariCache
		{
			public static readonly Script Instance = new Script("Cari", ScriptCode.Cari);
		}

		/// <summary>
		/// Cham
		/// added: 2005-10-16
		/// </summary>
		public static Script Cham => ChamCache.Instance;

		private static class ChamCache
		{
			public static readonly Script Instance = new Script("Cham", ScriptCode.Cham);
		}

		/// <summary>
		/// Cherokee
		/// added: 2005-10-16
		/// </summary>
		public static Script Cher => CherCache.Instance;

		private static class CherCache
		{
			public static readonly Script Instance = new Script("Cher", ScriptCode.Cher);
		}

		/// <summary>
		/// Chorasmian
		/// added: 2019-09-11
		/// </summary>
		public static Script Chrs => ChrsCache.Instance;

		private static class ChrsCache
		{
			public static readonly Script Instance = new Script("Chrs", ScriptCode.Chrs);
		}

		/// <summary>
		/// Cirth
		/// added: 2005-10-16
		/// </summary>
		public static Script Cirt => CirtCache.Instance;

		private static class CirtCache
		{
			public static readonly Script Instance = new Script("Cirt", ScriptCode.Cirt);
		}

		/// <summary>
		/// Coptic
		/// added: 2005-10-16
		/// </summary>
		public static Script Copt => CoptCache.Instance;

		private static class CoptCache
		{
			public static readonly Script Instance = new Script("Copt", ScriptCode.Copt);
		}

		/// <summary>
		/// Cypro-Minoan
		/// added: 2017-08-13
		/// </summary>
		public static Script Cpmn => CpmnCache.Instance;

		private static class CpmnCache
		{
			public static readonly Script Instance = new Script("Cpmn", ScriptCode.Cpmn);
		}

		/// <summary>
		/// Cypriot syllabary
		/// added: 2005-10-16
		/// </summary>
		public static Script Cprt => CprtCache.Instance;

		private static class CprtCache
		{
			public static readonly Script Instance = new Script("Cprt", ScriptCode.Cprt);
		}

		/// <summary>
		/// Cyrillic
		/// added: 2005-10-16
		/// </summary>
		public static Script Cyrl => CyrlCache.Instance;

		private static class CyrlCache
		{
			public static readonly Script Instance = new Script("Cyrl", ScriptCode.Cyrl);
		}

		/// <summary>
		/// Cyrillic (Old Church Slavonic variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Cyrs => CyrsCache.Instance;

		private static class CyrsCache
		{
			public static readonly Script Instance = new Script("Cyrs", ScriptCode.Cyrs);
		}

		/// <summary>
		/// Devanagari
		/// Nagari
		/// added: 2005-10-16
		/// </summary>
		public static Script Deva => DevaCache.Instance;

		private static class DevaCache
		{
			public static readonly Script Instance = new Script("Deva", ScriptCode.Deva);
		}

		/// <summary>
		/// Dives Akuru
		/// added: 2019-09-11
		/// </summary>
		public static Script Diak => DiakCache.Instance;

		private static class DiakCache
		{
			public static readonly Script Instance = new Script("Diak", ScriptCode.Diak);
		}

		/// <summary>
		/// Dogra
		/// added: 2017-01-13
		/// </summary>
		public static Script Dogr => DogrCache.Instance;

		private static class DogrCache
		{
			public static readonly Script Instance = new Script("Dogr", ScriptCode.Dogr);
		}

		/// <summary>
		/// Deseret
		/// Mormon
		/// added: 2005-10-16
		/// </summary>
		public static Script Dsrt => DsrtCache.Instance;

		private static class DsrtCache
		{
			public static readonly Script Instance = new Script("Dsrt", ScriptCode.Dsrt);
		}

		/// <summary>
		/// Duployan shorthand
		/// Duployan stenography
		/// added: 2010-08-16
		/// </summary>
		public static Script Dupl => DuplCache.Instance;

		private static class DuplCache
		{
			public static readonly Script Instance = new Script("Dupl", ScriptCode.Dupl);
		}

		/// <summary>
		/// Egyptian demotic
		/// added: 2005-10-16
		/// </summary>
		public static Script Egyd => EgydCache.Instance;

		private static class EgydCache
		{
			public static readonly Script Instance = new Script("Egyd", ScriptCode.Egyd);
		}

		/// <summary>
		/// Egyptian hieratic
		/// added: 2005-10-16
		/// </summary>
		public static Script Egyh => EgyhCache.Instance;

		private static class EgyhCache
		{
			public static readonly Script Instance = new Script("Egyh", ScriptCode.Egyh);
		}

		/// <summary>
		/// Egyptian hieroglyphs
		/// added: 2005-10-16
		/// </summary>
		public static Script Egyp => EgypCache.Instance;

		private static class EgypCache
		{
			public static readonly Script Instance = new Script("Egyp", ScriptCode.Egyp);
		}

		/// <summary>
		/// Elbasan
		/// added: 2010-08-16
		/// </summary>
		public static Script Elba => ElbaCache.Instance;

		private static class ElbaCache
		{
			public static readonly Script Instance = new Script("Elba", ScriptCode.Elba);
		}

		/// <summary>
		/// Elymaic
		/// added: 2018-10-28
		/// </summary>
		public static Script Elym => ElymCache.Instance;

		private static class ElymCache
		{
			public static readonly Script Instance = new Script("Elym", ScriptCode.Elym);
		}

		/// <summary>
		/// Ethiopic
		/// Geʻez
		/// Ge'ez
		/// added: 2005-10-16
		/// </summary>
		public static Script Ethi => EthiCache.Instance;

		private static class EthiCache
		{
			public static readonly Script Instance = new Script("Ethi", ScriptCode.Ethi);
		}

		/// <summary>
		/// Khutsuri (Asomtavruli and Nuskhuri)
		/// added: 2005-10-16
		/// </summary>
		public static Script Geok => GeokCache.Instance;

		private static class GeokCache
		{
			public static readonly Script Instance = new Script("Geok", ScriptCode.Geok);
		}

		/// <summary>
		/// Georgian (Mkhedruli and Mtavruli)
		/// added: 2005-10-16
		/// </summary>
		public static Script Geor => GeorCache.Instance;

		private static class GeorCache
		{
			public static readonly Script Instance = new Script("Geor", ScriptCode.Geor);
		}

		/// <summary>
		/// Glagolitic
		/// added: 2005-10-16
		/// </summary>
		public static Script Glag => GlagCache.Instance;

		private static class GlagCache
		{
			public static readonly Script Instance = new Script("Glag", ScriptCode.Glag);
		}

		/// <summary>
		/// Gunjala Gondi
		/// added: 2017-01-13
		/// </summary>
		public static Script Gong => GongCache.Instance;

		private static class GongCache
		{
			public static readonly Script Instance = new Script("Gong", ScriptCode.Gong);
		}

		/// <summary>
		/// Masaram Gondi
		/// added: 2017-01-13
		/// </summary>
		public static Script Gonm => GonmCache.Instance;

		private static class GonmCache
		{
			public static readonly Script Instance = new Script("Gonm", ScriptCode.Gonm);
		}

		/// <summary>
		/// Gothic
		/// added: 2005-10-16
		/// </summary>
		public static Script Goth => GothCache.Instance;

		private static class GothCache
		{
			public static readonly Script Instance = new Script("Goth", ScriptCode.Goth);
		}

		/// <summary>
		/// Grantha
		/// added: 2009-12-09
		/// </summary>
		public static Script Gran => GranCache.Instance;

		private static class GranCache
		{
			public static readonly Script Instance = new Script("Gran", ScriptCode.Gran);
		}

		/// <summary>
		/// Greek
		/// added: 2005-10-16
		/// </summary>
		public static Script Grek => GrekCache.Instance;

		private static class GrekCache
		{
			public static readonly Script Instance = new Script("Grek", ScriptCode.Grek);
		}

		/// <summary>
		/// Gujarati
		/// added: 2005-10-16
		/// </summary>
		public static Script Gujr => GujrCache.Instance;

		private static class GujrCache
		{
			public static readonly Script Instance = new Script("Gujr", ScriptCode.Gujr);
		}

		/// <summary>
		/// Gurmukhi
		/// added: 2005-10-16
		/// </summary>
		public static Script Guru => GuruCache.Instance;

		private static class GuruCache
		{
			public static readonly Script Instance = new Script("Guru", ScriptCode.Guru);
		}

		/// <summary>
		/// Han with Bopomofo (alias for Han + Bopomofo)
		/// added: 2016-02-08
		/// </summary>
		public static Script Hanb => HanbCache.Instance;

		private static class HanbCache
		{
			public static readonly Script Instance = new Script("Hanb", ScriptCode.Hanb);
		}

		/// <summary>
		/// Hangul
		/// Hangŭl
		/// Hangeul
		/// added: 2005-10-16
		/// </summary>
		public static Script Hang => HangCache.Instance;

		private static class HangCache
		{
			public static readonly Script Instance = new Script("Hang", ScriptCode.Hang);
		}

		/// <summary>
		/// Han
		/// Hanzi
		/// Kanji
		/// Hanja
		/// added: 2005-10-16
		/// </summary>
		public static Script Hani => HaniCache.Instance;

		private static class HaniCache
		{
			public static readonly Script Instance = new Script("Hani", ScriptCode.Hani);
		}

		/// <summary>
		/// Hanunoo
		/// Hanunóo
		/// added: 2005-10-16
		/// </summary>
		public static Script Hano => HanoCache.Instance;

		private static class HanoCache
		{
			public static readonly Script Instance = new Script("Hano", ScriptCode.Hano);
		}

		/// <summary>
		/// Han (Simplified variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Hans => HansCache.Instance;

		private static class HansCache
		{
			public static readonly Script Instance = new Script("Hans", ScriptCode.Hans);
		}

		/// <summary>
		/// Han (Traditional variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Hant => HantCache.Instance;

		private static class HantCache
		{
			public static readonly Script Instance = new Script("Hant", ScriptCode.Hant);
		}

		/// <summary>
		/// Hatran
		/// added: 2013-12-02
		/// </summary>
		public static Script Hatr => HatrCache.Instance;

		private static class HatrCache
		{
			public static readonly Script Instance = new Script("Hatr", ScriptCode.Hatr);
		}

		/// <summary>
		/// Hebrew
		/// added: 2005-10-16
		/// </summary>
		public static Script Hebr => HebrCache.Instance;

		private static class HebrCache
		{
			public static readonly Script Instance = new Script("Hebr", ScriptCode.Hebr);
		}

		/// <summary>
		/// Hiragana
		/// added: 2005-10-16
		/// </summary>
		public static Script Hira => HiraCache.Instance;

		private static class HiraCache
		{
			public static readonly Script Instance = new Script("Hira", ScriptCode.Hira);
		}

		/// <summary>
		/// Anatolian Hieroglyphs
		/// Luwian Hieroglyphs
		/// Hittite Hieroglyphs
		/// added: 2011-12-28
		/// </summary>
		public static Script Hluw => HluwCache.Instance;

		private static class HluwCache
		{
			public static readonly Script Instance = new Script("Hluw", ScriptCode.Hluw);
		}

		/// <summary>
		/// Pahawh Hmong
		/// added: 2005-10-16
		/// </summary>
		public static Script Hmng => HmngCache.Instance;

		private static class HmngCache
		{
			public static readonly Script Instance = new Script("Hmng", ScriptCode.Hmng);
		}

		/// <summary>
		/// Nyiakeng Puachue Hmong
		/// added: 2017-08-13
		/// </summary>
		public static Script Hmnp => HmnpCache.Instance;

		private static class HmnpCache
		{
			public static readonly Script Instance = new Script("Hmnp", ScriptCode.Hmnp);
		}

		/// <summary>
		/// Japanese syllabaries (alias for Hiragana + Katakana)
		/// added: 2005-10-16
		/// </summary>
		public static Script Hrkt => HrktCache.Instance;

		private static class HrktCache
		{
			public static readonly Script Instance = new Script("Hrkt", ScriptCode.Hrkt);
		}

		/// <summary>
		/// Old Hungarian
		/// Hungarian Runic
		/// added: 2005-10-16
		/// </summary>
		public static Script Hung => HungCache.Instance;

		private static class HungCache
		{
			public static readonly Script Instance = new Script("Hung", ScriptCode.Hung);
		}

		/// <summary>
		/// Indus
		/// Harappan
		/// added: 2005-10-16
		/// </summary>
		public static Script Inds => IndsCache.Instance;

		private static class IndsCache
		{
			public static readonly Script Instance = new Script("Inds", ScriptCode.Inds);
		}

		/// <summary>
		/// Old Italic (Etruscan, Oscan, etc.)
		/// added: 2005-10-16
		/// </summary>
		public static Script Ital => ItalCache.Instance;

		private static class ItalCache
		{
			public static readonly Script Instance = new Script("Ital", ScriptCode.Ital);
		}

		/// <summary>
		/// Jamo (alias for Jamo subset of Hangul)
		/// added: 2016-02-08
		/// </summary>
		public static Script Jamo => JamoCache.Instance;

		private static class JamoCache
		{
			public static readonly Script Instance = new Script("Jamo", ScriptCode.Jamo);
		}

		/// <summary>
		/// Javanese
		/// added: 2005-10-16
		/// </summary>
		public static Script Java => JavaCache.Instance;

		private static class JavaCache
		{
			public static readonly Script Instance = new Script("Java", ScriptCode.Java);
		}

		/// <summary>
		/// Japanese (alias for Han + Hiragana + Katakana)
		/// added: 2006-07-21
		/// </summary>
		public static Script Jpan => JpanCache.Instance;

		private static class JpanCache
		{
			public static readonly Script Instance = new Script("Jpan", ScriptCode.Jpan);
		}

		/// <summary>
		/// Jurchen
		/// added: 2011-01-07
		/// </summary>
		public static Script Jurc => JurcCache.Instance;

		private static class JurcCache
		{
			public static readonly Script Instance = new Script("Jurc", ScriptCode.Jurc);
		}

		/// <summary>
		/// Kayah Li
		/// added: 2005-10-16
		/// </summary>
		public static Script Kali => KaliCache.Instance;

		private static class KaliCache
		{
			public static readonly Script Instance = new Script("Kali", ScriptCode.Kali);
		}

		/// <summary>
		/// Katakana
		/// added: 2005-10-16
		/// </summary>
		public static Script Kana => KanaCache.Instance;

		private static class KanaCache
		{
			public static readonly Script Instance = new Script("Kana", ScriptCode.Kana);
		}

		/// <summary>
		/// Kawi
		/// added: 2021-12-24
		/// </summary>
		public static Script Kawi => KawiCache.Instance;

		private static class KawiCache
		{
			public static readonly Script Instance = new Script("Kawi", ScriptCode.Kawi);
		}

		/// <summary>
		/// Kharoshthi
		/// added: 2005-10-16
		/// </summary>
		public static Script Khar => KharCache.Instance;

		private static class KharCache
		{
			public static readonly Script Instance = new Script("Khar", ScriptCode.Khar);
		}

		/// <summary>
		/// Khmer
		/// added: 2005-10-16
		/// </summary>
		public static Script Khmr => KhmrCache.Instance;

		private static class KhmrCache
		{
			public static readonly Script Instance = new Script("Khmr", ScriptCode.Khmr);
		}

		/// <summary>
		/// Khojki
		/// added: 2011-08-16
		/// </summary>
		public static Script Khoj => KhojCache.Instance;

		private static class KhojCache
		{
			public static readonly Script Instance = new Script("Khoj", ScriptCode.Khoj);
		}

		/// <summary>
		/// Khitan large script
		/// added: 2014-12-11
		/// </summary>
		public static Script Kitl => KitlCache.Instance;

		private static class KitlCache
		{
			public static readonly Script Instance = new Script("Kitl", ScriptCode.Kitl);
		}

		/// <summary>
		/// Khitan small script
		/// added: 2014-12-11
		/// </summary>
		public static Script Kits => KitsCache.Instance;

		private static class KitsCache
		{
			public static readonly Script Instance = new Script("Kits", ScriptCode.Kits);
		}

		/// <summary>
		/// Kannada
		/// added: 2005-10-16
		/// </summary>
		public static Script Knda => KndaCache.Instance;

		private static class KndaCache
		{
			public static readonly Script Instance = new Script("Knda", ScriptCode.Knda);
		}

		/// <summary>
		/// Korean (alias for Hangul + Han)
		/// added: 2007-07-05
		/// </summary>
		public static Script Kore => KoreCache.Instance;

		private static class KoreCache
		{
			public static readonly Script Instance = new Script("Kore", ScriptCode.Kore);
		}

		/// <summary>
		/// Kpelle
		/// added: 2010-04-10
		/// </summary>
		public static Script Kpel => KpelCache.Instance;

		private static class KpelCache
		{
			public static readonly Script Instance = new Script("Kpel", ScriptCode.Kpel);
		}

		/// <summary>
		/// Kaithi
		/// added: 2007-12-05
		/// </summary>
		public static Script Kthi => KthiCache.Instance;

		private static class KthiCache
		{
			public static readonly Script Instance = new Script("Kthi", ScriptCode.Kthi);
		}

		/// <summary>
		/// Tai Tham
		/// Lanna
		/// added: 2006-07-21
		/// </summary>
		public static Script Lana => LanaCache.Instance;

		private static class LanaCache
		{
			public static readonly Script Instance = new Script("Lana", ScriptCode.Lana);
		}

		/// <summary>
		/// Lao
		/// added: 2005-10-16
		/// </summary>
		public static Script Laoo => LaooCache.Instance;

		private static class LaooCache
		{
			public static readonly Script Instance = new Script("Laoo", ScriptCode.Laoo);
		}

		/// <summary>
		/// Latin (Fraktur variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Latf => LatfCache.Instance;

		private static class LatfCache
		{
			public static readonly Script Instance = new Script("Latf", ScriptCode.Latf);
		}

		/// <summary>
		/// Latin (Gaelic variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Latg => LatgCache.Instance;

		private static class LatgCache
		{
			public static readonly Script Instance = new Script("Latg", ScriptCode.Latg);
		}

		/// <summary>
		/// Latin
		/// added: 2005-10-16
		/// </summary>
		public static Script Latn => LatnCache.Instance;

		private static class LatnCache
		{
			public static readonly Script Instance = new Script("Latn", ScriptCode.Latn);
		}

		/// <summary>
		/// Leke
		/// added: 2015-07-24
		/// </summary>
		public static Script Leke => LekeCache.Instance;

		private static class LekeCache
		{
			public static readonly Script Instance = new Script("Leke", ScriptCode.Leke);
		}

		/// <summary>
		/// Lepcha
		/// Róng
		/// added: 2005-10-16
		/// </summary>
		public static Script Lepc => LepcCache.Instance;

		private static class LepcCache
		{
			public static readonly Script Instance = new Script("Lepc", ScriptCode.Lepc);
		}

		/// <summary>
		/// Limbu
		/// added: 2005-10-16
		/// </summary>
		public static Script Limb => LimbCache.Instance;

		private static class LimbCache
		{
			public static readonly Script Instance = new Script("Limb", ScriptCode.Limb);
		}

		/// <summary>
		/// Linear A
		/// added: 2005-10-16
		/// </summary>
		public static Script Lina => LinaCache.Instance;

		private static class LinaCache
		{
			public static readonly Script Instance = new Script("Lina", ScriptCode.Lina);
		}

		/// <summary>
		/// Linear B
		/// added: 2005-10-16
		/// </summary>
		public static Script Linb => LinbCache.Instance;

		private static class LinbCache
		{
			public static readonly Script Instance = new Script("Linb", ScriptCode.Linb);
		}

		/// <summary>
		/// Lisu
		/// Fraser
		/// added: 2009-03-13
		/// </summary>
		public static Script Lisu => LisuCache.Instance;

		private static class LisuCache
		{
			public static readonly Script Instance = new Script("Lisu", ScriptCode.Lisu);
		}

		/// <summary>
		/// Loma
		/// added: 2010-04-10
		/// </summary>
		public static Script Loma => LomaCache.Instance;

		private static class LomaCache
		{
			public static readonly Script Instance = new Script("Loma", ScriptCode.Loma);
		}

		/// <summary>
		/// Lycian
		/// added: 2006-07-21
		/// </summary>
		public static Script Lyci => LyciCache.Instance;

		private static class LyciCache
		{
			public static readonly Script Instance = new Script("Lyci", ScriptCode.Lyci);
		}

		/// <summary>
		/// Lydian
		/// added: 2006-07-21
		/// </summary>
		public static Script Lydi => LydiCache.Instance;

		private static class LydiCache
		{
			public static readonly Script Instance = new Script("Lydi", ScriptCode.Lydi);
		}

		/// <summary>
		/// Mahajani
		/// added: 2012-11-01
		/// </summary>
		public static Script Mahj => MahjCache.Instance;

		private static class MahjCache
		{
			public static readonly Script Instance = new Script("Mahj", ScriptCode.Mahj);
		}

		/// <summary>
		/// Makasar
		/// added: 2017-01-13
		/// </summary>
		public static Script Maka => MakaCache.Instance;

		private static class MakaCache
		{
			public static readonly Script Instance = new Script("Maka", ScriptCode.Maka);
		}

		/// <summary>
		/// Mandaic
		/// Mandaean
		/// added: 2005-10-16
		/// </summary>
		public static Script Mand => MandCache.Instance;

		private static class MandCache
		{
			public static readonly Script Instance = new Script("Mand", ScriptCode.Mand);
		}

		/// <summary>
		/// Manichaean
		/// added: 2007-07-28
		/// </summary>
		public static Script Mani => ManiCache.Instance;

		private static class ManiCache
		{
			public static readonly Script Instance = new Script("Mani", ScriptCode.Mani);
		}

		/// <summary>
		/// Marchen
		/// added: 2014-12-11
		/// </summary>
		public static Script Marc => MarcCache.Instance;

		private static class MarcCache
		{
			public static readonly Script Instance = new Script("Marc", ScriptCode.Marc);
		}

		/// <summary>
		/// Mayan hieroglyphs
		/// added: 2005-10-16
		/// </summary>
		public static Script Maya => MayaCache.Instance;

		private static class MayaCache
		{
			public static readonly Script Instance = new Script("Maya", ScriptCode.Maya);
		}

		/// <summary>
		/// Medefaidrin
		/// Oberi Okaime
		/// Oberi Ɔkaimɛ
		/// added: 2017-01-13
		/// </summary>
		public static Script Medf => MedfCache.Instance;

		private static class MedfCache
		{
			public static readonly Script Instance = new Script("Medf", ScriptCode.Medf);
		}

		/// <summary>
		/// Mende Kikakui
		/// added: 2010-04-10
		/// </summary>
		public static Script Mend => MendCache.Instance;

		private static class MendCache
		{
			public static readonly Script Instance = new Script("Mend", ScriptCode.Mend);
		}

		/// <summary>
		/// Meroitic Cursive
		/// added: 2009-12-09
		/// </summary>
		public static Script Merc => MercCache.Instance;

		private static class MercCache
		{
			public static readonly Script Instance = new Script("Merc", ScriptCode.Merc);
		}

		/// <summary>
		/// Meroitic Hieroglyphs
		/// added: 2005-10-16
		/// </summary>
		public static Script Mero => MeroCache.Instance;

		private static class MeroCache
		{
			public static readonly Script Instance = new Script("Mero", ScriptCode.Mero);
		}

		/// <summary>
		/// Malayalam
		/// added: 2005-10-16
		/// </summary>
		public static Script Mlym => MlymCache.Instance;

		private static class MlymCache
		{
			public static readonly Script Instance = new Script("Mlym", ScriptCode.Mlym);
		}

		/// <summary>
		/// Modi
		/// Moḍī
		/// added: 2013-12-02
		/// </summary>
		public static Script Modi => ModiCache.Instance;

		private static class ModiCache
		{
			public static readonly Script Instance = new Script("Modi", ScriptCode.Modi);
		}

		/// <summary>
		/// Mongolian
		/// added: 2005-10-16
		/// </summary>
		public static Script Mong => MongCache.Instance;

		private static class MongCache
		{
			public static readonly Script Instance = new Script("Mong", ScriptCode.Mong);
		}

		/// <summary>
		/// Moon
		/// Moon code
		/// Moon script
		/// Moon type
		/// added: 2007-01-26
		/// </summary>
		public static Script Moon => MoonCache.Instance;

		private static class MoonCache
		{
			public static readonly Script Instance = new Script("Moon", ScriptCode.Moon);
		}

		/// <summary>
		/// Mro
		/// Mru
		/// added: 2011-01-07
		/// </summary>
		public static Script Mroo => MrooCache.Instance;

		private static class MrooCache
		{
			public static readonly Script Instance = new Script("Mroo", ScriptCode.Mroo);
		}

		/// <summary>
		/// Meitei Mayek
		/// Meithei
		/// Meetei
		/// added: 2007-01-26
		/// </summary>
		public static Script Mtei => MteiCache.Instance;

		private static class MteiCache
		{
			public static readonly Script Instance = new Script("Mtei", ScriptCode.Mtei);
		}

		/// <summary>
		/// Multani
		/// added: 2013-12-02
		/// </summary>
		public static Script Mult => MultCache.Instance;

		private static class MultCache
		{
			public static readonly Script Instance = new Script("Mult", ScriptCode.Mult);
		}

		/// <summary>
		/// Myanmar
		/// Burmese
		/// added: 2005-10-16
		/// </summary>
		public static Script Mymr => MymrCache.Instance;

		private static class MymrCache
		{
			public static readonly Script Instance = new Script("Mymr", ScriptCode.Mymr);
		}

		/// <summary>
		/// Nag Mundari
		/// added: 2021-12-24
		/// </summary>
		public static Script Nagm => NagmCache.Instance;

		private static class NagmCache
		{
			public static readonly Script Instance = new Script("Nagm", ScriptCode.Nagm);
		}

		/// <summary>
		/// Nandinagari
		/// added: 2018-10-28
		/// </summary>
		public static Script Nand => NandCache.Instance;

		private static class NandCache
		{
			public static readonly Script Instance = new Script("Nand", ScriptCode.Nand);
		}

		/// <summary>
		/// Old North Arabian
		/// Ancient North Arabian
		/// added: 2010-04-10
		/// </summary>
		public static Script Narb => NarbCache.Instance;

		private static class NarbCache
		{
			public static readonly Script Instance = new Script("Narb", ScriptCode.Narb);
		}

		/// <summary>
		/// Nabataean
		/// added: 2010-04-10
		/// </summary>
		public static Script Nbat => NbatCache.Instance;

		private static class NbatCache
		{
			public static readonly Script Instance = new Script("Nbat", ScriptCode.Nbat);
		}

		/// <summary>
		/// Newa
		/// Newar
		/// Newari
		/// Nepāla lipi
		/// added: 2016-01-04
		/// </summary>
		public static Script Newa => NewaCache.Instance;

		private static class NewaCache
		{
			public static readonly Script Instance = new Script("Newa", ScriptCode.Newa);
		}

		/// <summary>
		/// Naxi Dongba
		/// na²¹ɕi³³ to³³ba²¹
		/// Nakhi Tomba
		/// added: 2017-08-13
		/// </summary>
		public static Script Nkdb => NkdbCache.Instance;

		private static class NkdbCache
		{
			public static readonly Script Instance = new Script("Nkdb", ScriptCode.Nkdb);
		}

		/// <summary>
		/// Naxi Geba
		/// na²¹ɕi³³ gʌ²¹ba²¹
		/// 'Na-'Khi ²Ggŏ-¹baw
		/// Nakhi Geba
		/// added: 2009-03-13
		/// </summary>
		public static Script Nkgb => NkgbCache.Instance;

		private static class NkgbCache
		{
			public static readonly Script Instance = new Script("Nkgb", ScriptCode.Nkgb);
		}

		/// <summary>
		/// N’Ko
		/// N'Ko
		/// added: 2005-10-16
		/// </summary>
		public static Script Nkoo => NkooCache.Instance;

		private static class NkooCache
		{
			public static readonly Script Instance = new Script("Nkoo", ScriptCode.Nkoo);
		}

		/// <summary>
		/// Nüshu
		/// added: 2011-01-07
		/// </summary>
		public static Script Nshu => NshuCache.Instance;

		private static class NshuCache
		{
			public static readonly Script Instance = new Script("Nshu", ScriptCode.Nshu);
		}

		/// <summary>
		/// Ogham
		/// added: 2005-10-16
		/// </summary>
		public static Script Ogam => OgamCache.Instance;

		private static class OgamCache
		{
			public static readonly Script Instance = new Script("Ogam", ScriptCode.Ogam);
		}

		/// <summary>
		/// Ol Chiki
		/// Ol Cemet'
		/// Ol
		/// Santali
		/// added: 2006-07-21
		/// </summary>
		public static Script Olck => OlckCache.Instance;

		private static class OlckCache
		{
			public static readonly Script Instance = new Script("Olck", ScriptCode.Olck);
		}

		/// <summary>
		/// Old Turkic
		/// Orkhon Runic
		/// added: 2009-07-30
		/// </summary>
		public static Script Orkh => OrkhCache.Instance;

		private static class OrkhCache
		{
			public static readonly Script Instance = new Script("Orkh", ScriptCode.Orkh);
		}

		/// <summary>
		/// Oriya
		/// Odia
		/// added: 2005-10-16
		/// </summary>
		public static Script Orya => OryaCache.Instance;

		private static class OryaCache
		{
			public static readonly Script Instance = new Script("Orya", ScriptCode.Orya);
		}

		/// <summary>
		/// Osage
		/// added: 2014-12-11
		/// </summary>
		public static Script Osge => OsgeCache.Instance;

		private static class OsgeCache
		{
			public static readonly Script Instance = new Script("Osge", ScriptCode.Osge);
		}

		/// <summary>
		/// Osmanya
		/// added: 2005-10-16
		/// </summary>
		public static Script Osma => OsmaCache.Instance;

		private static class OsmaCache
		{
			public static readonly Script Instance = new Script("Osma", ScriptCode.Osma);
		}

		/// <summary>
		/// Old Uyghur
		/// added: 2021-02-12
		/// </summary>
		public static Script Ougr => OugrCache.Instance;

		private static class OugrCache
		{
			public static readonly Script Instance = new Script("Ougr", ScriptCode.Ougr);
		}

		/// <summary>
		/// Palmyrene
		/// added: 2010-04-10
		/// </summary>
		public static Script Palm => PalmCache.Instance;

		private static class PalmCache
		{
			public static readonly Script Instance = new Script("Palm", ScriptCode.Palm);
		}

		/// <summary>
		/// Pau Cin Hau
		/// added: 2013-12-02
		/// </summary>
		public static Script Pauc => PaucCache.Instance;

		private static class PaucCache
		{
			public static readonly Script Instance = new Script("Pauc", ScriptCode.Pauc);
		}

		/// <summary>
		/// Proto-Cuneiform
		/// added: 2021-02-12
		/// </summary>
		public static Script Pcun => PcunCache.Instance;

		private static class PcunCache
		{
			public static readonly Script Instance = new Script("Pcun", ScriptCode.Pcun);
		}

		/// <summary>
		/// Proto-Elamite
		/// added: 2021-02-12
		/// </summary>
		public static Script Pelm => PelmCache.Instance;

		private static class PelmCache
		{
			public static readonly Script Instance = new Script("Pelm", ScriptCode.Pelm);
		}

		/// <summary>
		/// Old Permic
		/// added: 2005-10-16
		/// </summary>
		public static Script Perm => PermCache.Instance;

		private static class PermCache
		{
			public static readonly Script Instance = new Script("Perm", ScriptCode.Perm);
		}

		/// <summary>
		/// Phags-pa
		/// added: 2005-10-16
		/// </summary>
		public static Script Phag => PhagCache.Instance;

		private static class PhagCache
		{
			public static readonly Script Instance = new Script("Phag", ScriptCode.Phag);
		}

		/// <summary>
		/// Inscriptional Pahlavi
		/// added: 2007-12-05
		/// </summary>
		public static Script Phli => PhliCache.Instance;

		private static class PhliCache
		{
			public static readonly Script Instance = new Script("Phli", ScriptCode.Phli);
		}

		/// <summary>
		/// Psalter Pahlavi
		/// added: 2007-12-05
		/// </summary>
		public static Script Phlp => PhlpCache.Instance;

		private static class PhlpCache
		{
			public static readonly Script Instance = new Script("Phlp", ScriptCode.Phlp);
		}

		/// <summary>
		/// Book Pahlavi
		/// added: 2007-07-28
		/// </summary>
		public static Script Phlv => PhlvCache.Instance;

		private static class PhlvCache
		{
			public static readonly Script Instance = new Script("Phlv", ScriptCode.Phlv);
		}

		/// <summary>
		/// Phoenician
		/// added: 2005-10-16
		/// </summary>
		public static Script Phnx => PhnxCache.Instance;

		private static class PhnxCache
		{
			public static readonly Script Instance = new Script("Phnx", ScriptCode.Phnx);
		}

		/// <summary>
		/// Klingon (KLI pIqaD)
		/// added: 2016-01-04
		/// </summary>
		public static Script Piqd => PiqdCache.Instance;

		private static class PiqdCache
		{
			public static readonly Script Instance = new Script("Piqd", ScriptCode.Piqd);
		}

		/// <summary>
		/// Miao
		/// Pollard
		/// added: 2005-10-16
		/// </summary>
		public static Script Plrd => PlrdCache.Instance;

		private static class PlrdCache
		{
			public static readonly Script Instance = new Script("Plrd", ScriptCode.Plrd);
		}

		/// <summary>
		/// Inscriptional Parthian
		/// added: 2007-12-05
		/// </summary>
		public static Script Prti => PrtiCache.Instance;

		private static class PrtiCache
		{
			public static readonly Script Instance = new Script("Prti", ScriptCode.Prti);
		}

		/// <summary>
		/// Proto-Sinaitic
		/// added: 2021-02-12
		/// </summary>
		public static Script Psin => PsinCache.Instance;

		private static class PsinCache
		{
			public static readonly Script Instance = new Script("Psin", ScriptCode.Psin);
		}

		/// <summary>
		/// Ranjana
		/// added: 2021-02-12
		/// </summary>
		public static Script Ranj => RanjCache.Instance;

		private static class RanjCache
		{
			public static readonly Script Instance = new Script("Ranj", ScriptCode.Ranj);
		}

		/// <summary>
		/// Rejang
		/// Redjang
		/// Kaganga
		/// added: 2006-10-17
		/// </summary>
		public static Script Rjng => RjngCache.Instance;

		private static class RjngCache
		{
			public static readonly Script Instance = new Script("Rjng", ScriptCode.Rjng);
		}

		/// <summary>
		/// Hanifi Rohingya
		/// added: 2017-12-13
		/// </summary>
		public static Script Rohg => RohgCache.Instance;

		private static class RohgCache
		{
			public static readonly Script Instance = new Script("Rohg", ScriptCode.Rohg);
		}

		/// <summary>
		/// Rongorongo
		/// added: 2005-10-16
		/// </summary>
		public static Script Roro => RoroCache.Instance;

		private static class RoroCache
		{
			public static readonly Script Instance = new Script("Roro", ScriptCode.Roro);
		}

		/// <summary>
		/// Runic
		/// added: 2005-10-16
		/// </summary>
		public static Script Runr => RunrCache.Instance;

		private static class RunrCache
		{
			public static readonly Script Instance = new Script("Runr", ScriptCode.Runr);
		}

		/// <summary>
		/// Samaritan
		/// added: 2007-07-28
		/// </summary>
		public static Script Samr => SamrCache.Instance;

		private static class SamrCache
		{
			public static readonly Script Instance = new Script("Samr", ScriptCode.Samr);
		}

		/// <summary>
		/// Sarati
		/// added: 2005-10-16
		/// </summary>
		public static Script Sara => SaraCache.Instance;

		private static class SaraCache
		{
			public static readonly Script Instance = new Script("Sara", ScriptCode.Sara);
		}

		/// <summary>
		/// Old South Arabian
		/// added: 2009-07-30
		/// </summary>
		public static Script Sarb => SarbCache.Instance;

		private static class SarbCache
		{
			public static readonly Script Instance = new Script("Sarb", ScriptCode.Sarb);
		}

		/// <summary>
		/// Saurashtra
		/// added: 2006-07-21
		/// </summary>
		public static Script Saur => SaurCache.Instance;

		private static class SaurCache
		{
			public static readonly Script Instance = new Script("Saur", ScriptCode.Saur);
		}

		/// <summary>
		/// SignWriting
		/// added: 2006-10-17
		/// </summary>
		public static Script Sgnw => SgnwCache.Instance;

		private static class SgnwCache
		{
			public static readonly Script Instance = new Script("Sgnw", ScriptCode.Sgnw);
		}

		/// <summary>
		/// Shavian
		/// Shaw
		/// added: 2005-10-16
		/// </summary>
		public static Script Shaw => ShawCache.Instance;

		private static class ShawCache
		{
			public static readonly Script Instance = new Script("Shaw", ScriptCode.Shaw);
		}

		/// <summary>
		/// Sharada
		/// Śāradā
		/// added: 2011-01-07
		/// </summary>
		public static Script Shrd => ShrdCache.Instance;

		private static class ShrdCache
		{
			public static readonly Script Instance = new Script("Shrd", ScriptCode.Shrd);
		}

		/// <summary>
		/// Shuishu
		/// added: 2017-08-13
		/// </summary>
		public static Script Shui => ShuiCache.Instance;

		private static class ShuiCache
		{
			public static readonly Script Instance = new Script("Shui", ScriptCode.Shui);
		}

		/// <summary>
		/// Siddham
		/// Siddhaṃ
		/// Siddhamātṛkā
		/// added: 2013-12-02
		/// </summary>
		public static Script Sidd => SiddCache.Instance;

		private static class SiddCache
		{
			public static readonly Script Instance = new Script("Sidd", ScriptCode.Sidd);
		}

		/// <summary>
		/// Khudawadi
		/// Sindhi
		/// added: 2010-08-16
		/// </summary>
		public static Script Sind => SindCache.Instance;

		private static class SindCache
		{
			public static readonly Script Instance = new Script("Sind", ScriptCode.Sind);
		}

		/// <summary>
		/// Sinhala
		/// added: 2005-10-16
		/// </summary>
		public static Script Sinh => SinhCache.Instance;

		private static class SinhCache
		{
			public static readonly Script Instance = new Script("Sinh", ScriptCode.Sinh);
		}

		/// <summary>
		/// Sogdian
		/// added: 2017-12-13
		/// </summary>
		public static Script Sogd => SogdCache.Instance;

		private static class SogdCache
		{
			public static readonly Script Instance = new Script("Sogd", ScriptCode.Sogd);
		}

		/// <summary>
		/// Old Sogdian
		/// added: 2017-12-13
		/// </summary>
		public static Script Sogo => SogoCache.Instance;

		private static class SogoCache
		{
			public static readonly Script Instance = new Script("Sogo", ScriptCode.Sogo);
		}

		/// <summary>
		/// Sora Sompeng
		/// added: 2011-01-07
		/// </summary>
		public static Script Sora => SoraCache.Instance;

		private static class SoraCache
		{
			public static readonly Script Instance = new Script("Sora", ScriptCode.Sora);
		}

		/// <summary>
		/// Soyombo
		/// added: 2017-01-13
		/// </summary>
		public static Script Soyo => SoyoCache.Instance;

		private static class SoyoCache
		{
			public static readonly Script Instance = new Script("Soyo", ScriptCode.Soyo);
		}

		/// <summary>
		/// Sundanese
		/// added: 2006-07-21
		/// </summary>
		public static Script Sund => SundCache.Instance;

		private static class SundCache
		{
			public static readonly Script Instance = new Script("Sund", ScriptCode.Sund);
		}

		/// <summary>
		/// Sunuwar
		/// added: 2021-12-24
		/// </summary>
		public static Script Sunu => SunuCache.Instance;

		private static class SunuCache
		{
			public static readonly Script Instance = new Script("Sunu", ScriptCode.Sunu);
		}

		/// <summary>
		/// Syloti Nagri
		/// added: 2005-10-16
		/// </summary>
		public static Script Sylo => SyloCache.Instance;

		private static class SyloCache
		{
			public static readonly Script Instance = new Script("Sylo", ScriptCode.Sylo);
		}

		/// <summary>
		/// Syriac
		/// added: 2005-10-16
		/// </summary>
		public static Script Syrc => SyrcCache.Instance;

		private static class SyrcCache
		{
			public static readonly Script Instance = new Script("Syrc", ScriptCode.Syrc);
		}

		/// <summary>
		/// Syriac (Estrangelo variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Syre => SyreCache.Instance;

		private static class SyreCache
		{
			public static readonly Script Instance = new Script("Syre", ScriptCode.Syre);
		}

		/// <summary>
		/// Syriac (Western variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Syrj => SyrjCache.Instance;

		private static class SyrjCache
		{
			public static readonly Script Instance = new Script("Syrj", ScriptCode.Syrj);
		}

		/// <summary>
		/// Syriac (Eastern variant)
		/// added: 2005-10-16
		/// </summary>
		public static Script Syrn => SyrnCache.Instance;

		private static class SyrnCache
		{
			public static readonly Script Instance = new Script("Syrn", ScriptCode.Syrn);
		}

		/// <summary>
		/// Tagbanwa
		/// added: 2005-10-16
		/// </summary>
		public static Script Tagb => TagbCache.Instance;

		private static class TagbCache
		{
			public static readonly Script Instance = new Script("Tagb", ScriptCode.Tagb);
		}

		/// <summary>
		/// Takri
		/// Ṭākrī
		/// Ṭāṅkrī
		/// added: 2011-01-07
		/// </summary>
		public static Script Takr => TakrCache.Instance;

		private static class TakrCache
		{
			public static readonly Script Instance = new Script("Takr", ScriptCode.Takr);
		}

		/// <summary>
		/// Tai Le
		/// added: 2005-10-16
		/// </summary>
		public static Script Tale => TaleCache.Instance;

		private static class TaleCache
		{
			public static readonly Script Instance = new Script("Tale", ScriptCode.Tale);
		}

		/// <summary>
		/// New Tai Lue
		/// added: 2005-10-16
		/// </summary>
		public static Script Talu => TaluCache.Instance;

		private static class TaluCache
		{
			public static readonly Script Instance = new Script("Talu", ScriptCode.Talu);
		}

		/// <summary>
		/// Tamil
		/// added: 2005-10-16
		/// </summary>
		public static Script Taml => TamlCache.Instance;

		private static class TamlCache
		{
			public static readonly Script Instance = new Script("Taml", ScriptCode.Taml);
		}

		/// <summary>
		/// Tangut
		/// added: 2011-01-07
		/// </summary>
		public static Script Tang => TangCache.Instance;

		private static class TangCache
		{
			public static readonly Script Instance = new Script("Tang", ScriptCode.Tang);
		}

		/// <summary>
		/// Tai Viet
		/// added: 2007-12-05
		/// </summary>
		public static Script Tavt => TavtCache.Instance;

		private static class TavtCache
		{
			public static readonly Script Instance = new Script("Tavt", ScriptCode.Tavt);
		}

		/// <summary>
		/// Telugu
		/// added: 2005-10-16
		/// </summary>
		public static Script Telu => TeluCache.Instance;

		private static class TeluCache
		{
			public static readonly Script Instance = new Script("Telu", ScriptCode.Telu);
		}

		/// <summary>
		/// Tengwar
		/// added: 2005-10-16
		/// </summary>
		public static Script Teng => TengCache.Instance;

		private static class TengCache
		{
			public static readonly Script Instance = new Script("Teng", ScriptCode.Teng);
		}

		/// <summary>
		/// Tifinagh
		/// Berber
		/// added: 2005-10-16
		/// </summary>
		public static Script Tfng => TfngCache.Instance;

		private static class TfngCache
		{
			public static readonly Script Instance = new Script("Tfng", ScriptCode.Tfng);
		}

		/// <summary>
		/// Tagalog
		/// Baybayin
		/// Alibata
		/// added: 2005-10-16
		/// </summary>
		public static Script Tglg => TglgCache.Instance;

		private static class TglgCache
		{
			public static readonly Script Instance = new Script("Tglg", ScriptCode.Tglg);
		}

		/// <summary>
		/// Thaana
		/// added: 2005-10-16
		/// </summary>
		public static Script Thaa => ThaaCache.Instance;

		private static class ThaaCache
		{
			public static readonly Script Instance = new Script("Thaa", ScriptCode.Thaa);
		}

		/// <summary>
		/// Thai
		/// added: 2005-10-16
		/// </summary>
		public static Script Thai => ThaiCache.Instance;

		private static class ThaiCache
		{
			public static readonly Script Instance = new Script("Thai", ScriptCode.Thai);
		}

		/// <summary>
		/// Tibetan
		/// added: 2005-10-16
		/// </summary>
		public static Script Tibt => TibtCache.Instance;

		private static class TibtCache
		{
			public static readonly Script Instance = new Script("Tibt", ScriptCode.Tibt);
		}

		/// <summary>
		/// Tirhuta
		/// added: 2011-08-16
		/// </summary>
		public static Script Tirh => TirhCache.Instance;

		private static class TirhCache
		{
			public static readonly Script Instance = new Script("Tirh", ScriptCode.Tirh);
		}

		/// <summary>
		/// Tangsa
		/// added: 2021-03-05
		/// </summary>
		public static Script Tnsa => TnsaCache.Instance;

		private static class TnsaCache
		{
			public static readonly Script Instance = new Script("Tnsa", ScriptCode.Tnsa);
		}

		/// <summary>
		/// Toto
		/// added: 2020-05-12
		/// </summary>
		public static Script Toto => TotoCache.Instance;

		private static class TotoCache
		{
			public static readonly Script Instance = new Script("Toto", ScriptCode.Toto);
		}

		/// <summary>
		/// Ugaritic
		/// added: 2005-10-16
		/// </summary>
		public static Script Ugar => UgarCache.Instance;

		private static class UgarCache
		{
			public static readonly Script Instance = new Script("Ugar", ScriptCode.Ugar);
		}

		/// <summary>
		/// Vai
		/// added: 2005-10-16
		/// </summary>
		public static Script Vaii => VaiiCache.Instance;

		private static class VaiiCache
		{
			public static readonly Script Instance = new Script("Vaii", ScriptCode.Vaii);
		}

		/// <summary>
		/// Visible Speech
		/// added: 2005-10-16
		/// </summary>
		public static Script Visp => VispCache.Instance;

		private static class VispCache
		{
			public static readonly Script Instance = new Script("Visp", ScriptCode.Visp);
		}

		/// <summary>
		/// Vithkuqi
		/// added: 2021-03-05
		/// </summary>
		public static Script Vith => VithCache.Instance;

		private static class VithCache
		{
			public static readonly Script Instance = new Script("Vith", ScriptCode.Vith);
		}

		/// <summary>
		/// Warang Citi
		/// Varang Kshiti
		/// added: 2009-12-09
		/// </summary>
		public static Script Wara => WaraCache.Instance;

		private static class WaraCache
		{
			public static readonly Script Instance = new Script("Wara", ScriptCode.Wara);
		}

		/// <summary>
		/// Wancho
		/// added: 2017-08-13
		/// </summary>
		public static Script Wcho => WchoCache.Instance;

		private static class WchoCache
		{
			public static readonly Script Instance = new Script("Wcho", ScriptCode.Wcho);
		}

		/// <summary>
		/// Woleai
		/// added: 2011-01-07
		/// </summary>
		public static Script Wole => WoleCache.Instance;

		private static class WoleCache
		{
			public static readonly Script Instance = new Script("Wole", ScriptCode.Wole);
		}

		/// <summary>
		/// Old Persian
		/// added: 2005-10-16
		/// </summary>
		public static Script Xpeo => XpeoCache.Instance;

		private static class XpeoCache
		{
			public static readonly Script Instance = new Script("Xpeo", ScriptCode.Xpeo);
		}

		/// <summary>
		/// Sumero-Akkadian cuneiform
		/// added: 2005-10-16
		/// </summary>
		public static Script Xsux => XsuxCache.Instance;

		private static class XsuxCache
		{
			public static readonly Script Instance = new Script("Xsux", ScriptCode.Xsux);
		}

		/// <summary>
		/// Yezidi
		/// added: 2019-09-11
		/// </summary>
		public static Script Yezi => YeziCache.Instance;

		private static class YeziCache
		{
			public static readonly Script Instance = new Script("Yezi", ScriptCode.Yezi);
		}

		/// <summary>
		/// Yi
		/// added: 2005-10-16
		/// </summary>
		public static Script Yiii => YiiiCache.Instance;

		private static class YiiiCache
		{
			public static readonly Script Instance = new Script("Yiii", ScriptCode.Yiii);
		}

		/// <summary>
		/// Zanabazar Square
		/// Zanabazarin Dörböljin Useg
		/// Xewtee Dörböljin Bicig
		/// Horizontal Square Script
		/// added: 2017-01-13
		/// </summary>
		public static Script Zanb => ZanbCache.Instance;

		private static class ZanbCache
		{
			public static readonly Script Instance = new Script("Zanb", ScriptCode.Zanb);
		}

		/// <summary>
		/// Code for inherited script
		/// Not intended for use as a language subtag
		/// added: 2009-04-03
		/// </summary>
		public static Script Zinh => ZinhCache.Instance;

		private static class ZinhCache
		{
			public static readonly Script Instance = new Script("Zinh", ScriptCode.Zinh);
		}

		/// <summary>
		/// Mathematical notation
		/// added: 2007-12-05
		/// </summary>
		public static Script Zmth => ZmthCache.Instance;

		private static class ZmthCache
		{
			public static readonly Script Instance = new Script("Zmth", ScriptCode.Zmth);
		}

		/// <summary>
		/// Symbols (Emoji variant)
		/// added: 2016-01-04
		/// </summary>
		public static Script Zsye => ZsyeCache.Instance;

		private static class ZsyeCache
		{
			public static readonly Script Instance = new Script("Zsye", ScriptCode.Zsye);
		}

		/// <summary>
		/// Symbols
		/// added: 2007-12-05
		/// </summary>
		public static Script Zsym => ZsymCache.Instance;

		private static class ZsymCache
		{
			public static readonly Script Instance = new Script("Zsym", ScriptCode.Zsym);
		}

		/// <summary>
		/// Code for unwritten documents
		/// added: 2005-10-16
		/// </summary>
		public static Script Zxxx => ZxxxCache.Instance;

		private static class ZxxxCache
		{
			public static readonly Script Instance = new Script("Zxxx", ScriptCode.Zxxx);
		}

		/// <summary>
		/// Code for undetermined script
		/// added: 2005-10-16
		/// </summary>
		public static Script Zyyy => ZyyyCache.Instance;

		private static class ZyyyCache
		{
			public static readonly Script Instance = new Script("Zyyy", ScriptCode.Zyyy);
		}

		/// <summary>
		/// Code for uncoded script
		/// added: 2005-10-16
		/// </summary>
		public static Script Zzzz => ZzzzCache.Instance;

		private static class ZzzzCache
		{
			public static readonly Script Instance = new Script("Zzzz", ScriptCode.Zzzz);
		}

	}
}
