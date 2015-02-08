﻿using System;
using System.Globalization;

namespace AbbyyLS.Globalization
{
	public static class RegionExtensions
	{
		public static Region GetPreferredValue(this Region v)
		{
			switch(v)
			{
				case Region.BU: return Region.MM;
				case Region.DD: return Region.DE;
				case Region.FX: return Region.FR;
				case Region.TP: return Region.TL;
				case Region.YD: return Region.YE;
				case Region.ZR: return Region.CD;
				default: return v;
			}
		}

		public static string ToText(this Region v)
		{
			switch (v)
			{
				case Region.AA: return "AA";
				case Region.AC: return "AC";
				case Region.AD: return "AD";
				case Region.AE: return "AE";
				case Region.AF: return "AF";
				case Region.AG: return "AG";
				case Region.AI: return "AI";
				case Region.AL: return "AL";
				case Region.AM: return "AM";
				case Region.AN: return "AN";
				case Region.AO: return "AO";
				case Region.AQ: return "AQ";
				case Region.AR: return "AR";
				case Region.AS: return "AS";
				case Region.AT: return "AT";
				case Region.AU: return "AU";
				case Region.AW: return "AW";
				case Region.AX: return "AX";
				case Region.AZ: return "AZ";
				case Region.BA: return "BA";
				case Region.BB: return "BB";
				case Region.BD: return "BD";
				case Region.BE: return "BE";
				case Region.BF: return "BF";
				case Region.BG: return "BG";
				case Region.BH: return "BH";
				case Region.BI: return "BI";
				case Region.BJ: return "BJ";
				case Region.BL: return "BL";
				case Region.BM: return "BM";
				case Region.BN: return "BN";
				case Region.BO: return "BO";
				case Region.BQ: return "BQ";
				case Region.BR: return "BR";
				case Region.BS: return "BS";
				case Region.BT: return "BT";
				case Region.BU: return "BU";
				case Region.BV: return "BV";
				case Region.BW: return "BW";
				case Region.BY: return "BY";
				case Region.BZ: return "BZ";
				case Region.CA: return "CA";
				case Region.CC: return "CC";
				case Region.CD: return "CD";
				case Region.CF: return "CF";
				case Region.CG: return "CG";
				case Region.CH: return "CH";
				case Region.CI: return "CI";
				case Region.CK: return "CK";
				case Region.CL: return "CL";
				case Region.CM: return "CM";
				case Region.CN: return "CN";
				case Region.CO: return "CO";
				case Region.CP: return "CP";
				case Region.CR: return "CR";
				case Region.CS: return "CS";
				case Region.CU: return "CU";
				case Region.CV: return "CV";
				case Region.CW: return "CW";
				case Region.CX: return "CX";
				case Region.CY: return "CY";
				case Region.CZ: return "CZ";
				case Region.DD: return "DD";
				case Region.DE: return "DE";
				case Region.DG: return "DG";
				case Region.DJ: return "DJ";
				case Region.DK: return "DK";
				case Region.DM: return "DM";
				case Region.DO: return "DO";
				case Region.DZ: return "DZ";
				case Region.EA: return "EA";
				case Region.EC: return "EC";
				case Region.EE: return "EE";
				case Region.EG: return "EG";
				case Region.EH: return "EH";
				case Region.ER: return "ER";
				case Region.ES: return "ES";
				case Region.ET: return "ET";
				case Region.EU: return "EU";
				case Region.FI: return "FI";
				case Region.FJ: return "FJ";
				case Region.FK: return "FK";
				case Region.FM: return "FM";
				case Region.FO: return "FO";
				case Region.FR: return "FR";
				case Region.FX: return "FX";
				case Region.GA: return "GA";
				case Region.GB: return "GB";
				case Region.GD: return "GD";
				case Region.GE: return "GE";
				case Region.GF: return "GF";
				case Region.GG: return "GG";
				case Region.GH: return "GH";
				case Region.GI: return "GI";
				case Region.GL: return "GL";
				case Region.GM: return "GM";
				case Region.GN: return "GN";
				case Region.GP: return "GP";
				case Region.GQ: return "GQ";
				case Region.GR: return "GR";
				case Region.GS: return "GS";
				case Region.GT: return "GT";
				case Region.GU: return "GU";
				case Region.GW: return "GW";
				case Region.GY: return "GY";
				case Region.HK: return "HK";
				case Region.HM: return "HM";
				case Region.HN: return "HN";
				case Region.HR: return "HR";
				case Region.HT: return "HT";
				case Region.HU: return "HU";
				case Region.IC: return "IC";
				case Region.ID: return "ID";
				case Region.IE: return "IE";
				case Region.IL: return "IL";
				case Region.IM: return "IM";
				case Region.IN: return "IN";
				case Region.IO: return "IO";
				case Region.IQ: return "IQ";
				case Region.IR: return "IR";
				case Region.IS: return "IS";
				case Region.IT: return "IT";
				case Region.JE: return "JE";
				case Region.JM: return "JM";
				case Region.JO: return "JO";
				case Region.JP: return "JP";
				case Region.KE: return "KE";
				case Region.KG: return "KG";
				case Region.KH: return "KH";
				case Region.KI: return "KI";
				case Region.KM: return "KM";
				case Region.KN: return "KN";
				case Region.KP: return "KP";
				case Region.KR: return "KR";
				case Region.KW: return "KW";
				case Region.KY: return "KY";
				case Region.KZ: return "KZ";
				case Region.LA: return "LA";
				case Region.LB: return "LB";
				case Region.LC: return "LC";
				case Region.LI: return "LI";
				case Region.LK: return "LK";
				case Region.LR: return "LR";
				case Region.LS: return "LS";
				case Region.LT: return "LT";
				case Region.LU: return "LU";
				case Region.LV: return "LV";
				case Region.LY: return "LY";
				case Region.MA: return "MA";
				case Region.MC: return "MC";
				case Region.MD: return "MD";
				case Region.ME: return "ME";
				case Region.MF: return "MF";
				case Region.MG: return "MG";
				case Region.MH: return "MH";
				case Region.MK: return "MK";
				case Region.ML: return "ML";
				case Region.MM: return "MM";
				case Region.MN: return "MN";
				case Region.MO: return "MO";
				case Region.MP: return "MP";
				case Region.MQ: return "MQ";
				case Region.MR: return "MR";
				case Region.MS: return "MS";
				case Region.MT: return "MT";
				case Region.MU: return "MU";
				case Region.MV: return "MV";
				case Region.MW: return "MW";
				case Region.MX: return "MX";
				case Region.MY: return "MY";
				case Region.MZ: return "MZ";
				case Region.NA: return "NA";
				case Region.NC: return "NC";
				case Region.NE: return "NE";
				case Region.NF: return "NF";
				case Region.NG: return "NG";
				case Region.NI: return "NI";
				case Region.NL: return "NL";
				case Region.NO: return "NO";
				case Region.NP: return "NP";
				case Region.NR: return "NR";
				case Region.NT: return "NT";
				case Region.NU: return "NU";
				case Region.NZ: return "NZ";
				case Region.OM: return "OM";
				case Region.PA: return "PA";
				case Region.PE: return "PE";
				case Region.PF: return "PF";
				case Region.PG: return "PG";
				case Region.PH: return "PH";
				case Region.PK: return "PK";
				case Region.PL: return "PL";
				case Region.PM: return "PM";
				case Region.PN: return "PN";
				case Region.PR: return "PR";
				case Region.PS: return "PS";
				case Region.PT: return "PT";
				case Region.PW: return "PW";
				case Region.PY: return "PY";
				case Region.QA: return "QA";
				case Region.RE: return "RE";
				case Region.RO: return "RO";
				case Region.RS: return "RS";
				case Region.RU: return "RU";
				case Region.RW: return "RW";
				case Region.SA: return "SA";
				case Region.SB: return "SB";
				case Region.SC: return "SC";
				case Region.SD: return "SD";
				case Region.SE: return "SE";
				case Region.SG: return "SG";
				case Region.SH: return "SH";
				case Region.SI: return "SI";
				case Region.SJ: return "SJ";
				case Region.SK: return "SK";
				case Region.SL: return "SL";
				case Region.SM: return "SM";
				case Region.SN: return "SN";
				case Region.SO: return "SO";
				case Region.SR: return "SR";
				case Region.SS: return "SS";
				case Region.ST: return "ST";
				case Region.SU: return "SU";
				case Region.SV: return "SV";
				case Region.SX: return "SX";
				case Region.SY: return "SY";
				case Region.SZ: return "SZ";
				case Region.TA: return "TA";
				case Region.TC: return "TC";
				case Region.TD: return "TD";
				case Region.TF: return "TF";
				case Region.TG: return "TG";
				case Region.TH: return "TH";
				case Region.TJ: return "TJ";
				case Region.TK: return "TK";
				case Region.TL: return "TL";
				case Region.TM: return "TM";
				case Region.TN: return "TN";
				case Region.TO: return "TO";
				case Region.TP: return "TP";
				case Region.TR: return "TR";
				case Region.TT: return "TT";
				case Region.TV: return "TV";
				case Region.TW: return "TW";
				case Region.TZ: return "TZ";
				case Region.UA: return "UA";
				case Region.UG: return "UG";
				case Region.UM: return "UM";
				case Region.US: return "US";
				case Region.UY: return "UY";
				case Region.UZ: return "UZ";
				case Region.VA: return "VA";
				case Region.VC: return "VC";
				case Region.VE: return "VE";
				case Region.VG: return "VG";
				case Region.VI: return "VI";
				case Region.VN: return "VN";
				case Region.VU: return "VU";
				case Region.WF: return "WF";
				case Region.WS: return "WS";
				case Region.YD: return "YD";
				case Region.YE: return "YE";
				case Region.YT: return "YT";
				case Region.YU: return "YU";
				case Region.ZA: return "ZA";
				case Region.ZM: return "ZM";
				case Region.ZR: return "ZR";
				case Region.ZW: return "ZW";
				case Region.ZZ: return "ZZ";
				case Region.M001: return "001";
				case Region.M002: return "002";
				case Region.M003: return "003";
				case Region.M005: return "005";
				case Region.M009: return "009";
				case Region.M011: return "011";
				case Region.M013: return "013";
				case Region.M014: return "014";
				case Region.M015: return "015";
				case Region.M017: return "017";
				case Region.M018: return "018";
				case Region.M019: return "019";
				case Region.M021: return "021";
				case Region.M029: return "029";
				case Region.M030: return "030";
				case Region.M034: return "034";
				case Region.M035: return "035";
				case Region.M039: return "039";
				case Region.M053: return "053";
				case Region.M054: return "054";
				case Region.M057: return "057";
				case Region.M061: return "061";
				case Region.M142: return "142";
				case Region.M143: return "143";
				case Region.M145: return "145";
				case Region.M150: return "150";
				case Region.M151: return "151";
				case Region.M154: return "154";
				case Region.M155: return "155";
				case Region.M419: return "419";
				default:
					throw new NotImplementedException("unexpected value '" + v + "'");
			}
		}
		
		public static Region ParseFromRegion(this string text)
		{
			var result = text.TryParseFromRegion();
			if (result.HasValue)
				return result.Value;
			
			throw new FormatException("unexpected region '" + text + "'");
		}

		public static Region? TryParseFromRegion(this string text)
		{
			switch (text.ToLower(CultureInfo.InvariantCulture))
			{
				case "aa": return Region.AA;
				case "ac": return Region.AC;
				case "ad": return Region.AD;
				case "ae": return Region.AE;
				case "af": return Region.AF;
				case "ag": return Region.AG;
				case "ai": return Region.AI;
				case "al": return Region.AL;
				case "am": return Region.AM;
				case "an": return Region.AN;
				case "ao": return Region.AO;
				case "aq": return Region.AQ;
				case "ar": return Region.AR;
				case "as": return Region.AS;
				case "at": return Region.AT;
				case "au": return Region.AU;
				case "aw": return Region.AW;
				case "ax": return Region.AX;
				case "az": return Region.AZ;
				case "ba": return Region.BA;
				case "bb": return Region.BB;
				case "bd": return Region.BD;
				case "be": return Region.BE;
				case "bf": return Region.BF;
				case "bg": return Region.BG;
				case "bh": return Region.BH;
				case "bi": return Region.BI;
				case "bj": return Region.BJ;
				case "bl": return Region.BL;
				case "bm": return Region.BM;
				case "bn": return Region.BN;
				case "bo": return Region.BO;
				case "bq": return Region.BQ;
				case "br": return Region.BR;
				case "bs": return Region.BS;
				case "bt": return Region.BT;
				case "bu": return Region.BU;
				case "bv": return Region.BV;
				case "bw": return Region.BW;
				case "by": return Region.BY;
				case "bz": return Region.BZ;
				case "ca": return Region.CA;
				case "cc": return Region.CC;
				case "cd": return Region.CD;
				case "cf": return Region.CF;
				case "cg": return Region.CG;
				case "ch": return Region.CH;
				case "ci": return Region.CI;
				case "ck": return Region.CK;
				case "cl": return Region.CL;
				case "cm": return Region.CM;
				case "cn": return Region.CN;
				case "co": return Region.CO;
				case "cp": return Region.CP;
				case "cr": return Region.CR;
				case "cs": return Region.CS;
				case "cu": return Region.CU;
				case "cv": return Region.CV;
				case "cw": return Region.CW;
				case "cx": return Region.CX;
				case "cy": return Region.CY;
				case "cz": return Region.CZ;
				case "dd": return Region.DD;
				case "de": return Region.DE;
				case "dg": return Region.DG;
				case "dj": return Region.DJ;
				case "dk": return Region.DK;
				case "dm": return Region.DM;
				case "do": return Region.DO;
				case "dz": return Region.DZ;
				case "ea": return Region.EA;
				case "ec": return Region.EC;
				case "ee": return Region.EE;
				case "eg": return Region.EG;
				case "eh": return Region.EH;
				case "er": return Region.ER;
				case "es": return Region.ES;
				case "et": return Region.ET;
				case "eu": return Region.EU;
				case "fi": return Region.FI;
				case "fj": return Region.FJ;
				case "fk": return Region.FK;
				case "fm": return Region.FM;
				case "fo": return Region.FO;
				case "fr": return Region.FR;
				case "fx": return Region.FX;
				case "ga": return Region.GA;
				case "gb": return Region.GB;
				case "gd": return Region.GD;
				case "ge": return Region.GE;
				case "gf": return Region.GF;
				case "gg": return Region.GG;
				case "gh": return Region.GH;
				case "gi": return Region.GI;
				case "gl": return Region.GL;
				case "gm": return Region.GM;
				case "gn": return Region.GN;
				case "gp": return Region.GP;
				case "gq": return Region.GQ;
				case "gr": return Region.GR;
				case "gs": return Region.GS;
				case "gt": return Region.GT;
				case "gu": return Region.GU;
				case "gw": return Region.GW;
				case "gy": return Region.GY;
				case "hk": return Region.HK;
				case "hm": return Region.HM;
				case "hn": return Region.HN;
				case "hr": return Region.HR;
				case "ht": return Region.HT;
				case "hu": return Region.HU;
				case "ic": return Region.IC;
				case "id": return Region.ID;
				case "ie": return Region.IE;
				case "il": return Region.IL;
				case "im": return Region.IM;
				case "in": return Region.IN;
				case "io": return Region.IO;
				case "iq": return Region.IQ;
				case "ir": return Region.IR;
				case "is": return Region.IS;
				case "it": return Region.IT;
				case "je": return Region.JE;
				case "jm": return Region.JM;
				case "jo": return Region.JO;
				case "jp": return Region.JP;
				case "ke": return Region.KE;
				case "kg": return Region.KG;
				case "kh": return Region.KH;
				case "ki": return Region.KI;
				case "km": return Region.KM;
				case "kn": return Region.KN;
				case "kp": return Region.KP;
				case "kr": return Region.KR;
				case "kw": return Region.KW;
				case "ky": return Region.KY;
				case "kz": return Region.KZ;
				case "la": return Region.LA;
				case "lb": return Region.LB;
				case "lc": return Region.LC;
				case "li": return Region.LI;
				case "lk": return Region.LK;
				case "lr": return Region.LR;
				case "ls": return Region.LS;
				case "lt": return Region.LT;
				case "lu": return Region.LU;
				case "lv": return Region.LV;
				case "ly": return Region.LY;
				case "ma": return Region.MA;
				case "mc": return Region.MC;
				case "md": return Region.MD;
				case "me": return Region.ME;
				case "mf": return Region.MF;
				case "mg": return Region.MG;
				case "mh": return Region.MH;
				case "mk": return Region.MK;
				case "ml": return Region.ML;
				case "mm": return Region.MM;
				case "mn": return Region.MN;
				case "mo": return Region.MO;
				case "mp": return Region.MP;
				case "mq": return Region.MQ;
				case "mr": return Region.MR;
				case "ms": return Region.MS;
				case "mt": return Region.MT;
				case "mu": return Region.MU;
				case "mv": return Region.MV;
				case "mw": return Region.MW;
				case "mx": return Region.MX;
				case "my": return Region.MY;
				case "mz": return Region.MZ;
				case "na": return Region.NA;
				case "nc": return Region.NC;
				case "ne": return Region.NE;
				case "nf": return Region.NF;
				case "ng": return Region.NG;
				case "ni": return Region.NI;
				case "nl": return Region.NL;
				case "no": return Region.NO;
				case "np": return Region.NP;
				case "nr": return Region.NR;
				case "nt": return Region.NT;
				case "nu": return Region.NU;
				case "nz": return Region.NZ;
				case "om": return Region.OM;
				case "pa": return Region.PA;
				case "pe": return Region.PE;
				case "pf": return Region.PF;
				case "pg": return Region.PG;
				case "ph": return Region.PH;
				case "pk": return Region.PK;
				case "pl": return Region.PL;
				case "pm": return Region.PM;
				case "pn": return Region.PN;
				case "pr": return Region.PR;
				case "ps": return Region.PS;
				case "pt": return Region.PT;
				case "pw": return Region.PW;
				case "py": return Region.PY;
				case "qa": return Region.QA;
				case "re": return Region.RE;
				case "ro": return Region.RO;
				case "rs": return Region.RS;
				case "ru": return Region.RU;
				case "rw": return Region.RW;
				case "sa": return Region.SA;
				case "sb": return Region.SB;
				case "sc": return Region.SC;
				case "sd": return Region.SD;
				case "se": return Region.SE;
				case "sg": return Region.SG;
				case "sh": return Region.SH;
				case "si": return Region.SI;
				case "sj": return Region.SJ;
				case "sk": return Region.SK;
				case "sl": return Region.SL;
				case "sm": return Region.SM;
				case "sn": return Region.SN;
				case "so": return Region.SO;
				case "sr": return Region.SR;
				case "ss": return Region.SS;
				case "st": return Region.ST;
				case "su": return Region.SU;
				case "sv": return Region.SV;
				case "sx": return Region.SX;
				case "sy": return Region.SY;
				case "sz": return Region.SZ;
				case "ta": return Region.TA;
				case "tc": return Region.TC;
				case "td": return Region.TD;
				case "tf": return Region.TF;
				case "tg": return Region.TG;
				case "th": return Region.TH;
				case "tj": return Region.TJ;
				case "tk": return Region.TK;
				case "tl": return Region.TL;
				case "tm": return Region.TM;
				case "tn": return Region.TN;
				case "to": return Region.TO;
				case "tp": return Region.TP;
				case "tr": return Region.TR;
				case "tt": return Region.TT;
				case "tv": return Region.TV;
				case "tw": return Region.TW;
				case "tz": return Region.TZ;
				case "ua": return Region.UA;
				case "ug": return Region.UG;
				case "um": return Region.UM;
				case "us": return Region.US;
				case "uy": return Region.UY;
				case "uz": return Region.UZ;
				case "va": return Region.VA;
				case "vc": return Region.VC;
				case "ve": return Region.VE;
				case "vg": return Region.VG;
				case "vi": return Region.VI;
				case "vn": return Region.VN;
				case "vu": return Region.VU;
				case "wf": return Region.WF;
				case "ws": return Region.WS;
				case "yd": return Region.YD;
				case "ye": return Region.YE;
				case "yt": return Region.YT;
				case "yu": return Region.YU;
				case "za": return Region.ZA;
				case "zm": return Region.ZM;
				case "zr": return Region.ZR;
				case "zw": return Region.ZW;
				case "zz": return Region.ZZ;
				case "001": return Region.M001;
				case "002": return Region.M002;
				case "003": return Region.M003;
				case "005": return Region.M005;
				case "009": return Region.M009;
				case "011": return Region.M011;
				case "013": return Region.M013;
				case "014": return Region.M014;
				case "015": return Region.M015;
				case "017": return Region.M017;
				case "018": return Region.M018;
				case "019": return Region.M019;
				case "021": return Region.M021;
				case "029": return Region.M029;
				case "030": return Region.M030;
				case "034": return Region.M034;
				case "035": return Region.M035;
				case "039": return Region.M039;
				case "053": return Region.M053;
				case "054": return Region.M054;
				case "057": return Region.M057;
				case "061": return Region.M061;
				case "142": return Region.M142;
				case "143": return Region.M143;
				case "145": return Region.M145;
				case "150": return Region.M150;
				case "151": return Region.M151;
				case "154": return Region.M154;
				case "155": return Region.M155;
				case "419": return Region.M419;
				default: return null;
			}
		}
	}
}
