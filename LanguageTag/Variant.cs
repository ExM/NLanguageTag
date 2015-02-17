using System;

namespace AbbyyLS.Globalization
{
	public enum Variant
	{
		/// <summary>
		/// Late Middle French (to 1606)
		/// 16th century French as in Jean Nicot, "Thresor de la langue francoyse", 1606, but also including some French similar to that of Rabelais
		/// </summary>
		V1606nict = 0,

		/// <summary>
		/// Early Modern French
		/// 17th century French, as catalogued in the "Dictionnaire de l'académie françoise", 4eme ed. 1694; frequently includes elements of Middle French, as this is a transitional period
		/// </summary>
		V1694acad = 1,

		/// <summary>
		/// Traditional German orthography
		/// </summary>
		V1901 = 2,

		/// <summary>
		/// "Academic" ("governmental") variant of Belarusian as codified in 1959
		/// </summary>
		V1959acad = 3,

		/// <summary>
		/// Standardized Resian orthography
		/// For standardized Resian an orthography was published in 1994.
		/// </summary>
		V1994 = 4,

		/// <summary>
		/// German orthography of 1996
		/// </summary>
		V1996 = 5,

		/// <summary>
		/// ALA-LC Romanization, 1997 edition
		/// Romanizations recommended by the American Library Association and the Library of Congress, in "ALA-LC Romanization Tables: Transliteration Schemes for Non-Roman Scripts" (1997), ISBN 978-0-8444-0940-5.
		/// </summary>
		Alalc97 = 6,

		/// <summary>
		/// Aluku dialect Boni dialect
		/// Aluku dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Aluku = 7,

		/// <summary>
		/// Eastern Armenian
		/// </summary>
		Arevela = 8,

		/// <summary>
		/// Western Armenian
		/// </summary>
		Arevmda = 9,

		/// <summary>
		/// Unified Turkic Latin Alphabet (Historical)
		/// Denotes alphabet used in Turkic republics/regions of the former USSR in late 1920s, and throughout 1930s, which aspired to represent equivalent phonemes in a unified fashion. Also known as: New Turkic Alphabet; Birlәşdirilmiş Jeni Tyrk Әlifbasь (Birlesdirilmis Jeni Tyrk Elifbasi); Jaŋalif (Janalif).
		/// </summary>
		Baku1926 = 10,

		/// <summary>
		/// The Balanka dialect of Anii
		/// Balanka is one of 19 Anii dialects.
		/// </summary>
		Balanka = 11,

		/// <summary>
		/// The Barlavento dialect group of Kabuverdianu
		/// Barlavento is one of the two main dialect groups of Kabuverdianu.
		/// </summary>
		Barla = 12,

		/// <summary>
		/// Buddhist Hybrid Sanskrit
		/// </summary>
		Bauddha = 13,

		/// <summary>
		/// Biscayan dialect of Basque
		/// </summary>
		Biscayan = 14,

		/// <summary>
		/// The San Giorgio dialect of Resian The Bila dialect of Resian
		/// The dialect of San Giorgio/Bila is one of the four major local dialects of Resian
		/// </summary>
		Biske = 15,

		/// <summary>
		/// Slovene in Bohorič alphabet
		/// The subtag represents the alphabet codified by Adam Bohorič in 1584 and used from the first printed Slovene book and up to the mid-19th century.
		/// </summary>
		Bohoric = 16,

		/// <summary>
		/// Boontling
		/// Jargon embedded in American English
		/// </summary>
		Boont = 17,

		/// <summary>
		/// Slovene in Dajnko alphabet
		/// The subtag represents the alphabet codified by Peter Dajnko and used from 1824 to 1839 mostly in Styria (in what is now Eastern Slovenia).
		/// </summary>
		Dajnko = 18,

		/// <summary>
		/// Serbian with Ekavian pronunciation
		/// </summary>
		Ekavsk = 19,

		/// <summary>
		/// Early Modern English (1500-1700)
		/// </summary>
		Emodeng = 20,

		/// <summary>
		/// International Phonetic Alphabet
		/// </summary>
		Fonipa = 21,

		/// <summary>
		/// Uralic Phonetic Alphabet
		/// </summary>
		Fonupa = 22,

		/// <summary>
		/// X-SAMPA transcription
		/// Indicates that the content is transcribed according to X-SAMPA
		/// </summary>
		Fonxsamp = 23,

		/// <summary>
		/// Hepburn romanization
		/// </summary>
		Hepburn = 24,

		/// <summary>
		/// Norwegian in Høgnorsk (High Norwegian) orthography
		/// Norwegian following Ivar Aasen's orthographical principles, including modern usage.
		/// </summary>
		Hognorsk = 25,

		/// <summary>
		/// Serbian with Ijekavian pronunciation
		/// </summary>
		Ijekavsk = 26,

		/// <summary>
		/// Epic Sanskrit
		/// </summary>
		Itihasa = 27,

		/// <summary>
		/// Jauer dialect of Romansh
		/// The spoken dialect of the Val Müstair, which has no written standard.
		/// </summary>
		Jauer = 28,

		/// <summary>
		/// Jyutping Cantonese Romanization
		/// Jyutping romanization of Cantonese
		/// </summary>
		Jyutping = 29,

		/// <summary>
		/// Common Cornish orthography of Revived Cornish
		/// </summary>
		Kkcor = 30,

		/// <summary>
		/// The Kociewie dialect of Polish
		/// The dialect of Kociewie is spoken in the region around Starogard Gdański, Tczew and Świecie in northern Poland.
		/// </summary>
		Kociewie = 31,

		/// <summary>
		/// Standard Cornish orthography of Revived Cornish Kernowek Standard
		/// </summary>
		Kscor = 32,

		/// <summary>
		/// Classical Sanskrit
		/// </summary>
		Laukika = 33,

		/// <summary>
		/// The Lipovaz dialect of Resian The Lipovec dialect of Resian
		/// The dialect of Lipovaz/Lipovec is one of the minor local dialects of Resian
		/// </summary>
		Lipaw = 34,

		/// <summary>
		/// Post-1917 Russian orthography
		/// Russian orthography as established by the 1917/1918 orthographic reforms
		/// </summary>
		Luna1918 = 35,

		/// <summary>
		/// Slovene in Metelko alphabet
		/// The subtag represents the alphabet codified by Franc Serafin Metelko and used from 1825 to 1833.
		/// </summary>
		Metelko = 36,

		/// <summary>
		/// Monotonic Greek
		/// </summary>
		Monoton = 37,

		/// <summary>
		/// Ndyuka dialect Aukan dialect
		/// Ndyuka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Ndyuka = 38,

		/// <summary>
		/// Natisone dialect Nadiza dialect
		/// </summary>
		Nedis = 39,

		/// <summary>
		/// The Gniva dialect of Resian The Njiva dialect of Resian
		/// The dialect of Gniva/Njiva is one of the four major local dialects of Resian
		/// </summary>
		Njiva = 40,

		/// <summary>
		/// Volapük nulik Volapük perevidöl Volapük nulädik de Jong's Volapük New Volapük Revised Volapük Modern Volapük
		/// </summary>
		Nulik = 41,

		/// <summary>
		/// The Oseacco dialect of Resian The Osojane dialect of Resian
		/// The dialect of Oseacco/Osojane is one of the four major local dialects of Resian
		/// </summary>
		Osojs = 42,

		/// <summary>
		/// Pamaka dialect
		/// Pamaka dialect of the "Busi Nenge Tongo" English-based Creole continuum in Eastern Suriname and Western French Guiana
		/// </summary>
		Pamaka = 43,

		/// <summary>
		/// Petrine orthography
		/// Russian orthography from the Petrine orthographic reforms of 1708 to the 1917 orthographic reform
		/// </summary>
		Petr1708 = 44,

		/// <summary>
		/// Pinyin romanization
		/// </summary>
		Pinyin = 45,

		/// <summary>
		/// Polytonic Greek
		/// </summary>
		Polyton = 46,

		/// <summary>
		/// Puter idiom of Romansh
		/// Puter is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Puter = 47,

		/// <summary>
		/// Volapük rigik Schleyer's Volapük Original Volapük Classic Volapük
		/// </summary>
		Rigik = 48,

		/// <summary>
		/// Resian Resianic Rezijan
		/// </summary>
		Rozaj = 49,

		/// <summary>
		/// Rumantsch Grischun
		/// Supraregional Romansh written standard
		/// </summary>
		Rumgr = 50,

		/// <summary>
		/// Scottish Standard English
		/// </summary>
		Scotland = 51,

		/// <summary>
		/// Scouse
		/// English Liverpudlian dialect known as 'Scouse'
		/// </summary>
		Scouse = 52,

		/// <summary>
		/// The Stolvizza dialect of Resian The Solbica dialect of Resian
		/// The dialect of Stolvizza/Solbica is one of the four major local dialects of Resian
		/// </summary>
		Solba = 53,

		/// <summary>
		/// The Sotavento dialect group of Kabuverdianu
		/// Sotavento is one of the two main dialect groups of Kabuverdianu.
		/// </summary>
		Sotav = 54,

		/// <summary>
		/// Surmiran idiom of Romansh
		/// Surmiran is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Surmiran = 55,

		/// <summary>
		/// Sursilvan idiom of Romansh
		/// Sursilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Sursilv = 56,

		/// <summary>
		/// Sutsilvan idiom of Romansh
		/// Sutsilvan is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Sutsilv = 57,

		/// <summary>
		/// Belarusian in Taraskievica orthography
		/// The subtag represents Branislau Taraskievic's Belarusian orthography as published in "Bielaruski klasycny pravapis" by Juras Buslakou, Vincuk Viacorka, Zmicier Sanko, and Zmicier Sauka (Vilnia- Miensk 2005).
		/// </summary>
		Tarask = 58,

		/// <summary>
		/// Unified Cornish orthography of Revived Cornish
		/// </summary>
		Uccor = 59,

		/// <summary>
		/// Unified Cornish Revised orthography of Revived Cornish
		/// </summary>
		Ucrcor = 60,

		/// <summary>
		/// Ulster dialect of Scots
		/// </summary>
		Ulster = 61,

		/// <summary>
		/// Unifon phonetic alphabet
		/// </summary>
		Unifon = 62,

		/// <summary>
		/// Vedic Sanskrit
		/// The most ancient dialect of Sanskrit used in verse and prose composed until about the 4th century B.C.E.
		/// </summary>
		Vaidika = 63,

		/// <summary>
		/// Valencian
		/// Variety spoken in the "Comunidad Valenciana" region of Spain, where it is co-official with Spanish.
		/// </summary>
		Valencia = 64,

		/// <summary>
		/// Vallader idiom of Romansh
		/// Vallader is one of the five traditional written standards or "idioms" of the Romansh language.
		/// </summary>
		Vallader = 65,

		/// <summary>
		/// Wade-Giles romanization
		/// </summary>
		Wadegile = 66,

	}
}
