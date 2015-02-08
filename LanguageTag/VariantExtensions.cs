using System;
using System.Globalization;

namespace AbbyyLS.Globalization
{
	public static class VariantExtensions
	{
		public static Variant GetPreferredValue(this Variant v)
		{
			switch(v)
			{
				case Variant.Heploc: return Variant.Alalc97;
				default: return v;
			}
		}

		public static string GetPrefix(this Variant v)
		{
			switch(v)
			{
				case Variant.V1606nict: return "frm";
				case Variant.V1694acad: return "fr";
				case Variant.V1901: return "de";
				case Variant.V1959acad: return "be";
				case Variant.V1994: return "sl-rozaj-solba";
				case Variant.V1996: return "de";
				case Variant.Aluku: return "djk";
				case Variant.Arevela: return "hy";
				case Variant.Arevmda: return "hy";
				case Variant.Baku1926: return "uz";
				case Variant.Balanka: return "blo";
				case Variant.Barla: return "kea";
				case Variant.Bauddha: return "sa";
				case Variant.Biscayan: return "eu";
				case Variant.Biske: return "sl-rozaj";
				case Variant.Bohoric: return "sl";
				case Variant.Boont: return "en";
				case Variant.Dajnko: return "sl";
				case Variant.Ekavsk: return "sr-Cyrl";
				case Variant.Emodeng: return "en";
				case Variant.Hepburn: return "ja-Latn";
				case Variant.Heploc: return "ja-Latn-hepburn";
				case Variant.Hognorsk: return "nn";
				case Variant.Ijekavsk: return "sr-Cyrl";
				case Variant.Itihasa: return "sa";
				case Variant.Jauer: return "rm";
				case Variant.Jyutping: return "yue";
				case Variant.Kkcor: return "kw";
				case Variant.Kscor: return "kw";
				case Variant.Laukika: return "sa";
				case Variant.Lipaw: return "sl-rozaj";
				case Variant.Luna1918: return "ru";
				case Variant.Metelko: return "sl";
				case Variant.Monoton: return "el";
				case Variant.Ndyuka: return "djk";
				case Variant.Nedis: return "sl";
				case Variant.Njiva: return "sl-rozaj";
				case Variant.Nulik: return "vo";
				case Variant.Osojs: return "sl-rozaj";
				case Variant.Pamaka: return "djk";
				case Variant.Petr1708: return "ru";
				case Variant.Pinyin: return "bo-Latn";
				case Variant.Polyton: return "el";
				case Variant.Puter: return "rm";
				case Variant.Rigik: return "vo";
				case Variant.Rozaj: return "sl";
				case Variant.Rumgr: return "rm";
				case Variant.Scotland: return "en";
				case Variant.Scouse: return "en";
				case Variant.Solba: return "sl-rozaj";
				case Variant.Sotav: return "kea";
				case Variant.Surmiran: return "rm";
				case Variant.Sursilv: return "rm";
				case Variant.Sutsilv: return "rm";
				case Variant.Tarask: return "be";
				case Variant.Uccor: return "kw";
				case Variant.Ucrcor: return "kw";
				case Variant.Ulster: return "sco";
				case Variant.Unifon: return "yur";
				case Variant.Vaidika: return "sa";
				case Variant.Valencia: return "ca";
				case Variant.Vallader: return "rm";
				case Variant.Wadegile: return "zh-Latn";
				default: return null;
			}
		}

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
				case Variant.Heploc: return "heploc";
				case Variant.Hognorsk: return "hognorsk";
				case Variant.Ijekavsk: return "ijekavsk";
				case Variant.Itihasa: return "itihasa";
				case Variant.Jauer: return "jauer";
				case Variant.Jyutping: return "jyutping";
				case Variant.Kkcor: return "kkcor";
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
		
		public static Variant ParseFromVariant(this string text)
		{
			var result = text.TryParseFromVariant();
			if (result.HasValue)
				return result.Value;
			
			throw new FormatException("unexpected variant code '" + text + "'");
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
				case "heploc": return Variant.Heploc;
				case "hognorsk": return Variant.Hognorsk;
				case "ijekavsk": return Variant.Ijekavsk;
				case "itihasa": return Variant.Itihasa;
				case "jauer": return Variant.Jauer;
				case "jyutping": return Variant.Jyutping;
				case "kkcor": return Variant.Kkcor;
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
