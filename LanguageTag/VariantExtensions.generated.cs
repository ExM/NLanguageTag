using System;
using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	public static partial class LanguageTagExtensions
	{
		private static string[] GetTextPrefixes(this Variant v)
		{
			switch(v)
			{
				case Variant.V1606nict: return new string[] { "frm" };
				case Variant.V1694acad: return new string[] { "fr" };
				case Variant.V1901: return new string[] { "de" };
				case Variant.V1959acad: return new string[] { "be" };
				case Variant.V1994: return new string[] { "sl-rozaj", "sl-rozaj-biske", "sl-rozaj-njiva", "sl-rozaj-osojs", "sl-rozaj-solba" };
				case Variant.V1996: return new string[] { "de" };
				case Variant.Alalc97: return new string[] {  };
				case Variant.Aluku: return new string[] { "djk" };
				case Variant.Arevela: return new string[] { "hy" };
				case Variant.Arevmda: return new string[] { "hy" };
				case Variant.Baku1926: return new string[] { "az", "ba", "crh", "kk", "krc", "ky", "sah", "tk", "tt", "uz" };
				case Variant.Balanka: return new string[] { "blo" };
				case Variant.Barla: return new string[] { "kea" };
				case Variant.Bauddha: return new string[] { "sa" };
				case Variant.Biscayan: return new string[] { "eu" };
				case Variant.Biske: return new string[] { "sl-rozaj" };
				case Variant.Bohoric: return new string[] { "sl" };
				case Variant.Boont: return new string[] { "en" };
				case Variant.Dajnko: return new string[] { "sl" };
				case Variant.Ekavsk: return new string[] { "sr", "sr-Latn", "sr-Cyrl" };
				case Variant.Emodeng: return new string[] { "en" };
				case Variant.Fonipa: return new string[] {  };
				case Variant.Fonupa: return new string[] {  };
				case Variant.Fonxsamp: return new string[] {  };
				case Variant.Hepburn: return new string[] { "ja-Latn" };
				case Variant.Hognorsk: return new string[] { "nn" };
				case Variant.Ijekavsk: return new string[] { "sr", "sr-Latn", "sr-Cyrl" };
				case Variant.Itihasa: return new string[] { "sa" };
				case Variant.Jauer: return new string[] { "rm" };
				case Variant.Jyutping: return new string[] { "yue" };
				case Variant.Kkcor: return new string[] { "kw" };
				case Variant.Kociewie: return new string[] { "pl" };
				case Variant.Kscor: return new string[] { "kw" };
				case Variant.Laukika: return new string[] { "sa" };
				case Variant.Lipaw: return new string[] { "sl-rozaj" };
				case Variant.Luna1918: return new string[] { "ru" };
				case Variant.Metelko: return new string[] { "sl" };
				case Variant.Monoton: return new string[] { "el" };
				case Variant.Ndyuka: return new string[] { "djk" };
				case Variant.Nedis: return new string[] { "sl" };
				case Variant.Njiva: return new string[] { "sl-rozaj" };
				case Variant.Nulik: return new string[] { "vo" };
				case Variant.Osojs: return new string[] { "sl-rozaj" };
				case Variant.Pamaka: return new string[] { "djk" };
				case Variant.Petr1708: return new string[] { "ru" };
				case Variant.Pinyin: return new string[] { "zh-Latn", "bo-Latn" };
				case Variant.Polyton: return new string[] { "el" };
				case Variant.Puter: return new string[] { "rm" };
				case Variant.Rigik: return new string[] { "vo" };
				case Variant.Rozaj: return new string[] { "sl" };
				case Variant.Rumgr: return new string[] { "rm" };
				case Variant.Scotland: return new string[] { "en" };
				case Variant.Scouse: return new string[] { "en" };
				case Variant.Solba: return new string[] { "sl-rozaj" };
				case Variant.Sotav: return new string[] { "kea" };
				case Variant.Surmiran: return new string[] { "rm" };
				case Variant.Sursilv: return new string[] { "rm" };
				case Variant.Sutsilv: return new string[] { "rm" };
				case Variant.Tarask: return new string[] { "be" };
				case Variant.Uccor: return new string[] { "kw" };
				case Variant.Ucrcor: return new string[] { "kw" };
				case Variant.Ulster: return new string[] { "sco" };
				case Variant.Unifon: return new string[] { "en", "hup", "kyh", "tol", "yur" };
				case Variant.Vaidika: return new string[] { "sa" };
				case Variant.Valencia: return new string[] { "ca" };
				case Variant.Vallader: return new string[] { "rm" };
				case Variant.Wadegile: return new string[] { "zh-Latn" };
				default:
					throw new NotImplementedException("unexpected value: " + v);
			}
		}

		/// <summary>
		/// Converts the value to its equivalent string representation.
		/// </summary>
		public static string ToText(this Variant v)
		{
			switch (v)
			{
				case Variant.V1606nict: return "1606nict";
				case Variant.V1694acad: return "1694acad";
				case Variant.V1901: return "1901";
				case Variant.V1959acad: return "1959acad";
				case Variant.V1994: return "1994";
				case Variant.V1996: return "1996";
				case Variant.Alalc97: return "alalc97";
				case Variant.Aluku: return "aluku";
				case Variant.Arevela: return "arevela";
				case Variant.Arevmda: return "arevmda";
				case Variant.Baku1926: return "baku1926";
				case Variant.Balanka: return "balanka";
				case Variant.Barla: return "barla";
				case Variant.Bauddha: return "bauddha";
				case Variant.Biscayan: return "biscayan";
				case Variant.Biske: return "biske";
				case Variant.Bohoric: return "bohoric";
				case Variant.Boont: return "boont";
				case Variant.Dajnko: return "dajnko";
				case Variant.Ekavsk: return "ekavsk";
				case Variant.Emodeng: return "emodeng";
				case Variant.Fonipa: return "fonipa";
				case Variant.Fonupa: return "fonupa";
				case Variant.Fonxsamp: return "fonxsamp";
				case Variant.Hepburn: return "hepburn";
				case Variant.Hognorsk: return "hognorsk";
				case Variant.Ijekavsk: return "ijekavsk";
				case Variant.Itihasa: return "itihasa";
				case Variant.Jauer: return "jauer";
				case Variant.Jyutping: return "jyutping";
				case Variant.Kkcor: return "kkcor";
				case Variant.Kociewie: return "kociewie";
				case Variant.Kscor: return "kscor";
				case Variant.Laukika: return "laukika";
				case Variant.Lipaw: return "lipaw";
				case Variant.Luna1918: return "luna1918";
				case Variant.Metelko: return "metelko";
				case Variant.Monoton: return "monoton";
				case Variant.Ndyuka: return "ndyuka";
				case Variant.Nedis: return "nedis";
				case Variant.Njiva: return "njiva";
				case Variant.Nulik: return "nulik";
				case Variant.Osojs: return "osojs";
				case Variant.Pamaka: return "pamaka";
				case Variant.Petr1708: return "petr1708";
				case Variant.Pinyin: return "pinyin";
				case Variant.Polyton: return "polyton";
				case Variant.Puter: return "puter";
				case Variant.Rigik: return "rigik";
				case Variant.Rozaj: return "rozaj";
				case Variant.Rumgr: return "rumgr";
				case Variant.Scotland: return "scotland";
				case Variant.Scouse: return "scouse";
				case Variant.Solba: return "solba";
				case Variant.Sotav: return "sotav";
				case Variant.Surmiran: return "surmiran";
				case Variant.Sursilv: return "sursilv";
				case Variant.Sutsilv: return "sutsilv";
				case Variant.Tarask: return "tarask";
				case Variant.Uccor: return "uccor";
				case Variant.Ucrcor: return "ucrcor";
				case Variant.Ulster: return "ulster";
				case Variant.Unifon: return "unifon";
				case Variant.Vaidika: return "vaidika";
				case Variant.Valencia: return "valencia";
				case Variant.Vallader: return "vallader";
				case Variant.Wadegile: return "wadegile";
				default:
					throw new NotImplementedException("unexpected value: " + v);
			}
		}

		public static Variant? TryParseFromVariant(this string text)
		{
			switch (text.ToLower(CultureInfo.InvariantCulture))
			{
				case "1606nict": return Variant.V1606nict;
				case "1694acad": return Variant.V1694acad;
				case "1901": return Variant.V1901;
				case "1959acad": return Variant.V1959acad;
				case "1994": return Variant.V1994;
				case "1996": return Variant.V1996;
				case "alalc97": return Variant.Alalc97;
				case "aluku": return Variant.Aluku;
				case "arevela": return Variant.Arevela;
				case "arevmda": return Variant.Arevmda;
				case "baku1926": return Variant.Baku1926;
				case "balanka": return Variant.Balanka;
				case "barla": return Variant.Barla;
				case "bauddha": return Variant.Bauddha;
				case "biscayan": return Variant.Biscayan;
				case "biske": return Variant.Biske;
				case "bohoric": return Variant.Bohoric;
				case "boont": return Variant.Boont;
				case "dajnko": return Variant.Dajnko;
				case "ekavsk": return Variant.Ekavsk;
				case "emodeng": return Variant.Emodeng;
				case "fonipa": return Variant.Fonipa;
				case "fonupa": return Variant.Fonupa;
				case "fonxsamp": return Variant.Fonxsamp;
				case "hepburn": return Variant.Hepburn;
				case "heploc": return Variant.Alalc97;
				case "hognorsk": return Variant.Hognorsk;
				case "ijekavsk": return Variant.Ijekavsk;
				case "itihasa": return Variant.Itihasa;
				case "jauer": return Variant.Jauer;
				case "jyutping": return Variant.Jyutping;
				case "kkcor": return Variant.Kkcor;
				case "kociewie": return Variant.Kociewie;
				case "kscor": return Variant.Kscor;
				case "laukika": return Variant.Laukika;
				case "lipaw": return Variant.Lipaw;
				case "luna1918": return Variant.Luna1918;
				case "metelko": return Variant.Metelko;
				case "monoton": return Variant.Monoton;
				case "ndyuka": return Variant.Ndyuka;
				case "nedis": return Variant.Nedis;
				case "njiva": return Variant.Njiva;
				case "nulik": return Variant.Nulik;
				case "osojs": return Variant.Osojs;
				case "pamaka": return Variant.Pamaka;
				case "petr1708": return Variant.Petr1708;
				case "pinyin": return Variant.Pinyin;
				case "polyton": return Variant.Polyton;
				case "puter": return Variant.Puter;
				case "rigik": return Variant.Rigik;
				case "rozaj": return Variant.Rozaj;
				case "rumgr": return Variant.Rumgr;
				case "scotland": return Variant.Scotland;
				case "scouse": return Variant.Scouse;
				case "solba": return Variant.Solba;
				case "sotav": return Variant.Sotav;
				case "surmiran": return Variant.Surmiran;
				case "sursilv": return Variant.Sursilv;
				case "sutsilv": return Variant.Sutsilv;
				case "tarask": return Variant.Tarask;
				case "uccor": return Variant.Uccor;
				case "ucrcor": return Variant.Ucrcor;
				case "ulster": return Variant.Ulster;
				case "unifon": return Variant.Unifon;
				case "vaidika": return Variant.Vaidika;
				case "valencia": return Variant.Valencia;
				case "vallader": return Variant.Vallader;
				case "wadegile": return Variant.Wadegile;
				default: return null;
			}
		}
	}
}
