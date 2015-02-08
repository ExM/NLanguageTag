﻿using System;
using System.Globalization;

namespace AbbyyLS.Globalization
{
	public static partial class ScriptExtensions
	{
		public static string ToText(this Script v)
		{
			switch (v)
			{
				case Script.Afak: return "Afak";
				case Script.Aghb: return "Aghb";
				case Script.Ahom: return "Ahom";
				case Script.Arab: return "Arab";
				case Script.Armi: return "Armi";
				case Script.Armn: return "Armn";
				case Script.Avst: return "Avst";
				case Script.Bali: return "Bali";
				case Script.Bamu: return "Bamu";
				case Script.Bass: return "Bass";
				case Script.Batk: return "Batk";
				case Script.Beng: return "Beng";
				case Script.Blis: return "Blis";
				case Script.Bopo: return "Bopo";
				case Script.Brah: return "Brah";
				case Script.Brai: return "Brai";
				case Script.Bugi: return "Bugi";
				case Script.Buhd: return "Buhd";
				case Script.Cakm: return "Cakm";
				case Script.Cans: return "Cans";
				case Script.Cari: return "Cari";
				case Script.Cham: return "Cham";
				case Script.Cher: return "Cher";
				case Script.Cirt: return "Cirt";
				case Script.Copt: return "Copt";
				case Script.Cprt: return "Cprt";
				case Script.Cyrl: return "Cyrl";
				case Script.Cyrs: return "Cyrs";
				case Script.Deva: return "Deva";
				case Script.Dsrt: return "Dsrt";
				case Script.Dupl: return "Dupl";
				case Script.Egyd: return "Egyd";
				case Script.Egyh: return "Egyh";
				case Script.Egyp: return "Egyp";
				case Script.Elba: return "Elba";
				case Script.Ethi: return "Ethi";
				case Script.Geok: return "Geok";
				case Script.Geor: return "Geor";
				case Script.Glag: return "Glag";
				case Script.Goth: return "Goth";
				case Script.Gran: return "Gran";
				case Script.Grek: return "Grek";
				case Script.Gujr: return "Gujr";
				case Script.Guru: return "Guru";
				case Script.Hang: return "Hang";
				case Script.Hani: return "Hani";
				case Script.Hano: return "Hano";
				case Script.Hans: return "Hans";
				case Script.Hant: return "Hant";
				case Script.Hatr: return "Hatr";
				case Script.Hebr: return "Hebr";
				case Script.Hira: return "Hira";
				case Script.Hluw: return "Hluw";
				case Script.Hmng: return "Hmng";
				case Script.Hrkt: return "Hrkt";
				case Script.Hung: return "Hung";
				case Script.Inds: return "Inds";
				case Script.Ital: return "Ital";
				case Script.Java: return "Java";
				case Script.Jpan: return "Jpan";
				case Script.Jurc: return "Jurc";
				case Script.Kali: return "Kali";
				case Script.Kana: return "Kana";
				case Script.Khar: return "Khar";
				case Script.Khmr: return "Khmr";
				case Script.Khoj: return "Khoj";
				case Script.Knda: return "Knda";
				case Script.Kore: return "Kore";
				case Script.Kpel: return "Kpel";
				case Script.Kthi: return "Kthi";
				case Script.Lana: return "Lana";
				case Script.Laoo: return "Laoo";
				case Script.Latf: return "Latf";
				case Script.Latg: return "Latg";
				case Script.Latn: return "Latn";
				case Script.Lepc: return "Lepc";
				case Script.Limb: return "Limb";
				case Script.Lina: return "Lina";
				case Script.Linb: return "Linb";
				case Script.Lisu: return "Lisu";
				case Script.Loma: return "Loma";
				case Script.Lyci: return "Lyci";
				case Script.Lydi: return "Lydi";
				case Script.Mahj: return "Mahj";
				case Script.Mand: return "Mand";
				case Script.Mani: return "Mani";
				case Script.Maya: return "Maya";
				case Script.Mend: return "Mend";
				case Script.Merc: return "Merc";
				case Script.Mero: return "Mero";
				case Script.Mlym: return "Mlym";
				case Script.Modi: return "Modi";
				case Script.Mong: return "Mong";
				case Script.Moon: return "Moon";
				case Script.Mroo: return "Mroo";
				case Script.Mtei: return "Mtei";
				case Script.Mult: return "Mult";
				case Script.Mymr: return "Mymr";
				case Script.Narb: return "Narb";
				case Script.Nbat: return "Nbat";
				case Script.Nkgb: return "Nkgb";
				case Script.Nkoo: return "Nkoo";
				case Script.Nshu: return "Nshu";
				case Script.Ogam: return "Ogam";
				case Script.Olck: return "Olck";
				case Script.Orkh: return "Orkh";
				case Script.Orya: return "Orya";
				case Script.Osma: return "Osma";
				case Script.Palm: return "Palm";
				case Script.Pauc: return "Pauc";
				case Script.Perm: return "Perm";
				case Script.Phag: return "Phag";
				case Script.Phli: return "Phli";
				case Script.Phlp: return "Phlp";
				case Script.Phlv: return "Phlv";
				case Script.Phnx: return "Phnx";
				case Script.Plrd: return "Plrd";
				case Script.Prti: return "Prti";
				case Script.Rjng: return "Rjng";
				case Script.Roro: return "Roro";
				case Script.Runr: return "Runr";
				case Script.Samr: return "Samr";
				case Script.Sara: return "Sara";
				case Script.Sarb: return "Sarb";
				case Script.Saur: return "Saur";
				case Script.Sgnw: return "Sgnw";
				case Script.Shaw: return "Shaw";
				case Script.Shrd: return "Shrd";
				case Script.Sidd: return "Sidd";
				case Script.Sind: return "Sind";
				case Script.Sinh: return "Sinh";
				case Script.Sora: return "Sora";
				case Script.Sund: return "Sund";
				case Script.Sylo: return "Sylo";
				case Script.Syrc: return "Syrc";
				case Script.Syre: return "Syre";
				case Script.Syrj: return "Syrj";
				case Script.Syrn: return "Syrn";
				case Script.Tagb: return "Tagb";
				case Script.Takr: return "Takr";
				case Script.Tale: return "Tale";
				case Script.Talu: return "Talu";
				case Script.Taml: return "Taml";
				case Script.Tang: return "Tang";
				case Script.Tavt: return "Tavt";
				case Script.Telu: return "Telu";
				case Script.Teng: return "Teng";
				case Script.Tfng: return "Tfng";
				case Script.Tglg: return "Tglg";
				case Script.Thaa: return "Thaa";
				case Script.Thai: return "Thai";
				case Script.Tibt: return "Tibt";
				case Script.Tirh: return "Tirh";
				case Script.Ugar: return "Ugar";
				case Script.Vaii: return "Vaii";
				case Script.Visp: return "Visp";
				case Script.Wara: return "Wara";
				case Script.Wole: return "Wole";
				case Script.Xpeo: return "Xpeo";
				case Script.Xsux: return "Xsux";
				case Script.Yiii: return "Yiii";
				case Script.Zinh: return "Zinh";
				case Script.Zmth: return "Zmth";
				case Script.Zsym: return "Zsym";
				case Script.Zxxx: return "Zxxx";
				case Script.Zyyy: return "Zyyy";
				case Script.Zzzz: return "Zzzz";
				default:
					throw new NotImplementedException("unexpected value: " + v);
			}
		}

		public static Script? TryParseFromScript(this string text)
		{
			switch (text.ToLower(CultureInfo.InvariantCulture))
			{
				case "afak": return Script.Afak;
				case "aghb": return Script.Aghb;
				case "ahom": return Script.Ahom;
				case "arab": return Script.Arab;
				case "armi": return Script.Armi;
				case "armn": return Script.Armn;
				case "avst": return Script.Avst;
				case "bali": return Script.Bali;
				case "bamu": return Script.Bamu;
				case "bass": return Script.Bass;
				case "batk": return Script.Batk;
				case "beng": return Script.Beng;
				case "blis": return Script.Blis;
				case "bopo": return Script.Bopo;
				case "brah": return Script.Brah;
				case "brai": return Script.Brai;
				case "bugi": return Script.Bugi;
				case "buhd": return Script.Buhd;
				case "cakm": return Script.Cakm;
				case "cans": return Script.Cans;
				case "cari": return Script.Cari;
				case "cham": return Script.Cham;
				case "cher": return Script.Cher;
				case "cirt": return Script.Cirt;
				case "copt": return Script.Copt;
				case "cprt": return Script.Cprt;
				case "cyrl": return Script.Cyrl;
				case "cyrs": return Script.Cyrs;
				case "deva": return Script.Deva;
				case "dsrt": return Script.Dsrt;
				case "dupl": return Script.Dupl;
				case "egyd": return Script.Egyd;
				case "egyh": return Script.Egyh;
				case "egyp": return Script.Egyp;
				case "elba": return Script.Elba;
				case "ethi": return Script.Ethi;
				case "geok": return Script.Geok;
				case "geor": return Script.Geor;
				case "glag": return Script.Glag;
				case "goth": return Script.Goth;
				case "gran": return Script.Gran;
				case "grek": return Script.Grek;
				case "gujr": return Script.Gujr;
				case "guru": return Script.Guru;
				case "hang": return Script.Hang;
				case "hani": return Script.Hani;
				case "hano": return Script.Hano;
				case "hans": return Script.Hans;
				case "hant": return Script.Hant;
				case "hatr": return Script.Hatr;
				case "hebr": return Script.Hebr;
				case "hira": return Script.Hira;
				case "hluw": return Script.Hluw;
				case "hmng": return Script.Hmng;
				case "hrkt": return Script.Hrkt;
				case "hung": return Script.Hung;
				case "inds": return Script.Inds;
				case "ital": return Script.Ital;
				case "java": return Script.Java;
				case "jpan": return Script.Jpan;
				case "jurc": return Script.Jurc;
				case "kali": return Script.Kali;
				case "kana": return Script.Kana;
				case "khar": return Script.Khar;
				case "khmr": return Script.Khmr;
				case "khoj": return Script.Khoj;
				case "knda": return Script.Knda;
				case "kore": return Script.Kore;
				case "kpel": return Script.Kpel;
				case "kthi": return Script.Kthi;
				case "lana": return Script.Lana;
				case "laoo": return Script.Laoo;
				case "latf": return Script.Latf;
				case "latg": return Script.Latg;
				case "latn": return Script.Latn;
				case "lepc": return Script.Lepc;
				case "limb": return Script.Limb;
				case "lina": return Script.Lina;
				case "linb": return Script.Linb;
				case "lisu": return Script.Lisu;
				case "loma": return Script.Loma;
				case "lyci": return Script.Lyci;
				case "lydi": return Script.Lydi;
				case "mahj": return Script.Mahj;
				case "mand": return Script.Mand;
				case "mani": return Script.Mani;
				case "maya": return Script.Maya;
				case "mend": return Script.Mend;
				case "merc": return Script.Merc;
				case "mero": return Script.Mero;
				case "mlym": return Script.Mlym;
				case "modi": return Script.Modi;
				case "mong": return Script.Mong;
				case "moon": return Script.Moon;
				case "mroo": return Script.Mroo;
				case "mtei": return Script.Mtei;
				case "mult": return Script.Mult;
				case "mymr": return Script.Mymr;
				case "narb": return Script.Narb;
				case "nbat": return Script.Nbat;
				case "nkgb": return Script.Nkgb;
				case "nkoo": return Script.Nkoo;
				case "nshu": return Script.Nshu;
				case "ogam": return Script.Ogam;
				case "olck": return Script.Olck;
				case "orkh": return Script.Orkh;
				case "orya": return Script.Orya;
				case "osma": return Script.Osma;
				case "palm": return Script.Palm;
				case "pauc": return Script.Pauc;
				case "perm": return Script.Perm;
				case "phag": return Script.Phag;
				case "phli": return Script.Phli;
				case "phlp": return Script.Phlp;
				case "phlv": return Script.Phlv;
				case "phnx": return Script.Phnx;
				case "plrd": return Script.Plrd;
				case "prti": return Script.Prti;
				case "rjng": return Script.Rjng;
				case "roro": return Script.Roro;
				case "runr": return Script.Runr;
				case "samr": return Script.Samr;
				case "sara": return Script.Sara;
				case "sarb": return Script.Sarb;
				case "saur": return Script.Saur;
				case "sgnw": return Script.Sgnw;
				case "shaw": return Script.Shaw;
				case "shrd": return Script.Shrd;
				case "sidd": return Script.Sidd;
				case "sind": return Script.Sind;
				case "sinh": return Script.Sinh;
				case "sora": return Script.Sora;
				case "sund": return Script.Sund;
				case "sylo": return Script.Sylo;
				case "syrc": return Script.Syrc;
				case "syre": return Script.Syre;
				case "syrj": return Script.Syrj;
				case "syrn": return Script.Syrn;
				case "tagb": return Script.Tagb;
				case "takr": return Script.Takr;
				case "tale": return Script.Tale;
				case "talu": return Script.Talu;
				case "taml": return Script.Taml;
				case "tang": return Script.Tang;
				case "tavt": return Script.Tavt;
				case "telu": return Script.Telu;
				case "teng": return Script.Teng;
				case "tfng": return Script.Tfng;
				case "tglg": return Script.Tglg;
				case "thaa": return Script.Thaa;
				case "thai": return Script.Thai;
				case "tibt": return Script.Tibt;
				case "tirh": return Script.Tirh;
				case "ugar": return Script.Ugar;
				case "vaii": return Script.Vaii;
				case "visp": return Script.Visp;
				case "wara": return Script.Wara;
				case "wole": return Script.Wole;
				case "xpeo": return Script.Xpeo;
				case "xsux": return Script.Xsux;
				case "yiii": return Script.Yiii;
				case "zinh": return Script.Zinh;
				case "zmth": return Script.Zmth;
				case "zsym": return Script.Zsym;
				case "zxxx": return Script.Zxxx;
				case "zyyy": return Script.Zyyy;
				case "zzzz": return Script.Zzzz;
				default: return null;
			}
		}
	}
}
