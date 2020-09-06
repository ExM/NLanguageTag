using System;

namespace NLanguageTag
{
	public partial class Variant
	{
		/// <summary>
		/// Late Middle French (to 1606)
		/// 16th century French as in Jean Nicot, "Thresor de la langue francoyse", 1606, but also including some French similar to that of Rabelais
		/// added: 2007-03-20
		/// </summary>
		public static Variant V1606nict => V1606nictCache.Instance;

		private static class V1606nictCache
		{
			public static readonly Variant Instance = new Variant("1606nict", VariantCode.V1606nict, new string[] { "frm" }, false);
		}

		/// <summary>
		/// Early Modern French
		/// 17th century French, as catalogued in the "Dictionnaire de l'académie françoise", 4eme ed. 1694; frequently includes elements of Middle French, as this is a transitional period
		/// added: 2007-03-20
		/// </summary>
		public static Variant V1694acad => V1694acadCache.Instance;

		private static class V1694acadCache
		{
			public static readonly Variant Instance = new Variant("1694acad", VariantCode.V1694acad, new string[] { "fr" }, false);
		}

		/// <summary>
		/// Traditional German orthography
		/// added: 2005-10-16
		/// </summary>
		public static Variant V1901 => V1901Cache.Instance;

		private static class V1901Cache
		{
			public static readonly Variant Instance = new Variant("1901", VariantCode.V1901, new string[] { "de" }, false);
		}

		/// <summary>
		/// "Academic" ("governmental") variant of Belarusian as codified in 1959
		/// added: 2008-09-30
		/// </summary>
		public static Variant V1959acad => V1959acadCache.Instance;

		private static class V1959acadCache
		{
			public static readonly Variant Instance = new Variant("1959acad", VariantCode.V1959acad, new string[] { "be" }, false);
		}

		/// <summary>
		/// Standardized Resian orthography
		/// For standardized Resian an orthography was published in 1994.
		/// added: 2007-07-28
		/// </summary>
		public static Variant V1994 => V1994Cache.Instance;

		private static class V1994Cache
		{
			public static readonly Variant Instance = new Variant("1994", VariantCode.V1994, new string[] { "sl-rozaj", "sl-rozaj-biske", "sl-rozaj-njiva", "sl-rozaj-osojs", "sl-rozaj-solba" }, false);
		}

		/// <summary>
		/// German orthography of 1996
		/// added: 2005-10-16
		/// </summary>
		public static Variant V1996 => V1996Cache.Instance;

		private static class V1996Cache
		{
			public static readonly Variant Instance = new Variant("1996", VariantCode.V1996, new string[] { "de" }, false);
		}

		/// <summary>
		/// Orthographic formulation of 1943 - Official in Brazil (Formulário Ortográfico de 1943 - Oficial no Brasil)
		/// Denotes conventions established by the Academia Brasileira de Letras in 1943 and generally used in Brazil until 2009
		/// added: 2015-05-06
		/// </summary>
		public static Variant Abl1943 => Abl1943Cache.Instance;

		private static class Abl1943Cache
		{
			public static readonly Variant Instance = new Variant("abl1943", VariantCode.Abl1943, new string[] { "pt-BR" }, false);
		}

		/// <summary>
		/// Akuapem Twi
		/// added: 2017-06-05
		/// </summary>
		public static Variant Akuapem => AkuapemCache.Instance;

		private static class AkuapemCache
		{
			public static readonly Variant Instance = new Variant("akuapem", VariantCode.Akuapem, new string[] { "tw" }, false);
		}

		/// <summary>
		/// ALA-LC Romanization, 1997 edition
		/// Romanizations recommended by the American Library Association and the Library of Congress, in "ALA-LC Romanization Tables: Transliteration Schemes for Non-Roman Scripts" (1997), ISBN 978-0-8444-0940-5.
		/// added: 2009-12-09
		/// </summary>
		public static Variant Alalc97 => Alalc97Cache.Instance;

		private static class Alalc97Cache
		{
			public static readonly Variant Instance = new Variant("alalc97", VariantCode.Alalc97, new string[] {  }, false);
		}

		/// <summary>
		/// Aluku dialect
		/// Boni dialect
		/// Aluku dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// added: 2009-09-05
		/// </summary>
		public static Variant Aluku => AlukuCache.Instance;

		private static class AlukuCache
		{
			public static readonly Variant Instance = new Variant("aluku", VariantCode.Aluku, new string[] { "djk" }, false);
		}

		/// <summary>
		/// Portuguese Language Orthographic Agreement of 1990 (Acordo Ortográfico da Língua Portuguesa de 1990)
		/// Portuguese orthography conventions established in 1990 but not brought into effect until 2009
		/// added: 2015-05-06
		/// </summary>
		public static Variant Ao1990 => Ao1990Cache.Instance;

		private static class Ao1990Cache
		{
			public static readonly Variant Instance = new Variant("ao1990", VariantCode.Ao1990, new string[] { "pt", "gl" }, false);
		}

		/// <summary>
		/// Aranese
		/// Occitan variant spoken in the Val d'Aran
		/// added: 2018-04-22
		/// </summary>
		public static Variant Aranes => AranesCache.Instance;

		private static class AranesCache
		{
			public static readonly Variant Instance = new Variant("aranes", VariantCode.Aranes, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Eastern Armenian
		/// Preferred tag is hy
		/// added: 2006-09-18
		/// </summary>
		[Obsolete("Preferred tag is hy, deprecated from 2018-03-24")]
		public static Variant Arevela => ArevelaCache.Instance;

		private static class ArevelaCache
		{
			public static readonly Variant Instance = new Variant("arevela", VariantCode.Arevela, new string[] { "hy" }, true);
		}

		/// <summary>
		/// Western Armenian
		/// Preferred tag is hyw
		/// added: 2006-09-18
		/// </summary>
		[Obsolete("Preferred tag is hyw, deprecated from 2018-03-24")]
		public static Variant Arevmda => ArevmdaCache.Instance;

		private static class ArevmdaCache
		{
			public static readonly Variant Instance = new Variant("arevmda", VariantCode.Arevmda, new string[] { "hy" }, true);
		}

		/// <summary>
		/// Asante Twi
		/// Ashanti Twi
		/// added: 2017-06-05
		/// </summary>
		public static Variant Asante => AsanteCache.Instance;

		private static class AsanteCache
		{
			public static readonly Variant Instance = new Variant("asante", VariantCode.Asante, new string[] { "tw" }, false);
		}

		/// <summary>
		/// Auvergnat
		/// Occitan variant spoken in Auvergne
		/// added: 2018-04-22
		/// </summary>
		public static Variant Auvern => AuvernCache.Instance;

		private static class AuvernCache
		{
			public static readonly Variant Instance = new Variant("auvern", VariantCode.Auvern, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Unified Turkic Latin Alphabet (Historical)
		/// Denotes alphabet used in Turkic republics/regions of the former USSR in late 1920s, and throughout 1930s, which aspired to represent equivalent phonemes in a unified fashion. Also known as: New Turkic Alphabet; Birlәşdirilmiş Jeni Tyrk Әlifbasь (Birlesdirilmis Jeni Tyrk Elifbasi); Jaŋalif (Janalif).
		/// added: 2007-04-18
		/// </summary>
		public static Variant Baku1926 => Baku1926Cache.Instance;

		private static class Baku1926Cache
		{
			public static readonly Variant Instance = new Variant("baku1926", VariantCode.Baku1926, new string[] { "az", "ba", "crh", "kk", "krc", "ky", "sah", "tk", "tt", "uz" }, false);
		}

		/// <summary>
		/// The Balanka dialect of Anii
		/// Balanka is one of 19 Anii dialects.
		/// added: 2014-02-15
		/// </summary>
		public static Variant Balanka => BalankaCache.Instance;

		private static class BalankaCache
		{
			public static readonly Variant Instance = new Variant("balanka", VariantCode.Balanka, new string[] { "blo" }, false);
		}

		/// <summary>
		/// The Barlavento dialect group of Kabuverdianu
		/// Barlavento is one of the two main dialect groups of Kabuverdianu.
		/// added: 2013-12-10
		/// </summary>
		public static Variant Barla => BarlaCache.Instance;

		private static class BarlaCache
		{
			public static readonly Variant Instance = new Variant("barla", VariantCode.Barla, new string[] { "kea" }, false);
		}

		/// <summary>
		/// Basic English
		/// added: 2015-12-29
		/// </summary>
		public static Variant Basiceng => BasicengCache.Instance;

		private static class BasicengCache
		{
			public static readonly Variant Instance = new Variant("basiceng", VariantCode.Basiceng, new string[] { "en" }, false);
		}

		/// <summary>
		/// Buddhist Hybrid Sanskrit
		/// added: 2010-07-28
		/// </summary>
		public static Variant Bauddha => BauddhaCache.Instance;

		private static class BauddhaCache
		{
			public static readonly Variant Instance = new Variant("bauddha", VariantCode.Bauddha, new string[] { "sa" }, false);
		}

		/// <summary>
		/// Biscayan dialect of Basque
		/// added: 2010-04-13
		/// </summary>
		public static Variant Biscayan => BiscayanCache.Instance;

		private static class BiscayanCache
		{
			public static readonly Variant Instance = new Variant("biscayan", VariantCode.Biscayan, new string[] { "eu" }, false);
		}

		/// <summary>
		/// The San Giorgio dialect of Resian
		/// The Bila dialect of Resian
		/// The dialect of San Giorgio/Bila is one of the four major local dialects of Resian
		/// added: 2007-07-05
		/// </summary>
		public static Variant Biske => BiskeCache.Instance;

		private static class BiskeCache
		{
			public static readonly Variant Instance = new Variant("biske", VariantCode.Biske, new string[] { "sl-rozaj" }, false);
		}

		/// <summary>
		/// Slovene in Bohorič alphabet
		/// The subtag represents the alphabet codified by Adam Bohorič in 1584 and used from the first printed Slovene book and up to the mid-19th century.
		/// added: 2012-06-27
		/// </summary>
		public static Variant Bohoric => BohoricCache.Instance;

		private static class BohoricCache
		{
			public static readonly Variant Instance = new Variant("bohoric", VariantCode.Bohoric, new string[] { "sl" }, false);
		}

		/// <summary>
		/// Boontling
		/// Jargon embedded in American English
		/// added: 2006-09-18
		/// </summary>
		public static Variant Boont => BoontCache.Instance;

		private static class BoontCache
		{
			public static readonly Variant Instance = new Variant("boont", VariantCode.Boont, new string[] { "en" }, false);
		}

		/// <summary>
		/// Bornholmsk
		/// added: 2019-03-27
		/// </summary>
		public static Variant Bornholm => BornholmCache.Instance;

		private static class BornholmCache
		{
			public static readonly Variant Instance = new Variant("bornholm", VariantCode.Bornholm, new string[] { "da" }, false);
		}

		/// <summary>
		/// Cisalpine
		/// Occitan variant spoken in northwestern Italy
		/// added: 2018-04-22
		/// </summary>
		public static Variant Cisaup => CisaupCache.Instance;

		private static class CisaupCache
		{
			public static readonly Variant Instance = new Variant("cisaup", VariantCode.Cisaup, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Portuguese-Brazilian Orthographic Convention of 1945 (Convenção Ortográfica Luso-Brasileira de 1945)
		/// Portuguese orthography conventions established in 1945, generally in effect until 2009. This reform was not ratified in Brazil.
		/// added: 2015-05-06
		/// </summary>
		public static Variant Colb1945 => Colb1945Cache.Instance;

		private static class Colb1945Cache
		{
			public static readonly Variant Instance = new Variant("colb1945", VariantCode.Colb1945, new string[] { "pt" }, false);
		}

		/// <summary>
		/// Cornu-English
		/// Cornish English
		/// Anglo-Cornish
		/// added: 2015-12-07
		/// </summary>
		public static Variant Cornu => CornuCache.Instance;

		private static class CornuCache
		{
			public static readonly Variant Instance = new Variant("cornu", VariantCode.Cornu, new string[] { "en" }, false);
		}

		/// <summary>
		/// Occitan variants of the Croissant area
		/// added: 2018-04-22
		/// </summary>
		public static Variant Creiss => CreissCache.Instance;

		private static class CreissCache
		{
			public static readonly Variant Instance = new Variant("creiss", VariantCode.Creiss, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Slovene in Dajnko alphabet
		/// The subtag represents the alphabet codified by Peter Dajnko and used from 1824 to 1839 mostly in Styria (in what is now Eastern Slovenia).
		/// added: 2012-06-27
		/// </summary>
		public static Variant Dajnko => DajnkoCache.Instance;

		private static class DajnkoCache
		{
			public static readonly Variant Instance = new Variant("dajnko", VariantCode.Dajnko, new string[] { "sl" }, false);
		}

		/// <summary>
		/// Serbian with Ekavian pronunciation
		/// added: 2013-12-02
		/// </summary>
		public static Variant Ekavsk => EkavskCache.Instance;

		private static class EkavskCache
		{
			public static readonly Variant Instance = new Variant("ekavsk", VariantCode.Ekavsk, new string[] { "sr", "sr-Latn", "sr-Cyrl" }, false);
		}

		/// <summary>
		/// Early Modern English (1500-1700)
		/// added: 2012-02-05
		/// </summary>
		public static Variant Emodeng => EmodengCache.Instance;

		private static class EmodengCache
		{
			public static readonly Variant Instance = new Variant("emodeng", VariantCode.Emodeng, new string[] { "en" }, false);
		}

		/// <summary>
		/// International Phonetic Alphabet
		/// added: 2006-12-11
		/// </summary>
		public static Variant Fonipa => FonipaCache.Instance;

		private static class FonipaCache
		{
			public static readonly Variant Instance = new Variant("fonipa", VariantCode.Fonipa, new string[] {  }, false);
		}

		/// <summary>
		/// Kirshenbaum Phonetic Alphabet
		/// added: 2018-04-22
		/// </summary>
		public static Variant Fonkirsh => FonkirshCache.Instance;

		private static class FonkirshCache
		{
			public static readonly Variant Instance = new Variant("fonkirsh", VariantCode.Fonkirsh, new string[] {  }, false);
		}

		/// <summary>
		/// North American Phonetic Alphabet
		/// Americanist Phonetic Notation
		/// added: 2016-06-24
		/// </summary>
		public static Variant Fonnapa => FonnapaCache.Instance;

		private static class FonnapaCache
		{
			public static readonly Variant Instance = new Variant("fonnapa", VariantCode.Fonnapa, new string[] {  }, false);
		}

		/// <summary>
		/// Uralic Phonetic Alphabet
		/// added: 2006-12-11
		/// </summary>
		public static Variant Fonupa => FonupaCache.Instance;

		private static class FonupaCache
		{
			public static readonly Variant Instance = new Variant("fonupa", VariantCode.Fonupa, new string[] {  }, false);
		}

		/// <summary>
		/// X-SAMPA transcription
		/// Indicates that the content is transcribed according to X-SAMPA
		/// added: 2010-10-23
		/// </summary>
		public static Variant Fonxsamp => FonxsampCache.Instance;

		private static class FonxsampCache
		{
			public static readonly Variant Instance = new Variant("fonxsamp", VariantCode.Fonxsamp, new string[] {  }, false);
		}

		/// <summary>
		/// Gascon
		/// Occitan variant spoken in Gascony
		/// added: 2018-04-22
		/// </summary>
		public static Variant Gascon => GasconCache.Instance;

		private static class GasconCache
		{
			public static readonly Variant Instance = new Variant("gascon", VariantCode.Gascon, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Classical Occitan orthography
		/// Classical written standard for Occitan developed in 1935 by Alibèrt
		/// added: 2018-04-22
		/// </summary>
		public static Variant Grclass => GrclassCache.Instance;

		private static class GrclassCache
		{
			public static readonly Variant Instance = new Variant("grclass", VariantCode.Grclass, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Italian-inspired Occitan orthography
		/// added: 2018-04-22
		/// </summary>
		public static Variant Grital => GritalCache.Instance;

		private static class GritalCache
		{
			public static readonly Variant Instance = new Variant("grital", VariantCode.Grital, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Mistralian or Mistralian-inspired Occitan orthography
		/// Written standard developed by Romanilha in 1853 and used by Mistral and the Félibres, including derived standards such as Escolo dóu Po, Escolo Gaston Febus, and others
		/// added: 2018-04-22
		/// </summary>
		public static Variant Grmistr => GrmistrCache.Instance;

		private static class GrmistrCache
		{
			public static readonly Variant Instance = new Variant("grmistr", VariantCode.Grmistr, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Hepburn romanization
		/// added: 2009-10-01
		/// </summary>
		public static Variant Hepburn => HepburnCache.Instance;

		private static class HepburnCache
		{
			public static readonly Variant Instance = new Variant("hepburn", VariantCode.Hepburn, new string[] { "ja-Latn" }, false);
		}

		/// <summary>
		/// Hepburn romanization, Library of Congress method
		/// Preferred tag is ja-Latn-alalc97
		/// added: 2009-10-01
		/// </summary>
		[Obsolete("Preferred tag is ja-Latn-alalc97, deprecated from 2010-02-07")]
		public static Variant Heploc => HeplocCache.Instance;

		private static class HeplocCache
		{
			public static readonly Variant Instance = new Variant("heploc", VariantCode.Heploc, new string[] { "ja-Latn-hepburn" }, true);
		}

		/// <summary>
		/// Norwegian in Høgnorsk (High Norwegian) orthography
		/// Norwegian following Ivar Aasen's orthographical principles, including modern usage.
		/// added: 2010-01-02
		/// </summary>
		public static Variant Hognorsk => HognorskCache.Instance;

		private static class HognorskCache
		{
			public static readonly Variant Instance = new Variant("hognorsk", VariantCode.Hognorsk, new string[] { "nn" }, false);
		}

		/// <summary>
		/// Standard H-system orthographic fallback for spelling Esperanto
		/// added: 2017-03-14
		/// </summary>
		public static Variant Hsistemo => HsistemoCache.Instance;

		private static class HsistemoCache
		{
			public static readonly Variant Instance = new Variant("hsistemo", VariantCode.Hsistemo, new string[] { "eo" }, false);
		}

		/// <summary>
		/// Serbian with Ijekavian pronunciation
		/// added: 2013-12-02
		/// </summary>
		public static Variant Ijekavsk => IjekavskCache.Instance;

		private static class IjekavskCache
		{
			public static readonly Variant Instance = new Variant("ijekavsk", VariantCode.Ijekavsk, new string[] { "sr", "sr-Latn", "sr-Cyrl" }, false);
		}

		/// <summary>
		/// Epic Sanskrit
		/// added: 2010-07-28
		/// </summary>
		public static Variant Itihasa => ItihasaCache.Instance;

		private static class ItihasaCache
		{
			public static readonly Variant Instance = new Variant("itihasa", VariantCode.Itihasa, new string[] { "sa" }, false);
		}

		/// <summary>
		/// Bulgarian in 1899 orthography
		/// Bulgarian orthography introduced by Todor Ivanchov in 1899
		/// added: 2017-12-13
		/// </summary>
		public static Variant Ivanchov => IvanchovCache.Instance;

		private static class IvanchovCache
		{
			public static readonly Variant Instance = new Variant("ivanchov", VariantCode.Ivanchov, new string[] { "bg" }, false);
		}

		/// <summary>
		/// Jauer dialect of Romansh
		/// The spoken dialect of the Val Müstair, which has no written standard.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Jauer => JauerCache.Instance;

		private static class JauerCache
		{
			public static readonly Variant Instance = new Variant("jauer", VariantCode.Jauer, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Jyutping Cantonese Romanization
		/// Jyutping romanization of Cantonese
		/// added: 2010-10-23
		/// </summary>
		public static Variant Jyutping => JyutpingCache.Instance;

		private static class JyutpingCache
		{
			public static readonly Variant Instance = new Variant("jyutping", VariantCode.Jyutping, new string[] { "yue" }, false);
		}

		/// <summary>
		/// Common Cornish orthography of Revived Cornish
		/// added: 2008-10-14
		/// </summary>
		public static Variant Kkcor => KkcorCache.Instance;

		private static class KkcorCache
		{
			public static readonly Variant Instance = new Variant("kkcor", VariantCode.Kkcor, new string[] { "kw" }, false);
		}

		/// <summary>
		/// The Kociewie dialect of Polish
		/// The dialect of Kociewie is spoken in the region around Starogard Gdański, Tczew and Świecie in northern Poland.
		/// added: 2014-11-27
		/// </summary>
		public static Variant Kociewie => KociewieCache.Instance;

		private static class KociewieCache
		{
			public static readonly Variant Instance = new Variant("kociewie", VariantCode.Kociewie, new string[] { "pl" }, false);
		}

		/// <summary>
		/// Standard Cornish orthography of Revived Cornish
		/// Kernowek Standard
		/// added: 2012-06-27
		/// </summary>
		public static Variant Kscor => KscorCache.Instance;

		private static class KscorCache
		{
			public static readonly Variant Instance = new Variant("kscor", VariantCode.Kscor, new string[] { "kw" }, false);
		}

		/// <summary>
		/// Classical Sanskrit
		/// added: 2010-07-28
		/// </summary>
		public static Variant Laukika => LaukikaCache.Instance;

		private static class LaukikaCache
		{
			public static readonly Variant Instance = new Variant("laukika", VariantCode.Laukika, new string[] { "sa" }, false);
		}

		/// <summary>
		/// Limousin
		/// Occitan variant spoken in Limousin
		/// added: 2018-04-22
		/// </summary>
		public static Variant Lemosin => LemosinCache.Instance;

		private static class LemosinCache
		{
			public static readonly Variant Instance = new Variant("lemosin", VariantCode.Lemosin, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Languedocien
		/// Occitan variant spoken in Languedoc
		/// added: 2018-04-22
		/// </summary>
		public static Variant Lengadoc => LengadocCache.Instance;

		private static class LengadocCache
		{
			public static readonly Variant Instance = new Variant("lengadoc", VariantCode.Lengadoc, new string[] { "oc" }, false);
		}

		/// <summary>
		/// The Lipovaz dialect of Resian
		/// The Lipovec dialect of Resian
		/// The dialect of Lipovaz/Lipovec is one of the minor local dialects of Resian
		/// added: 2007-08-11
		/// </summary>
		public static Variant Lipaw => LipawCache.Instance;

		private static class LipawCache
		{
			public static readonly Variant Instance = new Variant("lipaw", VariantCode.Lipaw, new string[] { "sl-rozaj" }, false);
		}

		/// <summary>
		/// Post-1917 Russian orthography
		/// Russian orthography as established by the 1917/1918 orthographic reforms
		/// added: 2010-10-10
		/// </summary>
		public static Variant Luna1918 => Luna1918Cache.Instance;

		private static class Luna1918Cache
		{
			public static readonly Variant Instance = new Variant("luna1918", VariantCode.Luna1918, new string[] { "ru" }, false);
		}

		/// <summary>
		/// Slovene in Metelko alphabet
		/// The subtag represents the alphabet codified by Franc Serafin Metelko and used from 1825 to 1833.
		/// added: 2012-06-27
		/// </summary>
		public static Variant Metelko => MetelkoCache.Instance;

		private static class MetelkoCache
		{
			public static readonly Variant Instance = new Variant("metelko", VariantCode.Metelko, new string[] { "sl" }, false);
		}

		/// <summary>
		/// Monotonic Greek
		/// added: 2006-12-11
		/// </summary>
		public static Variant Monoton => MonotonCache.Instance;

		private static class MonotonCache
		{
			public static readonly Variant Instance = new Variant("monoton", VariantCode.Monoton, new string[] { "el" }, false);
		}

		/// <summary>
		/// Ndyuka dialect
		/// Aukan dialect
		/// Ndyuka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// added: 2009-09-05
		/// </summary>
		public static Variant Ndyuka => NdyukaCache.Instance;

		private static class NdyukaCache
		{
			public static readonly Variant Instance = new Variant("ndyuka", VariantCode.Ndyuka, new string[] { "djk" }, false);
		}

		/// <summary>
		/// Natisone dialect
		/// Nadiza dialect
		/// added: 2005-10-16
		/// </summary>
		public static Variant Nedis => NedisCache.Instance;

		private static class NedisCache
		{
			public static readonly Variant Instance = new Variant("nedis", VariantCode.Nedis, new string[] { "sl" }, false);
		}

		/// <summary>
		/// Newfoundland English
		/// added: 2015-11-25
		/// </summary>
		public static Variant Newfound => NewfoundCache.Instance;

		private static class NewfoundCache
		{
			public static readonly Variant Instance = new Variant("newfound", VariantCode.Newfound, new string[] { "en-CA" }, false);
		}

		/// <summary>
		/// Niçard
		/// Occitan variant spoken in Nice
		/// added: 2018-04-22
		/// </summary>
		public static Variant Nicard => NicardCache.Instance;

		private static class NicardCache
		{
			public static readonly Variant Instance = new Variant("nicard", VariantCode.Nicard, new string[] { "oc" }, false);
		}

		/// <summary>
		/// The Gniva dialect of Resian
		/// The Njiva dialect of Resian
		/// The dialect of Gniva/Njiva is one of the four major local dialects of Resian
		/// added: 2007-07-05
		/// </summary>
		public static Variant Njiva => NjivaCache.Instance;

		private static class NjivaCache
		{
			public static readonly Variant Instance = new Variant("njiva", VariantCode.Njiva, new string[] { "sl-rozaj" }, false);
		}

		/// <summary>
		/// Volapük nulik
		/// Volapük perevidöl
		/// Volapük nulädik
		/// de Jong's Volapük
		/// New Volapük
		/// Revised Volapük
		/// Modern Volapük
		/// added: 2012-01-28
		/// </summary>
		public static Variant Nulik => NulikCache.Instance;

		private static class NulikCache
		{
			public static readonly Variant Instance = new Variant("nulik", VariantCode.Nulik, new string[] { "vo" }, false);
		}

		/// <summary>
		/// The Oseacco dialect of Resian
		/// The Osojane dialect of Resian
		/// The dialect of Oseacco/Osojane is one of the four major local dialects of Resian
		/// added: 2007-07-05
		/// </summary>
		public static Variant Osojs => OsojsCache.Instance;

		private static class OsojsCache
		{
			public static readonly Variant Instance = new Variant("osojs", VariantCode.Osojs, new string[] { "sl-rozaj" }, false);
		}

		/// <summary>
		/// Oxford English Dictionary spelling
		/// added: 2015-04-17
		/// </summary>
		public static Variant Oxendict => OxendictCache.Instance;

		private static class OxendictCache
		{
			public static readonly Variant Instance = new Variant("oxendict", VariantCode.Oxendict, new string[] { "en" }, false);
		}

		/// <summary>
		/// Pahawh Hmong Second Stage Reduced orthography
		/// added: 2017-01-13
		/// </summary>
		public static Variant Pahawh2 => Pahawh2Cache.Instance;

		private static class Pahawh2Cache
		{
			public static readonly Variant Instance = new Variant("pahawh2", VariantCode.Pahawh2, new string[] { "mww", "hnj" }, false);
		}

		/// <summary>
		/// Pahawh Hmong Third Stage Reduced orthography
		/// added: 2017-01-13
		/// </summary>
		public static Variant Pahawh3 => Pahawh3Cache.Instance;

		private static class Pahawh3Cache
		{
			public static readonly Variant Instance = new Variant("pahawh3", VariantCode.Pahawh3, new string[] { "mww", "hnj" }, false);
		}

		/// <summary>
		/// Pahawh Hmong Final Version orthography
		/// added: 2017-01-13
		/// </summary>
		public static Variant Pahawh4 => Pahawh4Cache.Instance;

		private static class Pahawh4Cache
		{
			public static readonly Variant Instance = new Variant("pahawh4", VariantCode.Pahawh4, new string[] { "mww", "hnj" }, false);
		}

		/// <summary>
		/// Pamaka dialect
		/// Pamaka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// added: 2009-09-05
		/// </summary>
		public static Variant Pamaka => PamakaCache.Instance;

		private static class PamakaCache
		{
			public static readonly Variant Instance = new Variant("pamaka", VariantCode.Pamaka, new string[] { "djk" }, false);
		}

		/// <summary>
		/// Latino Sine Flexione
		/// Interlingua de API
		/// Interlingua de Peano
		/// Peano’s Interlingua, created in 1903 by Giuseppe Peano as an international auxiliary language
		/// added: 2020-03-12
		/// </summary>
		public static Variant Peano => PeanoCache.Instance;

		private static class PeanoCache
		{
			public static readonly Variant Instance = new Variant("peano", VariantCode.Peano, new string[] { "la" }, false);
		}

		/// <summary>
		/// Petrine orthography
		/// Russian orthography from the Petrine orthographic reforms of 1708 to the 1917 orthographic reform
		/// added: 2010-10-10
		/// </summary>
		public static Variant Petr1708 => Petr1708Cache.Instance;

		private static class Petr1708Cache
		{
			public static readonly Variant Instance = new Variant("petr1708", VariantCode.Petr1708, new string[] { "ru" }, false);
		}

		/// <summary>
		/// Pinyin romanization
		/// added: 2008-10-14
		/// </summary>
		public static Variant Pinyin => PinyinCache.Instance;

		private static class PinyinCache
		{
			public static readonly Variant Instance = new Variant("pinyin", VariantCode.Pinyin, new string[] { "zh-Latn", "bo-Latn" }, false);
		}

		/// <summary>
		/// Polytonic Greek
		/// added: 2006-12-11
		/// </summary>
		public static Variant Polyton => PolytonCache.Instance;

		private static class PolytonCache
		{
			public static readonly Variant Instance = new Variant("polyton", VariantCode.Polyton, new string[] { "el" }, false);
		}

		/// <summary>
		/// Provençal
		/// Occitan variant spoken in Provence
		/// added: 2018-04-22
		/// </summary>
		public static Variant Provenc => ProvencCache.Instance;

		private static class ProvencCache
		{
			public static readonly Variant Instance = new Variant("provenc", VariantCode.Provenc, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Puter idiom of Romansh
		/// Puter is one of the five traditional written standards or "idioms" of the Romansh language.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Puter => PuterCache.Instance;

		private static class PuterCache
		{
			public static readonly Variant Instance = new Variant("puter", VariantCode.Puter, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Volapük rigik
		/// Schleyer's Volapük
		/// Original Volapük
		/// Classic Volapük
		/// added: 2012-01-28
		/// </summary>
		public static Variant Rigik => RigikCache.Instance;

		private static class RigikCache
		{
			public static readonly Variant Instance = new Variant("rigik", VariantCode.Rigik, new string[] { "vo" }, false);
		}

		/// <summary>
		/// Resian
		/// Resianic
		/// Rezijan
		/// added: 2005-10-16
		/// </summary>
		public static Variant Rozaj => RozajCache.Instance;

		private static class RozajCache
		{
			public static readonly Variant Instance = new Variant("rozaj", VariantCode.Rozaj, new string[] { "sl" }, false);
		}

		/// <summary>
		/// Rumantsch Grischun
		/// Supraregional Romansh written standard
		/// added: 2010-06-29
		/// </summary>
		public static Variant Rumgr => RumgrCache.Instance;

		private static class RumgrCache
		{
			public static readonly Variant Instance = new Variant("rumgr", VariantCode.Rumgr, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Scottish Standard English
		/// added: 2007-08-31
		/// </summary>
		public static Variant Scotland => ScotlandCache.Instance;

		private static class ScotlandCache
		{
			public static readonly Variant Instance = new Variant("scotland", VariantCode.Scotland, new string[] { "en" }, false);
		}

		/// <summary>
		/// Scouse
		/// English Liverpudlian dialect known as 'Scouse'
		/// added: 2006-09-18
		/// </summary>
		public static Variant Scouse => ScouseCache.Instance;

		private static class ScouseCache
		{
			public static readonly Variant Instance = new Variant("scouse", VariantCode.Scouse, new string[] { "en" }, false);
		}

		/// <summary>
		/// Simplified form
		/// added: 2015-12-29
		/// </summary>
		public static Variant Simple => SimpleCache.Instance;

		private static class SimpleCache
		{
			public static readonly Variant Instance = new Variant("simple", VariantCode.Simple, new string[] {  }, false);
		}

		/// <summary>
		/// The Stolvizza dialect of Resian
		/// The Solbica dialect of Resian
		/// The dialect of Stolvizza/Solbica is one of the four major local dialects of Resian
		/// added: 2007-07-05
		/// </summary>
		public static Variant Solba => SolbaCache.Instance;

		private static class SolbaCache
		{
			public static readonly Variant Instance = new Variant("solba", VariantCode.Solba, new string[] { "sl-rozaj" }, false);
		}

		/// <summary>
		/// The Sotavento dialect group of Kabuverdianu
		/// Sotavento is one of the two main dialect groups of Kabuverdianu.
		/// added: 2013-12-10
		/// </summary>
		public static Variant Sotav => SotavCache.Instance;

		private static class SotavCache
		{
			public static readonly Variant Instance = new Variant("sotav", VariantCode.Sotav, new string[] { "kea" }, false);
		}

		/// <summary>
		/// Spanglish
		/// A variety of contact dialects of English and Spanish
		/// added: 2017-02-23
		/// </summary>
		public static Variant Spanglis => SpanglisCache.Instance;

		private static class SpanglisCache
		{
			public static readonly Variant Instance = new Variant("spanglis", VariantCode.Spanglis, new string[] { "en", "es" }, false);
		}

		/// <summary>
		/// Surmiran idiom of Romansh
		/// Surmiran is one of the five traditional written standards or "idioms" of the Romansh language.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Surmiran => SurmiranCache.Instance;

		private static class SurmiranCache
		{
			public static readonly Variant Instance = new Variant("surmiran", VariantCode.Surmiran, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Sursilvan idiom of Romansh
		/// Sursilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Sursilv => SursilvCache.Instance;

		private static class SursilvCache
		{
			public static readonly Variant Instance = new Variant("sursilv", VariantCode.Sursilv, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Sutsilvan idiom of Romansh
		/// Sutsilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Sutsilv => SutsilvCache.Instance;

		private static class SutsilvCache
		{
			public static readonly Variant Instance = new Variant("sutsilv", VariantCode.Sutsilv, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Belarusian in Taraskievica orthography
		/// The subtag represents Branislau Taraskievic's Belarusian orthography as published in "Bielaruski klasycny pravapis" by Juras Buslakou, Vincuk Viacorka, Zmicier Sanko, and Zmicier Sauka (Vilnia- Miensk 2005).
		/// added: 2007-04-27
		/// </summary>
		public static Variant Tarask => TaraskCache.Instance;

		private static class TaraskCache
		{
			public static readonly Variant Instance = new Variant("tarask", VariantCode.Tarask, new string[] { "be" }, false);
		}

		/// <summary>
		/// Tongyong Pinyin romanization
		/// Former official transcription standard for Mandarin Chinese in Taiwan.
		/// added: 2020-06-08
		/// </summary>
		public static Variant Tongyong => TongyongCache.Instance;

		private static class TongyongCache
		{
			public static readonly Variant Instance = new Variant("tongyong", VariantCode.Tongyong, new string[] { "zh-Latn" }, false);
		}

		/// <summary>
		/// Tunumiisiut
		/// East Greenlandic
		/// Østgrønlandsk
		/// Also known as Tunumiit oraasiat
		/// added: 2020-07-16
		/// </summary>
		public static Variant Tunumiit => TunumiitCache.Instance;

		private static class TunumiitCache
		{
			public static readonly Variant Instance = new Variant("tunumiit", VariantCode.Tunumiit, new string[] { "kl" }, false);
		}

		/// <summary>
		/// Unified Cornish orthography of Revived Cornish
		/// added: 2008-10-14
		/// </summary>
		public static Variant Uccor => UccorCache.Instance;

		private static class UccorCache
		{
			public static readonly Variant Instance = new Variant("uccor", VariantCode.Uccor, new string[] { "kw" }, false);
		}

		/// <summary>
		/// Unified Cornish Revised orthography of Revived Cornish
		/// added: 2008-10-14
		/// </summary>
		public static Variant Ucrcor => UcrcorCache.Instance;

		private static class UcrcorCache
		{
			public static readonly Variant Instance = new Variant("ucrcor", VariantCode.Ucrcor, new string[] { "kw" }, false);
		}

		/// <summary>
		/// Ulster dialect of Scots
		/// added: 2010-04-10
		/// </summary>
		public static Variant Ulster => UlsterCache.Instance;

		private static class UlsterCache
		{
			public static readonly Variant Instance = new Variant("ulster", VariantCode.Ulster, new string[] { "sco" }, false);
		}

		/// <summary>
		/// Unifon phonetic alphabet
		/// added: 2013-10-02
		/// </summary>
		public static Variant Unifon => UnifonCache.Instance;

		private static class UnifonCache
		{
			public static readonly Variant Instance = new Variant("unifon", VariantCode.Unifon, new string[] { "en", "hup", "kyh", "tol", "yur" }, false);
		}

		/// <summary>
		/// Vedic Sanskrit
		/// The most ancient dialect of Sanskrit used in verse and prose composed until about the 4th century B.C.E.
		/// added: 2010-07-28
		/// </summary>
		public static Variant Vaidika => VaidikaCache.Instance;

		private static class VaidikaCache
		{
			public static readonly Variant Instance = new Variant("vaidika", VariantCode.Vaidika, new string[] { "sa" }, false);
		}

		/// <summary>
		/// Valencian
		/// Variety spoken in the "Comunidad Valenciana" region of Spain, where it is co-official with Spanish.
		/// added: 2007-03-06
		/// </summary>
		public static Variant Valencia => ValenciaCache.Instance;

		private static class ValenciaCache
		{
			public static readonly Variant Instance = new Variant("valencia", VariantCode.Valencia, new string[] { "ca" }, false);
		}

		/// <summary>
		/// Vallader idiom of Romansh
		/// Vallader is one of the five traditional written standards or "idioms" of the Romansh language.
		/// added: 2010-06-29
		/// </summary>
		public static Variant Vallader => ValladerCache.Instance;

		private static class ValladerCache
		{
			public static readonly Variant Instance = new Variant("vallader", VariantCode.Vallader, new string[] { "rm" }, false);
		}

		/// <summary>
		/// Vivaro-Alpine
		/// Occitan variant spoken in northeastern Occitania
		/// added: 2018-04-22
		/// </summary>
		public static Variant Vivaraup => VivaraupCache.Instance;

		private static class VivaraupCache
		{
			public static readonly Variant Instance = new Variant("vivaraup", VariantCode.Vivaraup, new string[] { "oc" }, false);
		}

		/// <summary>
		/// Wade-Giles romanization
		/// added: 2008-10-03
		/// </summary>
		public static Variant Wadegile => WadegileCache.Instance;

		private static class WadegileCache
		{
			public static readonly Variant Instance = new Variant("wadegile", VariantCode.Wadegile, new string[] { "zh-Latn" }, false);
		}

		/// <summary>
		/// Standard X-system orthographic fallback for spelling Esperanto
		/// added: 2017-03-14
		/// </summary>
		public static Variant Xsistemo => XsistemoCache.Instance;

		private static class XsistemoCache
		{
			public static readonly Variant Instance = new Variant("xsistemo", VariantCode.Xsistemo, new string[] { "eo" }, false);
		}

	}
}
