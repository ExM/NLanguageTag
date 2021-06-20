using System;
using System.Globalization;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Region
	{

		internal static Region? TryParse(StringSpan span)
		{
			switch(span.Length)
			{
				case 2: return tryParse_L2(span);
				case 3: return tryParse_L3(span);
				default: return null;
			}
		}
		
		private static Region? tryParse_L2(StringSpan span)
		{
			if ("qm" <= span && span <= "qz") return forPrivateUse(span.AsText());
			if ("xa" <= span && span <= "xz") return forPrivateUse(span.AsText());
		
			switch(span[0])
			{
				case 'a': return tryParse_L2_a(span);
				case 'b': return tryParse_L2_b(span);
				case 'c': return tryParse_L2_c(span);
				case 'd': return tryParse_L2_d(span);
				case 'e': return tryParse_L2_e(span);
				case 'f': return tryParse_L2_f(span);
				case 'g': return tryParse_L2_g(span);
				case 'h': return tryParse_L2_h(span);
				case 'i': return tryParse_L2_i(span);
				case 'j': return tryParse_L2_j(span);
				case 'k': return tryParse_L2_k(span);
				case 'l': return tryParse_L2_l(span);
				case 'm': return tryParse_L2_m(span);
				case 'n': return tryParse_L2_n(span);
				case 'o': return tryParse_L2_o(span);
				case 'p': return tryParse_L2_p(span);
				case 'q': return tryParse_L2_q(span);
				case 'r': return tryParse_L2_r(span);
				case 's': return tryParse_L2_s(span);
				case 't': return tryParse_L2_t(span);
				case 'u': return tryParse_L2_u(span);
				case 'v': return tryParse_L2_v(span);
				case 'w': return tryParse_L2_w(span);
				case 'y': return tryParse_L2_y(span);
				case 'z': return tryParse_L2_z(span);
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return ACCache.Instance;
				case 'd': return ADCache.Instance;
				case 'e': return AECache.Instance;
				case 'f': return AFCache.Instance;
				case 'g': return AGCache.Instance;
				case 'i': return AICache.Instance;
				case 'l': return ALCache.Instance;
				case 'm': return AMCache.Instance;
				case 'n': return ANCache.Instance;
				case 'o': return AOCache.Instance;
				case 'q': return AQCache.Instance;
				case 'r': return ARCache.Instance;
				case 's': return ASCache.Instance;
				case 't': return ATCache.Instance;
				case 'u': return AUCache.Instance;
				case 'w': return AWCache.Instance;
				case 'x': return AXCache.Instance;
				case 'z': return AZCache.Instance;
				case 'a': return forPrivateUse("aa");
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return BACache.Instance;
				case 'b': return BBCache.Instance;
				case 'd': return BDCache.Instance;
				case 'e': return BECache.Instance;
				case 'f': return BFCache.Instance;
				case 'g': return BGCache.Instance;
				case 'h': return BHCache.Instance;
				case 'i': return BICache.Instance;
				case 'j': return BJCache.Instance;
				case 'l': return BLCache.Instance;
				case 'm': return BMCache.Instance;
				case 'n': return BNCache.Instance;
				case 'o': return BOCache.Instance;
				case 'q': return BQCache.Instance;
				case 'r': return BRCache.Instance;
				case 's': return BSCache.Instance;
				case 't': return BTCache.Instance;
				case 'u': return MMCache.Instance;
				case 'v': return BVCache.Instance;
				case 'w': return BWCache.Instance;
				case 'y': return BYCache.Instance;
				case 'z': return BZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return CACache.Instance;
				case 'c': return CCCache.Instance;
				case 'd': return CDCache.Instance;
				case 'f': return CFCache.Instance;
				case 'g': return CGCache.Instance;
				case 'h': return CHCache.Instance;
				case 'i': return CICache.Instance;
				case 'k': return CKCache.Instance;
				case 'l': return CLCache.Instance;
				case 'm': return CMCache.Instance;
				case 'n': return CNCache.Instance;
				case 'o': return COCache.Instance;
				case 'p': return CPCache.Instance;
				case 'r': return CRCache.Instance;
				case 's': return CSCache.Instance;
				case 'u': return CUCache.Instance;
				case 'v': return CVCache.Instance;
				case 'w': return CWCache.Instance;
				case 'x': return CXCache.Instance;
				case 'y': return CYCache.Instance;
				case 'z': return CZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return DECache.Instance;
				case 'e': return DECache.Instance;
				case 'g': return DGCache.Instance;
				case 'j': return DJCache.Instance;
				case 'k': return DKCache.Instance;
				case 'm': return DMCache.Instance;
				case 'o': return DOCache.Instance;
				case 'z': return DZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return EACache.Instance;
				case 'c': return ECCache.Instance;
				case 'e': return EECache.Instance;
				case 'g': return EGCache.Instance;
				case 'h': return EHCache.Instance;
				case 'r': return ERCache.Instance;
				case 's': return ESCache.Instance;
				case 't': return ETCache.Instance;
				case 'u': return EUCache.Instance;
				case 'z': return EZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return FICache.Instance;
				case 'j': return FJCache.Instance;
				case 'k': return FKCache.Instance;
				case 'm': return FMCache.Instance;
				case 'o': return FOCache.Instance;
				case 'r': return FRCache.Instance;
				case 'x': return FRCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return GACache.Instance;
				case 'b': return GBCache.Instance;
				case 'd': return GDCache.Instance;
				case 'e': return GECache.Instance;
				case 'f': return GFCache.Instance;
				case 'g': return GGCache.Instance;
				case 'h': return GHCache.Instance;
				case 'i': return GICache.Instance;
				case 'l': return GLCache.Instance;
				case 'm': return GMCache.Instance;
				case 'n': return GNCache.Instance;
				case 'p': return GPCache.Instance;
				case 'q': return GQCache.Instance;
				case 'r': return GRCache.Instance;
				case 's': return GSCache.Instance;
				case 't': return GTCache.Instance;
				case 'u': return GUCache.Instance;
				case 'w': return GWCache.Instance;
				case 'y': return GYCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'k': return HKCache.Instance;
				case 'm': return HMCache.Instance;
				case 'n': return HNCache.Instance;
				case 'r': return HRCache.Instance;
				case 't': return HTCache.Instance;
				case 'u': return HUCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return ICCache.Instance;
				case 'd': return IDCache.Instance;
				case 'e': return IECache.Instance;
				case 'l': return ILCache.Instance;
				case 'm': return IMCache.Instance;
				case 'n': return INCache.Instance;
				case 'o': return IOCache.Instance;
				case 'q': return IQCache.Instance;
				case 'r': return IRCache.Instance;
				case 's': return ISCache.Instance;
				case 't': return ITCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return JECache.Instance;
				case 'm': return JMCache.Instance;
				case 'o': return JOCache.Instance;
				case 'p': return JPCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return KECache.Instance;
				case 'g': return KGCache.Instance;
				case 'h': return KHCache.Instance;
				case 'i': return KICache.Instance;
				case 'm': return KMCache.Instance;
				case 'n': return KNCache.Instance;
				case 'p': return KPCache.Instance;
				case 'r': return KRCache.Instance;
				case 'w': return KWCache.Instance;
				case 'y': return KYCache.Instance;
				case 'z': return KZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return LACache.Instance;
				case 'b': return LBCache.Instance;
				case 'c': return LCCache.Instance;
				case 'i': return LICache.Instance;
				case 'k': return LKCache.Instance;
				case 'r': return LRCache.Instance;
				case 's': return LSCache.Instance;
				case 't': return LTCache.Instance;
				case 'u': return LUCache.Instance;
				case 'v': return LVCache.Instance;
				case 'y': return LYCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return MACache.Instance;
				case 'c': return MCCache.Instance;
				case 'd': return MDCache.Instance;
				case 'e': return MECache.Instance;
				case 'f': return MFCache.Instance;
				case 'g': return MGCache.Instance;
				case 'h': return MHCache.Instance;
				case 'k': return MKCache.Instance;
				case 'l': return MLCache.Instance;
				case 'm': return MMCache.Instance;
				case 'n': return MNCache.Instance;
				case 'o': return MOCache.Instance;
				case 'p': return MPCache.Instance;
				case 'q': return MQCache.Instance;
				case 'r': return MRCache.Instance;
				case 's': return MSCache.Instance;
				case 't': return MTCache.Instance;
				case 'u': return MUCache.Instance;
				case 'v': return MVCache.Instance;
				case 'w': return MWCache.Instance;
				case 'x': return MXCache.Instance;
				case 'y': return MYCache.Instance;
				case 'z': return MZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return NACache.Instance;
				case 'c': return NCCache.Instance;
				case 'e': return NECache.Instance;
				case 'f': return NFCache.Instance;
				case 'g': return NGCache.Instance;
				case 'i': return NICache.Instance;
				case 'l': return NLCache.Instance;
				case 'o': return NOCache.Instance;
				case 'p': return NPCache.Instance;
				case 'r': return NRCache.Instance;
				case 't': return NTCache.Instance;
				case 'u': return NUCache.Instance;
				case 'z': return NZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'm')
				return OMCache.Instance;
			return null;
		}
		
		private static Region? tryParse_L2_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return PACache.Instance;
				case 'e': return PECache.Instance;
				case 'f': return PFCache.Instance;
				case 'g': return PGCache.Instance;
				case 'h': return PHCache.Instance;
				case 'k': return PKCache.Instance;
				case 'l': return PLCache.Instance;
				case 'm': return PMCache.Instance;
				case 'n': return PNCache.Instance;
				case 'r': return PRCache.Instance;
				case 's': return PSCache.Instance;
				case 't': return PTCache.Instance;
				case 'w': return PWCache.Instance;
				case 'y': return PYCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_q(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return QACache.Instance;
			return null;
		}
		
		private static Region? tryParse_L2_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return RECache.Instance;
				case 'o': return ROCache.Instance;
				case 's': return RSCache.Instance;
				case 'u': return RUCache.Instance;
				case 'w': return RWCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return SACache.Instance;
				case 'b': return SBCache.Instance;
				case 'c': return SCCache.Instance;
				case 'd': return SDCache.Instance;
				case 'e': return SECache.Instance;
				case 'g': return SGCache.Instance;
				case 'h': return SHCache.Instance;
				case 'i': return SICache.Instance;
				case 'j': return SJCache.Instance;
				case 'k': return SKCache.Instance;
				case 'l': return SLCache.Instance;
				case 'm': return SMCache.Instance;
				case 'n': return SNCache.Instance;
				case 'o': return SOCache.Instance;
				case 'r': return SRCache.Instance;
				case 's': return SSCache.Instance;
				case 't': return STCache.Instance;
				case 'u': return SUCache.Instance;
				case 'v': return SVCache.Instance;
				case 'x': return SXCache.Instance;
				case 'y': return SYCache.Instance;
				case 'z': return SZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return TACache.Instance;
				case 'c': return TCCache.Instance;
				case 'd': return TDCache.Instance;
				case 'f': return TFCache.Instance;
				case 'g': return TGCache.Instance;
				case 'h': return THCache.Instance;
				case 'j': return TJCache.Instance;
				case 'k': return TKCache.Instance;
				case 'l': return TLCache.Instance;
				case 'm': return TMCache.Instance;
				case 'n': return TNCache.Instance;
				case 'o': return TOCache.Instance;
				case 'p': return TLCache.Instance;
				case 'r': return TRCache.Instance;
				case 't': return TTCache.Instance;
				case 'v': return TVCache.Instance;
				case 'w': return TWCache.Instance;
				case 'z': return TZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return UACache.Instance;
				case 'g': return UGCache.Instance;
				case 'm': return UMCache.Instance;
				case 'n': return UNCache.Instance;
				case 's': return USCache.Instance;
				case 'y': return UYCache.Instance;
				case 'z': return UZCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return VACache.Instance;
				case 'c': return VCCache.Instance;
				case 'e': return VECache.Instance;
				case 'g': return VGCache.Instance;
				case 'i': return VICache.Instance;
				case 'n': return VNCache.Instance;
				case 'u': return VUCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'f': return WFCache.Instance;
				case 's': return WSCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return YECache.Instance;
				case 'e': return YECache.Instance;
				case 't': return YTCache.Instance;
				case 'u': return YUCache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return ZACache.Instance;
				case 'm': return ZMCache.Instance;
				case 'r': return CDCache.Instance;
				case 'w': return ZWCache.Instance;
				case 'z': return forPrivateUse("zz");
				default: return null;
			}
		}
		
		private static Region? tryParse_L3(StringSpan span)
		{
			switch(span[0])
			{
				case '0': return tryParse_L3_0(span);
				case '1': return tryParse_L3_1(span);
				case '2': return tryParse_L3_2(span);
				case '4': return tryParse_L3_4(span);
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_0(StringSpan span)
		{
			switch(span[1])
			{
				case '0': return tryParse_L3_00(span);
				case '1': return tryParse_L3_01(span);
				case '2': return tryParse_L3_02(span);
				case '3': return tryParse_L3_03(span);
				case '5': return tryParse_L3_05(span);
				case '6': return tryParse_L3_06(span);
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_00(StringSpan span)
		{
			switch(span[2])
			{
				case '1': return M001Cache.Instance;
				case '2': return M002Cache.Instance;
				case '3': return M003Cache.Instance;
				case '5': return M005Cache.Instance;
				case '9': return M009Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_01(StringSpan span)
		{
			switch(span[2])
			{
				case '1': return M011Cache.Instance;
				case '3': return M013Cache.Instance;
				case '4': return M014Cache.Instance;
				case '5': return M015Cache.Instance;
				case '7': return M017Cache.Instance;
				case '8': return M018Cache.Instance;
				case '9': return M019Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_02(StringSpan span)
		{
			switch(span[2])
			{
				case '1': return M021Cache.Instance;
				case '9': return M029Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_03(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return M030Cache.Instance;
				case '4': return M034Cache.Instance;
				case '5': return M035Cache.Instance;
				case '9': return M039Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_05(StringSpan span)
		{
			switch(span[2])
			{
				case '3': return M053Cache.Instance;
				case '4': return M054Cache.Instance;
				case '7': return M057Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_06(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '1')
				return M061Cache.Instance;
			return null;
		}
		
		private static Region? tryParse_L3_1(StringSpan span)
		{
			switch(span[1])
			{
				case '4': return tryParse_L3_14(span);
				case '5': return tryParse_L3_15(span);
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_14(StringSpan span)
		{
			switch(span[2])
			{
				case '2': return M142Cache.Instance;
				case '3': return M143Cache.Instance;
				case '5': return M145Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_15(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return M150Cache.Instance;
				case '1': return M151Cache.Instance;
				case '4': return M154Cache.Instance;
				case '5': return M155Cache.Instance;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_2(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == '0')
				return tryParse_L3_20(span);
			return null;
		}
		
		private static Region? tryParse_L3_20(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '2')
				return M202Cache.Instance;
			return null;
		}
		
		private static Region? tryParse_L3_4(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == '1')
				return tryParse_L3_41(span);
			return null;
		}
		
		private static Region? tryParse_L3_41(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '9')
				return M419Cache.Instance;
			return null;
		}
	}
}
