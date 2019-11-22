using System;

namespace NLanguageTag
{
	/// <summary>
	/// Script subtags are used to indicate the script or writing system variations
	/// that distinguish the written forms of a language or its dialects
	/// </summary>
	public enum Script
	{
		/// <summary>
		/// Adlam
		/// </summary>
		Adlm,

		/// <summary>
		/// Afaka
		/// </summary>
		Afak,

		/// <summary>
		/// Caucasian Albanian
		/// </summary>
		Aghb,

		/// <summary>
		/// Ahom Tai Ahom
		/// </summary>
		Ahom,

		/// <summary>
		/// Arabic
		/// </summary>
		Arab,

		/// <summary>
		/// Arabic (Nastaliq variant)
		/// </summary>
		Aran,

		/// <summary>
		/// Imperial Aramaic
		/// </summary>
		Armi,

		/// <summary>
		/// Armenian
		/// </summary>
		Armn,

		/// <summary>
		/// Avestan
		/// </summary>
		Avst,

		/// <summary>
		/// Balinese
		/// </summary>
		Bali,

		/// <summary>
		/// Bamum
		/// </summary>
		Bamu,

		/// <summary>
		/// Bassa Vah
		/// </summary>
		Bass,

		/// <summary>
		/// Batak
		/// </summary>
		Batk,

		/// <summary>
		/// Bengali
		/// </summary>
		Beng,

		/// <summary>
		/// Bhaiksuki
		/// </summary>
		Bhks,

		/// <summary>
		/// Blissymbols
		/// </summary>
		Blis,

		/// <summary>
		/// Bopomofo
		/// </summary>
		Bopo,

		/// <summary>
		/// Brahmi
		/// </summary>
		Brah,

		/// <summary>
		/// Braille
		/// </summary>
		Brai,

		/// <summary>
		/// Buginese
		/// </summary>
		Bugi,

		/// <summary>
		/// Buhid
		/// </summary>
		Buhd,

		/// <summary>
		/// Chakma
		/// </summary>
		Cakm,

		/// <summary>
		/// Unified Canadian Aboriginal Syllabics
		/// </summary>
		Cans,

		/// <summary>
		/// Carian
		/// </summary>
		Cari,

		/// <summary>
		/// Cham
		/// </summary>
		Cham,

		/// <summary>
		/// Cherokee
		/// </summary>
		Cher,

		/// <summary>
		/// Cirth
		/// </summary>
		Cirt,

		/// <summary>
		/// Coptic
		/// </summary>
		Copt,

		/// <summary>
		/// Cypriot
		/// </summary>
		Cprt,

		/// <summary>
		/// Cyrillic
		/// </summary>
		Cyrl,

		/// <summary>
		/// Cyrillic (Old Church Slavonic variant)
		/// </summary>
		Cyrs,

		/// <summary>
		/// Devanagari Nagari
		/// </summary>
		Deva,

		/// <summary>
		/// Deseret Mormon
		/// </summary>
		Dsrt,

		/// <summary>
		/// Duployan shorthand Duployan stenography
		/// </summary>
		Dupl,

		/// <summary>
		/// Egyptian demotic
		/// </summary>
		Egyd,

		/// <summary>
		/// Egyptian hieratic
		/// </summary>
		Egyh,

		/// <summary>
		/// Egyptian hieroglyphs
		/// </summary>
		Egyp,

		/// <summary>
		/// Elbasan
		/// </summary>
		Elba,

		/// <summary>
		/// Ethiopic Geʻez Ge'ez
		/// </summary>
		Ethi,

		/// <summary>
		/// Khutsuri (Asomtavruli and Nuskhuri)
		/// </summary>
		Geok,

		/// <summary>
		/// Georgian (Mkhedruli)
		/// </summary>
		Geor,

		/// <summary>
		/// Glagolitic
		/// </summary>
		Glag,

		/// <summary>
		/// Gothic
		/// </summary>
		Goth,

		/// <summary>
		/// Grantha
		/// </summary>
		Gran,

		/// <summary>
		/// Greek
		/// </summary>
		Grek,

		/// <summary>
		/// Gujarati
		/// </summary>
		Gujr,

		/// <summary>
		/// Gurmukhi
		/// </summary>
		Guru,

		/// <summary>
		/// Han with Bopomofo (alias for Han + Bopomofo)
		/// </summary>
		Hanb,

		/// <summary>
		/// Hangul Hangŭl Hangeul
		/// </summary>
		Hang,

		/// <summary>
		/// Han Hanzi Kanji Hanja
		/// </summary>
		Hani,

		/// <summary>
		/// Hanunoo Hanunóo
		/// </summary>
		Hano,

		/// <summary>
		/// Han (Simplified variant)
		/// </summary>
		Hans,

		/// <summary>
		/// Han (Traditional variant)
		/// </summary>
		Hant,

		/// <summary>
		/// Hatran
		/// </summary>
		Hatr,

		/// <summary>
		/// Hebrew
		/// </summary>
		Hebr,

		/// <summary>
		/// Hiragana
		/// </summary>
		Hira,

		/// <summary>
		/// Anatolian Hieroglyphs Luwian Hieroglyphs Hittite Hieroglyphs
		/// </summary>
		Hluw,

		/// <summary>
		/// Pahawh Hmong
		/// </summary>
		Hmng,

		/// <summary>
		/// Japanese syllabaries (alias for Hiragana + Katakana)
		/// </summary>
		Hrkt,

		/// <summary>
		/// Old Hungarian Hungarian Runic
		/// </summary>
		Hung,

		/// <summary>
		/// Indus Harappan
		/// </summary>
		Inds,

		/// <summary>
		/// Old Italic (Etruscan, Oscan, etc.)
		/// </summary>
		Ital,

		/// <summary>
		/// Jamo (alias for Jamo subset of Hangul)
		/// </summary>
		Jamo,

		/// <summary>
		/// Javanese
		/// </summary>
		Java,

		/// <summary>
		/// Japanese (alias for Han + Hiragana + Katakana)
		/// </summary>
		Jpan,

		/// <summary>
		/// Jurchen
		/// </summary>
		Jurc,

		/// <summary>
		/// Kayah Li
		/// </summary>
		Kali,

		/// <summary>
		/// Katakana
		/// </summary>
		Kana,

		/// <summary>
		/// Kharoshthi
		/// </summary>
		Khar,

		/// <summary>
		/// Khmer
		/// </summary>
		Khmr,

		/// <summary>
		/// Khojki
		/// </summary>
		Khoj,

		/// <summary>
		/// Khitan large script
		/// </summary>
		Kitl,

		/// <summary>
		/// Khitan small script
		/// </summary>
		Kits,

		/// <summary>
		/// Kannada
		/// </summary>
		Knda,

		/// <summary>
		/// Korean (alias for Hangul + Han)
		/// </summary>
		Kore,

		/// <summary>
		/// Kpelle
		/// </summary>
		Kpel,

		/// <summary>
		/// Kaithi
		/// </summary>
		Kthi,

		/// <summary>
		/// Tai Tham Lanna
		/// </summary>
		Lana,

		/// <summary>
		/// Lao
		/// </summary>
		Laoo,

		/// <summary>
		/// Latin (Fraktur variant)
		/// </summary>
		Latf,

		/// <summary>
		/// Latin (Gaelic variant)
		/// </summary>
		Latg,

		/// <summary>
		/// Latin
		/// </summary>
		Latn,

		/// <summary>
		/// Leke
		/// </summary>
		Leke,

		/// <summary>
		/// Lepcha Róng
		/// </summary>
		Lepc,

		/// <summary>
		/// Limbu
		/// </summary>
		Limb,

		/// <summary>
		/// Linear A
		/// </summary>
		Lina,

		/// <summary>
		/// Linear B
		/// </summary>
		Linb,

		/// <summary>
		/// Lisu Fraser
		/// </summary>
		Lisu,

		/// <summary>
		/// Loma
		/// </summary>
		Loma,

		/// <summary>
		/// Lycian
		/// </summary>
		Lyci,

		/// <summary>
		/// Lydian
		/// </summary>
		Lydi,

		/// <summary>
		/// Mahajani
		/// </summary>
		Mahj,

		/// <summary>
		/// Mandaic Mandaean
		/// </summary>
		Mand,

		/// <summary>
		/// Manichaean
		/// </summary>
		Mani,

		/// <summary>
		/// Marchen
		/// </summary>
		Marc,

		/// <summary>
		/// Mayan hieroglyphs
		/// </summary>
		Maya,

		/// <summary>
		/// Mende Kikakui
		/// </summary>
		Mend,

		/// <summary>
		/// Meroitic Cursive
		/// </summary>
		Merc,

		/// <summary>
		/// Meroitic Hieroglyphs
		/// </summary>
		Mero,

		/// <summary>
		/// Malayalam
		/// </summary>
		Mlym,

		/// <summary>
		/// Modi Moḍī
		/// </summary>
		Modi,

		/// <summary>
		/// Mongolian
		/// </summary>
		Mong,

		/// <summary>
		/// Moon Moon code Moon script Moon type
		/// </summary>
		Moon,

		/// <summary>
		/// Mro Mru
		/// </summary>
		Mroo,

		/// <summary>
		/// Meitei Mayek Meithei Meetei
		/// </summary>
		Mtei,

		/// <summary>
		/// Multani
		/// </summary>
		Mult,

		/// <summary>
		/// Myanmar Burmese
		/// </summary>
		Mymr,

		/// <summary>
		/// Old North Arabian Ancient North Arabian
		/// </summary>
		Narb,

		/// <summary>
		/// Nabataean
		/// </summary>
		Nbat,

		/// <summary>
		/// Newa Newar Newari Nepāla lipi
		/// </summary>
		Newa,

		/// <summary>
		/// Nakhi Geba 'Na-'Khi ²Ggŏ-¹baw Naxi Geba
		/// </summary>
		Nkgb,

		/// <summary>
		/// N’Ko N'Ko
		/// </summary>
		Nkoo,

		/// <summary>
		/// Nüshu
		/// </summary>
		Nshu,

		/// <summary>
		/// Ogham
		/// </summary>
		Ogam,

		/// <summary>
		/// Ol Chiki Ol Cemet' Ol Santali
		/// </summary>
		Olck,

		/// <summary>
		/// Old Turkic Orkhon Runic
		/// </summary>
		Orkh,

		/// <summary>
		/// Oriya
		/// </summary>
		Orya,

		/// <summary>
		/// Osage
		/// </summary>
		Osge,

		/// <summary>
		/// Osmanya
		/// </summary>
		Osma,

		/// <summary>
		/// Palmyrene
		/// </summary>
		Palm,

		/// <summary>
		/// Pau Cin Hau
		/// </summary>
		Pauc,

		/// <summary>
		/// Old Permic
		/// </summary>
		Perm,

		/// <summary>
		/// Phags-pa
		/// </summary>
		Phag,

		/// <summary>
		/// Inscriptional Pahlavi
		/// </summary>
		Phli,

		/// <summary>
		/// Psalter Pahlavi
		/// </summary>
		Phlp,

		/// <summary>
		/// Book Pahlavi
		/// </summary>
		Phlv,

		/// <summary>
		/// Phoenician
		/// </summary>
		Phnx,

		/// <summary>
		/// Klingon (KLI pIqaD)
		/// </summary>
		Piqd,

		/// <summary>
		/// Miao Pollard
		/// </summary>
		Plrd,

		/// <summary>
		/// Inscriptional Parthian
		/// </summary>
		Prti,

		/// <summary>
		/// Rejang Redjang Kaganga
		/// </summary>
		Rjng,

		/// <summary>
		/// Rongorongo
		/// </summary>
		Roro,

		/// <summary>
		/// Runic
		/// </summary>
		Runr,

		/// <summary>
		/// Samaritan
		/// </summary>
		Samr,

		/// <summary>
		/// Sarati
		/// </summary>
		Sara,

		/// <summary>
		/// Old South Arabian
		/// </summary>
		Sarb,

		/// <summary>
		/// Saurashtra
		/// </summary>
		Saur,

		/// <summary>
		/// SignWriting
		/// </summary>
		Sgnw,

		/// <summary>
		/// Shavian Shaw
		/// </summary>
		Shaw,

		/// <summary>
		/// Sharada Śāradā
		/// </summary>
		Shrd,

		/// <summary>
		/// Siddham Siddhaṃ Siddhamātṛkā
		/// </summary>
		Sidd,

		/// <summary>
		/// Khudawadi Sindhi
		/// </summary>
		Sind,

		/// <summary>
		/// Sinhala
		/// </summary>
		Sinh,

		/// <summary>
		/// Sora Sompeng
		/// </summary>
		Sora,

		/// <summary>
		/// Sundanese
		/// </summary>
		Sund,

		/// <summary>
		/// Syloti Nagri
		/// </summary>
		Sylo,

		/// <summary>
		/// Syriac
		/// </summary>
		Syrc,

		/// <summary>
		/// Syriac (Estrangelo variant)
		/// </summary>
		Syre,

		/// <summary>
		/// Syriac (Western variant)
		/// </summary>
		Syrj,

		/// <summary>
		/// Syriac (Eastern variant)
		/// </summary>
		Syrn,

		/// <summary>
		/// Tagbanwa
		/// </summary>
		Tagb,

		/// <summary>
		/// Takri Ṭākrī Ṭāṅkrī
		/// </summary>
		Takr,

		/// <summary>
		/// Tai Le
		/// </summary>
		Tale,

		/// <summary>
		/// New Tai Lue
		/// </summary>
		Talu,

		/// <summary>
		/// Tamil
		/// </summary>
		Taml,

		/// <summary>
		/// Tangut
		/// </summary>
		Tang,

		/// <summary>
		/// Tai Viet
		/// </summary>
		Tavt,

		/// <summary>
		/// Telugu
		/// </summary>
		Telu,

		/// <summary>
		/// Tengwar
		/// </summary>
		Teng,

		/// <summary>
		/// Tifinagh Berber
		/// </summary>
		Tfng,

		/// <summary>
		/// Tagalog Baybayin Alibata
		/// </summary>
		Tglg,

		/// <summary>
		/// Thaana
		/// </summary>
		Thaa,

		/// <summary>
		/// Thai
		/// </summary>
		Thai,

		/// <summary>
		/// Tibetan
		/// </summary>
		Tibt,

		/// <summary>
		/// Tirhuta
		/// </summary>
		Tirh,

		/// <summary>
		/// Ugaritic
		/// </summary>
		Ugar,

		/// <summary>
		/// Vai
		/// </summary>
		Vaii,

		/// <summary>
		/// Visible Speech
		/// </summary>
		Visp,

		/// <summary>
		/// Warang Citi Varang Kshiti
		/// </summary>
		Wara,

		/// <summary>
		/// Woleai
		/// </summary>
		Wole,

		/// <summary>
		/// Old Persian
		/// </summary>
		Xpeo,

		/// <summary>
		/// Sumero-Akkadian cuneiform
		/// </summary>
		Xsux,

		/// <summary>
		/// Yi
		/// </summary>
		Yiii,

		/// <summary>
		/// Code for inherited script
		/// Not intended for use as a language subtag
		/// </summary>
		Zinh,

		/// <summary>
		/// Mathematical notation
		/// </summary>
		Zmth,

		/// <summary>
		/// Symbols (Emoji variant)
		/// </summary>
		Zsye,

		/// <summary>
		/// Symbols
		/// </summary>
		Zsym,

		/// <summary>
		/// Code for unwritten documents
		/// </summary>
		Zxxx,

		/// <summary>
		/// Code for undetermined script
		/// </summary>
		Zyyy,

		/// <summary>
		/// Code for uncoded script
		/// </summary>
		Zzzz,

	}
}
