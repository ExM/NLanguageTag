using System;
using System.Globalization;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Language
	{

		internal static Language? TryParse(StringSpan span)
		{
			switch(span.Length)
			{
				case 2: return tryParse_L2(span);
				case 3: return tryParse_L3(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L2(StringSpan span)
		{
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
				case 'x': return tryParse_L2_x(span);
				case 'y': return tryParse_L2_y(span);
				case 'z': return tryParse_L2_z(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return AACache.Instance;
				case 'b': return ABCache.Instance;
				case 'e': return AECache.Instance;
				case 'f': return AFCache.Instance;
				case 'k': return AKCache.Instance;
				case 'm': return AMCache.Instance;
				case 'n': return ANCache.Instance;
				case 'r': return ARCache.Instance;
				case 's': return ASCache.Instance;
				case 'v': return AVCache.Instance;
				case 'y': return AYCache.Instance;
				case 'z': return AZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return BACache.Instance;
				case 'e': return BECache.Instance;
				case 'g': return BGCache.Instance;
				case 'h': return BHCache.Instance;
				case 'i': return BICache.Instance;
				case 'm': return BMCache.Instance;
				case 'n': return BNCache.Instance;
				case 'o': return BOCache.Instance;
				case 'r': return BRCache.Instance;
				case 's': return BSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return CACache.Instance;
				case 'e': return CECache.Instance;
				case 'h': return CHCache.Instance;
				case 'o': return COCache.Instance;
				case 'r': return CRCache.Instance;
				case 's': return CSCache.Instance;
				case 'u': return CUCache.Instance;
				case 'v': return CVCache.Instance;
				case 'y': return CYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return DACache.Instance;
				case 'e': return DECache.Instance;
				case 'v': return DVCache.Instance;
				case 'z': return DZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return EECache.Instance;
				case 'l': return ELCache.Instance;
				case 'n': return ENCache.Instance;
				case 'o': return EOCache.Instance;
				case 's': return ESCache.Instance;
				case 't': return ETCache.Instance;
				case 'u': return EUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return FACache.Instance;
				case 'f': return FFCache.Instance;
				case 'i': return FICache.Instance;
				case 'j': return FJCache.Instance;
				case 'o': return FOCache.Instance;
				case 'r': return FRCache.Instance;
				case 'y': return FYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return GACache.Instance;
				case 'd': return GDCache.Instance;
				case 'l': return GLCache.Instance;
				case 'n': return GNCache.Instance;
				case 'u': return GUCache.Instance;
				case 'v': return GVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return HACache.Instance;
				case 'e': return HECache.Instance;
				case 'i': return HICache.Instance;
				case 'o': return HOCache.Instance;
				case 'r': return HRCache.Instance;
				case 't': return HTCache.Instance;
				case 'u': return HUCache.Instance;
				case 'y': return HYCache.Instance;
				case 'z': return HZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return IACache.Instance;
				case 'd': return IDCache.Instance;
				case 'e': return IECache.Instance;
				case 'g': return IGCache.Instance;
				case 'i': return IICache.Instance;
				case 'k': return IKCache.Instance;
				case 'n': return IDCache.Instance;
				case 'o': return IOCache.Instance;
				case 's': return ISCache.Instance;
				case 't': return ITCache.Instance;
				case 'u': return IUCache.Instance;
				case 'w': return HECache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return JACache.Instance;
				case 'i': return YICache.Instance;
				case 'v': return JVCache.Instance;
				case 'w': return JVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return KACache.Instance;
				case 'g': return KGCache.Instance;
				case 'i': return KICache.Instance;
				case 'j': return KJCache.Instance;
				case 'k': return KKCache.Instance;
				case 'l': return KLCache.Instance;
				case 'm': return KMCache.Instance;
				case 'n': return KNCache.Instance;
				case 'o': return KOCache.Instance;
				case 'r': return KRCache.Instance;
				case 's': return KSCache.Instance;
				case 'u': return KUCache.Instance;
				case 'v': return KVCache.Instance;
				case 'w': return KWCache.Instance;
				case 'y': return KYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return LACache.Instance;
				case 'b': return LBCache.Instance;
				case 'g': return LGCache.Instance;
				case 'i': return LICache.Instance;
				case 'n': return LNCache.Instance;
				case 'o': return LOCache.Instance;
				case 't': return LTCache.Instance;
				case 'u': return LUCache.Instance;
				case 'v': return LVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return MGCache.Instance;
				case 'h': return MHCache.Instance;
				case 'i': return MICache.Instance;
				case 'k': return MKCache.Instance;
				case 'l': return MLCache.Instance;
				case 'n': return MNCache.Instance;
				case 'o': return ROCache.Instance;
				case 'r': return MRCache.Instance;
				case 's': return MSCache.Instance;
				case 't': return MTCache.Instance;
				case 'y': return MYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return NACache.Instance;
				case 'b': return NBCache.Instance;
				case 'd': return NDCache.Instance;
				case 'e': return NECache.Instance;
				case 'g': return NGCache.Instance;
				case 'l': return NLCache.Instance;
				case 'n': return NNCache.Instance;
				case 'o': return NOCache.Instance;
				case 'r': return NRCache.Instance;
				case 'v': return NVCache.Instance;
				case 'y': return NYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_o(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return OCCache.Instance;
				case 'j': return OJCache.Instance;
				case 'm': return OMCache.Instance;
				case 'r': return ORCache.Instance;
				case 's': return OSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return PACache.Instance;
				case 'i': return PICache.Instance;
				case 'l': return PLCache.Instance;
				case 's': return PSCache.Instance;
				case 't': return PTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_q(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return QUCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L2_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'm': return RMCache.Instance;
				case 'n': return RNCache.Instance;
				case 'o': return ROCache.Instance;
				case 'u': return RUCache.Instance;
				case 'w': return RWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return SACache.Instance;
				case 'c': return SCCache.Instance;
				case 'd': return SDCache.Instance;
				case 'e': return SECache.Instance;
				case 'g': return SGCache.Instance;
				case 'h': return SHCache.Instance;
				case 'i': return SICache.Instance;
				case 'k': return SKCache.Instance;
				case 'l': return SLCache.Instance;
				case 'm': return SMCache.Instance;
				case 'n': return SNCache.Instance;
				case 'o': return SOCache.Instance;
				case 'q': return SQCache.Instance;
				case 'r': return SRCache.Instance;
				case 's': return SSCache.Instance;
				case 't': return STCache.Instance;
				case 'u': return SUCache.Instance;
				case 'v': return SVCache.Instance;
				case 'w': return SWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return TACache.Instance;
				case 'e': return TECache.Instance;
				case 'g': return TGCache.Instance;
				case 'h': return THCache.Instance;
				case 'i': return TICache.Instance;
				case 'k': return TKCache.Instance;
				case 'l': return TLCache.Instance;
				case 'n': return TNCache.Instance;
				case 'o': return TOCache.Instance;
				case 'r': return TRCache.Instance;
				case 's': return TSCache.Instance;
				case 't': return TTCache.Instance;
				case 'w': return TWCache.Instance;
				case 'y': return TYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return UGCache.Instance;
				case 'k': return UKCache.Instance;
				case 'r': return URCache.Instance;
				case 'z': return UZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return VECache.Instance;
				case 'i': return VICache.Instance;
				case 'o': return VOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return WACache.Instance;
				case 'o': return WOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_x(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'h')
				return XHCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L2_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return YICache.Instance;
				case 'o': return YOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return ZACache.Instance;
				case 'h': return ZHCache.Instance;
				case 'u': return ZUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3(StringSpan span)
		{
			if ("qaa" <= span && span <= "qtz") return forPrivateUse(span.AsText());
		
			switch(span[0])
			{
				case 'a': return tryParse_L3_a(span);
				case 'b': return tryParse_L3_b(span);
				case 'c': return tryParse_L3_c(span);
				case 'd': return tryParse_L3_d(span);
				case 'e': return tryParse_L3_e(span);
				case 'f': return tryParse_L3_f(span);
				case 'g': return tryParse_L3_g(span);
				case 'h': return tryParse_L3_h(span);
				case 'i': return tryParse_L3_i(span);
				case 'j': return tryParse_L3_j(span);
				case 'k': return tryParse_L3_k(span);
				case 'l': return tryParse_L3_l(span);
				case 'm': return tryParse_L3_m(span);
				case 'n': return tryParse_L3_n(span);
				case 'o': return tryParse_L3_o(span);
				case 'p': return tryParse_L3_p(span);
				case 'q': return tryParse_L3_q(span);
				case 'r': return tryParse_L3_r(span);
				case 's': return tryParse_L3_s(span);
				case 't': return tryParse_L3_t(span);
				case 'u': return tryParse_L3_u(span);
				case 'v': return tryParse_L3_v(span);
				case 'w': return tryParse_L3_w(span);
				case 'x': return tryParse_L3_x(span);
				case 'y': return tryParse_L3_y(span);
				case 'z': return tryParse_L3_z(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_aa(span);
				case 'b': return tryParse_L3_ab(span);
				case 'c': return tryParse_L3_ac(span);
				case 'd': return tryParse_L3_ad(span);
				case 'e': return tryParse_L3_ae(span);
				case 'f': return tryParse_L3_af(span);
				case 'g': return tryParse_L3_ag(span);
				case 'h': return tryParse_L3_ah(span);
				case 'i': return tryParse_L3_ai(span);
				case 'j': return tryParse_L3_aj(span);
				case 'k': return tryParse_L3_ak(span);
				case 'l': return tryParse_L3_al(span);
				case 'm': return tryParse_L3_am(span);
				case 'n': return tryParse_L3_an(span);
				case 'o': return tryParse_L3_ao(span);
				case 'p': return tryParse_L3_ap(span);
				case 'q': return tryParse_L3_aq(span);
				case 'r': return tryParse_L3_ar(span);
				case 's': return tryParse_L3_as(span);
				case 't': return tryParse_L3_at(span);
				case 'u': return tryParse_L3_au(span);
				case 'v': return tryParse_L3_av(span);
				case 'w': return tryParse_L3_aw(span);
				case 'x': return tryParse_L3_ax(span);
				case 'y': return tryParse_L3_ay(span);
				case 'z': return tryParse_L3_az(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AAACache.Instance;
				case 'b': return AABCache.Instance;
				case 'c': return AACCache.Instance;
				case 'd': return AADCache.Instance;
				case 'e': return AAECache.Instance;
				case 'f': return AAFCache.Instance;
				case 'g': return AAGCache.Instance;
				case 'h': return AAHCache.Instance;
				case 'i': return AAICache.Instance;
				case 'k': return AAKCache.Instance;
				case 'l': return AALCache.Instance;
				case 'm': return AASCache.Instance;
				case 'n': return AANCache.Instance;
				case 'o': return AAOCache.Instance;
				case 'p': return AAPCache.Instance;
				case 'q': return AAQCache.Instance;
				case 's': return AASCache.Instance;
				case 't': return AATCache.Instance;
				case 'u': return AAUCache.Instance;
				case 'v': return AAVCache.Instance;
				case 'w': return AAWCache.Instance;
				case 'x': return AAXCache.Instance;
				case 'z': return AAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ab(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ABACache.Instance;
				case 'b': return ABBCache.Instance;
				case 'c': return ABCCache.Instance;
				case 'd': return ABDCache.Instance;
				case 'e': return ABECache.Instance;
				case 'f': return ABFCache.Instance;
				case 'g': return ABGCache.Instance;
				case 'h': return ABHCache.Instance;
				case 'i': return ABICache.Instance;
				case 'j': return ABJCache.Instance;
				case 'l': return ABLCache.Instance;
				case 'm': return ABMCache.Instance;
				case 'n': return ABNCache.Instance;
				case 'o': return ABOCache.Instance;
				case 'p': return ABPCache.Instance;
				case 'q': return ABQCache.Instance;
				case 'r': return ABRCache.Instance;
				case 's': return ABSCache.Instance;
				case 't': return ABTCache.Instance;
				case 'u': return ABUCache.Instance;
				case 'v': return ABVCache.Instance;
				case 'w': return ABWCache.Instance;
				case 'x': return ABXCache.Instance;
				case 'y': return ABYCache.Instance;
				case 'z': return ABZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ac(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ACACache.Instance;
				case 'b': return ACBCache.Instance;
				case 'd': return ACDCache.Instance;
				case 'e': return ACECache.Instance;
				case 'f': return ACFCache.Instance;
				case 'h': return ACHCache.Instance;
				case 'i': return ACICache.Instance;
				case 'k': return ACKCache.Instance;
				case 'l': return ACLCache.Instance;
				case 'm': return ACMCache.Instance;
				case 'n': return ACNCache.Instance;
				case 'p': return ACPCache.Instance;
				case 'q': return ACQCache.Instance;
				case 'r': return ACRCache.Instance;
				case 's': return ACSCache.Instance;
				case 't': return ACTCache.Instance;
				case 'u': return ACUCache.Instance;
				case 'v': return ACVCache.Instance;
				case 'w': return ACWCache.Instance;
				case 'x': return ACXCache.Instance;
				case 'y': return ACYCache.Instance;
				case 'z': return ACZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ad(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ADACache.Instance;
				case 'b': return ADBCache.Instance;
				case 'd': return ADDCache.Instance;
				case 'e': return ADECache.Instance;
				case 'f': return ADFCache.Instance;
				case 'g': return ADGCache.Instance;
				case 'h': return ADHCache.Instance;
				case 'i': return ADICache.Instance;
				case 'j': return ADJCache.Instance;
				case 'l': return ADLCache.Instance;
				case 'n': return ADNCache.Instance;
				case 'o': return ADOCache.Instance;
				case 'p': return DZCache.Instance;
				case 'q': return ADQCache.Instance;
				case 'r': return ADRCache.Instance;
				case 's': return ADSCache.Instance;
				case 't': return ADTCache.Instance;
				case 'u': return ADUCache.Instance;
				case 'w': return ADWCache.Instance;
				case 'x': return ADXCache.Instance;
				case 'y': return ADYCache.Instance;
				case 'z': return ADZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ae(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AEACache.Instance;
				case 'b': return AEBCache.Instance;
				case 'c': return AECCache.Instance;
				case 'd': return AEDCache.Instance;
				case 'e': return AEECache.Instance;
				case 'k': return AEKCache.Instance;
				case 'l': return AELCache.Instance;
				case 'm': return AEMCache.Instance;
				case 'n': return AENCache.Instance;
				case 'q': return AEQCache.Instance;
				case 'r': return AERCache.Instance;
				case 's': return AESCache.Instance;
				case 'u': return AEUCache.Instance;
				case 'w': return AEWCache.Instance;
				case 'y': return AEYCache.Instance;
				case 'z': return AEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_af(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AFACache.Instance;
				case 'b': return AFBCache.Instance;
				case 'd': return AFDCache.Instance;
				case 'e': return AFECache.Instance;
				case 'g': return AFGCache.Instance;
				case 'h': return AFHCache.Instance;
				case 'i': return AFICache.Instance;
				case 'k': return AFKCache.Instance;
				case 'n': return AFNCache.Instance;
				case 'o': return AFOCache.Instance;
				case 'p': return AFPCache.Instance;
				case 's': return AFSCache.Instance;
				case 't': return AFTCache.Instance;
				case 'u': return AFUCache.Instance;
				case 'z': return AFZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ag(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AGACache.Instance;
				case 'b': return AGBCache.Instance;
				case 'c': return AGCCache.Instance;
				case 'd': return AGDCache.Instance;
				case 'e': return AGECache.Instance;
				case 'f': return AGFCache.Instance;
				case 'g': return AGGCache.Instance;
				case 'h': return AGHCache.Instance;
				case 'i': return AGICache.Instance;
				case 'j': return AGJCache.Instance;
				case 'k': return AGKCache.Instance;
				case 'l': return AGLCache.Instance;
				case 'm': return AGMCache.Instance;
				case 'n': return AGNCache.Instance;
				case 'o': return AGOCache.Instance;
				case 'p': return AGPCache.Instance;
				case 'q': return AGQCache.Instance;
				case 'r': return AGRCache.Instance;
				case 's': return AGSCache.Instance;
				case 't': return AGTCache.Instance;
				case 'u': return AGUCache.Instance;
				case 'v': return AGVCache.Instance;
				case 'w': return AGWCache.Instance;
				case 'x': return AGXCache.Instance;
				case 'y': return AGYCache.Instance;
				case 'z': return AGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ah(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AHACache.Instance;
				case 'b': return AHBCache.Instance;
				case 'g': return AHGCache.Instance;
				case 'h': return AHHCache.Instance;
				case 'i': return AHICache.Instance;
				case 'k': return AHKCache.Instance;
				case 'l': return AHLCache.Instance;
				case 'm': return AHMCache.Instance;
				case 'n': return AHNCache.Instance;
				case 'o': return AHOCache.Instance;
				case 'p': return AHPCache.Instance;
				case 'r': return AHRCache.Instance;
				case 's': return AHSCache.Instance;
				case 't': return AHTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ai(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AIACache.Instance;
				case 'b': return AIBCache.Instance;
				case 'c': return AICCache.Instance;
				case 'd': return AIDCache.Instance;
				case 'e': return AIECache.Instance;
				case 'f': return AIFCache.Instance;
				case 'g': return AIGCache.Instance;
				case 'h': return AIHCache.Instance;
				case 'i': return AIICache.Instance;
				case 'j': return AIJCache.Instance;
				case 'k': return AIKCache.Instance;
				case 'l': return AILCache.Instance;
				case 'm': return AIMCache.Instance;
				case 'n': return AINCache.Instance;
				case 'o': return AIOCache.Instance;
				case 'p': return AIPCache.Instance;
				case 'q': return AIQCache.Instance;
				case 'r': return AIRCache.Instance;
				case 's': return AISCache.Instance;
				case 't': return AITCache.Instance;
				case 'w': return AIWCache.Instance;
				case 'x': return AIXCache.Instance;
				case 'y': return AIYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AJACache.Instance;
				case 'g': return AJGCache.Instance;
				case 'i': return AJICache.Instance;
				case 'n': return AJNCache.Instance;
				case 'p': return APCCache.Instance;
				case 's': return AJSCache.Instance;
				case 't': return AEBCache.Instance;
				case 'u': return AJUCache.Instance;
				case 'w': return AJWCache.Instance;
				case 'z': return AJZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ak(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AKBCache.Instance;
				case 'c': return AKCCache.Instance;
				case 'd': return AKDCache.Instance;
				case 'e': return AKECache.Instance;
				case 'f': return AKFCache.Instance;
				case 'g': return AKGCache.Instance;
				case 'h': return AKHCache.Instance;
				case 'i': return AKICache.Instance;
				case 'j': return AKJCache.Instance;
				case 'k': return AKKCache.Instance;
				case 'l': return AKLCache.Instance;
				case 'm': return AKMCache.Instance;
				case 'o': return AKOCache.Instance;
				case 'p': return AKPCache.Instance;
				case 'q': return AKQCache.Instance;
				case 'r': return AKRCache.Instance;
				case 's': return AKSCache.Instance;
				case 't': return AKTCache.Instance;
				case 'u': return AKUCache.Instance;
				case 'v': return AKVCache.Instance;
				case 'w': return AKWCache.Instance;
				case 'x': return AKXCache.Instance;
				case 'y': return AKYCache.Instance;
				case 'z': return AKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_al(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ALACache.Instance;
				case 'c': return ALCCache.Instance;
				case 'd': return ALDCache.Instance;
				case 'e': return ALECache.Instance;
				case 'f': return ALFCache.Instance;
				case 'g': return ALGCache.Instance;
				case 'h': return ALHCache.Instance;
				case 'i': return ALICache.Instance;
				case 'j': return ALJCache.Instance;
				case 'k': return ALKCache.Instance;
				case 'l': return ALLCache.Instance;
				case 'm': return ALMCache.Instance;
				case 'n': return ALNCache.Instance;
				case 'o': return ALOCache.Instance;
				case 'p': return ALPCache.Instance;
				case 'q': return ALQCache.Instance;
				case 'r': return ALRCache.Instance;
				case 's': return ALSCache.Instance;
				case 't': return ALTCache.Instance;
				case 'u': return ALUCache.Instance;
				case 'v': return ALVCache.Instance;
				case 'w': return ALWCache.Instance;
				case 'x': return ALXCache.Instance;
				case 'y': return ALYCache.Instance;
				case 'z': return ALZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_am(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AMACache.Instance;
				case 'b': return AMBCache.Instance;
				case 'c': return AMCCache.Instance;
				case 'e': return AMECache.Instance;
				case 'f': return AMFCache.Instance;
				case 'g': return AMGCache.Instance;
				case 'i': return AMICache.Instance;
				case 'j': return AMJCache.Instance;
				case 'k': return AMKCache.Instance;
				case 'l': return AMLCache.Instance;
				case 'm': return AMMCache.Instance;
				case 'n': return AMNCache.Instance;
				case 'o': return AMOCache.Instance;
				case 'p': return AMPCache.Instance;
				case 'q': return AMQCache.Instance;
				case 'r': return AMRCache.Instance;
				case 's': return AMSCache.Instance;
				case 't': return AMTCache.Instance;
				case 'u': return AMUCache.Instance;
				case 'v': return AMVCache.Instance;
				case 'w': return AMWCache.Instance;
				case 'x': return AMXCache.Instance;
				case 'y': return AMYCache.Instance;
				case 'z': return AMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_an(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ANACache.Instance;
				case 'b': return ANBCache.Instance;
				case 'c': return ANCCache.Instance;
				case 'd': return ANDCache.Instance;
				case 'e': return ANECache.Instance;
				case 'f': return ANFCache.Instance;
				case 'g': return ANGCache.Instance;
				case 'h': return ANHCache.Instance;
				case 'i': return ANICache.Instance;
				case 'j': return ANJCache.Instance;
				case 'k': return ANKCache.Instance;
				case 'l': return ANLCache.Instance;
				case 'm': return ANMCache.Instance;
				case 'n': return ANNCache.Instance;
				case 'o': return ANOCache.Instance;
				case 'p': return ANPCache.Instance;
				case 'q': return ANQCache.Instance;
				case 'r': return ANRCache.Instance;
				case 's': return ANSCache.Instance;
				case 't': return ANTCache.Instance;
				case 'u': return ANUCache.Instance;
				case 'v': return ANVCache.Instance;
				case 'w': return ANWCache.Instance;
				case 'x': return ANXCache.Instance;
				case 'y': return ANYCache.Instance;
				case 'z': return ANZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ao(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AOACache.Instance;
				case 'b': return AOBCache.Instance;
				case 'c': return AOCCache.Instance;
				case 'd': return AODCache.Instance;
				case 'e': return AOECache.Instance;
				case 'f': return AOFCache.Instance;
				case 'g': return AOGCache.Instance;
				case 'h': return AOHCache.Instance;
				case 'i': return AOICache.Instance;
				case 'j': return AOJCache.Instance;
				case 'k': return AOKCache.Instance;
				case 'l': return AOLCache.Instance;
				case 'm': return AOMCache.Instance;
				case 'n': return AONCache.Instance;
				case 'r': return AORCache.Instance;
				case 's': return AOSCache.Instance;
				case 't': return AOTCache.Instance;
				case 'u': return AOUCache.Instance;
				case 'x': return AOXCache.Instance;
				case 'z': return AOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ap(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return APACache.Instance;
				case 'b': return APBCache.Instance;
				case 'c': return APCCache.Instance;
				case 'd': return APDCache.Instance;
				case 'e': return APECache.Instance;
				case 'f': return APFCache.Instance;
				case 'g': return APGCache.Instance;
				case 'h': return APHCache.Instance;
				case 'i': return APICache.Instance;
				case 'j': return APJCache.Instance;
				case 'k': return APKCache.Instance;
				case 'l': return APLCache.Instance;
				case 'm': return APMCache.Instance;
				case 'n': return APNCache.Instance;
				case 'o': return APOCache.Instance;
				case 'p': return APPCache.Instance;
				case 'q': return APQCache.Instance;
				case 'r': return APRCache.Instance;
				case 's': return APSCache.Instance;
				case 't': return APTCache.Instance;
				case 'u': return APUCache.Instance;
				case 'v': return APVCache.Instance;
				case 'w': return APWCache.Instance;
				case 'x': return APXCache.Instance;
				case 'y': return APYCache.Instance;
				case 'z': return APZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AQACache.Instance;
				case 'c': return AQCCache.Instance;
				case 'd': return AQDCache.Instance;
				case 'g': return AQGCache.Instance;
				case 'k': return AQKCache.Instance;
				case 'l': return AQLCache.Instance;
				case 'm': return AQMCache.Instance;
				case 'n': return AQNCache.Instance;
				case 'p': return AQPCache.Instance;
				case 'r': return AQRCache.Instance;
				case 't': return AQTCache.Instance;
				case 'z': return AQZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ar(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ARBCache.Instance;
				case 'c': return ARCCache.Instance;
				case 'd': return ARDCache.Instance;
				case 'e': return ARECache.Instance;
				case 'h': return ARHCache.Instance;
				case 'i': return ARICache.Instance;
				case 'j': return ARJCache.Instance;
				case 'k': return ARKCache.Instance;
				case 'l': return ARLCache.Instance;
				case 'n': return ARNCache.Instance;
				case 'o': return AROCache.Instance;
				case 'p': return ARPCache.Instance;
				case 'q': return ARQCache.Instance;
				case 'r': return ARRCache.Instance;
				case 's': return ARSCache.Instance;
				case 't': return ARTCache.Instance;
				case 'u': return ARUCache.Instance;
				case 'v': return ARVCache.Instance;
				case 'w': return ARWCache.Instance;
				case 'x': return ARXCache.Instance;
				case 'y': return ARYCache.Instance;
				case 'z': return ARZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_as(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ASACache.Instance;
				case 'b': return ASBCache.Instance;
				case 'c': return ASCCache.Instance;
				case 'd': return SNZCache.Instance;
				case 'e': return ASECache.Instance;
				case 'f': return ASFCache.Instance;
				case 'g': return ASGCache.Instance;
				case 'h': return ASHCache.Instance;
				case 'i': return ASICache.Instance;
				case 'j': return ASJCache.Instance;
				case 'k': return ASKCache.Instance;
				case 'l': return ASLCache.Instance;
				case 'n': return ASNCache.Instance;
				case 'o': return ASOCache.Instance;
				case 'p': return ASPCache.Instance;
				case 'q': return ASQCache.Instance;
				case 'r': return ASRCache.Instance;
				case 's': return ASSCache.Instance;
				case 't': return ASTCache.Instance;
				case 'u': return ASUCache.Instance;
				case 'v': return ASVCache.Instance;
				case 'w': return ASWCache.Instance;
				case 'x': return ASXCache.Instance;
				case 'y': return ASYCache.Instance;
				case 'z': return ASZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_at(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ATACache.Instance;
				case 'b': return ATBCache.Instance;
				case 'c': return ATCCache.Instance;
				case 'd': return ATDCache.Instance;
				case 'e': return ATECache.Instance;
				case 'g': return ATGCache.Instance;
				case 'h': return ATHCache.Instance;
				case 'i': return ATICache.Instance;
				case 'j': return ATJCache.Instance;
				case 'k': return ATKCache.Instance;
				case 'l': return ATLCache.Instance;
				case 'm': return ATMCache.Instance;
				case 'n': return ATNCache.Instance;
				case 'o': return ATOCache.Instance;
				case 'p': return ATPCache.Instance;
				case 'q': return ATQCache.Instance;
				case 'r': return ATRCache.Instance;
				case 's': return ATSCache.Instance;
				case 't': return ATTCache.Instance;
				case 'u': return ATUCache.Instance;
				case 'v': return ATVCache.Instance;
				case 'w': return ATWCache.Instance;
				case 'x': return ATXCache.Instance;
				case 'y': return ATYCache.Instance;
				case 'z': return ATZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_au(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AUACache.Instance;
				case 'b': return AUBCache.Instance;
				case 'c': return AUCCache.Instance;
				case 'd': return AUDCache.Instance;
				case 'e': return KTZCache.Instance;
				case 'f': return AUFCache.Instance;
				case 'g': return AUGCache.Instance;
				case 'h': return AUHCache.Instance;
				case 'i': return AUICache.Instance;
				case 'j': return AUJCache.Instance;
				case 'k': return AUKCache.Instance;
				case 'l': return AULCache.Instance;
				case 'm': return AUMCache.Instance;
				case 'n': return AUNCache.Instance;
				case 'o': return AUOCache.Instance;
				case 'p': return AUPCache.Instance;
				case 'q': return AUQCache.Instance;
				case 'r': return AURCache.Instance;
				case 's': return AUSCache.Instance;
				case 't': return AUTCache.Instance;
				case 'u': return AUUCache.Instance;
				case 'w': return AUWCache.Instance;
				case 'x': return AUXCache.Instance;
				case 'y': return AUYCache.Instance;
				case 'z': return AUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_av(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AVBCache.Instance;
				case 'd': return AVDCache.Instance;
				case 'i': return AVICache.Instance;
				case 'k': return AVKCache.Instance;
				case 'l': return AVLCache.Instance;
				case 'm': return AVMCache.Instance;
				case 'n': return AVNCache.Instance;
				case 'o': return AVOCache.Instance;
				case 's': return AVSCache.Instance;
				case 't': return AVTCache.Instance;
				case 'u': return AVUCache.Instance;
				case 'v': return AVVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AWACache.Instance;
				case 'b': return AWBCache.Instance;
				case 'c': return AWCCache.Instance;
				case 'd': return AWDCache.Instance;
				case 'e': return AWECache.Instance;
				case 'g': return AWGCache.Instance;
				case 'h': return AWHCache.Instance;
				case 'i': return AWICache.Instance;
				case 'k': return AWKCache.Instance;
				case 'm': return AWMCache.Instance;
				case 'n': return AWNCache.Instance;
				case 'o': return AWOCache.Instance;
				case 'r': return AWRCache.Instance;
				case 's': return AWSCache.Instance;
				case 't': return AWTCache.Instance;
				case 'u': return AWUCache.Instance;
				case 'v': return AWVCache.Instance;
				case 'w': return AWWCache.Instance;
				case 'x': return AWXCache.Instance;
				case 'y': return AWYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ax(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AXBCache.Instance;
				case 'e': return AXECache.Instance;
				case 'g': return AXGCache.Instance;
				case 'k': return AXKCache.Instance;
				case 'l': return AXLCache.Instance;
				case 'm': return AXMCache.Instance;
				case 'x': return AXXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ay(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AYACache.Instance;
				case 'b': return AYBCache.Instance;
				case 'c': return AYCCache.Instance;
				case 'd': return AYDCache.Instance;
				case 'e': return AYECache.Instance;
				case 'g': return AYGCache.Instance;
				case 'h': return AYHCache.Instance;
				case 'i': return AYICache.Instance;
				case 'k': return AYKCache.Instance;
				case 'l': return AYLCache.Instance;
				case 'n': return AYNCache.Instance;
				case 'o': return AYOCache.Instance;
				case 'p': return AYPCache.Instance;
				case 'q': return AYQCache.Instance;
				case 'r': return AYRCache.Instance;
				case 's': return AYSCache.Instance;
				case 't': return AYTCache.Instance;
				case 'u': return AYUCache.Instance;
				case 'x': return NUNCache.Instance;
				case 'y': return AYYCache.Instance;
				case 'z': return AYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_az(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AZACache.Instance;
				case 'b': return AZBCache.Instance;
				case 'c': return AZCCache.Instance;
				case 'd': return AZDCache.Instance;
				case 'g': return AZGCache.Instance;
				case 'j': return AZJCache.Instance;
				case 'm': return AZMCache.Instance;
				case 'n': return AZNCache.Instance;
				case 'o': return AZOCache.Instance;
				case 't': return AZTCache.Instance;
				case 'z': return AZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ba(span);
				case 'b': return tryParse_L3_bb(span);
				case 'c': return tryParse_L3_bc(span);
				case 'd': return tryParse_L3_bd(span);
				case 'e': return tryParse_L3_be(span);
				case 'f': return tryParse_L3_bf(span);
				case 'g': return tryParse_L3_bg(span);
				case 'h': return tryParse_L3_bh(span);
				case 'i': return tryParse_L3_bi(span);
				case 'j': return tryParse_L3_bj(span);
				case 'k': return tryParse_L3_bk(span);
				case 'l': return tryParse_L3_bl(span);
				case 'm': return tryParse_L3_bm(span);
				case 'n': return tryParse_L3_bn(span);
				case 'o': return tryParse_L3_bo(span);
				case 'p': return tryParse_L3_bp(span);
				case 'q': return tryParse_L3_bq(span);
				case 'r': return tryParse_L3_br(span);
				case 's': return tryParse_L3_bs(span);
				case 't': return tryParse_L3_bt(span);
				case 'u': return tryParse_L3_bu(span);
				case 'v': return tryParse_L3_bv(span);
				case 'w': return tryParse_L3_bw(span);
				case 'x': return tryParse_L3_bx(span);
				case 'y': return tryParse_L3_by(span);
				case 'z': return tryParse_L3_bz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ba(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BAACache.Instance;
				case 'b': return BABCache.Instance;
				case 'c': return BACCache.Instance;
				case 'd': return BADCache.Instance;
				case 'e': return BAECache.Instance;
				case 'f': return BAFCache.Instance;
				case 'g': return BAGCache.Instance;
				case 'h': return BAHCache.Instance;
				case 'i': return BAICache.Instance;
				case 'j': return BAJCache.Instance;
				case 'l': return BALCache.Instance;
				case 'n': return BANCache.Instance;
				case 'o': return BAOCache.Instance;
				case 'p': return BAPCache.Instance;
				case 'r': return BARCache.Instance;
				case 's': return BASCache.Instance;
				case 't': return BATCache.Instance;
				case 'u': return BAUCache.Instance;
				case 'v': return BAVCache.Instance;
				case 'w': return BAWCache.Instance;
				case 'x': return BAXCache.Instance;
				case 'y': return BAYCache.Instance;
				case 'z': return BAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BBACache.Instance;
				case 'b': return BBBCache.Instance;
				case 'c': return BBCCache.Instance;
				case 'd': return BBDCache.Instance;
				case 'e': return BBECache.Instance;
				case 'f': return BBFCache.Instance;
				case 'g': return BBGCache.Instance;
				case 'h': return BBHCache.Instance;
				case 'i': return BBICache.Instance;
				case 'j': return BBJCache.Instance;
				case 'k': return BBKCache.Instance;
				case 'l': return BBLCache.Instance;
				case 'm': return BBMCache.Instance;
				case 'n': return BBNCache.Instance;
				case 'o': return BBOCache.Instance;
				case 'p': return BBPCache.Instance;
				case 'q': return BBQCache.Instance;
				case 'r': return BBRCache.Instance;
				case 's': return BBSCache.Instance;
				case 't': return BBTCache.Instance;
				case 'u': return BBUCache.Instance;
				case 'v': return BBVCache.Instance;
				case 'w': return BBWCache.Instance;
				case 'x': return BBXCache.Instance;
				case 'y': return BBYCache.Instance;
				case 'z': return BBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BCACache.Instance;
				case 'b': return BCBCache.Instance;
				case 'c': return BCCCache.Instance;
				case 'd': return BCDCache.Instance;
				case 'e': return BCECache.Instance;
				case 'f': return BCFCache.Instance;
				case 'g': return BCGCache.Instance;
				case 'h': return BCHCache.Instance;
				case 'i': return BCICache.Instance;
				case 'j': return BCJCache.Instance;
				case 'k': return BCKCache.Instance;
				case 'l': return BCLCache.Instance;
				case 'm': return BCMCache.Instance;
				case 'n': return BCNCache.Instance;
				case 'o': return BCOCache.Instance;
				case 'p': return BCPCache.Instance;
				case 'q': return BCQCache.Instance;
				case 'r': return BCRCache.Instance;
				case 's': return BCSCache.Instance;
				case 't': return BCTCache.Instance;
				case 'u': return BCUCache.Instance;
				case 'v': return BCVCache.Instance;
				case 'w': return BCWCache.Instance;
				case 'y': return BCYCache.Instance;
				case 'z': return BCZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BDACache.Instance;
				case 'b': return BDBCache.Instance;
				case 'c': return BDCCache.Instance;
				case 'd': return BDDCache.Instance;
				case 'e': return BDECache.Instance;
				case 'f': return BDFCache.Instance;
				case 'g': return BDGCache.Instance;
				case 'h': return BDHCache.Instance;
				case 'i': return BDICache.Instance;
				case 'j': return BDJCache.Instance;
				case 'k': return BDKCache.Instance;
				case 'l': return BDLCache.Instance;
				case 'm': return BDMCache.Instance;
				case 'n': return BDNCache.Instance;
				case 'o': return BDOCache.Instance;
				case 'p': return BDPCache.Instance;
				case 'q': return BDQCache.Instance;
				case 'r': return BDRCache.Instance;
				case 's': return BDSCache.Instance;
				case 't': return BDTCache.Instance;
				case 'u': return BDUCache.Instance;
				case 'v': return BDVCache.Instance;
				case 'w': return BDWCache.Instance;
				case 'x': return BDXCache.Instance;
				case 'y': return BDYCache.Instance;
				case 'z': return BDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_be(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BEACache.Instance;
				case 'b': return BEBCache.Instance;
				case 'c': return BECCache.Instance;
				case 'd': return BEDCache.Instance;
				case 'e': return BEECache.Instance;
				case 'f': return BEFCache.Instance;
				case 'g': return BEGCache.Instance;
				case 'h': return BEHCache.Instance;
				case 'i': return BEICache.Instance;
				case 'j': return BEJCache.Instance;
				case 'k': return BEKCache.Instance;
				case 'm': return BEMCache.Instance;
				case 'o': return BEOCache.Instance;
				case 'p': return BEPCache.Instance;
				case 'q': return BEQCache.Instance;
				case 'r': return BERCache.Instance;
				case 's': return BESCache.Instance;
				case 't': return BETCache.Instance;
				case 'u': return BEUCache.Instance;
				case 'v': return BEVCache.Instance;
				case 'w': return BEWCache.Instance;
				case 'x': return BEXCache.Instance;
				case 'y': return BEYCache.Instance;
				case 'z': return BEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BFACache.Instance;
				case 'b': return BFBCache.Instance;
				case 'c': return BFCCache.Instance;
				case 'd': return BFDCache.Instance;
				case 'e': return BFECache.Instance;
				case 'f': return BFFCache.Instance;
				case 'g': return BFGCache.Instance;
				case 'h': return BFHCache.Instance;
				case 'i': return BFICache.Instance;
				case 'j': return BFJCache.Instance;
				case 'k': return BFKCache.Instance;
				case 'l': return BFLCache.Instance;
				case 'm': return BFMCache.Instance;
				case 'n': return BFNCache.Instance;
				case 'o': return BFOCache.Instance;
				case 'p': return BFPCache.Instance;
				case 'q': return BFQCache.Instance;
				case 'r': return BFRCache.Instance;
				case 's': return BFSCache.Instance;
				case 't': return BFTCache.Instance;
				case 'u': return BFUCache.Instance;
				case 'w': return BFWCache.Instance;
				case 'x': return BFXCache.Instance;
				case 'y': return BFYCache.Instance;
				case 'z': return BFZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BGACache.Instance;
				case 'b': return BGBCache.Instance;
				case 'c': return BGCCache.Instance;
				case 'd': return BGDCache.Instance;
				case 'e': return BGECache.Instance;
				case 'f': return BGFCache.Instance;
				case 'g': return BGGCache.Instance;
				case 'i': return BGICache.Instance;
				case 'j': return BGJCache.Instance;
				case 'k': return BGKCache.Instance;
				case 'l': return BGLCache.Instance;
				case 'm': return BCGCache.Instance;
				case 'n': return BGNCache.Instance;
				case 'o': return BGOCache.Instance;
				case 'p': return BGPCache.Instance;
				case 'q': return BGQCache.Instance;
				case 'r': return BGRCache.Instance;
				case 's': return BGSCache.Instance;
				case 't': return BGTCache.Instance;
				case 'u': return BGUCache.Instance;
				case 'v': return BGVCache.Instance;
				case 'w': return BGWCache.Instance;
				case 'x': return BGXCache.Instance;
				case 'y': return BGYCache.Instance;
				case 'z': return BGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BHACache.Instance;
				case 'b': return BHBCache.Instance;
				case 'c': return BHCCache.Instance;
				case 'd': return BHDCache.Instance;
				case 'e': return BHECache.Instance;
				case 'f': return BHFCache.Instance;
				case 'g': return BHGCache.Instance;
				case 'h': return BHHCache.Instance;
				case 'i': return BHICache.Instance;
				case 'j': return BHJCache.Instance;
				case 'k': return BHKCache.Instance;
				case 'l': return BHLCache.Instance;
				case 'm': return BHMCache.Instance;
				case 'n': return BHNCache.Instance;
				case 'o': return BHOCache.Instance;
				case 'p': return BHPCache.Instance;
				case 'q': return BHQCache.Instance;
				case 'r': return BHRCache.Instance;
				case 's': return BHSCache.Instance;
				case 't': return BHTCache.Instance;
				case 'u': return BHUCache.Instance;
				case 'v': return BHVCache.Instance;
				case 'w': return BHWCache.Instance;
				case 'x': return BHXCache.Instance;
				case 'y': return BHYCache.Instance;
				case 'z': return BHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BIACache.Instance;
				case 'b': return BIBCache.Instance;
				case 'c': return BIRCache.Instance;
				case 'd': return BIDCache.Instance;
				case 'e': return BIECache.Instance;
				case 'f': return BIFCache.Instance;
				case 'g': return BIGCache.Instance;
				case 'j': return BIJCache.Instance;
				case 'k': return BIKCache.Instance;
				case 'l': return BILCache.Instance;
				case 'm': return BIMCache.Instance;
				case 'n': return BINCache.Instance;
				case 'o': return BIOCache.Instance;
				case 'p': return BIPCache.Instance;
				case 'q': return BIQCache.Instance;
				case 'r': return BIRCache.Instance;
				case 't': return BITCache.Instance;
				case 'u': return BIUCache.Instance;
				case 'v': return BIVCache.Instance;
				case 'w': return BIWCache.Instance;
				case 'x': return BIXCache.Instance;
				case 'y': return BIYCache.Instance;
				case 'z': return BIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BJACache.Instance;
				case 'b': return BJBCache.Instance;
				case 'c': return BJCCache.Instance;
				case 'd': return DRLCache.Instance;
				case 'e': return BJECache.Instance;
				case 'f': return BJFCache.Instance;
				case 'g': return BJGCache.Instance;
				case 'h': return BJHCache.Instance;
				case 'i': return BJICache.Instance;
				case 'j': return BJJCache.Instance;
				case 'k': return BJKCache.Instance;
				case 'l': return BJLCache.Instance;
				case 'm': return BJMCache.Instance;
				case 'n': return BJNCache.Instance;
				case 'o': return BJOCache.Instance;
				case 'p': return BJPCache.Instance;
				case 'q': return BJQCache.Instance;
				case 'r': return BJRCache.Instance;
				case 's': return BJSCache.Instance;
				case 't': return BJTCache.Instance;
				case 'u': return BJUCache.Instance;
				case 'v': return BJVCache.Instance;
				case 'w': return BJWCache.Instance;
				case 'x': return BJXCache.Instance;
				case 'y': return BJYCache.Instance;
				case 'z': return BJZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BKACache.Instance;
				case 'b': return BKBCache.Instance;
				case 'c': return BKCCache.Instance;
				case 'd': return BKDCache.Instance;
				case 'f': return BKFCache.Instance;
				case 'g': return BKGCache.Instance;
				case 'h': return BKHCache.Instance;
				case 'i': return BKICache.Instance;
				case 'j': return BKJCache.Instance;
				case 'k': return BKKCache.Instance;
				case 'l': return BKLCache.Instance;
				case 'm': return BKMCache.Instance;
				case 'n': return BKNCache.Instance;
				case 'o': return BKOCache.Instance;
				case 'p': return BKPCache.Instance;
				case 'q': return BKQCache.Instance;
				case 'r': return BKRCache.Instance;
				case 's': return BKSCache.Instance;
				case 't': return BKTCache.Instance;
				case 'u': return BKUCache.Instance;
				case 'v': return BKVCache.Instance;
				case 'w': return BKWCache.Instance;
				case 'x': return BKXCache.Instance;
				case 'y': return BKYCache.Instance;
				case 'z': return BKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BLACache.Instance;
				case 'b': return BLBCache.Instance;
				case 'c': return BLCCache.Instance;
				case 'd': return BLDCache.Instance;
				case 'e': return BLECache.Instance;
				case 'f': return BLFCache.Instance;
				case 'g': return IBACache.Instance;
				case 'h': return BLHCache.Instance;
				case 'i': return BLICache.Instance;
				case 'j': return BLJCache.Instance;
				case 'k': return BLKCache.Instance;
				case 'l': return BLLCache.Instance;
				case 'm': return BLMCache.Instance;
				case 'n': return BLNCache.Instance;
				case 'o': return BLOCache.Instance;
				case 'p': return BLPCache.Instance;
				case 'q': return BLQCache.Instance;
				case 'r': return BLRCache.Instance;
				case 's': return BLSCache.Instance;
				case 't': return BLTCache.Instance;
				case 'v': return BLVCache.Instance;
				case 'w': return BLWCache.Instance;
				case 'x': return BLXCache.Instance;
				case 'y': return BLYCache.Instance;
				case 'z': return BLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BMACache.Instance;
				case 'b': return BMBCache.Instance;
				case 'c': return BMCCache.Instance;
				case 'd': return BMDCache.Instance;
				case 'e': return BMECache.Instance;
				case 'f': return BMFCache.Instance;
				case 'g': return BMGCache.Instance;
				case 'h': return BMHCache.Instance;
				case 'i': return BMICache.Instance;
				case 'j': return BMJCache.Instance;
				case 'k': return BMKCache.Instance;
				case 'l': return BMLCache.Instance;
				case 'm': return BMMCache.Instance;
				case 'n': return BMNCache.Instance;
				case 'o': return BMOCache.Instance;
				case 'p': return BMPCache.Instance;
				case 'q': return BMQCache.Instance;
				case 'r': return BMRCache.Instance;
				case 's': return BMSCache.Instance;
				case 't': return BMTCache.Instance;
				case 'u': return BMUCache.Instance;
				case 'v': return BMVCache.Instance;
				case 'w': return BMWCache.Instance;
				case 'x': return BMXCache.Instance;
				case 'y': return BMYCache.Instance;
				case 'z': return BMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BNACache.Instance;
				case 'b': return BNBCache.Instance;
				case 'c': return BNCCache.Instance;
				case 'd': return BNDCache.Instance;
				case 'e': return BNECache.Instance;
				case 'f': return BNFCache.Instance;
				case 'g': return BNGCache.Instance;
				case 'i': return BNICache.Instance;
				case 'j': return BNJCache.Instance;
				case 'k': return BNKCache.Instance;
				case 'l': return BNLCache.Instance;
				case 'm': return BNMCache.Instance;
				case 'n': return BNNCache.Instance;
				case 'o': return BNOCache.Instance;
				case 'p': return BNPCache.Instance;
				case 'q': return BNQCache.Instance;
				case 'r': return BNRCache.Instance;
				case 's': return BNSCache.Instance;
				case 't': return BNTCache.Instance;
				case 'u': return BNUCache.Instance;
				case 'v': return BNVCache.Instance;
				case 'w': return BNWCache.Instance;
				case 'x': return BNXCache.Instance;
				case 'y': return BNYCache.Instance;
				case 'z': return BNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BOACache.Instance;
				case 'b': return BOBCache.Instance;
				case 'e': return BOECache.Instance;
				case 'f': return BOFCache.Instance;
				case 'g': return BOGCache.Instance;
				case 'h': return BOHCache.Instance;
				case 'i': return BOICache.Instance;
				case 'j': return BOJCache.Instance;
				case 'k': return BOKCache.Instance;
				case 'l': return BOLCache.Instance;
				case 'm': return BOMCache.Instance;
				case 'n': return BONCache.Instance;
				case 'o': return BOOCache.Instance;
				case 'p': return BOPCache.Instance;
				case 'q': return BOQCache.Instance;
				case 'r': return BORCache.Instance;
				case 't': return BOTCache.Instance;
				case 'u': return BOUCache.Instance;
				case 'v': return BOVCache.Instance;
				case 'w': return BOWCache.Instance;
				case 'x': return BOXCache.Instance;
				case 'y': return BOYCache.Instance;
				case 'z': return BOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BPACache.Instance;
				case 'b': return BPBCache.Instance;
				case 'c': return BPCCache.Instance;
				case 'd': return BPDCache.Instance;
				case 'e': return BPECache.Instance;
				case 'g': return BPGCache.Instance;
				case 'h': return BPHCache.Instance;
				case 'i': return BPICache.Instance;
				case 'j': return BPJCache.Instance;
				case 'k': return BPKCache.Instance;
				case 'l': return BPLCache.Instance;
				case 'm': return BPMCache.Instance;
				case 'n': return BPNCache.Instance;
				case 'o': return BPOCache.Instance;
				case 'p': return BPPCache.Instance;
				case 'q': return BPQCache.Instance;
				case 'r': return BPRCache.Instance;
				case 's': return BPSCache.Instance;
				case 't': return BPTCache.Instance;
				case 'u': return BPUCache.Instance;
				case 'v': return BPVCache.Instance;
				case 'w': return BPWCache.Instance;
				case 'x': return BPXCache.Instance;
				case 'y': return BPYCache.Instance;
				case 'z': return BPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BQACache.Instance;
				case 'b': return BQBCache.Instance;
				case 'c': return BQCCache.Instance;
				case 'd': return BQDCache.Instance;
				case 'f': return BQFCache.Instance;
				case 'g': return BQGCache.Instance;
				case 'h': return BQHCache.Instance;
				case 'i': return BQICache.Instance;
				case 'j': return BQJCache.Instance;
				case 'k': return BQKCache.Instance;
				case 'l': return BQLCache.Instance;
				case 'm': return BQMCache.Instance;
				case 'n': return BQNCache.Instance;
				case 'o': return BQOCache.Instance;
				case 'p': return BQPCache.Instance;
				case 'q': return BQQCache.Instance;
				case 'r': return BQRCache.Instance;
				case 's': return BQSCache.Instance;
				case 't': return BQTCache.Instance;
				case 'u': return BQUCache.Instance;
				case 'v': return BQVCache.Instance;
				case 'w': return BQWCache.Instance;
				case 'x': return BQXCache.Instance;
				case 'y': return BQYCache.Instance;
				case 'z': return BQZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_br(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BRACache.Instance;
				case 'b': return BRBCache.Instance;
				case 'c': return BRCCache.Instance;
				case 'd': return BRDCache.Instance;
				case 'f': return BRFCache.Instance;
				case 'g': return BRGCache.Instance;
				case 'h': return BRHCache.Instance;
				case 'i': return BRICache.Instance;
				case 'j': return BRJCache.Instance;
				case 'k': return BRKCache.Instance;
				case 'l': return BRLCache.Instance;
				case 'm': return BRMCache.Instance;
				case 'n': return BRNCache.Instance;
				case 'o': return BROCache.Instance;
				case 'p': return BRPCache.Instance;
				case 'q': return BRQCache.Instance;
				case 'r': return BRRCache.Instance;
				case 's': return BRSCache.Instance;
				case 't': return BRTCache.Instance;
				case 'u': return BRUCache.Instance;
				case 'v': return BRVCache.Instance;
				case 'w': return BRWCache.Instance;
				case 'x': return BRXCache.Instance;
				case 'y': return BRYCache.Instance;
				case 'z': return BRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BSACache.Instance;
				case 'b': return BSBCache.Instance;
				case 'c': return BSCCache.Instance;
				case 'e': return BSECache.Instance;
				case 'f': return BSFCache.Instance;
				case 'g': return BSGCache.Instance;
				case 'h': return BSHCache.Instance;
				case 'i': return BSICache.Instance;
				case 'j': return BSJCache.Instance;
				case 'k': return BSKCache.Instance;
				case 'l': return BSLCache.Instance;
				case 'm': return BSMCache.Instance;
				case 'n': return BSNCache.Instance;
				case 'o': return BSOCache.Instance;
				case 'p': return BSPCache.Instance;
				case 'q': return BSQCache.Instance;
				case 'r': return BSRCache.Instance;
				case 's': return BSSCache.Instance;
				case 't': return BSTCache.Instance;
				case 'u': return BSUCache.Instance;
				case 'v': return BSVCache.Instance;
				case 'w': return BSWCache.Instance;
				case 'x': return BSXCache.Instance;
				case 'y': return BSYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BTACache.Instance;
				case 'b': return BTBCache.Instance;
				case 'c': return BTCCache.Instance;
				case 'd': return BTDCache.Instance;
				case 'e': return BTECache.Instance;
				case 'f': return BTFCache.Instance;
				case 'g': return BTGCache.Instance;
				case 'h': return BTHCache.Instance;
				case 'i': return BTICache.Instance;
				case 'j': return BTJCache.Instance;
				case 'k': return BTKCache.Instance;
				case 'l': return BTLCache.Instance;
				case 'm': return BTMCache.Instance;
				case 'n': return BTNCache.Instance;
				case 'o': return BTOCache.Instance;
				case 'p': return BTPCache.Instance;
				case 'q': return BTQCache.Instance;
				case 'r': return BTRCache.Instance;
				case 's': return BTSCache.Instance;
				case 't': return BTTCache.Instance;
				case 'u': return BTUCache.Instance;
				case 'v': return BTVCache.Instance;
				case 'w': return BTWCache.Instance;
				case 'x': return BTXCache.Instance;
				case 'y': return BTYCache.Instance;
				case 'z': return BTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BUACache.Instance;
				case 'b': return BUBCache.Instance;
				case 'c': return BUCCache.Instance;
				case 'd': return BUDCache.Instance;
				case 'e': return BUECache.Instance;
				case 'f': return BUFCache.Instance;
				case 'g': return BUGCache.Instance;
				case 'h': return BUHCache.Instance;
				case 'i': return BUICache.Instance;
				case 'j': return BUJCache.Instance;
				case 'k': return BUKCache.Instance;
				case 'm': return BUMCache.Instance;
				case 'n': return BUNCache.Instance;
				case 'o': return BUOCache.Instance;
				case 'p': return BUPCache.Instance;
				case 'q': return BUQCache.Instance;
				case 's': return BUSCache.Instance;
				case 't': return BUTCache.Instance;
				case 'u': return BUUCache.Instance;
				case 'v': return BUVCache.Instance;
				case 'w': return BUWCache.Instance;
				case 'x': return BUXCache.Instance;
				case 'y': return BUYCache.Instance;
				case 'z': return BUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BVACache.Instance;
				case 'b': return BVBCache.Instance;
				case 'c': return BVCCache.Instance;
				case 'd': return BVDCache.Instance;
				case 'e': return BVECache.Instance;
				case 'f': return BVFCache.Instance;
				case 'g': return BVGCache.Instance;
				case 'h': return BVHCache.Instance;
				case 'i': return BVICache.Instance;
				case 'j': return BVJCache.Instance;
				case 'k': return BVKCache.Instance;
				case 'l': return BVLCache.Instance;
				case 'm': return BVMCache.Instance;
				case 'n': return BVNCache.Instance;
				case 'o': return BVOCache.Instance;
				case 'p': return BVPCache.Instance;
				case 'q': return BVQCache.Instance;
				case 'r': return BVRCache.Instance;
				case 't': return BVTCache.Instance;
				case 'u': return BVUCache.Instance;
				case 'v': return BVVCache.Instance;
				case 'w': return BVWCache.Instance;
				case 'x': return BVXCache.Instance;
				case 'y': return BVYCache.Instance;
				case 'z': return BVZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BWACache.Instance;
				case 'b': return BWBCache.Instance;
				case 'c': return BWCCache.Instance;
				case 'd': return BWDCache.Instance;
				case 'e': return BWECache.Instance;
				case 'f': return BWFCache.Instance;
				case 'g': return BWGCache.Instance;
				case 'h': return BWHCache.Instance;
				case 'i': return BWICache.Instance;
				case 'j': return BWJCache.Instance;
				case 'k': return BWKCache.Instance;
				case 'l': return BWLCache.Instance;
				case 'm': return BWMCache.Instance;
				case 'n': return BWNCache.Instance;
				case 'o': return BWOCache.Instance;
				case 'p': return BWPCache.Instance;
				case 'q': return BWQCache.Instance;
				case 'r': return BWRCache.Instance;
				case 's': return BWSCache.Instance;
				case 't': return BWTCache.Instance;
				case 'u': return BWUCache.Instance;
				case 'w': return BWWCache.Instance;
				case 'x': return BWXCache.Instance;
				case 'y': return BWYCache.Instance;
				case 'z': return BWZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BXACache.Instance;
				case 'b': return BXBCache.Instance;
				case 'c': return BXCCache.Instance;
				case 'd': return BXDCache.Instance;
				case 'e': return BXECache.Instance;
				case 'f': return BXFCache.Instance;
				case 'g': return BXGCache.Instance;
				case 'h': return BXHCache.Instance;
				case 'i': return BXICache.Instance;
				case 'j': return BXJCache.Instance;
				case 'k': return BXKCache.Instance;
				case 'l': return BXLCache.Instance;
				case 'm': return BXMCache.Instance;
				case 'n': return BXNCache.Instance;
				case 'o': return BXOCache.Instance;
				case 'p': return BXPCache.Instance;
				case 'q': return BXQCache.Instance;
				case 'r': return BXRCache.Instance;
				case 's': return BXSCache.Instance;
				case 'u': return BXUCache.Instance;
				case 'v': return BXVCache.Instance;
				case 'w': return BXWCache.Instance;
				case 'x': return BXXCache.Instance;
				case 'z': return BXZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_by(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BYACache.Instance;
				case 'b': return BYBCache.Instance;
				case 'c': return BYCCache.Instance;
				case 'd': return BYDCache.Instance;
				case 'e': return BYECache.Instance;
				case 'f': return BYFCache.Instance;
				case 'g': return BYGCache.Instance;
				case 'h': return BYHCache.Instance;
				case 'i': return BYICache.Instance;
				case 'j': return BYJCache.Instance;
				case 'k': return BYKCache.Instance;
				case 'l': return BYLCache.Instance;
				case 'm': return BYMCache.Instance;
				case 'n': return BYNCache.Instance;
				case 'o': return BYOCache.Instance;
				case 'p': return BYPCache.Instance;
				case 'q': return BYQCache.Instance;
				case 'r': return BYRCache.Instance;
				case 's': return BYSCache.Instance;
				case 't': return BYTCache.Instance;
				case 'v': return BYVCache.Instance;
				case 'w': return BYWCache.Instance;
				case 'x': return BYXCache.Instance;
				case 'y': return BYYCache.Instance;
				case 'z': return BYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BZACache.Instance;
				case 'b': return BZBCache.Instance;
				case 'c': return BZCCache.Instance;
				case 'd': return BZDCache.Instance;
				case 'e': return BZECache.Instance;
				case 'f': return BZFCache.Instance;
				case 'g': return BZGCache.Instance;
				case 'h': return BZHCache.Instance;
				case 'i': return BZICache.Instance;
				case 'j': return BZJCache.Instance;
				case 'k': return BZKCache.Instance;
				case 'l': return BZLCache.Instance;
				case 'm': return BZMCache.Instance;
				case 'n': return BZNCache.Instance;
				case 'o': return BZOCache.Instance;
				case 'p': return BZPCache.Instance;
				case 'q': return BZQCache.Instance;
				case 'r': return BZRCache.Instance;
				case 's': return BZSCache.Instance;
				case 't': return BZTCache.Instance;
				case 'u': return BZUCache.Instance;
				case 'v': return BZVCache.Instance;
				case 'w': return BZWCache.Instance;
				case 'x': return BZXCache.Instance;
				case 'y': return BZYCache.Instance;
				case 'z': return BZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ca(span);
				case 'b': return tryParse_L3_cb(span);
				case 'c': return tryParse_L3_cc(span);
				case 'd': return tryParse_L3_cd(span);
				case 'e': return tryParse_L3_ce(span);
				case 'f': return tryParse_L3_cf(span);
				case 'g': return tryParse_L3_cg(span);
				case 'h': return tryParse_L3_ch(span);
				case 'i': return tryParse_L3_ci(span);
				case 'j': return tryParse_L3_cj(span);
				case 'k': return tryParse_L3_ck(span);
				case 'l': return tryParse_L3_cl(span);
				case 'm': return tryParse_L3_cm(span);
				case 'n': return tryParse_L3_cn(span);
				case 'o': return tryParse_L3_co(span);
				case 'p': return tryParse_L3_cp(span);
				case 'q': return tryParse_L3_cq(span);
				case 'r': return tryParse_L3_cr(span);
				case 's': return tryParse_L3_cs(span);
				case 't': return tryParse_L3_ct(span);
				case 'u': return tryParse_L3_cu(span);
				case 'v': return tryParse_L3_cv(span);
				case 'w': return tryParse_L3_cw(span);
				case 'x': return tryParse_L3_cx(span);
				case 'y': return tryParse_L3_cy(span);
				case 'z': return tryParse_L3_cz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ca(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CAACache.Instance;
				case 'b': return CABCache.Instance;
				case 'c': return CACCache.Instance;
				case 'd': return CADCache.Instance;
				case 'e': return CAECache.Instance;
				case 'f': return CAFCache.Instance;
				case 'g': return CAGCache.Instance;
				case 'h': return CAHCache.Instance;
				case 'i': return CAICache.Instance;
				case 'j': return CAJCache.Instance;
				case 'k': return CAKCache.Instance;
				case 'l': return CALCache.Instance;
				case 'm': return CAMCache.Instance;
				case 'n': return CANCache.Instance;
				case 'o': return CAOCache.Instance;
				case 'p': return CAPCache.Instance;
				case 'q': return CAQCache.Instance;
				case 'r': return CARCache.Instance;
				case 's': return CASCache.Instance;
				case 'u': return CAUCache.Instance;
				case 'v': return CAVCache.Instance;
				case 'w': return CAWCache.Instance;
				case 'x': return CAXCache.Instance;
				case 'y': return CAYCache.Instance;
				case 'z': return CAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CBACache.Instance;
				case 'b': return CBBCache.Instance;
				case 'c': return CBCCache.Instance;
				case 'd': return CBDCache.Instance;
				case 'e': return CBECache.Instance;
				case 'g': return CBGCache.Instance;
				case 'h': return CBHCache.Instance;
				case 'i': return CBICache.Instance;
				case 'j': return CBJCache.Instance;
				case 'k': return CBKCache.Instance;
				case 'l': return CBLCache.Instance;
				case 'n': return CBNCache.Instance;
				case 'o': return CBOCache.Instance;
				case 'q': return CBQCache.Instance;
				case 'r': return CBRCache.Instance;
				case 's': return CBSCache.Instance;
				case 't': return CBTCache.Instance;
				case 'u': return CBUCache.Instance;
				case 'v': return CBVCache.Instance;
				case 'w': return CBWCache.Instance;
				case 'y': return CBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CCACache.Instance;
				case 'c': return CCCCache.Instance;
				case 'd': return CCDCache.Instance;
				case 'e': return CCECache.Instance;
				case 'g': return CCGCache.Instance;
				case 'h': return CCHCache.Instance;
				case 'j': return CCJCache.Instance;
				case 'l': return CCLCache.Instance;
				case 'm': return CCMCache.Instance;
				case 'n': return CCNCache.Instance;
				case 'o': return CCOCache.Instance;
				case 'p': return CCPCache.Instance;
				case 'q': return RKICache.Instance;
				case 'r': return CCRCache.Instance;
				case 's': return CCSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CDACache.Instance;
				case 'c': return CDCCache.Instance;
				case 'd': return CDDCache.Instance;
				case 'e': return CDECache.Instance;
				case 'f': return CDFCache.Instance;
				case 'g': return CDGCache.Instance;
				case 'h': return CDHCache.Instance;
				case 'i': return CDICache.Instance;
				case 'j': return CDJCache.Instance;
				case 'm': return CDMCache.Instance;
				case 'n': return CDNCache.Instance;
				case 'o': return CDOCache.Instance;
				case 'r': return CDRCache.Instance;
				case 's': return CDSCache.Instance;
				case 'y': return CDYCache.Instance;
				case 'z': return CDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ce(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CEACache.Instance;
				case 'b': return CEBCache.Instance;
				case 'g': return CEGCache.Instance;
				case 'k': return CEKCache.Instance;
				case 'l': return CELCache.Instance;
				case 'n': return CENCache.Instance;
				case 't': return CETCache.Instance;
				case 'y': return CEYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CFACache.Instance;
				case 'd': return CFDCache.Instance;
				case 'g': return CFGCache.Instance;
				case 'm': return CFMCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CGACache.Instance;
				case 'c': return CGCCache.Instance;
				case 'g': return CGGCache.Instance;
				case 'k': return CGKCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ch(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return CHBCache.Instance;
				case 'c': return CHCCache.Instance;
				case 'd': return CHDCache.Instance;
				case 'f': return CHFCache.Instance;
				case 'g': return CHGCache.Instance;
				case 'h': return CHHCache.Instance;
				case 'j': return CHJCache.Instance;
				case 'k': return CHKCache.Instance;
				case 'l': return CHLCache.Instance;
				case 'm': return CHMCache.Instance;
				case 'n': return CHNCache.Instance;
				case 'o': return CHOCache.Instance;
				case 'p': return CHPCache.Instance;
				case 'q': return CHQCache.Instance;
				case 'r': return CHRCache.Instance;
				case 't': return CHTCache.Instance;
				case 'w': return CHWCache.Instance;
				case 'x': return CHXCache.Instance;
				case 'y': return CHYCache.Instance;
				case 'z': return CHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ci(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CIACache.Instance;
				case 'b': return CIBCache.Instance;
				case 'c': return CICCache.Instance;
				case 'd': return CIDCache.Instance;
				case 'e': return CIECache.Instance;
				case 'h': return CIHCache.Instance;
				case 'k': return CIKCache.Instance;
				case 'm': return CIMCache.Instance;
				case 'n': return CINCache.Instance;
				case 'p': return CIPCache.Instance;
				case 'r': return CIRCache.Instance;
				case 'w': return CIWCache.Instance;
				case 'y': return CIYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CJACache.Instance;
				case 'e': return CJECache.Instance;
				case 'h': return CJHCache.Instance;
				case 'i': return CJICache.Instance;
				case 'k': return CJKCache.Instance;
				case 'm': return CJMCache.Instance;
				case 'n': return CJNCache.Instance;
				case 'o': return CJOCache.Instance;
				case 'p': return CJPCache.Instance;
				case 'r': return MOMCache.Instance;
				case 's': return CJSCache.Instance;
				case 'v': return CJVCache.Instance;
				case 'y': return CJYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ck(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CMRCache.Instance;
				case 'b': return CKBCache.Instance;
				case 'h': return CKHCache.Instance;
				case 'l': return CKLCache.Instance;
				case 'm': return CKMCache.Instance;
				case 'n': return CKNCache.Instance;
				case 'o': return CKOCache.Instance;
				case 'q': return CKQCache.Instance;
				case 'r': return CKRCache.Instance;
				case 's': return CKSCache.Instance;
				case 't': return CKTCache.Instance;
				case 'u': return CKUCache.Instance;
				case 'v': return CKVCache.Instance;
				case 'x': return CKXCache.Instance;
				case 'y': return CKYCache.Instance;
				case 'z': return CKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CLACache.Instance;
				case 'c': return CLCCache.Instance;
				case 'd': return CLDCache.Instance;
				case 'e': return CLECache.Instance;
				case 'h': return CLHCache.Instance;
				case 'i': return CLICache.Instance;
				case 'j': return CLJCache.Instance;
				case 'k': return CLKCache.Instance;
				case 'l': return CLLCache.Instance;
				case 'm': return CLMCache.Instance;
				case 'o': return CLOCache.Instance;
				case 's': return CLSCache.Instance;
				case 't': return CLTCache.Instance;
				case 'u': return CLUCache.Instance;
				case 'w': return CLWCache.Instance;
				case 'y': return CLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CMACache.Instance;
				case 'c': return CMCCache.Instance;
				case 'e': return CMECache.Instance;
				case 'g': return CMGCache.Instance;
				case 'i': return CMICache.Instance;
				case 'k': return XCHCache.Instance;
				case 'l': return CMLCache.Instance;
				case 'm': return CMMCache.Instance;
				case 'n': return CMNCache.Instance;
				case 'o': return CMOCache.Instance;
				case 'r': return CMRCache.Instance;
				case 's': return CMSCache.Instance;
				case 't': return CMTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CNACache.Instance;
				case 'b': return CNBCache.Instance;
				case 'c': return CNCCache.Instance;
				case 'g': return CNGCache.Instance;
				case 'h': return CNHCache.Instance;
				case 'i': return CNICache.Instance;
				case 'k': return CNKCache.Instance;
				case 'l': return CNLCache.Instance;
				case 'o': return CNOCache.Instance;
				case 'p': return CNPCache.Instance;
				case 'q': return CNQCache.Instance;
				case 'r': return CNRCache.Instance;
				case 's': return CNSCache.Instance;
				case 't': return CNTCache.Instance;
				case 'u': return CNUCache.Instance;
				case 'w': return CNWCache.Instance;
				case 'x': return CNXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_co(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return COACache.Instance;
				case 'b': return COBCache.Instance;
				case 'c': return COCCache.Instance;
				case 'd': return CODCache.Instance;
				case 'e': return COECache.Instance;
				case 'f': return COFCache.Instance;
				case 'g': return COGCache.Instance;
				case 'h': return COHCache.Instance;
				case 'j': return COJCache.Instance;
				case 'k': return COKCache.Instance;
				case 'l': return COLCache.Instance;
				case 'm': return COMCache.Instance;
				case 'n': return CONCache.Instance;
				case 'o': return COOCache.Instance;
				case 'p': return COPCache.Instance;
				case 'q': return COQCache.Instance;
				case 't': return COTCache.Instance;
				case 'u': return COUCache.Instance;
				case 'v': return COVCache.Instance;
				case 'w': return COWCache.Instance;
				case 'x': return COXCache.Instance;
				case 'y': return PIJCache.Instance;
				case 'z': return COZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CPACache.Instance;
				case 'b': return CPBCache.Instance;
				case 'c': return CPCCache.Instance;
				case 'e': return CPECache.Instance;
				case 'f': return CPFCache.Instance;
				case 'g': return CPGCache.Instance;
				case 'i': return CPICache.Instance;
				case 'n': return CPNCache.Instance;
				case 'o': return CPOCache.Instance;
				case 'p': return CPPCache.Instance;
				case 's': return CPSCache.Instance;
				case 'u': return CPUCache.Instance;
				case 'x': return CPXCache.Instance;
				case 'y': return CPYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cq(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return CQDCache.Instance;
				case 'u': return QUHCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CRACache.Instance;
				case 'b': return CRBCache.Instance;
				case 'c': return CRCCache.Instance;
				case 'd': return CRDCache.Instance;
				case 'f': return CRFCache.Instance;
				case 'g': return CRGCache.Instance;
				case 'h': return CRHCache.Instance;
				case 'i': return CRICache.Instance;
				case 'j': return CRJCache.Instance;
				case 'k': return CRKCache.Instance;
				case 'l': return CRLCache.Instance;
				case 'm': return CRMCache.Instance;
				case 'n': return CRNCache.Instance;
				case 'o': return CROCache.Instance;
				case 'p': return CRPCache.Instance;
				case 'q': return CRQCache.Instance;
				case 'r': return CRRCache.Instance;
				case 's': return CRSCache.Instance;
				case 't': return CRTCache.Instance;
				case 'v': return CRVCache.Instance;
				case 'w': return CRWCache.Instance;
				case 'x': return CRXCache.Instance;
				case 'y': return CRYCache.Instance;
				case 'z': return CRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CSACache.Instance;
				case 'b': return CSBCache.Instance;
				case 'c': return CSCCache.Instance;
				case 'd': return CSDCache.Instance;
				case 'e': return CSECache.Instance;
				case 'f': return CSFCache.Instance;
				case 'g': return CSGCache.Instance;
				case 'h': return CSHCache.Instance;
				case 'i': return CSICache.Instance;
				case 'j': return CSJCache.Instance;
				case 'k': return CSKCache.Instance;
				case 'l': return CSLCache.Instance;
				case 'm': return CSMCache.Instance;
				case 'n': return CSNCache.Instance;
				case 'o': return CSOCache.Instance;
				case 'p': return CSPCache.Instance;
				case 'q': return CSQCache.Instance;
				case 'r': return CSRCache.Instance;
				case 's': return CSSCache.Instance;
				case 't': return CSTCache.Instance;
				case 'u': return CSUCache.Instance;
				case 'v': return CSVCache.Instance;
				case 'w': return CSWCache.Instance;
				case 'x': return CSXCache.Instance;
				case 'y': return CSYCache.Instance;
				case 'z': return CSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ct(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CTACache.Instance;
				case 'c': return CTCCache.Instance;
				case 'd': return CTDCache.Instance;
				case 'e': return CTECache.Instance;
				case 'g': return CTGCache.Instance;
				case 'h': return CTHCache.Instance;
				case 'l': return CTLCache.Instance;
				case 'm': return CTMCache.Instance;
				case 'n': return CTNCache.Instance;
				case 'o': return CTOCache.Instance;
				case 'p': return CTPCache.Instance;
				case 's': return CTSCache.Instance;
				case 't': return CTTCache.Instance;
				case 'u': return CTUCache.Instance;
				case 'y': return CTYCache.Instance;
				case 'z': return CTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CUACache.Instance;
				case 'b': return CUBCache.Instance;
				case 'c': return CUCCache.Instance;
				case 'g': return CUGCache.Instance;
				case 'h': return CUHCache.Instance;
				case 'i': return CUICache.Instance;
				case 'j': return CUJCache.Instance;
				case 'k': return CUKCache.Instance;
				case 'l': return CULCache.Instance;
				case 'm': return CUMCache.Instance;
				case 'o': return CUOCache.Instance;
				case 'p': return CUPCache.Instance;
				case 'q': return CUQCache.Instance;
				case 'r': return CURCache.Instance;
				case 's': return CUSCache.Instance;
				case 't': return CUTCache.Instance;
				case 'u': return CUUCache.Instance;
				case 'v': return CUVCache.Instance;
				case 'w': return CUWCache.Instance;
				case 'x': return CUXCache.Instance;
				case 'y': return CUYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cv(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return CVGCache.Instance;
				case 'n': return CVNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CWACache.Instance;
				case 'b': return CWBCache.Instance;
				case 'd': return CWDCache.Instance;
				case 'e': return CWECache.Instance;
				case 'g': return CWGCache.Instance;
				case 't': return CWTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return CXHCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_cy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CYACache.Instance;
				case 'b': return CYBCache.Instance;
				case 'o': return CYOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return CZHCache.Instance;
				case 'k': return CZKCache.Instance;
				case 'n': return CZNCache.Instance;
				case 'o': return CZOCache.Instance;
				case 't': return CZTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_da(span);
				case 'b': return tryParse_L3_db(span);
				case 'c': return tryParse_L3_dc(span);
				case 'd': return tryParse_L3_dd(span);
				case 'e': return tryParse_L3_de(span);
				case 'g': return tryParse_L3_dg(span);
				case 'h': return tryParse_L3_dh(span);
				case 'i': return tryParse_L3_di(span);
				case 'j': return tryParse_L3_dj(span);
				case 'k': return tryParse_L3_dk(span);
				case 'l': return tryParse_L3_dl(span);
				case 'm': return tryParse_L3_dm(span);
				case 'n': return tryParse_L3_dn(span);
				case 'o': return tryParse_L3_do(span);
				case 'p': return tryParse_L3_dp(span);
				case 'r': return tryParse_L3_dr(span);
				case 's': return tryParse_L3_ds(span);
				case 't': return tryParse_L3_dt(span);
				case 'u': return tryParse_L3_du(span);
				case 'v': return tryParse_L3_dv(span);
				case 'w': return tryParse_L3_dw(span);
				case 'y': return tryParse_L3_dy(span);
				case 'z': return tryParse_L3_dz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_da(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DAACache.Instance;
				case 'c': return DACCache.Instance;
				case 'd': return DADCache.Instance;
				case 'e': return DAECache.Instance;
				case 'f': return DAFCache.Instance;
				case 'g': return DAGCache.Instance;
				case 'h': return DAHCache.Instance;
				case 'i': return DAICache.Instance;
				case 'j': return DAJCache.Instance;
				case 'k': return DAKCache.Instance;
				case 'l': return DALCache.Instance;
				case 'm': return DAMCache.Instance;
				case 'o': return DAOCache.Instance;
				case 'p': return DAPCache.Instance;
				case 'q': return DAQCache.Instance;
				case 'r': return DARCache.Instance;
				case 's': return DASCache.Instance;
				case 'u': return DAUCache.Instance;
				case 'v': return DAVCache.Instance;
				case 'w': return DAWCache.Instance;
				case 'x': return DAXCache.Instance;
				case 'y': return DAYCache.Instance;
				case 'z': return DAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_db(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DBACache.Instance;
				case 'b': return DBBCache.Instance;
				case 'd': return DBDCache.Instance;
				case 'e': return DBECache.Instance;
				case 'f': return DBFCache.Instance;
				case 'g': return DBGCache.Instance;
				case 'i': return DBICache.Instance;
				case 'j': return DBJCache.Instance;
				case 'l': return DBLCache.Instance;
				case 'm': return DBMCache.Instance;
				case 'n': return DBNCache.Instance;
				case 'o': return DBOCache.Instance;
				case 'p': return DBPCache.Instance;
				case 'q': return DBQCache.Instance;
				case 'r': return DBRCache.Instance;
				case 't': return DBTCache.Instance;
				case 'u': return DBUCache.Instance;
				case 'v': return DBVCache.Instance;
				case 'w': return DBWCache.Instance;
				case 'y': return DBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return DCCCache.Instance;
				case 'r': return DCRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DDACache.Instance;
				case 'd': return DDDCache.Instance;
				case 'e': return DDECache.Instance;
				case 'g': return DDGCache.Instance;
				case 'i': return DDICache.Instance;
				case 'j': return DDJCache.Instance;
				case 'n': return DDNCache.Instance;
				case 'o': return DDOCache.Instance;
				case 'r': return DDRCache.Instance;
				case 's': return DDSCache.Instance;
				case 'w': return DDWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_de(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return DECCache.Instance;
				case 'd': return DEDCache.Instance;
				case 'e': return DEECache.Instance;
				case 'f': return DEFCache.Instance;
				case 'g': return DEGCache.Instance;
				case 'h': return DEHCache.Instance;
				case 'i': return DEICache.Instance;
				case 'k': return SQMCache.Instance;
				case 'l': return DELCache.Instance;
				case 'm': return DEMCache.Instance;
				case 'n': return DENCache.Instance;
				case 'p': return DEPCache.Instance;
				case 'q': return DEQCache.Instance;
				case 'r': return DERCache.Instance;
				case 's': return DESCache.Instance;
				case 'v': return DEVCache.Instance;
				case 'z': return DEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DGACache.Instance;
				case 'b': return DGBCache.Instance;
				case 'c': return DGCCache.Instance;
				case 'd': return DGDCache.Instance;
				case 'e': return DGECache.Instance;
				case 'g': return DGGCache.Instance;
				case 'h': return DGHCache.Instance;
				case 'i': return DGICache.Instance;
				case 'k': return DGKCache.Instance;
				case 'l': return DGLCache.Instance;
				case 'n': return DGNCache.Instance;
				case 'o': return DGOCache.Instance;
				case 'r': return DGRCache.Instance;
				case 's': return DGSCache.Instance;
				case 't': return DGTCache.Instance;
				case 'u': return DGUCache.Instance;
				case 'w': return DGWCache.Instance;
				case 'x': return DGXCache.Instance;
				case 'z': return DGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DHACache.Instance;
				case 'd': return DHDCache.Instance;
				case 'g': return DHGCache.Instance;
				case 'i': return DHICache.Instance;
				case 'l': return DHLCache.Instance;
				case 'm': return DHMCache.Instance;
				case 'n': return DHNCache.Instance;
				case 'o': return DHOCache.Instance;
				case 'r': return DHRCache.Instance;
				case 's': return DHSCache.Instance;
				case 'u': return DHUCache.Instance;
				case 'v': return DHVCache.Instance;
				case 'w': return DHWCache.Instance;
				case 'x': return DHXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_di(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DIACache.Instance;
				case 'b': return DIBCache.Instance;
				case 'c': return DICCache.Instance;
				case 'd': return DIDCache.Instance;
				case 'f': return DIFCache.Instance;
				case 'g': return DIGCache.Instance;
				case 'h': return DIHCache.Instance;
				case 'i': return DIICache.Instance;
				case 'j': return DIJCache.Instance;
				case 'k': return DIKCache.Instance;
				case 'l': return DILCache.Instance;
				case 'm': return DIMCache.Instance;
				case 'n': return DINCache.Instance;
				case 'o': return DIOCache.Instance;
				case 'p': return DIPCache.Instance;
				case 'q': return DIQCache.Instance;
				case 'r': return DIRCache.Instance;
				case 's': return DISCache.Instance;
				case 't': return DIFCache.Instance;
				case 'u': return DIUCache.Instance;
				case 'w': return DIWCache.Instance;
				case 'x': return DIXCache.Instance;
				case 'y': return DIYCache.Instance;
				case 'z': return DIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DJACache.Instance;
				case 'b': return DJBCache.Instance;
				case 'c': return DJCCache.Instance;
				case 'd': return DJDCache.Instance;
				case 'e': return DJECache.Instance;
				case 'f': return DJFCache.Instance;
				case 'i': return DJICache.Instance;
				case 'j': return DJJCache.Instance;
				case 'k': return DJKCache.Instance;
				case 'l': return DJLCache.Instance;
				case 'm': return DJMCache.Instance;
				case 'n': return DJNCache.Instance;
				case 'o': return DJOCache.Instance;
				case 'r': return DJRCache.Instance;
				case 'u': return DJUCache.Instance;
				case 'w': return DJWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DKACache.Instance;
				case 'g': return DKGCache.Instance;
				case 'k': return DKKCache.Instance;
				case 'l': return DKLCache.Instance;
				case 'r': return DKRCache.Instance;
				case 's': return DKSCache.Instance;
				case 'x': return DKXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dl(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return DLGCache.Instance;
				case 'k': return DLKCache.Instance;
				case 'm': return DLMCache.Instance;
				case 'n': return DLNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DMACache.Instance;
				case 'b': return DMBCache.Instance;
				case 'c': return DMCCache.Instance;
				case 'd': return DMDCache.Instance;
				case 'e': return DMECache.Instance;
				case 'f': return DMFCache.Instance;
				case 'g': return DMGCache.Instance;
				case 'k': return DMKCache.Instance;
				case 'l': return DMLCache.Instance;
				case 'm': return DMMCache.Instance;
				case 'n': return DMNCache.Instance;
				case 'o': return DMOCache.Instance;
				case 'r': return DMRCache.Instance;
				case 's': return DMSCache.Instance;
				case 'u': return DMUCache.Instance;
				case 'v': return DMVCache.Instance;
				case 'w': return DMWCache.Instance;
				case 'x': return DMXCache.Instance;
				case 'y': return DMYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DNACache.Instance;
				case 'd': return DNDCache.Instance;
				case 'e': return DNECache.Instance;
				case 'g': return DNGCache.Instance;
				case 'i': return DNICache.Instance;
				case 'j': return DNJCache.Instance;
				case 'k': return DNKCache.Instance;
				case 'n': return DNNCache.Instance;
				case 'o': return DNOCache.Instance;
				case 'r': return DNRCache.Instance;
				case 't': return DNTCache.Instance;
				case 'u': return DNUCache.Instance;
				case 'v': return DNVCache.Instance;
				case 'w': return DNWCache.Instance;
				case 'y': return DNYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_do(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DOACache.Instance;
				case 'b': return DOBCache.Instance;
				case 'c': return DOCCache.Instance;
				case 'e': return DOECache.Instance;
				case 'f': return DOFCache.Instance;
				case 'h': return DOHCache.Instance;
				case 'i': return DOICache.Instance;
				case 'k': return DOKCache.Instance;
				case 'l': return DOLCache.Instance;
				case 'n': return DONCache.Instance;
				case 'o': return DOOCache.Instance;
				case 'p': return DOPCache.Instance;
				case 'q': return DOQCache.Instance;
				case 'r': return DORCache.Instance;
				case 's': return DOSCache.Instance;
				case 't': return DOTCache.Instance;
				case 'v': return DOVCache.Instance;
				case 'w': return DOWCache.Instance;
				case 'x': return DOXCache.Instance;
				case 'y': return DOYCache.Instance;
				case 'z': return DOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return DPPCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_dr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DRACache.Instance;
				case 'b': return DRBCache.Instance;
				case 'c': return DRCCache.Instance;
				case 'd': return DRDCache.Instance;
				case 'e': return DRECache.Instance;
				case 'g': return DRGCache.Instance;
				case 'h': return KHKCache.Instance;
				case 'i': return DRICache.Instance;
				case 'l': return DRLCache.Instance;
				case 'n': return DRNCache.Instance;
				case 'o': return DROCache.Instance;
				case 'q': return DRQCache.Instance;
				case 'r': return KZKCache.Instance;
				case 's': return DRSCache.Instance;
				case 't': return DRTCache.Instance;
				case 'u': return DRUCache.Instance;
				case 'w': return PRSCache.Instance;
				case 'y': return DRYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ds(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return DSBCache.Instance;
				case 'e': return DSECache.Instance;
				case 'h': return DSHCache.Instance;
				case 'i': return DSICache.Instance;
				case 'k': return DSKCache.Instance;
				case 'l': return DSLCache.Instance;
				case 'n': return DSNCache.Instance;
				case 'o': return DSOCache.Instance;
				case 'q': return DSQCache.Instance;
				case 'z': return DSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DTACache.Instance;
				case 'b': return DTBCache.Instance;
				case 'd': return DTDCache.Instance;
				case 'h': return DTHCache.Instance;
				case 'i': return DTICache.Instance;
				case 'k': return DTKCache.Instance;
				case 'm': return DTMCache.Instance;
				case 'n': return DTNCache.Instance;
				case 'o': return DTOCache.Instance;
				case 'p': return DTPCache.Instance;
				case 'r': return DTRCache.Instance;
				case 's': return DTSCache.Instance;
				case 't': return DTTCache.Instance;
				case 'u': return DTUCache.Instance;
				case 'y': return DTYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_du(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DUACache.Instance;
				case 'b': return DUBCache.Instance;
				case 'c': return DUCCache.Instance;
				case 'd': return DUDCache.Instance;
				case 'e': return DUECache.Instance;
				case 'f': return DUFCache.Instance;
				case 'g': return DUGCache.Instance;
				case 'h': return DUHCache.Instance;
				case 'i': return DUICache.Instance;
				case 'j': return DUJCache.Instance;
				case 'k': return DUKCache.Instance;
				case 'l': return DULCache.Instance;
				case 'm': return DUMCache.Instance;
				case 'n': return DUNCache.Instance;
				case 'o': return DUOCache.Instance;
				case 'p': return DUPCache.Instance;
				case 'q': return DUQCache.Instance;
				case 'r': return DURCache.Instance;
				case 's': return DUSCache.Instance;
				case 'u': return DUUCache.Instance;
				case 'v': return DUVCache.Instance;
				case 'w': return DUWCache.Instance;
				case 'x': return DUXCache.Instance;
				case 'y': return DUYCache.Instance;
				case 'z': return DUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return DVACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_dw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DWACache.Instance;
				case 'k': return DWKCache.Instance;
				case 'l': return DWLCache.Instance;
				case 'r': return DWRCache.Instance;
				case 's': return DWSCache.Instance;
				case 'u': return DWUCache.Instance;
				case 'w': return DWWCache.Instance;
				case 'y': return DWYCache.Instance;
				case 'z': return DWZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DYACache.Instance;
				case 'b': return DYBCache.Instance;
				case 'd': return DYDCache.Instance;
				case 'g': return DYGCache.Instance;
				case 'i': return DYICache.Instance;
				case 'm': return DYMCache.Instance;
				case 'n': return DYNCache.Instance;
				case 'o': return DYOCache.Instance;
				case 'r': return DYRCache.Instance;
				case 'u': return DYUCache.Instance;
				case 'y': return DYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DZACache.Instance;
				case 'd': return DZDCache.Instance;
				case 'e': return DZECache.Instance;
				case 'g': return DZGCache.Instance;
				case 'l': return DZLCache.Instance;
				case 'n': return DZNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ea(span);
				case 'b': return tryParse_L3_eb(span);
				case 'c': return tryParse_L3_ec(span);
				case 'e': return tryParse_L3_ee(span);
				case 'f': return tryParse_L3_ef(span);
				case 'g': return tryParse_L3_eg(span);
				case 'h': return tryParse_L3_eh(span);
				case 'i': return tryParse_L3_ei(span);
				case 'j': return tryParse_L3_ej(span);
				case 'k': return tryParse_L3_ek(span);
				case 'l': return tryParse_L3_el(span);
				case 'm': return tryParse_L3_em(span);
				case 'n': return tryParse_L3_en(span);
				case 'o': return tryParse_L3_eo(span);
				case 'p': return tryParse_L3_ep(span);
				case 'r': return tryParse_L3_er(span);
				case 's': return tryParse_L3_es(span);
				case 't': return tryParse_L3_et(span);
				case 'u': return tryParse_L3_eu(span);
				case 'v': return tryParse_L3_ev(span);
				case 'w': return tryParse_L3_ew(span);
				case 'x': return tryParse_L3_ex(span);
				case 'y': return tryParse_L3_ey(span);
				case 'z': return tryParse_L3_ez(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ea(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return EAACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_eb(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return EBCCache.Instance;
				case 'g': return EBGCache.Instance;
				case 'k': return EBKCache.Instance;
				case 'o': return EBOCache.Instance;
				case 'r': return EBRCache.Instance;
				case 'u': return EBUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ec(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return ECRCache.Instance;
				case 's': return ECSCache.Instance;
				case 'y': return ECYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ee(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return EEECache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ef(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EFACache.Instance;
				case 'e': return EFECache.Instance;
				case 'i': return EFICache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EGACache.Instance;
				case 'l': return EGLCache.Instance;
				case 'm': return EGMCache.Instance;
				case 'o': return EGOCache.Instance;
				case 'x': return EGXCache.Instance;
				case 'y': return EGYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eh(StringSpan span)
		{
			switch(span[2])
			{
				case 's': return EHSCache.Instance;
				case 'u': return EHUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ei(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return EIPCache.Instance;
				case 't': return EITCache.Instance;
				case 'v': return EIVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ej(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return EJACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ek(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EKACache.Instance;
				case 'c': return EKCCache.Instance;
				case 'e': return EKECache.Instance;
				case 'g': return EKGCache.Instance;
				case 'i': return EKICache.Instance;
				case 'k': return EKKCache.Instance;
				case 'l': return EKLCache.Instance;
				case 'm': return EKMCache.Instance;
				case 'o': return EKOCache.Instance;
				case 'p': return EKPCache.Instance;
				case 'r': return EKRCache.Instance;
				case 'y': return EKYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_el(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ELECache.Instance;
				case 'h': return ELHCache.Instance;
				case 'i': return ELICache.Instance;
				case 'k': return ELKCache.Instance;
				case 'm': return ELMCache.Instance;
				case 'o': return ELOCache.Instance;
				case 'p': return ELPCache.Instance;
				case 'u': return ELUCache.Instance;
				case 'x': return ELXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_em(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EMACache.Instance;
				case 'b': return EMBCache.Instance;
				case 'e': return EMECache.Instance;
				case 'g': return EMGCache.Instance;
				case 'i': return EMICache.Instance;
				case 'k': return EMKCache.Instance;
				case 'm': return EMMCache.Instance;
				case 'n': return EMNCache.Instance;
				case 'o': return EMOCache.Instance;
				case 'p': return EMPCache.Instance;
				case 'q': return EMQCache.Instance;
				case 's': return EMSCache.Instance;
				case 'u': return EMUCache.Instance;
				case 'w': return EMWCache.Instance;
				case 'x': return EMXCache.Instance;
				case 'y': return EMYCache.Instance;
				case 'z': return EMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_en(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ENACache.Instance;
				case 'b': return ENBCache.Instance;
				case 'c': return ENCCache.Instance;
				case 'd': return ENDCache.Instance;
				case 'f': return ENFCache.Instance;
				case 'h': return ENHCache.Instance;
				case 'l': return ENLCache.Instance;
				case 'm': return ENMCache.Instance;
				case 'n': return ENNCache.Instance;
				case 'o': return ENOCache.Instance;
				case 'q': return ENQCache.Instance;
				case 'r': return ENRCache.Instance;
				case 'u': return ENUCache.Instance;
				case 'v': return ENVCache.Instance;
				case 'w': return ENWCache.Instance;
				case 'x': return ENXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return EOTCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ep(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return EPICache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_er(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ERACache.Instance;
				case 'g': return ERGCache.Instance;
				case 'h': return ERHCache.Instance;
				case 'i': return ERICache.Instance;
				case 'k': return ERKCache.Instance;
				case 'o': return EROCache.Instance;
				case 'r': return ERRCache.Instance;
				case 's': return ERSCache.Instance;
				case 't': return ERTCache.Instance;
				case 'w': return ERWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_es(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ESECache.Instance;
				case 'g': return ESGCache.Instance;
				case 'h': return ESHCache.Instance;
				case 'i': return ESICache.Instance;
				case 'k': return ESKCache.Instance;
				case 'l': return ESLCache.Instance;
				case 'm': return ESMCache.Instance;
				case 'n': return ESNCache.Instance;
				case 'o': return ESOCache.Instance;
				case 'q': return ESQCache.Instance;
				case 's': return ESSCache.Instance;
				case 'u': return ESUCache.Instance;
				case 'x': return ESXCache.Instance;
				case 'y': return ESYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_et(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ETBCache.Instance;
				case 'c': return ETCCache.Instance;
				case 'h': return ETHCache.Instance;
				case 'n': return ETNCache.Instance;
				case 'o': return ETOCache.Instance;
				case 'r': return ETRCache.Instance;
				case 's': return ETSCache.Instance;
				case 't': return ETTCache.Instance;
				case 'u': return ETUCache.Instance;
				case 'x': return ETXCache.Instance;
				case 'z': return ETZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eu(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return EUDCache.Instance;
				case 'q': return EUQCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ev(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return EVECache.Instance;
				case 'h': return EVHCache.Instance;
				case 'n': return EVNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ew(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return EWOCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ex(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return EXTCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ey(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EYACache.Instance;
				case 'o': return EYOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ez(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EZACache.Instance;
				case 'e': return EZECache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_fa(span);
				case 'b': return tryParse_L3_fb(span);
				case 'c': return tryParse_L3_fc(span);
				case 'e': return tryParse_L3_fe(span);
				case 'f': return tryParse_L3_ff(span);
				case 'g': return tryParse_L3_fg(span);
				case 'i': return tryParse_L3_fi(span);
				case 'k': return tryParse_L3_fk(span);
				case 'l': return tryParse_L3_fl(span);
				case 'm': return tryParse_L3_fm(span);
				case 'n': return tryParse_L3_fn(span);
				case 'o': return tryParse_L3_fo(span);
				case 'p': return tryParse_L3_fp(span);
				case 'q': return tryParse_L3_fq(span);
				case 'r': return tryParse_L3_fr(span);
				case 's': return tryParse_L3_fs(span);
				case 'u': return tryParse_L3_fu(span);
				case 'v': return tryParse_L3_fv(span);
				case 'w': return tryParse_L3_fw(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FAACache.Instance;
				case 'b': return FABCache.Instance;
				case 'd': return FADCache.Instance;
				case 'f': return FAFCache.Instance;
				case 'g': return FAGCache.Instance;
				case 'h': return FAHCache.Instance;
				case 'i': return FAICache.Instance;
				case 'j': return FAJCache.Instance;
				case 'k': return FAKCache.Instance;
				case 'l': return FALCache.Instance;
				case 'm': return FAMCache.Instance;
				case 'n': return FANCache.Instance;
				case 'p': return FAPCache.Instance;
				case 'r': return FARCache.Instance;
				case 't': return FATCache.Instance;
				case 'u': return FAUCache.Instance;
				case 'x': return FAXCache.Instance;
				case 'y': return FAYCache.Instance;
				case 'z': return FAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return FBLCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return FCSCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FERCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ff(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return FFICache.Instance;
				case 'm': return FFMCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FGRCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FIACache.Instance;
				case 'e': return FIECache.Instance;
				case 'f': return FIFCache.Instance;
				case 'l': return FILCache.Instance;
				case 'p': return FIPCache.Instance;
				case 'r': return FIRCache.Instance;
				case 't': return FITCache.Instance;
				case 'u': return FIUCache.Instance;
				case 'w': return FIWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fk(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return FKKCache.Instance;
				case 'v': return FKVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FLACache.Instance;
				case 'h': return FLHCache.Instance;
				case 'i': return FLICache.Instance;
				case 'l': return FLLCache.Instance;
				case 'n': return FLNCache.Instance;
				case 'r': return FLRCache.Instance;
				case 'y': return FLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fm(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return FMPCache.Instance;
				case 'u': return FMUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return FNBCache.Instance;
				case 'g': return FNGCache.Instance;
				case 'i': return FNICache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fo(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return FODCache.Instance;
				case 'i': return FOICache.Instance;
				case 'm': return FOMCache.Instance;
				case 'n': return FONCache.Instance;
				case 'r': return FORCache.Instance;
				case 's': return FOSCache.Instance;
				case 'x': return FOXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return FPECache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return FQSCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fr(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return FRCCache.Instance;
				case 'd': return FRDCache.Instance;
				case 'k': return FRKCache.Instance;
				case 'm': return FRMCache.Instance;
				case 'o': return FROCache.Instance;
				case 'p': return FRPCache.Instance;
				case 'q': return FRQCache.Instance;
				case 'r': return FRRCache.Instance;
				case 's': return FRSCache.Instance;
				case 't': return FRTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return FSECache.Instance;
				case 'l': return FSLCache.Instance;
				case 's': return FSSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fu(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return FUBCache.Instance;
				case 'c': return FUCCache.Instance;
				case 'd': return FUDCache.Instance;
				case 'e': return FUECache.Instance;
				case 'f': return FUFCache.Instance;
				case 'h': return FUHCache.Instance;
				case 'i': return FUICache.Instance;
				case 'j': return FUJCache.Instance;
				case 'm': return FUMCache.Instance;
				case 'n': return FUNCache.Instance;
				case 'q': return FUQCache.Instance;
				case 'r': return FURCache.Instance;
				case 't': return FUTCache.Instance;
				case 'u': return FUUCache.Instance;
				case 'v': return FUVCache.Instance;
				case 'y': return FUYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FVRCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_fw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FWACache.Instance;
				case 'e': return FWECache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ga(span);
				case 'b': return tryParse_L3_gb(span);
				case 'c': return tryParse_L3_gc(span);
				case 'd': return tryParse_L3_gd(span);
				case 'e': return tryParse_L3_ge(span);
				case 'f': return tryParse_L3_gf(span);
				case 'g': return tryParse_L3_gg(span);
				case 'h': return tryParse_L3_gh(span);
				case 'i': return tryParse_L3_gi(span);
				case 'j': return tryParse_L3_gj(span);
				case 'k': return tryParse_L3_gk(span);
				case 'l': return tryParse_L3_gl(span);
				case 'm': return tryParse_L3_gm(span);
				case 'n': return tryParse_L3_gn(span);
				case 'o': return tryParse_L3_go(span);
				case 'p': return tryParse_L3_gp(span);
				case 'q': return tryParse_L3_gq(span);
				case 'r': return tryParse_L3_gr(span);
				case 's': return tryParse_L3_gs(span);
				case 't': return tryParse_L3_gt(span);
				case 'u': return tryParse_L3_gu(span);
				case 'v': return tryParse_L3_gv(span);
				case 'w': return tryParse_L3_gw(span);
				case 'x': return tryParse_L3_gx(span);
				case 'y': return tryParse_L3_gy(span);
				case 'z': return tryParse_L3_gz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ga(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GAACache.Instance;
				case 'b': return GABCache.Instance;
				case 'c': return GACCache.Instance;
				case 'd': return GADCache.Instance;
				case 'e': return GAECache.Instance;
				case 'f': return GAFCache.Instance;
				case 'g': return GAGCache.Instance;
				case 'h': return GAHCache.Instance;
				case 'i': return GAICache.Instance;
				case 'j': return GAJCache.Instance;
				case 'k': return GAKCache.Instance;
				case 'l': return GALCache.Instance;
				case 'm': return GAMCache.Instance;
				case 'n': return GANCache.Instance;
				case 'o': return GAOCache.Instance;
				case 'p': return GAPCache.Instance;
				case 'q': return GAQCache.Instance;
				case 'r': return GARCache.Instance;
				case 's': return GASCache.Instance;
				case 't': return GATCache.Instance;
				case 'u': return GAUCache.Instance;
				case 'v': return DEVCache.Instance;
				case 'w': return GAWCache.Instance;
				case 'x': return GAXCache.Instance;
				case 'y': return GAYCache.Instance;
				case 'z': return GAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GBACache.Instance;
				case 'b': return GBBCache.Instance;
				case 'c': return GBCCache.Instance;
				case 'd': return GBDCache.Instance;
				case 'e': return GBECache.Instance;
				case 'f': return GBFCache.Instance;
				case 'g': return GBGCache.Instance;
				case 'h': return GBHCache.Instance;
				case 'i': return GBICache.Instance;
				case 'j': return GBJCache.Instance;
				case 'k': return GBKCache.Instance;
				case 'l': return GBLCache.Instance;
				case 'm': return GBMCache.Instance;
				case 'n': return GBNCache.Instance;
				case 'o': return GBOCache.Instance;
				case 'p': return GBPCache.Instance;
				case 'q': return GBQCache.Instance;
				case 'r': return GBRCache.Instance;
				case 's': return GBSCache.Instance;
				case 'u': return GBUCache.Instance;
				case 'v': return GBVCache.Instance;
				case 'w': return GBWCache.Instance;
				case 'x': return GBXCache.Instance;
				case 'y': return GBYCache.Instance;
				case 'z': return GBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return GCCCache.Instance;
				case 'd': return GCDCache.Instance;
				case 'e': return GCECache.Instance;
				case 'f': return GCFCache.Instance;
				case 'l': return GCLCache.Instance;
				case 'n': return GCNCache.Instance;
				case 'r': return GCRCache.Instance;
				case 't': return GCTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GDACache.Instance;
				case 'b': return GDBCache.Instance;
				case 'c': return GDCCache.Instance;
				case 'd': return GDDCache.Instance;
				case 'e': return GDECache.Instance;
				case 'f': return GDFCache.Instance;
				case 'g': return GDGCache.Instance;
				case 'h': return GDHCache.Instance;
				case 'i': return GDICache.Instance;
				case 'j': return GDJCache.Instance;
				case 'k': return GDKCache.Instance;
				case 'l': return GDLCache.Instance;
				case 'm': return GDMCache.Instance;
				case 'n': return GDNCache.Instance;
				case 'o': return GDOCache.Instance;
				case 'q': return GDQCache.Instance;
				case 'r': return GDRCache.Instance;
				case 's': return GDSCache.Instance;
				case 't': return GDTCache.Instance;
				case 'u': return GDUCache.Instance;
				case 'x': return GDXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ge(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GEACache.Instance;
				case 'b': return GEBCache.Instance;
				case 'c': return GECCache.Instance;
				case 'd': return GEDCache.Instance;
				case 'f': return GEFCache.Instance;
				case 'g': return GEGCache.Instance;
				case 'h': return GEHCache.Instance;
				case 'i': return GEICache.Instance;
				case 'j': return GEJCache.Instance;
				case 'k': return GEKCache.Instance;
				case 'l': return GELCache.Instance;
				case 'm': return GEMCache.Instance;
				case 'q': return GEQCache.Instance;
				case 's': return GESCache.Instance;
				case 'v': return GEVCache.Instance;
				case 'w': return GEWCache.Instance;
				case 'x': return GEXCache.Instance;
				case 'y': return GEYCache.Instance;
				case 'z': return GEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gf(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return GFKCache.Instance;
				case 't': return GFTCache.Instance;
				case 'x': return VAJCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GGACache.Instance;
				case 'b': return GGBCache.Instance;
				case 'd': return GGDCache.Instance;
				case 'e': return GGECache.Instance;
				case 'g': return GGGCache.Instance;
				case 'k': return GGKCache.Instance;
				case 'l': return GGLCache.Instance;
				case 'n': return GVRCache.Instance;
				case 'o': return GGOCache.Instance;
				case 'r': return GGRCache.Instance;
				case 't': return GGTCache.Instance;
				case 'u': return GGUCache.Instance;
				case 'w': return GGWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GHACache.Instance;
				case 'c': return GHCCache.Instance;
				case 'e': return GHECache.Instance;
				case 'h': return GHHCache.Instance;
				case 'k': return GHKCache.Instance;
				case 'l': return GHLCache.Instance;
				case 'n': return GHNCache.Instance;
				case 'o': return GHOCache.Instance;
				case 'r': return GHRCache.Instance;
				case 's': return GHSCache.Instance;
				case 't': return GHTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GIACache.Instance;
				case 'b': return GIBCache.Instance;
				case 'c': return GICCache.Instance;
				case 'd': return GIDCache.Instance;
				case 'e': return GIECache.Instance;
				case 'g': return GIGCache.Instance;
				case 'h': return GIHCache.Instance;
				case 'i': return GIICache.Instance;
				case 'l': return GILCache.Instance;
				case 'm': return GIMCache.Instance;
				case 'n': return GINCache.Instance;
				case 'o': return GIOCache.Instance;
				case 'p': return GIPCache.Instance;
				case 'q': return GIQCache.Instance;
				case 'r': return GIRCache.Instance;
				case 's': return GISCache.Instance;
				case 't': return GITCache.Instance;
				case 'u': return GIUCache.Instance;
				case 'w': return GIWCache.Instance;
				case 'x': return GIXCache.Instance;
				case 'y': return GIYCache.Instance;
				case 'z': return GIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gj(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return GJICache.Instance;
				case 'k': return GJKCache.Instance;
				case 'm': return GJMCache.Instance;
				case 'n': return GJNCache.Instance;
				case 'r': return GJRCache.Instance;
				case 'u': return GJUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GKACache.Instance;
				case 'd': return GKDCache.Instance;
				case 'e': return GKECache.Instance;
				case 'n': return GKNCache.Instance;
				case 'o': return GKOCache.Instance;
				case 'p': return GKPCache.Instance;
				case 'u': return GKUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gl(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return GLBCache.Instance;
				case 'c': return GLCCache.Instance;
				case 'd': return GLDCache.Instance;
				case 'h': return GLHCache.Instance;
				case 'i': return KZKCache.Instance;
				case 'j': return GLJCache.Instance;
				case 'k': return GLKCache.Instance;
				case 'l': return GLLCache.Instance;
				case 'o': return GLOCache.Instance;
				case 'r': return GLRCache.Instance;
				case 'u': return GLUCache.Instance;
				case 'w': return GLWCache.Instance;
				case 'y': return GLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GMACache.Instance;
				case 'b': return GMBCache.Instance;
				case 'd': return GMDCache.Instance;
				case 'e': return GMECache.Instance;
				case 'g': return GMGCache.Instance;
				case 'h': return GMHCache.Instance;
				case 'l': return GMLCache.Instance;
				case 'm': return GMMCache.Instance;
				case 'n': return GMNCache.Instance;
				case 'q': return GMQCache.Instance;
				case 'r': return GMRCache.Instance;
				case 'u': return GMUCache.Instance;
				case 'v': return GMVCache.Instance;
				case 'w': return GMWCache.Instance;
				case 'x': return GMXCache.Instance;
				case 'y': return GMYCache.Instance;
				case 'z': return GMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GNACache.Instance;
				case 'b': return GNBCache.Instance;
				case 'c': return GNCCache.Instance;
				case 'd': return GNDCache.Instance;
				case 'e': return GNECache.Instance;
				case 'g': return GNGCache.Instance;
				case 'h': return GNHCache.Instance;
				case 'i': return GNICache.Instance;
				case 'j': return GNJCache.Instance;
				case 'k': return GNKCache.Instance;
				case 'l': return GNLCache.Instance;
				case 'm': return GNMCache.Instance;
				case 'n': return GNNCache.Instance;
				case 'o': return GNOCache.Instance;
				case 'q': return GNQCache.Instance;
				case 'r': return GNRCache.Instance;
				case 't': return GNTCache.Instance;
				case 'u': return GNUCache.Instance;
				case 'w': return GNWCache.Instance;
				case 'z': return GNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_go(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GOACache.Instance;
				case 'b': return GOBCache.Instance;
				case 'c': return GOCCache.Instance;
				case 'd': return GODCache.Instance;
				case 'e': return GOECache.Instance;
				case 'f': return GOFCache.Instance;
				case 'g': return GOGCache.Instance;
				case 'h': return GOHCache.Instance;
				case 'i': return GOICache.Instance;
				case 'j': return GOJCache.Instance;
				case 'k': return GOKCache.Instance;
				case 'l': return GOLCache.Instance;
				case 'm': return GOMCache.Instance;
				case 'n': return GONCache.Instance;
				case 'o': return GOOCache.Instance;
				case 'p': return GOPCache.Instance;
				case 'q': return GOQCache.Instance;
				case 'r': return GORCache.Instance;
				case 's': return GOSCache.Instance;
				case 't': return GOTCache.Instance;
				case 'u': return GOUCache.Instance;
				case 'v': return GOVCache.Instance;
				case 'w': return GOWCache.Instance;
				case 'x': return GOXCache.Instance;
				case 'y': return GOYCache.Instance;
				case 'z': return GOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GPACache.Instance;
				case 'e': return GPECache.Instance;
				case 'n': return GPNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GQACache.Instance;
				case 'i': return GQICache.Instance;
				case 'n': return GQNCache.Instance;
				case 'r': return GQRCache.Instance;
				case 'u': return GQUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GRACache.Instance;
				case 'b': return GRBCache.Instance;
				case 'c': return GRCCache.Instance;
				case 'd': return GRDCache.Instance;
				case 'g': return GRGCache.Instance;
				case 'h': return GRHCache.Instance;
				case 'i': return GRICache.Instance;
				case 'j': return GRJCache.Instance;
				case 'k': return GRKCache.Instance;
				case 'm': return GRMCache.Instance;
				case 'o': return GROCache.Instance;
				case 'q': return GRQCache.Instance;
				case 'r': return GRRCache.Instance;
				case 's': return GRSCache.Instance;
				case 't': return GRTCache.Instance;
				case 'u': return GRUCache.Instance;
				case 'v': return GRVCache.Instance;
				case 'w': return GRWCache.Instance;
				case 'x': return GRXCache.Instance;
				case 'y': return GRYCache.Instance;
				case 'z': return GRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return GSECache.Instance;
				case 'g': return GSGCache.Instance;
				case 'l': return GSLCache.Instance;
				case 'm': return GSMCache.Instance;
				case 'n': return GSNCache.Instance;
				case 'o': return GSOCache.Instance;
				case 'p': return GSPCache.Instance;
				case 's': return GSSCache.Instance;
				case 'w': return GSWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GTACache.Instance;
				case 'i': return NYCCache.Instance;
				case 'u': return GTUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GUACache.Instance;
				case 'b': return GUBCache.Instance;
				case 'c': return GUCCache.Instance;
				case 'd': return GUDCache.Instance;
				case 'e': return GUECache.Instance;
				case 'f': return GUFCache.Instance;
				case 'g': return GUGCache.Instance;
				case 'h': return GUHCache.Instance;
				case 'i': return GUICache.Instance;
				case 'k': return GUKCache.Instance;
				case 'l': return GULCache.Instance;
				case 'm': return GUMCache.Instance;
				case 'n': return GUNCache.Instance;
				case 'o': return GUOCache.Instance;
				case 'p': return GUPCache.Instance;
				case 'q': return GUQCache.Instance;
				case 'r': return GURCache.Instance;
				case 's': return GUSCache.Instance;
				case 't': return GUTCache.Instance;
				case 'u': return GUUCache.Instance;
				case 'v': return DUZCache.Instance;
				case 'w': return GUWCache.Instance;
				case 'x': return GUXCache.Instance;
				case 'z': return GUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GVACache.Instance;
				case 'c': return GVCCache.Instance;
				case 'e': return GVECache.Instance;
				case 'f': return GVFCache.Instance;
				case 'j': return GVJCache.Instance;
				case 'l': return GVLCache.Instance;
				case 'm': return GVMCache.Instance;
				case 'n': return GVNCache.Instance;
				case 'o': return GVOCache.Instance;
				case 'p': return GVPCache.Instance;
				case 'r': return GVRCache.Instance;
				case 's': return GVSCache.Instance;
				case 'y': return GVYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GWACache.Instance;
				case 'b': return GWBCache.Instance;
				case 'c': return GWCCache.Instance;
				case 'd': return GWDCache.Instance;
				case 'e': return GWECache.Instance;
				case 'f': return GWFCache.Instance;
				case 'g': return GWGCache.Instance;
				case 'i': return GWICache.Instance;
				case 'j': return GWJCache.Instance;
				case 'm': return GWMCache.Instance;
				case 'n': return GWNCache.Instance;
				case 'r': return GWRCache.Instance;
				case 't': return GWTCache.Instance;
				case 'u': return GWUCache.Instance;
				case 'w': return GWWCache.Instance;
				case 'x': return GWXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return GXXCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_gy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GYACache.Instance;
				case 'b': return GYBCache.Instance;
				case 'd': return GYDCache.Instance;
				case 'e': return GYECache.Instance;
				case 'f': return GYFCache.Instance;
				case 'g': return GYGCache.Instance;
				case 'i': return GYICache.Instance;
				case 'l': return GYLCache.Instance;
				case 'm': return GYMCache.Instance;
				case 'n': return GYNCache.Instance;
				case 'o': return GYOCache.Instance;
				case 'r': return GYRCache.Instance;
				case 'y': return GYYCache.Instance;
				case 'z': return GYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GZACache.Instance;
				case 'i': return GZICache.Instance;
				case 'n': return GZNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ha(span);
				case 'b': return tryParse_L3_hb(span);
				case 'c': return tryParse_L3_hc(span);
				case 'd': return tryParse_L3_hd(span);
				case 'e': return tryParse_L3_he(span);
				case 'g': return tryParse_L3_hg(span);
				case 'h': return tryParse_L3_hh(span);
				case 'i': return tryParse_L3_hi(span);
				case 'j': return tryParse_L3_hj(span);
				case 'k': return tryParse_L3_hk(span);
				case 'l': return tryParse_L3_hl(span);
				case 'm': return tryParse_L3_hm(span);
				case 'n': return tryParse_L3_hn(span);
				case 'o': return tryParse_L3_ho(span);
				case 'p': return tryParse_L3_hp(span);
				case 'r': return tryParse_L3_hr(span);
				case 's': return tryParse_L3_hs(span);
				case 't': return tryParse_L3_ht(span);
				case 'u': return tryParse_L3_hu(span);
				case 'v': return tryParse_L3_hv(span);
				case 'w': return tryParse_L3_hw(span);
				case 'y': return tryParse_L3_hy(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ha(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HAACache.Instance;
				case 'b': return HABCache.Instance;
				case 'c': return HACCache.Instance;
				case 'd': return HADCache.Instance;
				case 'e': return HAECache.Instance;
				case 'f': return HAFCache.Instance;
				case 'g': return HAGCache.Instance;
				case 'h': return HAHCache.Instance;
				case 'i': return HAICache.Instance;
				case 'j': return HAJCache.Instance;
				case 'k': return HAKCache.Instance;
				case 'l': return HALCache.Instance;
				case 'm': return HAMCache.Instance;
				case 'n': return HANCache.Instance;
				case 'o': return HAOCache.Instance;
				case 'p': return HAPCache.Instance;
				case 'q': return HAQCache.Instance;
				case 'r': return HARCache.Instance;
				case 's': return HASCache.Instance;
				case 'v': return HAVCache.Instance;
				case 'w': return HAWCache.Instance;
				case 'x': return HAXCache.Instance;
				case 'y': return HAYCache.Instance;
				case 'z': return HAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HBACache.Instance;
				case 'b': return HBBCache.Instance;
				case 'n': return HBNCache.Instance;
				case 'o': return HBOCache.Instance;
				case 'u': return HBUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HCACache.Instance;
				case 'h': return HCHCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hd(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return HDNCache.Instance;
				case 's': return HDSCache.Instance;
				case 'y': return HDYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_he(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HEACache.Instance;
				case 'd': return HEDCache.Instance;
				case 'g': return HEGCache.Instance;
				case 'h': return HEHCache.Instance;
				case 'i': return HEICache.Instance;
				case 'm': return HEMCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hg(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return HGMCache.Instance;
				case 'w': return HGWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hh(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return HHICache.Instance;
				case 'r': return HHRCache.Instance;
				case 'y': return HHYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HIACache.Instance;
				case 'b': return HIBCache.Instance;
				case 'd': return HIDCache.Instance;
				case 'f': return HIFCache.Instance;
				case 'g': return HIGCache.Instance;
				case 'h': return HIHCache.Instance;
				case 'i': return HIICache.Instance;
				case 'j': return HIJCache.Instance;
				case 'k': return HIKCache.Instance;
				case 'l': return HILCache.Instance;
				case 'm': return HIMCache.Instance;
				case 'o': return HIOCache.Instance;
				case 'r': return HIRCache.Instance;
				case 't': return HITCache.Instance;
				case 'w': return HIWCache.Instance;
				case 'x': return HIXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return HJICache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_hk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HKACache.Instance;
				case 'e': return HKECache.Instance;
				case 'h': return HKHCache.Instance;
				case 'k': return HKKCache.Instance;
				case 'n': return HKNCache.Instance;
				case 's': return HKSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HLACache.Instance;
				case 'b': return HLBCache.Instance;
				case 'd': return HLDCache.Instance;
				case 'e': return HLECache.Instance;
				case 't': return HLTCache.Instance;
				case 'u': return HLUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HMACache.Instance;
				case 'b': return HMBCache.Instance;
				case 'c': return HMCCache.Instance;
				case 'd': return HMDCache.Instance;
				case 'e': return HMECache.Instance;
				case 'f': return HMFCache.Instance;
				case 'g': return HMGCache.Instance;
				case 'h': return HMHCache.Instance;
				case 'i': return HMICache.Instance;
				case 'j': return HMJCache.Instance;
				case 'k': return HMKCache.Instance;
				case 'l': return HMLCache.Instance;
				case 'm': return HMMCache.Instance;
				case 'n': return HMNCache.Instance;
				case 'p': return HMPCache.Instance;
				case 'q': return HMQCache.Instance;
				case 'r': return HMRCache.Instance;
				case 's': return HMSCache.Instance;
				case 't': return HMTCache.Instance;
				case 'u': return HMUCache.Instance;
				case 'v': return HMVCache.Instance;
				case 'w': return HMWCache.Instance;
				case 'x': return HMXCache.Instance;
				case 'y': return HMYCache.Instance;
				case 'z': return HMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HNACache.Instance;
				case 'd': return HNDCache.Instance;
				case 'e': return HNECache.Instance;
				case 'g': return HNGCache.Instance;
				case 'h': return HNHCache.Instance;
				case 'i': return HNICache.Instance;
				case 'j': return HNJCache.Instance;
				case 'm': return HNMCache.Instance;
				case 'n': return HNNCache.Instance;
				case 'o': return HNOCache.Instance;
				case 's': return HNSCache.Instance;
				case 'u': return HNUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ho(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HOACache.Instance;
				case 'b': return HOBCache.Instance;
				case 'c': return HOCCache.Instance;
				case 'd': return HODCache.Instance;
				case 'e': return HOECache.Instance;
				case 'h': return HOHCache.Instance;
				case 'i': return HOICache.Instance;
				case 'j': return HOJCache.Instance;
				case 'k': return HOKCache.Instance;
				case 'l': return HOLCache.Instance;
				case 'm': return HOMCache.Instance;
				case 'o': return HOOCache.Instance;
				case 'p': return HOPCache.Instance;
				case 'r': return HORCache.Instance;
				case 's': return HOSCache.Instance;
				case 't': return HOTCache.Instance;
				case 'v': return HOVCache.Instance;
				case 'w': return HOWCache.Instance;
				case 'y': return HOYCache.Instance;
				case 'z': return HOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hp(StringSpan span)
		{
			switch(span[2])
			{
				case 'o': return HPOCache.Instance;
				case 's': return HPSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HRACache.Instance;
				case 'c': return HRCCache.Instance;
				case 'e': return HRECache.Instance;
				case 'k': return HRKCache.Instance;
				case 'm': return HRMCache.Instance;
				case 'o': return HROCache.Instance;
				case 'p': return HRPCache.Instance;
				case 'r': return JALCache.Instance;
				case 't': return HRTCache.Instance;
				case 'u': return HRUCache.Instance;
				case 'w': return HRWCache.Instance;
				case 'x': return HRXCache.Instance;
				case 'z': return HRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hs(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return HSBCache.Instance;
				case 'h': return HSHCache.Instance;
				case 'l': return HSLCache.Instance;
				case 'n': return HSNCache.Instance;
				case 's': return HSSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ht(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return HTICache.Instance;
				case 'o': return HTOCache.Instance;
				case 's': return HTSCache.Instance;
				case 'u': return HTUCache.Instance;
				case 'x': return HTXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hu(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return HUBCache.Instance;
				case 'c': return HUCCache.Instance;
				case 'd': return HUDCache.Instance;
				case 'e': return HUECache.Instance;
				case 'f': return HUFCache.Instance;
				case 'g': return HUGCache.Instance;
				case 'h': return HUHCache.Instance;
				case 'i': return HUICache.Instance;
				case 'j': return HUJCache.Instance;
				case 'k': return HUKCache.Instance;
				case 'l': return HULCache.Instance;
				case 'm': return HUMCache.Instance;
				case 'o': return HUOCache.Instance;
				case 'p': return HUPCache.Instance;
				case 'q': return HUQCache.Instance;
				case 'r': return HURCache.Instance;
				case 's': return HUSCache.Instance;
				case 't': return HUTCache.Instance;
				case 'u': return HUUCache.Instance;
				case 'v': return HUVCache.Instance;
				case 'w': return HUWCache.Instance;
				case 'x': return HUXCache.Instance;
				case 'y': return HUYCache.Instance;
				case 'z': return HUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hv(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return HVCCache.Instance;
				case 'e': return HVECache.Instance;
				case 'k': return HVKCache.Instance;
				case 'n': return HVNCache.Instance;
				case 'v': return HVVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HWACache.Instance;
				case 'c': return HWCCache.Instance;
				case 'o': return HWOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HYACache.Instance;
				case 'w': return HYWCache.Instance;
				case 'x': return HYXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ia(span);
				case 'b': return tryParse_L3_ib(span);
				case 'c': return tryParse_L3_ic(span);
				case 'd': return tryParse_L3_id(span);
				case 'f': return tryParse_L3_if(span);
				case 'g': return tryParse_L3_ig(span);
				case 'h': return tryParse_L3_ih(span);
				case 'i': return tryParse_L3_ii(span);
				case 'j': return tryParse_L3_ij(span);
				case 'k': return tryParse_L3_ik(span);
				case 'l': return tryParse_L3_il(span);
				case 'm': return tryParse_L3_im(span);
				case 'n': return tryParse_L3_in(span);
				case 'o': return tryParse_L3_io(span);
				case 'p': return tryParse_L3_ip(span);
				case 'q': return tryParse_L3_iq(span);
				case 'r': return tryParse_L3_ir(span);
				case 's': return tryParse_L3_is(span);
				case 't': return tryParse_L3_it(span);
				case 'u': return tryParse_L3_iu(span);
				case 'v': return tryParse_L3_iv(span);
				case 'w': return tryParse_L3_iw(span);
				case 'x': return tryParse_L3_ix(span);
				case 'y': return tryParse_L3_iy(span);
				case 'z': return tryParse_L3_iz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ia(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return IAICache.Instance;
				case 'n': return IANCache.Instance;
				case 'p': return IAPCache.Instance;
				case 'r': return IARCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ib(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IBACache.Instance;
				case 'b': return IBBCache.Instance;
				case 'd': return IBDCache.Instance;
				case 'e': return IBECache.Instance;
				case 'g': return IBGCache.Instance;
				case 'h': return IBHCache.Instance;
				case 'i': return OPACache.Instance;
				case 'l': return IBLCache.Instance;
				case 'm': return IBMCache.Instance;
				case 'n': return IBNCache.Instance;
				case 'r': return IBRCache.Instance;
				case 'u': return IBUCache.Instance;
				case 'y': return IBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ic(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ICACache.Instance;
				case 'h': return ICHCache.Instance;
				case 'l': return ICLCache.Instance;
				case 'r': return ICRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_id(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IDACache.Instance;
				case 'b': return IDBCache.Instance;
				case 'c': return IDCCache.Instance;
				case 'd': return IDDCache.Instance;
				case 'e': return IDECache.Instance;
				case 'i': return IDICache.Instance;
				case 'r': return IDRCache.Instance;
				case 's': return IDSCache.Instance;
				case 't': return IDTCache.Instance;
				case 'u': return IDUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_if(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IFACache.Instance;
				case 'b': return IFBCache.Instance;
				case 'e': return IFECache.Instance;
				case 'f': return IFFCache.Instance;
				case 'k': return IFKCache.Instance;
				case 'm': return IFMCache.Instance;
				case 'u': return IFUCache.Instance;
				case 'y': return IFYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ig(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IGBCache.Instance;
				case 'e': return IGECache.Instance;
				case 'g': return IGGCache.Instance;
				case 'l': return IGLCache.Instance;
				case 'm': return IGMCache.Instance;
				case 'n': return IGNCache.Instance;
				case 'o': return IGOCache.Instance;
				case 's': return IGSCache.Instance;
				case 'w': return IGWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ih(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IHBCache.Instance;
				case 'i': return IHICache.Instance;
				case 'p': return IHPCache.Instance;
				case 'w': return IHWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ii(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return IINCache.Instance;
				case 'r': return IIRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ij(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return IJCCache.Instance;
				case 'e': return IJECache.Instance;
				case 'j': return IJJCache.Instance;
				case 'n': return IJNCache.Instance;
				case 'o': return IJOCache.Instance;
				case 's': return IJSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ik(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return IKECache.Instance;
				case 'h': return IKHCache.Instance;
				case 'i': return IKICache.Instance;
				case 'k': return IKKCache.Instance;
				case 'l': return IKLCache.Instance;
				case 'o': return IKOCache.Instance;
				case 'p': return IKPCache.Instance;
				case 'r': return IKRCache.Instance;
				case 's': return IKSCache.Instance;
				case 't': return IKTCache.Instance;
				case 'v': return IKVCache.Instance;
				case 'w': return IKWCache.Instance;
				case 'x': return IKXCache.Instance;
				case 'z': return IKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_il(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ILACache.Instance;
				case 'b': return ILBCache.Instance;
				case 'g': return ILGCache.Instance;
				case 'i': return ILICache.Instance;
				case 'k': return ILKCache.Instance;
				case 'l': return ILLCache.Instance;
				case 'm': return ILMCache.Instance;
				case 'o': return ILOCache.Instance;
				case 'p': return ILPCache.Instance;
				case 's': return ILSCache.Instance;
				case 'u': return ILUCache.Instance;
				case 'v': return ILVCache.Instance;
				case 'w': return GALCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_im(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IMACache.Instance;
				case 'e': return IMECache.Instance;
				case 'i': return IMICache.Instance;
				case 'l': return IMLCache.Instance;
				case 'n': return IMNCache.Instance;
				case 'o': return IMOCache.Instance;
				case 'r': return IMRCache.Instance;
				case 's': return IMSCache.Instance;
				case 't': return IMTCache.Instance;
				case 'y': return IMYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_in(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return INBCache.Instance;
				case 'c': return INCCache.Instance;
				case 'e': return INECache.Instance;
				case 'g': return INGCache.Instance;
				case 'h': return INHCache.Instance;
				case 'j': return INJCache.Instance;
				case 'l': return INLCache.Instance;
				case 'm': return INMCache.Instance;
				case 'n': return INNCache.Instance;
				case 'o': return INOCache.Instance;
				case 'p': return INPCache.Instance;
				case 's': return INSCache.Instance;
				case 't': return INTCache.Instance;
				case 'z': return INZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_io(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return IORCache.Instance;
				case 'u': return IOUCache.Instance;
				case 'w': return IOWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ip(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return IPICache.Instance;
				case 'o': return IPOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iq(StringSpan span)
		{
			switch(span[2])
			{
				case 'u': return IQUCache.Instance;
				case 'w': return IQWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ir(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IRACache.Instance;
				case 'e': return IRECache.Instance;
				case 'h': return IRHCache.Instance;
				case 'i': return IRICache.Instance;
				case 'k': return IRKCache.Instance;
				case 'n': return IRNCache.Instance;
				case 'o': return IROCache.Instance;
				case 'r': return IRRCache.Instance;
				case 'u': return IRUCache.Instance;
				case 'x': return IRXCache.Instance;
				case 'y': return IRYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_is(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ISACache.Instance;
				case 'c': return ISCCache.Instance;
				case 'd': return ISDCache.Instance;
				case 'e': return ISECache.Instance;
				case 'g': return ISGCache.Instance;
				case 'h': return ISHCache.Instance;
				case 'i': return ISICache.Instance;
				case 'k': return ISKCache.Instance;
				case 'm': return ISMCache.Instance;
				case 'n': return ISNCache.Instance;
				case 'o': return ISOCache.Instance;
				case 'r': return ISRCache.Instance;
				case 't': return ISTCache.Instance;
				case 'u': return ISUCache.Instance;
				case 'v': return ISVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_it(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ITBCache.Instance;
				case 'c': return ITCCache.Instance;
				case 'd': return ITDCache.Instance;
				case 'e': return ITECache.Instance;
				case 'i': return ITICache.Instance;
				case 'k': return ITKCache.Instance;
				case 'l': return ITLCache.Instance;
				case 'm': return ITMCache.Instance;
				case 'o': return ITOCache.Instance;
				case 'r': return ITRCache.Instance;
				case 's': return ITSCache.Instance;
				case 't': return ITTCache.Instance;
				case 'v': return ITVCache.Instance;
				case 'w': return ITWCache.Instance;
				case 'x': return ITXCache.Instance;
				case 'y': return ITYCache.Instance;
				case 'z': return ITZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return IUMCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_iv(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IVBCache.Instance;
				case 'v': return IVVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iw(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return IWKCache.Instance;
				case 'm': return IWMCache.Instance;
				case 'o': return IWOCache.Instance;
				case 's': return IWSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ix(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return IXCCache.Instance;
				case 'l': return IXLCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IYACache.Instance;
				case 'o': return IYOCache.Instance;
				case 'x': return IYXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return IZHCache.Instance;
				case 'i': return IZICache.Instance;
				case 'm': return IZMCache.Instance;
				case 'r': return IZRCache.Instance;
				case 'z': return IZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ja(span);
				case 'b': return tryParse_L3_jb(span);
				case 'c': return tryParse_L3_jc(span);
				case 'd': return tryParse_L3_jd(span);
				case 'e': return tryParse_L3_je(span);
				case 'g': return tryParse_L3_jg(span);
				case 'h': return tryParse_L3_jh(span);
				case 'i': return tryParse_L3_ji(span);
				case 'j': return tryParse_L3_jj(span);
				case 'k': return tryParse_L3_jk(span);
				case 'l': return tryParse_L3_jl(span);
				case 'm': return tryParse_L3_jm(span);
				case 'n': return tryParse_L3_jn(span);
				case 'o': return tryParse_L3_jo(span);
				case 'p': return tryParse_L3_jp(span);
				case 'q': return tryParse_L3_jq(span);
				case 'r': return tryParse_L3_jr(span);
				case 's': return tryParse_L3_js(span);
				case 'u': return tryParse_L3_ju(span);
				case 'v': return tryParse_L3_jv(span);
				case 'w': return tryParse_L3_jw(span);
				case 'y': return tryParse_L3_jy(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ja(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JAACache.Instance;
				case 'b': return JABCache.Instance;
				case 'c': return JACCache.Instance;
				case 'd': return JADCache.Instance;
				case 'e': return JAECache.Instance;
				case 'f': return JAFCache.Instance;
				case 'h': return JAHCache.Instance;
				case 'j': return JAJCache.Instance;
				case 'k': return JAKCache.Instance;
				case 'l': return JALCache.Instance;
				case 'm': return JAMCache.Instance;
				case 'n': return JANCache.Instance;
				case 'o': return JAOCache.Instance;
				case 'q': return JAQCache.Instance;
				case 'r': return JARCache.Instance;
				case 's': return JASCache.Instance;
				case 't': return JATCache.Instance;
				case 'u': return JAUCache.Instance;
				case 'x': return JAXCache.Instance;
				case 'y': return JAYCache.Instance;
				case 'z': return JAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jb(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JBECache.Instance;
				case 'i': return JBICache.Instance;
				case 'j': return JBJCache.Instance;
				case 'k': return JBKCache.Instance;
				case 'm': return JBMCache.Instance;
				case 'n': return JBNCache.Instance;
				case 'o': return JBOCache.Instance;
				case 'r': return JBRCache.Instance;
				case 't': return JBTCache.Instance;
				case 'u': return JBUCache.Instance;
				case 'w': return JBWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jc(StringSpan span)
		{
			switch(span[2])
			{
				case 's': return JCSCache.Instance;
				case 't': return JCTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JDACache.Instance;
				case 'g': return JDGCache.Instance;
				case 't': return JDTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_je(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JEBCache.Instance;
				case 'e': return JEECache.Instance;
				case 'g': return OYBCache.Instance;
				case 'h': return JEHCache.Instance;
				case 'i': return JEICache.Instance;
				case 'k': return JEKCache.Instance;
				case 'l': return JELCache.Instance;
				case 'n': return JENCache.Instance;
				case 'r': return JERCache.Instance;
				case 't': return JETCache.Instance;
				case 'u': return JEUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jg(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JGBCache.Instance;
				case 'e': return JGECache.Instance;
				case 'k': return JGKCache.Instance;
				case 'o': return JGOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jh(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return JHICache.Instance;
				case 's': return JHSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ji(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JIACache.Instance;
				case 'b': return JIBCache.Instance;
				case 'c': return JICCache.Instance;
				case 'd': return JIDCache.Instance;
				case 'e': return JIECache.Instance;
				case 'g': return JIGCache.Instance;
				case 'h': return JIHCache.Instance;
				case 'i': return JIICache.Instance;
				case 'l': return JILCache.Instance;
				case 'm': return JIMCache.Instance;
				case 'o': return JIOCache.Instance;
				case 'q': return JIQCache.Instance;
				case 't': return JITCache.Instance;
				case 'u': return JIUCache.Instance;
				case 'v': return JIVCache.Instance;
				case 'y': return JIYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jj(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JJECache.Instance;
				case 'r': return JJRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JKACache.Instance;
				case 'm': return JKMCache.Instance;
				case 'o': return JKOCache.Instance;
				case 'p': return JKPCache.Instance;
				case 'r': return JKRCache.Instance;
				case 's': return JKSCache.Instance;
				case 'u': return JKUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jl(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JLECache.Instance;
				case 's': return JLSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JMACache.Instance;
				case 'b': return JMBCache.Instance;
				case 'c': return JMCCache.Instance;
				case 'd': return JMDCache.Instance;
				case 'i': return JMICache.Instance;
				case 'l': return JMLCache.Instance;
				case 'n': return JMNCache.Instance;
				case 'r': return JMRCache.Instance;
				case 's': return JMSCache.Instance;
				case 'w': return JMWCache.Instance;
				case 'x': return JMXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JNACache.Instance;
				case 'd': return JNDCache.Instance;
				case 'g': return JNGCache.Instance;
				case 'i': return JNICache.Instance;
				case 'j': return JNJCache.Instance;
				case 'l': return JNLCache.Instance;
				case 's': return JNSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jo(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JOBCache.Instance;
				case 'd': return JODCache.Instance;
				case 'g': return JOGCache.Instance;
				case 'r': return JORCache.Instance;
				case 's': return JOSCache.Instance;
				case 'w': return JOWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JPACache.Instance;
				case 'r': return JPRCache.Instance;
				case 'x': return JPXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return JQRCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_jr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JRACache.Instance;
				case 'b': return JRBCache.Instance;
				case 'r': return JRRCache.Instance;
				case 't': return JRTCache.Instance;
				case 'u': return JRUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_js(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return JSLCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ju(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JUACache.Instance;
				case 'b': return JUBCache.Instance;
				case 'c': return JUCCache.Instance;
				case 'd': return JUDCache.Instance;
				case 'h': return JUHCache.Instance;
				case 'i': return JUICache.Instance;
				case 'k': return JUKCache.Instance;
				case 'l': return JULCache.Instance;
				case 'm': return JUMCache.Instance;
				case 'n': return JUNCache.Instance;
				case 'o': return JUOCache.Instance;
				case 'p': return JUPCache.Instance;
				case 'r': return JURCache.Instance;
				case 's': return JUSCache.Instance;
				case 't': return JUTCache.Instance;
				case 'u': return JUUCache.Instance;
				case 'w': return JUWCache.Instance;
				case 'y': return JUYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jv(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return JVDCache.Instance;
				case 'n': return JVNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return JWICache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_jy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JYACache.Instance;
				case 'e': return JYECache.Instance;
				case 'y': return JYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ka(span);
				case 'b': return tryParse_L3_kb(span);
				case 'c': return tryParse_L3_kc(span);
				case 'd': return tryParse_L3_kd(span);
				case 'e': return tryParse_L3_ke(span);
				case 'f': return tryParse_L3_kf(span);
				case 'g': return tryParse_L3_kg(span);
				case 'h': return tryParse_L3_kh(span);
				case 'i': return tryParse_L3_ki(span);
				case 'j': return tryParse_L3_kj(span);
				case 'k': return tryParse_L3_kk(span);
				case 'l': return tryParse_L3_kl(span);
				case 'm': return tryParse_L3_km(span);
				case 'n': return tryParse_L3_kn(span);
				case 'o': return tryParse_L3_ko(span);
				case 'p': return tryParse_L3_kp(span);
				case 'q': return tryParse_L3_kq(span);
				case 'r': return tryParse_L3_kr(span);
				case 's': return tryParse_L3_ks(span);
				case 't': return tryParse_L3_kt(span);
				case 'u': return tryParse_L3_ku(span);
				case 'v': return tryParse_L3_kv(span);
				case 'w': return tryParse_L3_kw(span);
				case 'x': return tryParse_L3_kx(span);
				case 'y': return tryParse_L3_ky(span);
				case 'z': return tryParse_L3_kz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ka(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KAACache.Instance;
				case 'b': return KABCache.Instance;
				case 'c': return KACCache.Instance;
				case 'd': return KADCache.Instance;
				case 'e': return KAECache.Instance;
				case 'f': return KAFCache.Instance;
				case 'g': return KAGCache.Instance;
				case 'h': return KAHCache.Instance;
				case 'i': return KAICache.Instance;
				case 'j': return KAJCache.Instance;
				case 'k': return KAKCache.Instance;
				case 'm': return KAMCache.Instance;
				case 'o': return KAOCache.Instance;
				case 'p': return KAPCache.Instance;
				case 'q': return KAQCache.Instance;
				case 'r': return KARCache.Instance;
				case 'v': return KAVCache.Instance;
				case 'w': return KAWCache.Instance;
				case 'x': return KAXCache.Instance;
				case 'y': return KAYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KBACache.Instance;
				case 'b': return KBBCache.Instance;
				case 'c': return KBCCache.Instance;
				case 'd': return KBDCache.Instance;
				case 'e': return KBECache.Instance;
				case 'f': return KBFCache.Instance;
				case 'g': return KBGCache.Instance;
				case 'h': return KBHCache.Instance;
				case 'i': return KBICache.Instance;
				case 'j': return KBJCache.Instance;
				case 'k': return KBKCache.Instance;
				case 'l': return KBLCache.Instance;
				case 'm': return KBMCache.Instance;
				case 'n': return KBNCache.Instance;
				case 'o': return KBOCache.Instance;
				case 'p': return KBPCache.Instance;
				case 'q': return KBQCache.Instance;
				case 'r': return KBRCache.Instance;
				case 's': return KBSCache.Instance;
				case 't': return KBTCache.Instance;
				case 'u': return KBUCache.Instance;
				case 'v': return KBVCache.Instance;
				case 'w': return KBWCache.Instance;
				case 'x': return KBXCache.Instance;
				case 'y': return KBYCache.Instance;
				case 'z': return KBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KCACache.Instance;
				case 'b': return KCBCache.Instance;
				case 'c': return KCCCache.Instance;
				case 'd': return KCDCache.Instance;
				case 'e': return KCECache.Instance;
				case 'f': return KCFCache.Instance;
				case 'g': return KCGCache.Instance;
				case 'h': return KCHCache.Instance;
				case 'i': return KCICache.Instance;
				case 'j': return KCJCache.Instance;
				case 'k': return KCKCache.Instance;
				case 'l': return KCLCache.Instance;
				case 'm': return KCMCache.Instance;
				case 'n': return KCNCache.Instance;
				case 'o': return KCOCache.Instance;
				case 'p': return KCPCache.Instance;
				case 'q': return KCQCache.Instance;
				case 'r': return KCRCache.Instance;
				case 's': return KCSCache.Instance;
				case 't': return KCTCache.Instance;
				case 'u': return KCUCache.Instance;
				case 'v': return KCVCache.Instance;
				case 'w': return KCWCache.Instance;
				case 'x': return KCXCache.Instance;
				case 'y': return KCYCache.Instance;
				case 'z': return KCZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KDACache.Instance;
				case 'c': return KDCCache.Instance;
				case 'd': return KDDCache.Instance;
				case 'e': return KDECache.Instance;
				case 'f': return KDFCache.Instance;
				case 'g': return KDGCache.Instance;
				case 'h': return KDHCache.Instance;
				case 'i': return KDICache.Instance;
				case 'j': return KDJCache.Instance;
				case 'k': return KDKCache.Instance;
				case 'l': return KDLCache.Instance;
				case 'm': return KDMCache.Instance;
				case 'n': return KDNCache.Instance;
				case 'o': return KDOCache.Instance;
				case 'p': return KDPCache.Instance;
				case 'q': return KDQCache.Instance;
				case 'r': return KDRCache.Instance;
				case 't': return KDTCache.Instance;
				case 'u': return KDUCache.Instance;
				case 'v': return KDVCache.Instance;
				case 'w': return KDWCache.Instance;
				case 'x': return KDXCache.Instance;
				case 'y': return KDYCache.Instance;
				case 'z': return KDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ke(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KEACache.Instance;
				case 'b': return KEBCache.Instance;
				case 'c': return KECCache.Instance;
				case 'd': return KEDCache.Instance;
				case 'e': return KEECache.Instance;
				case 'f': return KEFCache.Instance;
				case 'g': return KEGCache.Instance;
				case 'h': return KEHCache.Instance;
				case 'i': return KEICache.Instance;
				case 'j': return KEJCache.Instance;
				case 'k': return KEKCache.Instance;
				case 'l': return KELCache.Instance;
				case 'm': return KEMCache.Instance;
				case 'n': return KENCache.Instance;
				case 'o': return KEOCache.Instance;
				case 'p': return KEPCache.Instance;
				case 'q': return KEQCache.Instance;
				case 'r': return KERCache.Instance;
				case 's': return KESCache.Instance;
				case 't': return KETCache.Instance;
				case 'u': return KEUCache.Instance;
				case 'v': return KEVCache.Instance;
				case 'w': return KEWCache.Instance;
				case 'x': return KEXCache.Instance;
				case 'y': return KEYCache.Instance;
				case 'z': return KEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KFACache.Instance;
				case 'b': return KFBCache.Instance;
				case 'c': return KFCCache.Instance;
				case 'd': return KFDCache.Instance;
				case 'e': return KFECache.Instance;
				case 'f': return KFFCache.Instance;
				case 'g': return KFGCache.Instance;
				case 'h': return KFHCache.Instance;
				case 'i': return KFICache.Instance;
				case 'j': return KFJCache.Instance;
				case 'k': return KFKCache.Instance;
				case 'l': return KFLCache.Instance;
				case 'm': return KFMCache.Instance;
				case 'n': return KFNCache.Instance;
				case 'o': return KFOCache.Instance;
				case 'p': return KFPCache.Instance;
				case 'q': return KFQCache.Instance;
				case 'r': return KFRCache.Instance;
				case 's': return KFSCache.Instance;
				case 't': return KFTCache.Instance;
				case 'u': return KFUCache.Instance;
				case 'v': return KFVCache.Instance;
				case 'w': return KFWCache.Instance;
				case 'x': return KFXCache.Instance;
				case 'y': return KFYCache.Instance;
				case 'z': return KFZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KGACache.Instance;
				case 'b': return KGBCache.Instance;
				case 'c': return TDFCache.Instance;
				case 'd': return KGDCache.Instance;
				case 'e': return KGECache.Instance;
				case 'f': return KGFCache.Instance;
				case 'g': return KGGCache.Instance;
				case 'h': return KMLCache.Instance;
				case 'i': return KGICache.Instance;
				case 'j': return KGJCache.Instance;
				case 'k': return KGKCache.Instance;
				case 'l': return KGLCache.Instance;
				case 'm': return PLUCache.Instance;
				case 'n': return KGNCache.Instance;
				case 'o': return KGOCache.Instance;
				case 'p': return KGPCache.Instance;
				case 'q': return KGQCache.Instance;
				case 'r': return KGRCache.Instance;
				case 's': return KGSCache.Instance;
				case 't': return KGTCache.Instance;
				case 'u': return KGUCache.Instance;
				case 'v': return KGVCache.Instance;
				case 'w': return KGWCache.Instance;
				case 'x': return KGXCache.Instance;
				case 'y': return KGYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KHACache.Instance;
				case 'b': return KHBCache.Instance;
				case 'c': return KHCCache.Instance;
				case 'd': return KHDCache.Instance;
				case 'e': return KHECache.Instance;
				case 'f': return KHFCache.Instance;
				case 'g': return KHGCache.Instance;
				case 'h': return KHHCache.Instance;
				case 'i': return KHICache.Instance;
				case 'j': return KHJCache.Instance;
				case 'k': return KHKCache.Instance;
				case 'l': return KHLCache.Instance;
				case 'n': return KHNCache.Instance;
				case 'o': return KHOCache.Instance;
				case 'p': return KHPCache.Instance;
				case 'q': return KHQCache.Instance;
				case 'r': return KHRCache.Instance;
				case 's': return KHSCache.Instance;
				case 't': return KHTCache.Instance;
				case 'u': return KHUCache.Instance;
				case 'v': return KHVCache.Instance;
				case 'w': return KHWCache.Instance;
				case 'x': return KHXCache.Instance;
				case 'y': return KHYCache.Instance;
				case 'z': return KHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ki(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KIACache.Instance;
				case 'b': return KIBCache.Instance;
				case 'c': return KICCache.Instance;
				case 'd': return KIDCache.Instance;
				case 'e': return KIECache.Instance;
				case 'f': return KIFCache.Instance;
				case 'g': return KIGCache.Instance;
				case 'h': return KIHCache.Instance;
				case 'i': return KIICache.Instance;
				case 'j': return KIJCache.Instance;
				case 'l': return KILCache.Instance;
				case 'm': return KIMCache.Instance;
				case 'o': return KIOCache.Instance;
				case 'p': return KIPCache.Instance;
				case 'q': return KIQCache.Instance;
				case 's': return KISCache.Instance;
				case 't': return KITCache.Instance;
				case 'u': return KIUCache.Instance;
				case 'v': return KIVCache.Instance;
				case 'w': return KIWCache.Instance;
				case 'x': return KIXCache.Instance;
				case 'y': return KIYCache.Instance;
				case 'z': return KIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KJACache.Instance;
				case 'b': return KJBCache.Instance;
				case 'c': return KJCCache.Instance;
				case 'd': return KJDCache.Instance;
				case 'e': return KJECache.Instance;
				case 'f': return KJFCache.Instance;
				case 'g': return KJGCache.Instance;
				case 'h': return KJHCache.Instance;
				case 'i': return KJICache.Instance;
				case 'j': return KJJCache.Instance;
				case 'k': return KJKCache.Instance;
				case 'l': return KJLCache.Instance;
				case 'm': return KJMCache.Instance;
				case 'n': return KJNCache.Instance;
				case 'o': return KJOCache.Instance;
				case 'p': return KJPCache.Instance;
				case 'q': return KJQCache.Instance;
				case 'r': return KJRCache.Instance;
				case 's': return KJSCache.Instance;
				case 't': return KJTCache.Instance;
				case 'u': return KJUCache.Instance;
				case 'v': return KJVCache.Instance;
				case 'x': return KJXCache.Instance;
				case 'y': return KJYCache.Instance;
				case 'z': return KJZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KKACache.Instance;
				case 'b': return KKBCache.Instance;
				case 'c': return KKCCache.Instance;
				case 'd': return KKDCache.Instance;
				case 'e': return KKECache.Instance;
				case 'f': return KKFCache.Instance;
				case 'g': return KKGCache.Instance;
				case 'h': return KKHCache.Instance;
				case 'i': return KKICache.Instance;
				case 'j': return KKJCache.Instance;
				case 'k': return KKKCache.Instance;
				case 'l': return KKLCache.Instance;
				case 'm': return KKMCache.Instance;
				case 'n': return KKNCache.Instance;
				case 'o': return KKOCache.Instance;
				case 'p': return KKPCache.Instance;
				case 'q': return KKQCache.Instance;
				case 'r': return KKRCache.Instance;
				case 's': return KKSCache.Instance;
				case 't': return KKTCache.Instance;
				case 'u': return KKUCache.Instance;
				case 'v': return KKVCache.Instance;
				case 'w': return KKWCache.Instance;
				case 'x': return KKXCache.Instance;
				case 'y': return KKYCache.Instance;
				case 'z': return KKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KLACache.Instance;
				case 'b': return KLBCache.Instance;
				case 'c': return KLCCache.Instance;
				case 'd': return KLDCache.Instance;
				case 'e': return KLECache.Instance;
				case 'f': return KLFCache.Instance;
				case 'g': return KLGCache.Instance;
				case 'h': return KLHCache.Instance;
				case 'i': return KLICache.Instance;
				case 'j': return KLJCache.Instance;
				case 'k': return KLKCache.Instance;
				case 'l': return KLLCache.Instance;
				case 'm': return KLMCache.Instance;
				case 'n': return KLNCache.Instance;
				case 'o': return KLOCache.Instance;
				case 'p': return KLPCache.Instance;
				case 'q': return KLQCache.Instance;
				case 'r': return KLRCache.Instance;
				case 's': return KLSCache.Instance;
				case 't': return KLTCache.Instance;
				case 'u': return KLUCache.Instance;
				case 'v': return KLVCache.Instance;
				case 'w': return KLWCache.Instance;
				case 'x': return KLXCache.Instance;
				case 'y': return KLYCache.Instance;
				case 'z': return KLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_km(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KMACache.Instance;
				case 'b': return KMBCache.Instance;
				case 'c': return KMCCache.Instance;
				case 'd': return KMDCache.Instance;
				case 'e': return KMECache.Instance;
				case 'f': return KMFCache.Instance;
				case 'g': return KMGCache.Instance;
				case 'h': return KMHCache.Instance;
				case 'i': return KMICache.Instance;
				case 'j': return KMJCache.Instance;
				case 'k': return KMKCache.Instance;
				case 'l': return KMLCache.Instance;
				case 'm': return KMMCache.Instance;
				case 'n': return KMNCache.Instance;
				case 'o': return KMOCache.Instance;
				case 'p': return KMPCache.Instance;
				case 'q': return KMQCache.Instance;
				case 'r': return KMRCache.Instance;
				case 's': return KMSCache.Instance;
				case 't': return KMTCache.Instance;
				case 'u': return KMUCache.Instance;
				case 'v': return KMVCache.Instance;
				case 'w': return KMWCache.Instance;
				case 'x': return KMXCache.Instance;
				case 'y': return KMYCache.Instance;
				case 'z': return KMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KNACache.Instance;
				case 'b': return KNBCache.Instance;
				case 'c': return KNCCache.Instance;
				case 'd': return KNDCache.Instance;
				case 'e': return KNECache.Instance;
				case 'f': return KNFCache.Instance;
				case 'g': return KNGCache.Instance;
				case 'i': return KNICache.Instance;
				case 'j': return KNJCache.Instance;
				case 'k': return KNKCache.Instance;
				case 'l': return KNLCache.Instance;
				case 'm': return KNMCache.Instance;
				case 'n': return KNNCache.Instance;
				case 'o': return KNOCache.Instance;
				case 'p': return KNPCache.Instance;
				case 'q': return KNQCache.Instance;
				case 'r': return KNRCache.Instance;
				case 's': return KNSCache.Instance;
				case 't': return KNTCache.Instance;
				case 'u': return KNUCache.Instance;
				case 'v': return KNVCache.Instance;
				case 'w': return KNWCache.Instance;
				case 'x': return KNXCache.Instance;
				case 'y': return KNYCache.Instance;
				case 'z': return KNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ko(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KOACache.Instance;
				case 'c': return KOCCache.Instance;
				case 'd': return KODCache.Instance;
				case 'e': return KOECache.Instance;
				case 'f': return KOFCache.Instance;
				case 'g': return KOGCache.Instance;
				case 'h': return KOHCache.Instance;
				case 'i': return KOICache.Instance;
				case 'j': return KWVCache.Instance;
				case 'k': return KOKCache.Instance;
				case 'l': return KOLCache.Instance;
				case 'o': return KOOCache.Instance;
				case 'p': return KOPCache.Instance;
				case 'q': return KOQCache.Instance;
				case 's': return KOSCache.Instance;
				case 't': return KOTCache.Instance;
				case 'u': return KOUCache.Instance;
				case 'v': return KOVCache.Instance;
				case 'w': return KOWCache.Instance;
				case 'x': return KOXCache.Instance;
				case 'y': return KOYCache.Instance;
				case 'z': return KOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KPACache.Instance;
				case 'b': return KPBCache.Instance;
				case 'c': return KPCCache.Instance;
				case 'd': return KPDCache.Instance;
				case 'e': return KPECache.Instance;
				case 'f': return KPFCache.Instance;
				case 'g': return KPGCache.Instance;
				case 'h': return KPHCache.Instance;
				case 'i': return KPICache.Instance;
				case 'j': return KPJCache.Instance;
				case 'k': return KPKCache.Instance;
				case 'l': return KPLCache.Instance;
				case 'm': return KPMCache.Instance;
				case 'n': return KPNCache.Instance;
				case 'o': return KPOCache.Instance;
				case 'p': return KPPCache.Instance;
				case 'q': return KPQCache.Instance;
				case 'r': return KPRCache.Instance;
				case 's': return KPSCache.Instance;
				case 't': return KPTCache.Instance;
				case 'u': return KPUCache.Instance;
				case 'v': return KPVCache.Instance;
				case 'w': return KPWCache.Instance;
				case 'x': return KPXCache.Instance;
				case 'y': return KPYCache.Instance;
				case 'z': return KPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KQACache.Instance;
				case 'b': return KQBCache.Instance;
				case 'c': return KQCCache.Instance;
				case 'd': return KQDCache.Instance;
				case 'e': return KQECache.Instance;
				case 'f': return KQFCache.Instance;
				case 'g': return KQGCache.Instance;
				case 'h': return KQHCache.Instance;
				case 'i': return KQICache.Instance;
				case 'j': return KQJCache.Instance;
				case 'k': return KQKCache.Instance;
				case 'l': return KQLCache.Instance;
				case 'm': return KQMCache.Instance;
				case 'n': return KQNCache.Instance;
				case 'o': return KQOCache.Instance;
				case 'p': return KQPCache.Instance;
				case 'q': return KQQCache.Instance;
				case 'r': return KQRCache.Instance;
				case 's': return KQSCache.Instance;
				case 't': return KQTCache.Instance;
				case 'u': return KQUCache.Instance;
				case 'v': return KQVCache.Instance;
				case 'w': return KQWCache.Instance;
				case 'x': return KQXCache.Instance;
				case 'y': return KQYCache.Instance;
				case 'z': return KQZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KRACache.Instance;
				case 'b': return KRBCache.Instance;
				case 'c': return KRCCache.Instance;
				case 'd': return KRDCache.Instance;
				case 'e': return KRECache.Instance;
				case 'f': return KRFCache.Instance;
				case 'h': return KRHCache.Instance;
				case 'i': return KRICache.Instance;
				case 'j': return KRJCache.Instance;
				case 'k': return KRKCache.Instance;
				case 'l': return KRLCache.Instance;
				case 'm': return BMFCache.Instance;
				case 'n': return KRNCache.Instance;
				case 'o': return KROCache.Instance;
				case 'p': return KRPCache.Instance;
				case 'r': return KRRCache.Instance;
				case 's': return KRSCache.Instance;
				case 't': return KRTCache.Instance;
				case 'u': return KRUCache.Instance;
				case 'v': return KRVCache.Instance;
				case 'w': return KRWCache.Instance;
				case 'x': return KRXCache.Instance;
				case 'y': return KRYCache.Instance;
				case 'z': return KRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ks(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KSACache.Instance;
				case 'b': return KSBCache.Instance;
				case 'c': return KSCCache.Instance;
				case 'd': return KSDCache.Instance;
				case 'e': return KSECache.Instance;
				case 'f': return KSFCache.Instance;
				case 'g': return KSGCache.Instance;
				case 'h': return KSHCache.Instance;
				case 'i': return KSICache.Instance;
				case 'j': return KSJCache.Instance;
				case 'k': return KSKCache.Instance;
				case 'l': return KSLCache.Instance;
				case 'm': return KSMCache.Instance;
				case 'n': return KSNCache.Instance;
				case 'o': return KSOCache.Instance;
				case 'p': return KSPCache.Instance;
				case 'q': return KSQCache.Instance;
				case 'r': return KSRCache.Instance;
				case 's': return KSSCache.Instance;
				case 't': return KSTCache.Instance;
				case 'u': return KSUCache.Instance;
				case 'v': return KSVCache.Instance;
				case 'w': return KSWCache.Instance;
				case 'x': return KSXCache.Instance;
				case 'y': return KSYCache.Instance;
				case 'z': return KSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KTACache.Instance;
				case 'b': return KTBCache.Instance;
				case 'c': return KTCCache.Instance;
				case 'd': return KTDCache.Instance;
				case 'e': return KTECache.Instance;
				case 'f': return KTFCache.Instance;
				case 'g': return KTGCache.Instance;
				case 'h': return KTHCache.Instance;
				case 'i': return KTICache.Instance;
				case 'j': return KTJCache.Instance;
				case 'k': return KTKCache.Instance;
				case 'l': return KTLCache.Instance;
				case 'm': return KTMCache.Instance;
				case 'n': return KTNCache.Instance;
				case 'o': return KTOCache.Instance;
				case 'p': return KTPCache.Instance;
				case 'q': return KTQCache.Instance;
				case 'r': return DTPCache.Instance;
				case 's': return KTSCache.Instance;
				case 't': return KTTCache.Instance;
				case 'u': return KTUCache.Instance;
				case 'v': return KTVCache.Instance;
				case 'w': return KTWCache.Instance;
				case 'x': return KTXCache.Instance;
				case 'y': return KTYCache.Instance;
				case 'z': return KTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ku(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return KUBCache.Instance;
				case 'c': return KUCCache.Instance;
				case 'd': return KUDCache.Instance;
				case 'e': return KUECache.Instance;
				case 'f': return KUFCache.Instance;
				case 'g': return KUGCache.Instance;
				case 'h': return KUHCache.Instance;
				case 'i': return KUICache.Instance;
				case 'j': return KUJCache.Instance;
				case 'k': return KUKCache.Instance;
				case 'l': return KULCache.Instance;
				case 'm': return KUMCache.Instance;
				case 'n': return KUNCache.Instance;
				case 'o': return KUOCache.Instance;
				case 'p': return KUPCache.Instance;
				case 'q': return KUQCache.Instance;
				case 's': return KUSCache.Instance;
				case 't': return KUTCache.Instance;
				case 'u': return KUUCache.Instance;
				case 'v': return KUVCache.Instance;
				case 'w': return KUWCache.Instance;
				case 'x': return KUXCache.Instance;
				case 'y': return KUYCache.Instance;
				case 'z': return KUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KVACache.Instance;
				case 'b': return KVBCache.Instance;
				case 'c': return KVCCache.Instance;
				case 'd': return KVDCache.Instance;
				case 'e': return KVECache.Instance;
				case 'f': return KVFCache.Instance;
				case 'g': return KVGCache.Instance;
				case 'h': return KVHCache.Instance;
				case 'i': return KVICache.Instance;
				case 'j': return KVJCache.Instance;
				case 'k': return KVKCache.Instance;
				case 'l': return KVLCache.Instance;
				case 'm': return KVMCache.Instance;
				case 'n': return KVNCache.Instance;
				case 'o': return KVOCache.Instance;
				case 'p': return KVPCache.Instance;
				case 'q': return KVQCache.Instance;
				case 'r': return KVRCache.Instance;
				case 's': return GDJCache.Instance;
				case 't': return KVTCache.Instance;
				case 'u': return KVUCache.Instance;
				case 'v': return KVVCache.Instance;
				case 'w': return KVWCache.Instance;
				case 'x': return KVXCache.Instance;
				case 'y': return KVYCache.Instance;
				case 'z': return KVZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KWACache.Instance;
				case 'b': return KWBCache.Instance;
				case 'c': return KWCCache.Instance;
				case 'd': return KWDCache.Instance;
				case 'e': return KWECache.Instance;
				case 'f': return KWFCache.Instance;
				case 'g': return KWGCache.Instance;
				case 'h': return KWHCache.Instance;
				case 'i': return KWICache.Instance;
				case 'j': return KWJCache.Instance;
				case 'k': return KWKCache.Instance;
				case 'l': return KWLCache.Instance;
				case 'm': return KWMCache.Instance;
				case 'n': return KWNCache.Instance;
				case 'o': return KWOCache.Instance;
				case 'p': return KWPCache.Instance;
				case 'q': return YAMCache.Instance;
				case 'r': return KWRCache.Instance;
				case 's': return KWSCache.Instance;
				case 't': return KWTCache.Instance;
				case 'u': return KWUCache.Instance;
				case 'v': return KWVCache.Instance;
				case 'w': return KWWCache.Instance;
				case 'x': return KWXCache.Instance;
				case 'y': return KWYCache.Instance;
				case 'z': return KWZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KXACache.Instance;
				case 'b': return KXBCache.Instance;
				case 'c': return KXCCache.Instance;
				case 'd': return KXDCache.Instance;
				case 'e': return TVDCache.Instance;
				case 'f': return KXFCache.Instance;
				case 'h': return KXHCache.Instance;
				case 'i': return KXICache.Instance;
				case 'j': return KXJCache.Instance;
				case 'k': return KXKCache.Instance;
				case 'l': return KRUCache.Instance;
				case 'm': return KXMCache.Instance;
				case 'n': return KXNCache.Instance;
				case 'o': return KXOCache.Instance;
				case 'p': return KXPCache.Instance;
				case 'q': return KXQCache.Instance;
				case 'r': return KXRCache.Instance;
				case 's': return KXSCache.Instance;
				case 't': return KXTCache.Instance;
				case 'u': return KXUCache.Instance;
				case 'v': return KXVCache.Instance;
				case 'w': return KXWCache.Instance;
				case 'x': return KXXCache.Instance;
				case 'y': return KXYCache.Instance;
				case 'z': return KXZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ky(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KYACache.Instance;
				case 'b': return KYBCache.Instance;
				case 'c': return KYCCache.Instance;
				case 'd': return KYDCache.Instance;
				case 'e': return KYECache.Instance;
				case 'f': return KYFCache.Instance;
				case 'g': return KYGCache.Instance;
				case 'h': return KYHCache.Instance;
				case 'i': return KYICache.Instance;
				case 'j': return KYJCache.Instance;
				case 'k': return KYKCache.Instance;
				case 'l': return KYLCache.Instance;
				case 'm': return KYMCache.Instance;
				case 'n': return KYNCache.Instance;
				case 'o': return KYOCache.Instance;
				case 'p': return KYPCache.Instance;
				case 'q': return KYQCache.Instance;
				case 'r': return KYRCache.Instance;
				case 's': return KYSCache.Instance;
				case 't': return KYTCache.Instance;
				case 'u': return KYUCache.Instance;
				case 'v': return KYVCache.Instance;
				case 'w': return KYWCache.Instance;
				case 'x': return KYXCache.Instance;
				case 'y': return KYYCache.Instance;
				case 'z': return KYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KZACache.Instance;
				case 'b': return KZBCache.Instance;
				case 'c': return KZCCache.Instance;
				case 'd': return KZDCache.Instance;
				case 'e': return KZECache.Instance;
				case 'f': return KZFCache.Instance;
				case 'g': return KZGCache.Instance;
				case 'h': return KZHCache.Instance;
				case 'i': return KZICache.Instance;
				case 'j': return DTPCache.Instance;
				case 'k': return KZKCache.Instance;
				case 'l': return KZLCache.Instance;
				case 'm': return KZMCache.Instance;
				case 'n': return KZNCache.Instance;
				case 'o': return KZOCache.Instance;
				case 'p': return KZPCache.Instance;
				case 'q': return KZQCache.Instance;
				case 'r': return KZRCache.Instance;
				case 's': return KZSCache.Instance;
				case 't': return DTPCache.Instance;
				case 'u': return KZUCache.Instance;
				case 'v': return KZVCache.Instance;
				case 'w': return KZWCache.Instance;
				case 'x': return KZXCache.Instance;
				case 'y': return KZYCache.Instance;
				case 'z': return KZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_la(span);
				case 'b': return tryParse_L3_lb(span);
				case 'c': return tryParse_L3_lc(span);
				case 'd': return tryParse_L3_ld(span);
				case 'e': return tryParse_L3_le(span);
				case 'f': return tryParse_L3_lf(span);
				case 'g': return tryParse_L3_lg(span);
				case 'h': return tryParse_L3_lh(span);
				case 'i': return tryParse_L3_li(span);
				case 'j': return tryParse_L3_lj(span);
				case 'k': return tryParse_L3_lk(span);
				case 'l': return tryParse_L3_ll(span);
				case 'm': return tryParse_L3_lm(span);
				case 'n': return tryParse_L3_ln(span);
				case 'o': return tryParse_L3_lo(span);
				case 'p': return tryParse_L3_lp(span);
				case 'q': return tryParse_L3_lq(span);
				case 'r': return tryParse_L3_lr(span);
				case 's': return tryParse_L3_ls(span);
				case 't': return tryParse_L3_lt(span);
				case 'u': return tryParse_L3_lu(span);
				case 'v': return tryParse_L3_lv(span);
				case 'w': return tryParse_L3_lw(span);
				case 'x': return tryParse_L3_lx(span);
				case 'y': return tryParse_L3_ly(span);
				case 'z': return tryParse_L3_lz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_la(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LAACache.Instance;
				case 'b': return LABCache.Instance;
				case 'c': return LACCache.Instance;
				case 'd': return LADCache.Instance;
				case 'e': return LAECache.Instance;
				case 'f': return LAFCache.Instance;
				case 'g': return LAGCache.Instance;
				case 'h': return LAHCache.Instance;
				case 'i': return LAICache.Instance;
				case 'j': return LAJCache.Instance;
				case 'k': return KSPCache.Instance;
				case 'l': return LALCache.Instance;
				case 'm': return LAMCache.Instance;
				case 'n': return LANCache.Instance;
				case 'p': return LAPCache.Instance;
				case 'q': return LAQCache.Instance;
				case 'r': return LARCache.Instance;
				case 's': return LASCache.Instance;
				case 'u': return LAUCache.Instance;
				case 'w': return LAWCache.Instance;
				case 'x': return LAXCache.Instance;
				case 'y': return LAYCache.Instance;
				case 'z': return LAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LBACache.Instance;
				case 'b': return LBBCache.Instance;
				case 'c': return LBCCache.Instance;
				case 'e': return LBECache.Instance;
				case 'f': return LBFCache.Instance;
				case 'g': return LBGCache.Instance;
				case 'i': return LBICache.Instance;
				case 'j': return LBJCache.Instance;
				case 'k': return LBKCache.Instance;
				case 'l': return LBLCache.Instance;
				case 'm': return LBMCache.Instance;
				case 'n': return LBNCache.Instance;
				case 'o': return LBOCache.Instance;
				case 'q': return LBQCache.Instance;
				case 'r': return LBRCache.Instance;
				case 's': return LBSCache.Instance;
				case 't': return LBTCache.Instance;
				case 'u': return LBUCache.Instance;
				case 'v': return LBVCache.Instance;
				case 'w': return LBWCache.Instance;
				case 'x': return LBXCache.Instance;
				case 'y': return LBYCache.Instance;
				case 'z': return LBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return LCCCache.Instance;
				case 'd': return LCDCache.Instance;
				case 'e': return LCECache.Instance;
				case 'f': return LCFCache.Instance;
				case 'h': return LCHCache.Instance;
				case 'l': return LCLCache.Instance;
				case 'm': return LCMCache.Instance;
				case 'p': return LCPCache.Instance;
				case 'q': return LCQCache.Instance;
				case 's': return LCSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ld(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LDACache.Instance;
				case 'b': return LDBCache.Instance;
				case 'd': return LDDCache.Instance;
				case 'g': return LDGCache.Instance;
				case 'h': return LDHCache.Instance;
				case 'i': return LDICache.Instance;
				case 'j': return LDJCache.Instance;
				case 'k': return LDKCache.Instance;
				case 'l': return LDLCache.Instance;
				case 'm': return LDMCache.Instance;
				case 'n': return LDNCache.Instance;
				case 'o': return LDOCache.Instance;
				case 'p': return LDPCache.Instance;
				case 'q': return LDQCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_le(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LEACache.Instance;
				case 'b': return LEBCache.Instance;
				case 'c': return LECCache.Instance;
				case 'd': return LEDCache.Instance;
				case 'e': return LEECache.Instance;
				case 'f': return LEFCache.Instance;
				case 'g': return LEGCache.Instance;
				case 'h': return LEHCache.Instance;
				case 'i': return LEICache.Instance;
				case 'j': return LEJCache.Instance;
				case 'k': return LEKCache.Instance;
				case 'l': return LELCache.Instance;
				case 'm': return LEMCache.Instance;
				case 'n': return LENCache.Instance;
				case 'o': return LEOCache.Instance;
				case 'p': return LEPCache.Instance;
				case 'q': return LEQCache.Instance;
				case 'r': return LERCache.Instance;
				case 's': return LESCache.Instance;
				case 't': return LETCache.Instance;
				case 'u': return LEUCache.Instance;
				case 'v': return LEVCache.Instance;
				case 'w': return LEWCache.Instance;
				case 'x': return LEXCache.Instance;
				case 'y': return LEYCache.Instance;
				case 'z': return LEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LFACache.Instance;
				case 'n': return LFNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LGACache.Instance;
				case 'b': return LGBCache.Instance;
				case 'g': return LGGCache.Instance;
				case 'h': return LGHCache.Instance;
				case 'i': return LGICache.Instance;
				case 'k': return LGKCache.Instance;
				case 'l': return LGLCache.Instance;
				case 'm': return LGMCache.Instance;
				case 'n': return LGNCache.Instance;
				case 'o': return LGOCache.Instance;
				case 'q': return LGQCache.Instance;
				case 'r': return LGRCache.Instance;
				case 's': return LGSCache.Instance;
				case 't': return LGTCache.Instance;
				case 'u': return LGUCache.Instance;
				case 'z': return LGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LHACache.Instance;
				case 'h': return LHHCache.Instance;
				case 'i': return LHICache.Instance;
				case 'l': return LHLCache.Instance;
				case 'm': return LHMCache.Instance;
				case 'n': return LHNCache.Instance;
				case 'p': return LHPCache.Instance;
				case 's': return LHSCache.Instance;
				case 't': return LHTCache.Instance;
				case 'u': return LHUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_li(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LIACache.Instance;
				case 'b': return LIBCache.Instance;
				case 'c': return LICCache.Instance;
				case 'd': return LIDCache.Instance;
				case 'e': return LIECache.Instance;
				case 'f': return LIFCache.Instance;
				case 'g': return LIGCache.Instance;
				case 'h': return LIHCache.Instance;
				case 'i': return RAQCache.Instance;
				case 'j': return LIJCache.Instance;
				case 'k': return LIKCache.Instance;
				case 'l': return LILCache.Instance;
				case 'o': return LIOCache.Instance;
				case 'p': return LIPCache.Instance;
				case 'q': return LIQCache.Instance;
				case 'r': return LIRCache.Instance;
				case 's': return LISCache.Instance;
				case 'u': return LIUCache.Instance;
				case 'v': return LIVCache.Instance;
				case 'w': return LIWCache.Instance;
				case 'x': return LIXCache.Instance;
				case 'y': return LIYCache.Instance;
				case 'z': return LIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LJACache.Instance;
				case 'e': return LJECache.Instance;
				case 'i': return LJICache.Instance;
				case 'l': return LJLCache.Instance;
				case 'p': return LJPCache.Instance;
				case 'w': return LJWCache.Instance;
				case 'x': return LJXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LKACache.Instance;
				case 'b': return LKBCache.Instance;
				case 'c': return LKCCache.Instance;
				case 'd': return LKDCache.Instance;
				case 'e': return LKECache.Instance;
				case 'h': return LKHCache.Instance;
				case 'i': return LKICache.Instance;
				case 'j': return LKJCache.Instance;
				case 'l': return LKLCache.Instance;
				case 'm': return LKMCache.Instance;
				case 'n': return LKNCache.Instance;
				case 'o': return LKOCache.Instance;
				case 'r': return LKRCache.Instance;
				case 's': return LKSCache.Instance;
				case 't': return LKTCache.Instance;
				case 'u': return LKUCache.Instance;
				case 'y': return LKYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ll(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LLACache.Instance;
				case 'b': return LLBCache.Instance;
				case 'c': return LLCCache.Instance;
				case 'd': return LLDCache.Instance;
				case 'e': return LLECache.Instance;
				case 'f': return LLFCache.Instance;
				case 'g': return LLGCache.Instance;
				case 'h': return LLHCache.Instance;
				case 'i': return LLICache.Instance;
				case 'j': return LLJCache.Instance;
				case 'k': return LLKCache.Instance;
				case 'l': return LLLCache.Instance;
				case 'm': return LLMCache.Instance;
				case 'n': return LLNCache.Instance;
				case 'o': return NGTCache.Instance;
				case 'p': return LLPCache.Instance;
				case 'q': return LLQCache.Instance;
				case 's': return LLSCache.Instance;
				case 'u': return LLUCache.Instance;
				case 'x': return LLXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LMACache.Instance;
				case 'b': return LMBCache.Instance;
				case 'c': return LMCCache.Instance;
				case 'd': return LMDCache.Instance;
				case 'e': return LMECache.Instance;
				case 'f': return LMFCache.Instance;
				case 'g': return LMGCache.Instance;
				case 'h': return LMHCache.Instance;
				case 'i': return LMICache.Instance;
				case 'j': return LMJCache.Instance;
				case 'k': return LMKCache.Instance;
				case 'l': return LMLCache.Instance;
				case 'm': return RMXCache.Instance;
				case 'n': return LMNCache.Instance;
				case 'o': return LMOCache.Instance;
				case 'p': return LMPCache.Instance;
				case 'q': return LMQCache.Instance;
				case 'r': return LMRCache.Instance;
				case 'u': return LMUCache.Instance;
				case 'v': return LMVCache.Instance;
				case 'w': return LMWCache.Instance;
				case 'x': return LMXCache.Instance;
				case 'y': return LMYCache.Instance;
				case 'z': return LMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ln(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LNACache.Instance;
				case 'b': return LNBCache.Instance;
				case 'd': return LNDCache.Instance;
				case 'g': return LNGCache.Instance;
				case 'h': return LNHCache.Instance;
				case 'i': return LNICache.Instance;
				case 'j': return LNJCache.Instance;
				case 'l': return LNLCache.Instance;
				case 'm': return LNMCache.Instance;
				case 'n': return LNNCache.Instance;
				case 'o': return LNOCache.Instance;
				case 's': return LNSCache.Instance;
				case 'u': return LNUCache.Instance;
				case 'w': return LNWCache.Instance;
				case 'z': return LNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LOACache.Instance;
				case 'b': return LOBCache.Instance;
				case 'c': return LOCCache.Instance;
				case 'e': return LOECache.Instance;
				case 'f': return LOFCache.Instance;
				case 'g': return LOGCache.Instance;
				case 'h': return LOHCache.Instance;
				case 'i': return LOICache.Instance;
				case 'j': return LOJCache.Instance;
				case 'k': return LOKCache.Instance;
				case 'l': return LOLCache.Instance;
				case 'm': return LOMCache.Instance;
				case 'n': return LONCache.Instance;
				case 'o': return LOOCache.Instance;
				case 'p': return LOPCache.Instance;
				case 'q': return LOQCache.Instance;
				case 'r': return LORCache.Instance;
				case 's': return LOSCache.Instance;
				case 't': return LOTCache.Instance;
				case 'u': return LOUCache.Instance;
				case 'v': return LOVCache.Instance;
				case 'w': return LOWCache.Instance;
				case 'x': return LOXCache.Instance;
				case 'y': return LOYCache.Instance;
				case 'z': return LOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LPACache.Instance;
				case 'e': return LPECache.Instance;
				case 'n': return LPNCache.Instance;
				case 'o': return LPOCache.Instance;
				case 'x': return LPXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return LQRCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_lr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LRACache.Instance;
				case 'c': return LRCCache.Instance;
				case 'e': return LRECache.Instance;
				case 'g': return LRGCache.Instance;
				case 'i': return LRICache.Instance;
				case 'k': return LRKCache.Instance;
				case 'l': return LRLCache.Instance;
				case 'm': return LRMCache.Instance;
				case 'n': return LRNCache.Instance;
				case 'o': return LROCache.Instance;
				case 'r': return LRRCache.Instance;
				case 't': return LRTCache.Instance;
				case 'v': return LRVCache.Instance;
				case 'z': return LRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ls(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LSACache.Instance;
				case 'b': return LSBCache.Instance;
				case 'c': return LSCCache.Instance;
				case 'd': return LSDCache.Instance;
				case 'e': return LSECache.Instance;
				case 'g': return LSGCache.Instance;
				case 'h': return LSHCache.Instance;
				case 'i': return LSICache.Instance;
				case 'l': return LSLCache.Instance;
				case 'm': return LSMCache.Instance;
				case 'n': return LSNCache.Instance;
				case 'o': return LSOCache.Instance;
				case 'p': return LSPCache.Instance;
				case 'r': return LSRCache.Instance;
				case 's': return LSSCache.Instance;
				case 't': return LSTCache.Instance;
				case 'v': return LSVCache.Instance;
				case 'w': return LSWCache.Instance;
				case 'y': return LSYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lt(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return LTCCache.Instance;
				case 'g': return LTGCache.Instance;
				case 'h': return LTHCache.Instance;
				case 'i': return LTICache.Instance;
				case 'n': return LTNCache.Instance;
				case 'o': return LTOCache.Instance;
				case 's': return LTSCache.Instance;
				case 'u': return LTUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LUACache.Instance;
				case 'c': return LUCCache.Instance;
				case 'd': return LUDCache.Instance;
				case 'e': return LUECache.Instance;
				case 'f': return LUFCache.Instance;
				case 'h': return LUHCache.Instance;
				case 'i': return LUICache.Instance;
				case 'j': return LUJCache.Instance;
				case 'k': return LUKCache.Instance;
				case 'l': return LULCache.Instance;
				case 'm': return LUMCache.Instance;
				case 'n': return LUNCache.Instance;
				case 'o': return LUOCache.Instance;
				case 'p': return LUPCache.Instance;
				case 'q': return LUQCache.Instance;
				case 'r': return LURCache.Instance;
				case 's': return LUSCache.Instance;
				case 't': return LUTCache.Instance;
				case 'u': return LUUCache.Instance;
				case 'v': return LUVCache.Instance;
				case 'w': return LUWCache.Instance;
				case 'y': return LUYCache.Instance;
				case 'z': return LUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LVACache.Instance;
				case 'i': return LVICache.Instance;
				case 'k': return LVKCache.Instance;
				case 'l': return LVLCache.Instance;
				case 's': return LVSCache.Instance;
				case 'u': return LVUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LWACache.Instance;
				case 'e': return LWECache.Instance;
				case 'g': return LWGCache.Instance;
				case 'h': return LWHCache.Instance;
				case 'l': return LWLCache.Instance;
				case 'm': return LWMCache.Instance;
				case 'o': return LWOCache.Instance;
				case 's': return LWSCache.Instance;
				case 't': return LWTCache.Instance;
				case 'u': return LWUCache.Instance;
				case 'w': return LWWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return LXMCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ly(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LYACache.Instance;
				case 'g': return LYGCache.Instance;
				case 'n': return LYNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return LZHCache.Instance;
				case 'l': return LZLCache.Instance;
				case 'n': return LZNCache.Instance;
				case 'z': return LZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ma(span);
				case 'b': return tryParse_L3_mb(span);
				case 'c': return tryParse_L3_mc(span);
				case 'd': return tryParse_L3_md(span);
				case 'e': return tryParse_L3_me(span);
				case 'f': return tryParse_L3_mf(span);
				case 'g': return tryParse_L3_mg(span);
				case 'h': return tryParse_L3_mh(span);
				case 'i': return tryParse_L3_mi(span);
				case 'j': return tryParse_L3_mj(span);
				case 'k': return tryParse_L3_mk(span);
				case 'l': return tryParse_L3_ml(span);
				case 'm': return tryParse_L3_mm(span);
				case 'n': return tryParse_L3_mn(span);
				case 'o': return tryParse_L3_mo(span);
				case 'p': return tryParse_L3_mp(span);
				case 'q': return tryParse_L3_mq(span);
				case 'r': return tryParse_L3_mr(span);
				case 's': return tryParse_L3_ms(span);
				case 't': return tryParse_L3_mt(span);
				case 'u': return tryParse_L3_mu(span);
				case 'v': return tryParse_L3_mv(span);
				case 'w': return tryParse_L3_mw(span);
				case 'x': return tryParse_L3_mx(span);
				case 'y': return tryParse_L3_my(span);
				case 'z': return tryParse_L3_mz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ma(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MAACache.Instance;
				case 'b': return MABCache.Instance;
				case 'd': return MADCache.Instance;
				case 'e': return MAECache.Instance;
				case 'f': return MAFCache.Instance;
				case 'g': return MAGCache.Instance;
				case 'i': return MAICache.Instance;
				case 'j': return MAJCache.Instance;
				case 'k': return MAKCache.Instance;
				case 'm': return MAMCache.Instance;
				case 'n': return MANCache.Instance;
				case 'p': return MAPCache.Instance;
				case 'q': return MAQCache.Instance;
				case 's': return MASCache.Instance;
				case 't': return MATCache.Instance;
				case 'u': return MAUCache.Instance;
				case 'v': return MAVCache.Instance;
				case 'w': return MAWCache.Instance;
				case 'x': return MAXCache.Instance;
				case 'z': return MAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MBACache.Instance;
				case 'b': return MBBCache.Instance;
				case 'c': return MBCCache.Instance;
				case 'd': return MBDCache.Instance;
				case 'e': return MBECache.Instance;
				case 'f': return MBFCache.Instance;
				case 'h': return MBHCache.Instance;
				case 'i': return MBICache.Instance;
				case 'j': return MBJCache.Instance;
				case 'k': return MBKCache.Instance;
				case 'l': return MBLCache.Instance;
				case 'm': return MBMCache.Instance;
				case 'n': return MBNCache.Instance;
				case 'o': return MBOCache.Instance;
				case 'p': return MBPCache.Instance;
				case 'q': return MBQCache.Instance;
				case 'r': return MBRCache.Instance;
				case 's': return MBSCache.Instance;
				case 't': return MBTCache.Instance;
				case 'u': return MBUCache.Instance;
				case 'v': return MBVCache.Instance;
				case 'w': return MBWCache.Instance;
				case 'x': return MBXCache.Instance;
				case 'y': return MBYCache.Instance;
				case 'z': return MBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MCACache.Instance;
				case 'b': return MCBCache.Instance;
				case 'c': return MCCCache.Instance;
				case 'd': return MCDCache.Instance;
				case 'e': return MCECache.Instance;
				case 'f': return MCFCache.Instance;
				case 'g': return MCGCache.Instance;
				case 'h': return MCHCache.Instance;
				case 'i': return MCICache.Instance;
				case 'j': return MCJCache.Instance;
				case 'k': return MCKCache.Instance;
				case 'l': return MCLCache.Instance;
				case 'm': return MCMCache.Instance;
				case 'n': return MCNCache.Instance;
				case 'o': return MCOCache.Instance;
				case 'p': return MCPCache.Instance;
				case 'q': return MCQCache.Instance;
				case 'r': return MCRCache.Instance;
				case 's': return MCSCache.Instance;
				case 't': return MCTCache.Instance;
				case 'u': return MCUCache.Instance;
				case 'v': return MCVCache.Instance;
				case 'w': return MCWCache.Instance;
				case 'x': return MCXCache.Instance;
				case 'y': return MCYCache.Instance;
				case 'z': return MCZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_md(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MDACache.Instance;
				case 'b': return MDBCache.Instance;
				case 'c': return MDCCache.Instance;
				case 'd': return MDDCache.Instance;
				case 'e': return MDECache.Instance;
				case 'f': return MDFCache.Instance;
				case 'g': return MDGCache.Instance;
				case 'h': return MDHCache.Instance;
				case 'i': return MDICache.Instance;
				case 'j': return MDJCache.Instance;
				case 'k': return MDKCache.Instance;
				case 'l': return MDLCache.Instance;
				case 'm': return MDMCache.Instance;
				case 'n': return MDNCache.Instance;
				case 'p': return MDPCache.Instance;
				case 'q': return MDQCache.Instance;
				case 'r': return MDRCache.Instance;
				case 's': return MDSCache.Instance;
				case 't': return MDTCache.Instance;
				case 'u': return MDUCache.Instance;
				case 'v': return MDVCache.Instance;
				case 'w': return MDWCache.Instance;
				case 'x': return MDXCache.Instance;
				case 'y': return MDYCache.Instance;
				case 'z': return MDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_me(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MEACache.Instance;
				case 'b': return MEBCache.Instance;
				case 'c': return MECCache.Instance;
				case 'd': return MEDCache.Instance;
				case 'e': return MEECache.Instance;
				case 'f': return MEFCache.Instance;
				case 'g': return CIRCache.Instance;
				case 'h': return MEHCache.Instance;
				case 'i': return MEICache.Instance;
				case 'j': return MEJCache.Instance;
				case 'k': return MEKCache.Instance;
				case 'l': return MELCache.Instance;
				case 'm': return MEMCache.Instance;
				case 'n': return MENCache.Instance;
				case 'o': return MEOCache.Instance;
				case 'p': return MEPCache.Instance;
				case 'q': return MEQCache.Instance;
				case 'r': return MERCache.Instance;
				case 's': return MESCache.Instance;
				case 't': return METCache.Instance;
				case 'u': return MEUCache.Instance;
				case 'v': return MEVCache.Instance;
				case 'w': return MEWCache.Instance;
				case 'y': return MEYCache.Instance;
				case 'z': return MEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MFACache.Instance;
				case 'b': return MFBCache.Instance;
				case 'c': return MFCCache.Instance;
				case 'd': return MFDCache.Instance;
				case 'e': return MFECache.Instance;
				case 'f': return MFFCache.Instance;
				case 'g': return MFGCache.Instance;
				case 'h': return MFHCache.Instance;
				case 'i': return MFICache.Instance;
				case 'j': return MFJCache.Instance;
				case 'k': return MFKCache.Instance;
				case 'l': return MFLCache.Instance;
				case 'm': return MFMCache.Instance;
				case 'n': return MFNCache.Instance;
				case 'o': return MFOCache.Instance;
				case 'p': return MFPCache.Instance;
				case 'q': return MFQCache.Instance;
				case 'r': return MFRCache.Instance;
				case 's': return MFSCache.Instance;
				case 't': return MFTCache.Instance;
				case 'u': return MFUCache.Instance;
				case 'v': return MFVCache.Instance;
				case 'w': return MFWCache.Instance;
				case 'x': return MFXCache.Instance;
				case 'y': return MFYCache.Instance;
				case 'z': return MFZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MGACache.Instance;
				case 'b': return MGBCache.Instance;
				case 'c': return MGCCache.Instance;
				case 'd': return MGDCache.Instance;
				case 'e': return MGECache.Instance;
				case 'f': return MGFCache.Instance;
				case 'g': return MGGCache.Instance;
				case 'h': return MGHCache.Instance;
				case 'i': return MGICache.Instance;
				case 'j': return MGJCache.Instance;
				case 'k': return MGKCache.Instance;
				case 'l': return MGLCache.Instance;
				case 'm': return MGMCache.Instance;
				case 'n': return MGNCache.Instance;
				case 'o': return MGOCache.Instance;
				case 'p': return MGPCache.Instance;
				case 'q': return MGQCache.Instance;
				case 'r': return MGRCache.Instance;
				case 's': return MGSCache.Instance;
				case 't': return MGTCache.Instance;
				case 'u': return MGUCache.Instance;
				case 'v': return MGVCache.Instance;
				case 'w': return MGWCache.Instance;
				case 'x': return MGXCache.Instance;
				case 'y': return MGYCache.Instance;
				case 'z': return MGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MHACache.Instance;
				case 'b': return MHBCache.Instance;
				case 'c': return MHCCache.Instance;
				case 'd': return MHDCache.Instance;
				case 'e': return MHECache.Instance;
				case 'f': return MHFCache.Instance;
				case 'g': return MHGCache.Instance;
				case 'h': return MHHCache.Instance;
				case 'i': return MHICache.Instance;
				case 'j': return MHJCache.Instance;
				case 'k': return MHKCache.Instance;
				case 'l': return MHLCache.Instance;
				case 'm': return MHMCache.Instance;
				case 'n': return MHNCache.Instance;
				case 'o': return MHOCache.Instance;
				case 'p': return MHPCache.Instance;
				case 'q': return MHQCache.Instance;
				case 'r': return MHRCache.Instance;
				case 's': return MHSCache.Instance;
				case 't': return MHTCache.Instance;
				case 'u': return MHUCache.Instance;
				case 'w': return MHWCache.Instance;
				case 'x': return MHXCache.Instance;
				case 'y': return MHYCache.Instance;
				case 'z': return MHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MIACache.Instance;
				case 'b': return MIBCache.Instance;
				case 'c': return MICCache.Instance;
				case 'd': return MIDCache.Instance;
				case 'e': return MIECache.Instance;
				case 'f': return MIFCache.Instance;
				case 'g': return MIGCache.Instance;
				case 'h': return MIHCache.Instance;
				case 'i': return MIICache.Instance;
				case 'j': return MIJCache.Instance;
				case 'k': return MIKCache.Instance;
				case 'l': return MILCache.Instance;
				case 'm': return MIMCache.Instance;
				case 'n': return MINCache.Instance;
				case 'o': return MIOCache.Instance;
				case 'p': return MIPCache.Instance;
				case 'q': return MIQCache.Instance;
				case 'r': return MIRCache.Instance;
				case 's': return MISCache.Instance;
				case 't': return MITCache.Instance;
				case 'u': return MIUCache.Instance;
				case 'w': return MIWCache.Instance;
				case 'x': return MIXCache.Instance;
				case 'y': return MIYCache.Instance;
				case 'z': return MIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MJACache.Instance;
				case 'b': return MJBCache.Instance;
				case 'c': return MJCCache.Instance;
				case 'd': return MJDCache.Instance;
				case 'e': return MJECache.Instance;
				case 'g': return MJGCache.Instance;
				case 'h': return MJHCache.Instance;
				case 'i': return MJICache.Instance;
				case 'j': return MJJCache.Instance;
				case 'k': return MJKCache.Instance;
				case 'l': return MJLCache.Instance;
				case 'm': return MJMCache.Instance;
				case 'n': return MJNCache.Instance;
				case 'o': return MJOCache.Instance;
				case 'p': return MJPCache.Instance;
				case 'q': return MJQCache.Instance;
				case 'r': return MJRCache.Instance;
				case 's': return MJSCache.Instance;
				case 't': return MJTCache.Instance;
				case 'u': return MJUCache.Instance;
				case 'v': return MJVCache.Instance;
				case 'w': return MJWCache.Instance;
				case 'x': return MJXCache.Instance;
				case 'y': return MJYCache.Instance;
				case 'z': return MJZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MKACache.Instance;
				case 'b': return MKBCache.Instance;
				case 'c': return MKCCache.Instance;
				case 'e': return MKECache.Instance;
				case 'f': return MKFCache.Instance;
				case 'g': return MKGCache.Instance;
				case 'h': return MKHCache.Instance;
				case 'i': return MKICache.Instance;
				case 'j': return MKJCache.Instance;
				case 'k': return MKKCache.Instance;
				case 'l': return MKLCache.Instance;
				case 'm': return MKMCache.Instance;
				case 'n': return MKNCache.Instance;
				case 'o': return MKOCache.Instance;
				case 'p': return MKPCache.Instance;
				case 'q': return MKQCache.Instance;
				case 'r': return MKRCache.Instance;
				case 's': return MKSCache.Instance;
				case 't': return MKTCache.Instance;
				case 'u': return MKUCache.Instance;
				case 'v': return MKVCache.Instance;
				case 'w': return MKWCache.Instance;
				case 'x': return MKXCache.Instance;
				case 'y': return MKYCache.Instance;
				case 'z': return MKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ml(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MLACache.Instance;
				case 'b': return MLBCache.Instance;
				case 'c': return MLCCache.Instance;
				case 'd': return MLDCache.Instance;
				case 'e': return MLECache.Instance;
				case 'f': return MLFCache.Instance;
				case 'h': return MLHCache.Instance;
				case 'i': return MLICache.Instance;
				case 'j': return MLJCache.Instance;
				case 'k': return MLKCache.Instance;
				case 'l': return MLLCache.Instance;
				case 'm': return MLMCache.Instance;
				case 'n': return MLNCache.Instance;
				case 'o': return MLOCache.Instance;
				case 'p': return MLPCache.Instance;
				case 'q': return MLQCache.Instance;
				case 'r': return MLRCache.Instance;
				case 's': return MLSCache.Instance;
				case 'u': return MLUCache.Instance;
				case 'v': return MLVCache.Instance;
				case 'w': return MLWCache.Instance;
				case 'x': return MLXCache.Instance;
				case 'z': return MLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MMACache.Instance;
				case 'b': return MMBCache.Instance;
				case 'c': return MMCCache.Instance;
				case 'd': return MMDCache.Instance;
				case 'e': return MMECache.Instance;
				case 'f': return MMFCache.Instance;
				case 'g': return MMGCache.Instance;
				case 'h': return MMHCache.Instance;
				case 'i': return MMICache.Instance;
				case 'j': return MMJCache.Instance;
				case 'k': return MMKCache.Instance;
				case 'l': return MMLCache.Instance;
				case 'm': return MMMCache.Instance;
				case 'n': return MMNCache.Instance;
				case 'o': return MMOCache.Instance;
				case 'p': return MMPCache.Instance;
				case 'q': return MMQCache.Instance;
				case 'r': return MMRCache.Instance;
				case 't': return MMTCache.Instance;
				case 'u': return MMUCache.Instance;
				case 'v': return MMVCache.Instance;
				case 'w': return MMWCache.Instance;
				case 'x': return MMXCache.Instance;
				case 'y': return MMYCache.Instance;
				case 'z': return MMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MNACache.Instance;
				case 'b': return MNBCache.Instance;
				case 'c': return MNCCache.Instance;
				case 'd': return MNDCache.Instance;
				case 'e': return MNECache.Instance;
				case 'f': return MNFCache.Instance;
				case 'g': return MNGCache.Instance;
				case 'h': return MNHCache.Instance;
				case 'i': return MNICache.Instance;
				case 'j': return MNJCache.Instance;
				case 'k': return MNKCache.Instance;
				case 'l': return MNLCache.Instance;
				case 'm': return MNMCache.Instance;
				case 'n': return MNNCache.Instance;
				case 'o': return MNOCache.Instance;
				case 'p': return MNPCache.Instance;
				case 'q': return MNQCache.Instance;
				case 'r': return MNRCache.Instance;
				case 's': return MNSCache.Instance;
				case 't': return MNTCache.Instance;
				case 'u': return MNUCache.Instance;
				case 'v': return MNVCache.Instance;
				case 'w': return MNWCache.Instance;
				case 'x': return MNXCache.Instance;
				case 'y': return MNYCache.Instance;
				case 'z': return MNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MOACache.Instance;
				case 'c': return MOCCache.Instance;
				case 'd': return MODCache.Instance;
				case 'e': return MOECache.Instance;
				case 'f': return MOFCache.Instance;
				case 'g': return MOGCache.Instance;
				case 'h': return MOHCache.Instance;
				case 'i': return MOICache.Instance;
				case 'j': return MOJCache.Instance;
				case 'k': return MOKCache.Instance;
				case 'm': return MOMCache.Instance;
				case 'o': return MOOCache.Instance;
				case 'p': return MOPCache.Instance;
				case 'q': return MOQCache.Instance;
				case 'r': return MORCache.Instance;
				case 's': return MOSCache.Instance;
				case 't': return MOTCache.Instance;
				case 'u': return MOUCache.Instance;
				case 'v': return MOVCache.Instance;
				case 'w': return MOWCache.Instance;
				case 'x': return MOXCache.Instance;
				case 'y': return MOYCache.Instance;
				case 'z': return MOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MPACache.Instance;
				case 'b': return MPBCache.Instance;
				case 'c': return MPCCache.Instance;
				case 'd': return MPDCache.Instance;
				case 'e': return MPECache.Instance;
				case 'g': return MPGCache.Instance;
				case 'h': return MPHCache.Instance;
				case 'i': return MPICache.Instance;
				case 'j': return MPJCache.Instance;
				case 'k': return MPKCache.Instance;
				case 'l': return MPLCache.Instance;
				case 'm': return MPMCache.Instance;
				case 'n': return MPNCache.Instance;
				case 'o': return MPOCache.Instance;
				case 'p': return MPPCache.Instance;
				case 'q': return MPQCache.Instance;
				case 'r': return MPRCache.Instance;
				case 's': return MPSCache.Instance;
				case 't': return MPTCache.Instance;
				case 'u': return MPUCache.Instance;
				case 'v': return MPVCache.Instance;
				case 'w': return MPWCache.Instance;
				case 'x': return MPXCache.Instance;
				case 'y': return MPYCache.Instance;
				case 'z': return MPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MQACache.Instance;
				case 'b': return MQBCache.Instance;
				case 'c': return MQCCache.Instance;
				case 'e': return MQECache.Instance;
				case 'f': return MQFCache.Instance;
				case 'g': return MQGCache.Instance;
				case 'h': return MQHCache.Instance;
				case 'i': return MQICache.Instance;
				case 'j': return MQJCache.Instance;
				case 'k': return MQKCache.Instance;
				case 'l': return MQLCache.Instance;
				case 'm': return MQMCache.Instance;
				case 'n': return MQNCache.Instance;
				case 'o': return MQOCache.Instance;
				case 'p': return MQPCache.Instance;
				case 'q': return MQQCache.Instance;
				case 'r': return MQRCache.Instance;
				case 's': return MQSCache.Instance;
				case 't': return MQTCache.Instance;
				case 'u': return MQUCache.Instance;
				case 'v': return MQVCache.Instance;
				case 'w': return MQWCache.Instance;
				case 'x': return MQXCache.Instance;
				case 'y': return MQYCache.Instance;
				case 'z': return MQZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MRACache.Instance;
				case 'b': return MRBCache.Instance;
				case 'c': return MRCCache.Instance;
				case 'd': return MRDCache.Instance;
				case 'e': return MRECache.Instance;
				case 'f': return MRFCache.Instance;
				case 'g': return MRGCache.Instance;
				case 'h': return MRHCache.Instance;
				case 'j': return MRJCache.Instance;
				case 'k': return MRKCache.Instance;
				case 'l': return MRLCache.Instance;
				case 'm': return MRMCache.Instance;
				case 'n': return MRNCache.Instance;
				case 'o': return MROCache.Instance;
				case 'p': return MRPCache.Instance;
				case 'q': return MRQCache.Instance;
				case 'r': return MRRCache.Instance;
				case 's': return MRSCache.Instance;
				case 't': return MRTCache.Instance;
				case 'u': return MRUCache.Instance;
				case 'v': return MRVCache.Instance;
				case 'w': return MRWCache.Instance;
				case 'x': return MRXCache.Instance;
				case 'y': return MRYCache.Instance;
				case 'z': return MRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ms(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return MSBCache.Instance;
				case 'c': return MSCCache.Instance;
				case 'd': return MSDCache.Instance;
				case 'e': return MSECache.Instance;
				case 'f': return MSFCache.Instance;
				case 'g': return MSGCache.Instance;
				case 'h': return MSHCache.Instance;
				case 'i': return MSICache.Instance;
				case 'j': return MSJCache.Instance;
				case 'k': return MSKCache.Instance;
				case 'l': return MSLCache.Instance;
				case 'm': return MSMCache.Instance;
				case 'n': return MSNCache.Instance;
				case 'o': return MSOCache.Instance;
				case 'p': return MSPCache.Instance;
				case 'q': return MSQCache.Instance;
				case 'r': return MSRCache.Instance;
				case 's': return MSSCache.Instance;
				case 't': return MRYCache.Instance;
				case 'u': return MSUCache.Instance;
				case 'v': return MSVCache.Instance;
				case 'w': return MSWCache.Instance;
				case 'x': return MSXCache.Instance;
				case 'y': return MSYCache.Instance;
				case 'z': return MSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MTACache.Instance;
				case 'b': return MTBCache.Instance;
				case 'c': return MTCCache.Instance;
				case 'd': return MTDCache.Instance;
				case 'e': return MTECache.Instance;
				case 'f': return MTFCache.Instance;
				case 'g': return MTGCache.Instance;
				case 'h': return MTHCache.Instance;
				case 'i': return MTICache.Instance;
				case 'j': return MTJCache.Instance;
				case 'k': return MTKCache.Instance;
				case 'l': return MTLCache.Instance;
				case 'm': return MTMCache.Instance;
				case 'n': return MTNCache.Instance;
				case 'o': return MTOCache.Instance;
				case 'p': return MTPCache.Instance;
				case 'q': return MTQCache.Instance;
				case 'r': return MTRCache.Instance;
				case 's': return MTSCache.Instance;
				case 't': return MTTCache.Instance;
				case 'u': return MTUCache.Instance;
				case 'v': return MTVCache.Instance;
				case 'w': return MTWCache.Instance;
				case 'x': return MTXCache.Instance;
				case 'y': return MTYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MUACache.Instance;
				case 'b': return MUBCache.Instance;
				case 'c': return MUCCache.Instance;
				case 'd': return MUDCache.Instance;
				case 'e': return MUECache.Instance;
				case 'g': return MUGCache.Instance;
				case 'h': return MUHCache.Instance;
				case 'i': return MUICache.Instance;
				case 'j': return MUJCache.Instance;
				case 'k': return MUKCache.Instance;
				case 'l': return MULCache.Instance;
				case 'm': return MUMCache.Instance;
				case 'n': return MUNCache.Instance;
				case 'o': return MUOCache.Instance;
				case 'p': return MUPCache.Instance;
				case 'q': return MUQCache.Instance;
				case 'r': return MURCache.Instance;
				case 's': return MUSCache.Instance;
				case 't': return MUTCache.Instance;
				case 'u': return MUUCache.Instance;
				case 'v': return MUVCache.Instance;
				case 'x': return MUXCache.Instance;
				case 'y': return MUYCache.Instance;
				case 'z': return MUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MVACache.Instance;
				case 'b': return MVBCache.Instance;
				case 'd': return MVDCache.Instance;
				case 'e': return MVECache.Instance;
				case 'f': return MVFCache.Instance;
				case 'g': return MVGCache.Instance;
				case 'h': return MVHCache.Instance;
				case 'i': return MVICache.Instance;
				case 'k': return MVKCache.Instance;
				case 'l': return MVLCache.Instance;
				case 'm': return MVMCache.Instance;
				case 'n': return MVNCache.Instance;
				case 'o': return MVOCache.Instance;
				case 'p': return MVPCache.Instance;
				case 'q': return MVQCache.Instance;
				case 'r': return MVRCache.Instance;
				case 's': return MVSCache.Instance;
				case 't': return MVTCache.Instance;
				case 'u': return MVUCache.Instance;
				case 'v': return MVVCache.Instance;
				case 'w': return MVWCache.Instance;
				case 'x': return MVXCache.Instance;
				case 'y': return MVYCache.Instance;
				case 'z': return MVZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MWACache.Instance;
				case 'b': return MWBCache.Instance;
				case 'c': return MWCCache.Instance;
				case 'd': return MWDCache.Instance;
				case 'e': return MWECache.Instance;
				case 'f': return MWFCache.Instance;
				case 'g': return MWGCache.Instance;
				case 'h': return MWHCache.Instance;
				case 'i': return MWICache.Instance;
				case 'j': return VAJCache.Instance;
				case 'k': return MWKCache.Instance;
				case 'l': return MWLCache.Instance;
				case 'm': return MWMCache.Instance;
				case 'n': return MWNCache.Instance;
				case 'o': return MWOCache.Instance;
				case 'p': return MWPCache.Instance;
				case 'q': return MWQCache.Instance;
				case 'r': return MWRCache.Instance;
				case 's': return MWSCache.Instance;
				case 't': return MWTCache.Instance;
				case 'u': return MWUCache.Instance;
				case 'v': return MWVCache.Instance;
				case 'w': return MWWCache.Instance;
				case 'x': return MWXCache.Instance;
				case 'y': return MWYCache.Instance;
				case 'z': return MWZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MXACache.Instance;
				case 'b': return MXBCache.Instance;
				case 'c': return MXCCache.Instance;
				case 'd': return MXDCache.Instance;
				case 'e': return MXECache.Instance;
				case 'f': return MXFCache.Instance;
				case 'g': return MXGCache.Instance;
				case 'h': return MXHCache.Instance;
				case 'i': return MXICache.Instance;
				case 'j': return MXJCache.Instance;
				case 'k': return MXKCache.Instance;
				case 'l': return MXLCache.Instance;
				case 'm': return MXMCache.Instance;
				case 'n': return MXNCache.Instance;
				case 'o': return MXOCache.Instance;
				case 'p': return MXPCache.Instance;
				case 'q': return MXQCache.Instance;
				case 'r': return MXRCache.Instance;
				case 's': return MXSCache.Instance;
				case 't': return MXTCache.Instance;
				case 'u': return MXUCache.Instance;
				case 'v': return MXVCache.Instance;
				case 'w': return MXWCache.Instance;
				case 'x': return MXXCache.Instance;
				case 'y': return MXYCache.Instance;
				case 'z': return MXZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_my(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return MYBCache.Instance;
				case 'c': return MYCCache.Instance;
				case 'd': return AOGCache.Instance;
				case 'e': return MYECache.Instance;
				case 'f': return MYFCache.Instance;
				case 'g': return MYGCache.Instance;
				case 'h': return MYHCache.Instance;
				case 'i': return MYICache.Instance;
				case 'j': return MYJCache.Instance;
				case 'k': return MYKCache.Instance;
				case 'l': return MYLCache.Instance;
				case 'm': return MYMCache.Instance;
				case 'n': return MYNCache.Instance;
				case 'o': return MYOCache.Instance;
				case 'p': return MYPCache.Instance;
				case 'q': return MYQCache.Instance;
				case 'r': return MYRCache.Instance;
				case 's': return MYSCache.Instance;
				case 't': return MRYCache.Instance;
				case 'u': return MYUCache.Instance;
				case 'v': return MYVCache.Instance;
				case 'w': return MYWCache.Instance;
				case 'x': return MYXCache.Instance;
				case 'y': return MYYCache.Instance;
				case 'z': return MYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MZACache.Instance;
				case 'b': return MZBCache.Instance;
				case 'c': return MZCCache.Instance;
				case 'd': return MZDCache.Instance;
				case 'e': return MZECache.Instance;
				case 'g': return MZGCache.Instance;
				case 'h': return MZHCache.Instance;
				case 'i': return MZICache.Instance;
				case 'j': return MZJCache.Instance;
				case 'k': return MZKCache.Instance;
				case 'l': return MZLCache.Instance;
				case 'm': return MZMCache.Instance;
				case 'n': return MZNCache.Instance;
				case 'o': return MZOCache.Instance;
				case 'p': return MZPCache.Instance;
				case 'q': return MZQCache.Instance;
				case 'r': return MZRCache.Instance;
				case 's': return MZSCache.Instance;
				case 't': return MZTCache.Instance;
				case 'u': return MZUCache.Instance;
				case 'v': return MZVCache.Instance;
				case 'w': return MZWCache.Instance;
				case 'x': return MZXCache.Instance;
				case 'y': return MZYCache.Instance;
				case 'z': return MZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_na(span);
				case 'b': return tryParse_L3_nb(span);
				case 'c': return tryParse_L3_nc(span);
				case 'd': return tryParse_L3_nd(span);
				case 'e': return tryParse_L3_ne(span);
				case 'f': return tryParse_L3_nf(span);
				case 'g': return tryParse_L3_ng(span);
				case 'h': return tryParse_L3_nh(span);
				case 'i': return tryParse_L3_ni(span);
				case 'j': return tryParse_L3_nj(span);
				case 'k': return tryParse_L3_nk(span);
				case 'l': return tryParse_L3_nl(span);
				case 'm': return tryParse_L3_nm(span);
				case 'n': return tryParse_L3_nn(span);
				case 'o': return tryParse_L3_no(span);
				case 'p': return tryParse_L3_np(span);
				case 'q': return tryParse_L3_nq(span);
				case 'r': return tryParse_L3_nr(span);
				case 's': return tryParse_L3_ns(span);
				case 't': return tryParse_L3_nt(span);
				case 'u': return tryParse_L3_nu(span);
				case 'v': return tryParse_L3_nv(span);
				case 'w': return tryParse_L3_nw(span);
				case 'x': return tryParse_L3_nx(span);
				case 'y': return tryParse_L3_ny(span);
				case 'z': return tryParse_L3_nz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_na(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NAACache.Instance;
				case 'b': return NABCache.Instance;
				case 'c': return NACCache.Instance;
				case 'd': return XNYCache.Instance;
				case 'e': return NAECache.Instance;
				case 'f': return NAFCache.Instance;
				case 'g': return NAGCache.Instance;
				case 'h': return NAHCache.Instance;
				case 'i': return NAICache.Instance;
				case 'j': return NAJCache.Instance;
				case 'k': return NAKCache.Instance;
				case 'l': return NALCache.Instance;
				case 'm': return NAMCache.Instance;
				case 'n': return NANCache.Instance;
				case 'o': return NAOCache.Instance;
				case 'p': return NAPCache.Instance;
				case 'q': return NAQCache.Instance;
				case 'r': return NARCache.Instance;
				case 's': return NASCache.Instance;
				case 't': return NATCache.Instance;
				case 'w': return NAWCache.Instance;
				case 'x': return NAXCache.Instance;
				case 'y': return NAYCache.Instance;
				case 'z': return NAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NBACache.Instance;
				case 'b': return NBBCache.Instance;
				case 'c': return NBCCache.Instance;
				case 'd': return NBDCache.Instance;
				case 'e': return NBECache.Instance;
				case 'f': return NBFCache.Instance;
				case 'g': return NBGCache.Instance;
				case 'h': return NBHCache.Instance;
				case 'i': return NBICache.Instance;
				case 'j': return NBJCache.Instance;
				case 'k': return NBKCache.Instance;
				case 'm': return NBMCache.Instance;
				case 'n': return NBNCache.Instance;
				case 'o': return NBOCache.Instance;
				case 'p': return NBPCache.Instance;
				case 'q': return NBQCache.Instance;
				case 'r': return NBRCache.Instance;
				case 's': return NBSCache.Instance;
				case 't': return NBTCache.Instance;
				case 'u': return NBUCache.Instance;
				case 'v': return NBVCache.Instance;
				case 'w': return NBWCache.Instance;
				case 'x': return NBXCache.Instance;
				case 'y': return NBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NCACache.Instance;
				case 'b': return NCBCache.Instance;
				case 'c': return NCCCache.Instance;
				case 'd': return NCDCache.Instance;
				case 'e': return NCECache.Instance;
				case 'f': return NCFCache.Instance;
				case 'g': return NCGCache.Instance;
				case 'h': return NCHCache.Instance;
				case 'i': return NCICache.Instance;
				case 'j': return NCJCache.Instance;
				case 'k': return NCKCache.Instance;
				case 'l': return NCLCache.Instance;
				case 'm': return NCMCache.Instance;
				case 'n': return NCNCache.Instance;
				case 'o': return NCOCache.Instance;
				case 'p': return KDZCache.Instance;
				case 'q': return NCQCache.Instance;
				case 'r': return NCRCache.Instance;
				case 's': return NCSCache.Instance;
				case 't': return NCTCache.Instance;
				case 'u': return NCUCache.Instance;
				case 'x': return NCXCache.Instance;
				case 'z': return NCZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NDACache.Instance;
				case 'b': return NDBCache.Instance;
				case 'c': return NDCCache.Instance;
				case 'd': return NDDCache.Instance;
				case 'f': return NDFCache.Instance;
				case 'g': return NDGCache.Instance;
				case 'h': return NDHCache.Instance;
				case 'i': return NDICache.Instance;
				case 'j': return NDJCache.Instance;
				case 'k': return NDKCache.Instance;
				case 'l': return NDLCache.Instance;
				case 'm': return NDMCache.Instance;
				case 'n': return NDNCache.Instance;
				case 'p': return NDPCache.Instance;
				case 'q': return NDQCache.Instance;
				case 'r': return NDRCache.Instance;
				case 's': return NDSCache.Instance;
				case 't': return NDTCache.Instance;
				case 'u': return NDUCache.Instance;
				case 'v': return NDVCache.Instance;
				case 'w': return NDWCache.Instance;
				case 'x': return NDXCache.Instance;
				case 'y': return NDYCache.Instance;
				case 'z': return NDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ne(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NEACache.Instance;
				case 'b': return NEBCache.Instance;
				case 'c': return NECCache.Instance;
				case 'd': return NEDCache.Instance;
				case 'e': return NEECache.Instance;
				case 'f': return NEFCache.Instance;
				case 'g': return NEGCache.Instance;
				case 'h': return NEHCache.Instance;
				case 'i': return NEICache.Instance;
				case 'j': return NEJCache.Instance;
				case 'k': return NEKCache.Instance;
				case 'm': return NEMCache.Instance;
				case 'n': return NENCache.Instance;
				case 'o': return NEOCache.Instance;
				case 'q': return NEQCache.Instance;
				case 'r': return NERCache.Instance;
				case 's': return NESCache.Instance;
				case 't': return NETCache.Instance;
				case 'u': return NEUCache.Instance;
				case 'v': return NEVCache.Instance;
				case 'w': return NEWCache.Instance;
				case 'x': return NEXCache.Instance;
				case 'y': return NEYCache.Instance;
				case 'z': return NEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NFACache.Instance;
				case 'd': return NFDCache.Instance;
				case 'l': return NFLCache.Instance;
				case 'r': return NFRCache.Instance;
				case 'u': return NFUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ng(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NGACache.Instance;
				case 'b': return NGBCache.Instance;
				case 'c': return NGCCache.Instance;
				case 'd': return NGDCache.Instance;
				case 'e': return NGECache.Instance;
				case 'f': return NGFCache.Instance;
				case 'g': return NGGCache.Instance;
				case 'h': return NGHCache.Instance;
				case 'i': return NGICache.Instance;
				case 'j': return NGJCache.Instance;
				case 'k': return NGKCache.Instance;
				case 'l': return NGLCache.Instance;
				case 'm': return NGMCache.Instance;
				case 'n': return NGNCache.Instance;
				case 'o': return NGOCache.Instance;
				case 'p': return NGPCache.Instance;
				case 'q': return NGQCache.Instance;
				case 'r': return NGRCache.Instance;
				case 's': return NGSCache.Instance;
				case 't': return NGTCache.Instance;
				case 'u': return NGUCache.Instance;
				case 'v': return NGVCache.Instance;
				case 'w': return NGWCache.Instance;
				case 'x': return NGXCache.Instance;
				case 'y': return NGYCache.Instance;
				case 'z': return NGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NHACache.Instance;
				case 'b': return NHBCache.Instance;
				case 'c': return NHCCache.Instance;
				case 'd': return NHDCache.Instance;
				case 'e': return NHECache.Instance;
				case 'f': return NHFCache.Instance;
				case 'g': return NHGCache.Instance;
				case 'h': return NHHCache.Instance;
				case 'i': return NHICache.Instance;
				case 'k': return NHKCache.Instance;
				case 'm': return NHMCache.Instance;
				case 'n': return NHNCache.Instance;
				case 'o': return NHOCache.Instance;
				case 'p': return NHPCache.Instance;
				case 'q': return NHQCache.Instance;
				case 'r': return NHRCache.Instance;
				case 't': return NHTCache.Instance;
				case 'u': return NHUCache.Instance;
				case 'v': return NHVCache.Instance;
				case 'w': return NHWCache.Instance;
				case 'x': return NHXCache.Instance;
				case 'y': return NHYCache.Instance;
				case 'z': return NHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ni(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NIACache.Instance;
				case 'b': return NIBCache.Instance;
				case 'c': return NICCache.Instance;
				case 'd': return NIDCache.Instance;
				case 'e': return NIECache.Instance;
				case 'f': return NIFCache.Instance;
				case 'g': return NIGCache.Instance;
				case 'h': return NIHCache.Instance;
				case 'i': return NIICache.Instance;
				case 'j': return NIJCache.Instance;
				case 'k': return NIKCache.Instance;
				case 'l': return NILCache.Instance;
				case 'm': return NIMCache.Instance;
				case 'n': return NINCache.Instance;
				case 'o': return NIOCache.Instance;
				case 'q': return NIQCache.Instance;
				case 'r': return NIRCache.Instance;
				case 's': return NISCache.Instance;
				case 't': return NITCache.Instance;
				case 'u': return NIUCache.Instance;
				case 'v': return NIVCache.Instance;
				case 'w': return NIWCache.Instance;
				case 'x': return NIXCache.Instance;
				case 'y': return NIYCache.Instance;
				case 'z': return NIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NJACache.Instance;
				case 'b': return NJBCache.Instance;
				case 'd': return NJDCache.Instance;
				case 'h': return NJHCache.Instance;
				case 'i': return NJICache.Instance;
				case 'j': return NJJCache.Instance;
				case 'l': return NJLCache.Instance;
				case 'm': return NJMCache.Instance;
				case 'n': return NJNCache.Instance;
				case 'o': return NJOCache.Instance;
				case 'r': return NJRCache.Instance;
				case 's': return NJSCache.Instance;
				case 't': return NJTCache.Instance;
				case 'u': return NJUCache.Instance;
				case 'x': return NJXCache.Instance;
				case 'y': return NJYCache.Instance;
				case 'z': return NJZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NKACache.Instance;
				case 'b': return NKBCache.Instance;
				case 'c': return NKCCache.Instance;
				case 'd': return NKDCache.Instance;
				case 'e': return NKECache.Instance;
				case 'f': return NKFCache.Instance;
				case 'g': return NKGCache.Instance;
				case 'h': return NKHCache.Instance;
				case 'i': return NKICache.Instance;
				case 'j': return NKJCache.Instance;
				case 'k': return NKKCache.Instance;
				case 'm': return NKMCache.Instance;
				case 'n': return NKNCache.Instance;
				case 'o': return NKOCache.Instance;
				case 'p': return NKPCache.Instance;
				case 'q': return NKQCache.Instance;
				case 'r': return NKRCache.Instance;
				case 's': return NKSCache.Instance;
				case 't': return NKTCache.Instance;
				case 'u': return NKUCache.Instance;
				case 'v': return NKVCache.Instance;
				case 'w': return NKWCache.Instance;
				case 'x': return NKXCache.Instance;
				case 'z': return NKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NLACache.Instance;
				case 'c': return NLCCache.Instance;
				case 'e': return NLECache.Instance;
				case 'g': return NLGCache.Instance;
				case 'i': return NLICache.Instance;
				case 'j': return NLJCache.Instance;
				case 'k': return NLKCache.Instance;
				case 'l': return NLLCache.Instance;
				case 'm': return NLMCache.Instance;
				case 'n': return NLNCache.Instance;
				case 'o': return NLOCache.Instance;
				case 'q': return NLQCache.Instance;
				case 'r': return NLRCache.Instance;
				case 'u': return NLUCache.Instance;
				case 'v': return NLVCache.Instance;
				case 'w': return NLWCache.Instance;
				case 'x': return NLXCache.Instance;
				case 'y': return NLYCache.Instance;
				case 'z': return NLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NMACache.Instance;
				case 'b': return NMBCache.Instance;
				case 'c': return NMCCache.Instance;
				case 'd': return NMDCache.Instance;
				case 'e': return NMECache.Instance;
				case 'f': return NMFCache.Instance;
				case 'g': return NMGCache.Instance;
				case 'h': return NMHCache.Instance;
				case 'i': return NMICache.Instance;
				case 'j': return NMJCache.Instance;
				case 'k': return NMKCache.Instance;
				case 'l': return NMLCache.Instance;
				case 'm': return NMMCache.Instance;
				case 'n': return NMNCache.Instance;
				case 'o': return NMOCache.Instance;
				case 'p': return NMPCache.Instance;
				case 'q': return NMQCache.Instance;
				case 'r': return NMRCache.Instance;
				case 's': return NMSCache.Instance;
				case 't': return NMTCache.Instance;
				case 'u': return NMUCache.Instance;
				case 'v': return NMVCache.Instance;
				case 'w': return NMWCache.Instance;
				case 'x': return NMXCache.Instance;
				case 'y': return NMYCache.Instance;
				case 'z': return NMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NNACache.Instance;
				case 'b': return NNBCache.Instance;
				case 'c': return NNCCache.Instance;
				case 'd': return NNDCache.Instance;
				case 'e': return NNECache.Instance;
				case 'f': return NNFCache.Instance;
				case 'g': return NNGCache.Instance;
				case 'h': return NNHCache.Instance;
				case 'i': return NNICache.Instance;
				case 'j': return NNJCache.Instance;
				case 'k': return NNKCache.Instance;
				case 'l': return NNLCache.Instance;
				case 'm': return NNMCache.Instance;
				case 'n': return NNNCache.Instance;
				case 'p': return NNPCache.Instance;
				case 'q': return NNQCache.Instance;
				case 'r': return NNRCache.Instance;
				case 's': return NBRCache.Instance;
				case 't': return NNTCache.Instance;
				case 'u': return NNUCache.Instance;
				case 'v': return NNVCache.Instance;
				case 'w': return NNWCache.Instance;
				case 'x': return NGVCache.Instance;
				case 'y': return NNYCache.Instance;
				case 'z': return NNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_no(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NOACache.Instance;
				case 'c': return NOCCache.Instance;
				case 'd': return NODCache.Instance;
				case 'e': return NOECache.Instance;
				case 'f': return NOFCache.Instance;
				case 'g': return NOGCache.Instance;
				case 'h': return NOHCache.Instance;
				case 'i': return NOICache.Instance;
				case 'j': return NOJCache.Instance;
				case 'k': return NOKCache.Instance;
				case 'l': return NOLCache.Instance;
				case 'm': return CBRCache.Instance;
				case 'n': return NONCache.Instance;
				case 'o': return NOOCache.Instance;
				case 'p': return NOPCache.Instance;
				case 'q': return NOQCache.Instance;
				case 's': return NOSCache.Instance;
				case 't': return NOTCache.Instance;
				case 'u': return NOUCache.Instance;
				case 'v': return NOVCache.Instance;
				case 'w': return NOWCache.Instance;
				case 'y': return NOYCache.Instance;
				case 'z': return NOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_np(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NPACache.Instance;
				case 'b': return NPBCache.Instance;
				case 'g': return NPGCache.Instance;
				case 'h': return NPHCache.Instance;
				case 'i': return NPICache.Instance;
				case 'l': return NPLCache.Instance;
				case 'n': return NPNCache.Instance;
				case 'o': return NPOCache.Instance;
				case 's': return NPSCache.Instance;
				case 'u': return NPUCache.Instance;
				case 'x': return NPXCache.Instance;
				case 'y': return NPYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nq(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return NQGCache.Instance;
				case 'k': return NQKCache.Instance;
				case 'l': return NQLCache.Instance;
				case 'm': return NQMCache.Instance;
				case 'n': return NQNCache.Instance;
				case 'o': return NQOCache.Instance;
				case 'q': return NQQCache.Instance;
				case 't': return NQTCache.Instance;
				case 'y': return NQYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NRACache.Instance;
				case 'b': return NRBCache.Instance;
				case 'c': return NRCCache.Instance;
				case 'e': return NRECache.Instance;
				case 'f': return NRFCache.Instance;
				case 'g': return NRGCache.Instance;
				case 'i': return NRICache.Instance;
				case 'k': return NRKCache.Instance;
				case 'l': return NRLCache.Instance;
				case 'm': return NRMCache.Instance;
				case 'n': return NRNCache.Instance;
				case 'p': return NRPCache.Instance;
				case 'r': return NRRCache.Instance;
				case 't': return NRTCache.Instance;
				case 'u': return NRUCache.Instance;
				case 'x': return NRXCache.Instance;
				case 'z': return NRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ns(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NSACache.Instance;
				case 'b': return NSBCache.Instance;
				case 'c': return NSCCache.Instance;
				case 'd': return NSDCache.Instance;
				case 'e': return NSECache.Instance;
				case 'f': return NSFCache.Instance;
				case 'g': return NSGCache.Instance;
				case 'h': return NSHCache.Instance;
				case 'i': return NSICache.Instance;
				case 'k': return NSKCache.Instance;
				case 'l': return NSLCache.Instance;
				case 'm': return NSMCache.Instance;
				case 'n': return NSNCache.Instance;
				case 'o': return NSOCache.Instance;
				case 'p': return NSPCache.Instance;
				case 'q': return NSQCache.Instance;
				case 'r': return NSRCache.Instance;
				case 's': return NSSCache.Instance;
				case 't': return NSTCache.Instance;
				case 'u': return NSUCache.Instance;
				case 'v': return NSVCache.Instance;
				case 'w': return NSWCache.Instance;
				case 'x': return NSXCache.Instance;
				case 'y': return NSYCache.Instance;
				case 'z': return NSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nt(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return NTDCache.Instance;
				case 'e': return EKOCache.Instance;
				case 'g': return NTGCache.Instance;
				case 'i': return NTICache.Instance;
				case 'j': return NTJCache.Instance;
				case 'k': return NTKCache.Instance;
				case 'm': return NTMCache.Instance;
				case 'o': return NTOCache.Instance;
				case 'p': return NTPCache.Instance;
				case 'r': return NTRCache.Instance;
				case 's': return PIJCache.Instance;
				case 'u': return NTUCache.Instance;
				case 'w': return NTWCache.Instance;
				case 'x': return NTXCache.Instance;
				case 'y': return NTYCache.Instance;
				case 'z': return NTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NUACache.Instance;
				case 'b': return NUBCache.Instance;
				case 'c': return NUCCache.Instance;
				case 'd': return NUDCache.Instance;
				case 'e': return NUECache.Instance;
				case 'f': return NUFCache.Instance;
				case 'g': return NUGCache.Instance;
				case 'h': return NUHCache.Instance;
				case 'i': return NUICache.Instance;
				case 'j': return NUJCache.Instance;
				case 'k': return NUKCache.Instance;
				case 'l': return NULCache.Instance;
				case 'm': return NUMCache.Instance;
				case 'n': return NUNCache.Instance;
				case 'o': return NUOCache.Instance;
				case 'p': return NUPCache.Instance;
				case 'q': return NUQCache.Instance;
				case 'r': return NURCache.Instance;
				case 's': return NUSCache.Instance;
				case 't': return NUTCache.Instance;
				case 'u': return NUUCache.Instance;
				case 'v': return NUVCache.Instance;
				case 'w': return NUWCache.Instance;
				case 'x': return NUXCache.Instance;
				case 'y': return NUYCache.Instance;
				case 'z': return NUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nv(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return NVHCache.Instance;
				case 'm': return NVMCache.Instance;
				case 'o': return NVOCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NWACache.Instance;
				case 'b': return NWBCache.Instance;
				case 'c': return NWCCache.Instance;
				case 'e': return NWECache.Instance;
				case 'g': return NWGCache.Instance;
				case 'i': return NWICache.Instance;
				case 'm': return NWMCache.Instance;
				case 'o': return NWOCache.Instance;
				case 'r': return NWRCache.Instance;
				case 'w': return NWWCache.Instance;
				case 'x': return NWXCache.Instance;
				case 'y': return NWYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NXACache.Instance;
				case 'd': return NXDCache.Instance;
				case 'e': return NXECache.Instance;
				case 'g': return NXGCache.Instance;
				case 'i': return NXICache.Instance;
				case 'k': return NXKCache.Instance;
				case 'l': return NXLCache.Instance;
				case 'm': return NXMCache.Instance;
				case 'n': return NXNCache.Instance;
				case 'o': return NXOCache.Instance;
				case 'q': return NXQCache.Instance;
				case 'r': return NXRCache.Instance;
				case 'u': return BPPCache.Instance;
				case 'x': return NXXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ny(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return NYBCache.Instance;
				case 'c': return NYCCache.Instance;
				case 'd': return NYDCache.Instance;
				case 'e': return NYECache.Instance;
				case 'f': return NYFCache.Instance;
				case 'g': return NYGCache.Instance;
				case 'h': return NYHCache.Instance;
				case 'i': return NYICache.Instance;
				case 'j': return NYJCache.Instance;
				case 'k': return NYKCache.Instance;
				case 'l': return NYLCache.Instance;
				case 'm': return NYMCache.Instance;
				case 'n': return NYNCache.Instance;
				case 'o': return NYOCache.Instance;
				case 'p': return NYPCache.Instance;
				case 'q': return NYQCache.Instance;
				case 'r': return NYRCache.Instance;
				case 's': return NYSCache.Instance;
				case 't': return NYTCache.Instance;
				case 'u': return NYUCache.Instance;
				case 'v': return NYVCache.Instance;
				case 'w': return NYWCache.Instance;
				case 'x': return NYXCache.Instance;
				case 'y': return NYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NZACache.Instance;
				case 'b': return NZBCache.Instance;
				case 'd': return NZDCache.Instance;
				case 'i': return NZICache.Instance;
				case 'k': return NZKCache.Instance;
				case 'm': return NZMCache.Instance;
				case 'r': return NZRCache.Instance;
				case 's': return NZSCache.Instance;
				case 'u': return NZUCache.Instance;
				case 'y': return NZYCache.Instance;
				case 'z': return NZZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_o(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_oa(span);
				case 'b': return tryParse_L3_ob(span);
				case 'c': return tryParse_L3_oc(span);
				case 'd': return tryParse_L3_od(span);
				case 'f': return tryParse_L3_of(span);
				case 'g': return tryParse_L3_og(span);
				case 'h': return tryParse_L3_oh(span);
				case 'i': return tryParse_L3_oi(span);
				case 'j': return tryParse_L3_oj(span);
				case 'k': return tryParse_L3_ok(span);
				case 'l': return tryParse_L3_ol(span);
				case 'm': return tryParse_L3_om(span);
				case 'n': return tryParse_L3_on(span);
				case 'o': return tryParse_L3_oo(span);
				case 'p': return tryParse_L3_op(span);
				case 'r': return tryParse_L3_or(span);
				case 's': return tryParse_L3_os(span);
				case 't': return tryParse_L3_ot(span);
				case 'u': return tryParse_L3_ou(span);
				case 'v': return tryParse_L3_ov(span);
				case 'w': return tryParse_L3_ow(span);
				case 'y': return tryParse_L3_oy(span);
				case 'z': return tryParse_L3_oz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OAACache.Instance;
				case 'c': return OACCache.Instance;
				case 'r': return OARCache.Instance;
				case 'v': return OAVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ob(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return OBICache.Instance;
				case 'k': return OBKCache.Instance;
				case 'l': return OBLCache.Instance;
				case 'm': return OBMCache.Instance;
				case 'o': return OBOCache.Instance;
				case 'r': return OBRCache.Instance;
				case 't': return OBTCache.Instance;
				case 'u': return OBUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OCACache.Instance;
				case 'h': return OCHCache.Instance;
				case 'm': return OCMCache.Instance;
				case 'o': return OCOCache.Instance;
				case 'u': return OCUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_od(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ODACache.Instance;
				case 'k': return ODKCache.Instance;
				case 't': return ODTCache.Instance;
				case 'u': return ODUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_of(StringSpan span)
		{
			switch(span[2])
			{
				case 'o': return OFOCache.Instance;
				case 's': return OFSCache.Instance;
				case 'u': return OFUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_og(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OGBCache.Instance;
				case 'c': return OGCCache.Instance;
				case 'e': return OGECache.Instance;
				case 'g': return OGGCache.Instance;
				case 'o': return OGOCache.Instance;
				case 'u': return OGUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oh(StringSpan span)
		{
			switch(span[2])
			{
				case 't': return OHTCache.Instance;
				case 'u': return OHUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OIACache.Instance;
				case 'e': return OIECache.Instance;
				case 'n': return OINCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oj(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OJBCache.Instance;
				case 'c': return OJCCache.Instance;
				case 'g': return OJGCache.Instance;
				case 'p': return OJPCache.Instance;
				case 's': return OJSCache.Instance;
				case 'v': return OJVCache.Instance;
				case 'w': return OJWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ok(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OKACache.Instance;
				case 'b': return OKBCache.Instance;
				case 'c': return OKCCache.Instance;
				case 'd': return OKDCache.Instance;
				case 'e': return OKECache.Instance;
				case 'g': return OKGCache.Instance;
				case 'h': return OKHCache.Instance;
				case 'i': return OKICache.Instance;
				case 'j': return OKJCache.Instance;
				case 'k': return OKKCache.Instance;
				case 'l': return OKLCache.Instance;
				case 'm': return OKMCache.Instance;
				case 'n': return OKNCache.Instance;
				case 'o': return OKOCache.Instance;
				case 'r': return OKRCache.Instance;
				case 's': return OKSCache.Instance;
				case 'u': return OKUCache.Instance;
				case 'v': return OKVCache.Instance;
				case 'x': return OKXCache.Instance;
				case 'z': return OKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ol(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OLACache.Instance;
				case 'd': return OLDCache.Instance;
				case 'e': return OLECache.Instance;
				case 'k': return OLKCache.Instance;
				case 'm': return OLMCache.Instance;
				case 'o': return OLOCache.Instance;
				case 'r': return OLRCache.Instance;
				case 't': return OLTCache.Instance;
				case 'u': return OLUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_om(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OMACache.Instance;
				case 'b': return OMBCache.Instance;
				case 'c': return OMCCache.Instance;
				case 'e': return OMECache.Instance;
				case 'g': return OMGCache.Instance;
				case 'i': return OMICache.Instance;
				case 'k': return OMKCache.Instance;
				case 'l': return OMLCache.Instance;
				case 'n': return OMNCache.Instance;
				case 'o': return OMOCache.Instance;
				case 'p': return OMPCache.Instance;
				case 'q': return OMQCache.Instance;
				case 'r': return OMRCache.Instance;
				case 't': return OMTCache.Instance;
				case 'u': return OMUCache.Instance;
				case 'v': return OMVCache.Instance;
				case 'w': return OMWCache.Instance;
				case 'x': return OMXCache.Instance;
				case 'y': return OMYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_on(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ONACache.Instance;
				case 'b': return ONBCache.Instance;
				case 'e': return ONECache.Instance;
				case 'g': return ONGCache.Instance;
				case 'i': return ONICache.Instance;
				case 'j': return ONJCache.Instance;
				case 'k': return ONKCache.Instance;
				case 'n': return ONNCache.Instance;
				case 'o': return ONOCache.Instance;
				case 'p': return ONPCache.Instance;
				case 'r': return ONRCache.Instance;
				case 's': return ONSCache.Instance;
				case 't': return ONTCache.Instance;
				case 'u': return ONUCache.Instance;
				case 'w': return ONWCache.Instance;
				case 'x': return ONXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oo(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return OODCache.Instance;
				case 'g': return OOGCache.Instance;
				case 'n': return OONCache.Instance;
				case 'r': return OORCache.Instance;
				case 's': return OOSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_op(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OPACache.Instance;
				case 'k': return OPKCache.Instance;
				case 'm': return OPMCache.Instance;
				case 'o': return OPOCache.Instance;
				case 't': return OPTCache.Instance;
				case 'y': return OPYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_or(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ORACache.Instance;
				case 'c': return ORCCache.Instance;
				case 'e': return ORECache.Instance;
				case 'g': return ORGCache.Instance;
				case 'h': return ORHCache.Instance;
				case 'n': return ORNCache.Instance;
				case 'o': return OROCache.Instance;
				case 'r': return ORRCache.Instance;
				case 's': return ORSCache.Instance;
				case 't': return ORTCache.Instance;
				case 'u': return ORUCache.Instance;
				case 'v': return ORVCache.Instance;
				case 'w': return ORWCache.Instance;
				case 'x': return ORXCache.Instance;
				case 'y': return ORYCache.Instance;
				case 'z': return ORZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_os(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OSACache.Instance;
				case 'c': return OSCCache.Instance;
				case 'i': return OSICache.Instance;
				case 'n': return OSNCache.Instance;
				case 'o': return OSOCache.Instance;
				case 'p': return OSPCache.Instance;
				case 't': return OSTCache.Instance;
				case 'u': return OSUCache.Instance;
				case 'x': return OSXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ot(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OTACache.Instance;
				case 'b': return OTBCache.Instance;
				case 'd': return OTDCache.Instance;
				case 'e': return OTECache.Instance;
				case 'i': return OTICache.Instance;
				case 'k': return OTKCache.Instance;
				case 'l': return OTLCache.Instance;
				case 'm': return OTMCache.Instance;
				case 'n': return OTNCache.Instance;
				case 'o': return OTOCache.Instance;
				case 'q': return OTQCache.Instance;
				case 'r': return OTRCache.Instance;
				case 's': return OTSCache.Instance;
				case 't': return OTTCache.Instance;
				case 'u': return OTUCache.Instance;
				case 'w': return OTWCache.Instance;
				case 'x': return OTXCache.Instance;
				case 'y': return OTYCache.Instance;
				case 'z': return OTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ou(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OUACache.Instance;
				case 'b': return OUBCache.Instance;
				case 'e': return OUECache.Instance;
				case 'i': return OUICache.Instance;
				case 'm': return OUMCache.Instance;
				case 'n': return VAJCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ov(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return OVDCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ow(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return OWICache.Instance;
				case 'l': return OWLCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oy(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OYBCache.Instance;
				case 'd': return OYDCache.Instance;
				case 'm': return OYMCache.Instance;
				case 'y': return OYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return OZMCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_pa(span);
				case 'b': return tryParse_L3_pb(span);
				case 'c': return tryParse_L3_pc(span);
				case 'd': return tryParse_L3_pd(span);
				case 'e': return tryParse_L3_pe(span);
				case 'f': return tryParse_L3_pf(span);
				case 'g': return tryParse_L3_pg(span);
				case 'h': return tryParse_L3_ph(span);
				case 'i': return tryParse_L3_pi(span);
				case 'j': return tryParse_L3_pj(span);
				case 'k': return tryParse_L3_pk(span);
				case 'l': return tryParse_L3_pl(span);
				case 'm': return tryParse_L3_pm(span);
				case 'n': return tryParse_L3_pn(span);
				case 'o': return tryParse_L3_po(span);
				case 'p': return tryParse_L3_pp(span);
				case 'q': return tryParse_L3_pq(span);
				case 'r': return tryParse_L3_pr(span);
				case 's': return tryParse_L3_ps(span);
				case 't': return tryParse_L3_pt(span);
				case 'u': return tryParse_L3_pu(span);
				case 'w': return tryParse_L3_pw(span);
				case 'x': return tryParse_L3_px(span);
				case 'y': return tryParse_L3_py(span);
				case 'z': return tryParse_L3_pz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PAACache.Instance;
				case 'b': return PABCache.Instance;
				case 'c': return PACCache.Instance;
				case 'd': return PADCache.Instance;
				case 'e': return PAECache.Instance;
				case 'f': return PAFCache.Instance;
				case 'g': return PAGCache.Instance;
				case 'h': return PAHCache.Instance;
				case 'i': return PAICache.Instance;
				case 'k': return PAKCache.Instance;
				case 'l': return PALCache.Instance;
				case 'm': return PAMCache.Instance;
				case 'o': return PAOCache.Instance;
				case 'p': return PAPCache.Instance;
				case 'q': return PAQCache.Instance;
				case 'r': return PARCache.Instance;
				case 's': return PASCache.Instance;
				case 't': return KXRCache.Instance;
				case 'u': return PAUCache.Instance;
				case 'v': return PAVCache.Instance;
				case 'w': return PAWCache.Instance;
				case 'x': return PAXCache.Instance;
				case 'y': return PAYCache.Instance;
				case 'z': return PAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return PBBCache.Instance;
				case 'c': return PBCCache.Instance;
				case 'e': return PBECache.Instance;
				case 'f': return PBFCache.Instance;
				case 'g': return PBGCache.Instance;
				case 'h': return PBHCache.Instance;
				case 'i': return PBICache.Instance;
				case 'l': return PBLCache.Instance;
				case 'm': return PBMCache.Instance;
				case 'n': return PBNCache.Instance;
				case 'o': return PBOCache.Instance;
				case 'p': return PBPCache.Instance;
				case 'r': return PBRCache.Instance;
				case 's': return PBSCache.Instance;
				case 't': return PBTCache.Instance;
				case 'u': return PBUCache.Instance;
				case 'v': return PBVCache.Instance;
				case 'y': return PBYCache.Instance;
				case 'z': return PBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PCACache.Instance;
				case 'b': return PCBCache.Instance;
				case 'c': return PCCCache.Instance;
				case 'd': return PCDCache.Instance;
				case 'e': return PCECache.Instance;
				case 'f': return PCFCache.Instance;
				case 'g': return PCGCache.Instance;
				case 'h': return PCHCache.Instance;
				case 'i': return PCICache.Instance;
				case 'j': return PCJCache.Instance;
				case 'k': return PCKCache.Instance;
				case 'l': return PCLCache.Instance;
				case 'm': return PCMCache.Instance;
				case 'n': return PCNCache.Instance;
				case 'p': return PCPCache.Instance;
				case 'r': return ADXCache.Instance;
				case 'w': return PCWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PDACache.Instance;
				case 'c': return PDCCache.Instance;
				case 'i': return PDICache.Instance;
				case 'n': return PDNCache.Instance;
				case 'o': return PDOCache.Instance;
				case 't': return PDTCache.Instance;
				case 'u': return PDUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pe(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PEACache.Instance;
				case 'b': return PEBCache.Instance;
				case 'd': return PEDCache.Instance;
				case 'e': return PEECache.Instance;
				case 'f': return PEFCache.Instance;
				case 'g': return PEGCache.Instance;
				case 'h': return PEHCache.Instance;
				case 'i': return PEICache.Instance;
				case 'j': return PEJCache.Instance;
				case 'k': return PEKCache.Instance;
				case 'l': return PELCache.Instance;
				case 'm': return PEMCache.Instance;
				case 'o': return PEOCache.Instance;
				case 'p': return PEPCache.Instance;
				case 'q': return PEQCache.Instance;
				case 's': return PESCache.Instance;
				case 'v': return PEVCache.Instance;
				case 'x': return PEXCache.Instance;
				case 'y': return PEYCache.Instance;
				case 'z': return PEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PFACache.Instance;
				case 'e': return PFECache.Instance;
				case 'l': return PFLCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PGACache.Instance;
				case 'd': return PGDCache.Instance;
				case 'g': return PGGCache.Instance;
				case 'i': return PGICache.Instance;
				case 'k': return PGKCache.Instance;
				case 'l': return PGLCache.Instance;
				case 'n': return PGNCache.Instance;
				case 's': return PGSCache.Instance;
				case 'u': return PGUCache.Instance;
				case 'y': return PGYCache.Instance;
				case 'z': return PGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ph(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PHACache.Instance;
				case 'd': return PHDCache.Instance;
				case 'g': return PHGCache.Instance;
				case 'h': return PHHCache.Instance;
				case 'i': return PHICache.Instance;
				case 'j': return PHJCache.Instance;
				case 'k': return PHKCache.Instance;
				case 'l': return PHLCache.Instance;
				case 'm': return PHMCache.Instance;
				case 'n': return PHNCache.Instance;
				case 'o': return PHOCache.Instance;
				case 'q': return PHQCache.Instance;
				case 'r': return PHRCache.Instance;
				case 't': return PHTCache.Instance;
				case 'u': return PHUCache.Instance;
				case 'v': return PHVCache.Instance;
				case 'w': return PHWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PIACache.Instance;
				case 'b': return PIBCache.Instance;
				case 'c': return PICCache.Instance;
				case 'd': return PIDCache.Instance;
				case 'e': return PIECache.Instance;
				case 'f': return PIFCache.Instance;
				case 'g': return PIGCache.Instance;
				case 'h': return PIHCache.Instance;
				case 'i': return PIICache.Instance;
				case 'j': return PIJCache.Instance;
				case 'l': return PILCache.Instance;
				case 'm': return PIMCache.Instance;
				case 'n': return PINCache.Instance;
				case 'o': return PIOCache.Instance;
				case 'p': return PIPCache.Instance;
				case 'r': return PIRCache.Instance;
				case 's': return PISCache.Instance;
				case 't': return PITCache.Instance;
				case 'u': return PIUCache.Instance;
				case 'v': return PIVCache.Instance;
				case 'w': return PIWCache.Instance;
				case 'x': return PIXCache.Instance;
				case 'y': return PIYCache.Instance;
				case 'z': return PIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return PJTCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_pk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PKACache.Instance;
				case 'b': return PKBCache.Instance;
				case 'c': return PKCCache.Instance;
				case 'g': return PKGCache.Instance;
				case 'h': return PKHCache.Instance;
				case 'n': return PKNCache.Instance;
				case 'o': return PKOCache.Instance;
				case 'p': return PKPCache.Instance;
				case 'r': return PKRCache.Instance;
				case 's': return PKSCache.Instance;
				case 't': return PKTCache.Instance;
				case 'u': return PKUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PLACache.Instance;
				case 'b': return PLBCache.Instance;
				case 'c': return PLCCache.Instance;
				case 'd': return PLDCache.Instance;
				case 'e': return PLECache.Instance;
				case 'f': return PLFCache.Instance;
				case 'g': return PLGCache.Instance;
				case 'h': return PLHCache.Instance;
				case 'j': return PLJCache.Instance;
				case 'k': return PLKCache.Instance;
				case 'l': return PLLCache.Instance;
				case 'n': return PLNCache.Instance;
				case 'o': return PLOCache.Instance;
				case 'p': return PLPCache.Instance;
				case 'q': return PLQCache.Instance;
				case 'r': return PLRCache.Instance;
				case 's': return PLSCache.Instance;
				case 't': return PLTCache.Instance;
				case 'u': return PLUCache.Instance;
				case 'v': return PLVCache.Instance;
				case 'w': return PLWCache.Instance;
				case 'y': return PLYCache.Instance;
				case 'z': return PLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PMACache.Instance;
				case 'b': return PMBCache.Instance;
				case 'c': return HUWCache.Instance;
				case 'd': return PMDCache.Instance;
				case 'e': return PMECache.Instance;
				case 'f': return PMFCache.Instance;
				case 'h': return PMHCache.Instance;
				case 'i': return PMICache.Instance;
				case 'j': return PMJCache.Instance;
				case 'k': return CRRCache.Instance;
				case 'l': return PMLCache.Instance;
				case 'm': return PMMCache.Instance;
				case 'n': return PMNCache.Instance;
				case 'o': return PMOCache.Instance;
				case 'q': return PMQCache.Instance;
				case 'r': return PMRCache.Instance;
				case 's': return PMSCache.Instance;
				case 't': return PMTCache.Instance;
				case 'u': return PHRCache.Instance;
				case 'w': return PMWCache.Instance;
				case 'x': return PMXCache.Instance;
				case 'y': return PMYCache.Instance;
				case 'z': return PMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PNACache.Instance;
				case 'b': return PNBCache.Instance;
				case 'c': return PNCCache.Instance;
				case 'd': return PNDCache.Instance;
				case 'e': return PNECache.Instance;
				case 'g': return PNGCache.Instance;
				case 'h': return PNHCache.Instance;
				case 'i': return PNICache.Instance;
				case 'j': return PNJCache.Instance;
				case 'k': return PNKCache.Instance;
				case 'l': return PNLCache.Instance;
				case 'm': return PNMCache.Instance;
				case 'n': return PNNCache.Instance;
				case 'o': return PNOCache.Instance;
				case 'p': return PNPCache.Instance;
				case 'q': return PNQCache.Instance;
				case 'r': return PNRCache.Instance;
				case 's': return PNSCache.Instance;
				case 't': return PNTCache.Instance;
				case 'u': return PNUCache.Instance;
				case 'v': return PNVCache.Instance;
				case 'w': return PNWCache.Instance;
				case 'x': return PNXCache.Instance;
				case 'y': return PNYCache.Instance;
				case 'z': return PNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_po(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return POCCache.Instance;
				case 'd': return PODCache.Instance;
				case 'e': return POECache.Instance;
				case 'f': return POFCache.Instance;
				case 'g': return POGCache.Instance;
				case 'h': return POHCache.Instance;
				case 'i': return POICache.Instance;
				case 'k': return POKCache.Instance;
				case 'm': return POMCache.Instance;
				case 'n': return PONCache.Instance;
				case 'o': return POOCache.Instance;
				case 'p': return POPCache.Instance;
				case 'q': return POQCache.Instance;
				case 's': return POSCache.Instance;
				case 't': return POTCache.Instance;
				case 'v': return POVCache.Instance;
				case 'w': return POWCache.Instance;
				case 'x': return POXCache.Instance;
				case 'y': return POYCache.Instance;
				case 'z': return POZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BFYCache.Instance;
				case 'e': return PPECache.Instance;
				case 'i': return PPICache.Instance;
				case 'k': return PPKCache.Instance;
				case 'l': return PPLCache.Instance;
				case 'm': return PPMCache.Instance;
				case 'n': return PPNCache.Instance;
				case 'o': return PPOCache.Instance;
				case 'p': return PPPCache.Instance;
				case 'q': return PPQCache.Instance;
				case 'r': return LCQCache.Instance;
				case 's': return PPSCache.Instance;
				case 't': return PPTCache.Instance;
				case 'u': return PPUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PQACache.Instance;
				case 'e': return PQECache.Instance;
				case 'm': return PQMCache.Instance;
				case 'w': return PQWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PRACache.Instance;
				case 'b': return PRBCache.Instance;
				case 'c': return PRCCache.Instance;
				case 'd': return PRDCache.Instance;
				case 'e': return PRECache.Instance;
				case 'f': return PRFCache.Instance;
				case 'g': return PRGCache.Instance;
				case 'h': return PRHCache.Instance;
				case 'i': return PRICache.Instance;
				case 'k': return PRKCache.Instance;
				case 'l': return PRLCache.Instance;
				case 'm': return PRMCache.Instance;
				case 'n': return PRNCache.Instance;
				case 'o': return PROCache.Instance;
				case 'p': return GUCache.Instance;
				case 'q': return PRQCache.Instance;
				case 'r': return PRRCache.Instance;
				case 's': return PRSCache.Instance;
				case 't': return PRTCache.Instance;
				case 'u': return PRUCache.Instance;
				case 'w': return PRWCache.Instance;
				case 'x': return PRXCache.Instance;
				case 'y': return PRTCache.Instance;
				case 'z': return PRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ps(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PSACache.Instance;
				case 'c': return PSCCache.Instance;
				case 'd': return PSDCache.Instance;
				case 'e': return PSECache.Instance;
				case 'g': return PSGCache.Instance;
				case 'h': return PSHCache.Instance;
				case 'i': return PSICache.Instance;
				case 'l': return PSLCache.Instance;
				case 'm': return PSMCache.Instance;
				case 'n': return PSNCache.Instance;
				case 'o': return PSOCache.Instance;
				case 'p': return PSPCache.Instance;
				case 'q': return PSQCache.Instance;
				case 'r': return PSRCache.Instance;
				case 's': return PSSCache.Instance;
				case 't': return PSTCache.Instance;
				case 'u': return PSUCache.Instance;
				case 'w': return PSWCache.Instance;
				case 'y': return PSYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PTACache.Instance;
				case 'h': return PTHCache.Instance;
				case 'i': return PTICache.Instance;
				case 'n': return PTNCache.Instance;
				case 'o': return PTOCache.Instance;
				case 'p': return PTPCache.Instance;
				case 'q': return PTQCache.Instance;
				case 'r': return PTRCache.Instance;
				case 't': return PTTCache.Instance;
				case 'u': return PTUCache.Instance;
				case 'v': return PTVCache.Instance;
				case 'w': return PTWCache.Instance;
				case 'y': return PTYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PUACache.Instance;
				case 'b': return PUBCache.Instance;
				case 'c': return PUCCache.Instance;
				case 'd': return PUDCache.Instance;
				case 'e': return PUECache.Instance;
				case 'f': return PUFCache.Instance;
				case 'g': return PUGCache.Instance;
				case 'i': return PUICache.Instance;
				case 'j': return PUJCache.Instance;
				case 'k': return PUKCache.Instance;
				case 'm': return PUMCache.Instance;
				case 'o': return PUOCache.Instance;
				case 'p': return PUPCache.Instance;
				case 'q': return PUQCache.Instance;
				case 'r': return PURCache.Instance;
				case 't': return PUTCache.Instance;
				case 'u': return PUUCache.Instance;
				case 'w': return PUWCache.Instance;
				case 'x': return PUXCache.Instance;
				case 'y': return PUYCache.Instance;
				case 'z': return PUBCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PWACache.Instance;
				case 'b': return PWBCache.Instance;
				case 'g': return PWGCache.Instance;
				case 'i': return PWICache.Instance;
				case 'm': return PWMCache.Instance;
				case 'n': return PWNCache.Instance;
				case 'o': return PWOCache.Instance;
				case 'r': return PWRCache.Instance;
				case 'w': return PWWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_px(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return PXMCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_py(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return PYECache.Instance;
				case 'm': return PYMCache.Instance;
				case 'n': return PYNCache.Instance;
				case 's': return PYSCache.Instance;
				case 'u': return PYUCache.Instance;
				case 'x': return PYXCache.Instance;
				case 'y': return PYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pz(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return PZECache.Instance;
				case 'h': return PZHCache.Instance;
				case 'n': return PZNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_q(StringSpan span)
		{
			switch(span[1])
			{
				case 'u': return tryParse_L3_qu(span);
				case 'v': return tryParse_L3_qv(span);
				case 'w': return tryParse_L3_qw(span);
				case 'x': return tryParse_L3_qx(span);
				case 'y': return tryParse_L3_qy(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QUACache.Instance;
				case 'b': return QUBCache.Instance;
				case 'c': return QUCCache.Instance;
				case 'd': return QUDCache.Instance;
				case 'f': return QUFCache.Instance;
				case 'g': return QUGCache.Instance;
				case 'h': return QUHCache.Instance;
				case 'i': return QUICache.Instance;
				case 'k': return QUKCache.Instance;
				case 'l': return QULCache.Instance;
				case 'm': return QUMCache.Instance;
				case 'n': return QUNCache.Instance;
				case 'p': return QUPCache.Instance;
				case 'q': return QUQCache.Instance;
				case 'r': return QURCache.Instance;
				case 's': return QUSCache.Instance;
				case 'v': return QUVCache.Instance;
				case 'w': return QUWCache.Instance;
				case 'x': return QUXCache.Instance;
				case 'y': return QUYCache.Instance;
				case 'z': return QUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QVACache.Instance;
				case 'c': return QVCCache.Instance;
				case 'e': return QVECache.Instance;
				case 'h': return QVHCache.Instance;
				case 'i': return QVICache.Instance;
				case 'j': return QVJCache.Instance;
				case 'l': return QVLCache.Instance;
				case 'm': return QVMCache.Instance;
				case 'n': return QVNCache.Instance;
				case 'o': return QVOCache.Instance;
				case 'p': return QVPCache.Instance;
				case 's': return QVSCache.Instance;
				case 'w': return QVWCache.Instance;
				case 'y': return QVYCache.Instance;
				case 'z': return QVZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QWACache.Instance;
				case 'c': return QWCCache.Instance;
				case 'e': return QWECache.Instance;
				case 'h': return QWHCache.Instance;
				case 'm': return QWMCache.Instance;
				case 's': return QWSCache.Instance;
				case 't': return QWTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QXACache.Instance;
				case 'c': return QXCCache.Instance;
				case 'h': return QXHCache.Instance;
				case 'l': return QXLCache.Instance;
				case 'n': return QXNCache.Instance;
				case 'o': return QXOCache.Instance;
				case 'p': return QXPCache.Instance;
				case 'q': return QXQCache.Instance;
				case 'r': return QXRCache.Instance;
				case 's': return QXSCache.Instance;
				case 't': return QXTCache.Instance;
				case 'u': return QXUCache.Instance;
				case 'w': return QXWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QYACache.Instance;
				case 'p': return QYPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ra(span);
				case 'b': return tryParse_L3_rb(span);
				case 'c': return tryParse_L3_rc(span);
				case 'd': return tryParse_L3_rd(span);
				case 'e': return tryParse_L3_re(span);
				case 'g': return tryParse_L3_rg(span);
				case 'h': return tryParse_L3_rh(span);
				case 'i': return tryParse_L3_ri(span);
				case 'j': return tryParse_L3_rj(span);
				case 'k': return tryParse_L3_rk(span);
				case 'm': return tryParse_L3_rm(span);
				case 'n': return tryParse_L3_rn(span);
				case 'o': return tryParse_L3_ro(span);
				case 'p': return tryParse_L3_rp(span);
				case 'r': return tryParse_L3_rr(span);
				case 's': return tryParse_L3_rs(span);
				case 't': return tryParse_L3_rt(span);
				case 'u': return tryParse_L3_ru(span);
				case 'w': return tryParse_L3_rw(span);
				case 'x': return tryParse_L3_rx(span);
				case 'y': return tryParse_L3_ry(span);
				case 'z': return tryParse_L3_rz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ra(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RAACache.Instance;
				case 'b': return RABCache.Instance;
				case 'c': return RACCache.Instance;
				case 'd': return RADCache.Instance;
				case 'f': return RAFCache.Instance;
				case 'g': return RAGCache.Instance;
				case 'h': return RAHCache.Instance;
				case 'i': return RAICache.Instance;
				case 'j': return RAJCache.Instance;
				case 'k': return RAKCache.Instance;
				case 'l': return RALCache.Instance;
				case 'm': return RAMCache.Instance;
				case 'n': return RANCache.Instance;
				case 'o': return RAOCache.Instance;
				case 'p': return RAPCache.Instance;
				case 'q': return RAQCache.Instance;
				case 'r': return RARCache.Instance;
				case 's': return RASCache.Instance;
				case 't': return RATCache.Instance;
				case 'u': return RAUCache.Instance;
				case 'v': return RAVCache.Instance;
				case 'w': return RAWCache.Instance;
				case 'x': return RAXCache.Instance;
				case 'y': return RAYCache.Instance;
				case 'z': return RAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RBBCache.Instance;
				case 'k': return RBKCache.Instance;
				case 'l': return RBLCache.Instance;
				case 'p': return RBPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'f')
				return RCFCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_rd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'b')
				return RDBCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_re(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return REACache.Instance;
				case 'b': return REBCache.Instance;
				case 'e': return REECache.Instance;
				case 'g': return REGCache.Instance;
				case 'i': return REICache.Instance;
				case 'j': return REJCache.Instance;
				case 'l': return RELCache.Instance;
				case 'm': return REMCache.Instance;
				case 'n': return RENCache.Instance;
				case 'r': return RERCache.Instance;
				case 's': return RESCache.Instance;
				case 't': return RETCache.Instance;
				case 'y': return REYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RGACache.Instance;
				case 'e': return RGECache.Instance;
				case 'k': return RGKCache.Instance;
				case 'n': return RGNCache.Instance;
				case 'r': return RGRCache.Instance;
				case 's': return RGSCache.Instance;
				case 'u': return RGUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rh(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return RHGCache.Instance;
				case 'p': return RHPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ri(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RIACache.Instance;
				case 'b': return RIBCache.Instance;
				case 'e': return RIECache.Instance;
				case 'f': return RIFCache.Instance;
				case 'l': return RILCache.Instance;
				case 'm': return RIMCache.Instance;
				case 'n': return RINCache.Instance;
				case 'r': return RIRCache.Instance;
				case 't': return RITCache.Instance;
				case 'u': return RIUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rj(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return RJGCache.Instance;
				case 'i': return RJICache.Instance;
				case 's': return RJSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RKACache.Instance;
				case 'b': return RKBCache.Instance;
				case 'h': return RKHCache.Instance;
				case 'i': return RKICache.Instance;
				case 'm': return RKMCache.Instance;
				case 't': return RKTCache.Instance;
				case 'w': return RKWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RMACache.Instance;
				case 'b': return RMBCache.Instance;
				case 'c': return RMCCache.Instance;
				case 'd': return RMDCache.Instance;
				case 'e': return RMECache.Instance;
				case 'f': return RMFCache.Instance;
				case 'g': return RMGCache.Instance;
				case 'h': return RMHCache.Instance;
				case 'i': return RMICache.Instance;
				case 'k': return RMKCache.Instance;
				case 'l': return RMLCache.Instance;
				case 'm': return RMMCache.Instance;
				case 'n': return RMNCache.Instance;
				case 'o': return RMOCache.Instance;
				case 'p': return RMPCache.Instance;
				case 'q': return RMQCache.Instance;
				case 'r': return RMRCache.Instance;
				case 's': return RMSCache.Instance;
				case 't': return RMTCache.Instance;
				case 'u': return RMUCache.Instance;
				case 'v': return RMVCache.Instance;
				case 'w': return RMWCache.Instance;
				case 'x': return RMXCache.Instance;
				case 'y': return RMYCache.Instance;
				case 'z': return RMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RNACache.Instance;
				case 'b': return RNBCache.Instance;
				case 'd': return RNDCache.Instance;
				case 'g': return RNGCache.Instance;
				case 'l': return RNLCache.Instance;
				case 'n': return RNNCache.Instance;
				case 'p': return RNPCache.Instance;
				case 'r': return RNRCache.Instance;
				case 'w': return RNWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ro(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ROACache.Instance;
				case 'b': return ROBCache.Instance;
				case 'c': return ROCCache.Instance;
				case 'd': return RODCache.Instance;
				case 'e': return ROECache.Instance;
				case 'f': return ROFCache.Instance;
				case 'g': return ROGCache.Instance;
				case 'l': return ROLCache.Instance;
				case 'm': return ROMCache.Instance;
				case 'o': return ROOCache.Instance;
				case 'p': return ROPCache.Instance;
				case 'r': return RORCache.Instance;
				case 'u': return ROUCache.Instance;
				case 'w': return ROWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rp(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return RPNCache.Instance;
				case 't': return RPTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rr(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return RRICache.Instance;
				case 'm': return RRMCache.Instance;
				case 'o': return RROCache.Instance;
				case 't': return RRTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rs(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RSBCache.Instance;
				case 'i': return RSICache.Instance;
				case 'k': return RSKCache.Instance;
				case 'l': return RSLCache.Instance;
				case 'm': return RSMCache.Instance;
				case 'n': return RSNCache.Instance;
				case 'w': return RSWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rt(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return RTCCache.Instance;
				case 'h': return RTHCache.Instance;
				case 'm': return RTMCache.Instance;
				case 's': return RTSCache.Instance;
				case 'w': return RTWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ru(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RUBCache.Instance;
				case 'c': return RUCCache.Instance;
				case 'e': return RUECache.Instance;
				case 'f': return RUFCache.Instance;
				case 'g': return RUGCache.Instance;
				case 'h': return RUHCache.Instance;
				case 'i': return RUICache.Instance;
				case 'k': return RUKCache.Instance;
				case 'o': return RUOCache.Instance;
				case 'p': return RUPCache.Instance;
				case 'q': return RUQCache.Instance;
				case 't': return RUTCache.Instance;
				case 'u': return RUUCache.Instance;
				case 'y': return RUYCache.Instance;
				case 'z': return RUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RWACache.Instance;
				case 'k': return RWKCache.Instance;
				case 'l': return RWLCache.Instance;
				case 'm': return RWMCache.Instance;
				case 'o': return RWOCache.Instance;
				case 'r': return RWRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rx(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return RXDCache.Instance;
				case 'w': return RXWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ry(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return RYNCache.Instance;
				case 's': return RYSCache.Instance;
				case 'u': return RYUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return RZHCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_sa(span);
				case 'b': return tryParse_L3_sb(span);
				case 'c': return tryParse_L3_sc(span);
				case 'd': return tryParse_L3_sd(span);
				case 'e': return tryParse_L3_se(span);
				case 'f': return tryParse_L3_sf(span);
				case 'g': return tryParse_L3_sg(span);
				case 'h': return tryParse_L3_sh(span);
				case 'i': return tryParse_L3_si(span);
				case 'j': return tryParse_L3_sj(span);
				case 'k': return tryParse_L3_sk(span);
				case 'l': return tryParse_L3_sl(span);
				case 'm': return tryParse_L3_sm(span);
				case 'n': return tryParse_L3_sn(span);
				case 'o': return tryParse_L3_so(span);
				case 'p': return tryParse_L3_sp(span);
				case 'q': return tryParse_L3_sq(span);
				case 'r': return tryParse_L3_sr(span);
				case 's': return tryParse_L3_ss(span);
				case 't': return tryParse_L3_st(span);
				case 'u': return tryParse_L3_su(span);
				case 'v': return tryParse_L3_sv(span);
				case 'w': return tryParse_L3_sw(span);
				case 'x': return tryParse_L3_sx(span);
				case 'y': return tryParse_L3_sy(span);
				case 'z': return tryParse_L3_sz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SAACache.Instance;
				case 'b': return SABCache.Instance;
				case 'c': return SACCache.Instance;
				case 'd': return SADCache.Instance;
				case 'e': return SAECache.Instance;
				case 'f': return SAFCache.Instance;
				case 'h': return SAHCache.Instance;
				case 'i': return SAICache.Instance;
				case 'j': return SAJCache.Instance;
				case 'k': return SAKCache.Instance;
				case 'l': return SALCache.Instance;
				case 'm': return SAMCache.Instance;
				case 'o': return SAOCache.Instance;
				case 'p': return SAPCache.Instance;
				case 'q': return SAQCache.Instance;
				case 'r': return SARCache.Instance;
				case 's': return SASCache.Instance;
				case 't': return SATCache.Instance;
				case 'u': return SAUCache.Instance;
				case 'v': return SAVCache.Instance;
				case 'w': return SAWCache.Instance;
				case 'x': return SAXCache.Instance;
				case 'y': return SAYCache.Instance;
				case 'z': return SAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SBACache.Instance;
				case 'b': return SBBCache.Instance;
				case 'c': return SBCCache.Instance;
				case 'd': return SBDCache.Instance;
				case 'e': return SBECache.Instance;
				case 'f': return SBFCache.Instance;
				case 'g': return SBGCache.Instance;
				case 'h': return SBHCache.Instance;
				case 'i': return SBICache.Instance;
				case 'j': return SBJCache.Instance;
				case 'k': return SBKCache.Instance;
				case 'l': return SBLCache.Instance;
				case 'm': return SBMCache.Instance;
				case 'n': return SBNCache.Instance;
				case 'o': return SBOCache.Instance;
				case 'p': return SBPCache.Instance;
				case 'q': return SBQCache.Instance;
				case 'r': return SBRCache.Instance;
				case 's': return SBSCache.Instance;
				case 't': return SBTCache.Instance;
				case 'u': return SBUCache.Instance;
				case 'v': return SBVCache.Instance;
				case 'w': return SBWCache.Instance;
				case 'x': return SBXCache.Instance;
				case 'y': return SBYCache.Instance;
				case 'z': return SBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HLECache.Instance;
				case 'b': return SCBCache.Instance;
				case 'e': return SCECache.Instance;
				case 'f': return SCFCache.Instance;
				case 'g': return SCGCache.Instance;
				case 'h': return SCHCache.Instance;
				case 'i': return SCICache.Instance;
				case 'k': return SCKCache.Instance;
				case 'l': return SCLCache.Instance;
				case 'n': return SCNCache.Instance;
				case 'o': return SCOCache.Instance;
				case 'p': return SCPCache.Instance;
				case 'q': return SCQCache.Instance;
				case 's': return SCSCache.Instance;
				case 't': return SCTCache.Instance;
				case 'u': return SCUCache.Instance;
				case 'v': return SCVCache.Instance;
				case 'w': return SCWCache.Instance;
				case 'x': return SCXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SDACache.Instance;
				case 'b': return SDBCache.Instance;
				case 'c': return SDCCache.Instance;
				case 'e': return SDECache.Instance;
				case 'f': return SDFCache.Instance;
				case 'g': return SDGCache.Instance;
				case 'h': return SDHCache.Instance;
				case 'j': return SDJCache.Instance;
				case 'k': return SDKCache.Instance;
				case 'l': return SDLCache.Instance;
				case 'm': return SDMCache.Instance;
				case 'n': return SDNCache.Instance;
				case 'o': return SDOCache.Instance;
				case 'p': return SDPCache.Instance;
				case 'q': return SDQCache.Instance;
				case 'r': return SDRCache.Instance;
				case 's': return SDSCache.Instance;
				case 't': return SDTCache.Instance;
				case 'u': return SDUCache.Instance;
				case 'v': return SDVCache.Instance;
				case 'x': return SDXCache.Instance;
				case 'z': return SDZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_se(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SEACache.Instance;
				case 'b': return SEBCache.Instance;
				case 'c': return SECCache.Instance;
				case 'd': return SEDCache.Instance;
				case 'e': return SEECache.Instance;
				case 'f': return SEFCache.Instance;
				case 'g': return SEGCache.Instance;
				case 'h': return SEHCache.Instance;
				case 'i': return SEICache.Instance;
				case 'j': return SEJCache.Instance;
				case 'k': return SEKCache.Instance;
				case 'l': return SELCache.Instance;
				case 'm': return SEMCache.Instance;
				case 'n': return SENCache.Instance;
				case 'o': return SEOCache.Instance;
				case 'p': return SEPCache.Instance;
				case 'q': return SEQCache.Instance;
				case 'r': return SERCache.Instance;
				case 's': return SESCache.Instance;
				case 't': return SETCache.Instance;
				case 'u': return SEUCache.Instance;
				case 'v': return SEVCache.Instance;
				case 'w': return SEWCache.Instance;
				case 'y': return SEYCache.Instance;
				case 'z': return SEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sf(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SFBCache.Instance;
				case 'e': return SFECache.Instance;
				case 'm': return SFMCache.Instance;
				case 's': return SFSCache.Instance;
				case 'w': return SFWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SGACache.Instance;
				case 'b': return SGBCache.Instance;
				case 'c': return SGCCache.Instance;
				case 'd': return SGDCache.Instance;
				case 'e': return SGECache.Instance;
				case 'g': return SGGCache.Instance;
				case 'h': return SGHCache.Instance;
				case 'i': return SGICache.Instance;
				case 'j': return SGJCache.Instance;
				case 'k': return SGKCache.Instance;
				case 'l': return SGLCache.Instance;
				case 'm': return SGMCache.Instance;
				case 'n': return SGNCache.Instance;
				case 'o': return SGOCache.Instance;
				case 'p': return SGPCache.Instance;
				case 'r': return SGRCache.Instance;
				case 's': return SGSCache.Instance;
				case 't': return SGTCache.Instance;
				case 'u': return SGUCache.Instance;
				case 'w': return SGWCache.Instance;
				case 'x': return SGXCache.Instance;
				case 'y': return SGYCache.Instance;
				case 'z': return SGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SHACache.Instance;
				case 'b': return SHBCache.Instance;
				case 'c': return SHCCache.Instance;
				case 'd': return SHDCache.Instance;
				case 'e': return SHECache.Instance;
				case 'g': return SHGCache.Instance;
				case 'h': return SHHCache.Instance;
				case 'i': return SHICache.Instance;
				case 'j': return SHJCache.Instance;
				case 'k': return SHKCache.Instance;
				case 'l': return SHLCache.Instance;
				case 'm': return SHMCache.Instance;
				case 'n': return SHNCache.Instance;
				case 'o': return SHOCache.Instance;
				case 'p': return SHPCache.Instance;
				case 'q': return SHQCache.Instance;
				case 'r': return SHRCache.Instance;
				case 's': return SHSCache.Instance;
				case 't': return SHTCache.Instance;
				case 'u': return SHUCache.Instance;
				case 'v': return SHVCache.Instance;
				case 'w': return SHWCache.Instance;
				case 'x': return SHXCache.Instance;
				case 'y': return SHYCache.Instance;
				case 'z': return SHZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_si(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SIACache.Instance;
				case 'b': return SIBCache.Instance;
				case 'd': return SIDCache.Instance;
				case 'e': return SIECache.Instance;
				case 'f': return SIFCache.Instance;
				case 'g': return SIGCache.Instance;
				case 'h': return SIHCache.Instance;
				case 'i': return SIICache.Instance;
				case 'j': return SIJCache.Instance;
				case 'k': return SIKCache.Instance;
				case 'l': return SILCache.Instance;
				case 'm': return SIMCache.Instance;
				case 'o': return SIOCache.Instance;
				case 'p': return SIPCache.Instance;
				case 'q': return SIQCache.Instance;
				case 'r': return SIRCache.Instance;
				case 's': return SISCache.Instance;
				case 't': return SITCache.Instance;
				case 'u': return SIUCache.Instance;
				case 'v': return SIVCache.Instance;
				case 'w': return SIWCache.Instance;
				case 'x': return SIXCache.Instance;
				case 'y': return SIYCache.Instance;
				case 'z': return SIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SJACache.Instance;
				case 'b': return SJBCache.Instance;
				case 'c': return SJCCache.Instance;
				case 'd': return SJDCache.Instance;
				case 'e': return SJECache.Instance;
				case 'g': return SJGCache.Instance;
				case 'k': return SJKCache.Instance;
				case 'l': return SJLCache.Instance;
				case 'm': return SJMCache.Instance;
				case 'n': return SJNCache.Instance;
				case 'o': return SJOCache.Instance;
				case 'p': return SJPCache.Instance;
				case 'r': return SJRCache.Instance;
				case 's': return SJSCache.Instance;
				case 't': return SJTCache.Instance;
				case 'u': return SJUCache.Instance;
				case 'w': return SJWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SKACache.Instance;
				case 'b': return SKBCache.Instance;
				case 'c': return SKCCache.Instance;
				case 'd': return SKDCache.Instance;
				case 'e': return SKECache.Instance;
				case 'f': return SKFCache.Instance;
				case 'g': return SKGCache.Instance;
				case 'h': return SKHCache.Instance;
				case 'i': return SKICache.Instance;
				case 'j': return SKJCache.Instance;
				case 'k': return OYBCache.Instance;
				case 'm': return SKMCache.Instance;
				case 'n': return SKNCache.Instance;
				case 'o': return SKOCache.Instance;
				case 'p': return SKPCache.Instance;
				case 'q': return SKQCache.Instance;
				case 'r': return SKRCache.Instance;
				case 's': return SKSCache.Instance;
				case 't': return SKTCache.Instance;
				case 'u': return SKUCache.Instance;
				case 'v': return SKVCache.Instance;
				case 'w': return SKWCache.Instance;
				case 'x': return SKXCache.Instance;
				case 'y': return SKYCache.Instance;
				case 'z': return SKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SLACache.Instance;
				case 'c': return SLCCache.Instance;
				case 'd': return SLDCache.Instance;
				case 'e': return SLECache.Instance;
				case 'f': return SLFCache.Instance;
				case 'g': return SLGCache.Instance;
				case 'h': return SLHCache.Instance;
				case 'i': return SLICache.Instance;
				case 'j': return SLJCache.Instance;
				case 'l': return SLLCache.Instance;
				case 'm': return SLMCache.Instance;
				case 'n': return SLNCache.Instance;
				case 'p': return SLPCache.Instance;
				case 'q': return SLQCache.Instance;
				case 'r': return SLRCache.Instance;
				case 's': return SLSCache.Instance;
				case 't': return SLTCache.Instance;
				case 'u': return SLUCache.Instance;
				case 'w': return SLWCache.Instance;
				case 'x': return SLXCache.Instance;
				case 'y': return SLYCache.Instance;
				case 'z': return SLZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SMACache.Instance;
				case 'b': return SMBCache.Instance;
				case 'c': return SMCCache.Instance;
				case 'd': return KMBCache.Instance;
				case 'f': return SMFCache.Instance;
				case 'g': return SMGCache.Instance;
				case 'h': return SMHCache.Instance;
				case 'i': return SMICache.Instance;
				case 'j': return SMJCache.Instance;
				case 'k': return SMKCache.Instance;
				case 'l': return SMLCache.Instance;
				case 'm': return SMMCache.Instance;
				case 'n': return SMNCache.Instance;
				case 'p': return SMPCache.Instance;
				case 'q': return SMQCache.Instance;
				case 'r': return SMRCache.Instance;
				case 's': return SMSCache.Instance;
				case 't': return SMTCache.Instance;
				case 'u': return SMUCache.Instance;
				case 'v': return SMVCache.Instance;
				case 'w': return SMWCache.Instance;
				case 'x': return SMXCache.Instance;
				case 'y': return SMYCache.Instance;
				case 'z': return SMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IBACache.Instance;
				case 'c': return SNCCache.Instance;
				case 'e': return SNECache.Instance;
				case 'f': return SNFCache.Instance;
				case 'g': return SNGCache.Instance;
				case 'h': return SNHCache.Instance;
				case 'i': return SNICache.Instance;
				case 'j': return SNJCache.Instance;
				case 'k': return SNKCache.Instance;
				case 'l': return SNLCache.Instance;
				case 'm': return SNMCache.Instance;
				case 'n': return SNNCache.Instance;
				case 'o': return SNOCache.Instance;
				case 'p': return SNPCache.Instance;
				case 'q': return SNQCache.Instance;
				case 'r': return SNRCache.Instance;
				case 's': return SNSCache.Instance;
				case 'u': return SNUCache.Instance;
				case 'v': return SNVCache.Instance;
				case 'w': return SNWCache.Instance;
				case 'x': return SNXCache.Instance;
				case 'y': return SNYCache.Instance;
				case 'z': return SNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_so(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SOACache.Instance;
				case 'b': return SOBCache.Instance;
				case 'c': return SOCCache.Instance;
				case 'd': return SODCache.Instance;
				case 'e': return SOECache.Instance;
				case 'g': return SOGCache.Instance;
				case 'h': return SOHCache.Instance;
				case 'i': return SOICache.Instance;
				case 'j': return SOJCache.Instance;
				case 'k': return SOKCache.Instance;
				case 'l': return SOLCache.Instance;
				case 'n': return SONCache.Instance;
				case 'o': return SOOCache.Instance;
				case 'p': return SOPCache.Instance;
				case 'q': return SOQCache.Instance;
				case 'r': return SORCache.Instance;
				case 's': return SOSCache.Instance;
				case 'u': return SOUCache.Instance;
				case 'v': return SOVCache.Instance;
				case 'w': return SOWCache.Instance;
				case 'x': return SOXCache.Instance;
				case 'y': return SOYCache.Instance;
				case 'z': return SOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sp(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SPBCache.Instance;
				case 'c': return SPCCache.Instance;
				case 'd': return SPDCache.Instance;
				case 'e': return SPECache.Instance;
				case 'g': return SPGCache.Instance;
				case 'i': return SPICache.Instance;
				case 'k': return SPKCache.Instance;
				case 'l': return SPLCache.Instance;
				case 'm': return SPMCache.Instance;
				case 'n': return SPNCache.Instance;
				case 'o': return SPOCache.Instance;
				case 'p': return SPPCache.Instance;
				case 'q': return SPQCache.Instance;
				case 'r': return SPRCache.Instance;
				case 's': return SPSCache.Instance;
				case 't': return SPTCache.Instance;
				case 'u': return SPUCache.Instance;
				case 'v': return SPVCache.Instance;
				case 'x': return SPXCache.Instance;
				case 'y': return SPYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SQACache.Instance;
				case 'h': return SQHCache.Instance;
				case 'j': return SQJCache.Instance;
				case 'k': return SQKCache.Instance;
				case 'm': return SQMCache.Instance;
				case 'n': return SQNCache.Instance;
				case 'o': return SQOCache.Instance;
				case 'q': return SQQCache.Instance;
				case 'r': return SQRCache.Instance;
				case 's': return SQSCache.Instance;
				case 't': return SQTCache.Instance;
				case 'u': return SQUCache.Instance;
				case 'x': return SQXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SRACache.Instance;
				case 'b': return SRBCache.Instance;
				case 'c': return SRCCache.Instance;
				case 'e': return SRECache.Instance;
				case 'f': return SRFCache.Instance;
				case 'g': return SRGCache.Instance;
				case 'h': return SRHCache.Instance;
				case 'i': return SRICache.Instance;
				case 'k': return SRKCache.Instance;
				case 'l': return SRLCache.Instance;
				case 'm': return SRMCache.Instance;
				case 'n': return SRNCache.Instance;
				case 'o': return SROCache.Instance;
				case 'q': return SRQCache.Instance;
				case 'r': return SRRCache.Instance;
				case 's': return SRSCache.Instance;
				case 't': return SRTCache.Instance;
				case 'u': return SRUCache.Instance;
				case 'v': return SRVCache.Instance;
				case 'w': return SRWCache.Instance;
				case 'x': return SRXCache.Instance;
				case 'y': return SRYCache.Instance;
				case 'z': return SRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ss(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SSACache.Instance;
				case 'b': return SSBCache.Instance;
				case 'c': return SSCCache.Instance;
				case 'd': return SSDCache.Instance;
				case 'e': return SSECache.Instance;
				case 'f': return SSFCache.Instance;
				case 'g': return SSGCache.Instance;
				case 'h': return SSHCache.Instance;
				case 'i': return SSICache.Instance;
				case 'j': return SSJCache.Instance;
				case 'k': return SSKCache.Instance;
				case 'l': return SSLCache.Instance;
				case 'm': return SSMCache.Instance;
				case 'n': return SSNCache.Instance;
				case 'o': return SSOCache.Instance;
				case 'p': return SSPCache.Instance;
				case 'q': return SSQCache.Instance;
				case 'r': return SSRCache.Instance;
				case 's': return SSSCache.Instance;
				case 't': return SSTCache.Instance;
				case 'u': return SSUCache.Instance;
				case 'v': return SSVCache.Instance;
				case 'x': return SSXCache.Instance;
				case 'y': return SSYCache.Instance;
				case 'z': return SSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_st(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return STACache.Instance;
				case 'b': return STBCache.Instance;
				case 'd': return STDCache.Instance;
				case 'e': return STECache.Instance;
				case 'f': return STFCache.Instance;
				case 'g': return STGCache.Instance;
				case 'h': return STHCache.Instance;
				case 'i': return STICache.Instance;
				case 'j': return STJCache.Instance;
				case 'k': return STKCache.Instance;
				case 'l': return STLCache.Instance;
				case 'm': return STMCache.Instance;
				case 'n': return STNCache.Instance;
				case 'o': return STOCache.Instance;
				case 'p': return STPCache.Instance;
				case 'q': return STQCache.Instance;
				case 'r': return STRCache.Instance;
				case 's': return STSCache.Instance;
				case 't': return STTCache.Instance;
				case 'u': return STUCache.Instance;
				case 'v': return STVCache.Instance;
				case 'w': return STWCache.Instance;
				case 'y': return STYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_su(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SUACache.Instance;
				case 'b': return SUBCache.Instance;
				case 'c': return SUCCache.Instance;
				case 'e': return SUECache.Instance;
				case 'g': return SUGCache.Instance;
				case 'i': return SUICache.Instance;
				case 'j': return SUJCache.Instance;
				case 'k': return SUKCache.Instance;
				case 'l': return SULCache.Instance;
				case 'm': return SUMCache.Instance;
				case 'o': return SUOCache.Instance;
				case 'q': return SUQCache.Instance;
				case 'r': return SURCache.Instance;
				case 's': return SUSCache.Instance;
				case 't': return SUTCache.Instance;
				case 'v': return SUVCache.Instance;
				case 'w': return SUWCache.Instance;
				case 'x': return SUXCache.Instance;
				case 'y': return SUYCache.Instance;
				case 'z': return SUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SVACache.Instance;
				case 'b': return SVBCache.Instance;
				case 'c': return SVCCache.Instance;
				case 'e': return SVECache.Instance;
				case 'k': return SVKCache.Instance;
				case 'm': return SVMCache.Instance;
				case 'r': return SVRCache.Instance;
				case 's': return SVSCache.Instance;
				case 'x': return SVXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sw(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SWBCache.Instance;
				case 'c': return SWCCache.Instance;
				case 'f': return SWFCache.Instance;
				case 'g': return SWGCache.Instance;
				case 'h': return SWHCache.Instance;
				case 'i': return SWICache.Instance;
				case 'j': return SWJCache.Instance;
				case 'k': return SWKCache.Instance;
				case 'l': return SWLCache.Instance;
				case 'm': return SWMCache.Instance;
				case 'n': return SWNCache.Instance;
				case 'o': return SWOCache.Instance;
				case 'p': return SWPCache.Instance;
				case 'q': return SWQCache.Instance;
				case 'r': return SWRCache.Instance;
				case 's': return SWSCache.Instance;
				case 't': return SWTCache.Instance;
				case 'u': return SWUCache.Instance;
				case 'v': return SWVCache.Instance;
				case 'w': return SWWCache.Instance;
				case 'x': return SWXCache.Instance;
				case 'y': return SWYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sx(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SXBCache.Instance;
				case 'c': return SXCCache.Instance;
				case 'e': return SXECache.Instance;
				case 'g': return SXGCache.Instance;
				case 'k': return SXKCache.Instance;
				case 'l': return SXLCache.Instance;
				case 'm': return SXMCache.Instance;
				case 'n': return SXNCache.Instance;
				case 'o': return SXOCache.Instance;
				case 'r': return SXRCache.Instance;
				case 's': return SXSCache.Instance;
				case 'u': return SXUCache.Instance;
				case 'w': return SXWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SYACache.Instance;
				case 'b': return SYBCache.Instance;
				case 'c': return SYCCache.Instance;
				case 'd': return SYDCache.Instance;
				case 'i': return SYICache.Instance;
				case 'k': return SYKCache.Instance;
				case 'l': return SYLCache.Instance;
				case 'm': return SYMCache.Instance;
				case 'n': return SYNCache.Instance;
				case 'o': return SYOCache.Instance;
				case 'r': return SYRCache.Instance;
				case 's': return SYSCache.Instance;
				case 'w': return SYWCache.Instance;
				case 'x': return SYXCache.Instance;
				case 'y': return SYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SZACache.Instance;
				case 'b': return SZBCache.Instance;
				case 'c': return SZCCache.Instance;
				case 'd': return UMICache.Instance;
				case 'e': return SZECache.Instance;
				case 'g': return SZGCache.Instance;
				case 'l': return SZLCache.Instance;
				case 'n': return SZNCache.Instance;
				case 'p': return SZPCache.Instance;
				case 's': return SZSCache.Instance;
				case 'v': return SZVCache.Instance;
				case 'w': return SZWCache.Instance;
				case 'y': return SZYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ta(span);
				case 'b': return tryParse_L3_tb(span);
				case 'c': return tryParse_L3_tc(span);
				case 'd': return tryParse_L3_td(span);
				case 'e': return tryParse_L3_te(span);
				case 'f': return tryParse_L3_tf(span);
				case 'g': return tryParse_L3_tg(span);
				case 'h': return tryParse_L3_th(span);
				case 'i': return tryParse_L3_ti(span);
				case 'j': return tryParse_L3_tj(span);
				case 'k': return tryParse_L3_tk(span);
				case 'l': return tryParse_L3_tl(span);
				case 'm': return tryParse_L3_tm(span);
				case 'n': return tryParse_L3_tn(span);
				case 'o': return tryParse_L3_to(span);
				case 'p': return tryParse_L3_tp(span);
				case 'q': return tryParse_L3_tq(span);
				case 'r': return tryParse_L3_tr(span);
				case 's': return tryParse_L3_ts(span);
				case 't': return tryParse_L3_tt(span);
				case 'u': return tryParse_L3_tu(span);
				case 'v': return tryParse_L3_tv(span);
				case 'w': return tryParse_L3_tw(span);
				case 'x': return tryParse_L3_tx(span);
				case 'y': return tryParse_L3_ty(span);
				case 'z': return tryParse_L3_tz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ta(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TAACache.Instance;
				case 'b': return TABCache.Instance;
				case 'c': return TACCache.Instance;
				case 'd': return TADCache.Instance;
				case 'e': return TAECache.Instance;
				case 'f': return TAFCache.Instance;
				case 'g': return TAGCache.Instance;
				case 'i': return TAICache.Instance;
				case 'j': return TAJCache.Instance;
				case 'k': return TAKCache.Instance;
				case 'l': return TALCache.Instance;
				case 'n': return TANCache.Instance;
				case 'o': return TAOCache.Instance;
				case 'p': return TAPCache.Instance;
				case 'q': return TAQCache.Instance;
				case 'r': return TARCache.Instance;
				case 's': return TASCache.Instance;
				case 'u': return TAUCache.Instance;
				case 'v': return TAVCache.Instance;
				case 'w': return TAWCache.Instance;
				case 'x': return TAXCache.Instance;
				case 'y': return TAYCache.Instance;
				case 'z': return TAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TBACache.Instance;
				case 'b': return TBBCache.Instance;
				case 'c': return TBCCache.Instance;
				case 'd': return TBDCache.Instance;
				case 'e': return TBECache.Instance;
				case 'f': return TBFCache.Instance;
				case 'g': return TBGCache.Instance;
				case 'h': return TBHCache.Instance;
				case 'i': return TBICache.Instance;
				case 'j': return TBJCache.Instance;
				case 'k': return TBKCache.Instance;
				case 'l': return TBLCache.Instance;
				case 'm': return TBMCache.Instance;
				case 'n': return TBNCache.Instance;
				case 'o': return TBOCache.Instance;
				case 'p': return TBPCache.Instance;
				case 'q': return TBQCache.Instance;
				case 'r': return TBRCache.Instance;
				case 's': return TBSCache.Instance;
				case 't': return TBTCache.Instance;
				case 'u': return TBUCache.Instance;
				case 'v': return TBVCache.Instance;
				case 'w': return TBWCache.Instance;
				case 'x': return TBXCache.Instance;
				case 'y': return TBYCache.Instance;
				case 'z': return TBZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TCACache.Instance;
				case 'b': return TCBCache.Instance;
				case 'c': return TCCCache.Instance;
				case 'd': return TCDCache.Instance;
				case 'e': return TCECache.Instance;
				case 'f': return TCFCache.Instance;
				case 'g': return TCGCache.Instance;
				case 'h': return TCHCache.Instance;
				case 'i': return TCICache.Instance;
				case 'k': return TCKCache.Instance;
				case 'l': return TCLCache.Instance;
				case 'm': return TCMCache.Instance;
				case 'n': return TCNCache.Instance;
				case 'o': return TCOCache.Instance;
				case 'p': return TCPCache.Instance;
				case 'q': return TCQCache.Instance;
				case 's': return TCSCache.Instance;
				case 't': return TCTCache.Instance;
				case 'u': return TCUCache.Instance;
				case 'w': return TCWCache.Instance;
				case 'x': return TCXCache.Instance;
				case 'y': return TCYCache.Instance;
				case 'z': return TCZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_td(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TDACache.Instance;
				case 'b': return TDBCache.Instance;
				case 'c': return TDCCache.Instance;
				case 'd': return TDDCache.Instance;
				case 'e': return TDECache.Instance;
				case 'f': return TDFCache.Instance;
				case 'g': return TDGCache.Instance;
				case 'h': return TDHCache.Instance;
				case 'i': return TDICache.Instance;
				case 'j': return TDJCache.Instance;
				case 'k': return TDKCache.Instance;
				case 'l': return TDLCache.Instance;
				case 'm': return TDMCache.Instance;
				case 'n': return TDNCache.Instance;
				case 'o': return TDOCache.Instance;
				case 'q': return TDQCache.Instance;
				case 'r': return TDRCache.Instance;
				case 's': return TDSCache.Instance;
				case 't': return TDTCache.Instance;
				case 'u': return DTPCache.Instance;
				case 'v': return TDVCache.Instance;
				case 'x': return TDXCache.Instance;
				case 'y': return TDYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_te(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TEACache.Instance;
				case 'b': return TEBCache.Instance;
				case 'c': return TECCache.Instance;
				case 'd': return TEDCache.Instance;
				case 'e': return TEECache.Instance;
				case 'f': return TEFCache.Instance;
				case 'g': return TEGCache.Instance;
				case 'h': return TEHCache.Instance;
				case 'i': return TEICache.Instance;
				case 'k': return TEKCache.Instance;
				case 'm': return TEMCache.Instance;
				case 'n': return TENCache.Instance;
				case 'o': return TEOCache.Instance;
				case 'p': return TEPCache.Instance;
				case 'q': return TEQCache.Instance;
				case 'r': return TERCache.Instance;
				case 's': return TESCache.Instance;
				case 't': return TETCache.Instance;
				case 'u': return TEUCache.Instance;
				case 'v': return TEVCache.Instance;
				case 'w': return TEWCache.Instance;
				case 'x': return TEXCache.Instance;
				case 'y': return TEYCache.Instance;
				case 'z': return TEZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tf(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return TFICache.Instance;
				case 'n': return TFNCache.Instance;
				case 'o': return TFOCache.Instance;
				case 'r': return TFRCache.Instance;
				case 't': return TFTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TGACache.Instance;
				case 'b': return TGBCache.Instance;
				case 'c': return TGCCache.Instance;
				case 'd': return TGDCache.Instance;
				case 'e': return TGECache.Instance;
				case 'f': return TGFCache.Instance;
				case 'g': return TGGCache.Instance;
				case 'h': return TGHCache.Instance;
				case 'i': return TGICache.Instance;
				case 'j': return TGJCache.Instance;
				case 'n': return TGNCache.Instance;
				case 'o': return TGOCache.Instance;
				case 'p': return TGPCache.Instance;
				case 'q': return TGQCache.Instance;
				case 'r': return TGRCache.Instance;
				case 's': return TGSCache.Instance;
				case 't': return TGTCache.Instance;
				case 'u': return TGUCache.Instance;
				case 'v': return TGVCache.Instance;
				case 'w': return TGWCache.Instance;
				case 'x': return TGXCache.Instance;
				case 'y': return TGYCache.Instance;
				case 'z': return TGZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_th(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return TPOCache.Instance;
				case 'd': return THDCache.Instance;
				case 'e': return THECache.Instance;
				case 'f': return THFCache.Instance;
				case 'h': return THHCache.Instance;
				case 'i': return THICache.Instance;
				case 'k': return THKCache.Instance;
				case 'l': return THLCache.Instance;
				case 'm': return THMCache.Instance;
				case 'n': return THNCache.Instance;
				case 'p': return THPCache.Instance;
				case 'q': return THQCache.Instance;
				case 'r': return THRCache.Instance;
				case 's': return THSCache.Instance;
				case 't': return THTCache.Instance;
				case 'u': return THUCache.Instance;
				case 'v': return THVCache.Instance;
				case 'w': return OLACache.Instance;
				case 'x': return OYBCache.Instance;
				case 'y': return THYCache.Instance;
				case 'z': return THZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ti(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TIACache.Instance;
				case 'c': return TICCache.Instance;
				case 'd': return TIDCache.Instance;
				case 'e': return RASCache.Instance;
				case 'f': return TIFCache.Instance;
				case 'g': return TIGCache.Instance;
				case 'h': return TIHCache.Instance;
				case 'i': return TIICache.Instance;
				case 'j': return TIJCache.Instance;
				case 'k': return TIKCache.Instance;
				case 'l': return TILCache.Instance;
				case 'm': return TIMCache.Instance;
				case 'n': return TINCache.Instance;
				case 'o': return TIOCache.Instance;
				case 'p': return TIPCache.Instance;
				case 'q': return TIQCache.Instance;
				case 's': return TISCache.Instance;
				case 't': return TITCache.Instance;
				case 'u': return TIUCache.Instance;
				case 'v': return TIVCache.Instance;
				case 'w': return TIWCache.Instance;
				case 'x': return TIXCache.Instance;
				case 'y': return TIYCache.Instance;
				case 'z': return TIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TJACache.Instance;
				case 'g': return TJGCache.Instance;
				case 'i': return TJICache.Instance;
				case 'j': return TJJCache.Instance;
				case 'l': return TJLCache.Instance;
				case 'm': return TJMCache.Instance;
				case 'n': return TJNCache.Instance;
				case 'o': return TJOCache.Instance;
				case 'p': return TJPCache.Instance;
				case 's': return TJSCache.Instance;
				case 'u': return TJUCache.Instance;
				case 'w': return TJWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TKACache.Instance;
				case 'b': return TKBCache.Instance;
				case 'd': return TKDCache.Instance;
				case 'e': return TKECache.Instance;
				case 'f': return TKFCache.Instance;
				case 'g': return TKGCache.Instance;
				case 'k': return TWMCache.Instance;
				case 'l': return TKLCache.Instance;
				case 'm': return TKMCache.Instance;
				case 'n': return TKNCache.Instance;
				case 'p': return TKPCache.Instance;
				case 'q': return TKQCache.Instance;
				case 'r': return TKRCache.Instance;
				case 's': return TKSCache.Instance;
				case 't': return TKTCache.Instance;
				case 'u': return TKUCache.Instance;
				case 'v': return TKVCache.Instance;
				case 'w': return TKWCache.Instance;
				case 'x': return TKXCache.Instance;
				case 'z': return TKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TLACache.Instance;
				case 'b': return TLBCache.Instance;
				case 'c': return TLCCache.Instance;
				case 'd': return TLDCache.Instance;
				case 'f': return TLFCache.Instance;
				case 'g': return TLGCache.Instance;
				case 'h': return TLHCache.Instance;
				case 'i': return TLICache.Instance;
				case 'j': return TLJCache.Instance;
				case 'k': return TLKCache.Instance;
				case 'l': return TLLCache.Instance;
				case 'm': return TLMCache.Instance;
				case 'n': return TLNCache.Instance;
				case 'o': return TLOCache.Instance;
				case 'p': return TLPCache.Instance;
				case 'q': return TLQCache.Instance;
				case 'r': return TLRCache.Instance;
				case 's': return TLSCache.Instance;
				case 't': return TLTCache.Instance;
				case 'u': return TLUCache.Instance;
				case 'v': return TLVCache.Instance;
				case 'w': return WEOCache.Instance;
				case 'x': return TLXCache.Instance;
				case 'y': return TLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TMACache.Instance;
				case 'b': return TMBCache.Instance;
				case 'c': return TMCCache.Instance;
				case 'd': return TMDCache.Instance;
				case 'e': return TMECache.Instance;
				case 'f': return TMFCache.Instance;
				case 'g': return TMGCache.Instance;
				case 'h': return TMHCache.Instance;
				case 'i': return TMICache.Instance;
				case 'j': return TMJCache.Instance;
				case 'k': return TDGCache.Instance;
				case 'l': return TMLCache.Instance;
				case 'm': return TMMCache.Instance;
				case 'n': return TMNCache.Instance;
				case 'o': return TMOCache.Instance;
				case 'p': return TYJCache.Instance;
				case 'q': return TMQCache.Instance;
				case 'r': return TMRCache.Instance;
				case 's': return TMSCache.Instance;
				case 't': return TMTCache.Instance;
				case 'u': return TMUCache.Instance;
				case 'v': return TMVCache.Instance;
				case 'w': return TMWCache.Instance;
				case 'y': return TMYCache.Instance;
				case 'z': return TMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TNACache.Instance;
				case 'b': return TNBCache.Instance;
				case 'c': return TNCCache.Instance;
				case 'd': return TNDCache.Instance;
				case 'e': return KAKCache.Instance;
				case 'f': return PRSCache.Instance;
				case 'g': return TNGCache.Instance;
				case 'h': return TNHCache.Instance;
				case 'i': return TNICache.Instance;
				case 'k': return TNKCache.Instance;
				case 'l': return TNLCache.Instance;
				case 'm': return TNMCache.Instance;
				case 'n': return TNNCache.Instance;
				case 'o': return TNOCache.Instance;
				case 'p': return TNPCache.Instance;
				case 'q': return TNQCache.Instance;
				case 'r': return TNRCache.Instance;
				case 's': return TNSCache.Instance;
				case 't': return TNTCache.Instance;
				case 'u': return TNUCache.Instance;
				case 'v': return TNVCache.Instance;
				case 'w': return TNWCache.Instance;
				case 'x': return TNXCache.Instance;
				case 'y': return TNYCache.Instance;
				case 'z': return TNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_to(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return TOBCache.Instance;
				case 'c': return TOCCache.Instance;
				case 'd': return TODCache.Instance;
				case 'e': return TOECache.Instance;
				case 'f': return TOFCache.Instance;
				case 'g': return TOGCache.Instance;
				case 'h': return TOHCache.Instance;
				case 'i': return TOICache.Instance;
				case 'j': return TOJCache.Instance;
				case 'k': return TOKCache.Instance;
				case 'l': return TOLCache.Instance;
				case 'm': return TOMCache.Instance;
				case 'o': return TOOCache.Instance;
				case 'p': return TOPCache.Instance;
				case 'q': return TOQCache.Instance;
				case 'r': return TORCache.Instance;
				case 's': return TOSCache.Instance;
				case 'u': return TOUCache.Instance;
				case 'v': return TOVCache.Instance;
				case 'w': return TOWCache.Instance;
				case 'x': return TOXCache.Instance;
				case 'y': return TOYCache.Instance;
				case 'z': return TOZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TPACache.Instance;
				case 'c': return TPCCache.Instance;
				case 'e': return TPECache.Instance;
				case 'f': return TPFCache.Instance;
				case 'g': return TPGCache.Instance;
				case 'i': return TPICache.Instance;
				case 'j': return TPJCache.Instance;
				case 'k': return TPKCache.Instance;
				case 'l': return TPLCache.Instance;
				case 'm': return TPMCache.Instance;
				case 'n': return TPNCache.Instance;
				case 'o': return TPOCache.Instance;
				case 'p': return TPPCache.Instance;
				case 'q': return TPQCache.Instance;
				case 'r': return TPRCache.Instance;
				case 't': return TPTCache.Instance;
				case 'u': return TPUCache.Instance;
				case 'v': return TPVCache.Instance;
				case 'w': return TPNCache.Instance;
				case 'x': return TPXCache.Instance;
				case 'y': return TPYCache.Instance;
				case 'z': return TPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tq(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return TQBCache.Instance;
				case 'l': return TQLCache.Instance;
				case 'm': return TQMCache.Instance;
				case 'n': return TQNCache.Instance;
				case 'o': return TQOCache.Instance;
				case 'p': return TQPCache.Instance;
				case 'q': return TQQCache.Instance;
				case 'r': return TQRCache.Instance;
				case 't': return TQTCache.Instance;
				case 'u': return TQUCache.Instance;
				case 'w': return TQWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TRACache.Instance;
				case 'b': return TRBCache.Instance;
				case 'c': return TRCCache.Instance;
				case 'd': return TRDCache.Instance;
				case 'e': return TRECache.Instance;
				case 'f': return TRFCache.Instance;
				case 'g': return TRGCache.Instance;
				case 'h': return TRHCache.Instance;
				case 'i': return TRICache.Instance;
				case 'j': return TRJCache.Instance;
				case 'k': return TRKCache.Instance;
				case 'l': return TRLCache.Instance;
				case 'm': return TRMCache.Instance;
				case 'n': return TRNCache.Instance;
				case 'o': return TROCache.Instance;
				case 'p': return TRPCache.Instance;
				case 'q': return TRQCache.Instance;
				case 'r': return TRRCache.Instance;
				case 's': return TRSCache.Instance;
				case 't': return TRTCache.Instance;
				case 'u': return TRUCache.Instance;
				case 'v': return TRVCache.Instance;
				case 'w': return TRWCache.Instance;
				case 'x': return TRXCache.Instance;
				case 'y': return TRYCache.Instance;
				case 'z': return TRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ts(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TSACache.Instance;
				case 'b': return TSBCache.Instance;
				case 'c': return TSCCache.Instance;
				case 'd': return TSDCache.Instance;
				case 'e': return TSECache.Instance;
				case 'f': return TAJCache.Instance;
				case 'g': return TSGCache.Instance;
				case 'h': return TSHCache.Instance;
				case 'i': return TSICache.Instance;
				case 'j': return TSJCache.Instance;
				case 'k': return TSKCache.Instance;
				case 'l': return TSLCache.Instance;
				case 'm': return TSMCache.Instance;
				case 'p': return TSPCache.Instance;
				case 'q': return TSQCache.Instance;
				case 'r': return TSRCache.Instance;
				case 's': return TSSCache.Instance;
				case 't': return TSTCache.Instance;
				case 'u': return TSUCache.Instance;
				case 'v': return TSVCache.Instance;
				case 'w': return TSWCache.Instance;
				case 'x': return TSXCache.Instance;
				case 'y': return TSYCache.Instance;
				case 'z': return TSZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TTACache.Instance;
				case 'b': return TTBCache.Instance;
				case 'c': return TTCCache.Instance;
				case 'd': return TTDCache.Instance;
				case 'e': return TTECache.Instance;
				case 'f': return TTFCache.Instance;
				case 'g': return TTGCache.Instance;
				case 'h': return TTHCache.Instance;
				case 'i': return TTICache.Instance;
				case 'j': return TTJCache.Instance;
				case 'k': return TTKCache.Instance;
				case 'l': return TTLCache.Instance;
				case 'm': return TTMCache.Instance;
				case 'n': return TTNCache.Instance;
				case 'o': return TTOCache.Instance;
				case 'p': return TTPCache.Instance;
				case 'q': return TTQCache.Instance;
				case 'r': return TTRCache.Instance;
				case 's': return TTSCache.Instance;
				case 't': return TTTCache.Instance;
				case 'u': return TTUCache.Instance;
				case 'v': return TTVCache.Instance;
				case 'w': return TTWCache.Instance;
				case 'y': return TTYCache.Instance;
				case 'z': return TTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TUACache.Instance;
				case 'b': return TUBCache.Instance;
				case 'c': return TUCCache.Instance;
				case 'd': return TUDCache.Instance;
				case 'e': return TUECache.Instance;
				case 'f': return TUFCache.Instance;
				case 'g': return TUGCache.Instance;
				case 'h': return TUHCache.Instance;
				case 'i': return TUICache.Instance;
				case 'j': return TUJCache.Instance;
				case 'l': return TULCache.Instance;
				case 'm': return TUMCache.Instance;
				case 'n': return TUNCache.Instance;
				case 'o': return TUOCache.Instance;
				case 'p': return TUPCache.Instance;
				case 'q': return TUQCache.Instance;
				case 's': return TUSCache.Instance;
				case 't': return TUTCache.Instance;
				case 'u': return TUUCache.Instance;
				case 'v': return TUVCache.Instance;
				case 'w': return TUWCache.Instance;
				case 'x': return TUXCache.Instance;
				case 'y': return TUYCache.Instance;
				case 'z': return TUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TVACache.Instance;
				case 'd': return TVDCache.Instance;
				case 'e': return TVECache.Instance;
				case 'i': return TVICache.Instance;
				case 'k': return TVKCache.Instance;
				case 'l': return TVLCache.Instance;
				case 'm': return TVMCache.Instance;
				case 'n': return TVNCache.Instance;
				case 'o': return TVOCache.Instance;
				case 's': return TVSCache.Instance;
				case 't': return TVTCache.Instance;
				case 'u': return TVUCache.Instance;
				case 'w': return TVWCache.Instance;
				case 'x': return TVXCache.Instance;
				case 'y': return TVYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TWACache.Instance;
				case 'b': return TWBCache.Instance;
				case 'c': return TWCCache.Instance;
				case 'd': return TWDCache.Instance;
				case 'e': return TWECache.Instance;
				case 'f': return TWFCache.Instance;
				case 'g': return TWGCache.Instance;
				case 'h': return TWHCache.Instance;
				case 'l': return TWLCache.Instance;
				case 'm': return TWMCache.Instance;
				case 'n': return TWNCache.Instance;
				case 'o': return TWOCache.Instance;
				case 'p': return TWPCache.Instance;
				case 'q': return TWQCache.Instance;
				case 'r': return TWRCache.Instance;
				case 't': return TWTCache.Instance;
				case 'u': return TWUCache.Instance;
				case 'w': return TWWCache.Instance;
				case 'x': return TWXCache.Instance;
				case 'y': return TWYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TXACache.Instance;
				case 'b': return TXBCache.Instance;
				case 'c': return TXCCache.Instance;
				case 'e': return TXECache.Instance;
				case 'g': return TXGCache.Instance;
				case 'h': return TXHCache.Instance;
				case 'i': return TXICache.Instance;
				case 'j': return TXJCache.Instance;
				case 'm': return TXMCache.Instance;
				case 'n': return TXNCache.Instance;
				case 'o': return TXOCache.Instance;
				case 'q': return TXQCache.Instance;
				case 'r': return TXRCache.Instance;
				case 's': return TXSCache.Instance;
				case 't': return TXTCache.Instance;
				case 'u': return TXUCache.Instance;
				case 'x': return TXXCache.Instance;
				case 'y': return TXYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ty(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TYACache.Instance;
				case 'e': return TYECache.Instance;
				case 'h': return TYHCache.Instance;
				case 'i': return TYICache.Instance;
				case 'j': return TYJCache.Instance;
				case 'l': return TYLCache.Instance;
				case 'n': return TYNCache.Instance;
				case 'p': return TYPCache.Instance;
				case 'r': return TYRCache.Instance;
				case 's': return TYSCache.Instance;
				case 't': return TYTCache.Instance;
				case 'u': return TYUCache.Instance;
				case 'v': return TYVCache.Instance;
				case 'x': return TYXCache.Instance;
				case 'y': return TYYCache.Instance;
				case 'z': return TYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TZACache.Instance;
				case 'h': return TZHCache.Instance;
				case 'j': return TZJCache.Instance;
				case 'l': return TZLCache.Instance;
				case 'm': return TZMCache.Instance;
				case 'n': return TZNCache.Instance;
				case 'o': return TZOCache.Instance;
				case 'x': return TZXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ua(span);
				case 'b': return tryParse_L3_ub(span);
				case 'd': return tryParse_L3_ud(span);
				case 'e': return tryParse_L3_ue(span);
				case 'f': return tryParse_L3_uf(span);
				case 'g': return tryParse_L3_ug(span);
				case 'h': return tryParse_L3_uh(span);
				case 'i': return tryParse_L3_ui(span);
				case 'j': return tryParse_L3_uj(span);
				case 'k': return tryParse_L3_uk(span);
				case 'l': return tryParse_L3_ul(span);
				case 'm': return tryParse_L3_um(span);
				case 'n': return tryParse_L3_un(span);
				case 'o': return tryParse_L3_uo(span);
				case 'p': return tryParse_L3_up(span);
				case 'r': return tryParse_L3_ur(span);
				case 's': return tryParse_L3_us(span);
				case 't': return tryParse_L3_ut(span);
				case 'u': return tryParse_L3_uu(span);
				case 'v': return tryParse_L3_uv(span);
				case 'w': return tryParse_L3_uw(span);
				case 'y': return tryParse_L3_uy(span);
				case 'z': return tryParse_L3_uz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ua(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return UAMCache.Instance;
				case 'n': return UANCache.Instance;
				case 'r': return UARCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ub(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UBACache.Instance;
				case 'i': return UBICache.Instance;
				case 'l': return UBLCache.Instance;
				case 'r': return UBRCache.Instance;
				case 'u': return UBUCache.Instance;
				case 'y': return UBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ud(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UDACache.Instance;
				case 'e': return UDECache.Instance;
				case 'g': return UDGCache.Instance;
				case 'i': return UDICache.Instance;
				case 'j': return UDJCache.Instance;
				case 'l': return UDLCache.Instance;
				case 'm': return UDMCache.Instance;
				case 'u': return UDUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ue(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return UESCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_uf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return UFICache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ug(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UGACache.Instance;
				case 'b': return UGBCache.Instance;
				case 'e': return UGECache.Instance;
				case 'h': return UGHCache.Instance;
				case 'n': return UGNCache.Instance;
				case 'o': return UGOCache.Instance;
				case 'y': return UGYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UHACache.Instance;
				case 'n': return UHNCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ui(StringSpan span)
		{
			switch(span[2])
			{
				case 's': return UISCache.Instance;
				case 'v': return UIVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return UJICache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_uk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UKACache.Instance;
				case 'g': return UKGCache.Instance;
				case 'h': return UKHCache.Instance;
				case 'i': return UKICache.Instance;
				case 'k': return UKKCache.Instance;
				case 'l': return UKLCache.Instance;
				case 'p': return UKPCache.Instance;
				case 'q': return UKQCache.Instance;
				case 's': return UKSCache.Instance;
				case 'u': return UKUCache.Instance;
				case 'v': return UKVCache.Instance;
				case 'w': return UKWCache.Instance;
				case 'y': return UKYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ul(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ULACache.Instance;
				case 'b': return ULBCache.Instance;
				case 'c': return ULCCache.Instance;
				case 'e': return ULECache.Instance;
				case 'f': return ULFCache.Instance;
				case 'i': return ULICache.Instance;
				case 'k': return ULKCache.Instance;
				case 'l': return ULLCache.Instance;
				case 'm': return ULMCache.Instance;
				case 'n': return ULNCache.Instance;
				case 'u': return ULUCache.Instance;
				case 'w': return ULWCache.Instance;
				case 'y': return ULYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_um(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UMACache.Instance;
				case 'b': return UMBCache.Instance;
				case 'c': return UMCCache.Instance;
				case 'd': return UMDCache.Instance;
				case 'g': return UMGCache.Instance;
				case 'i': return UMICache.Instance;
				case 'm': return UMMCache.Instance;
				case 'n': return UMNCache.Instance;
				case 'o': return UMOCache.Instance;
				case 'p': return UMPCache.Instance;
				case 'r': return UMRCache.Instance;
				case 's': return UMSCache.Instance;
				case 'u': return UMUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_un(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UNACache.Instance;
				case 'd': return UNDCache.Instance;
				case 'e': return UNECache.Instance;
				case 'g': return UNGCache.Instance;
				case 'i': return UNICache.Instance;
				case 'k': return UNKCache.Instance;
				case 'm': return UNMCache.Instance;
				case 'n': return UNNCache.Instance;
				case 'p': return UNPCache.Instance;
				case 'r': return UNRCache.Instance;
				case 'u': return UNUCache.Instance;
				case 'x': return UNXCache.Instance;
				case 'z': return UNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uo(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return EMACache.Instance;
				case 'n': return UONCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_up(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return UPICache.Instance;
				case 'v': return UPVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ur(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return URACache.Instance;
				case 'b': return URBCache.Instance;
				case 'c': return URCCache.Instance;
				case 'e': return URECache.Instance;
				case 'f': return URFCache.Instance;
				case 'g': return URGCache.Instance;
				case 'h': return URHCache.Instance;
				case 'i': return URICache.Instance;
				case 'j': return URJCache.Instance;
				case 'k': return URKCache.Instance;
				case 'l': return URLCache.Instance;
				case 'm': return URMCache.Instance;
				case 'n': return URNCache.Instance;
				case 'o': return UROCache.Instance;
				case 'p': return URPCache.Instance;
				case 'r': return URRCache.Instance;
				case 't': return URTCache.Instance;
				case 'u': return URUCache.Instance;
				case 'v': return URVCache.Instance;
				case 'w': return URWCache.Instance;
				case 'x': return URXCache.Instance;
				case 'y': return URYCache.Instance;
				case 'z': return URZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_us(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return USACache.Instance;
				case 'h': return USHCache.Instance;
				case 'i': return USICache.Instance;
				case 'k': return USKCache.Instance;
				case 'p': return USPCache.Instance;
				case 's': return USSCache.Instance;
				case 'u': return USUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ut(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UTACache.Instance;
				case 'e': return UTECache.Instance;
				case 'h': return UTHCache.Instance;
				case 'p': return UTPCache.Instance;
				case 'r': return UTRCache.Instance;
				case 'u': return UTUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uu(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return UUMCache.Instance;
				case 'n': return UUNCache.Instance;
				case 'r': return UURCache.Instance;
				case 'u': return UUUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uv(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return UVECache.Instance;
				case 'h': return UVHCache.Instance;
				case 'l': return UVLCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return UWACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_uy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return UYACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_uz(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return UZNCache.Instance;
				case 's': return UZSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_va(span);
				case 'b': return tryParse_L3_vb(span);
				case 'e': return tryParse_L3_ve(span);
				case 'g': return tryParse_L3_vg(span);
				case 'i': return tryParse_L3_vi(span);
				case 'j': return tryParse_L3_vj(span);
				case 'k': return tryParse_L3_vk(span);
				case 'l': return tryParse_L3_vl(span);
				case 'm': return tryParse_L3_vm(span);
				case 'n': return tryParse_L3_vn(span);
				case 'o': return tryParse_L3_vo(span);
				case 'r': return tryParse_L3_vr(span);
				case 's': return tryParse_L3_vs(span);
				case 't': return tryParse_L3_vt(span);
				case 'u': return tryParse_L3_vu(span);
				case 'w': return tryParse_L3_vw(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_va(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VAACache.Instance;
				case 'e': return VAECache.Instance;
				case 'f': return VAFCache.Instance;
				case 'g': return VAGCache.Instance;
				case 'h': return VAHCache.Instance;
				case 'i': return VAICache.Instance;
				case 'j': return VAJCache.Instance;
				case 'l': return VALCache.Instance;
				case 'm': return VAMCache.Instance;
				case 'n': return VANCache.Instance;
				case 'o': return VAOCache.Instance;
				case 'p': return VAPCache.Instance;
				case 'r': return VARCache.Instance;
				case 's': return VASCache.Instance;
				case 'u': return VAUCache.Instance;
				case 'v': return VAVCache.Instance;
				case 'y': return VAYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return VBBCache.Instance;
				case 'k': return VBKCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ve(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return VECCache.Instance;
				case 'd': return VEDCache.Instance;
				case 'l': return VELCache.Instance;
				case 'm': return VEMCache.Instance;
				case 'o': return VEOCache.Instance;
				case 'p': return VEPCache.Instance;
				case 'r': return VERCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vg(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return VGRCache.Instance;
				case 't': return VGTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vi(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return VICCache.Instance;
				case 'd': return VIDCache.Instance;
				case 'f': return VIFCache.Instance;
				case 'g': return VIGCache.Instance;
				case 'l': return VILCache.Instance;
				case 'n': return VINCache.Instance;
				case 's': return VISCache.Instance;
				case 't': return VITCache.Instance;
				case 'v': return VIVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return VJKCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_vk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VKACache.Instance;
				case 'i': return VKICache.Instance;
				case 'j': return VKJCache.Instance;
				case 'k': return VKKCache.Instance;
				case 'l': return VKLCache.Instance;
				case 'm': return VKMCache.Instance;
				case 'n': return VKNCache.Instance;
				case 'o': return VKOCache.Instance;
				case 'p': return VKPCache.Instance;
				case 't': return VKTCache.Instance;
				case 'u': return VKUCache.Instance;
				case 'z': return VKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vl(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return VLPCache.Instance;
				case 's': return VLSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VMACache.Instance;
				case 'b': return VMBCache.Instance;
				case 'c': return VMCCache.Instance;
				case 'd': return VMDCache.Instance;
				case 'e': return VMECache.Instance;
				case 'f': return VMFCache.Instance;
				case 'g': return VMGCache.Instance;
				case 'h': return VMHCache.Instance;
				case 'i': return VMICache.Instance;
				case 'j': return VMJCache.Instance;
				case 'k': return VMKCache.Instance;
				case 'l': return VMLCache.Instance;
				case 'm': return VMMCache.Instance;
				case 'p': return VMPCache.Instance;
				case 'q': return VMQCache.Instance;
				case 'r': return VMRCache.Instance;
				case 's': return VMSCache.Instance;
				case 'u': return VMUCache.Instance;
				case 'v': return VMVCache.Instance;
				case 'w': return VMWCache.Instance;
				case 'x': return VMXCache.Instance;
				case 'y': return VMYCache.Instance;
				case 'z': return VMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vn(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return VNKCache.Instance;
				case 'm': return VNMCache.Instance;
				case 'p': return VNPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vo(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return VORCache.Instance;
				case 't': return VOTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VRACache.Instance;
				case 'o': return VROCache.Instance;
				case 's': return VRSCache.Instance;
				case 't': return VRTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vs(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return VSICache.Instance;
				case 'l': return VSLCache.Instance;
				case 'n': return VSNCache.Instance;
				case 'v': return VSVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return VTOCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_vu(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return VUMCache.Instance;
				case 'n': return VUNCache.Instance;
				case 't': return VUTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return VWACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_wa(span);
				case 'b': return tryParse_L3_wb(span);
				case 'c': return tryParse_L3_wc(span);
				case 'd': return tryParse_L3_wd(span);
				case 'e': return tryParse_L3_we(span);
				case 'f': return tryParse_L3_wf(span);
				case 'g': return tryParse_L3_wg(span);
				case 'h': return tryParse_L3_wh(span);
				case 'i': return tryParse_L3_wi(span);
				case 'j': return tryParse_L3_wj(span);
				case 'k': return tryParse_L3_wk(span);
				case 'l': return tryParse_L3_wl(span);
				case 'm': return tryParse_L3_wm(span);
				case 'n': return tryParse_L3_wn(span);
				case 'o': return tryParse_L3_wo(span);
				case 'p': return tryParse_L3_wp(span);
				case 'r': return tryParse_L3_wr(span);
				case 's': return tryParse_L3_ws(span);
				case 't': return tryParse_L3_wt(span);
				case 'u': return tryParse_L3_wu(span);
				case 'w': return tryParse_L3_ww(span);
				case 'x': return tryParse_L3_wx(span);
				case 'y': return tryParse_L3_wy(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WAACache.Instance;
				case 'b': return WABCache.Instance;
				case 'c': return WACCache.Instance;
				case 'd': return WADCache.Instance;
				case 'e': return WAECache.Instance;
				case 'f': return WAFCache.Instance;
				case 'g': return WAGCache.Instance;
				case 'h': return WAHCache.Instance;
				case 'i': return WAICache.Instance;
				case 'j': return WAJCache.Instance;
				case 'k': return WAKCache.Instance;
				case 'l': return WALCache.Instance;
				case 'm': return WAMCache.Instance;
				case 'n': return WANCache.Instance;
				case 'o': return WAOCache.Instance;
				case 'p': return WAPCache.Instance;
				case 'q': return WAQCache.Instance;
				case 'r': return WARCache.Instance;
				case 's': return WASCache.Instance;
				case 't': return WATCache.Instance;
				case 'u': return WAUCache.Instance;
				case 'v': return WAVCache.Instance;
				case 'w': return WAWCache.Instance;
				case 'x': return WAXCache.Instance;
				case 'y': return WAYCache.Instance;
				case 'z': return WAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WBACache.Instance;
				case 'b': return WBBCache.Instance;
				case 'e': return WBECache.Instance;
				case 'f': return WBFCache.Instance;
				case 'h': return WBHCache.Instance;
				case 'i': return WBICache.Instance;
				case 'j': return WBJCache.Instance;
				case 'k': return WBKCache.Instance;
				case 'l': return WBLCache.Instance;
				case 'm': return WBMCache.Instance;
				case 'p': return WBPCache.Instance;
				case 'q': return WBQCache.Instance;
				case 'r': return WBRCache.Instance;
				case 's': return WBSCache.Instance;
				case 't': return WBTCache.Instance;
				case 'v': return WBVCache.Instance;
				case 'w': return WBWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WCACache.Instance;
				case 'i': return WCICache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wd(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return WDDCache.Instance;
				case 'g': return WDGCache.Instance;
				case 'j': return WDJCache.Instance;
				case 'k': return WDKCache.Instance;
				case 't': return WDTCache.Instance;
				case 'u': return WDUCache.Instance;
				case 'y': return WDYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_we(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WEACache.Instance;
				case 'c': return WECCache.Instance;
				case 'd': return WEDCache.Instance;
				case 'g': return WEGCache.Instance;
				case 'h': return WEHCache.Instance;
				case 'i': return WEICache.Instance;
				case 'm': return WEMCache.Instance;
				case 'n': return WENCache.Instance;
				case 'o': return WEOCache.Instance;
				case 'p': return WEPCache.Instance;
				case 'r': return WERCache.Instance;
				case 's': return WESCache.Instance;
				case 't': return WETCache.Instance;
				case 'u': return WEUCache.Instance;
				case 'w': return WEWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return WFGCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_wg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WGACache.Instance;
				case 'b': return WGBCache.Instance;
				case 'g': return WGGCache.Instance;
				case 'i': return WGICache.Instance;
				case 'o': return WGOCache.Instance;
				case 'u': return WGUCache.Instance;
				case 'w': return WGWCache.Instance;
				case 'y': return WGYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WHACache.Instance;
				case 'g': return WHGCache.Instance;
				case 'k': return WHKCache.Instance;
				case 'u': return WHUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wi(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return WIBCache.Instance;
				case 'c': return WICCache.Instance;
				case 'e': return WIECache.Instance;
				case 'f': return WIFCache.Instance;
				case 'g': return WIGCache.Instance;
				case 'h': return WIHCache.Instance;
				case 'i': return WIICache.Instance;
				case 'j': return WIJCache.Instance;
				case 'k': return WIKCache.Instance;
				case 'l': return WILCache.Instance;
				case 'm': return WIMCache.Instance;
				case 'n': return WINCache.Instance;
				case 'r': return WIRCache.Instance;
				case 't': return WITCache.Instance;
				case 'u': return WIUCache.Instance;
				case 'v': return WIVCache.Instance;
				case 'w': return WIWCache.Instance;
				case 'y': return WIYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WJACache.Instance;
				case 'i': return WJICache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WKACache.Instance;
				case 'b': return WKBCache.Instance;
				case 'd': return WKDCache.Instance;
				case 'l': return WKLCache.Instance;
				case 'r': return WKRCache.Instance;
				case 'u': return WKUCache.Instance;
				case 'w': return WKWCache.Instance;
				case 'y': return WKYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WLACache.Instance;
				case 'c': return WLCCache.Instance;
				case 'e': return WLECache.Instance;
				case 'g': return WLGCache.Instance;
				case 'h': return WLHCache.Instance;
				case 'i': return WLICache.Instance;
				case 'k': return WLKCache.Instance;
				case 'l': return WLLCache.Instance;
				case 'm': return WLMCache.Instance;
				case 'o': return WLOCache.Instance;
				case 'r': return WLRCache.Instance;
				case 's': return WLSCache.Instance;
				case 'u': return WLUCache.Instance;
				case 'v': return WLVCache.Instance;
				case 'w': return WLWCache.Instance;
				case 'x': return WLXCache.Instance;
				case 'y': return WLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WMACache.Instance;
				case 'b': return WMBCache.Instance;
				case 'c': return WMCCache.Instance;
				case 'd': return WMDCache.Instance;
				case 'e': return WMECache.Instance;
				case 'g': return WMGCache.Instance;
				case 'h': return WMHCache.Instance;
				case 'i': return WMICache.Instance;
				case 'm': return WMMCache.Instance;
				case 'n': return WMNCache.Instance;
				case 'o': return WMOCache.Instance;
				case 's': return WMSCache.Instance;
				case 't': return WMTCache.Instance;
				case 'w': return WMWCache.Instance;
				case 'x': return WMXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return WNBCache.Instance;
				case 'c': return WNCCache.Instance;
				case 'd': return WNDCache.Instance;
				case 'e': return WNECache.Instance;
				case 'g': return WNGCache.Instance;
				case 'i': return WNICache.Instance;
				case 'k': return WNKCache.Instance;
				case 'm': return WNMCache.Instance;
				case 'n': return WNNCache.Instance;
				case 'o': return WNOCache.Instance;
				case 'p': return WNPCache.Instance;
				case 'u': return WNUCache.Instance;
				case 'w': return WNWCache.Instance;
				case 'y': return WNYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WOACache.Instance;
				case 'b': return WOBCache.Instance;
				case 'c': return WOCCache.Instance;
				case 'd': return WODCache.Instance;
				case 'e': return WOECache.Instance;
				case 'f': return WOFCache.Instance;
				case 'g': return WOGCache.Instance;
				case 'i': return WOICache.Instance;
				case 'k': return WOKCache.Instance;
				case 'm': return WOMCache.Instance;
				case 'n': return WONCache.Instance;
				case 'o': return WOOCache.Instance;
				case 'r': return WORCache.Instance;
				case 's': return WOSCache.Instance;
				case 'w': return WOWCache.Instance;
				case 'y': return WOYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return WPCCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_wr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WRACache.Instance;
				case 'b': return WRBCache.Instance;
				case 'd': return WRDCache.Instance;
				case 'g': return WRGCache.Instance;
				case 'h': return WRHCache.Instance;
				case 'i': return WRICache.Instance;
				case 'k': return WRKCache.Instance;
				case 'l': return WRLCache.Instance;
				case 'm': return WRMCache.Instance;
				case 'n': return WRNCache.Instance;
				case 'o': return WROCache.Instance;
				case 'p': return WRPCache.Instance;
				case 'r': return WRRCache.Instance;
				case 's': return WRSCache.Instance;
				case 'u': return WRUCache.Instance;
				case 'v': return WRVCache.Instance;
				case 'w': return WRWCache.Instance;
				case 'x': return WRXCache.Instance;
				case 'y': return WRYCache.Instance;
				case 'z': return WRZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ws(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WSACache.Instance;
				case 'g': return WSGCache.Instance;
				case 'i': return WSICache.Instance;
				case 'k': return WSKCache.Instance;
				case 'r': return WSRCache.Instance;
				case 's': return WSSCache.Instance;
				case 'u': return WSUCache.Instance;
				case 'v': return WSVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wt(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return WTBCache.Instance;
				case 'f': return WTFCache.Instance;
				case 'h': return WTHCache.Instance;
				case 'i': return WTICache.Instance;
				case 'k': return WTKCache.Instance;
				case 'm': return WTMCache.Instance;
				case 'w': return WTWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WUACache.Instance;
				case 'b': return WUBCache.Instance;
				case 'd': return WUDCache.Instance;
				case 'h': return WUHCache.Instance;
				case 'l': return WULCache.Instance;
				case 'm': return WUMCache.Instance;
				case 'n': return WUNCache.Instance;
				case 'r': return WURCache.Instance;
				case 't': return WUTCache.Instance;
				case 'u': return WUUCache.Instance;
				case 'v': return WUVCache.Instance;
				case 'x': return WUXCache.Instance;
				case 'y': return WUYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ww(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WWACache.Instance;
				case 'b': return WWBCache.Instance;
				case 'o': return WWOCache.Instance;
				case 'r': return WWRCache.Instance;
				case 'w': return WWWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WXACache.Instance;
				case 'w': return WXWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WYACache.Instance;
				case 'b': return WYBCache.Instance;
				case 'i': return WYICache.Instance;
				case 'm': return WYMCache.Instance;
				case 'n': return WYNCache.Instance;
				case 'r': return WYRCache.Instance;
				case 'y': return WYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_x(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_xa(span);
				case 'b': return tryParse_L3_xb(span);
				case 'c': return tryParse_L3_xc(span);
				case 'd': return tryParse_L3_xd(span);
				case 'e': return tryParse_L3_xe(span);
				case 'f': return tryParse_L3_xf(span);
				case 'g': return tryParse_L3_xg(span);
				case 'h': return tryParse_L3_xh(span);
				case 'i': return tryParse_L3_xi(span);
				case 'j': return tryParse_L3_xj(span);
				case 'k': return tryParse_L3_xk(span);
				case 'l': return tryParse_L3_xl(span);
				case 'm': return tryParse_L3_xm(span);
				case 'n': return tryParse_L3_xn(span);
				case 'o': return tryParse_L3_xo(span);
				case 'p': return tryParse_L3_xp(span);
				case 'q': return tryParse_L3_xq(span);
				case 'r': return tryParse_L3_xr(span);
				case 's': return tryParse_L3_xs(span);
				case 't': return tryParse_L3_xt(span);
				case 'u': return tryParse_L3_xu(span);
				case 'v': return tryParse_L3_xv(span);
				case 'w': return tryParse_L3_xw(span);
				case 'x': return tryParse_L3_xx(span);
				case 'y': return tryParse_L3_xy(span);
				case 'z': return tryParse_L3_xz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xa(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XAACache.Instance;
				case 'b': return XABCache.Instance;
				case 'c': return XACCache.Instance;
				case 'd': return XADCache.Instance;
				case 'e': return XAECache.Instance;
				case 'g': return XAGCache.Instance;
				case 'i': return XAICache.Instance;
				case 'j': return XAJCache.Instance;
				case 'k': return XAKCache.Instance;
				case 'l': return XALCache.Instance;
				case 'm': return XAMCache.Instance;
				case 'n': return XANCache.Instance;
				case 'o': return XAOCache.Instance;
				case 'p': return XAPCache.Instance;
				case 'q': return XAQCache.Instance;
				case 'r': return XARCache.Instance;
				case 's': return XASCache.Instance;
				case 't': return XATCache.Instance;
				case 'u': return XAUCache.Instance;
				case 'v': return XAVCache.Instance;
				case 'w': return XAWCache.Instance;
				case 'y': return XAYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CAXCache.Instance;
				case 'b': return XBBCache.Instance;
				case 'c': return XBCCache.Instance;
				case 'd': return XBDCache.Instance;
				case 'e': return XBECache.Instance;
				case 'g': return XBGCache.Instance;
				case 'i': return XBICache.Instance;
				case 'j': return XBJCache.Instance;
				case 'm': return XBMCache.Instance;
				case 'n': return XBNCache.Instance;
				case 'o': return XBOCache.Instance;
				case 'p': return XBPCache.Instance;
				case 'r': return XBRCache.Instance;
				case 'w': return XBWCache.Instance;
				case 'x': return XBXCache.Instance;
				case 'y': return XBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xc(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XCBCache.Instance;
				case 'c': return XCCCache.Instance;
				case 'e': return XCECache.Instance;
				case 'g': return XCGCache.Instance;
				case 'h': return XCHCache.Instance;
				case 'l': return XCLCache.Instance;
				case 'm': return XCMCache.Instance;
				case 'n': return XCNCache.Instance;
				case 'o': return XCOCache.Instance;
				case 'r': return XCRCache.Instance;
				case 't': return XCTCache.Instance;
				case 'u': return XCUCache.Instance;
				case 'v': return XCVCache.Instance;
				case 'w': return XCWCache.Instance;
				case 'y': return XCYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XDACache.Instance;
				case 'c': return XDCCache.Instance;
				case 'k': return XDKCache.Instance;
				case 'm': return XDMCache.Instance;
				case 'o': return XDOCache.Instance;
				case 'q': return XDQCache.Instance;
				case 'y': return XDYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xe(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XEBCache.Instance;
				case 'd': return XEDCache.Instance;
				case 'g': return XEGCache.Instance;
				case 'l': return XELCache.Instance;
				case 'm': return XEMCache.Instance;
				case 'p': return XEPCache.Instance;
				case 'r': return XERCache.Instance;
				case 's': return XESCache.Instance;
				case 't': return XETCache.Instance;
				case 'u': return XEUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return XFACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_xg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XGACache.Instance;
				case 'b': return XGBCache.Instance;
				case 'd': return XGDCache.Instance;
				case 'f': return XGFCache.Instance;
				case 'g': return XGGCache.Instance;
				case 'i': return XGICache.Instance;
				case 'l': return XGLCache.Instance;
				case 'm': return XGMCache.Instance;
				case 'n': return XGNCache.Instance;
				case 'r': return XGRCache.Instance;
				case 'u': return XGUCache.Instance;
				case 'w': return XGWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XHACache.Instance;
				case 'c': return XHCCache.Instance;
				case 'd': return XHDCache.Instance;
				case 'e': return XHECache.Instance;
				case 'm': return XHMCache.Instance;
				case 'r': return XHRCache.Instance;
				case 't': return XHTCache.Instance;
				case 'u': return XHUCache.Instance;
				case 'v': return XHVCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ACNCache.Instance;
				case 'b': return XIBCache.Instance;
				case 'i': return XIICache.Instance;
				case 'l': return XILCache.Instance;
				case 'n': return XINCache.Instance;
				case 'p': return XIPCache.Instance;
				case 'r': return XIRCache.Instance;
				case 's': return XISCache.Instance;
				case 'v': return XIVCache.Instance;
				case 'y': return XIYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xj(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XJBCache.Instance;
				case 't': return XJTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XKACache.Instance;
				case 'b': return XKBCache.Instance;
				case 'c': return XKCCache.Instance;
				case 'd': return XKDCache.Instance;
				case 'e': return XKECache.Instance;
				case 'f': return XKFCache.Instance;
				case 'g': return XKGCache.Instance;
				case 'h': return WAWCache.Instance;
				case 'i': return XKICache.Instance;
				case 'j': return XKJCache.Instance;
				case 'k': return XKKCache.Instance;
				case 'l': return XKLCache.Instance;
				case 'n': return XKNCache.Instance;
				case 'o': return XKOCache.Instance;
				case 'p': return XKPCache.Instance;
				case 'q': return XKQCache.Instance;
				case 'r': return XKRCache.Instance;
				case 's': return XKSCache.Instance;
				case 't': return XKTCache.Instance;
				case 'u': return XKUCache.Instance;
				case 'v': return XKVCache.Instance;
				case 'w': return XKWCache.Instance;
				case 'x': return XKXCache.Instance;
				case 'y': return XKYCache.Instance;
				case 'z': return XKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XLACache.Instance;
				case 'b': return XLBCache.Instance;
				case 'c': return XLCCache.Instance;
				case 'd': return XLDCache.Instance;
				case 'e': return XLECache.Instance;
				case 'g': return XLGCache.Instance;
				case 'i': return XLICache.Instance;
				case 'n': return XLNCache.Instance;
				case 'o': return XLOCache.Instance;
				case 'p': return XLPCache.Instance;
				case 's': return XLSCache.Instance;
				case 'u': return XLUCache.Instance;
				case 'y': return XLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XMACache.Instance;
				case 'b': return XMBCache.Instance;
				case 'c': return XMCCache.Instance;
				case 'd': return XMDCache.Instance;
				case 'e': return XMECache.Instance;
				case 'f': return XMFCache.Instance;
				case 'g': return XMGCache.Instance;
				case 'h': return XMHCache.Instance;
				case 'j': return XMJCache.Instance;
				case 'k': return XMKCache.Instance;
				case 'l': return XMLCache.Instance;
				case 'm': return XMMCache.Instance;
				case 'n': return XMNCache.Instance;
				case 'o': return XMOCache.Instance;
				case 'p': return XMPCache.Instance;
				case 'q': return XMQCache.Instance;
				case 'r': return XMRCache.Instance;
				case 's': return XMSCache.Instance;
				case 't': return XMTCache.Instance;
				case 'u': return XMUCache.Instance;
				case 'v': return XMVCache.Instance;
				case 'w': return XMWCache.Instance;
				case 'x': return XMXCache.Instance;
				case 'y': return XMYCache.Instance;
				case 'z': return XMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XNACache.Instance;
				case 'b': return XNBCache.Instance;
				case 'd': return XNDCache.Instance;
				case 'g': return XNGCache.Instance;
				case 'h': return XNHCache.Instance;
				case 'i': return XNICache.Instance;
				case 'j': return XNJCache.Instance;
				case 'k': return XNKCache.Instance;
				case 'm': return XNMCache.Instance;
				case 'n': return XNNCache.Instance;
				case 'o': return XNOCache.Instance;
				case 'q': return XNQCache.Instance;
				case 'r': return XNRCache.Instance;
				case 's': return XNSCache.Instance;
				case 't': return XNTCache.Instance;
				case 'u': return XNUCache.Instance;
				case 'y': return XNYCache.Instance;
				case 'z': return XNZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xo(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return XOCCache.Instance;
				case 'd': return XODCache.Instance;
				case 'g': return XOGCache.Instance;
				case 'i': return XOICache.Instance;
				case 'k': return XOKCache.Instance;
				case 'm': return XOMCache.Instance;
				case 'n': return XONCache.Instance;
				case 'o': return XOOCache.Instance;
				case 'p': return XOPCache.Instance;
				case 'r': return XORCache.Instance;
				case 'w': return XOWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XPACache.Instance;
				case 'b': return XPBCache.Instance;
				case 'c': return XPCCache.Instance;
				case 'd': return XPDCache.Instance;
				case 'e': return XPECache.Instance;
				case 'f': return XPFCache.Instance;
				case 'g': return XPGCache.Instance;
				case 'h': return XPHCache.Instance;
				case 'i': return XPICache.Instance;
				case 'j': return XPJCache.Instance;
				case 'k': return XPKCache.Instance;
				case 'l': return XPLCache.Instance;
				case 'm': return XPMCache.Instance;
				case 'n': return XPNCache.Instance;
				case 'o': return XPOCache.Instance;
				case 'p': return XPPCache.Instance;
				case 'q': return XPQCache.Instance;
				case 'r': return XPRCache.Instance;
				case 's': return XPSCache.Instance;
				case 't': return XPTCache.Instance;
				case 'u': return XPUCache.Instance;
				case 'v': return XPVCache.Instance;
				case 'w': return XPWCache.Instance;
				case 'x': return XPXCache.Instance;
				case 'y': return XPYCache.Instance;
				case 'z': return XPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XQACache.Instance;
				case 't': return XQTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XRACache.Instance;
				case 'b': return XRBCache.Instance;
				case 'd': return XRDCache.Instance;
				case 'e': return XRECache.Instance;
				case 'g': return XRGCache.Instance;
				case 'i': return XRICache.Instance;
				case 'm': return XRMCache.Instance;
				case 'n': return XRNCache.Instance;
				case 'q': return DMWCache.Instance;
				case 'r': return XRRCache.Instance;
				case 't': return XRTCache.Instance;
				case 'u': return XRUCache.Instance;
				case 'w': return XRWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XSACache.Instance;
				case 'b': return XSBCache.Instance;
				case 'c': return XSCCache.Instance;
				case 'd': return XSDCache.Instance;
				case 'e': return XSECache.Instance;
				case 'h': return XSHCache.Instance;
				case 'i': return XSICache.Instance;
				case 'j': return XSJCache.Instance;
				case 'l': return XSLCache.Instance;
				case 'm': return XSMCache.Instance;
				case 'n': return XSNCache.Instance;
				case 'o': return XSOCache.Instance;
				case 'p': return XSPCache.Instance;
				case 'q': return XSQCache.Instance;
				case 'r': return XSRCache.Instance;
				case 's': return ZKOCache.Instance;
				case 'u': return XSUCache.Instance;
				case 'v': return XSVCache.Instance;
				case 'y': return XSYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XTACache.Instance;
				case 'b': return XTBCache.Instance;
				case 'c': return XTCCache.Instance;
				case 'd': return XTDCache.Instance;
				case 'e': return XTECache.Instance;
				case 'g': return XTGCache.Instance;
				case 'h': return XTHCache.Instance;
				case 'i': return XTICache.Instance;
				case 'j': return XTJCache.Instance;
				case 'l': return XTLCache.Instance;
				case 'm': return XTMCache.Instance;
				case 'n': return XTNCache.Instance;
				case 'o': return XTOCache.Instance;
				case 'p': return XTPCache.Instance;
				case 'q': return XTQCache.Instance;
				case 'r': return XTRCache.Instance;
				case 's': return XTSCache.Instance;
				case 't': return XTTCache.Instance;
				case 'u': return XTUCache.Instance;
				case 'v': return XTVCache.Instance;
				case 'w': return XTWCache.Instance;
				case 'y': return XTYCache.Instance;
				case 'z': return XTZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XUACache.Instance;
				case 'b': return XUBCache.Instance;
				case 'd': return XUDCache.Instance;
				case 'g': return XUGCache.Instance;
				case 'j': return XUJCache.Instance;
				case 'l': return XULCache.Instance;
				case 'm': return XUMCache.Instance;
				case 'n': return XUNCache.Instance;
				case 'o': return XUOCache.Instance;
				case 'p': return XUPCache.Instance;
				case 'r': return XURCache.Instance;
				case 't': return XUTCache.Instance;
				case 'u': return XUUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xv(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return XVECache.Instance;
				case 'i': return XVICache.Instance;
				case 'n': return XVNCache.Instance;
				case 'o': return XVOCache.Instance;
				case 's': return XVSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XWACache.Instance;
				case 'c': return XWCCache.Instance;
				case 'd': return XWDCache.Instance;
				case 'e': return XWECache.Instance;
				case 'g': return XWGCache.Instance;
				case 'j': return XWJCache.Instance;
				case 'k': return XWKCache.Instance;
				case 'l': return XWLCache.Instance;
				case 'o': return XWOCache.Instance;
				case 'r': return XWRCache.Instance;
				case 't': return XWTCache.Instance;
				case 'w': return XWWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xx(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XXBCache.Instance;
				case 'k': return XXKCache.Instance;
				case 'm': return XXMCache.Instance;
				case 'r': return XXRCache.Instance;
				case 't': return XXTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XYACache.Instance;
				case 'b': return XYBCache.Instance;
				case 'j': return XYJCache.Instance;
				case 'k': return XYKCache.Instance;
				case 'l': return XYLCache.Instance;
				case 't': return XYTCache.Instance;
				case 'y': return XYYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return XZHCache.Instance;
				case 'm': return XZMCache.Instance;
				case 'p': return XZPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_ya(span);
				case 'b': return tryParse_L3_yb(span);
				case 'c': return tryParse_L3_yc(span);
				case 'd': return tryParse_L3_yd(span);
				case 'e': return tryParse_L3_ye(span);
				case 'g': return tryParse_L3_yg(span);
				case 'h': return tryParse_L3_yh(span);
				case 'i': return tryParse_L3_yi(span);
				case 'k': return tryParse_L3_yk(span);
				case 'l': return tryParse_L3_yl(span);
				case 'm': return tryParse_L3_ym(span);
				case 'n': return tryParse_L3_yn(span);
				case 'o': return tryParse_L3_yo(span);
				case 'p': return tryParse_L3_yp(span);
				case 'r': return tryParse_L3_yr(span);
				case 's': return tryParse_L3_ys(span);
				case 't': return tryParse_L3_yt(span);
				case 'u': return tryParse_L3_yu(span);
				case 'v': return tryParse_L3_yv(span);
				case 'w': return tryParse_L3_yw(span);
				case 'x': return tryParse_L3_yx(span);
				case 'y': return tryParse_L3_yy(span);
				case 'z': return tryParse_L3_yz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ya(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YAACache.Instance;
				case 'b': return YABCache.Instance;
				case 'c': return YACCache.Instance;
				case 'd': return YADCache.Instance;
				case 'e': return YAECache.Instance;
				case 'f': return YAFCache.Instance;
				case 'g': return YAGCache.Instance;
				case 'h': return YAHCache.Instance;
				case 'i': return YAICache.Instance;
				case 'j': return YAJCache.Instance;
				case 'k': return YAKCache.Instance;
				case 'l': return YALCache.Instance;
				case 'm': return YAMCache.Instance;
				case 'n': return YANCache.Instance;
				case 'o': return YAOCache.Instance;
				case 'p': return YAPCache.Instance;
				case 'q': return YAQCache.Instance;
				case 'r': return YARCache.Instance;
				case 's': return YASCache.Instance;
				case 't': return YATCache.Instance;
				case 'u': return YAUCache.Instance;
				case 'v': return YAVCache.Instance;
				case 'w': return YAWCache.Instance;
				case 'x': return YAXCache.Instance;
				case 'y': return YAYCache.Instance;
				case 'z': return YAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YBACache.Instance;
				case 'b': return YBBCache.Instance;
				case 'd': return RKICache.Instance;
				case 'e': return YBECache.Instance;
				case 'h': return YBHCache.Instance;
				case 'i': return YBICache.Instance;
				case 'j': return YBJCache.Instance;
				case 'k': return YBKCache.Instance;
				case 'l': return YBLCache.Instance;
				case 'm': return YBMCache.Instance;
				case 'n': return YBNCache.Instance;
				case 'o': return YBOCache.Instance;
				case 'x': return YBXCache.Instance;
				case 'y': return YBYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yc(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return YCHCache.Instance;
				case 'l': return YCLCache.Instance;
				case 'n': return YCNCache.Instance;
				case 'p': return YCPCache.Instance;
				case 'r': return YCRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YDACache.Instance;
				case 'd': return YDDCache.Instance;
				case 'e': return YDECache.Instance;
				case 'g': return YDGCache.Instance;
				case 'k': return YDKCache.Instance;
				case 's': return YDSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ye(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YEACache.Instance;
				case 'c': return YECCache.Instance;
				case 'e': return YEECache.Instance;
				case 'i': return YEICache.Instance;
				case 'j': return YEJCache.Instance;
				case 'l': return YELCache.Instance;
				case 'n': return YENCache.Instance;
				case 'r': return YERCache.Instance;
				case 's': return YESCache.Instance;
				case 't': return YETCache.Instance;
				case 'u': return YEUCache.Instance;
				case 'v': return YEVCache.Instance;
				case 'y': return YEYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YGACache.Instance;
				case 'i': return YGICache.Instance;
				case 'l': return YGLCache.Instance;
				case 'm': return YGMCache.Instance;
				case 'p': return YGPCache.Instance;
				case 'r': return YGRCache.Instance;
				case 's': return YGSCache.Instance;
				case 'u': return YGUCache.Instance;
				case 'w': return YGWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YHACache.Instance;
				case 'd': return YHDCache.Instance;
				case 'l': return YHLCache.Instance;
				case 's': return YHSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YIACache.Instance;
				case 'f': return YIFCache.Instance;
				case 'g': return YIGCache.Instance;
				case 'h': return YIHCache.Instance;
				case 'i': return YIICache.Instance;
				case 'j': return YIJCache.Instance;
				case 'k': return YIKCache.Instance;
				case 'l': return YILCache.Instance;
				case 'm': return YIMCache.Instance;
				case 'n': return YINCache.Instance;
				case 'p': return YIPCache.Instance;
				case 'q': return YIQCache.Instance;
				case 'r': return YIRCache.Instance;
				case 's': return YISCache.Instance;
				case 't': return YITCache.Instance;
				case 'u': return YIUCache.Instance;
				case 'v': return YIVCache.Instance;
				case 'x': return YIXCache.Instance;
				case 'y': return YIYCache.Instance;
				case 'z': return YIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YKACache.Instance;
				case 'g': return YKGCache.Instance;
				case 'h': return YKHCache.Instance;
				case 'i': return YKICache.Instance;
				case 'k': return YKKCache.Instance;
				case 'l': return YKLCache.Instance;
				case 'm': return YKMCache.Instance;
				case 'n': return YKNCache.Instance;
				case 'o': return YKOCache.Instance;
				case 'r': return YKRCache.Instance;
				case 't': return YKTCache.Instance;
				case 'u': return YKUCache.Instance;
				case 'y': return YKYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YLACache.Instance;
				case 'b': return YLBCache.Instance;
				case 'e': return YLECache.Instance;
				case 'g': return YLGCache.Instance;
				case 'i': return YLICache.Instance;
				case 'l': return YLLCache.Instance;
				case 'm': return YLMCache.Instance;
				case 'n': return YLNCache.Instance;
				case 'o': return YLOCache.Instance;
				case 'r': return YLRCache.Instance;
				case 'u': return YLUCache.Instance;
				case 'y': return YLYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ym(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LRRCache.Instance;
				case 'b': return YMBCache.Instance;
				case 'c': return YMCCache.Instance;
				case 'd': return YMDCache.Instance;
				case 'e': return YMECache.Instance;
				case 'g': return YMGCache.Instance;
				case 'h': return YMHCache.Instance;
				case 'i': return YMICache.Instance;
				case 'k': return YMKCache.Instance;
				case 'l': return YMLCache.Instance;
				case 'm': return YMMCache.Instance;
				case 'n': return YMNCache.Instance;
				case 'o': return YMOCache.Instance;
				case 'p': return YMPCache.Instance;
				case 'q': return YMQCache.Instance;
				case 'r': return YMRCache.Instance;
				case 's': return YMSCache.Instance;
				case 't': return MTMCache.Instance;
				case 'x': return YMXCache.Instance;
				case 'z': return YMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YNACache.Instance;
				case 'b': return YNBCache.Instance;
				case 'd': return YNDCache.Instance;
				case 'e': return YNECache.Instance;
				case 'g': return YNGCache.Instance;
				case 'h': return YNHCache.Instance;
				case 'k': return YNKCache.Instance;
				case 'l': return YNLCache.Instance;
				case 'n': return YNNCache.Instance;
				case 'o': return YNOCache.Instance;
				case 'q': return YNQCache.Instance;
				case 's': return YNSCache.Instance;
				case 'u': return YNUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yo(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return YOBCache.Instance;
				case 'g': return YOGCache.Instance;
				case 'i': return YOICache.Instance;
				case 'k': return YOKCache.Instance;
				case 'l': return YOLCache.Instance;
				case 'm': return YOMCache.Instance;
				case 'n': return YONCache.Instance;
				case 's': return ZOMCache.Instance;
				case 't': return YOTCache.Instance;
				case 'x': return YOXCache.Instance;
				case 'y': return YOYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YPACache.Instance;
				case 'b': return YPBCache.Instance;
				case 'g': return YPGCache.Instance;
				case 'h': return YPHCache.Instance;
				case 'k': return YPKCache.Instance;
				case 'm': return YPMCache.Instance;
				case 'n': return YPNCache.Instance;
				case 'o': return YPOCache.Instance;
				case 'p': return YPPCache.Instance;
				case 'z': return YPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YRACache.Instance;
				case 'b': return YRBCache.Instance;
				case 'e': return YRECache.Instance;
				case 'i': return YRICache.Instance;
				case 'k': return YRKCache.Instance;
				case 'l': return YRLCache.Instance;
				case 'm': return YRMCache.Instance;
				case 'n': return YRNCache.Instance;
				case 'o': return YROCache.Instance;
				case 's': return YRSCache.Instance;
				case 'w': return YRWCache.Instance;
				case 'y': return YRYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ys(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return YSCCache.Instance;
				case 'd': return YSDCache.Instance;
				case 'g': return YSGCache.Instance;
				case 'l': return YSLCache.Instance;
				case 'm': return YSMCache.Instance;
				case 'n': return YSNCache.Instance;
				case 'o': return YSOCache.Instance;
				case 'p': return YSPCache.Instance;
				case 'r': return YSRCache.Instance;
				case 's': return YSSCache.Instance;
				case 'y': return YSYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YTACache.Instance;
				case 'l': return YTLCache.Instance;
				case 'p': return YTPCache.Instance;
				case 'w': return YTWCache.Instance;
				case 'y': return YTYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YUACache.Instance;
				case 'b': return YUBCache.Instance;
				case 'c': return YUCCache.Instance;
				case 'd': return YUDCache.Instance;
				case 'e': return YUECache.Instance;
				case 'f': return YUFCache.Instance;
				case 'g': return YUGCache.Instance;
				case 'i': return YUICache.Instance;
				case 'j': return YUJCache.Instance;
				case 'k': return YUKCache.Instance;
				case 'l': return YULCache.Instance;
				case 'm': return YUMCache.Instance;
				case 'n': return YUNCache.Instance;
				case 'p': return YUPCache.Instance;
				case 'q': return YUQCache.Instance;
				case 'r': return YURCache.Instance;
				case 't': return YUTCache.Instance;
				case 'u': return YUGCache.Instance;
				case 'w': return YUWCache.Instance;
				case 'x': return YUXCache.Instance;
				case 'y': return YUYCache.Instance;
				case 'z': return YUZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YVACache.Instance;
				case 't': return YVTCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YWACache.Instance;
				case 'g': return YWGCache.Instance;
				case 'l': return YWLCache.Instance;
				case 'n': return YWNCache.Instance;
				case 'q': return YWQCache.Instance;
				case 'r': return YWRCache.Instance;
				case 't': return YWTCache.Instance;
				case 'u': return YWUCache.Instance;
				case 'w': return YWWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YXACache.Instance;
				case 'g': return YXGCache.Instance;
				case 'l': return YXLCache.Instance;
				case 'm': return YXMCache.Instance;
				case 'u': return YXUCache.Instance;
				case 'y': return YXYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yy(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return YYRCache.Instance;
				case 'u': return YYUCache.Instance;
				case 'z': return YYZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yz(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return YZGCache.Instance;
				case 'k': return YZKCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L3_za(span);
				case 'b': return tryParse_L3_zb(span);
				case 'c': return tryParse_L3_zc(span);
				case 'd': return tryParse_L3_zd(span);
				case 'e': return tryParse_L3_ze(span);
				case 'g': return tryParse_L3_zg(span);
				case 'h': return tryParse_L3_zh(span);
				case 'i': return tryParse_L3_zi(span);
				case 'k': return tryParse_L3_zk(span);
				case 'l': return tryParse_L3_zl(span);
				case 'm': return tryParse_L3_zm(span);
				case 'n': return tryParse_L3_zn(span);
				case 'o': return tryParse_L3_zo(span);
				case 'p': return tryParse_L3_zp(span);
				case 'q': return tryParse_L3_zq(span);
				case 'r': return tryParse_L3_zr(span);
				case 's': return tryParse_L3_zs(span);
				case 't': return tryParse_L3_zt(span);
				case 'u': return tryParse_L3_zu(span);
				case 'w': return tryParse_L3_zw(span);
				case 'x': return tryParse_L3_zx(span);
				case 'y': return tryParse_L3_zy(span);
				case 'z': return tryParse_L3_zz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_za(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZAACache.Instance;
				case 'b': return ZABCache.Instance;
				case 'c': return ZACCache.Instance;
				case 'd': return ZADCache.Instance;
				case 'e': return ZAECache.Instance;
				case 'f': return ZAFCache.Instance;
				case 'g': return ZAGCache.Instance;
				case 'h': return ZAHCache.Instance;
				case 'i': return ZAICache.Instance;
				case 'j': return ZAJCache.Instance;
				case 'k': return ZAKCache.Instance;
				case 'l': return ZALCache.Instance;
				case 'm': return ZAMCache.Instance;
				case 'o': return ZAOCache.Instance;
				case 'p': return ZAPCache.Instance;
				case 'q': return ZAQCache.Instance;
				case 'r': return ZARCache.Instance;
				case 's': return ZASCache.Instance;
				case 't': return ZATCache.Instance;
				case 'u': return ZAUCache.Instance;
				case 'v': return ZAVCache.Instance;
				case 'w': return ZAWCache.Instance;
				case 'x': return ZAXCache.Instance;
				case 'y': return ZAYCache.Instance;
				case 'z': return ZAZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZBACache.Instance;
				case 'c': return ZBCCache.Instance;
				case 'e': return ZBECache.Instance;
				case 'l': return ZBLCache.Instance;
				case 't': return ZBTCache.Instance;
				case 'u': return ZBUCache.Instance;
				case 'w': return ZBWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZCACache.Instance;
				case 'd': return ZCDCache.Instance;
				case 'h': return ZCHCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'j')
				return ZDJCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_ze(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZEACache.Instance;
				case 'g': return ZEGCache.Instance;
				case 'h': return ZEHCache.Instance;
				case 'm': return ZEMCache.Instance;
				case 'n': return ZENCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZGACache.Instance;
				case 'b': return ZGBCache.Instance;
				case 'h': return ZGHCache.Instance;
				case 'm': return ZGMCache.Instance;
				case 'n': return ZGNCache.Instance;
				case 'r': return ZGRCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zh(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ZHBCache.Instance;
				case 'd': return ZHDCache.Instance;
				case 'i': return ZHICache.Instance;
				case 'n': return ZHNCache.Instance;
				case 'w': return ZHWCache.Instance;
				case 'x': return ZHXCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZIACache.Instance;
				case 'b': return ZIBCache.Instance;
				case 'k': return ZIKCache.Instance;
				case 'l': return ZILCache.Instance;
				case 'm': return ZIMCache.Instance;
				case 'n': return ZINCache.Instance;
				case 'r': return SCVCache.Instance;
				case 'w': return ZIWCache.Instance;
				case 'z': return ZIZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZKACache.Instance;
				case 'b': return KJHCache.Instance;
				case 'd': return ZKDCache.Instance;
				case 'g': return ZKGCache.Instance;
				case 'h': return ZKHCache.Instance;
				case 'k': return ZKKCache.Instance;
				case 'n': return ZKNCache.Instance;
				case 'o': return ZKOCache.Instance;
				case 'p': return ZKPCache.Instance;
				case 'r': return ZKRCache.Instance;
				case 't': return ZKTCache.Instance;
				case 'u': return ZKUCache.Instance;
				case 'v': return ZKVCache.Instance;
				case 'z': return ZKZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZLACache.Instance;
				case 'e': return ZLECache.Instance;
				case 'j': return ZLJCache.Instance;
				case 'm': return ZLMCache.Instance;
				case 'n': return ZLNCache.Instance;
				case 'q': return ZLQCache.Instance;
				case 's': return ZLSCache.Instance;
				case 'u': return ZLUCache.Instance;
				case 'w': return ZLWCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZMACache.Instance;
				case 'b': return ZMBCache.Instance;
				case 'c': return ZMCCache.Instance;
				case 'd': return ZMDCache.Instance;
				case 'e': return ZMECache.Instance;
				case 'f': return ZMFCache.Instance;
				case 'g': return ZMGCache.Instance;
				case 'h': return ZMHCache.Instance;
				case 'i': return ZMICache.Instance;
				case 'j': return ZMJCache.Instance;
				case 'k': return ZMKCache.Instance;
				case 'l': return ZMLCache.Instance;
				case 'm': return ZMMCache.Instance;
				case 'n': return ZMNCache.Instance;
				case 'o': return ZMOCache.Instance;
				case 'p': return ZMPCache.Instance;
				case 'q': return ZMQCache.Instance;
				case 'r': return ZMRCache.Instance;
				case 's': return ZMSCache.Instance;
				case 't': return ZMTCache.Instance;
				case 'u': return ZMUCache.Instance;
				case 'v': return ZMVCache.Instance;
				case 'w': return ZMWCache.Instance;
				case 'x': return ZMXCache.Instance;
				case 'y': return ZMYCache.Instance;
				case 'z': return ZMZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZNACache.Instance;
				case 'd': return ZNDCache.Instance;
				case 'e': return ZNECache.Instance;
				case 'g': return ZNGCache.Instance;
				case 'k': return ZNKCache.Instance;
				case 's': return ZNSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zo(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return ZOCCache.Instance;
				case 'h': return ZOHCache.Instance;
				case 'm': return ZOMCache.Instance;
				case 'o': return ZOOCache.Instance;
				case 'q': return ZOQCache.Instance;
				case 'r': return ZORCache.Instance;
				case 's': return ZOSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZPACache.Instance;
				case 'b': return ZPBCache.Instance;
				case 'c': return ZPCCache.Instance;
				case 'd': return ZPDCache.Instance;
				case 'e': return ZPECache.Instance;
				case 'f': return ZPFCache.Instance;
				case 'g': return ZPGCache.Instance;
				case 'h': return ZPHCache.Instance;
				case 'i': return ZPICache.Instance;
				case 'j': return ZPJCache.Instance;
				case 'k': return ZPKCache.Instance;
				case 'l': return ZPLCache.Instance;
				case 'm': return ZPMCache.Instance;
				case 'n': return ZPNCache.Instance;
				case 'o': return ZPOCache.Instance;
				case 'p': return ZPPCache.Instance;
				case 'q': return ZPQCache.Instance;
				case 'r': return ZPRCache.Instance;
				case 's': return ZPSCache.Instance;
				case 't': return ZPTCache.Instance;
				case 'u': return ZPUCache.Instance;
				case 'v': return ZPVCache.Instance;
				case 'w': return ZPWCache.Instance;
				case 'x': return ZPXCache.Instance;
				case 'y': return ZPYCache.Instance;
				case 'z': return ZPZCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return ZQECache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_zr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZRACache.Instance;
				case 'g': return ZRGCache.Instance;
				case 'n': return ZRNCache.Instance;
				case 'o': return ZROCache.Instance;
				case 'p': return ZRPCache.Instance;
				case 's': return ZRSCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZSACache.Instance;
				case 'k': return ZSKCache.Instance;
				case 'l': return ZSLCache.Instance;
				case 'm': return ZSMCache.Instance;
				case 'r': return ZSRCache.Instance;
				case 'u': return ZSUCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zt(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ZTECache.Instance;
				case 'g': return ZTGCache.Instance;
				case 'l': return ZTLCache.Instance;
				case 'm': return ZTMCache.Instance;
				case 'n': return ZTNCache.Instance;
				case 'p': return ZTPCache.Instance;
				case 'q': return ZTQCache.Instance;
				case 's': return ZTSCache.Instance;
				case 't': return ZTTCache.Instance;
				case 'u': return ZTUCache.Instance;
				case 'x': return ZTXCache.Instance;
				case 'y': return ZTYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZUACache.Instance;
				case 'h': return ZUHCache.Instance;
				case 'm': return ZUMCache.Instance;
				case 'n': return ZUNCache.Instance;
				case 'y': return ZUYCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return ZWACache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_zx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return ZXXCache.Instance;
			return null;
		}
		
		private static Language? tryParse_L3_zy(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ZYBCache.Instance;
				case 'g': return ZYGCache.Instance;
				case 'j': return ZYJCache.Instance;
				case 'n': return ZYNCache.Instance;
				case 'p': return ZYPCache.Instance;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZZACache.Instance;
				case 'j': return ZZJCache.Instance;
				default: return null;
			}
		}
	}
}
