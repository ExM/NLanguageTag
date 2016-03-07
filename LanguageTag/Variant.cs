using System;

namespace AbbyyLS.Globalization.Bcp47
{
	/// <summary>
	/// Variant subtags are used to indicate additional, well-recognized variations that define a
	/// language or its dialects that are not covered by other available subtags.
	/// </summary>
	public enum Variant
	{
		/// <summary>
		/// Late Middle French (to 1606)
		/// 16th century French as in Jean Nicot, "Thresor de la langue francoyse", 1606, but also including some French similar to that of Rabelais
		/// </summary>
		V1606nict,

		/// <summary>
		/// Early Modern French
		/// 17th century French, as catalogued in the "Dictionnaire de l'académie françoise", 4eme ed. 1694; frequently includes elements of Middle French, as this is a transitional period
		/// </summary>
		V1694acad,

		/// <summary>
		/// Traditional German orthography
		/// </summary>
		V1901,

		/// <summary>
		/// "Academic" ("governmental") variant of Belarusian as codified in 1959
		/// </summary>
		V1959acad,

		/// <summary>
		/// Standardized Resian orthography
		/// For standardized Resian an orthography was published in 1994.
		/// </summary>
		V1994,

		/// <summary>
		/// German orthography of 1996
		/// </summary>
		V1996,

		/// <summary>
		/// Orthographic formulation of 1943 - Official in Brazil (Formulário Ortográfico de 1943 - Oficial no Brasil)
		/// Denotes conventions established by the Academia Brasileira de Letras in 1943 and generally used in Brazil until 2009
		/// </summary>
		Abl1943,

		/// <summary>
		/// ALA-LC Romanization, 1997 edition
		/// Romanizations recommended by the American Library Association and the Library of Congress, in "ALA-LC Romanization Tables: Transliteration Schemes for Non-Roman Scripts" (1997), ISBN 978-0-8444-0940-5.
		/// </summary>
		Alalc97,

		/// <summary>
		/// Aluku dialect Boni dialect
		/// Aluku dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Aluku,

		/// <summary>
		/// Portuguese Language Orthographic Agreement of 1990 (Acordo Ortográfico da Língua Portuguesa de 1990)
		/// Portuguese orthography conventions established in 1990 but not brought into effect until 2009
		/// </summary>
		Ao1990,

		/// <summary>
		/// Eastern Armenian
		/// </summary>
		Arevela,

		/// <summary>
		/// Western Armenian
		/// </summary>
		Arevmda,

		/// <summary>
		/// Unified Turkic Latin Alphabet (Historical)
		/// Denotes alphabet used in Turkic republics/regions of the former USSR in late 1920s, and throughout 1930s, which aspired to represent equivalent phonemes in a unified fashion. Also known as: New Turkic Alphabet; Birlәşdirilmiş Jeni Tyrk Әlifbasь (Birlesdirilmis Jeni Tyrk Elifbasi); Jaŋalif (Janalif).
		/// </summary>
		Baku1926,

		/// <summary>
		/// The Balanka dialect of Anii
		/// Balanka is one of 19 Anii dialects.
		/// </summary>
		Balanka,

		/// <summary>
		/// The Barlavento dialect group of Kabuverdianu
		/// Barlavento is one of the two main dialect groups of Kabuverdianu.
		/// </summary>
		Barla,

		/// <summary>
		/// Basic English
		/// </summary>
		Basiceng,

		/// <summary>
		/// Buddhist Hybrid Sanskrit
		/// </summary>
		Bauddha,

		/// <summary>
		/// Biscayan dialect of Basque
		/// </summary>
		Biscayan,

		/// <summary>
		/// The San Giorgio dialect of Resian The Bila dialect of Resian
		/// The dialect of San Giorgio/Bila is one of the four major local dialects of Resian
		/// </summary>
		Biske,

		/// <summary>
		/// Slovene in Bohorič alphabet
		/// The subtag represents the alphabet codified by Adam Bohorič in 1584 and used from the first printed Slovene book and up to the mid-19th century.
		/// </summary>
		Bohoric,

		/// <summary>
		/// Boontling
		/// Jargon embedded in American English
		/// </summary>
		Boont,

		/// <summary>
		/// Portuguese-Brazilian Orthographic Convention of 1945 (Convenção Ortográfica Luso-Brasileira de 1945)
		/// Portuguese orthography conventions established in 1945, generally in effect until 2009. This reform was not ratified in Brazil.
		/// </summary>
		Colb1945,

		/// <summary>
		/// Cornu-English Cornish English Anglo-Cornish
		/// </summary>
		Cornu,

		/// <summary>
		/// Slovene in Dajnko alphabet
		/// The subtag represents the alphabet codified by Peter Dajnko and used from 1824 to 1839 mostly in Styria (in what is now Eastern Slovenia).
		/// </summary>
		Dajnko,

		/// <summary>
		/// Serbian with Ekavian pronunciation
		/// </summary>
		Ekavsk,

		/// <summary>
		/// Early Modern English (1500-1700)
		/// </summary>
		Emodeng,

		/// <summary>
		/// International Phonetic Alphabet
		/// </summary>
		Fonipa,

		/// <summary>
		/// Uralic Phonetic Alphabet
		/// </summary>
		Fonupa,

		/// <summary>
		/// X-SAMPA transcription
		/// Indicates that the content is transcribed according to X-SAMPA
		/// </summary>
		Fonxsamp,

		/// <summary>
		/// Hepburn romanization
		/// </summary>
		Hepburn,

		/// <summary>
		/// Norwegian in Høgnorsk (High Norwegian) orthography
		/// Norwegian following Ivar Aasen's orthographical principles, including modern usage.
		/// </summary>
		Hognorsk,

		/// <summary>
		/// Serbian with Ijekavian pronunciation
		/// </summary>
		Ijekavsk,

		/// <summary>
		/// Epic Sanskrit
		/// </summary>
		Itihasa,

		/// <summary>
		/// Jauer dialect of Romansh
		/// The spoken dialect of the Val Müstair, which has no written standard.
		/// </summary>
		Jauer,

		/// <summary>
		/// Jyutping Cantonese Romanization
		/// Jyutping romanization of Cantonese
		/// </summary>
		Jyutping,

		/// <summary>
		/// Common Cornish orthography of Revived Cornish
		/// </summary>
		Kkcor,

		/// <summary>
		/// The Kociewie dialect of Polish
		/// The dialect of Kociewie is spoken in the region around Starogard Gdański, Tczew and Świecie in northern Poland.
		/// </summary>
		Kociewie,

		/// <summary>
		/// Standard Cornish orthography of Revived Cornish Kernowek Standard
		/// </summary>
		Kscor,

		/// <summary>
		/// Classical Sanskrit
		/// </summary>
		Laukika,

		/// <summary>
		/// The Lipovaz dialect of Resian The Lipovec dialect of Resian
		/// The dialect of Lipovaz/Lipovec is one of the minor local dialects of Resian
		/// </summary>
		Lipaw,

		/// <summary>
		/// Post-1917 Russian orthography
		/// Russian orthography as established by the 1917/1918 orthographic reforms
		/// </summary>
		Luna1918,

		/// <summary>
		/// Slovene in Metelko alphabet
		/// The subtag represents the alphabet codified by Franc Serafin Metelko and used from 1825 to 1833.
		/// </summary>
		Metelko,

		/// <summary>
		/// Monotonic Greek
		/// </summary>
		Monoton,

		/// <summary>
		/// Ndyuka dialect Aukan dialect
		/// Ndyuka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Ndyuka,

		/// <summary>
		/// Natisone dialect Nadiza dialect
		/// </summary>
		Nedis,

		/// <summary>
		/// Newfoundland English
		/// </summary>
		Newfound,

		/// <summary>
		/// The Gniva dialect of Resian The Njiva dialect of Resian
		/// The dialect of Gniva/Njiva is one of the four major local dialects of Resian
		/// </summary>
		Njiva,

		/// <summary>
		/// Volapük nulik Volapük perevidöl Volapük nulädik de Jong's Volapük New Volapük Revised Volapük Modern Volapük
		/// </summary>
		Nulik,

		/// <summary>
		/// The Oseacco dialect of Resian The Osojane dialect of Resian
		/// The dialect of Oseacco/Osojane is one of the four major local dialects of Resian
		/// </summary>
		Osojs,

		/// <summary>
		/// Oxford English Dictionary spelling
		/// </summary>
		Oxendict,

		/// <summary>
		/// Pamaka dialect
		/// Pamaka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Pamaka,

		/// <summary>
		/// Petrine orthography
		/// Russian orthography from the Petrine orthographic reforms of 1708 to the 1917 orthographic reform
		/// </summary>
		Petr1708,

		/// <summary>
		/// Pinyin romanization
		/// </summary>
		Pinyin,

		/// <summary>
		/// Polytonic Greek
		/// </summary>
		Polyton,

		/// <summary>
		/// Puter idiom of Romansh
		/// Puter is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Puter,

		/// <summary>
		/// Volapük rigik Schleyer's Volapük Original Volapük Classic Volapük
		/// </summary>
		Rigik,

		/// <summary>
		/// Resian Resianic Rezijan
		/// </summary>
		Rozaj,

		/// <summary>
		/// Rumantsch Grischun
		/// Supraregional Romansh written standard
		/// </summary>
		Rumgr,

		/// <summary>
		/// Scottish Standard English
		/// </summary>
		Scotland,

		/// <summary>
		/// Scouse
		/// English Liverpudlian dialect known as 'Scouse'
		/// </summary>
		Scouse,

		/// <summary>
		/// Simplified form
		/// </summary>
		Simple,

		/// <summary>
		/// The Stolvizza dialect of Resian The Solbica dialect of Resian
		/// The dialect of Stolvizza/Solbica is one of the four major local dialects of Resian
		/// </summary>
		Solba,

		/// <summary>
		/// The Sotavento dialect group of Kabuverdianu
		/// Sotavento is one of the two main dialect groups of Kabuverdianu.
		/// </summary>
		Sotav,

		/// <summary>
		/// Surmiran idiom of Romansh
		/// Surmiran is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Surmiran,

		/// <summary>
		/// Sursilvan idiom of Romansh
		/// Sursilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Sursilv,

		/// <summary>
		/// Sutsilvan idiom of Romansh
		/// Sutsilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Sutsilv,

		/// <summary>
		/// Belarusian in Taraskievica orthography
		/// The subtag represents Branislau Taraskievic's Belarusian orthography as published in "Bielaruski klasycny pravapis" by Juras Buslakou, Vincuk Viacorka, Zmicier Sanko, and Zmicier Sauka (Vilnia- Miensk 2005).
		/// </summary>
		Tarask,

		/// <summary>
		/// Unified Cornish orthography of Revived Cornish
		/// </summary>
		Uccor,

		/// <summary>
		/// Unified Cornish Revised orthography of Revived Cornish
		/// </summary>
		Ucrcor,

		/// <summary>
		/// Ulster dialect of Scots
		/// </summary>
		Ulster,

		/// <summary>
		/// Unifon phonetic alphabet
		/// </summary>
		Unifon,

		/// <summary>
		/// Vedic Sanskrit
		/// The most ancient dialect of Sanskrit used in verse and prose composed until about the 4th century B.C.E.
		/// </summary>
		Vaidika,

		/// <summary>
		/// Valencian
		/// Variety spoken in the "Comunidad Valenciana" region of Spain, where it is co-official with Spanish.
		/// </summary>
		Valencia,

		/// <summary>
		/// Vallader idiom of Romansh
		/// Vallader is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Vallader,

		/// <summary>
		/// Wade-Giles romanization
		/// </summary>
		Wadegile,

	}
}
