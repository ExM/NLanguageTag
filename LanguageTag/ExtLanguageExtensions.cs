using System;
using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	/// <summary>
	/// Мethods for the components of language tag
	/// </summary>
	public static partial class LanguageTagExtensions
	{
		/// <summary>
		/// Determines the possible presence of extlang subtag
		/// </summary>
		/// <param name="language">primary language subtag</param>
		public static bool ExtLanguageAvailable(this Language language)
		{
			switch(language)
			{
				case Language.AR:
				case Language.SGN:
				case Language.MS:
				case Language.ZH:
				case Language.KOK:
				case Language.LV:
				case Language.SW:
				case Language.UZ:
					return true;
				default:
					return false;
			}
		}

		/// <summary>
		/// specifies the language that must precede the extlang subtag
		/// </summary>
		/// <param name="language">primary language subtag</param>
		public static Language? GetPrefix(this Language language)
		{
			switch(language)
			{
				case Language.AAO: return Language.AR;
				case Language.ABH: return Language.AR;
				case Language.ABV: return Language.AR;
				case Language.ACM: return Language.AR;
				case Language.ACQ: return Language.AR;
				case Language.ACW: return Language.AR;
				case Language.ACX: return Language.AR;
				case Language.ACY: return Language.AR;
				case Language.ADF: return Language.AR;
				case Language.ADS: return Language.SGN;
				case Language.AEB: return Language.AR;
				case Language.AEC: return Language.AR;
				case Language.AED: return Language.SGN;
				case Language.AEN: return Language.SGN;
				case Language.AFB: return Language.AR;
				case Language.AFG: return Language.SGN;
				case Language.AJP: return Language.AR;
				case Language.APC: return Language.AR;
				case Language.APD: return Language.AR;
				case Language.ARB: return Language.AR;
				case Language.ARQ: return Language.AR;
				case Language.ARS: return Language.AR;
				case Language.ARY: return Language.AR;
				case Language.ARZ: return Language.AR;
				case Language.ASE: return Language.SGN;
				case Language.ASF: return Language.SGN;
				case Language.ASP: return Language.SGN;
				case Language.ASQ: return Language.SGN;
				case Language.ASW: return Language.SGN;
				case Language.AUZ: return Language.AR;
				case Language.AVL: return Language.AR;
				case Language.AYH: return Language.AR;
				case Language.AYL: return Language.AR;
				case Language.AYN: return Language.AR;
				case Language.AYP: return Language.AR;
				case Language.BBZ: return Language.AR;
				case Language.BFI: return Language.SGN;
				case Language.BFK: return Language.SGN;
				case Language.BJN: return Language.MS;
				case Language.BOG: return Language.SGN;
				case Language.BQN: return Language.SGN;
				case Language.BQY: return Language.SGN;
				case Language.BTJ: return Language.MS;
				case Language.BVE: return Language.MS;
				case Language.BVL: return Language.SGN;
				case Language.BVU: return Language.MS;
				case Language.BZS: return Language.SGN;
				case Language.CDO: return Language.ZH;
				case Language.CDS: return Language.SGN;
				case Language.CJY: return Language.ZH;
				case Language.CMN: return Language.ZH;
				case Language.COA: return Language.MS;
				case Language.CPX: return Language.ZH;
				case Language.CSC: return Language.SGN;
				case Language.CSD: return Language.SGN;
				case Language.CSE: return Language.SGN;
				case Language.CSF: return Language.SGN;
				case Language.CSG: return Language.SGN;
				case Language.CSL: return Language.SGN;
				case Language.CSN: return Language.SGN;
				case Language.CSQ: return Language.SGN;
				case Language.CSR: return Language.SGN;
				case Language.CZH: return Language.ZH;
				case Language.CZO: return Language.ZH;
				case Language.DOQ: return Language.SGN;
				case Language.DSE: return Language.SGN;
				case Language.DSL: return Language.SGN;
				case Language.DUP: return Language.MS;
				case Language.ECS: return Language.SGN;
				case Language.ESL: return Language.SGN;
				case Language.ESN: return Language.SGN;
				case Language.ESO: return Language.SGN;
				case Language.ETH: return Language.SGN;
				case Language.FCS: return Language.SGN;
				case Language.FSE: return Language.SGN;
				case Language.FSL: return Language.SGN;
				case Language.FSS: return Language.SGN;
				case Language.GAN: return Language.ZH;
				case Language.GDS: return Language.SGN;
				case Language.GOM: return Language.KOK;
				case Language.GSE: return Language.SGN;
				case Language.GSG: return Language.SGN;
				case Language.GSM: return Language.SGN;
				case Language.GSS: return Language.SGN;
				case Language.GUS: return Language.SGN;
				case Language.HAB: return Language.SGN;
				case Language.HAF: return Language.SGN;
				case Language.HAK: return Language.ZH;
				case Language.HDS: return Language.SGN;
				case Language.HJI: return Language.MS;
				case Language.HKS: return Language.SGN;
				case Language.HOS: return Language.SGN;
				case Language.HPS: return Language.SGN;
				case Language.HSH: return Language.SGN;
				case Language.HSL: return Language.SGN;
				case Language.HSN: return Language.ZH;
				case Language.ICL: return Language.SGN;
				case Language.IKS: return Language.SGN;
				case Language.ILS: return Language.SGN;
				case Language.INL: return Language.SGN;
				case Language.INS: return Language.SGN;
				case Language.ISE: return Language.SGN;
				case Language.ISG: return Language.SGN;
				case Language.ISR: return Language.SGN;
				case Language.JAK: return Language.MS;
				case Language.JAX: return Language.MS;
				case Language.JCS: return Language.SGN;
				case Language.JHS: return Language.SGN;
				case Language.JLS: return Language.SGN;
				case Language.JOS: return Language.SGN;
				case Language.JSL: return Language.SGN;
				case Language.JUS: return Language.SGN;
				case Language.KGI: return Language.SGN;
				case Language.KNN: return Language.KOK;
				case Language.KVB: return Language.MS;
				case Language.KVK: return Language.SGN;
				case Language.KVR: return Language.MS;
				case Language.KXD: return Language.MS;
				case Language.LBS: return Language.SGN;
				case Language.LCE: return Language.MS;
				case Language.LCF: return Language.MS;
				case Language.LIW: return Language.MS;
				case Language.LLS: return Language.SGN;
				case Language.LSG: return Language.SGN;
				case Language.LSL: return Language.SGN;
				case Language.LSO: return Language.SGN;
				case Language.LSP: return Language.SGN;
				case Language.LST: return Language.SGN;
				case Language.LSY: return Language.SGN;
				case Language.LTG: return Language.LV;
				case Language.LVS: return Language.LV;
				case Language.LZH: return Language.ZH;
				case Language.MAX: return Language.MS;
				case Language.MDL: return Language.SGN;
				case Language.MEO: return Language.MS;
				case Language.MFA: return Language.MS;
				case Language.MFB: return Language.MS;
				case Language.MFS: return Language.SGN;
				case Language.MIN: return Language.MS;
				case Language.MNP: return Language.ZH;
				case Language.MQG: return Language.MS;
				case Language.MRE: return Language.SGN;
				case Language.MSD: return Language.SGN;
				case Language.MSI: return Language.MS;
				case Language.MSR: return Language.SGN;
				case Language.MUI: return Language.MS;
				case Language.MZC: return Language.SGN;
				case Language.MZG: return Language.SGN;
				case Language.MZY: return Language.SGN;
				case Language.NAN: return Language.ZH;
				case Language.NBS: return Language.SGN;
				case Language.NCS: return Language.SGN;
				case Language.NSI: return Language.SGN;
				case Language.NSL: return Language.SGN;
				case Language.NSP: return Language.SGN;
				case Language.NSR: return Language.SGN;
				case Language.NZS: return Language.SGN;
				case Language.OKL: return Language.SGN;
				case Language.ORN: return Language.MS;
				case Language.ORS: return Language.MS;
				case Language.PEL: return Language.MS;
				case Language.PGA: return Language.AR;
				case Language.PKS: return Language.SGN;
				case Language.PRL: return Language.SGN;
				case Language.PRZ: return Language.SGN;
				case Language.PSC: return Language.SGN;
				case Language.PSD: return Language.SGN;
				case Language.PSE: return Language.MS;
				case Language.PSG: return Language.SGN;
				case Language.PSL: return Language.SGN;
				case Language.PSO: return Language.SGN;
				case Language.PSP: return Language.SGN;
				case Language.PSR: return Language.SGN;
				case Language.PYS: return Language.SGN;
				case Language.RMS: return Language.SGN;
				case Language.RSI: return Language.SGN;
				case Language.RSL: return Language.SGN;
				case Language.SDL: return Language.SGN;
				case Language.SFB: return Language.SGN;
				case Language.SFS: return Language.SGN;
				case Language.SGG: return Language.SGN;
				case Language.SGX: return Language.SGN;
				case Language.SHU: return Language.AR;
				case Language.SLF: return Language.SGN;
				case Language.SLS: return Language.SGN;
				case Language.SQK: return Language.SGN;
				case Language.SQS: return Language.SGN;
				case Language.SSH: return Language.AR;
				case Language.SSP: return Language.SGN;
				case Language.SSR: return Language.SGN;
				case Language.SVK: return Language.SGN;
				case Language.SWC: return Language.SW;
				case Language.SWH: return Language.SW;
				case Language.SWL: return Language.SGN;
				case Language.SYY: return Language.SGN;
				case Language.TMW: return Language.MS;
				case Language.TSE: return Language.SGN;
				case Language.TSM: return Language.SGN;
				case Language.TSQ: return Language.SGN;
				case Language.TSS: return Language.SGN;
				case Language.TSY: return Language.SGN;
				case Language.TZA: return Language.SGN;
				case Language.UGN: return Language.SGN;
				case Language.UGY: return Language.SGN;
				case Language.UKL: return Language.SGN;
				case Language.UKS: return Language.SGN;
				case Language.URK: return Language.MS;
				case Language.UZN: return Language.UZ;
				case Language.UZS: return Language.UZ;
				case Language.VGT: return Language.SGN;
				case Language.VKK: return Language.MS;
				case Language.VKT: return Language.MS;
				case Language.VSI: return Language.SGN;
				case Language.VSL: return Language.SGN;
				case Language.VSV: return Language.SGN;
				case Language.WUU: return Language.ZH;
				case Language.XKI: return Language.SGN;
				case Language.XML: return Language.SGN;
				case Language.XMM: return Language.MS;
				case Language.XMS: return Language.SGN;
				case Language.YGS: return Language.SGN;
				case Language.YHS: return Language.SGN;
				case Language.YSL: return Language.SGN;
				case Language.YUE: return Language.ZH;
				case Language.ZIB: return Language.SGN;
				case Language.ZLM: return Language.MS;
				case Language.ZMI: return Language.MS;
				case Language.ZSL: return Language.SGN;
				case Language.ZSM: return Language.MS;
				default:
					return null;
			}
		}

		public static Language? TryParseFromExtLanguage(this string text, Language prefix)
		{
			switch(prefix)
			{
				case Language.AR:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "aao": return Language.AAO;
						case "abh": return Language.ABH;
						case "abv": return Language.ABV;
						case "acm": return Language.ACM;
						case "acq": return Language.ACQ;
						case "acw": return Language.ACW;
						case "acx": return Language.ACX;
						case "acy": return Language.ACY;
						case "adf": return Language.ADF;
						case "aeb": return Language.AEB;
						case "aec": return Language.AEC;
						case "afb": return Language.AFB;
						case "ajp": return Language.AJP;
						case "apc": return Language.APC;
						case "apd": return Language.APD;
						case "arb": return Language.ARB;
						case "arq": return Language.ARQ;
						case "ars": return Language.ARS;
						case "ary": return Language.ARY;
						case "arz": return Language.ARZ;
						case "auz": return Language.AUZ;
						case "avl": return Language.AVL;
						case "ayh": return Language.AYH;
						case "ayl": return Language.AYL;
						case "ayn": return Language.AYN;
						case "ayp": return Language.AYP;
						case "bbz": return Language.BBZ;
						case "pga": return Language.PGA;
						case "shu": return Language.SHU;
						case "ssh": return Language.SSH;
						default: return null;
					}
				case Language.SGN:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "ads": return Language.ADS;
						case "aed": return Language.AED;
						case "aen": return Language.AEN;
						case "afg": return Language.AFG;
						case "ase": return Language.ASE;
						case "asf": return Language.ASF;
						case "asp": return Language.ASP;
						case "asq": return Language.ASQ;
						case "asw": return Language.ASW;
						case "bfi": return Language.BFI;
						case "bfk": return Language.BFK;
						case "bog": return Language.BOG;
						case "bqn": return Language.BQN;
						case "bqy": return Language.BQY;
						case "bvl": return Language.BVL;
						case "bzs": return Language.BZS;
						case "cds": return Language.CDS;
						case "csc": return Language.CSC;
						case "csd": return Language.CSD;
						case "cse": return Language.CSE;
						case "csf": return Language.CSF;
						case "csg": return Language.CSG;
						case "csl": return Language.CSL;
						case "csn": return Language.CSN;
						case "csq": return Language.CSQ;
						case "csr": return Language.CSR;
						case "doq": return Language.DOQ;
						case "dse": return Language.DSE;
						case "dsl": return Language.DSL;
						case "ecs": return Language.ECS;
						case "esl": return Language.ESL;
						case "esn": return Language.ESN;
						case "eso": return Language.ESO;
						case "eth": return Language.ETH;
						case "fcs": return Language.FCS;
						case "fse": return Language.FSE;
						case "fsl": return Language.FSL;
						case "fss": return Language.FSS;
						case "gds": return Language.GDS;
						case "gse": return Language.GSE;
						case "gsg": return Language.GSG;
						case "gsm": return Language.GSM;
						case "gss": return Language.GSS;
						case "gus": return Language.GUS;
						case "hab": return Language.HAB;
						case "haf": return Language.HAF;
						case "hds": return Language.HDS;
						case "hks": return Language.HKS;
						case "hos": return Language.HOS;
						case "hps": return Language.HPS;
						case "hsh": return Language.HSH;
						case "hsl": return Language.HSL;
						case "icl": return Language.ICL;
						case "iks": return Language.IKS;
						case "ils": return Language.ILS;
						case "inl": return Language.INL;
						case "ins": return Language.INS;
						case "ise": return Language.ISE;
						case "isg": return Language.ISG;
						case "isr": return Language.ISR;
						case "jcs": return Language.JCS;
						case "jhs": return Language.JHS;
						case "jls": return Language.JLS;
						case "jos": return Language.JOS;
						case "jsl": return Language.JSL;
						case "jus": return Language.JUS;
						case "kgi": return Language.KGI;
						case "kvk": return Language.KVK;
						case "lbs": return Language.LBS;
						case "lls": return Language.LLS;
						case "lsg": return Language.LSG;
						case "lsl": return Language.LSL;
						case "lso": return Language.LSO;
						case "lsp": return Language.LSP;
						case "lst": return Language.LST;
						case "lsy": return Language.LSY;
						case "mdl": return Language.MDL;
						case "mfs": return Language.MFS;
						case "mre": return Language.MRE;
						case "msd": return Language.MSD;
						case "msr": return Language.MSR;
						case "mzc": return Language.MZC;
						case "mzg": return Language.MZG;
						case "mzy": return Language.MZY;
						case "nbs": return Language.NBS;
						case "ncs": return Language.NCS;
						case "nsi": return Language.NSI;
						case "nsl": return Language.NSL;
						case "nsp": return Language.NSP;
						case "nsr": return Language.NSR;
						case "nzs": return Language.NZS;
						case "okl": return Language.OKL;
						case "pks": return Language.PKS;
						case "prl": return Language.PRL;
						case "prz": return Language.PRZ;
						case "psc": return Language.PSC;
						case "psd": return Language.PSD;
						case "psg": return Language.PSG;
						case "psl": return Language.PSL;
						case "pso": return Language.PSO;
						case "psp": return Language.PSP;
						case "psr": return Language.PSR;
						case "pys": return Language.PYS;
						case "rms": return Language.RMS;
						case "rsi": return Language.RSI;
						case "rsl": return Language.RSL;
						case "sdl": return Language.SDL;
						case "sfb": return Language.SFB;
						case "sfs": return Language.SFS;
						case "sgg": return Language.SGG;
						case "sgx": return Language.SGX;
						case "slf": return Language.SLF;
						case "sls": return Language.SLS;
						case "sqk": return Language.SQK;
						case "sqs": return Language.SQS;
						case "ssp": return Language.SSP;
						case "ssr": return Language.SSR;
						case "svk": return Language.SVK;
						case "swl": return Language.SWL;
						case "syy": return Language.SYY;
						case "tse": return Language.TSE;
						case "tsm": return Language.TSM;
						case "tsq": return Language.TSQ;
						case "tss": return Language.TSS;
						case "tsy": return Language.TSY;
						case "tza": return Language.TZA;
						case "ugn": return Language.UGN;
						case "ugy": return Language.UGY;
						case "ukl": return Language.UKL;
						case "uks": return Language.UKS;
						case "vgt": return Language.VGT;
						case "vsi": return Language.VSI;
						case "vsl": return Language.VSL;
						case "vsv": return Language.VSV;
						case "xki": return Language.XKI;
						case "xml": return Language.XML;
						case "xms": return Language.XMS;
						case "ygs": return Language.YGS;
						case "yhs": return Language.YHS;
						case "ysl": return Language.YSL;
						case "zib": return Language.ZIB;
						case "zsl": return Language.ZSL;
						default: return null;
					}
				case Language.MS:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "bjn": return Language.BJN;
						case "btj": return Language.BTJ;
						case "bve": return Language.BVE;
						case "bvu": return Language.BVU;
						case "coa": return Language.COA;
						case "dup": return Language.DUP;
						case "hji": return Language.HJI;
						case "jak": return Language.JAK;
						case "jax": return Language.JAX;
						case "kvb": return Language.KVB;
						case "kvr": return Language.KVR;
						case "kxd": return Language.KXD;
						case "lce": return Language.LCE;
						case "lcf": return Language.LCF;
						case "liw": return Language.LIW;
						case "max": return Language.MAX;
						case "meo": return Language.MEO;
						case "mfa": return Language.MFA;
						case "mfb": return Language.MFB;
						case "min": return Language.MIN;
						case "mqg": return Language.MQG;
						case "msi": return Language.MSI;
						case "mui": return Language.MUI;
						case "orn": return Language.ORN;
						case "ors": return Language.ORS;
						case "pel": return Language.PEL;
						case "pse": return Language.PSE;
						case "tmw": return Language.TMW;
						case "urk": return Language.URK;
						case "vkk": return Language.VKK;
						case "vkt": return Language.VKT;
						case "xmm": return Language.XMM;
						case "zlm": return Language.ZLM;
						case "zmi": return Language.ZMI;
						case "zsm": return Language.ZSM;
						default: return null;
					}
				case Language.ZH:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "cdo": return Language.CDO;
						case "cjy": return Language.CJY;
						case "cmn": return Language.CMN;
						case "cpx": return Language.CPX;
						case "czh": return Language.CZH;
						case "czo": return Language.CZO;
						case "gan": return Language.GAN;
						case "hak": return Language.HAK;
						case "hsn": return Language.HSN;
						case "lzh": return Language.LZH;
						case "mnp": return Language.MNP;
						case "nan": return Language.NAN;
						case "wuu": return Language.WUU;
						case "yue": return Language.YUE;
						default: return null;
					}
				case Language.KOK:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "gom": return Language.GOM;
						case "knn": return Language.KNN;
						default: return null;
					}
				case Language.LV:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "ltg": return Language.LTG;
						case "lvs": return Language.LVS;
						default: return null;
					}
				case Language.SW:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "swc": return Language.SWC;
						case "swh": return Language.SWH;
						default: return null;
					}
				case Language.UZ:
					switch (text.ToLower(CultureInfo.InvariantCulture))
					{
						case "uzn": return Language.UZN;
						case "uzs": return Language.UZS;
						default: return null;
					}
				default:
					return null;
			}
		}
	}
}
