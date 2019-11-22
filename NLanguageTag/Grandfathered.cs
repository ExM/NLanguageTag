using System;
using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	internal static class Grandfathered
	{
		internal static string GetPreferredValue(string text)
		{
			switch(text.ToLower())
			{
				case "art-lojban": return "jbo";
				case "en-gb-oed": return "en-GB-oxendict";
				case "i-ami": return "ami";
				case "i-bnn": return "bnn";
				case "i-hak": return "hak";
				case "i-klingon": return "tlh";
				case "i-lux": return "lb";
				case "i-navajo": return "nv";
				case "i-pwn": return "pwn";
				case "i-tao": return "tao";
				case "i-tay": return "tay";
				case "i-tsu": return "tsu";
				case "no-bok": return "nb";
				case "no-nyn": return "nn";
				case "sgn-be-fr": return "sfb";
				case "sgn-be-nl": return "vgt";
				case "sgn-ch-de": return "sgg";
				case "zh-guoyu": return "cmn";
				case "zh-hakka": return "hak";
				case "zh-min-nan": return "nan";
				case "zh-xiang": return "hsn";
				case "cel-gaulish": throw new NotSupportedException("grandfathered code '" + text + "' not supported");
				case "i-default": throw new NotSupportedException("grandfathered code '" + text + "' not supported");
				case "i-enochian": throw new NotSupportedException("grandfathered code '" + text + "' not supported");
				case "i-mingo": throw new NotSupportedException("grandfathered code '" + text + "' not supported");
				case "zh-min": throw new NotSupportedException("grandfathered code '" + text + "' not supported");
				case "zh-chs": return "zh-Hans";
				case "zh-cht": return "zh-Hant";
				default: return null;
			}
		}
	}
}
