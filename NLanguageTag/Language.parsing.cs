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
				case 'a': return AA;
				case 'b': return AB;
				case 'e': return AE;
				case 'f': return AF;
				case 'k': return AK;
				case 'm': return AM;
				case 'n': return AN;
				case 'r': return AR;
				case 's': return AS;
				case 'v': return AV;
				case 'y': return AY;
				case 'z': return AZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return BA;
				case 'e': return BE;
				case 'g': return BG;
				case 'h': return BH;
				case 'i': return BI;
				case 'm': return BM;
				case 'n': return BN;
				case 'o': return BO;
				case 'r': return BR;
				case 's': return BS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return CA;
				case 'e': return CE;
				case 'h': return CH;
				case 'o': return CO;
				case 'r': return CR;
				case 's': return CS;
				case 'u': return CU;
				case 'v': return CV;
				case 'y': return CY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return DA;
				case 'e': return DE;
				case 'v': return DV;
				case 'z': return DZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return EE;
				case 'l': return EL;
				case 'n': return EN;
				case 'o': return EO;
				case 's': return ES;
				case 't': return ET;
				case 'u': return EU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return FA;
				case 'f': return FF;
				case 'i': return FI;
				case 'j': return FJ;
				case 'o': return FO;
				case 'r': return FR;
				case 'y': return FY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return GA;
				case 'd': return GD;
				case 'l': return GL;
				case 'n': return GN;
				case 'u': return GU;
				case 'v': return GV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return HA;
				case 'e': return HE;
				case 'i': return HI;
				case 'o': return HO;
				case 'r': return HR;
				case 't': return HT;
				case 'u': return HU;
				case 'y': return HY;
				case 'z': return HZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return IA;
				case 'd': return ID;
				case 'e': return IE;
				case 'g': return IG;
				case 'i': return II;
				case 'k': return IK;
				case 'n': return ID;
				case 'o': return IO;
				case 's': return IS;
				case 't': return IT;
				case 'u': return IU;
				case 'w': return HE;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return JA;
				case 'i': return YI;
				case 'v': return JV;
				case 'w': return JV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return KA;
				case 'g': return KG;
				case 'i': return KI;
				case 'j': return KJ;
				case 'k': return KK;
				case 'l': return KL;
				case 'm': return KM;
				case 'n': return KN;
				case 'o': return KO;
				case 'r': return KR;
				case 's': return KS;
				case 'u': return KU;
				case 'v': return KV;
				case 'w': return KW;
				case 'y': return KY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return LA;
				case 'b': return LB;
				case 'g': return LG;
				case 'i': return LI;
				case 'n': return LN;
				case 'o': return LO;
				case 't': return LT;
				case 'u': return LU;
				case 'v': return LV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return MG;
				case 'h': return MH;
				case 'i': return MI;
				case 'k': return MK;
				case 'l': return ML;
				case 'n': return MN;
				case 'o': return RO;
				case 'r': return MR;
				case 's': return MS;
				case 't': return MT;
				case 'y': return MY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return NA;
				case 'b': return NB;
				case 'd': return ND;
				case 'e': return NE;
				case 'g': return NG;
				case 'l': return NL;
				case 'n': return NN;
				case 'o': return NO;
				case 'r': return NR;
				case 'v': return NV;
				case 'y': return NY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_o(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return OC;
				case 'j': return OJ;
				case 'm': return OM;
				case 'r': return OR;
				case 's': return OS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return PA;
				case 'i': return PI;
				case 'l': return PL;
				case 's': return PS;
				case 't': return PT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_q(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return QU;
			return null;
		}
		
		private static Language? tryParse_L2_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'm': return RM;
				case 'n': return RN;
				case 'o': return RO;
				case 'u': return RU;
				case 'w': return RW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return SA;
				case 'c': return SC;
				case 'd': return SD;
				case 'e': return SE;
				case 'g': return SG;
				case 'h': return SH;
				case 'i': return SI;
				case 'k': return SK;
				case 'l': return SL;
				case 'm': return SM;
				case 'n': return SN;
				case 'o': return SO;
				case 'q': return SQ;
				case 'r': return SR;
				case 's': return SS;
				case 't': return ST;
				case 'u': return SU;
				case 'v': return SV;
				case 'w': return SW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return TA;
				case 'e': return TE;
				case 'g': return TG;
				case 'h': return TH;
				case 'i': return TI;
				case 'k': return TK;
				case 'l': return TL;
				case 'n': return TN;
				case 'o': return TO;
				case 'r': return TR;
				case 's': return TS;
				case 't': return TT;
				case 'w': return TW;
				case 'y': return TY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return UG;
				case 'k': return UK;
				case 'r': return UR;
				case 'z': return UZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return VE;
				case 'i': return VI;
				case 'o': return VO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return WA;
				case 'o': return WO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_x(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'h')
				return XH;
			return null;
		}
		
		private static Language? tryParse_L2_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return YI;
				case 'o': return YO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L2_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return ZA;
				case 'h': return ZH;
				case 'u': return ZU;
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
				case 'a': return AAA;
				case 'b': return AAB;
				case 'c': return AAC;
				case 'd': return AAD;
				case 'e': return AAE;
				case 'f': return AAF;
				case 'g': return AAG;
				case 'h': return AAH;
				case 'i': return AAI;
				case 'k': return AAK;
				case 'l': return AAL;
				case 'm': return AAS;
				case 'n': return AAN;
				case 'o': return AAO;
				case 'p': return AAP;
				case 'q': return AAQ;
				case 's': return AAS;
				case 't': return AAT;
				case 'u': return AAU;
				case 'v': return AAV;
				case 'w': return AAW;
				case 'x': return AAX;
				case 'z': return AAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ab(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ABA;
				case 'b': return ABB;
				case 'c': return ABC;
				case 'd': return ABD;
				case 'e': return ABE;
				case 'f': return ABF;
				case 'g': return ABG;
				case 'h': return ABH;
				case 'i': return ABI;
				case 'j': return ABJ;
				case 'l': return ABL;
				case 'm': return ABM;
				case 'n': return ABN;
				case 'o': return ABO;
				case 'p': return ABP;
				case 'q': return ABQ;
				case 'r': return ABR;
				case 's': return ABS;
				case 't': return ABT;
				case 'u': return ABU;
				case 'v': return ABV;
				case 'w': return ABW;
				case 'x': return ABX;
				case 'y': return ABY;
				case 'z': return ABZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ac(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ACA;
				case 'b': return ACB;
				case 'd': return ACD;
				case 'e': return ACE;
				case 'f': return ACF;
				case 'h': return ACH;
				case 'i': return ACI;
				case 'k': return ACK;
				case 'l': return ACL;
				case 'm': return ACM;
				case 'n': return ACN;
				case 'p': return ACP;
				case 'q': return ACQ;
				case 'r': return ACR;
				case 's': return ACS;
				case 't': return ACT;
				case 'u': return ACU;
				case 'v': return ACV;
				case 'w': return ACW;
				case 'x': return ACX;
				case 'y': return ACY;
				case 'z': return ACZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ad(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ADA;
				case 'b': return ADB;
				case 'd': return ADD;
				case 'e': return ADE;
				case 'f': return ADF;
				case 'g': return ADG;
				case 'h': return ADH;
				case 'i': return ADI;
				case 'j': return ADJ;
				case 'l': return ADL;
				case 'n': return ADN;
				case 'o': return ADO;
				case 'p': return DZ;
				case 'q': return ADQ;
				case 'r': return ADR;
				case 's': return ADS;
				case 't': return ADT;
				case 'u': return ADU;
				case 'w': return ADW;
				case 'x': return ADX;
				case 'y': return ADY;
				case 'z': return ADZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ae(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AEA;
				case 'b': return AEB;
				case 'c': return AEC;
				case 'd': return AED;
				case 'e': return AEE;
				case 'k': return AEK;
				case 'l': return AEL;
				case 'm': return AEM;
				case 'n': return AEN;
				case 'q': return AEQ;
				case 'r': return AER;
				case 's': return AES;
				case 'u': return AEU;
				case 'w': return AEW;
				case 'y': return AEY;
				case 'z': return AEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_af(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AFA;
				case 'b': return AFB;
				case 'd': return AFD;
				case 'e': return AFE;
				case 'g': return AFG;
				case 'h': return AFH;
				case 'i': return AFI;
				case 'k': return AFK;
				case 'n': return AFN;
				case 'o': return AFO;
				case 'p': return AFP;
				case 's': return AFS;
				case 't': return AFT;
				case 'u': return AFU;
				case 'z': return AFZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ag(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AGA;
				case 'b': return AGB;
				case 'c': return AGC;
				case 'd': return AGD;
				case 'e': return AGE;
				case 'f': return AGF;
				case 'g': return AGG;
				case 'h': return AGH;
				case 'i': return AGI;
				case 'j': return AGJ;
				case 'k': return AGK;
				case 'l': return AGL;
				case 'm': return AGM;
				case 'n': return AGN;
				case 'o': return AGO;
				case 'p': return AGP;
				case 'q': return AGQ;
				case 'r': return AGR;
				case 's': return AGS;
				case 't': return AGT;
				case 'u': return AGU;
				case 'v': return AGV;
				case 'w': return AGW;
				case 'x': return AGX;
				case 'y': return AGY;
				case 'z': return AGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ah(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AHA;
				case 'b': return AHB;
				case 'g': return AHG;
				case 'h': return AHH;
				case 'i': return AHI;
				case 'k': return AHK;
				case 'l': return AHL;
				case 'm': return AHM;
				case 'n': return AHN;
				case 'o': return AHO;
				case 'p': return AHP;
				case 'r': return AHR;
				case 's': return AHS;
				case 't': return AHT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ai(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AIA;
				case 'b': return AIB;
				case 'c': return AIC;
				case 'd': return AID;
				case 'e': return AIE;
				case 'f': return AIF;
				case 'g': return AIG;
				case 'h': return AIH;
				case 'i': return AII;
				case 'j': return AIJ;
				case 'k': return AIK;
				case 'l': return AIL;
				case 'm': return AIM;
				case 'n': return AIN;
				case 'o': return AIO;
				case 'p': return AIP;
				case 'q': return AIQ;
				case 'r': return AIR;
				case 's': return AIS;
				case 't': return AIT;
				case 'w': return AIW;
				case 'x': return AIX;
				case 'y': return AIY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AJA;
				case 'g': return AJG;
				case 'i': return AJI;
				case 'n': return AJN;
				case 'p': return AJP;
				case 't': return AJT;
				case 'u': return AJU;
				case 'w': return AJW;
				case 'z': return AJZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ak(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AKB;
				case 'c': return AKC;
				case 'd': return AKD;
				case 'e': return AKE;
				case 'f': return AKF;
				case 'g': return AKG;
				case 'h': return AKH;
				case 'i': return AKI;
				case 'j': return AKJ;
				case 'k': return AKK;
				case 'l': return AKL;
				case 'm': return AKM;
				case 'o': return AKO;
				case 'p': return AKP;
				case 'q': return AKQ;
				case 'r': return AKR;
				case 's': return AKS;
				case 't': return AKT;
				case 'u': return AKU;
				case 'v': return AKV;
				case 'w': return AKW;
				case 'x': return AKX;
				case 'y': return AKY;
				case 'z': return AKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_al(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ALA;
				case 'c': return ALC;
				case 'd': return ALD;
				case 'e': return ALE;
				case 'f': return ALF;
				case 'g': return ALG;
				case 'h': return ALH;
				case 'i': return ALI;
				case 'j': return ALJ;
				case 'k': return ALK;
				case 'l': return ALL;
				case 'm': return ALM;
				case 'n': return ALN;
				case 'o': return ALO;
				case 'p': return ALP;
				case 'q': return ALQ;
				case 'r': return ALR;
				case 's': return ALS;
				case 't': return ALT;
				case 'u': return ALU;
				case 'v': return ALV;
				case 'w': return ALW;
				case 'x': return ALX;
				case 'y': return ALY;
				case 'z': return ALZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_am(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AMA;
				case 'b': return AMB;
				case 'c': return AMC;
				case 'e': return AME;
				case 'f': return AMF;
				case 'g': return AMG;
				case 'i': return AMI;
				case 'j': return AMJ;
				case 'k': return AMK;
				case 'l': return AML;
				case 'm': return AMM;
				case 'n': return AMN;
				case 'o': return AMO;
				case 'p': return AMP;
				case 'q': return AMQ;
				case 'r': return AMR;
				case 's': return AMS;
				case 't': return AMT;
				case 'u': return AMU;
				case 'v': return AMV;
				case 'w': return AMW;
				case 'x': return AMX;
				case 'y': return AMY;
				case 'z': return AMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_an(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ANA;
				case 'b': return ANB;
				case 'c': return ANC;
				case 'd': return AND;
				case 'e': return ANE;
				case 'f': return ANF;
				case 'g': return ANG;
				case 'h': return ANH;
				case 'i': return ANI;
				case 'j': return ANJ;
				case 'k': return ANK;
				case 'l': return ANL;
				case 'm': return ANM;
				case 'n': return ANN;
				case 'o': return ANO;
				case 'p': return ANP;
				case 'q': return ANQ;
				case 'r': return ANR;
				case 's': return ANS;
				case 't': return ANT;
				case 'u': return ANU;
				case 'v': return ANV;
				case 'w': return ANW;
				case 'x': return ANX;
				case 'y': return ANY;
				case 'z': return ANZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ao(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AOA;
				case 'b': return AOB;
				case 'c': return AOC;
				case 'd': return AOD;
				case 'e': return AOE;
				case 'f': return AOF;
				case 'g': return AOG;
				case 'h': return AOH;
				case 'i': return AOI;
				case 'j': return AOJ;
				case 'k': return AOK;
				case 'l': return AOL;
				case 'm': return AOM;
				case 'n': return AON;
				case 'r': return AOR;
				case 's': return AOS;
				case 't': return AOT;
				case 'u': return AOU;
				case 'x': return AOX;
				case 'z': return AOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ap(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return APA;
				case 'b': return APB;
				case 'c': return APC;
				case 'd': return APD;
				case 'e': return APE;
				case 'f': return APF;
				case 'g': return APG;
				case 'h': return APH;
				case 'i': return API;
				case 'j': return APJ;
				case 'k': return APK;
				case 'l': return APL;
				case 'm': return APM;
				case 'n': return APN;
				case 'o': return APO;
				case 'p': return APP;
				case 'q': return APQ;
				case 'r': return APR;
				case 's': return APS;
				case 't': return APT;
				case 'u': return APU;
				case 'v': return APV;
				case 'w': return APW;
				case 'x': return APX;
				case 'y': return APY;
				case 'z': return APZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AQA;
				case 'c': return AQC;
				case 'd': return AQD;
				case 'g': return AQG;
				case 'l': return AQL;
				case 'm': return AQM;
				case 'n': return AQN;
				case 'p': return AQP;
				case 'r': return AQR;
				case 't': return AQT;
				case 'z': return AQZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ar(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ARB;
				case 'c': return ARC;
				case 'd': return ARD;
				case 'e': return ARE;
				case 'h': return ARH;
				case 'i': return ARI;
				case 'j': return ARJ;
				case 'k': return ARK;
				case 'l': return ARL;
				case 'n': return ARN;
				case 'o': return ARO;
				case 'p': return ARP;
				case 'q': return ARQ;
				case 'r': return ARR;
				case 's': return ARS;
				case 't': return ART;
				case 'u': return ARU;
				case 'v': return ARV;
				case 'w': return ARW;
				case 'x': return ARX;
				case 'y': return ARY;
				case 'z': return ARZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_as(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ASA;
				case 'b': return ASB;
				case 'c': return ASC;
				case 'd': return SNZ;
				case 'e': return ASE;
				case 'f': return ASF;
				case 'g': return ASG;
				case 'h': return ASH;
				case 'i': return ASI;
				case 'j': return ASJ;
				case 'k': return ASK;
				case 'l': return ASL;
				case 'n': return ASN;
				case 'o': return ASO;
				case 'p': return ASP;
				case 'q': return ASQ;
				case 'r': return ASR;
				case 's': return ASS;
				case 't': return AST;
				case 'u': return ASU;
				case 'v': return ASV;
				case 'w': return ASW;
				case 'x': return ASX;
				case 'y': return ASY;
				case 'z': return ASZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_at(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ATA;
				case 'b': return ATB;
				case 'c': return ATC;
				case 'd': return ATD;
				case 'e': return ATE;
				case 'g': return ATG;
				case 'h': return ATH;
				case 'i': return ATI;
				case 'j': return ATJ;
				case 'k': return ATK;
				case 'l': return ATL;
				case 'm': return ATM;
				case 'n': return ATN;
				case 'o': return ATO;
				case 'p': return ATP;
				case 'q': return ATQ;
				case 'r': return ATR;
				case 's': return ATS;
				case 't': return ATT;
				case 'u': return ATU;
				case 'v': return ATV;
				case 'w': return ATW;
				case 'x': return ATX;
				case 'y': return ATY;
				case 'z': return ATZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_au(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AUA;
				case 'b': return AUB;
				case 'c': return AUC;
				case 'd': return AUD;
				case 'e': return KTZ;
				case 'f': return AUF;
				case 'g': return AUG;
				case 'h': return AUH;
				case 'i': return AUI;
				case 'j': return AUJ;
				case 'k': return AUK;
				case 'l': return AUL;
				case 'm': return AUM;
				case 'n': return AUN;
				case 'o': return AUO;
				case 'p': return AUP;
				case 'q': return AUQ;
				case 'r': return AUR;
				case 's': return AUS;
				case 't': return AUT;
				case 'u': return AUU;
				case 'w': return AUW;
				case 'x': return AUX;
				case 'y': return AUY;
				case 'z': return AUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_av(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AVB;
				case 'd': return AVD;
				case 'i': return AVI;
				case 'k': return AVK;
				case 'l': return AVL;
				case 'm': return AVM;
				case 'n': return AVN;
				case 'o': return AVO;
				case 's': return AVS;
				case 't': return AVT;
				case 'u': return AVU;
				case 'v': return AVV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_aw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AWA;
				case 'b': return AWB;
				case 'c': return AWC;
				case 'd': return AWD;
				case 'e': return AWE;
				case 'g': return AWG;
				case 'h': return AWH;
				case 'i': return AWI;
				case 'k': return AWK;
				case 'm': return AWM;
				case 'n': return AWN;
				case 'o': return AWO;
				case 'r': return AWR;
				case 's': return AWS;
				case 't': return AWT;
				case 'u': return AWU;
				case 'v': return AWV;
				case 'w': return AWW;
				case 'x': return AWX;
				case 'y': return AWY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ax(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return AXB;
				case 'e': return AXE;
				case 'g': return AXG;
				case 'k': return AXK;
				case 'l': return AXL;
				case 'm': return AXM;
				case 'x': return AXX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ay(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AYA;
				case 'b': return AYB;
				case 'c': return AYC;
				case 'd': return AYD;
				case 'e': return AYE;
				case 'g': return AYG;
				case 'h': return AYH;
				case 'i': return AYI;
				case 'k': return AYK;
				case 'l': return AYL;
				case 'n': return AYN;
				case 'o': return AYO;
				case 'p': return AYP;
				case 'q': return AYQ;
				case 'r': return AYR;
				case 's': return AYS;
				case 't': return AYT;
				case 'u': return AYU;
				case 'x': return NUN;
				case 'y': return AYY;
				case 'z': return AYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_az(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return AZA;
				case 'b': return AZB;
				case 'c': return AZC;
				case 'd': return AZD;
				case 'g': return AZG;
				case 'j': return AZJ;
				case 'm': return AZM;
				case 'n': return AZN;
				case 'o': return AZO;
				case 't': return AZT;
				case 'z': return AZZ;
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
				case 'a': return BAA;
				case 'b': return BAB;
				case 'c': return BAC;
				case 'd': return BAD;
				case 'e': return BAE;
				case 'f': return BAF;
				case 'g': return BAG;
				case 'h': return BAH;
				case 'i': return BAI;
				case 'j': return BAJ;
				case 'l': return BAL;
				case 'n': return BAN;
				case 'o': return BAO;
				case 'p': return BAP;
				case 'r': return BAR;
				case 's': return BAS;
				case 't': return BAT;
				case 'u': return BAU;
				case 'v': return BAV;
				case 'w': return BAW;
				case 'x': return BAX;
				case 'y': return BAY;
				case 'z': return BAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BBA;
				case 'b': return BBB;
				case 'c': return BBC;
				case 'd': return BBD;
				case 'e': return BBE;
				case 'f': return BBF;
				case 'g': return BBG;
				case 'h': return BBH;
				case 'i': return BBI;
				case 'j': return BBJ;
				case 'k': return BBK;
				case 'l': return BBL;
				case 'm': return BBM;
				case 'n': return BBN;
				case 'o': return BBO;
				case 'p': return BBP;
				case 'q': return BBQ;
				case 'r': return BBR;
				case 's': return BBS;
				case 't': return BBT;
				case 'u': return BBU;
				case 'v': return BBV;
				case 'w': return BBW;
				case 'x': return BBX;
				case 'y': return BBY;
				case 'z': return BBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BCA;
				case 'b': return BCB;
				case 'c': return BCC;
				case 'd': return BCD;
				case 'e': return BCE;
				case 'f': return BCF;
				case 'g': return BCG;
				case 'h': return BCH;
				case 'i': return BCI;
				case 'j': return BCJ;
				case 'k': return BCK;
				case 'l': return BCL;
				case 'm': return BCM;
				case 'n': return BCN;
				case 'o': return BCO;
				case 'p': return BCP;
				case 'q': return BCQ;
				case 'r': return BCR;
				case 's': return BCS;
				case 't': return BCT;
				case 'u': return BCU;
				case 'v': return BCV;
				case 'w': return BCW;
				case 'y': return BCY;
				case 'z': return BCZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BDA;
				case 'b': return BDB;
				case 'c': return BDC;
				case 'd': return BDD;
				case 'e': return BDE;
				case 'f': return BDF;
				case 'g': return BDG;
				case 'h': return BDH;
				case 'i': return BDI;
				case 'j': return BDJ;
				case 'k': return BDK;
				case 'l': return BDL;
				case 'm': return BDM;
				case 'n': return BDN;
				case 'o': return BDO;
				case 'p': return BDP;
				case 'q': return BDQ;
				case 'r': return BDR;
				case 's': return BDS;
				case 't': return BDT;
				case 'u': return BDU;
				case 'v': return BDV;
				case 'w': return BDW;
				case 'x': return BDX;
				case 'y': return BDY;
				case 'z': return BDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_be(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BEA;
				case 'b': return BEB;
				case 'c': return BEC;
				case 'd': return BED;
				case 'e': return BEE;
				case 'f': return BEF;
				case 'g': return BEG;
				case 'h': return BEH;
				case 'i': return BEI;
				case 'j': return BEJ;
				case 'k': return BEK;
				case 'm': return BEM;
				case 'o': return BEO;
				case 'p': return BEP;
				case 'q': return BEQ;
				case 'r': return BER;
				case 's': return BES;
				case 't': return BET;
				case 'u': return BEU;
				case 'v': return BEV;
				case 'w': return BEW;
				case 'x': return BEX;
				case 'y': return BEY;
				case 'z': return BEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BFA;
				case 'b': return BFB;
				case 'c': return BFC;
				case 'd': return BFD;
				case 'e': return BFE;
				case 'f': return BFF;
				case 'g': return BFG;
				case 'h': return BFH;
				case 'i': return BFI;
				case 'j': return BFJ;
				case 'k': return BFK;
				case 'l': return BFL;
				case 'm': return BFM;
				case 'n': return BFN;
				case 'o': return BFO;
				case 'p': return BFP;
				case 'q': return BFQ;
				case 'r': return BFR;
				case 's': return BFS;
				case 't': return BFT;
				case 'u': return BFU;
				case 'w': return BFW;
				case 'x': return BFX;
				case 'y': return BFY;
				case 'z': return BFZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BGA;
				case 'b': return BGB;
				case 'c': return BGC;
				case 'd': return BGD;
				case 'e': return BGE;
				case 'f': return BGF;
				case 'g': return BGG;
				case 'i': return BGI;
				case 'j': return BGJ;
				case 'k': return BGK;
				case 'l': return BGL;
				case 'm': return BCG;
				case 'n': return BGN;
				case 'o': return BGO;
				case 'p': return BGP;
				case 'q': return BGQ;
				case 'r': return BGR;
				case 's': return BGS;
				case 't': return BGT;
				case 'u': return BGU;
				case 'v': return BGV;
				case 'w': return BGW;
				case 'x': return BGX;
				case 'y': return BGY;
				case 'z': return BGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BHA;
				case 'b': return BHB;
				case 'c': return BHC;
				case 'd': return BHD;
				case 'e': return BHE;
				case 'f': return BHF;
				case 'g': return BHG;
				case 'h': return BHH;
				case 'i': return BHI;
				case 'j': return BHJ;
				case 'k': return BHK;
				case 'l': return BHL;
				case 'm': return BHM;
				case 'n': return BHN;
				case 'o': return BHO;
				case 'p': return BHP;
				case 'q': return BHQ;
				case 'r': return BHR;
				case 's': return BHS;
				case 't': return BHT;
				case 'u': return BHU;
				case 'v': return BHV;
				case 'w': return BHW;
				case 'x': return BHX;
				case 'y': return BHY;
				case 'z': return BHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BIA;
				case 'b': return BIB;
				case 'c': return BIC;
				case 'd': return BID;
				case 'e': return BIE;
				case 'f': return BIF;
				case 'g': return BIG;
				case 'j': return BIJ;
				case 'k': return BIK;
				case 'l': return BIL;
				case 'm': return BIM;
				case 'n': return BIN;
				case 'o': return BIO;
				case 'p': return BIP;
				case 'q': return BIQ;
				case 'r': return BIR;
				case 't': return BIT;
				case 'u': return BIU;
				case 'v': return BIV;
				case 'w': return BIW;
				case 'x': return BIX;
				case 'y': return BIY;
				case 'z': return BIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BJA;
				case 'b': return BJB;
				case 'c': return BJC;
				case 'd': return DRL;
				case 'e': return BJE;
				case 'f': return BJF;
				case 'g': return BJG;
				case 'h': return BJH;
				case 'i': return BJI;
				case 'j': return BJJ;
				case 'k': return BJK;
				case 'l': return BJL;
				case 'm': return BJM;
				case 'n': return BJN;
				case 'o': return BJO;
				case 'p': return BJP;
				case 'q': return BJQ;
				case 'r': return BJR;
				case 's': return BJS;
				case 't': return BJT;
				case 'u': return BJU;
				case 'v': return BJV;
				case 'w': return BJW;
				case 'x': return BJX;
				case 'y': return BJY;
				case 'z': return BJZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BKA;
				case 'b': return BKB;
				case 'c': return BKC;
				case 'd': return BKD;
				case 'f': return BKF;
				case 'g': return BKG;
				case 'h': return BKH;
				case 'i': return BKI;
				case 'j': return BKJ;
				case 'k': return BKK;
				case 'l': return BKL;
				case 'm': return BKM;
				case 'n': return BKN;
				case 'o': return BKO;
				case 'p': return BKP;
				case 'q': return BKQ;
				case 'r': return BKR;
				case 's': return BKS;
				case 't': return BKT;
				case 'u': return BKU;
				case 'v': return BKV;
				case 'w': return BKW;
				case 'x': return BKX;
				case 'y': return BKY;
				case 'z': return BKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BLA;
				case 'b': return BLB;
				case 'c': return BLC;
				case 'd': return BLD;
				case 'e': return BLE;
				case 'f': return BLF;
				case 'g': return BLG;
				case 'h': return BLH;
				case 'i': return BLI;
				case 'j': return BLJ;
				case 'k': return BLK;
				case 'l': return BLL;
				case 'm': return BLM;
				case 'n': return BLN;
				case 'o': return BLO;
				case 'p': return BLP;
				case 'q': return BLQ;
				case 'r': return BLR;
				case 's': return BLS;
				case 't': return BLT;
				case 'v': return BLV;
				case 'w': return BLW;
				case 'x': return BLX;
				case 'y': return BLY;
				case 'z': return BLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BMA;
				case 'b': return BMB;
				case 'c': return BMC;
				case 'd': return BMD;
				case 'e': return BME;
				case 'f': return BMF;
				case 'g': return BMG;
				case 'h': return BMH;
				case 'i': return BMI;
				case 'j': return BMJ;
				case 'k': return BMK;
				case 'l': return BML;
				case 'm': return BMM;
				case 'n': return BMN;
				case 'o': return BMO;
				case 'p': return BMP;
				case 'q': return BMQ;
				case 'r': return BMR;
				case 's': return BMS;
				case 't': return BMT;
				case 'u': return BMU;
				case 'v': return BMV;
				case 'w': return BMW;
				case 'x': return BMX;
				case 'y': return BMY;
				case 'z': return BMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BNA;
				case 'b': return BNB;
				case 'c': return BNC;
				case 'd': return BND;
				case 'e': return BNE;
				case 'f': return BNF;
				case 'g': return BNG;
				case 'i': return BNI;
				case 'j': return BNJ;
				case 'k': return BNK;
				case 'l': return BNL;
				case 'm': return BNM;
				case 'n': return BNN;
				case 'o': return BNO;
				case 'p': return BNP;
				case 'q': return BNQ;
				case 'r': return BNR;
				case 's': return BNS;
				case 't': return BNT;
				case 'u': return BNU;
				case 'v': return BNV;
				case 'w': return BNW;
				case 'x': return BNX;
				case 'y': return BNY;
				case 'z': return BNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BOA;
				case 'b': return BOB;
				case 'e': return BOE;
				case 'f': return BOF;
				case 'g': return BOG;
				case 'h': return BOH;
				case 'i': return BOI;
				case 'j': return BOJ;
				case 'k': return BOK;
				case 'l': return BOL;
				case 'm': return BOM;
				case 'n': return BON;
				case 'o': return BOO;
				case 'p': return BOP;
				case 'q': return BOQ;
				case 'r': return BOR;
				case 't': return BOT;
				case 'u': return BOU;
				case 'v': return BOV;
				case 'w': return BOW;
				case 'x': return BOX;
				case 'y': return BOY;
				case 'z': return BOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BPA;
				case 'b': return BPB;
				case 'd': return BPD;
				case 'g': return BPG;
				case 'h': return BPH;
				case 'i': return BPI;
				case 'j': return BPJ;
				case 'k': return BPK;
				case 'l': return BPL;
				case 'm': return BPM;
				case 'n': return BPN;
				case 'o': return BPO;
				case 'p': return BPP;
				case 'q': return BPQ;
				case 'r': return BPR;
				case 's': return BPS;
				case 't': return BPT;
				case 'u': return BPU;
				case 'v': return BPV;
				case 'w': return BPW;
				case 'x': return BPX;
				case 'y': return BPY;
				case 'z': return BPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BQA;
				case 'b': return BQB;
				case 'c': return BQC;
				case 'd': return BQD;
				case 'f': return BQF;
				case 'g': return BQG;
				case 'h': return BQH;
				case 'i': return BQI;
				case 'j': return BQJ;
				case 'k': return BQK;
				case 'l': return BQL;
				case 'm': return BQM;
				case 'n': return BQN;
				case 'o': return BQO;
				case 'p': return BQP;
				case 'q': return BQQ;
				case 'r': return BQR;
				case 's': return BQS;
				case 't': return BQT;
				case 'u': return BQU;
				case 'v': return BQV;
				case 'w': return BQW;
				case 'x': return BQX;
				case 'y': return BQY;
				case 'z': return BQZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_br(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BRA;
				case 'b': return BRB;
				case 'c': return BRC;
				case 'd': return BRD;
				case 'f': return BRF;
				case 'g': return BRG;
				case 'h': return BRH;
				case 'i': return BRI;
				case 'j': return BRJ;
				case 'k': return BRK;
				case 'l': return BRL;
				case 'm': return BRM;
				case 'n': return BRN;
				case 'o': return BRO;
				case 'p': return BRP;
				case 'q': return BRQ;
				case 'r': return BRR;
				case 's': return BRS;
				case 't': return BRT;
				case 'u': return BRU;
				case 'v': return BRV;
				case 'w': return BRW;
				case 'x': return BRX;
				case 'y': return BRY;
				case 'z': return BRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BSA;
				case 'b': return BSB;
				case 'c': return BSC;
				case 'e': return BSE;
				case 'f': return BSF;
				case 'g': return BSG;
				case 'h': return BSH;
				case 'i': return BSI;
				case 'j': return BSJ;
				case 'k': return BSK;
				case 'l': return BSL;
				case 'm': return BSM;
				case 'n': return BSN;
				case 'o': return BSO;
				case 'p': return BSP;
				case 'q': return BSQ;
				case 'r': return BSR;
				case 's': return BSS;
				case 't': return BST;
				case 'u': return BSU;
				case 'v': return BSV;
				case 'w': return BSW;
				case 'x': return BSX;
				case 'y': return BSY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BTA;
				case 'b': return BTB;
				case 'c': return BTC;
				case 'd': return BTD;
				case 'e': return BTE;
				case 'f': return BTF;
				case 'g': return BTG;
				case 'h': return BTH;
				case 'i': return BTI;
				case 'j': return BTJ;
				case 'k': return BTK;
				case 'l': return BTL;
				case 'm': return BTM;
				case 'n': return BTN;
				case 'o': return BTO;
				case 'p': return BTP;
				case 'q': return BTQ;
				case 'r': return BTR;
				case 's': return BTS;
				case 't': return BTT;
				case 'u': return BTU;
				case 'v': return BTV;
				case 'w': return BTW;
				case 'x': return BTX;
				case 'y': return BTY;
				case 'z': return BTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BUA;
				case 'b': return BUB;
				case 'c': return BUC;
				case 'd': return BUD;
				case 'e': return BUE;
				case 'f': return BUF;
				case 'g': return BUG;
				case 'h': return BUH;
				case 'i': return BUI;
				case 'j': return BUJ;
				case 'k': return BUK;
				case 'm': return BUM;
				case 'n': return BUN;
				case 'o': return BUO;
				case 'p': return BUP;
				case 'q': return BUQ;
				case 's': return BUS;
				case 't': return BUT;
				case 'u': return BUU;
				case 'v': return BUV;
				case 'w': return BUW;
				case 'x': return BUX;
				case 'y': return BUY;
				case 'z': return BUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BVA;
				case 'b': return BVB;
				case 'c': return BVC;
				case 'd': return BVD;
				case 'e': return BVE;
				case 'f': return BVF;
				case 'g': return BVG;
				case 'h': return BVH;
				case 'i': return BVI;
				case 'j': return BVJ;
				case 'k': return BVK;
				case 'l': return BVL;
				case 'm': return BVM;
				case 'n': return BVN;
				case 'o': return BVO;
				case 'p': return BVP;
				case 'q': return BVQ;
				case 'r': return BVR;
				case 't': return BVT;
				case 'u': return BVU;
				case 'v': return BVV;
				case 'w': return BVW;
				case 'x': return BVX;
				case 'y': return BVY;
				case 'z': return BVZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BWA;
				case 'b': return BWB;
				case 'c': return BWC;
				case 'd': return BWD;
				case 'e': return BWE;
				case 'f': return BWF;
				case 'g': return BWG;
				case 'h': return BWH;
				case 'i': return BWI;
				case 'j': return BWJ;
				case 'k': return BWK;
				case 'l': return BWL;
				case 'm': return BWM;
				case 'n': return BWN;
				case 'o': return BWO;
				case 'p': return BWP;
				case 'q': return BWQ;
				case 'r': return BWR;
				case 's': return BWS;
				case 't': return BWT;
				case 'u': return BWU;
				case 'w': return BWW;
				case 'x': return BWX;
				case 'y': return BWY;
				case 'z': return BWZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BXA;
				case 'b': return BXB;
				case 'c': return BXC;
				case 'd': return BXD;
				case 'e': return BXE;
				case 'f': return BXF;
				case 'g': return BXG;
				case 'h': return BXH;
				case 'i': return BXI;
				case 'j': return BXJ;
				case 'k': return BXK;
				case 'l': return BXL;
				case 'm': return BXM;
				case 'n': return BXN;
				case 'o': return BXO;
				case 'p': return BXP;
				case 'q': return BXQ;
				case 'r': return BXR;
				case 's': return BXS;
				case 'u': return BXU;
				case 'v': return BXV;
				case 'w': return BXW;
				case 'x': return BXX;
				case 'z': return BXZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_by(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BYA;
				case 'b': return BYB;
				case 'c': return BYC;
				case 'd': return BYD;
				case 'e': return BYE;
				case 'f': return BYF;
				case 'g': return BYG;
				case 'h': return BYH;
				case 'i': return BYI;
				case 'j': return BYJ;
				case 'k': return BYK;
				case 'l': return BYL;
				case 'm': return BYM;
				case 'n': return BYN;
				case 'o': return BYO;
				case 'p': return BYP;
				case 'q': return BYQ;
				case 'r': return BYR;
				case 's': return BYS;
				case 't': return BYT;
				case 'v': return BYV;
				case 'w': return BYW;
				case 'x': return BYX;
				case 'y': return BYY;
				case 'z': return BYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_bz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BZA;
				case 'b': return BZB;
				case 'c': return BZC;
				case 'd': return BZD;
				case 'e': return BZE;
				case 'f': return BZF;
				case 'g': return BZG;
				case 'h': return BZH;
				case 'i': return BZI;
				case 'j': return BZJ;
				case 'k': return BZK;
				case 'l': return BZL;
				case 'm': return BZM;
				case 'n': return BZN;
				case 'o': return BZO;
				case 'p': return BZP;
				case 'q': return BZQ;
				case 'r': return BZR;
				case 's': return BZS;
				case 't': return BZT;
				case 'u': return BZU;
				case 'v': return BZV;
				case 'w': return BZW;
				case 'x': return BZX;
				case 'y': return BZY;
				case 'z': return BZZ;
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
				case 'y': return tryParse_L3_cy(span);
				case 'z': return tryParse_L3_cz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ca(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CAA;
				case 'b': return CAB;
				case 'c': return CAC;
				case 'd': return CAD;
				case 'e': return CAE;
				case 'f': return CAF;
				case 'g': return CAG;
				case 'h': return CAH;
				case 'i': return CAI;
				case 'j': return CAJ;
				case 'k': return CAK;
				case 'l': return CAL;
				case 'm': return CAM;
				case 'n': return CAN;
				case 'o': return CAO;
				case 'p': return CAP;
				case 'q': return CAQ;
				case 'r': return CAR;
				case 's': return CAS;
				case 'u': return CAU;
				case 'v': return CAV;
				case 'w': return CAW;
				case 'x': return CAX;
				case 'y': return CAY;
				case 'z': return CAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CBA;
				case 'b': return CBB;
				case 'c': return CBC;
				case 'd': return CBD;
				case 'e': return CBE;
				case 'g': return CBG;
				case 'h': return CBH;
				case 'i': return CBI;
				case 'j': return CBJ;
				case 'k': return CBK;
				case 'l': return CBL;
				case 'n': return CBN;
				case 'o': return CBO;
				case 'q': return CBQ;
				case 'r': return CBR;
				case 's': return CBS;
				case 't': return CBT;
				case 'u': return CBU;
				case 'v': return CBV;
				case 'w': return CBW;
				case 'y': return CBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CCA;
				case 'c': return CCC;
				case 'd': return CCD;
				case 'e': return CCE;
				case 'g': return CCG;
				case 'h': return CCH;
				case 'j': return CCJ;
				case 'l': return CCL;
				case 'm': return CCM;
				case 'n': return CCN;
				case 'o': return CCO;
				case 'p': return CCP;
				case 'q': return RKI;
				case 'r': return CCR;
				case 's': return CCS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CDA;
				case 'c': return CDC;
				case 'd': return CDD;
				case 'e': return CDE;
				case 'f': return CDF;
				case 'g': return CDG;
				case 'h': return CDH;
				case 'i': return CDI;
				case 'j': return CDJ;
				case 'm': return CDM;
				case 'n': return CDN;
				case 'o': return CDO;
				case 'r': return CDR;
				case 's': return CDS;
				case 'y': return CDY;
				case 'z': return CDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ce(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CEA;
				case 'b': return CEB;
				case 'g': return CEG;
				case 'k': return CEK;
				case 'l': return CEL;
				case 'n': return CEN;
				case 't': return CET;
				case 'y': return CEY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CFA;
				case 'd': return CFD;
				case 'g': return CFG;
				case 'm': return CFM;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CGA;
				case 'c': return CGC;
				case 'g': return CGG;
				case 'k': return CGK;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ch(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return CHB;
				case 'c': return CHC;
				case 'd': return CHD;
				case 'f': return CHF;
				case 'g': return CHG;
				case 'h': return CHH;
				case 'j': return CHJ;
				case 'k': return CHK;
				case 'l': return CHL;
				case 'm': return CHM;
				case 'n': return CHN;
				case 'o': return CHO;
				case 'p': return CHP;
				case 'q': return CHQ;
				case 'r': return CHR;
				case 't': return CHT;
				case 'w': return CHW;
				case 'x': return CHX;
				case 'y': return CHY;
				case 'z': return CHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ci(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CIA;
				case 'b': return CIB;
				case 'c': return CIC;
				case 'd': return CID;
				case 'e': return CIE;
				case 'h': return CIH;
				case 'k': return CIK;
				case 'm': return CIM;
				case 'n': return CIN;
				case 'p': return CIP;
				case 'r': return CIR;
				case 'w': return CIW;
				case 'y': return CIY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CJA;
				case 'e': return CJE;
				case 'h': return CJH;
				case 'i': return CJI;
				case 'k': return CJK;
				case 'm': return CJM;
				case 'n': return CJN;
				case 'o': return CJO;
				case 'p': return CJP;
				case 'r': return MOM;
				case 's': return CJS;
				case 'v': return CJV;
				case 'y': return CJY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ck(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CMR;
				case 'b': return CKB;
				case 'h': return CKH;
				case 'l': return CKL;
				case 'm': return CKM;
				case 'n': return CKN;
				case 'o': return CKO;
				case 'q': return CKQ;
				case 'r': return CKR;
				case 's': return CKS;
				case 't': return CKT;
				case 'u': return CKU;
				case 'v': return CKV;
				case 'x': return CKX;
				case 'y': return CKY;
				case 'z': return CKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CLA;
				case 'c': return CLC;
				case 'd': return CLD;
				case 'e': return CLE;
				case 'h': return CLH;
				case 'i': return CLI;
				case 'j': return CLJ;
				case 'k': return CLK;
				case 'l': return CLL;
				case 'm': return CLM;
				case 'o': return CLO;
				case 't': return CLT;
				case 'u': return CLU;
				case 'w': return CLW;
				case 'y': return CLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CMA;
				case 'c': return CMC;
				case 'e': return CME;
				case 'g': return CMG;
				case 'i': return CMI;
				case 'k': return XCH;
				case 'l': return CML;
				case 'm': return CMM;
				case 'n': return CMN;
				case 'o': return CMO;
				case 'r': return CMR;
				case 's': return CMS;
				case 't': return CMT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CNA;
				case 'b': return CNB;
				case 'c': return CNC;
				case 'g': return CNG;
				case 'h': return CNH;
				case 'i': return CNI;
				case 'k': return CNK;
				case 'l': return CNL;
				case 'o': return CNO;
				case 'p': return CNP;
				case 'r': return CNR;
				case 's': return CNS;
				case 't': return CNT;
				case 'u': return CNU;
				case 'w': return CNW;
				case 'x': return CNX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_co(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return COA;
				case 'b': return COB;
				case 'c': return COC;
				case 'd': return COD;
				case 'e': return COE;
				case 'f': return COF;
				case 'g': return COG;
				case 'h': return COH;
				case 'j': return COJ;
				case 'k': return COK;
				case 'l': return COL;
				case 'm': return COM;
				case 'n': return CON;
				case 'o': return COO;
				case 'p': return COP;
				case 'q': return COQ;
				case 't': return COT;
				case 'u': return COU;
				case 'v': return COV;
				case 'w': return COW;
				case 'x': return COX;
				case 'y': return PIJ;
				case 'z': return COZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CPA;
				case 'b': return CPB;
				case 'c': return CPC;
				case 'e': return CPE;
				case 'f': return CPF;
				case 'g': return CPG;
				case 'i': return CPI;
				case 'n': return CPN;
				case 'o': return CPO;
				case 'p': return CPP;
				case 's': return CPS;
				case 'u': return CPU;
				case 'x': return CPX;
				case 'y': return CPY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cq(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return CQD;
				case 'u': return QUH;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CRA;
				case 'b': return CRB;
				case 'c': return CRC;
				case 'd': return CRD;
				case 'f': return CRF;
				case 'g': return CRG;
				case 'h': return CRH;
				case 'i': return CRI;
				case 'j': return CRJ;
				case 'k': return CRK;
				case 'l': return CRL;
				case 'm': return CRM;
				case 'n': return CRN;
				case 'o': return CRO;
				case 'p': return CRP;
				case 'q': return CRQ;
				case 'r': return CRR;
				case 's': return CRS;
				case 't': return CRT;
				case 'v': return CRV;
				case 'w': return CRW;
				case 'x': return CRX;
				case 'y': return CRY;
				case 'z': return CRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CSA;
				case 'b': return CSB;
				case 'c': return CSC;
				case 'd': return CSD;
				case 'e': return CSE;
				case 'f': return CSF;
				case 'g': return CSG;
				case 'h': return CSH;
				case 'i': return CSI;
				case 'j': return CSJ;
				case 'k': return CSK;
				case 'l': return CSL;
				case 'm': return CSM;
				case 'n': return CSN;
				case 'o': return CSO;
				case 'p': return CSP;
				case 'q': return CSQ;
				case 'r': return CSR;
				case 's': return CSS;
				case 't': return CST;
				case 'u': return CSU;
				case 'v': return CSV;
				case 'w': return CSW;
				case 'y': return CSY;
				case 'z': return CSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ct(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CTA;
				case 'c': return CTC;
				case 'd': return CTD;
				case 'e': return CTE;
				case 'g': return CTG;
				case 'h': return CTH;
				case 'l': return CTL;
				case 'm': return CTM;
				case 'n': return CTN;
				case 'o': return CTO;
				case 'p': return CTP;
				case 's': return CTS;
				case 't': return CTT;
				case 'u': return CTU;
				case 'z': return CTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CUA;
				case 'b': return CUB;
				case 'c': return CUC;
				case 'g': return CUG;
				case 'h': return CUH;
				case 'i': return CUI;
				case 'j': return CUJ;
				case 'k': return CUK;
				case 'l': return CUL;
				case 'm': return CUM;
				case 'o': return CUO;
				case 'p': return CUP;
				case 'q': return CUQ;
				case 'r': return CUR;
				case 's': return CUS;
				case 't': return CUT;
				case 'u': return CUU;
				case 'v': return CUV;
				case 'w': return CUW;
				case 'x': return CUX;
				case 'y': return CUY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cv(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return CVG;
				case 'n': return CVN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CWA;
				case 'b': return CWB;
				case 'd': return CWD;
				case 'e': return CWE;
				case 'g': return CWG;
				case 't': return CWT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CYA;
				case 'b': return CYB;
				case 'o': return CYO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_cz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return CZH;
				case 'k': return CZK;
				case 'n': return CZN;
				case 'o': return CZO;
				case 't': return CZT;
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
				case 'a': return DAA;
				case 'c': return DAC;
				case 'd': return DAD;
				case 'e': return DAE;
				case 'f': return DAF;
				case 'g': return DAG;
				case 'h': return DAH;
				case 'i': return DAI;
				case 'j': return DAJ;
				case 'k': return DAK;
				case 'l': return DAL;
				case 'm': return DAM;
				case 'o': return DAO;
				case 'p': return DAP;
				case 'q': return DAQ;
				case 'r': return DAR;
				case 's': return DAS;
				case 'u': return DAU;
				case 'v': return DAV;
				case 'w': return DAW;
				case 'x': return DAX;
				case 'y': return DAY;
				case 'z': return DAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_db(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DBA;
				case 'b': return DBB;
				case 'd': return DBD;
				case 'e': return DBE;
				case 'f': return DBF;
				case 'g': return DBG;
				case 'i': return DBI;
				case 'j': return DBJ;
				case 'l': return DBL;
				case 'm': return DBM;
				case 'n': return DBN;
				case 'o': return DBO;
				case 'p': return DBP;
				case 'q': return DBQ;
				case 'r': return DBR;
				case 't': return DBT;
				case 'u': return DBU;
				case 'v': return DBV;
				case 'w': return DBW;
				case 'y': return DBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return DCC;
				case 'r': return DCR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DDA;
				case 'd': return DDD;
				case 'e': return DDE;
				case 'g': return DDG;
				case 'i': return DDI;
				case 'j': return DDJ;
				case 'n': return DDN;
				case 'o': return DDO;
				case 'r': return DDR;
				case 's': return DDS;
				case 'w': return DDW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_de(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return DEC;
				case 'd': return DED;
				case 'e': return DEE;
				case 'f': return DEF;
				case 'g': return DEG;
				case 'h': return DEH;
				case 'i': return DEI;
				case 'k': return DEK;
				case 'l': return DEL;
				case 'm': return DEM;
				case 'n': return DEN;
				case 'p': return DEP;
				case 'q': return DEQ;
				case 'r': return DER;
				case 's': return DES;
				case 'v': return DEV;
				case 'z': return DEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DGA;
				case 'b': return DGB;
				case 'c': return DGC;
				case 'd': return DGD;
				case 'e': return DGE;
				case 'g': return DGG;
				case 'h': return DGH;
				case 'i': return DGI;
				case 'k': return DGK;
				case 'l': return DGL;
				case 'n': return DGN;
				case 'o': return DGO;
				case 'r': return DGR;
				case 's': return DGS;
				case 't': return DGT;
				case 'u': return DGU;
				case 'w': return DGW;
				case 'x': return DGX;
				case 'z': return DGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DHA;
				case 'd': return DHD;
				case 'g': return DHG;
				case 'i': return DHI;
				case 'l': return DHL;
				case 'm': return DHM;
				case 'n': return DHN;
				case 'o': return DHO;
				case 'r': return DHR;
				case 's': return DHS;
				case 'u': return DHU;
				case 'v': return DHV;
				case 'w': return DHW;
				case 'x': return DHX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_di(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DIA;
				case 'b': return DIB;
				case 'c': return DIC;
				case 'd': return DID;
				case 'f': return DIF;
				case 'g': return DIG;
				case 'h': return DIH;
				case 'i': return DII;
				case 'j': return DIJ;
				case 'k': return DIK;
				case 'l': return DIL;
				case 'm': return DIM;
				case 'n': return DIN;
				case 'o': return DIO;
				case 'p': return DIP;
				case 'q': return DIQ;
				case 'r': return DIR;
				case 's': return DIS;
				case 't': return DIF;
				case 'u': return DIU;
				case 'w': return DIW;
				case 'x': return DIX;
				case 'y': return DIY;
				case 'z': return DIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DJA;
				case 'b': return DJB;
				case 'c': return DJC;
				case 'd': return DJD;
				case 'e': return DJE;
				case 'f': return DJF;
				case 'i': return DJI;
				case 'j': return DJJ;
				case 'k': return DJK;
				case 'l': return DJL;
				case 'm': return DJM;
				case 'n': return DJN;
				case 'o': return DJO;
				case 'r': return DJR;
				case 'u': return DJU;
				case 'w': return DJW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DKA;
				case 'k': return DKK;
				case 'l': return DKL;
				case 'r': return DKR;
				case 's': return DKS;
				case 'x': return DKX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dl(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return DLG;
				case 'k': return DLK;
				case 'm': return DLM;
				case 'n': return DLN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DMA;
				case 'b': return DMB;
				case 'c': return DMC;
				case 'd': return DMD;
				case 'e': return DME;
				case 'f': return DMF;
				case 'g': return DMG;
				case 'k': return DMK;
				case 'l': return DML;
				case 'm': return DMM;
				case 'n': return DMN;
				case 'o': return DMO;
				case 'r': return DMR;
				case 's': return DMS;
				case 'u': return DMU;
				case 'v': return DMV;
				case 'w': return DMW;
				case 'x': return DMX;
				case 'y': return DMY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DNA;
				case 'd': return DND;
				case 'e': return DNE;
				case 'g': return DNG;
				case 'i': return DNI;
				case 'j': return DNJ;
				case 'k': return DNK;
				case 'n': return DNN;
				case 'o': return DNO;
				case 'r': return DNR;
				case 't': return DNT;
				case 'u': return DNU;
				case 'v': return DNV;
				case 'w': return DNW;
				case 'y': return DNY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_do(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DOA;
				case 'b': return DOB;
				case 'c': return DOC;
				case 'e': return DOE;
				case 'f': return DOF;
				case 'h': return DOH;
				case 'i': return DOI;
				case 'k': return DOK;
				case 'l': return DOL;
				case 'n': return DON;
				case 'o': return DOO;
				case 'p': return DOP;
				case 'q': return DOQ;
				case 'r': return DOR;
				case 's': return DOS;
				case 't': return DOT;
				case 'v': return DOV;
				case 'w': return DOW;
				case 'x': return DOX;
				case 'y': return DOY;
				case 'z': return DOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return DPP;
			return null;
		}
		
		private static Language? tryParse_L3_dr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DRA;
				case 'b': return DRB;
				case 'c': return DRC;
				case 'd': return DRD;
				case 'e': return DRE;
				case 'g': return DRG;
				case 'h': return KHK;
				case 'i': return DRI;
				case 'l': return DRL;
				case 'n': return DRN;
				case 'o': return DRO;
				case 'q': return DRQ;
				case 'r': return KZK;
				case 's': return DRS;
				case 't': return DRT;
				case 'u': return DRU;
				case 'w': return PRS;
				case 'y': return DRY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ds(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return DSB;
				case 'e': return DSE;
				case 'h': return DSH;
				case 'i': return DSI;
				case 'l': return DSL;
				case 'n': return DSN;
				case 'o': return DSO;
				case 'q': return DSQ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DTA;
				case 'b': return DTB;
				case 'd': return DTD;
				case 'h': return DTH;
				case 'i': return DTI;
				case 'k': return DTK;
				case 'm': return DTM;
				case 'n': return DTN;
				case 'o': return DTO;
				case 'p': return DTP;
				case 'r': return DTR;
				case 's': return DTS;
				case 't': return DTT;
				case 'u': return DTU;
				case 'y': return DTY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_du(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DUA;
				case 'b': return DUB;
				case 'c': return DUC;
				case 'd': return DUD;
				case 'e': return DUE;
				case 'f': return DUF;
				case 'g': return DUG;
				case 'h': return DUH;
				case 'i': return DUI;
				case 'j': return DUJ;
				case 'k': return DUK;
				case 'l': return DUL;
				case 'm': return DUM;
				case 'n': return DUN;
				case 'o': return DUO;
				case 'p': return DUP;
				case 'q': return DUQ;
				case 'r': return DUR;
				case 's': return DUS;
				case 'u': return DUU;
				case 'v': return DUV;
				case 'w': return DUW;
				case 'x': return DUX;
				case 'y': return DUY;
				case 'z': return DUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return DVA;
			return null;
		}
		
		private static Language? tryParse_L3_dw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DWA;
				case 'k': return DWK;
				case 'l': return DWL;
				case 'r': return DWR;
				case 's': return DWS;
				case 'u': return DWU;
				case 'w': return DWW;
				case 'y': return DWY;
				case 'z': return DWZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DYA;
				case 'b': return DYB;
				case 'd': return DYD;
				case 'g': return DYG;
				case 'i': return DYI;
				case 'm': return DYM;
				case 'n': return DYN;
				case 'o': return DYO;
				case 'u': return DYU;
				case 'y': return DYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_dz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return DZA;
				case 'd': return DZD;
				case 'e': return DZE;
				case 'g': return DZG;
				case 'l': return DZL;
				case 'n': return DZN;
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
				return EAA;
			return null;
		}
		
		private static Language? tryParse_L3_eb(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return EBC;
				case 'g': return EBG;
				case 'k': return EBK;
				case 'o': return EBO;
				case 'r': return EBR;
				case 'u': return EBU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ec(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return ECR;
				case 's': return ECS;
				case 'y': return ECY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ee(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return EEE;
			return null;
		}
		
		private static Language? tryParse_L3_ef(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EFA;
				case 'e': return EFE;
				case 'i': return EFI;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EGA;
				case 'l': return EGL;
				case 'o': return EGO;
				case 'x': return EGX;
				case 'y': return EGY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return EHU;
			return null;
		}
		
		private static Language? tryParse_L3_ei(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return EIP;
				case 't': return EIT;
				case 'v': return EIV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ej(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return EJA;
			return null;
		}
		
		private static Language? tryParse_L3_ek(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EKA;
				case 'c': return EKC;
				case 'e': return EKE;
				case 'g': return EKG;
				case 'i': return EKI;
				case 'k': return EKK;
				case 'l': return EKL;
				case 'm': return EKM;
				case 'o': return EKO;
				case 'p': return EKP;
				case 'r': return EKR;
				case 'y': return EKY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_el(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ELE;
				case 'h': return ELH;
				case 'i': return ELI;
				case 'k': return ELK;
				case 'm': return ELM;
				case 'o': return ELO;
				case 'p': return ELP;
				case 'u': return ELU;
				case 'x': return ELX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_em(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EMA;
				case 'b': return EMB;
				case 'e': return EME;
				case 'g': return EMG;
				case 'i': return EMI;
				case 'k': return EMK;
				case 'm': return EMM;
				case 'n': return EMN;
				case 'o': return EMO;
				case 'p': return EMP;
				case 's': return EMS;
				case 'u': return EMU;
				case 'w': return EMW;
				case 'x': return EMX;
				case 'y': return EMY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_en(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ENA;
				case 'b': return ENB;
				case 'c': return ENC;
				case 'd': return END;
				case 'f': return ENF;
				case 'h': return ENH;
				case 'l': return ENL;
				case 'm': return ENM;
				case 'n': return ENN;
				case 'o': return ENO;
				case 'q': return ENQ;
				case 'r': return ENR;
				case 'u': return ENU;
				case 'v': return ENV;
				case 'w': return ENW;
				case 'x': return ENX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return EOT;
			return null;
		}
		
		private static Language? tryParse_L3_ep(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return EPI;
			return null;
		}
		
		private static Language? tryParse_L3_er(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ERA;
				case 'g': return ERG;
				case 'h': return ERH;
				case 'i': return ERI;
				case 'k': return ERK;
				case 'o': return ERO;
				case 'r': return ERR;
				case 's': return ERS;
				case 't': return ERT;
				case 'w': return ERW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_es(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ESE;
				case 'g': return ESG;
				case 'h': return ESH;
				case 'i': return ESI;
				case 'k': return ESK;
				case 'l': return ESL;
				case 'm': return ESM;
				case 'n': return ESN;
				case 'o': return ESO;
				case 'q': return ESQ;
				case 's': return ESS;
				case 'u': return ESU;
				case 'x': return ESX;
				case 'y': return ESY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_et(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ETB;
				case 'c': return ETC;
				case 'h': return ETH;
				case 'n': return ETN;
				case 'o': return ETO;
				case 'r': return ETR;
				case 's': return ETS;
				case 't': return ETT;
				case 'u': return ETU;
				case 'x': return ETX;
				case 'z': return ETZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_eu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'q')
				return EUQ;
			return null;
		}
		
		private static Language? tryParse_L3_ev(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return EVE;
				case 'h': return EVH;
				case 'n': return EVN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ew(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return EWO;
			return null;
		}
		
		private static Language? tryParse_L3_ex(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return EXT;
			return null;
		}
		
		private static Language? tryParse_L3_ey(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EYA;
				case 'o': return EYO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ez(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return EZA;
				case 'e': return EZE;
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
				case 'a': return FAA;
				case 'b': return FAB;
				case 'd': return FAD;
				case 'f': return FAF;
				case 'g': return FAG;
				case 'h': return FAH;
				case 'i': return FAI;
				case 'j': return FAJ;
				case 'k': return FAK;
				case 'l': return FAL;
				case 'm': return FAM;
				case 'n': return FAN;
				case 'p': return FAP;
				case 'r': return FAR;
				case 't': return FAT;
				case 'u': return FAU;
				case 'x': return FAX;
				case 'y': return FAY;
				case 'z': return FAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return FBL;
			return null;
		}
		
		private static Language? tryParse_L3_fc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return FCS;
			return null;
		}
		
		private static Language? tryParse_L3_fe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FER;
			return null;
		}
		
		private static Language? tryParse_L3_ff(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return FFI;
				case 'm': return FFM;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FGR;
			return null;
		}
		
		private static Language? tryParse_L3_fi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FIA;
				case 'e': return FIE;
				case 'f': return FIF;
				case 'l': return FIL;
				case 'p': return FIP;
				case 'r': return FIR;
				case 't': return FIT;
				case 'u': return FIU;
				case 'w': return FIW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fk(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return FKK;
				case 'v': return FKV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FLA;
				case 'h': return FLH;
				case 'i': return FLI;
				case 'l': return FLL;
				case 'n': return FLN;
				case 'r': return FLR;
				case 'y': return FLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fm(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return FMP;
				case 'u': return FMU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return FNB;
				case 'g': return FNG;
				case 'i': return FNI;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fo(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return FOD;
				case 'i': return FOI;
				case 'm': return FOM;
				case 'n': return FON;
				case 'r': return FOR;
				case 's': return FOS;
				case 'x': return FOX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return FPE;
			return null;
		}
		
		private static Language? tryParse_L3_fq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return FQS;
			return null;
		}
		
		private static Language? tryParse_L3_fr(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return FRC;
				case 'd': return FRD;
				case 'k': return FRK;
				case 'm': return FRM;
				case 'o': return FRO;
				case 'p': return FRP;
				case 'q': return FRQ;
				case 'r': return FRR;
				case 's': return FRS;
				case 't': return FRT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return FSE;
				case 'l': return FSL;
				case 's': return FSS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fu(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return FUB;
				case 'c': return FUC;
				case 'd': return FUD;
				case 'e': return FUE;
				case 'f': return FUF;
				case 'h': return FUH;
				case 'i': return FUI;
				case 'j': return FUJ;
				case 'm': return FUM;
				case 'n': return FUN;
				case 'q': return FUQ;
				case 'r': return FUR;
				case 't': return FUT;
				case 'u': return FUU;
				case 'v': return FUV;
				case 'y': return FUY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_fv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return FVR;
			return null;
		}
		
		private static Language? tryParse_L3_fw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return FWA;
				case 'e': return FWE;
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
				case 'a': return GAA;
				case 'b': return GAB;
				case 'c': return GAC;
				case 'd': return GAD;
				case 'e': return GAE;
				case 'f': return GAF;
				case 'g': return GAG;
				case 'h': return GAH;
				case 'i': return GAI;
				case 'j': return GAJ;
				case 'k': return GAK;
				case 'l': return GAL;
				case 'm': return GAM;
				case 'n': return GAN;
				case 'o': return GAO;
				case 'p': return GAP;
				case 'q': return GAQ;
				case 'r': return GAR;
				case 's': return GAS;
				case 't': return GAT;
				case 'u': return GAU;
				case 'v': return DEV;
				case 'w': return GAW;
				case 'x': return GAX;
				case 'y': return GAY;
				case 'z': return GAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GBA;
				case 'b': return GBB;
				case 'c': return GBC;
				case 'd': return GBD;
				case 'e': return GBE;
				case 'f': return GBF;
				case 'g': return GBG;
				case 'h': return GBH;
				case 'i': return GBI;
				case 'j': return GBJ;
				case 'k': return GBK;
				case 'l': return GBL;
				case 'm': return GBM;
				case 'n': return GBN;
				case 'o': return GBO;
				case 'p': return GBP;
				case 'q': return GBQ;
				case 'r': return GBR;
				case 's': return GBS;
				case 'u': return GBU;
				case 'v': return GBV;
				case 'w': return GBW;
				case 'x': return GBX;
				case 'y': return GBY;
				case 'z': return GBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return GCC;
				case 'd': return GCD;
				case 'e': return GCE;
				case 'f': return GCF;
				case 'l': return GCL;
				case 'n': return GCN;
				case 'r': return GCR;
				case 't': return GCT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GDA;
				case 'b': return GDB;
				case 'c': return GDC;
				case 'd': return GDD;
				case 'e': return GDE;
				case 'f': return GDF;
				case 'g': return GDG;
				case 'h': return GDH;
				case 'i': return GDI;
				case 'j': return GDJ;
				case 'k': return GDK;
				case 'l': return GDL;
				case 'm': return GDM;
				case 'n': return GDN;
				case 'o': return GDO;
				case 'q': return GDQ;
				case 'r': return GDR;
				case 's': return GDS;
				case 't': return GDT;
				case 'u': return GDU;
				case 'x': return GDX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ge(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GEA;
				case 'b': return GEB;
				case 'c': return GEC;
				case 'd': return GED;
				case 'f': return GEF;
				case 'g': return GEG;
				case 'h': return GEH;
				case 'i': return GEI;
				case 'j': return GEJ;
				case 'k': return GEK;
				case 'l': return GEL;
				case 'm': return GEM;
				case 'q': return GEQ;
				case 's': return GES;
				case 'v': return GEV;
				case 'w': return GEW;
				case 'x': return GEX;
				case 'y': return GEY;
				case 'z': return GEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gf(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return GFK;
				case 't': return GFT;
				case 'x': return VAJ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GGA;
				case 'b': return GGB;
				case 'd': return GGD;
				case 'e': return GGE;
				case 'g': return GGG;
				case 'k': return GGK;
				case 'l': return GGL;
				case 'n': return GVR;
				case 'o': return GGO;
				case 'r': return GGR;
				case 't': return GGT;
				case 'u': return GGU;
				case 'w': return GGW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GHA;
				case 'c': return GHC;
				case 'e': return GHE;
				case 'h': return GHH;
				case 'k': return GHK;
				case 'l': return GHL;
				case 'n': return GHN;
				case 'o': return GHO;
				case 'r': return GHR;
				case 's': return GHS;
				case 't': return GHT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GIA;
				case 'b': return GIB;
				case 'c': return GIC;
				case 'd': return GID;
				case 'e': return GIE;
				case 'g': return GIG;
				case 'h': return GIH;
				case 'l': return GIL;
				case 'm': return GIM;
				case 'n': return GIN;
				case 'o': return GIO;
				case 'p': return GIP;
				case 'q': return GIQ;
				case 'r': return GIR;
				case 's': return GIS;
				case 't': return GIT;
				case 'u': return GIU;
				case 'w': return GIW;
				case 'x': return GIX;
				case 'y': return GIY;
				case 'z': return GIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gj(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return GJI;
				case 'k': return GJK;
				case 'm': return GJM;
				case 'n': return GJN;
				case 'r': return GJR;
				case 'u': return GJU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GKA;
				case 'd': return GKD;
				case 'e': return GKE;
				case 'n': return GKN;
				case 'o': return GKO;
				case 'p': return GKP;
				case 'u': return GKU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gl(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return GLC;
				case 'd': return GLD;
				case 'h': return GLH;
				case 'i': return KZK;
				case 'j': return GLJ;
				case 'k': return GLK;
				case 'l': return GLL;
				case 'o': return GLO;
				case 'r': return GLR;
				case 'u': return GLU;
				case 'w': return GLW;
				case 'y': return GLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GMA;
				case 'b': return GMB;
				case 'd': return GMD;
				case 'e': return GME;
				case 'g': return GMG;
				case 'h': return GMH;
				case 'l': return GML;
				case 'm': return GMM;
				case 'n': return GMN;
				case 'q': return GMQ;
				case 'r': return GMR;
				case 'u': return GMU;
				case 'v': return GMV;
				case 'w': return GMW;
				case 'x': return GMX;
				case 'y': return GMY;
				case 'z': return GMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GNA;
				case 'b': return GNB;
				case 'c': return GNC;
				case 'd': return GND;
				case 'e': return GNE;
				case 'g': return GNG;
				case 'h': return GNH;
				case 'i': return GNI;
				case 'j': return GNJ;
				case 'k': return GNK;
				case 'l': return GNL;
				case 'm': return GNM;
				case 'n': return GNN;
				case 'o': return GNO;
				case 'q': return GNQ;
				case 'r': return GNR;
				case 't': return GNT;
				case 'u': return GNU;
				case 'w': return GNW;
				case 'z': return GNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_go(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GOA;
				case 'b': return GOB;
				case 'c': return GOC;
				case 'd': return GOD;
				case 'e': return GOE;
				case 'f': return GOF;
				case 'g': return GOG;
				case 'h': return GOH;
				case 'i': return GOI;
				case 'j': return GOJ;
				case 'k': return GOK;
				case 'l': return GOL;
				case 'm': return GOM;
				case 'n': return GON;
				case 'o': return GOO;
				case 'p': return GOP;
				case 'q': return GOQ;
				case 'r': return GOR;
				case 's': return GOS;
				case 't': return GOT;
				case 'u': return GOU;
				case 'w': return GOW;
				case 'x': return GOX;
				case 'y': return GOY;
				case 'z': return GOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GPA;
				case 'e': return GPE;
				case 'n': return GPN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GQA;
				case 'i': return GQI;
				case 'n': return GQN;
				case 'r': return GQR;
				case 'u': return GQU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GRA;
				case 'b': return GRB;
				case 'c': return GRC;
				case 'd': return GRD;
				case 'g': return GRG;
				case 'h': return GRH;
				case 'i': return GRI;
				case 'j': return GRJ;
				case 'k': return GRK;
				case 'm': return GRM;
				case 'o': return GRO;
				case 'q': return GRQ;
				case 'r': return GRR;
				case 's': return GRS;
				case 't': return GRT;
				case 'u': return GRU;
				case 'v': return GRV;
				case 'w': return GRW;
				case 'x': return GRX;
				case 'y': return GRY;
				case 'z': return GRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return GSE;
				case 'g': return GSG;
				case 'l': return GSL;
				case 'm': return GSM;
				case 'n': return GSN;
				case 'o': return GSO;
				case 'p': return GSP;
				case 's': return GSS;
				case 'w': return GSW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GTA;
				case 'i': return NYC;
				case 'u': return GTU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GUA;
				case 'b': return GUB;
				case 'c': return GUC;
				case 'd': return GUD;
				case 'e': return GUE;
				case 'f': return GUF;
				case 'g': return GUG;
				case 'h': return GUH;
				case 'i': return GUI;
				case 'k': return GUK;
				case 'l': return GUL;
				case 'm': return GUM;
				case 'n': return GUN;
				case 'o': return GUO;
				case 'p': return GUP;
				case 'q': return GUQ;
				case 'r': return GUR;
				case 's': return GUS;
				case 't': return GUT;
				case 'u': return GUU;
				case 'v': return DUZ;
				case 'w': return GUW;
				case 'x': return GUX;
				case 'z': return GUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GVA;
				case 'c': return GVC;
				case 'e': return GVE;
				case 'f': return GVF;
				case 'j': return GVJ;
				case 'l': return GVL;
				case 'm': return GVM;
				case 'n': return GVN;
				case 'o': return GVO;
				case 'p': return GVP;
				case 'r': return GVR;
				case 's': return GVS;
				case 'y': return GVY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GWA;
				case 'b': return GWB;
				case 'c': return GWC;
				case 'd': return GWD;
				case 'e': return GWE;
				case 'f': return GWF;
				case 'g': return GWG;
				case 'i': return GWI;
				case 'j': return GWJ;
				case 'm': return GWM;
				case 'n': return GWN;
				case 'r': return GWR;
				case 't': return GWT;
				case 'u': return GWU;
				case 'w': return GWW;
				case 'x': return GWX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return GXX;
			return null;
		}
		
		private static Language? tryParse_L3_gy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GYA;
				case 'b': return GYB;
				case 'd': return GYD;
				case 'e': return GYE;
				case 'f': return GYF;
				case 'g': return GYG;
				case 'i': return GYI;
				case 'l': return GYL;
				case 'm': return GYM;
				case 'n': return GYN;
				case 'o': return GYO;
				case 'r': return GYR;
				case 'y': return GYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_gz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return GZA;
				case 'i': return GZI;
				case 'n': return GZN;
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
				case 'a': return HAA;
				case 'b': return HAB;
				case 'c': return HAC;
				case 'd': return HAD;
				case 'e': return HAE;
				case 'f': return HAF;
				case 'g': return HAG;
				case 'h': return HAH;
				case 'i': return HAI;
				case 'j': return HAJ;
				case 'k': return HAK;
				case 'l': return HAL;
				case 'm': return HAM;
				case 'n': return HAN;
				case 'o': return HAO;
				case 'p': return HAP;
				case 'q': return HAQ;
				case 'r': return HAR;
				case 's': return HAS;
				case 'v': return HAV;
				case 'w': return HAW;
				case 'x': return HAX;
				case 'y': return HAY;
				case 'z': return HAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HBA;
				case 'b': return HBB;
				case 'n': return HBN;
				case 'o': return HBO;
				case 'u': return HBU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HCA;
				case 'h': return HCH;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hd(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return HDN;
				case 's': return HDS;
				case 'y': return HDY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_he(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HEA;
				case 'd': return HED;
				case 'g': return HEG;
				case 'h': return HEH;
				case 'i': return HEI;
				case 'm': return HEM;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hg(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return HGM;
				case 'w': return HGW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hh(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return HHI;
				case 'r': return HHR;
				case 'y': return HHY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HIA;
				case 'b': return HIB;
				case 'd': return HID;
				case 'f': return HIF;
				case 'g': return HIG;
				case 'h': return HIH;
				case 'i': return HII;
				case 'j': return HIJ;
				case 'k': return HIK;
				case 'l': return HIL;
				case 'm': return HIM;
				case 'o': return HIO;
				case 'r': return HIR;
				case 't': return HIT;
				case 'w': return HIW;
				case 'x': return HIX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return HJI;
			return null;
		}
		
		private static Language? tryParse_L3_hk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HKA;
				case 'e': return HKE;
				case 'k': return HKK;
				case 'n': return HKN;
				case 's': return HKS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HLA;
				case 'b': return HLB;
				case 'd': return HLD;
				case 'e': return HLE;
				case 't': return HLT;
				case 'u': return HLU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HMA;
				case 'b': return HMB;
				case 'c': return HMC;
				case 'd': return HMD;
				case 'e': return HME;
				case 'f': return HMF;
				case 'g': return HMG;
				case 'h': return HMH;
				case 'i': return HMI;
				case 'j': return HMJ;
				case 'k': return HMK;
				case 'l': return HML;
				case 'm': return HMM;
				case 'n': return HMN;
				case 'p': return HMP;
				case 'q': return HMQ;
				case 'r': return HMR;
				case 's': return HMS;
				case 't': return HMT;
				case 'u': return HMU;
				case 'v': return HMV;
				case 'w': return HMW;
				case 'x': return HMX;
				case 'y': return HMY;
				case 'z': return HMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HNA;
				case 'd': return HND;
				case 'e': return HNE;
				case 'g': return HNG;
				case 'h': return HNH;
				case 'i': return HNI;
				case 'j': return HNJ;
				case 'n': return HNN;
				case 'o': return HNO;
				case 's': return HNS;
				case 'u': return HNU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ho(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HOA;
				case 'b': return HOB;
				case 'c': return HOC;
				case 'd': return HOD;
				case 'e': return HOE;
				case 'h': return HOH;
				case 'i': return HOI;
				case 'j': return HOJ;
				case 'k': return HOK;
				case 'l': return HOL;
				case 'm': return HOM;
				case 'o': return HOO;
				case 'p': return HOP;
				case 'r': return HOR;
				case 's': return HOS;
				case 't': return HOT;
				case 'v': return HOV;
				case 'w': return HOW;
				case 'y': return HOY;
				case 'z': return HOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hp(StringSpan span)
		{
			switch(span[2])
			{
				case 'o': return HPO;
				case 's': return HPS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HRA;
				case 'c': return HRC;
				case 'e': return HRE;
				case 'k': return HRK;
				case 'm': return HRM;
				case 'o': return HRO;
				case 'p': return HRP;
				case 'r': return JAL;
				case 't': return HRT;
				case 'u': return HRU;
				case 'w': return HRW;
				case 'x': return HRX;
				case 'z': return HRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hs(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return HSB;
				case 'h': return HSH;
				case 'l': return HSL;
				case 'n': return HSN;
				case 's': return HSS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ht(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return HTI;
				case 'o': return HTO;
				case 's': return HTS;
				case 'u': return HTU;
				case 'x': return HTX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hu(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return HUB;
				case 'c': return HUC;
				case 'd': return HUD;
				case 'e': return HUE;
				case 'f': return HUF;
				case 'g': return HUG;
				case 'h': return HUH;
				case 'i': return HUI;
				case 'j': return HUJ;
				case 'k': return HUK;
				case 'l': return HUL;
				case 'm': return HUM;
				case 'o': return HUO;
				case 'p': return HUP;
				case 'q': return HUQ;
				case 'r': return HUR;
				case 's': return HUS;
				case 't': return HUT;
				case 'u': return HUU;
				case 'v': return HUV;
				case 'w': return HUW;
				case 'x': return HUX;
				case 'y': return HUY;
				case 'z': return HUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hv(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return HVC;
				case 'e': return HVE;
				case 'k': return HVK;
				case 'n': return HVN;
				case 'v': return HVV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HWA;
				case 'c': return HWC;
				case 'o': return HWO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_hy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HYA;
				case 'w': return HYW;
				case 'x': return HYX;
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
				case 'i': return IAI;
				case 'n': return IAN;
				case 'p': return IAP;
				case 'r': return IAR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ib(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IBA;
				case 'b': return IBB;
				case 'd': return IBD;
				case 'e': return IBE;
				case 'g': return IBG;
				case 'h': return IBH;
				case 'i': return OPA;
				case 'l': return IBL;
				case 'm': return IBM;
				case 'n': return IBN;
				case 'r': return IBR;
				case 'u': return IBU;
				case 'y': return IBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ic(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ICA;
				case 'h': return ICH;
				case 'l': return ICL;
				case 'r': return ICR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_id(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IDA;
				case 'b': return IDB;
				case 'c': return IDC;
				case 'd': return IDD;
				case 'e': return IDE;
				case 'i': return IDI;
				case 'r': return IDR;
				case 's': return IDS;
				case 't': return IDT;
				case 'u': return IDU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_if(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IFA;
				case 'b': return IFB;
				case 'e': return IFE;
				case 'f': return IFF;
				case 'k': return IFK;
				case 'm': return IFM;
				case 'u': return IFU;
				case 'y': return IFY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ig(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IGB;
				case 'e': return IGE;
				case 'g': return IGG;
				case 'l': return IGL;
				case 'm': return IGM;
				case 'n': return IGN;
				case 'o': return IGO;
				case 's': return IGS;
				case 'w': return IGW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ih(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IHB;
				case 'i': return IHI;
				case 'p': return IHP;
				case 'w': return IHW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ii(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return IIN;
				case 'r': return IIR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ij(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return IJC;
				case 'e': return IJE;
				case 'j': return IJJ;
				case 'n': return IJN;
				case 'o': return IJO;
				case 's': return IJS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ik(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return IKE;
				case 'i': return IKI;
				case 'k': return IKK;
				case 'l': return IKL;
				case 'o': return IKO;
				case 'p': return IKP;
				case 'r': return IKR;
				case 's': return IKS;
				case 't': return IKT;
				case 'v': return IKV;
				case 'w': return IKW;
				case 'x': return IKX;
				case 'z': return IKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_il(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ILA;
				case 'b': return ILB;
				case 'g': return ILG;
				case 'i': return ILI;
				case 'k': return ILK;
				case 'l': return ILL;
				case 'm': return ILM;
				case 'o': return ILO;
				case 'p': return ILP;
				case 's': return ILS;
				case 'u': return ILU;
				case 'v': return ILV;
				case 'w': return GAL;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_im(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IMA;
				case 'e': return IME;
				case 'i': return IMI;
				case 'l': return IML;
				case 'n': return IMN;
				case 'o': return IMO;
				case 'r': return IMR;
				case 's': return IMS;
				case 'y': return IMY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_in(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return INB;
				case 'c': return INC;
				case 'e': return INE;
				case 'g': return ING;
				case 'h': return INH;
				case 'j': return INJ;
				case 'l': return INL;
				case 'm': return INM;
				case 'n': return INN;
				case 'o': return INO;
				case 'p': return INP;
				case 's': return INS;
				case 't': return INT;
				case 'z': return INZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_io(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return IOR;
				case 'u': return IOU;
				case 'w': return IOW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ip(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return IPI;
				case 'o': return IPO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iq(StringSpan span)
		{
			switch(span[2])
			{
				case 'u': return IQU;
				case 'w': return IQW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ir(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IRA;
				case 'e': return IRE;
				case 'h': return IRH;
				case 'i': return IRI;
				case 'k': return IRK;
				case 'n': return IRN;
				case 'o': return IRO;
				case 'r': return IRR;
				case 'u': return IRU;
				case 'x': return IRX;
				case 'y': return IRY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_is(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ISA;
				case 'c': return ISC;
				case 'd': return ISD;
				case 'e': return ISE;
				case 'g': return ISG;
				case 'h': return ISH;
				case 'i': return ISI;
				case 'k': return ISK;
				case 'm': return ISM;
				case 'n': return ISN;
				case 'o': return ISO;
				case 'r': return ISR;
				case 't': return IST;
				case 'u': return ISU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_it(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ITB;
				case 'c': return ITC;
				case 'd': return ITD;
				case 'e': return ITE;
				case 'i': return ITI;
				case 'k': return ITK;
				case 'l': return ITL;
				case 'm': return ITM;
				case 'o': return ITO;
				case 'r': return ITR;
				case 's': return ITS;
				case 't': return ITT;
				case 'v': return ITV;
				case 'w': return ITW;
				case 'x': return ITX;
				case 'y': return ITY;
				case 'z': return ITZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return IUM;
			return null;
		}
		
		private static Language? tryParse_L3_iv(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return IVB;
				case 'v': return IVV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iw(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return IWK;
				case 'm': return IWM;
				case 'o': return IWO;
				case 's': return IWS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ix(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return IXC;
				case 'l': return IXL;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return IYA;
				case 'o': return IYO;
				case 'x': return IYX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_iz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return IZH;
				case 'i': return IZI;
				case 'r': return IZR;
				case 'z': return IZZ;
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
				case 'a': return JAA;
				case 'b': return JAB;
				case 'c': return JAC;
				case 'd': return JAD;
				case 'e': return JAE;
				case 'f': return JAF;
				case 'h': return JAH;
				case 'j': return JAJ;
				case 'k': return JAK;
				case 'l': return JAL;
				case 'm': return JAM;
				case 'n': return JAN;
				case 'o': return JAO;
				case 'q': return JAQ;
				case 'r': return JAR;
				case 's': return JAS;
				case 't': return JAT;
				case 'u': return JAU;
				case 'x': return JAX;
				case 'y': return JAY;
				case 'z': return JAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jb(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JBE;
				case 'i': return JBI;
				case 'j': return JBJ;
				case 'k': return JBK;
				case 'n': return JBN;
				case 'o': return JBO;
				case 'r': return JBR;
				case 't': return JBT;
				case 'u': return JBU;
				case 'w': return JBW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jc(StringSpan span)
		{
			switch(span[2])
			{
				case 's': return JCS;
				case 't': return JCT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JDA;
				case 'g': return JDG;
				case 't': return JDT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_je(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JEB;
				case 'e': return JEE;
				case 'g': return OYB;
				case 'h': return JEH;
				case 'i': return JEI;
				case 'k': return JEK;
				case 'l': return JEL;
				case 'n': return JEN;
				case 'r': return JER;
				case 't': return JET;
				case 'u': return JEU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jg(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JGB;
				case 'e': return JGE;
				case 'k': return JGK;
				case 'o': return JGO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jh(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return JHI;
				case 's': return JHS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ji(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JIA;
				case 'b': return JIB;
				case 'c': return JIC;
				case 'd': return JID;
				case 'e': return JIE;
				case 'g': return JIG;
				case 'h': return JIH;
				case 'i': return JII;
				case 'l': return JIL;
				case 'm': return JIM;
				case 'o': return JIO;
				case 'q': return JIQ;
				case 't': return JIT;
				case 'u': return JIU;
				case 'v': return JIV;
				case 'y': return JIY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jj(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JJE;
				case 'r': return JJR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JKA;
				case 'm': return JKM;
				case 'o': return JKO;
				case 'p': return JKP;
				case 'r': return JKR;
				case 'u': return JKU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jl(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return JLE;
				case 's': return JLS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JMA;
				case 'b': return JMB;
				case 'c': return JMC;
				case 'd': return JMD;
				case 'i': return JMI;
				case 'l': return JML;
				case 'n': return JMN;
				case 'r': return JMR;
				case 's': return JMS;
				case 'w': return JMW;
				case 'x': return JMX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JNA;
				case 'd': return JND;
				case 'g': return JNG;
				case 'i': return JNI;
				case 'j': return JNJ;
				case 'l': return JNL;
				case 's': return JNS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jo(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return JOB;
				case 'd': return JOD;
				case 'g': return JOG;
				case 'r': return JOR;
				case 's': return JOS;
				case 'w': return JOW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JPA;
				case 'r': return JPR;
				case 'x': return JPX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return JQR;
			return null;
		}
		
		private static Language? tryParse_L3_jr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JRA;
				case 'b': return JRB;
				case 'r': return JRR;
				case 't': return JRT;
				case 'u': return JRU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_js(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return JSL;
			return null;
		}
		
		private static Language? tryParse_L3_ju(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JUA;
				case 'b': return JUB;
				case 'c': return JUC;
				case 'd': return JUD;
				case 'h': return JUH;
				case 'i': return JUI;
				case 'k': return JUK;
				case 'l': return JUL;
				case 'm': return JUM;
				case 'n': return JUN;
				case 'o': return JUO;
				case 'p': return JUP;
				case 'r': return JUR;
				case 's': return JUS;
				case 't': return JUT;
				case 'u': return JUU;
				case 'w': return JUW;
				case 'y': return JUY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jv(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return JVD;
				case 'n': return JVN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_jw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return JWI;
			return null;
		}
		
		private static Language? tryParse_L3_jy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return JYA;
				case 'e': return JYE;
				case 'y': return JYY;
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
				case 'a': return KAA;
				case 'b': return KAB;
				case 'c': return KAC;
				case 'd': return KAD;
				case 'e': return KAE;
				case 'f': return KAF;
				case 'g': return KAG;
				case 'h': return KAH;
				case 'i': return KAI;
				case 'j': return KAJ;
				case 'k': return KAK;
				case 'm': return KAM;
				case 'o': return KAO;
				case 'p': return KAP;
				case 'q': return KAQ;
				case 'r': return KAR;
				case 'v': return KAV;
				case 'w': return KAW;
				case 'x': return KAX;
				case 'y': return KAY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KBA;
				case 'b': return KBB;
				case 'c': return KBC;
				case 'd': return KBD;
				case 'e': return KBE;
				case 'f': return KBF;
				case 'g': return KBG;
				case 'h': return KBH;
				case 'i': return KBI;
				case 'j': return KBJ;
				case 'k': return KBK;
				case 'l': return KBL;
				case 'm': return KBM;
				case 'n': return KBN;
				case 'o': return KBO;
				case 'p': return KBP;
				case 'q': return KBQ;
				case 'r': return KBR;
				case 's': return KBS;
				case 't': return KBT;
				case 'u': return KBU;
				case 'v': return KBV;
				case 'w': return KBW;
				case 'x': return KBX;
				case 'y': return KBY;
				case 'z': return KBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KCA;
				case 'b': return KCB;
				case 'c': return KCC;
				case 'd': return KCD;
				case 'e': return KCE;
				case 'f': return KCF;
				case 'g': return KCG;
				case 'h': return KCH;
				case 'i': return KCI;
				case 'j': return KCJ;
				case 'k': return KCK;
				case 'l': return KCL;
				case 'm': return KCM;
				case 'n': return KCN;
				case 'o': return KCO;
				case 'p': return KCP;
				case 'q': return KCQ;
				case 'r': return KCR;
				case 's': return KCS;
				case 't': return KCT;
				case 'u': return KCU;
				case 'v': return KCV;
				case 'w': return KCW;
				case 'x': return KCX;
				case 'y': return KCY;
				case 'z': return KCZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KDA;
				case 'c': return KDC;
				case 'd': return KDD;
				case 'e': return KDE;
				case 'f': return KDF;
				case 'g': return KDG;
				case 'h': return KDH;
				case 'i': return KDI;
				case 'j': return KDJ;
				case 'k': return KDK;
				case 'l': return KDL;
				case 'm': return KDM;
				case 'n': return KDN;
				case 'o': return KDO;
				case 'p': return KDP;
				case 'q': return KDQ;
				case 'r': return KDR;
				case 't': return KDT;
				case 'u': return KDU;
				case 'v': return KDV;
				case 'w': return KDW;
				case 'x': return KDX;
				case 'y': return KDY;
				case 'z': return KDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ke(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KEA;
				case 'b': return KEB;
				case 'c': return KEC;
				case 'd': return KED;
				case 'e': return KEE;
				case 'f': return KEF;
				case 'g': return KEG;
				case 'h': return KEH;
				case 'i': return KEI;
				case 'j': return KEJ;
				case 'k': return KEK;
				case 'l': return KEL;
				case 'm': return KEM;
				case 'n': return KEN;
				case 'o': return KEO;
				case 'p': return KEP;
				case 'q': return KEQ;
				case 'r': return KER;
				case 's': return KES;
				case 't': return KET;
				case 'u': return KEU;
				case 'v': return KEV;
				case 'w': return KEW;
				case 'x': return KEX;
				case 'y': return KEY;
				case 'z': return KEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KFA;
				case 'b': return KFB;
				case 'c': return KFC;
				case 'd': return KFD;
				case 'e': return KFE;
				case 'f': return KFF;
				case 'g': return KFG;
				case 'h': return KFH;
				case 'i': return KFI;
				case 'j': return KFJ;
				case 'k': return KFK;
				case 'l': return KFL;
				case 'm': return KFM;
				case 'n': return KFN;
				case 'o': return KFO;
				case 'p': return KFP;
				case 'q': return KFQ;
				case 'r': return KFR;
				case 's': return KFS;
				case 't': return KFT;
				case 'u': return KFU;
				case 'v': return KFV;
				case 'w': return KFW;
				case 'x': return KFX;
				case 'y': return KFY;
				case 'z': return KFZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KGA;
				case 'b': return KGB;
				case 'c': return TDF;
				case 'd': return KGD;
				case 'e': return KGE;
				case 'f': return KGF;
				case 'g': return KGG;
				case 'h': return KML;
				case 'i': return KGI;
				case 'j': return KGJ;
				case 'k': return KGK;
				case 'l': return KGL;
				case 'm': return KGM;
				case 'n': return KGN;
				case 'o': return KGO;
				case 'p': return KGP;
				case 'q': return KGQ;
				case 'r': return KGR;
				case 's': return KGS;
				case 't': return KGT;
				case 'u': return KGU;
				case 'v': return KGV;
				case 'w': return KGW;
				case 'x': return KGX;
				case 'y': return KGY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KHA;
				case 'b': return KHB;
				case 'c': return KHC;
				case 'd': return KHD;
				case 'e': return KHE;
				case 'f': return KHF;
				case 'g': return KHG;
				case 'h': return KHH;
				case 'i': return KHI;
				case 'j': return KHJ;
				case 'k': return KHK;
				case 'l': return KHL;
				case 'n': return KHN;
				case 'o': return KHO;
				case 'p': return KHP;
				case 'q': return KHQ;
				case 'r': return KHR;
				case 's': return KHS;
				case 't': return KHT;
				case 'u': return KHU;
				case 'v': return KHV;
				case 'w': return KHW;
				case 'x': return KHX;
				case 'y': return KHY;
				case 'z': return KHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ki(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KIA;
				case 'b': return KIB;
				case 'c': return KIC;
				case 'd': return KID;
				case 'e': return KIE;
				case 'f': return KIF;
				case 'g': return KIG;
				case 'h': return KIH;
				case 'i': return KII;
				case 'j': return KIJ;
				case 'l': return KIL;
				case 'm': return KIM;
				case 'o': return KIO;
				case 'p': return KIP;
				case 'q': return KIQ;
				case 's': return KIS;
				case 't': return KIT;
				case 'u': return KIU;
				case 'v': return KIV;
				case 'w': return KIW;
				case 'x': return KIX;
				case 'y': return KIY;
				case 'z': return KIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KJA;
				case 'b': return KJB;
				case 'c': return KJC;
				case 'd': return KJD;
				case 'e': return KJE;
				case 'f': return KJF;
				case 'g': return KJG;
				case 'h': return KJH;
				case 'i': return KJI;
				case 'j': return KJJ;
				case 'k': return KJK;
				case 'l': return KJL;
				case 'm': return KJM;
				case 'n': return KJN;
				case 'o': return KJO;
				case 'p': return KJP;
				case 'q': return KJQ;
				case 'r': return KJR;
				case 's': return KJS;
				case 't': return KJT;
				case 'u': return KJU;
				case 'v': return KJV;
				case 'x': return KJX;
				case 'y': return KJY;
				case 'z': return KJZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KKA;
				case 'b': return KKB;
				case 'c': return KKC;
				case 'd': return KKD;
				case 'e': return KKE;
				case 'f': return KKF;
				case 'g': return KKG;
				case 'h': return KKH;
				case 'i': return KKI;
				case 'j': return KKJ;
				case 'k': return KKK;
				case 'l': return KKL;
				case 'm': return KKM;
				case 'n': return KKN;
				case 'o': return KKO;
				case 'p': return KKP;
				case 'q': return KKQ;
				case 'r': return KKR;
				case 's': return KKS;
				case 't': return KKT;
				case 'u': return KKU;
				case 'v': return KKV;
				case 'w': return KKW;
				case 'x': return KKX;
				case 'y': return KKY;
				case 'z': return KKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KLA;
				case 'b': return KLB;
				case 'c': return KLC;
				case 'd': return KLD;
				case 'e': return KLE;
				case 'f': return KLF;
				case 'g': return KLG;
				case 'h': return KLH;
				case 'i': return KLI;
				case 'j': return KLJ;
				case 'k': return KLK;
				case 'l': return KLL;
				case 'm': return KLM;
				case 'n': return KLN;
				case 'o': return KLO;
				case 'p': return KLP;
				case 'q': return KLQ;
				case 'r': return KLR;
				case 's': return KLS;
				case 't': return KLT;
				case 'u': return KLU;
				case 'v': return KLV;
				case 'w': return KLW;
				case 'x': return KLX;
				case 'y': return KLY;
				case 'z': return KLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_km(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KMA;
				case 'b': return KMB;
				case 'c': return KMC;
				case 'd': return KMD;
				case 'e': return KME;
				case 'f': return KMF;
				case 'g': return KMG;
				case 'h': return KMH;
				case 'i': return KMI;
				case 'j': return KMJ;
				case 'k': return KMK;
				case 'l': return KML;
				case 'm': return KMM;
				case 'n': return KMN;
				case 'o': return KMO;
				case 'p': return KMP;
				case 'q': return KMQ;
				case 'r': return KMR;
				case 's': return KMS;
				case 't': return KMT;
				case 'u': return KMU;
				case 'v': return KMV;
				case 'w': return KMW;
				case 'x': return KMX;
				case 'y': return KMY;
				case 'z': return KMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KNA;
				case 'b': return KNB;
				case 'c': return KNC;
				case 'd': return KND;
				case 'e': return KNE;
				case 'f': return KNF;
				case 'g': return KNG;
				case 'i': return KNI;
				case 'j': return KNJ;
				case 'k': return KNK;
				case 'l': return KNL;
				case 'm': return KNM;
				case 'n': return KNN;
				case 'o': return KNO;
				case 'p': return KNP;
				case 'q': return KNQ;
				case 'r': return KNR;
				case 's': return KNS;
				case 't': return KNT;
				case 'u': return KNU;
				case 'v': return KNV;
				case 'w': return KNW;
				case 'x': return KNX;
				case 'y': return KNY;
				case 'z': return KNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ko(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KOA;
				case 'c': return KOC;
				case 'd': return KOD;
				case 'e': return KOE;
				case 'f': return KOF;
				case 'g': return KOG;
				case 'h': return KOH;
				case 'i': return KOI;
				case 'j': return KWV;
				case 'k': return KOK;
				case 'l': return KOL;
				case 'o': return KOO;
				case 'p': return KOP;
				case 'q': return KOQ;
				case 's': return KOS;
				case 't': return KOT;
				case 'u': return KOU;
				case 'v': return KOV;
				case 'w': return KOW;
				case 'x': return KOX;
				case 'y': return KOY;
				case 'z': return KOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KPA;
				case 'b': return KPB;
				case 'c': return KPC;
				case 'd': return KPD;
				case 'e': return KPE;
				case 'f': return KPF;
				case 'g': return KPG;
				case 'h': return KPH;
				case 'i': return KPI;
				case 'j': return KPJ;
				case 'k': return KPK;
				case 'l': return KPL;
				case 'm': return KPM;
				case 'n': return KPN;
				case 'o': return KPO;
				case 'p': return KPP;
				case 'q': return KPQ;
				case 'r': return KPR;
				case 's': return KPS;
				case 't': return KPT;
				case 'u': return KPU;
				case 'v': return KPV;
				case 'w': return KPW;
				case 'x': return KPX;
				case 'y': return KPY;
				case 'z': return KPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KQA;
				case 'b': return KQB;
				case 'c': return KQC;
				case 'd': return KQD;
				case 'e': return KQE;
				case 'f': return KQF;
				case 'g': return KQG;
				case 'h': return KQH;
				case 'i': return KQI;
				case 'j': return KQJ;
				case 'k': return KQK;
				case 'l': return KQL;
				case 'm': return KQM;
				case 'n': return KQN;
				case 'o': return KQO;
				case 'p': return KQP;
				case 'q': return KQQ;
				case 'r': return KQR;
				case 's': return KQS;
				case 't': return KQT;
				case 'u': return KQU;
				case 'v': return KQV;
				case 'w': return KQW;
				case 'x': return KQX;
				case 'y': return KQY;
				case 'z': return KQZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KRA;
				case 'b': return KRB;
				case 'c': return KRC;
				case 'd': return KRD;
				case 'e': return KRE;
				case 'f': return KRF;
				case 'h': return KRH;
				case 'i': return KRI;
				case 'j': return KRJ;
				case 'k': return KRK;
				case 'l': return KRL;
				case 'm': return BMF;
				case 'n': return KRN;
				case 'o': return KRO;
				case 'p': return KRP;
				case 'r': return KRR;
				case 's': return KRS;
				case 't': return KRT;
				case 'u': return KRU;
				case 'v': return KRV;
				case 'w': return KRW;
				case 'x': return KRX;
				case 'y': return KRY;
				case 'z': return KRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ks(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KSA;
				case 'b': return KSB;
				case 'c': return KSC;
				case 'd': return KSD;
				case 'e': return KSE;
				case 'f': return KSF;
				case 'g': return KSG;
				case 'h': return KSH;
				case 'i': return KSI;
				case 'j': return KSJ;
				case 'k': return KSK;
				case 'l': return KSL;
				case 'm': return KSM;
				case 'n': return KSN;
				case 'o': return KSO;
				case 'p': return KSP;
				case 'q': return KSQ;
				case 'r': return KSR;
				case 's': return KSS;
				case 't': return KST;
				case 'u': return KSU;
				case 'v': return KSV;
				case 'w': return KSW;
				case 'x': return KSX;
				case 'y': return KSY;
				case 'z': return KSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KTA;
				case 'b': return KTB;
				case 'c': return KTC;
				case 'd': return KTD;
				case 'e': return KTE;
				case 'f': return KTF;
				case 'g': return KTG;
				case 'h': return KTH;
				case 'i': return KTI;
				case 'j': return KTJ;
				case 'k': return KTK;
				case 'l': return KTL;
				case 'm': return KTM;
				case 'n': return KTN;
				case 'o': return KTO;
				case 'p': return KTP;
				case 'q': return KTQ;
				case 'r': return DTP;
				case 's': return KTS;
				case 't': return KTT;
				case 'u': return KTU;
				case 'v': return KTV;
				case 'w': return KTW;
				case 'x': return KTX;
				case 'y': return KTY;
				case 'z': return KTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ku(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return KUB;
				case 'c': return KUC;
				case 'd': return KUD;
				case 'e': return KUE;
				case 'f': return KUF;
				case 'g': return KUG;
				case 'h': return KUH;
				case 'i': return KUI;
				case 'j': return KUJ;
				case 'k': return KUK;
				case 'l': return KUL;
				case 'm': return KUM;
				case 'n': return KUN;
				case 'o': return KUO;
				case 'p': return KUP;
				case 'q': return KUQ;
				case 's': return KUS;
				case 't': return KUT;
				case 'u': return KUU;
				case 'v': return KUV;
				case 'w': return KUW;
				case 'x': return KUX;
				case 'y': return KUY;
				case 'z': return KUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KVA;
				case 'b': return KVB;
				case 'c': return KVC;
				case 'd': return KVD;
				case 'e': return KVE;
				case 'f': return KVF;
				case 'g': return KVG;
				case 'h': return KVH;
				case 'i': return KVI;
				case 'j': return KVJ;
				case 'k': return KVK;
				case 'l': return KVL;
				case 'm': return KVM;
				case 'n': return KVN;
				case 'o': return KVO;
				case 'p': return KVP;
				case 'q': return KVQ;
				case 'r': return KVR;
				case 's': return GDJ;
				case 't': return KVT;
				case 'u': return KVU;
				case 'v': return KVV;
				case 'w': return KVW;
				case 'x': return KVX;
				case 'y': return KVY;
				case 'z': return KVZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KWA;
				case 'b': return KWB;
				case 'c': return KWC;
				case 'd': return KWD;
				case 'e': return KWE;
				case 'f': return KWF;
				case 'g': return KWG;
				case 'h': return KWH;
				case 'i': return KWI;
				case 'j': return KWJ;
				case 'k': return KWK;
				case 'l': return KWL;
				case 'm': return KWM;
				case 'n': return KWN;
				case 'o': return KWO;
				case 'p': return KWP;
				case 'q': return YAM;
				case 'r': return KWR;
				case 's': return KWS;
				case 't': return KWT;
				case 'u': return KWU;
				case 'v': return KWV;
				case 'w': return KWW;
				case 'x': return KWX;
				case 'y': return KWY;
				case 'z': return KWZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KXA;
				case 'b': return KXB;
				case 'c': return KXC;
				case 'd': return KXD;
				case 'e': return TVD;
				case 'f': return KXF;
				case 'h': return KXH;
				case 'i': return KXI;
				case 'j': return KXJ;
				case 'k': return KXK;
				case 'l': return KRU;
				case 'm': return KXM;
				case 'n': return KXN;
				case 'o': return KXO;
				case 'p': return KXP;
				case 'q': return KXQ;
				case 'r': return KXR;
				case 's': return KXS;
				case 't': return KXT;
				case 'u': return KXU;
				case 'v': return KXV;
				case 'w': return KXW;
				case 'x': return KXX;
				case 'y': return KXY;
				case 'z': return KXZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ky(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KYA;
				case 'b': return KYB;
				case 'c': return KYC;
				case 'd': return KYD;
				case 'e': return KYE;
				case 'f': return KYF;
				case 'g': return KYG;
				case 'h': return KYH;
				case 'i': return KYI;
				case 'j': return KYJ;
				case 'k': return KYK;
				case 'l': return KYL;
				case 'm': return KYM;
				case 'n': return KYN;
				case 'o': return KYO;
				case 'p': return KYP;
				case 'q': return KYQ;
				case 'r': return KYR;
				case 's': return KYS;
				case 't': return KYT;
				case 'u': return KYU;
				case 'v': return KYV;
				case 'w': return KYW;
				case 'x': return KYX;
				case 'y': return KYY;
				case 'z': return KYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_kz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return KZA;
				case 'b': return KZB;
				case 'c': return KZC;
				case 'd': return KZD;
				case 'e': return KZE;
				case 'f': return KZF;
				case 'g': return KZG;
				case 'h': return KZH;
				case 'i': return KZI;
				case 'j': return DTP;
				case 'k': return KZK;
				case 'l': return KZL;
				case 'm': return KZM;
				case 'n': return KZN;
				case 'o': return KZO;
				case 'p': return KZP;
				case 'q': return KZQ;
				case 'r': return KZR;
				case 's': return KZS;
				case 't': return DTP;
				case 'u': return KZU;
				case 'v': return KZV;
				case 'w': return KZW;
				case 'x': return KZX;
				case 'y': return KZY;
				case 'z': return KZZ;
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
				case 'r': return tryParse_L3_lr(span);
				case 's': return tryParse_L3_ls(span);
				case 't': return tryParse_L3_lt(span);
				case 'u': return tryParse_L3_lu(span);
				case 'v': return tryParse_L3_lv(span);
				case 'w': return tryParse_L3_lw(span);
				case 'y': return tryParse_L3_ly(span);
				case 'z': return tryParse_L3_lz(span);
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_la(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LAA;
				case 'b': return LAB;
				case 'c': return LAC;
				case 'd': return LAD;
				case 'e': return LAE;
				case 'f': return LAF;
				case 'g': return LAG;
				case 'h': return LAH;
				case 'i': return LAI;
				case 'j': return LAJ;
				case 'k': return LAK;
				case 'l': return LAL;
				case 'm': return LAM;
				case 'n': return LAN;
				case 'p': return LAP;
				case 'q': return LAQ;
				case 'r': return LAR;
				case 's': return LAS;
				case 'u': return LAU;
				case 'w': return LAW;
				case 'x': return LAX;
				case 'y': return LAY;
				case 'z': return LAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LBA;
				case 'b': return LBB;
				case 'c': return LBC;
				case 'e': return LBE;
				case 'f': return LBF;
				case 'g': return LBG;
				case 'i': return LBI;
				case 'j': return LBJ;
				case 'k': return LBK;
				case 'l': return LBL;
				case 'm': return LBM;
				case 'n': return LBN;
				case 'o': return LBO;
				case 'q': return LBQ;
				case 'r': return LBR;
				case 's': return LBS;
				case 't': return LBT;
				case 'u': return LBU;
				case 'v': return LBV;
				case 'w': return LBW;
				case 'x': return LBX;
				case 'y': return LBY;
				case 'z': return LBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lc(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return LCC;
				case 'd': return LCD;
				case 'e': return LCE;
				case 'f': return LCF;
				case 'h': return LCH;
				case 'l': return LCL;
				case 'm': return LCM;
				case 'p': return LCP;
				case 'q': return LCQ;
				case 's': return LCS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ld(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LDA;
				case 'b': return LDB;
				case 'd': return LDD;
				case 'g': return LDG;
				case 'h': return LDH;
				case 'i': return LDI;
				case 'j': return LDJ;
				case 'k': return LDK;
				case 'l': return LDL;
				case 'm': return LDM;
				case 'n': return LDN;
				case 'o': return LDO;
				case 'p': return LDP;
				case 'q': return LDQ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_le(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LEA;
				case 'b': return LEB;
				case 'c': return LEC;
				case 'd': return LED;
				case 'e': return LEE;
				case 'f': return LEF;
				case 'g': return LEG;
				case 'h': return LEH;
				case 'i': return LEI;
				case 'j': return LEJ;
				case 'k': return LEK;
				case 'l': return LEL;
				case 'm': return LEM;
				case 'n': return LEN;
				case 'o': return LEO;
				case 'p': return LEP;
				case 'q': return LEQ;
				case 'r': return LER;
				case 's': return LES;
				case 't': return LET;
				case 'u': return LEU;
				case 'v': return LEV;
				case 'w': return LEW;
				case 'x': return LEX;
				case 'y': return LEY;
				case 'z': return LEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LFA;
				case 'n': return LFN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LGA;
				case 'b': return LGB;
				case 'g': return LGG;
				case 'h': return LGH;
				case 'i': return LGI;
				case 'k': return LGK;
				case 'l': return LGL;
				case 'm': return LGM;
				case 'n': return LGN;
				case 'q': return LGQ;
				case 'r': return LGR;
				case 't': return LGT;
				case 'u': return LGU;
				case 'z': return LGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LHA;
				case 'h': return LHH;
				case 'i': return LHI;
				case 'l': return LHL;
				case 'm': return LHM;
				case 'n': return LHN;
				case 'p': return LHP;
				case 's': return LHS;
				case 't': return LHT;
				case 'u': return LHU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_li(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LIA;
				case 'b': return LIB;
				case 'c': return LIC;
				case 'd': return LID;
				case 'e': return LIE;
				case 'f': return LIF;
				case 'g': return LIG;
				case 'h': return LIH;
				case 'i': return RAQ;
				case 'j': return LIJ;
				case 'k': return LIK;
				case 'l': return LIL;
				case 'o': return LIO;
				case 'p': return LIP;
				case 'q': return LIQ;
				case 'r': return LIR;
				case 's': return LIS;
				case 'u': return LIU;
				case 'v': return LIV;
				case 'w': return LIW;
				case 'x': return LIX;
				case 'y': return LIY;
				case 'z': return LIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LJA;
				case 'e': return LJE;
				case 'i': return LJI;
				case 'l': return LJL;
				case 'p': return LJP;
				case 'w': return LJW;
				case 'x': return LJX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LKA;
				case 'b': return LKB;
				case 'c': return LKC;
				case 'd': return LKD;
				case 'e': return LKE;
				case 'h': return LKH;
				case 'i': return LKI;
				case 'j': return LKJ;
				case 'l': return LKL;
				case 'm': return LKM;
				case 'n': return LKN;
				case 'o': return LKO;
				case 'r': return LKR;
				case 's': return LKS;
				case 't': return LKT;
				case 'u': return LKU;
				case 'y': return LKY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ll(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LLA;
				case 'b': return LLB;
				case 'c': return LLC;
				case 'd': return LLD;
				case 'e': return LLE;
				case 'f': return LLF;
				case 'g': return LLG;
				case 'h': return LLH;
				case 'i': return LLI;
				case 'j': return LLJ;
				case 'k': return LLK;
				case 'l': return LLL;
				case 'm': return LLM;
				case 'n': return LLN;
				case 'o': return NGT;
				case 'p': return LLP;
				case 'q': return LLQ;
				case 's': return LLS;
				case 'u': return LLU;
				case 'x': return LLX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LMA;
				case 'b': return LMB;
				case 'c': return LMC;
				case 'd': return LMD;
				case 'e': return LME;
				case 'f': return LMF;
				case 'g': return LMG;
				case 'h': return LMH;
				case 'i': return LMI;
				case 'j': return LMJ;
				case 'k': return LMK;
				case 'l': return LML;
				case 'm': return RMX;
				case 'n': return LMN;
				case 'o': return LMO;
				case 'p': return LMP;
				case 'q': return LMQ;
				case 'r': return LMR;
				case 'u': return LMU;
				case 'v': return LMV;
				case 'w': return LMW;
				case 'x': return LMX;
				case 'y': return LMY;
				case 'z': return LMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ln(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LNA;
				case 'b': return LNB;
				case 'd': return LND;
				case 'g': return LNG;
				case 'h': return LNH;
				case 'i': return LNI;
				case 'j': return LNJ;
				case 'l': return LNL;
				case 'm': return LNM;
				case 'n': return LNN;
				case 'o': return LNO;
				case 's': return LNS;
				case 'u': return LNU;
				case 'w': return LNW;
				case 'z': return LNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LOA;
				case 'b': return LOB;
				case 'c': return LOC;
				case 'e': return LOE;
				case 'f': return LOF;
				case 'g': return LOG;
				case 'h': return LOH;
				case 'i': return LOI;
				case 'j': return LOJ;
				case 'k': return LOK;
				case 'l': return LOL;
				case 'm': return LOM;
				case 'n': return LON;
				case 'o': return LOO;
				case 'p': return LOP;
				case 'q': return LOQ;
				case 'r': return LOR;
				case 's': return LOS;
				case 't': return LOT;
				case 'u': return LOU;
				case 'v': return LOV;
				case 'w': return LOW;
				case 'x': return LOX;
				case 'y': return LOY;
				case 'z': return LOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LPA;
				case 'e': return LPE;
				case 'n': return LPN;
				case 'o': return LPO;
				case 'x': return LPX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LRA;
				case 'c': return LRC;
				case 'e': return LRE;
				case 'g': return LRG;
				case 'i': return LRI;
				case 'k': return LRK;
				case 'l': return LRL;
				case 'm': return LRM;
				case 'n': return LRN;
				case 'o': return LRO;
				case 'r': return LRR;
				case 't': return LRT;
				case 'v': return LRV;
				case 'z': return LRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ls(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LSA;
				case 'd': return LSD;
				case 'e': return LSE;
				case 'g': return LSG;
				case 'h': return LSH;
				case 'i': return LSI;
				case 'l': return LSL;
				case 'm': return LSM;
				case 'n': return LSN;
				case 'o': return LSO;
				case 'p': return LSP;
				case 'r': return LSR;
				case 's': return LSS;
				case 't': return LST;
				case 'v': return LSV;
				case 'y': return LSY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lt(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return LTC;
				case 'g': return LTG;
				case 'h': return LTH;
				case 'i': return LTI;
				case 'n': return LTN;
				case 'o': return LTO;
				case 's': return LTS;
				case 'u': return LTU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LUA;
				case 'c': return LUC;
				case 'd': return LUD;
				case 'e': return LUE;
				case 'f': return LUF;
				case 'i': return LUI;
				case 'j': return LUJ;
				case 'k': return LUK;
				case 'l': return LUL;
				case 'm': return LUM;
				case 'n': return LUN;
				case 'o': return LUO;
				case 'p': return LUP;
				case 'q': return LUQ;
				case 'r': return LUR;
				case 's': return LUS;
				case 't': return LUT;
				case 'u': return LUU;
				case 'v': return LUV;
				case 'w': return LUW;
				case 'y': return LUY;
				case 'z': return LUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LVA;
				case 'i': return LVI;
				case 'k': return LVK;
				case 's': return LVS;
				case 'u': return LVU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LWA;
				case 'e': return LWE;
				case 'g': return LWG;
				case 'h': return LWH;
				case 'l': return LWL;
				case 'm': return LWM;
				case 'o': return LWO;
				case 's': return LWS;
				case 't': return LWT;
				case 'u': return LWU;
				case 'w': return LWW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ly(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LYA;
				case 'g': return LYG;
				case 'n': return LYN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_lz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return LZH;
				case 'l': return LZL;
				case 'n': return LZN;
				case 'z': return LZZ;
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
				case 'a': return MAA;
				case 'b': return MAB;
				case 'd': return MAD;
				case 'e': return MAE;
				case 'f': return MAF;
				case 'g': return MAG;
				case 'i': return MAI;
				case 'j': return MAJ;
				case 'k': return MAK;
				case 'm': return MAM;
				case 'n': return MAN;
				case 'p': return MAP;
				case 'q': return MAQ;
				case 's': return MAS;
				case 't': return MAT;
				case 'u': return MAU;
				case 'v': return MAV;
				case 'w': return MAW;
				case 'x': return MAX;
				case 'z': return MAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MBA;
				case 'b': return MBB;
				case 'c': return MBC;
				case 'd': return MBD;
				case 'e': return MBE;
				case 'f': return MBF;
				case 'h': return MBH;
				case 'i': return MBI;
				case 'j': return MBJ;
				case 'k': return MBK;
				case 'l': return MBL;
				case 'm': return MBM;
				case 'n': return MBN;
				case 'o': return MBO;
				case 'p': return MBP;
				case 'q': return MBQ;
				case 'r': return MBR;
				case 's': return MBS;
				case 't': return MBT;
				case 'u': return MBU;
				case 'v': return MBV;
				case 'w': return MBW;
				case 'x': return MBX;
				case 'y': return MBY;
				case 'z': return MBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MCA;
				case 'b': return MCB;
				case 'c': return MCC;
				case 'd': return MCD;
				case 'e': return MCE;
				case 'f': return MCF;
				case 'g': return MCG;
				case 'h': return MCH;
				case 'i': return MCI;
				case 'j': return MCJ;
				case 'k': return MCK;
				case 'l': return MCL;
				case 'm': return MCM;
				case 'n': return MCN;
				case 'o': return MCO;
				case 'p': return MCP;
				case 'q': return MCQ;
				case 'r': return MCR;
				case 's': return MCS;
				case 't': return MCT;
				case 'u': return MCU;
				case 'v': return MCV;
				case 'w': return MCW;
				case 'x': return MCX;
				case 'y': return MCY;
				case 'z': return MCZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_md(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MDA;
				case 'b': return MDB;
				case 'c': return MDC;
				case 'd': return MDD;
				case 'e': return MDE;
				case 'f': return MDF;
				case 'g': return MDG;
				case 'h': return MDH;
				case 'i': return MDI;
				case 'j': return MDJ;
				case 'k': return MDK;
				case 'l': return MDL;
				case 'm': return MDM;
				case 'n': return MDN;
				case 'p': return MDP;
				case 'q': return MDQ;
				case 'r': return MDR;
				case 's': return MDS;
				case 't': return MDT;
				case 'u': return MDU;
				case 'v': return MDV;
				case 'w': return MDW;
				case 'x': return MDX;
				case 'y': return MDY;
				case 'z': return MDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_me(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MEA;
				case 'b': return MEB;
				case 'c': return MEC;
				case 'd': return MED;
				case 'e': return MEE;
				case 'f': return MEF;
				case 'g': return CIR;
				case 'h': return MEH;
				case 'i': return MEI;
				case 'j': return MEJ;
				case 'k': return MEK;
				case 'l': return MEL;
				case 'm': return MEM;
				case 'n': return MEN;
				case 'o': return MEO;
				case 'p': return MEP;
				case 'q': return MEQ;
				case 'r': return MER;
				case 's': return MES;
				case 't': return MET;
				case 'u': return MEU;
				case 'v': return MEV;
				case 'w': return MEW;
				case 'y': return MEY;
				case 'z': return MEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MFA;
				case 'b': return MFB;
				case 'c': return MFC;
				case 'd': return MFD;
				case 'e': return MFE;
				case 'f': return MFF;
				case 'g': return MFG;
				case 'h': return MFH;
				case 'i': return MFI;
				case 'j': return MFJ;
				case 'k': return MFK;
				case 'l': return MFL;
				case 'm': return MFM;
				case 'n': return MFN;
				case 'o': return MFO;
				case 'p': return MFP;
				case 'q': return MFQ;
				case 'r': return MFR;
				case 's': return MFS;
				case 't': return MFT;
				case 'u': return MFU;
				case 'v': return MFV;
				case 'w': return MFW;
				case 'x': return MFX;
				case 'y': return MFY;
				case 'z': return MFZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MGA;
				case 'b': return MGB;
				case 'c': return MGC;
				case 'd': return MGD;
				case 'e': return MGE;
				case 'f': return MGF;
				case 'g': return MGG;
				case 'h': return MGH;
				case 'i': return MGI;
				case 'j': return MGJ;
				case 'k': return MGK;
				case 'l': return MGL;
				case 'm': return MGM;
				case 'n': return MGN;
				case 'o': return MGO;
				case 'p': return MGP;
				case 'q': return MGQ;
				case 'r': return MGR;
				case 's': return MGS;
				case 't': return MGT;
				case 'u': return MGU;
				case 'v': return MGV;
				case 'w': return MGW;
				case 'x': return MGX;
				case 'y': return MGY;
				case 'z': return MGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MHA;
				case 'b': return MHB;
				case 'c': return MHC;
				case 'd': return MHD;
				case 'e': return MHE;
				case 'f': return MHF;
				case 'g': return MHG;
				case 'h': return MHH;
				case 'i': return MHI;
				case 'j': return MHJ;
				case 'k': return MHK;
				case 'l': return MHL;
				case 'm': return MHM;
				case 'n': return MHN;
				case 'o': return MHO;
				case 'p': return MHP;
				case 'q': return MHQ;
				case 'r': return MHR;
				case 's': return MHS;
				case 't': return MHT;
				case 'u': return MHU;
				case 'w': return MHW;
				case 'x': return MHX;
				case 'y': return MHY;
				case 'z': return MHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MIA;
				case 'b': return MIB;
				case 'c': return MIC;
				case 'd': return MID;
				case 'e': return MIE;
				case 'f': return MIF;
				case 'g': return MIG;
				case 'h': return MIH;
				case 'i': return MII;
				case 'j': return MIJ;
				case 'k': return MIK;
				case 'l': return MIL;
				case 'm': return MIM;
				case 'n': return MIN;
				case 'o': return MIO;
				case 'p': return MIP;
				case 'q': return MIQ;
				case 'r': return MIR;
				case 's': return MIS;
				case 't': return MIT;
				case 'u': return MIU;
				case 'w': return MIW;
				case 'x': return MIX;
				case 'y': return MIY;
				case 'z': return MIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MJA;
				case 'b': return MJB;
				case 'c': return MJC;
				case 'd': return MJD;
				case 'e': return MJE;
				case 'g': return MJG;
				case 'h': return MJH;
				case 'i': return MJI;
				case 'j': return MJJ;
				case 'k': return MJK;
				case 'l': return MJL;
				case 'm': return MJM;
				case 'n': return MJN;
				case 'o': return MJO;
				case 'p': return MJP;
				case 'q': return MJQ;
				case 'r': return MJR;
				case 's': return MJS;
				case 't': return MJT;
				case 'u': return MJU;
				case 'v': return MJV;
				case 'w': return MJW;
				case 'x': return MJX;
				case 'y': return MJY;
				case 'z': return MJZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MKA;
				case 'b': return MKB;
				case 'c': return MKC;
				case 'e': return MKE;
				case 'f': return MKF;
				case 'g': return MKG;
				case 'h': return MKH;
				case 'i': return MKI;
				case 'j': return MKJ;
				case 'k': return MKK;
				case 'l': return MKL;
				case 'm': return MKM;
				case 'n': return MKN;
				case 'o': return MKO;
				case 'p': return MKP;
				case 'q': return MKQ;
				case 'r': return MKR;
				case 's': return MKS;
				case 't': return MKT;
				case 'u': return MKU;
				case 'v': return MKV;
				case 'w': return MKW;
				case 'x': return MKX;
				case 'y': return MKY;
				case 'z': return MKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ml(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MLA;
				case 'b': return MLB;
				case 'c': return MLC;
				case 'd': return MLD;
				case 'e': return MLE;
				case 'f': return MLF;
				case 'h': return MLH;
				case 'i': return MLI;
				case 'j': return MLJ;
				case 'k': return MLK;
				case 'l': return MLL;
				case 'm': return MLM;
				case 'n': return MLN;
				case 'o': return MLO;
				case 'p': return MLP;
				case 'q': return MLQ;
				case 'r': return MLR;
				case 's': return MLS;
				case 'u': return MLU;
				case 'v': return MLV;
				case 'w': return MLW;
				case 'x': return MLX;
				case 'z': return MLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MMA;
				case 'b': return MMB;
				case 'c': return MMC;
				case 'd': return MMD;
				case 'e': return MME;
				case 'f': return MMF;
				case 'g': return MMG;
				case 'h': return MMH;
				case 'i': return MMI;
				case 'j': return MMJ;
				case 'k': return MMK;
				case 'l': return MML;
				case 'm': return MMM;
				case 'n': return MMN;
				case 'o': return MMO;
				case 'p': return MMP;
				case 'q': return MMQ;
				case 'r': return MMR;
				case 't': return MMT;
				case 'u': return MMU;
				case 'v': return MMV;
				case 'w': return MMW;
				case 'x': return MMX;
				case 'y': return MMY;
				case 'z': return MMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MNA;
				case 'b': return MNB;
				case 'c': return MNC;
				case 'd': return MND;
				case 'e': return MNE;
				case 'f': return MNF;
				case 'g': return MNG;
				case 'h': return MNH;
				case 'i': return MNI;
				case 'j': return MNJ;
				case 'k': return MNK;
				case 'l': return MNL;
				case 'm': return MNM;
				case 'n': return MNN;
				case 'o': return MNO;
				case 'p': return MNP;
				case 'q': return MNQ;
				case 'r': return MNR;
				case 's': return MNS;
				case 't': return MNT;
				case 'u': return MNU;
				case 'v': return MNV;
				case 'w': return MNW;
				case 'x': return MNX;
				case 'y': return MNY;
				case 'z': return MNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MOA;
				case 'c': return MOC;
				case 'd': return MOD;
				case 'e': return MOE;
				case 'f': return MOF;
				case 'g': return MOG;
				case 'h': return MOH;
				case 'i': return MOI;
				case 'j': return MOJ;
				case 'k': return MOK;
				case 'm': return MOM;
				case 'o': return MOO;
				case 'p': return MOP;
				case 'q': return MOQ;
				case 'r': return MOR;
				case 's': return MOS;
				case 't': return MOT;
				case 'u': return MOU;
				case 'v': return MOV;
				case 'w': return MOW;
				case 'x': return MOX;
				case 'y': return MOY;
				case 'z': return MOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MPA;
				case 'b': return MPB;
				case 'c': return MPC;
				case 'd': return MPD;
				case 'e': return MPE;
				case 'g': return MPG;
				case 'h': return MPH;
				case 'i': return MPI;
				case 'j': return MPJ;
				case 'k': return MPK;
				case 'l': return MPL;
				case 'm': return MPM;
				case 'n': return MPN;
				case 'o': return MPO;
				case 'p': return MPP;
				case 'q': return MPQ;
				case 'r': return MPR;
				case 's': return MPS;
				case 't': return MPT;
				case 'u': return MPU;
				case 'v': return MPV;
				case 'w': return MPW;
				case 'x': return MPX;
				case 'y': return MPY;
				case 'z': return MPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MQA;
				case 'b': return MQB;
				case 'c': return MQC;
				case 'e': return MQE;
				case 'f': return MQF;
				case 'g': return MQG;
				case 'h': return MQH;
				case 'i': return MQI;
				case 'j': return MQJ;
				case 'k': return MQK;
				case 'l': return MQL;
				case 'm': return MQM;
				case 'n': return MQN;
				case 'o': return MQO;
				case 'p': return MQP;
				case 'q': return MQQ;
				case 'r': return MQR;
				case 's': return MQS;
				case 't': return MQT;
				case 'u': return MQU;
				case 'v': return MQV;
				case 'w': return MQW;
				case 'x': return MQX;
				case 'y': return MQY;
				case 'z': return MQZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MRA;
				case 'b': return MRB;
				case 'c': return MRC;
				case 'd': return MRD;
				case 'e': return MRE;
				case 'f': return MRF;
				case 'g': return MRG;
				case 'h': return MRH;
				case 'j': return MRJ;
				case 'k': return MRK;
				case 'l': return MRL;
				case 'm': return MRM;
				case 'n': return MRN;
				case 'o': return MRO;
				case 'p': return MRP;
				case 'q': return MRQ;
				case 'r': return MRR;
				case 's': return MRS;
				case 't': return MRT;
				case 'u': return MRU;
				case 'v': return MRV;
				case 'w': return MRW;
				case 'x': return MRX;
				case 'y': return MRY;
				case 'z': return MRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ms(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return MSB;
				case 'c': return MSC;
				case 'd': return MSD;
				case 'e': return MSE;
				case 'f': return MSF;
				case 'g': return MSG;
				case 'h': return MSH;
				case 'i': return MSI;
				case 'j': return MSJ;
				case 'k': return MSK;
				case 'l': return MSL;
				case 'm': return MSM;
				case 'n': return MSN;
				case 'o': return MSO;
				case 'p': return MSP;
				case 'q': return MSQ;
				case 'r': return MSR;
				case 's': return MSS;
				case 't': return MRY;
				case 'u': return MSU;
				case 'v': return MSV;
				case 'w': return MSW;
				case 'x': return MSX;
				case 'y': return MSY;
				case 'z': return MSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MTA;
				case 'b': return MTB;
				case 'c': return MTC;
				case 'd': return MTD;
				case 'e': return MTE;
				case 'f': return MTF;
				case 'g': return MTG;
				case 'h': return MTH;
				case 'i': return MTI;
				case 'j': return MTJ;
				case 'k': return MTK;
				case 'l': return MTL;
				case 'm': return MTM;
				case 'n': return MTN;
				case 'o': return MTO;
				case 'p': return MTP;
				case 'q': return MTQ;
				case 'r': return MTR;
				case 's': return MTS;
				case 't': return MTT;
				case 'u': return MTU;
				case 'v': return MTV;
				case 'w': return MTW;
				case 'x': return MTX;
				case 'y': return MTY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MUA;
				case 'b': return MUB;
				case 'c': return MUC;
				case 'd': return MUD;
				case 'e': return MUE;
				case 'g': return MUG;
				case 'h': return MUH;
				case 'i': return MUI;
				case 'j': return MUJ;
				case 'k': return MUK;
				case 'l': return MUL;
				case 'm': return MUM;
				case 'n': return MUN;
				case 'o': return MUO;
				case 'p': return MUP;
				case 'q': return MUQ;
				case 'r': return MUR;
				case 's': return MUS;
				case 't': return MUT;
				case 'u': return MUU;
				case 'v': return MUV;
				case 'x': return MUX;
				case 'y': return MUY;
				case 'z': return MUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MVA;
				case 'b': return MVB;
				case 'd': return MVD;
				case 'e': return MVE;
				case 'f': return MVF;
				case 'g': return MVG;
				case 'h': return MVH;
				case 'i': return MVI;
				case 'k': return MVK;
				case 'l': return MVL;
				case 'm': return MVM;
				case 'n': return MVN;
				case 'o': return MVO;
				case 'p': return MVP;
				case 'q': return MVQ;
				case 'r': return MVR;
				case 's': return MVS;
				case 't': return MVT;
				case 'u': return MVU;
				case 'v': return MVV;
				case 'w': return MVW;
				case 'x': return MVX;
				case 'y': return MVY;
				case 'z': return MVZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MWA;
				case 'b': return MWB;
				case 'c': return MWC;
				case 'd': return MWD;
				case 'e': return MWE;
				case 'f': return MWF;
				case 'g': return MWG;
				case 'h': return MWH;
				case 'i': return MWI;
				case 'j': return VAJ;
				case 'k': return MWK;
				case 'l': return MWL;
				case 'm': return MWM;
				case 'n': return MWN;
				case 'o': return MWO;
				case 'p': return MWP;
				case 'q': return MWQ;
				case 'r': return MWR;
				case 's': return MWS;
				case 't': return MWT;
				case 'u': return MWU;
				case 'v': return MWV;
				case 'w': return MWW;
				case 'x': return MWX;
				case 'y': return MWY;
				case 'z': return MWZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MXA;
				case 'b': return MXB;
				case 'c': return MXC;
				case 'd': return MXD;
				case 'e': return MXE;
				case 'f': return MXF;
				case 'g': return MXG;
				case 'h': return MXH;
				case 'i': return MXI;
				case 'j': return MXJ;
				case 'k': return MXK;
				case 'l': return MXL;
				case 'm': return MXM;
				case 'n': return MXN;
				case 'o': return MXO;
				case 'p': return MXP;
				case 'q': return MXQ;
				case 'r': return MXR;
				case 's': return MXS;
				case 't': return MXT;
				case 'u': return MXU;
				case 'v': return MXV;
				case 'w': return MXW;
				case 'x': return MXX;
				case 'y': return MXY;
				case 'z': return MXZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_my(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return MYB;
				case 'c': return MYC;
				case 'd': return AOG;
				case 'e': return MYE;
				case 'f': return MYF;
				case 'g': return MYG;
				case 'h': return MYH;
				case 'i': return MYI;
				case 'j': return MYJ;
				case 'k': return MYK;
				case 'l': return MYL;
				case 'm': return MYM;
				case 'n': return MYN;
				case 'o': return MYO;
				case 'p': return MYP;
				case 'q': return MYQ;
				case 'r': return MYR;
				case 's': return MYS;
				case 't': return MRY;
				case 'u': return MYU;
				case 'v': return MYV;
				case 'w': return MYW;
				case 'x': return MYX;
				case 'y': return MYY;
				case 'z': return MYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_mz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return MZA;
				case 'b': return MZB;
				case 'c': return MZC;
				case 'd': return MZD;
				case 'e': return MZE;
				case 'g': return MZG;
				case 'h': return MZH;
				case 'i': return MZI;
				case 'j': return MZJ;
				case 'k': return MZK;
				case 'l': return MZL;
				case 'm': return MZM;
				case 'n': return MZN;
				case 'o': return MZO;
				case 'p': return MZP;
				case 'q': return MZQ;
				case 'r': return MZR;
				case 's': return MZS;
				case 't': return MZT;
				case 'u': return MZU;
				case 'v': return MZV;
				case 'w': return MZW;
				case 'x': return MZX;
				case 'y': return MZY;
				case 'z': return MZZ;
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
				case 'a': return NAA;
				case 'b': return NAB;
				case 'c': return NAC;
				case 'd': return XNY;
				case 'e': return NAE;
				case 'f': return NAF;
				case 'g': return NAG;
				case 'h': return NAH;
				case 'i': return NAI;
				case 'j': return NAJ;
				case 'k': return NAK;
				case 'l': return NAL;
				case 'm': return NAM;
				case 'n': return NAN;
				case 'o': return NAO;
				case 'p': return NAP;
				case 'q': return NAQ;
				case 'r': return NAR;
				case 's': return NAS;
				case 't': return NAT;
				case 'w': return NAW;
				case 'x': return NAX;
				case 'y': return NAY;
				case 'z': return NAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NBA;
				case 'b': return NBB;
				case 'c': return NBC;
				case 'd': return NBD;
				case 'e': return NBE;
				case 'f': return NBF;
				case 'g': return NBG;
				case 'h': return NBH;
				case 'i': return NBI;
				case 'j': return NBJ;
				case 'k': return NBK;
				case 'm': return NBM;
				case 'n': return NBN;
				case 'o': return NBO;
				case 'p': return NBP;
				case 'q': return NBQ;
				case 'r': return NBR;
				case 's': return NBS;
				case 't': return NBT;
				case 'u': return NBU;
				case 'v': return NBV;
				case 'w': return NBW;
				case 'x': return NBX;
				case 'y': return NBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NCA;
				case 'b': return NCB;
				case 'c': return NCC;
				case 'd': return NCD;
				case 'e': return NCE;
				case 'f': return NCF;
				case 'g': return NCG;
				case 'h': return NCH;
				case 'i': return NCI;
				case 'j': return NCJ;
				case 'k': return NCK;
				case 'l': return NCL;
				case 'm': return NCM;
				case 'n': return NCN;
				case 'o': return NCO;
				case 'p': return KDZ;
				case 'q': return NCQ;
				case 'r': return NCR;
				case 's': return NCS;
				case 't': return NCT;
				case 'u': return NCU;
				case 'x': return NCX;
				case 'z': return NCZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NDA;
				case 'b': return NDB;
				case 'c': return NDC;
				case 'd': return NDD;
				case 'f': return NDF;
				case 'g': return NDG;
				case 'h': return NDH;
				case 'i': return NDI;
				case 'j': return NDJ;
				case 'k': return NDK;
				case 'l': return NDL;
				case 'm': return NDM;
				case 'n': return NDN;
				case 'p': return NDP;
				case 'q': return NDQ;
				case 'r': return NDR;
				case 's': return NDS;
				case 't': return NDT;
				case 'u': return NDU;
				case 'v': return NDV;
				case 'w': return NDW;
				case 'x': return NDX;
				case 'y': return NDY;
				case 'z': return NDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ne(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NEA;
				case 'b': return NEB;
				case 'c': return NEC;
				case 'd': return NED;
				case 'e': return NEE;
				case 'f': return NEF;
				case 'g': return NEG;
				case 'h': return NEH;
				case 'i': return NEI;
				case 'j': return NEJ;
				case 'k': return NEK;
				case 'm': return NEM;
				case 'n': return NEN;
				case 'o': return NEO;
				case 'q': return NEQ;
				case 'r': return NER;
				case 's': return NES;
				case 't': return NET;
				case 'u': return NEU;
				case 'v': return NEV;
				case 'w': return NEW;
				case 'x': return NEX;
				case 'y': return NEY;
				case 'z': return NEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NFA;
				case 'd': return NFD;
				case 'l': return NFL;
				case 'r': return NFR;
				case 'u': return NFU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ng(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NGA;
				case 'b': return NGB;
				case 'c': return NGC;
				case 'd': return NGD;
				case 'e': return NGE;
				case 'f': return NGF;
				case 'g': return NGG;
				case 'h': return NGH;
				case 'i': return NGI;
				case 'j': return NGJ;
				case 'k': return NGK;
				case 'l': return NGL;
				case 'm': return NGM;
				case 'n': return NGN;
				case 'o': return NGO;
				case 'p': return NGP;
				case 'q': return NGQ;
				case 'r': return NGR;
				case 's': return NGS;
				case 't': return NGT;
				case 'u': return NGU;
				case 'v': return NGV;
				case 'w': return NGW;
				case 'x': return NGX;
				case 'y': return NGY;
				case 'z': return NGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NHA;
				case 'b': return NHB;
				case 'c': return NHC;
				case 'd': return NHD;
				case 'e': return NHE;
				case 'f': return NHF;
				case 'g': return NHG;
				case 'h': return NHH;
				case 'i': return NHI;
				case 'k': return NHK;
				case 'm': return NHM;
				case 'n': return NHN;
				case 'o': return NHO;
				case 'p': return NHP;
				case 'q': return NHQ;
				case 'r': return NHR;
				case 't': return NHT;
				case 'u': return NHU;
				case 'v': return NHV;
				case 'w': return NHW;
				case 'x': return NHX;
				case 'y': return NHY;
				case 'z': return NHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ni(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NIA;
				case 'b': return NIB;
				case 'c': return NIC;
				case 'd': return NID;
				case 'e': return NIE;
				case 'f': return NIF;
				case 'g': return NIG;
				case 'h': return NIH;
				case 'i': return NII;
				case 'j': return NIJ;
				case 'k': return NIK;
				case 'l': return NIL;
				case 'm': return NIM;
				case 'n': return NIN;
				case 'o': return NIO;
				case 'q': return NIQ;
				case 'r': return NIR;
				case 's': return NIS;
				case 't': return NIT;
				case 'u': return NIU;
				case 'v': return NIV;
				case 'w': return NIW;
				case 'x': return NIX;
				case 'y': return NIY;
				case 'z': return NIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NJA;
				case 'b': return NJB;
				case 'd': return NJD;
				case 'h': return NJH;
				case 'i': return NJI;
				case 'j': return NJJ;
				case 'l': return NJL;
				case 'm': return NJM;
				case 'n': return NJN;
				case 'o': return NJO;
				case 'r': return NJR;
				case 's': return NJS;
				case 't': return NJT;
				case 'u': return NJU;
				case 'x': return NJX;
				case 'y': return NJY;
				case 'z': return NJZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NKA;
				case 'b': return NKB;
				case 'c': return NKC;
				case 'd': return NKD;
				case 'e': return NKE;
				case 'f': return NKF;
				case 'g': return NKG;
				case 'h': return NKH;
				case 'i': return NKI;
				case 'j': return NKJ;
				case 'k': return NKK;
				case 'm': return NKM;
				case 'n': return NKN;
				case 'o': return NKO;
				case 'p': return NKP;
				case 'q': return NKQ;
				case 'r': return NKR;
				case 's': return NKS;
				case 't': return NKT;
				case 'u': return NKU;
				case 'v': return NKV;
				case 'w': return NKW;
				case 'x': return NKX;
				case 'z': return NKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NLA;
				case 'c': return NLC;
				case 'e': return NLE;
				case 'g': return NLG;
				case 'i': return NLI;
				case 'j': return NLJ;
				case 'k': return NLK;
				case 'l': return NLL;
				case 'm': return NLM;
				case 'n': return NLN;
				case 'o': return NLO;
				case 'q': return NLQ;
				case 'r': return NLR;
				case 'u': return NLU;
				case 'v': return NLV;
				case 'w': return NLW;
				case 'x': return NLX;
				case 'y': return NLY;
				case 'z': return NLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NMA;
				case 'b': return NMB;
				case 'c': return NMC;
				case 'd': return NMD;
				case 'e': return NME;
				case 'f': return NMF;
				case 'g': return NMG;
				case 'h': return NMH;
				case 'i': return NMI;
				case 'j': return NMJ;
				case 'k': return NMK;
				case 'l': return NML;
				case 'm': return NMM;
				case 'n': return NMN;
				case 'o': return NMO;
				case 'p': return NMP;
				case 'q': return NMQ;
				case 'r': return NMR;
				case 's': return NMS;
				case 't': return NMT;
				case 'u': return NMU;
				case 'v': return NMV;
				case 'w': return NMW;
				case 'x': return NMX;
				case 'y': return NMY;
				case 'z': return NMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NNA;
				case 'b': return NNB;
				case 'c': return NNC;
				case 'd': return NND;
				case 'e': return NNE;
				case 'f': return NNF;
				case 'g': return NNG;
				case 'h': return NNH;
				case 'i': return NNI;
				case 'j': return NNJ;
				case 'k': return NNK;
				case 'l': return NNL;
				case 'm': return NNM;
				case 'n': return NNN;
				case 'p': return NNP;
				case 'q': return NNQ;
				case 'r': return NNR;
				case 's': return NBR;
				case 't': return NNT;
				case 'u': return NNU;
				case 'v': return NNV;
				case 'w': return NNW;
				case 'x': return NGV;
				case 'y': return NNY;
				case 'z': return NNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_no(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NOA;
				case 'c': return NOC;
				case 'd': return NOD;
				case 'e': return NOE;
				case 'f': return NOF;
				case 'g': return NOG;
				case 'h': return NOH;
				case 'i': return NOI;
				case 'j': return NOJ;
				case 'k': return NOK;
				case 'l': return NOL;
				case 'm': return NOM;
				case 'n': return NON;
				case 'o': return NOO;
				case 'p': return NOP;
				case 'q': return NOQ;
				case 's': return NOS;
				case 't': return NOT;
				case 'u': return NOU;
				case 'v': return NOV;
				case 'w': return NOW;
				case 'y': return NOY;
				case 'z': return NOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_np(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NPA;
				case 'b': return NPB;
				case 'g': return NPG;
				case 'h': return NPH;
				case 'i': return NPI;
				case 'l': return NPL;
				case 'n': return NPN;
				case 'o': return NPO;
				case 's': return NPS;
				case 'u': return NPU;
				case 'x': return NPX;
				case 'y': return NPY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nq(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return NQG;
				case 'k': return NQK;
				case 'l': return NQL;
				case 'm': return NQM;
				case 'n': return NQN;
				case 'o': return NQO;
				case 'q': return NQQ;
				case 'y': return NQY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NRA;
				case 'b': return NRB;
				case 'c': return NRC;
				case 'e': return NRE;
				case 'f': return NRF;
				case 'g': return NRG;
				case 'i': return NRI;
				case 'k': return NRK;
				case 'l': return NRL;
				case 'm': return NRM;
				case 'n': return NRN;
				case 'p': return NRP;
				case 'r': return NRR;
				case 't': return NRT;
				case 'u': return NRU;
				case 'x': return NRX;
				case 'z': return NRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ns(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NSA;
				case 'b': return NSB;
				case 'c': return NSC;
				case 'd': return NSD;
				case 'e': return NSE;
				case 'f': return NSF;
				case 'g': return NSG;
				case 'h': return NSH;
				case 'i': return NSI;
				case 'k': return NSK;
				case 'l': return NSL;
				case 'm': return NSM;
				case 'n': return NSN;
				case 'o': return NSO;
				case 'p': return NSP;
				case 'q': return NSQ;
				case 'r': return NSR;
				case 's': return NSS;
				case 't': return NST;
				case 'u': return NSU;
				case 'v': return NSV;
				case 'w': return NSW;
				case 'x': return NSX;
				case 'y': return NSY;
				case 'z': return NSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nt(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return NTD;
				case 'e': return NTE;
				case 'g': return NTG;
				case 'i': return NTI;
				case 'j': return NTJ;
				case 'k': return NTK;
				case 'm': return NTM;
				case 'o': return NTO;
				case 'p': return NTP;
				case 'r': return NTR;
				case 's': return PIJ;
				case 'u': return NTU;
				case 'w': return NTW;
				case 'x': return NTX;
				case 'y': return NTY;
				case 'z': return NTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NUA;
				case 'b': return NUB;
				case 'c': return NUC;
				case 'd': return NUD;
				case 'e': return NUE;
				case 'f': return NUF;
				case 'g': return NUG;
				case 'h': return NUH;
				case 'i': return NUI;
				case 'j': return NUJ;
				case 'k': return NUK;
				case 'l': return NUL;
				case 'm': return NUM;
				case 'n': return NUN;
				case 'o': return NUO;
				case 'p': return NUP;
				case 'q': return NUQ;
				case 'r': return NUR;
				case 's': return NUS;
				case 't': return NUT;
				case 'u': return NUU;
				case 'v': return NUV;
				case 'w': return NUW;
				case 'x': return NUX;
				case 'y': return NUY;
				case 'z': return NUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nv(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return NVH;
				case 'm': return NVM;
				case 'o': return NVO;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NWA;
				case 'b': return NWB;
				case 'c': return NWC;
				case 'e': return NWE;
				case 'g': return NWG;
				case 'i': return NWI;
				case 'm': return NWM;
				case 'o': return NWO;
				case 'r': return NWR;
				case 'x': return NWX;
				case 'y': return NWY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NXA;
				case 'd': return NXD;
				case 'e': return NXE;
				case 'g': return NXG;
				case 'i': return NXI;
				case 'k': return NXK;
				case 'l': return NXL;
				case 'm': return NXM;
				case 'n': return NXN;
				case 'o': return NXO;
				case 'q': return NXQ;
				case 'r': return NXR;
				case 'u': return BPP;
				case 'x': return NXX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ny(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return NYB;
				case 'c': return NYC;
				case 'd': return NYD;
				case 'e': return NYE;
				case 'f': return NYF;
				case 'g': return NYG;
				case 'h': return NYH;
				case 'i': return NYI;
				case 'j': return NYJ;
				case 'k': return NYK;
				case 'l': return NYL;
				case 'm': return NYM;
				case 'n': return NYN;
				case 'o': return NYO;
				case 'p': return NYP;
				case 'q': return NYQ;
				case 'r': return NYR;
				case 's': return NYS;
				case 't': return NYT;
				case 'u': return NYU;
				case 'v': return NYV;
				case 'w': return NYW;
				case 'x': return NYX;
				case 'y': return NYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_nz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return NZA;
				case 'b': return NZB;
				case 'd': return NZD;
				case 'i': return NZI;
				case 'k': return NZK;
				case 'm': return NZM;
				case 's': return NZS;
				case 'u': return NZU;
				case 'y': return NZY;
				case 'z': return NZZ;
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
				case 'a': return OAA;
				case 'c': return OAC;
				case 'r': return OAR;
				case 'v': return OAV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ob(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return OBI;
				case 'k': return OBK;
				case 'l': return OBL;
				case 'm': return OBM;
				case 'o': return OBO;
				case 'r': return OBR;
				case 't': return OBT;
				case 'u': return OBU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OCA;
				case 'h': return OCH;
				case 'o': return OCO;
				case 'u': return OCU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_od(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ODA;
				case 'k': return ODK;
				case 't': return ODT;
				case 'u': return ODU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_of(StringSpan span)
		{
			switch(span[2])
			{
				case 'o': return OFO;
				case 's': return OFS;
				case 'u': return OFU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_og(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OGB;
				case 'c': return OGC;
				case 'e': return OGE;
				case 'g': return OGG;
				case 'o': return OGO;
				case 'u': return OGU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oh(StringSpan span)
		{
			switch(span[2])
			{
				case 't': return OHT;
				case 'u': return OHU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OIA;
				case 'n': return OIN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oj(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OJB;
				case 'c': return OJC;
				case 'g': return OJG;
				case 'p': return OJP;
				case 's': return OJS;
				case 'v': return OJV;
				case 'w': return OJW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ok(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OKA;
				case 'b': return OKB;
				case 'd': return OKD;
				case 'e': return OKE;
				case 'g': return OKG;
				case 'h': return OKH;
				case 'i': return OKI;
				case 'j': return OKJ;
				case 'k': return OKK;
				case 'l': return OKL;
				case 'm': return OKM;
				case 'n': return OKN;
				case 'o': return OKO;
				case 'r': return OKR;
				case 's': return OKS;
				case 'u': return OKU;
				case 'v': return OKV;
				case 'x': return OKX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ol(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OLA;
				case 'd': return OLD;
				case 'e': return OLE;
				case 'k': return OLK;
				case 'm': return OLM;
				case 'o': return OLO;
				case 'r': return OLR;
				case 't': return OLT;
				case 'u': return OLU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_om(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OMA;
				case 'b': return OMB;
				case 'c': return OMC;
				case 'e': return OME;
				case 'g': return OMG;
				case 'i': return OMI;
				case 'k': return OMK;
				case 'l': return OML;
				case 'n': return OMN;
				case 'o': return OMO;
				case 'p': return OMP;
				case 'q': return OMQ;
				case 'r': return OMR;
				case 't': return OMT;
				case 'u': return OMU;
				case 'v': return OMV;
				case 'w': return OMW;
				case 'x': return OMX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_on(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ONA;
				case 'b': return ONB;
				case 'e': return ONE;
				case 'g': return ONG;
				case 'i': return ONI;
				case 'j': return ONJ;
				case 'k': return ONK;
				case 'n': return ONN;
				case 'o': return ONO;
				case 'p': return ONP;
				case 'r': return ONR;
				case 's': return ONS;
				case 't': return ONT;
				case 'u': return ONU;
				case 'w': return ONW;
				case 'x': return ONX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oo(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return OOD;
				case 'g': return OOG;
				case 'n': return OON;
				case 'r': return OOR;
				case 's': return OOS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_op(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OPA;
				case 'k': return OPK;
				case 'm': return OPM;
				case 'o': return OPO;
				case 't': return OPT;
				case 'y': return OPY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_or(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ORA;
				case 'c': return ORC;
				case 'e': return ORE;
				case 'g': return ORG;
				case 'h': return ORH;
				case 'n': return ORN;
				case 'o': return ORO;
				case 'r': return ORR;
				case 's': return ORS;
				case 't': return ORT;
				case 'u': return ORU;
				case 'v': return ORV;
				case 'w': return ORW;
				case 'x': return ORX;
				case 'y': return ORY;
				case 'z': return ORZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_os(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OSA;
				case 'c': return OSC;
				case 'i': return OSI;
				case 'o': return OSO;
				case 'p': return OSP;
				case 't': return OST;
				case 'u': return OSU;
				case 'x': return OSX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ot(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OTA;
				case 'b': return OTB;
				case 'd': return OTD;
				case 'e': return OTE;
				case 'i': return OTI;
				case 'k': return OTK;
				case 'l': return OTL;
				case 'm': return OTM;
				case 'n': return OTN;
				case 'o': return OTO;
				case 'q': return OTQ;
				case 'r': return OTR;
				case 's': return OTS;
				case 't': return OTT;
				case 'u': return OTU;
				case 'w': return OTW;
				case 'x': return OTX;
				case 'y': return OTY;
				case 'z': return OTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ou(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return OUA;
				case 'b': return OUB;
				case 'e': return OUE;
				case 'i': return OUI;
				case 'm': return OUM;
				case 'n': return VAJ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ov(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return OVD;
			return null;
		}
		
		private static Language? tryParse_L3_ow(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return OWI;
				case 'l': return OWL;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oy(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return OYB;
				case 'd': return OYD;
				case 'm': return OYM;
				case 'y': return OYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_oz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return OZM;
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
				case 'a': return PAA;
				case 'b': return PAB;
				case 'c': return PAC;
				case 'd': return PAD;
				case 'e': return PAE;
				case 'f': return PAF;
				case 'g': return PAG;
				case 'h': return PAH;
				case 'i': return PAI;
				case 'k': return PAK;
				case 'l': return PAL;
				case 'm': return PAM;
				case 'o': return PAO;
				case 'p': return PAP;
				case 'q': return PAQ;
				case 'r': return PAR;
				case 's': return PAS;
				case 't': return PAT;
				case 'u': return PAU;
				case 'v': return PAV;
				case 'w': return PAW;
				case 'x': return PAX;
				case 'y': return PAY;
				case 'z': return PAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return PBB;
				case 'c': return PBC;
				case 'e': return PBE;
				case 'f': return PBF;
				case 'g': return PBG;
				case 'h': return PBH;
				case 'i': return PBI;
				case 'l': return PBL;
				case 'm': return PBM;
				case 'n': return PBN;
				case 'o': return PBO;
				case 'p': return PBP;
				case 'r': return PBR;
				case 's': return PBS;
				case 't': return PBT;
				case 'u': return PBU;
				case 'v': return PBV;
				case 'y': return PBY;
				case 'z': return PBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PCA;
				case 'b': return PCB;
				case 'c': return PCC;
				case 'd': return PCD;
				case 'e': return PCE;
				case 'f': return PCF;
				case 'g': return PCG;
				case 'h': return PCH;
				case 'i': return PCI;
				case 'j': return PCJ;
				case 'k': return PCK;
				case 'l': return PCL;
				case 'm': return PCM;
				case 'n': return PCN;
				case 'p': return PCP;
				case 'r': return ADX;
				case 'w': return PCW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PDA;
				case 'c': return PDC;
				case 'i': return PDI;
				case 'n': return PDN;
				case 'o': return PDO;
				case 't': return PDT;
				case 'u': return PDU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pe(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PEA;
				case 'b': return PEB;
				case 'd': return PED;
				case 'e': return PEE;
				case 'f': return PEF;
				case 'g': return PEG;
				case 'h': return PEH;
				case 'i': return PEI;
				case 'j': return PEJ;
				case 'k': return PEK;
				case 'l': return PEL;
				case 'm': return PEM;
				case 'o': return PEO;
				case 'p': return PEP;
				case 'q': return PEQ;
				case 's': return PES;
				case 'v': return PEV;
				case 'x': return PEX;
				case 'y': return PEY;
				case 'z': return PEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PFA;
				case 'e': return PFE;
				case 'l': return PFL;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PGA;
				case 'd': return PGD;
				case 'g': return PGG;
				case 'i': return PGI;
				case 'k': return PGK;
				case 'l': return PGL;
				case 'n': return PGN;
				case 's': return PGS;
				case 'u': return PGU;
				case 'y': return PGY;
				case 'z': return PGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ph(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PHA;
				case 'd': return PHD;
				case 'g': return PHG;
				case 'h': return PHH;
				case 'i': return PHI;
				case 'k': return PHK;
				case 'l': return PHL;
				case 'm': return PHM;
				case 'n': return PHN;
				case 'o': return PHO;
				case 'q': return PHQ;
				case 'r': return PHR;
				case 't': return PHT;
				case 'u': return PHU;
				case 'v': return PHV;
				case 'w': return PHW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PIA;
				case 'b': return PIB;
				case 'c': return PIC;
				case 'd': return PID;
				case 'e': return PIE;
				case 'f': return PIF;
				case 'g': return PIG;
				case 'h': return PIH;
				case 'i': return PII;
				case 'j': return PIJ;
				case 'l': return PIL;
				case 'm': return PIM;
				case 'n': return PIN;
				case 'o': return PIO;
				case 'p': return PIP;
				case 'r': return PIR;
				case 's': return PIS;
				case 't': return PIT;
				case 'u': return PIU;
				case 'v': return PIV;
				case 'w': return PIW;
				case 'x': return PIX;
				case 'y': return PIY;
				case 'z': return PIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return PJT;
			return null;
		}
		
		private static Language? tryParse_L3_pk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PKA;
				case 'b': return PKB;
				case 'c': return PKC;
				case 'g': return PKG;
				case 'h': return PKH;
				case 'n': return PKN;
				case 'o': return PKO;
				case 'p': return PKP;
				case 'r': return PKR;
				case 's': return PKS;
				case 't': return PKT;
				case 'u': return PKU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PLA;
				case 'b': return PLB;
				case 'c': return PLC;
				case 'd': return PLD;
				case 'e': return PLE;
				case 'f': return PLF;
				case 'g': return PLG;
				case 'h': return PLH;
				case 'j': return PLJ;
				case 'k': return PLK;
				case 'l': return PLL;
				case 'n': return PLN;
				case 'o': return PLO;
				case 'p': return PLP;
				case 'q': return PLQ;
				case 'r': return PLR;
				case 's': return PLS;
				case 't': return PLT;
				case 'u': return PLU;
				case 'v': return PLV;
				case 'w': return PLW;
				case 'y': return PLY;
				case 'z': return PLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PMA;
				case 'b': return PMB;
				case 'c': return HUW;
				case 'd': return PMD;
				case 'e': return PME;
				case 'f': return PMF;
				case 'h': return PMH;
				case 'i': return PMI;
				case 'j': return PMJ;
				case 'k': return PMK;
				case 'l': return PML;
				case 'm': return PMM;
				case 'n': return PMN;
				case 'o': return PMO;
				case 'q': return PMQ;
				case 'r': return PMR;
				case 's': return PMS;
				case 't': return PMT;
				case 'u': return PHR;
				case 'w': return PMW;
				case 'x': return PMX;
				case 'y': return PMY;
				case 'z': return PMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PNA;
				case 'b': return PNB;
				case 'c': return PNC;
				case 'd': return PND;
				case 'e': return PNE;
				case 'g': return PNG;
				case 'h': return PNH;
				case 'i': return PNI;
				case 'j': return PNJ;
				case 'k': return PNK;
				case 'l': return PNL;
				case 'm': return PNM;
				case 'n': return PNN;
				case 'o': return PNO;
				case 'p': return PNP;
				case 'q': return PNQ;
				case 'r': return PNR;
				case 's': return PNS;
				case 't': return PNT;
				case 'u': return PNU;
				case 'v': return PNV;
				case 'w': return PNW;
				case 'x': return PNX;
				case 'y': return PNY;
				case 'z': return PNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_po(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return POC;
				case 'd': return POD;
				case 'e': return POE;
				case 'f': return POF;
				case 'g': return POG;
				case 'h': return POH;
				case 'i': return POI;
				case 'k': return POK;
				case 'm': return POM;
				case 'n': return PON;
				case 'o': return POO;
				case 'p': return POP;
				case 'q': return POQ;
				case 's': return POS;
				case 't': return POT;
				case 'v': return POV;
				case 'w': return POW;
				case 'x': return POX;
				case 'y': return POY;
				case 'z': return POZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return BFY;
				case 'e': return PPE;
				case 'i': return PPI;
				case 'k': return PPK;
				case 'l': return PPL;
				case 'm': return PPM;
				case 'n': return PPN;
				case 'o': return PPO;
				case 'p': return PPP;
				case 'q': return PPQ;
				case 'r': return LCQ;
				case 's': return PPS;
				case 't': return PPT;
				case 'u': return PPU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PQA;
				case 'e': return PQE;
				case 'm': return PQM;
				case 'w': return PQW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PRA;
				case 'b': return PRB;
				case 'c': return PRC;
				case 'd': return PRD;
				case 'e': return PRE;
				case 'f': return PRF;
				case 'g': return PRG;
				case 'h': return PRH;
				case 'i': return PRI;
				case 'k': return PRK;
				case 'l': return PRL;
				case 'm': return PRM;
				case 'n': return PRN;
				case 'o': return PRO;
				case 'p': return PRP;
				case 'q': return PRQ;
				case 'r': return PRR;
				case 's': return PRS;
				case 't': return PRT;
				case 'u': return PRU;
				case 'w': return PRW;
				case 'x': return PRX;
				case 'y': return PRT;
				case 'z': return PRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ps(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PSA;
				case 'c': return PSC;
				case 'd': return PSD;
				case 'e': return PSE;
				case 'g': return PSG;
				case 'h': return PSH;
				case 'i': return PSI;
				case 'l': return PSL;
				case 'm': return PSM;
				case 'n': return PSN;
				case 'o': return PSO;
				case 'p': return PSP;
				case 'q': return PSQ;
				case 'r': return PSR;
				case 's': return PSS;
				case 't': return PST;
				case 'u': return PSU;
				case 'w': return PSW;
				case 'y': return PSY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PTA;
				case 'h': return PTH;
				case 'i': return PTI;
				case 'n': return PTN;
				case 'o': return PTO;
				case 'p': return PTP;
				case 'q': return PTQ;
				case 'r': return PTR;
				case 't': return PTT;
				case 'u': return PTU;
				case 'v': return PTV;
				case 'w': return PTW;
				case 'y': return PTY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PUA;
				case 'b': return PUB;
				case 'c': return PUC;
				case 'd': return PUD;
				case 'e': return PUE;
				case 'f': return PUF;
				case 'g': return PUG;
				case 'i': return PUI;
				case 'j': return PUJ;
				case 'k': return PUK;
				case 'm': return PUM;
				case 'o': return PUO;
				case 'p': return PUP;
				case 'q': return PUQ;
				case 'r': return PUR;
				case 't': return PUT;
				case 'u': return PUU;
				case 'w': return PUW;
				case 'x': return PUX;
				case 'y': return PUY;
				case 'z': return PUB;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return PWA;
				case 'b': return PWB;
				case 'g': return PWG;
				case 'i': return PWI;
				case 'm': return PWM;
				case 'n': return PWN;
				case 'o': return PWO;
				case 'r': return PWR;
				case 'w': return PWW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_px(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return PXM;
			return null;
		}
		
		private static Language? tryParse_L3_py(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return PYE;
				case 'm': return PYM;
				case 'n': return PYN;
				case 's': return PYS;
				case 'u': return PYU;
				case 'x': return PYX;
				case 'y': return PYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_pz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return PZN;
			return null;
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
				case 'a': return QUA;
				case 'b': return QUB;
				case 'c': return QUC;
				case 'd': return QUD;
				case 'f': return QUF;
				case 'g': return QUG;
				case 'h': return QUH;
				case 'i': return QUI;
				case 'k': return QUK;
				case 'l': return QUL;
				case 'm': return QUM;
				case 'n': return QUN;
				case 'p': return QUP;
				case 'q': return QUQ;
				case 'r': return QUR;
				case 's': return QUS;
				case 'v': return QUV;
				case 'w': return QUW;
				case 'x': return QUX;
				case 'y': return QUY;
				case 'z': return QUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QVA;
				case 'c': return QVC;
				case 'e': return QVE;
				case 'h': return QVH;
				case 'i': return QVI;
				case 'j': return QVJ;
				case 'l': return QVL;
				case 'm': return QVM;
				case 'n': return QVN;
				case 'o': return QVO;
				case 'p': return QVP;
				case 's': return QVS;
				case 'w': return QVW;
				case 'y': return QVY;
				case 'z': return QVZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QWA;
				case 'c': return QWC;
				case 'e': return QWE;
				case 'h': return QWH;
				case 'm': return QWM;
				case 's': return QWS;
				case 't': return QWT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QXA;
				case 'c': return QXC;
				case 'h': return QXH;
				case 'l': return QXL;
				case 'n': return QXN;
				case 'o': return QXO;
				case 'p': return QXP;
				case 'q': return QXQ;
				case 'r': return QXR;
				case 's': return QXS;
				case 't': return QXT;
				case 'u': return QXU;
				case 'w': return QXW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_qy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return QYA;
				case 'p': return QYP;
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
				case 'a': return RAA;
				case 'b': return RAB;
				case 'c': return RAC;
				case 'd': return RAD;
				case 'f': return RAF;
				case 'g': return RAG;
				case 'h': return RAH;
				case 'i': return RAI;
				case 'j': return RAJ;
				case 'k': return RAK;
				case 'l': return RAL;
				case 'm': return RAM;
				case 'n': return RAN;
				case 'o': return RAO;
				case 'p': return RAP;
				case 'q': return RAQ;
				case 'r': return RAR;
				case 's': return RAS;
				case 't': return RAT;
				case 'u': return RAU;
				case 'v': return RAV;
				case 'w': return RAW;
				case 'x': return RAX;
				case 'y': return RAY;
				case 'z': return RAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RBB;
				case 'k': return RBK;
				case 'l': return RBL;
				case 'p': return RBP;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'f')
				return RCF;
			return null;
		}
		
		private static Language? tryParse_L3_rd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'b')
				return RDB;
			return null;
		}
		
		private static Language? tryParse_L3_re(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return REA;
				case 'b': return REB;
				case 'e': return REE;
				case 'g': return REG;
				case 'i': return REI;
				case 'j': return REJ;
				case 'l': return REL;
				case 'm': return REM;
				case 'n': return REN;
				case 'r': return RER;
				case 's': return RES;
				case 't': return RET;
				case 'y': return REY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RGA;
				case 'e': return RGE;
				case 'k': return RGK;
				case 'n': return RGN;
				case 'r': return RGR;
				case 's': return RGS;
				case 'u': return RGU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rh(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return RHG;
				case 'p': return RHP;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ri(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RIA;
				case 'e': return RIE;
				case 'f': return RIF;
				case 'l': return RIL;
				case 'm': return RIM;
				case 'n': return RIN;
				case 'r': return RIR;
				case 't': return RIT;
				case 'u': return RIU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rj(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return RJG;
				case 'i': return RJI;
				case 's': return RJS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RKA;
				case 'b': return RKB;
				case 'h': return RKH;
				case 'i': return RKI;
				case 'm': return RKM;
				case 't': return RKT;
				case 'w': return RKW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RMA;
				case 'b': return RMB;
				case 'c': return RMC;
				case 'd': return RMD;
				case 'e': return RME;
				case 'f': return RMF;
				case 'g': return RMG;
				case 'h': return RMH;
				case 'i': return RMI;
				case 'k': return RMK;
				case 'l': return RML;
				case 'm': return RMM;
				case 'n': return RMN;
				case 'o': return RMO;
				case 'p': return RMP;
				case 'q': return RMQ;
				case 'r': return RMR;
				case 's': return RMS;
				case 't': return RMT;
				case 'u': return RMU;
				case 'v': return RMV;
				case 'w': return RMW;
				case 'x': return RMX;
				case 'y': return RMY;
				case 'z': return RMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RNA;
				case 'd': return RND;
				case 'g': return RNG;
				case 'l': return RNL;
				case 'n': return RNN;
				case 'p': return RNP;
				case 'r': return RNR;
				case 'w': return RNW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ro(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ROA;
				case 'b': return ROB;
				case 'c': return ROC;
				case 'd': return ROD;
				case 'e': return ROE;
				case 'f': return ROF;
				case 'g': return ROG;
				case 'l': return ROL;
				case 'm': return ROM;
				case 'o': return ROO;
				case 'p': return ROP;
				case 'r': return ROR;
				case 'u': return ROU;
				case 'w': return ROW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rp(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return RPN;
				case 't': return RPT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rr(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return RRI;
				case 'o': return RRO;
				case 't': return RRT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rs(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RSB;
				case 'i': return RSI;
				case 'l': return RSL;
				case 'm': return RSM;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rt(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return RTC;
				case 'h': return RTH;
				case 'm': return RTM;
				case 's': return RTS;
				case 'w': return RTW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ru(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return RUB;
				case 'c': return RUC;
				case 'e': return RUE;
				case 'f': return RUF;
				case 'g': return RUG;
				case 'h': return RUH;
				case 'i': return RUI;
				case 'k': return RUK;
				case 'o': return RUO;
				case 'p': return RUP;
				case 'q': return RUQ;
				case 't': return RUT;
				case 'u': return RUU;
				case 'y': return RUY;
				case 'z': return RUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return RWA;
				case 'k': return RWK;
				case 'm': return RWM;
				case 'o': return RWO;
				case 'r': return RWR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rx(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return RXD;
				case 'w': return RXW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ry(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return RYN;
				case 's': return RYS;
				case 'u': return RYU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_rz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return RZH;
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
				case 'a': return SAA;
				case 'b': return SAB;
				case 'c': return SAC;
				case 'd': return SAD;
				case 'e': return SAE;
				case 'f': return SAF;
				case 'h': return SAH;
				case 'i': return SAI;
				case 'j': return SAJ;
				case 'k': return SAK;
				case 'l': return SAL;
				case 'm': return SAM;
				case 'o': return SAO;
				case 'p': return SAP;
				case 'q': return SAQ;
				case 'r': return SAR;
				case 's': return SAS;
				case 't': return SAT;
				case 'u': return SAU;
				case 'v': return SAV;
				case 'w': return SAW;
				case 'x': return SAX;
				case 'y': return SAY;
				case 'z': return SAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SBA;
				case 'b': return SBB;
				case 'c': return SBC;
				case 'd': return SBD;
				case 'e': return SBE;
				case 'f': return SBF;
				case 'g': return SBG;
				case 'h': return SBH;
				case 'i': return SBI;
				case 'j': return SBJ;
				case 'k': return SBK;
				case 'l': return SBL;
				case 'm': return SBM;
				case 'n': return SBN;
				case 'o': return SBO;
				case 'p': return SBP;
				case 'q': return SBQ;
				case 'r': return SBR;
				case 's': return SBS;
				case 't': return SBT;
				case 'u': return SBU;
				case 'v': return SBV;
				case 'w': return SBW;
				case 'x': return SBX;
				case 'y': return SBY;
				case 'z': return SBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return HLE;
				case 'b': return SCB;
				case 'e': return SCE;
				case 'f': return SCF;
				case 'g': return SCG;
				case 'h': return SCH;
				case 'i': return SCI;
				case 'k': return SCK;
				case 'l': return SCL;
				case 'n': return SCN;
				case 'o': return SCO;
				case 'p': return SCP;
				case 'q': return SCQ;
				case 's': return SCS;
				case 't': return SCT;
				case 'u': return SCU;
				case 'v': return SCV;
				case 'w': return SCW;
				case 'x': return SCX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SDA;
				case 'b': return SDB;
				case 'c': return SDC;
				case 'e': return SDE;
				case 'f': return SDF;
				case 'g': return SDG;
				case 'h': return SDH;
				case 'j': return SDJ;
				case 'k': return SDK;
				case 'l': return SDL;
				case 'm': return SDM;
				case 'n': return SDN;
				case 'o': return SDO;
				case 'p': return SDP;
				case 'q': return SDQ;
				case 'r': return SDR;
				case 's': return SDS;
				case 't': return SDT;
				case 'u': return SDU;
				case 'v': return SDV;
				case 'x': return SDX;
				case 'z': return SDZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_se(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SEA;
				case 'b': return SEB;
				case 'c': return SEC;
				case 'd': return SED;
				case 'e': return SEE;
				case 'f': return SEF;
				case 'g': return SEG;
				case 'h': return SEH;
				case 'i': return SEI;
				case 'j': return SEJ;
				case 'k': return SEK;
				case 'l': return SEL;
				case 'm': return SEM;
				case 'n': return SEN;
				case 'o': return SEO;
				case 'p': return SEP;
				case 'q': return SEQ;
				case 'r': return SER;
				case 's': return SES;
				case 't': return SET;
				case 'u': return SEU;
				case 'v': return SEV;
				case 'w': return SEW;
				case 'y': return SEY;
				case 'z': return SEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sf(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SFB;
				case 'e': return SFE;
				case 'm': return SFM;
				case 's': return SFS;
				case 'w': return SFW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SGA;
				case 'b': return SGB;
				case 'c': return SGC;
				case 'd': return SGD;
				case 'e': return SGE;
				case 'g': return SGG;
				case 'h': return SGH;
				case 'i': return SGI;
				case 'j': return SGJ;
				case 'k': return SGK;
				case 'l': return SGL;
				case 'm': return SGM;
				case 'n': return SGN;
				case 'o': return SGO;
				case 'p': return SGP;
				case 'r': return SGR;
				case 's': return SGS;
				case 't': return SGT;
				case 'u': return SGU;
				case 'w': return SGW;
				case 'x': return SGX;
				case 'y': return SGY;
				case 'z': return SGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SHA;
				case 'b': return SHB;
				case 'c': return SHC;
				case 'd': return SHD;
				case 'e': return SHE;
				case 'g': return SHG;
				case 'h': return SHH;
				case 'i': return SHI;
				case 'j': return SHJ;
				case 'k': return SHK;
				case 'l': return SHL;
				case 'm': return SHM;
				case 'n': return SHN;
				case 'o': return SHO;
				case 'p': return SHP;
				case 'q': return SHQ;
				case 'r': return SHR;
				case 's': return SHS;
				case 't': return SHT;
				case 'u': return SHU;
				case 'v': return SHV;
				case 'w': return SHW;
				case 'x': return SHX;
				case 'y': return SHY;
				case 'z': return SHZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_si(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SIA;
				case 'b': return SIB;
				case 'd': return SID;
				case 'e': return SIE;
				case 'f': return SIF;
				case 'g': return SIG;
				case 'h': return SIH;
				case 'i': return SII;
				case 'j': return SIJ;
				case 'k': return SIK;
				case 'l': return SIL;
				case 'm': return SIM;
				case 'o': return SIO;
				case 'p': return SIP;
				case 'q': return SIQ;
				case 'r': return SIR;
				case 's': return SIS;
				case 't': return SIT;
				case 'u': return SIU;
				case 'v': return SIV;
				case 'w': return SIW;
				case 'x': return SIX;
				case 'y': return SIY;
				case 'z': return SIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SJA;
				case 'b': return SJB;
				case 'd': return SJD;
				case 'e': return SJE;
				case 'g': return SJG;
				case 'k': return SJK;
				case 'l': return SJL;
				case 'm': return SJM;
				case 'n': return SJN;
				case 'o': return SJO;
				case 'p': return SJP;
				case 'r': return SJR;
				case 's': return SJS;
				case 't': return SJT;
				case 'u': return SJU;
				case 'w': return SJW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SKA;
				case 'b': return SKB;
				case 'c': return SKC;
				case 'd': return SKD;
				case 'e': return SKE;
				case 'f': return SKF;
				case 'g': return SKG;
				case 'h': return SKH;
				case 'i': return SKI;
				case 'j': return SKJ;
				case 'k': return OYB;
				case 'm': return SKM;
				case 'n': return SKN;
				case 'o': return SKO;
				case 'p': return SKP;
				case 'q': return SKQ;
				case 'r': return SKR;
				case 's': return SKS;
				case 't': return SKT;
				case 'u': return SKU;
				case 'v': return SKV;
				case 'w': return SKW;
				case 'x': return SKX;
				case 'y': return SKY;
				case 'z': return SKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SLA;
				case 'c': return SLC;
				case 'd': return SLD;
				case 'e': return SLE;
				case 'f': return SLF;
				case 'g': return SLG;
				case 'h': return SLH;
				case 'i': return SLI;
				case 'j': return SLJ;
				case 'l': return SLL;
				case 'm': return SLM;
				case 'n': return SLN;
				case 'p': return SLP;
				case 'q': return SLQ;
				case 'r': return SLR;
				case 's': return SLS;
				case 't': return SLT;
				case 'u': return SLU;
				case 'w': return SLW;
				case 'x': return SLX;
				case 'y': return SLY;
				case 'z': return SLZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SMA;
				case 'b': return SMB;
				case 'c': return SMC;
				case 'd': return SMD;
				case 'f': return SMF;
				case 'g': return SMG;
				case 'h': return SMH;
				case 'i': return SMI;
				case 'j': return SMJ;
				case 'k': return SMK;
				case 'l': return SML;
				case 'm': return SMM;
				case 'n': return SMN;
				case 'p': return SMP;
				case 'q': return SMQ;
				case 'r': return SMR;
				case 's': return SMS;
				case 't': return SMT;
				case 'u': return SMU;
				case 'v': return SMV;
				case 'w': return SMW;
				case 'x': return SMX;
				case 'y': return SMY;
				case 'z': return SMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SNB;
				case 'c': return SNC;
				case 'e': return SNE;
				case 'f': return SNF;
				case 'g': return SNG;
				case 'h': return SNH;
				case 'i': return SNI;
				case 'j': return SNJ;
				case 'k': return SNK;
				case 'l': return SNL;
				case 'm': return SNM;
				case 'n': return SNN;
				case 'o': return SNO;
				case 'p': return SNP;
				case 'q': return SNQ;
				case 'r': return SNR;
				case 's': return SNS;
				case 'u': return SNU;
				case 'v': return SNV;
				case 'w': return SNW;
				case 'x': return SNX;
				case 'y': return SNY;
				case 'z': return SNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_so(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SOA;
				case 'b': return SOB;
				case 'c': return SOC;
				case 'd': return SOD;
				case 'e': return SOE;
				case 'g': return SOG;
				case 'h': return SOH;
				case 'i': return SOI;
				case 'j': return SOJ;
				case 'k': return SOK;
				case 'l': return SOL;
				case 'n': return SON;
				case 'o': return SOO;
				case 'p': return SOP;
				case 'q': return SOQ;
				case 'r': return SOR;
				case 's': return SOS;
				case 'u': return SOU;
				case 'v': return SOV;
				case 'w': return SOW;
				case 'x': return SOX;
				case 'y': return SOY;
				case 'z': return SOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sp(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SPB;
				case 'c': return SPC;
				case 'd': return SPD;
				case 'e': return SPE;
				case 'g': return SPG;
				case 'i': return SPI;
				case 'k': return SPK;
				case 'l': return SPL;
				case 'm': return SPM;
				case 'n': return SPN;
				case 'o': return SPO;
				case 'p': return SPP;
				case 'q': return SPQ;
				case 'r': return SPR;
				case 's': return SPS;
				case 't': return SPT;
				case 'u': return SPU;
				case 'v': return SPV;
				case 'x': return SPX;
				case 'y': return SPY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SQA;
				case 'h': return SQH;
				case 'j': return SQJ;
				case 'k': return SQK;
				case 'm': return SQM;
				case 'n': return SQN;
				case 'o': return SQO;
				case 'q': return SQQ;
				case 'r': return SQR;
				case 's': return SQS;
				case 't': return SQT;
				case 'u': return SQU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SRA;
				case 'b': return SRB;
				case 'c': return SRC;
				case 'e': return SRE;
				case 'f': return SRF;
				case 'g': return SRG;
				case 'h': return SRH;
				case 'i': return SRI;
				case 'k': return SRK;
				case 'l': return SRL;
				case 'm': return SRM;
				case 'n': return SRN;
				case 'o': return SRO;
				case 'q': return SRQ;
				case 'r': return SRR;
				case 's': return SRS;
				case 't': return SRT;
				case 'u': return SRU;
				case 'v': return SRV;
				case 'w': return SRW;
				case 'x': return SRX;
				case 'y': return SRY;
				case 'z': return SRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ss(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SSA;
				case 'b': return SSB;
				case 'c': return SSC;
				case 'd': return SSD;
				case 'e': return SSE;
				case 'f': return SSF;
				case 'g': return SSG;
				case 'h': return SSH;
				case 'i': return SSI;
				case 'j': return SSJ;
				case 'k': return SSK;
				case 'l': return SSL;
				case 'm': return SSM;
				case 'n': return SSN;
				case 'o': return SSO;
				case 'p': return SSP;
				case 'q': return SSQ;
				case 'r': return SSR;
				case 's': return SSS;
				case 't': return SST;
				case 'u': return SSU;
				case 'v': return SSV;
				case 'x': return SSX;
				case 'y': return SSY;
				case 'z': return SSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_st(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return STA;
				case 'b': return STB;
				case 'd': return STD;
				case 'e': return STE;
				case 'f': return STF;
				case 'g': return STG;
				case 'h': return STH;
				case 'i': return STI;
				case 'j': return STJ;
				case 'k': return STK;
				case 'l': return STL;
				case 'm': return STM;
				case 'n': return STN;
				case 'o': return STO;
				case 'p': return STP;
				case 'q': return STQ;
				case 'r': return STR;
				case 's': return STS;
				case 't': return STT;
				case 'u': return STU;
				case 'v': return STV;
				case 'w': return STW;
				case 'y': return STY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_su(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SUA;
				case 'b': return SUB;
				case 'c': return SUC;
				case 'e': return SUE;
				case 'g': return SUG;
				case 'i': return SUI;
				case 'j': return SUJ;
				case 'k': return SUK;
				case 'l': return SUL;
				case 'm': return SUM;
				case 'q': return SUQ;
				case 'r': return SUR;
				case 's': return SUS;
				case 't': return SUT;
				case 'v': return SUV;
				case 'w': return SUW;
				case 'x': return SUX;
				case 'y': return SUY;
				case 'z': return SUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SVA;
				case 'b': return SVB;
				case 'c': return SVC;
				case 'e': return SVE;
				case 'k': return SVK;
				case 'm': return SVM;
				case 'r': return SVR;
				case 's': return SVS;
				case 'x': return SVX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sw(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SWB;
				case 'c': return SWC;
				case 'f': return SWF;
				case 'g': return SWG;
				case 'h': return SWH;
				case 'i': return SWI;
				case 'j': return SWJ;
				case 'k': return SWK;
				case 'l': return SWL;
				case 'm': return SWM;
				case 'n': return SWN;
				case 'o': return SWO;
				case 'p': return SWP;
				case 'q': return SWQ;
				case 'r': return SWR;
				case 's': return SWS;
				case 't': return SWT;
				case 'u': return SWU;
				case 'v': return SWV;
				case 'w': return SWW;
				case 'x': return SWX;
				case 'y': return SWY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sx(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return SXB;
				case 'c': return SXC;
				case 'e': return SXE;
				case 'g': return SXG;
				case 'k': return SXK;
				case 'l': return SXL;
				case 'm': return SXM;
				case 'n': return SXN;
				case 'o': return SXO;
				case 'r': return SXR;
				case 's': return SXS;
				case 'u': return SXU;
				case 'w': return SXW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SYA;
				case 'b': return SYB;
				case 'c': return SYC;
				case 'd': return SYD;
				case 'i': return SYI;
				case 'k': return SYK;
				case 'l': return SYL;
				case 'm': return SYM;
				case 'n': return SYN;
				case 'o': return SYO;
				case 'r': return SYR;
				case 's': return SYS;
				case 'w': return SYW;
				case 'x': return SYX;
				case 'y': return SYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_sz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return SZA;
				case 'b': return SZB;
				case 'c': return SZC;
				case 'd': return SZD;
				case 'e': return SZE;
				case 'g': return SZG;
				case 'l': return SZL;
				case 'n': return SZN;
				case 'p': return SZP;
				case 's': return SZS;
				case 'v': return SZV;
				case 'w': return SZW;
				case 'y': return SZY;
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
				case 'a': return TAA;
				case 'b': return TAB;
				case 'c': return TAC;
				case 'd': return TAD;
				case 'e': return TAE;
				case 'f': return TAF;
				case 'g': return TAG;
				case 'i': return TAI;
				case 'j': return TAJ;
				case 'k': return TAK;
				case 'l': return TAL;
				case 'n': return TAN;
				case 'o': return TAO;
				case 'p': return TAP;
				case 'q': return TAQ;
				case 'r': return TAR;
				case 's': return TAS;
				case 'u': return TAU;
				case 'v': return TAV;
				case 'w': return TAW;
				case 'x': return TAX;
				case 'y': return TAY;
				case 'z': return TAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TBA;
				case 'b': return TBB;
				case 'c': return TBC;
				case 'd': return TBD;
				case 'e': return TBE;
				case 'f': return TBF;
				case 'g': return TBG;
				case 'h': return TBH;
				case 'i': return TBI;
				case 'j': return TBJ;
				case 'k': return TBK;
				case 'l': return TBL;
				case 'm': return TBM;
				case 'n': return TBN;
				case 'o': return TBO;
				case 'p': return TBP;
				case 'q': return TBQ;
				case 'r': return TBR;
				case 's': return TBS;
				case 't': return TBT;
				case 'u': return TBU;
				case 'v': return TBV;
				case 'w': return TBW;
				case 'x': return TBX;
				case 'y': return TBY;
				case 'z': return TBZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TCA;
				case 'b': return TCB;
				case 'c': return TCC;
				case 'd': return TCD;
				case 'e': return TCE;
				case 'f': return TCF;
				case 'g': return TCG;
				case 'h': return TCH;
				case 'i': return TCI;
				case 'k': return TCK;
				case 'l': return TCL;
				case 'm': return TCM;
				case 'n': return TCN;
				case 'o': return TCO;
				case 'p': return TCP;
				case 'q': return TCQ;
				case 's': return TCS;
				case 't': return TCT;
				case 'u': return TCU;
				case 'w': return TCW;
				case 'x': return TCX;
				case 'y': return TCY;
				case 'z': return TCZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_td(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TDA;
				case 'b': return TDB;
				case 'c': return TDC;
				case 'd': return TDD;
				case 'e': return TDE;
				case 'f': return TDF;
				case 'g': return TDG;
				case 'h': return TDH;
				case 'i': return TDI;
				case 'j': return TDJ;
				case 'k': return TDK;
				case 'l': return TDL;
				case 'm': return TDM;
				case 'n': return TDN;
				case 'o': return TDO;
				case 'q': return TDQ;
				case 'r': return TDR;
				case 's': return TDS;
				case 't': return TDT;
				case 'u': return DTP;
				case 'v': return TDV;
				case 'x': return TDX;
				case 'y': return TDY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_te(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TEA;
				case 'b': return TEB;
				case 'c': return TEC;
				case 'd': return TED;
				case 'e': return TEE;
				case 'f': return TEF;
				case 'g': return TEG;
				case 'h': return TEH;
				case 'i': return TEI;
				case 'k': return TEK;
				case 'm': return TEM;
				case 'n': return TEN;
				case 'o': return TEO;
				case 'p': return TEP;
				case 'q': return TEQ;
				case 'r': return TER;
				case 's': return TES;
				case 't': return TET;
				case 'u': return TEU;
				case 'v': return TEV;
				case 'w': return TEW;
				case 'x': return TEX;
				case 'y': return TEY;
				case 'z': return TEZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tf(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return TFI;
				case 'n': return TFN;
				case 'o': return TFO;
				case 'r': return TFR;
				case 't': return TFT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TGA;
				case 'b': return TGB;
				case 'c': return TGC;
				case 'd': return TGD;
				case 'e': return TGE;
				case 'f': return TGF;
				case 'g': return TGG;
				case 'h': return TGH;
				case 'i': return TGI;
				case 'j': return TGJ;
				case 'n': return TGN;
				case 'o': return TGO;
				case 'p': return TGP;
				case 'q': return TGQ;
				case 'r': return TGR;
				case 's': return TGS;
				case 't': return TGT;
				case 'u': return TGU;
				case 'v': return TGV;
				case 'w': return TGW;
				case 'x': return TGX;
				case 'y': return TGY;
				case 'z': return TGZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_th(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return TPO;
				case 'd': return THD;
				case 'e': return THE;
				case 'f': return THF;
				case 'h': return THH;
				case 'i': return THI;
				case 'k': return THK;
				case 'l': return THL;
				case 'm': return THM;
				case 'n': return THN;
				case 'p': return THP;
				case 'q': return THQ;
				case 'r': return THR;
				case 's': return THS;
				case 't': return THT;
				case 'u': return THU;
				case 'v': return THV;
				case 'w': return OLA;
				case 'x': return OYB;
				case 'y': return THY;
				case 'z': return THZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ti(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TIA;
				case 'c': return TIC;
				case 'd': return TID;
				case 'e': return RAS;
				case 'f': return TIF;
				case 'g': return TIG;
				case 'h': return TIH;
				case 'i': return TII;
				case 'j': return TIJ;
				case 'k': return TIK;
				case 'l': return TIL;
				case 'm': return TIM;
				case 'n': return TIN;
				case 'o': return TIO;
				case 'p': return TIP;
				case 'q': return TIQ;
				case 's': return TIS;
				case 't': return TIT;
				case 'u': return TIU;
				case 'v': return TIV;
				case 'w': return TIW;
				case 'x': return TIX;
				case 'y': return TIY;
				case 'z': return TIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TJA;
				case 'g': return TJG;
				case 'i': return TJI;
				case 'j': return TJJ;
				case 'l': return TJL;
				case 'm': return TJM;
				case 'n': return TJN;
				case 'o': return TJO;
				case 'p': return TJP;
				case 's': return TJS;
				case 'u': return TJU;
				case 'w': return TJW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TKA;
				case 'b': return TKB;
				case 'd': return TKD;
				case 'e': return TKE;
				case 'f': return TKF;
				case 'g': return TKG;
				case 'k': return TWM;
				case 'l': return TKL;
				case 'm': return TKM;
				case 'n': return TKN;
				case 'p': return TKP;
				case 'q': return TKQ;
				case 'r': return TKR;
				case 's': return TKS;
				case 't': return TKT;
				case 'u': return TKU;
				case 'v': return TKV;
				case 'w': return TKW;
				case 'x': return TKX;
				case 'z': return TKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TLA;
				case 'b': return TLB;
				case 'c': return TLC;
				case 'd': return TLD;
				case 'f': return TLF;
				case 'g': return TLG;
				case 'h': return TLH;
				case 'i': return TLI;
				case 'j': return TLJ;
				case 'k': return TLK;
				case 'l': return TLL;
				case 'm': return TLM;
				case 'n': return TLN;
				case 'o': return TLO;
				case 'p': return TLP;
				case 'q': return TLQ;
				case 'r': return TLR;
				case 's': return TLS;
				case 't': return TLT;
				case 'u': return TLU;
				case 'v': return TLV;
				case 'w': return WEO;
				case 'x': return TLX;
				case 'y': return TLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TMA;
				case 'b': return TMB;
				case 'c': return TMC;
				case 'd': return TMD;
				case 'e': return TME;
				case 'f': return TMF;
				case 'g': return TMG;
				case 'h': return TMH;
				case 'i': return TMI;
				case 'j': return TMJ;
				case 'k': return TMK;
				case 'l': return TML;
				case 'm': return TMM;
				case 'n': return TMN;
				case 'o': return TMO;
				case 'p': return TYJ;
				case 'q': return TMQ;
				case 'r': return TMR;
				case 's': return TMS;
				case 't': return TMT;
				case 'u': return TMU;
				case 'v': return TMV;
				case 'w': return TMW;
				case 'y': return TMY;
				case 'z': return TMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TNA;
				case 'b': return TNB;
				case 'c': return TNC;
				case 'd': return TND;
				case 'e': return KAK;
				case 'f': return PRS;
				case 'g': return TNG;
				case 'h': return TNH;
				case 'i': return TNI;
				case 'k': return TNK;
				case 'l': return TNL;
				case 'm': return TNM;
				case 'n': return TNN;
				case 'o': return TNO;
				case 'p': return TNP;
				case 'q': return TNQ;
				case 'r': return TNR;
				case 's': return TNS;
				case 't': return TNT;
				case 'u': return TNU;
				case 'v': return TNV;
				case 'w': return TNW;
				case 'x': return TNX;
				case 'y': return TNY;
				case 'z': return TNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_to(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return TOB;
				case 'c': return TOC;
				case 'd': return TOD;
				case 'e': return TOE;
				case 'f': return TOF;
				case 'g': return TOG;
				case 'h': return TOH;
				case 'i': return TOI;
				case 'j': return TOJ;
				case 'l': return TOL;
				case 'm': return TOM;
				case 'o': return TOO;
				case 'p': return TOP;
				case 'q': return TOQ;
				case 'r': return TOR;
				case 's': return TOS;
				case 'u': return TOU;
				case 'v': return TOV;
				case 'w': return TOW;
				case 'x': return TOX;
				case 'y': return TOY;
				case 'z': return TOZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TPA;
				case 'c': return TPC;
				case 'e': return TPE;
				case 'f': return TPF;
				case 'g': return TPG;
				case 'i': return TPI;
				case 'j': return TPJ;
				case 'k': return TPK;
				case 'l': return TPL;
				case 'm': return TPM;
				case 'n': return TPN;
				case 'o': return TPO;
				case 'p': return TPP;
				case 'q': return TPQ;
				case 'r': return TPR;
				case 't': return TPT;
				case 'u': return TPU;
				case 'v': return TPV;
				case 'w': return TPW;
				case 'x': return TPX;
				case 'y': return TPY;
				case 'z': return TPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tq(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return TQB;
				case 'l': return TQL;
				case 'm': return TQM;
				case 'n': return TQN;
				case 'o': return TQO;
				case 'p': return TQP;
				case 'q': return TQQ;
				case 'r': return TQR;
				case 't': return TQT;
				case 'u': return TQU;
				case 'w': return TQW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TRA;
				case 'b': return TRB;
				case 'c': return TRC;
				case 'd': return TRD;
				case 'e': return TRE;
				case 'f': return TRF;
				case 'g': return TRG;
				case 'h': return TRH;
				case 'i': return TRI;
				case 'j': return TRJ;
				case 'k': return TRK;
				case 'l': return TRL;
				case 'm': return TRM;
				case 'n': return TRN;
				case 'o': return TRO;
				case 'p': return TRP;
				case 'q': return TRQ;
				case 'r': return TRR;
				case 's': return TRS;
				case 't': return TRT;
				case 'u': return TRU;
				case 'v': return TRV;
				case 'w': return TRW;
				case 'x': return TRX;
				case 'y': return TRY;
				case 'z': return TRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ts(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TSA;
				case 'b': return TSB;
				case 'c': return TSC;
				case 'd': return TSD;
				case 'e': return TSE;
				case 'f': return TAJ;
				case 'g': return TSG;
				case 'h': return TSH;
				case 'i': return TSI;
				case 'j': return TSJ;
				case 'k': return TSK;
				case 'l': return TSL;
				case 'm': return TSM;
				case 'p': return TSP;
				case 'q': return TSQ;
				case 'r': return TSR;
				case 's': return TSS;
				case 't': return TST;
				case 'u': return TSU;
				case 'v': return TSV;
				case 'w': return TSW;
				case 'x': return TSX;
				case 'y': return TSY;
				case 'z': return TSZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TTA;
				case 'b': return TTB;
				case 'c': return TTC;
				case 'd': return TTD;
				case 'e': return TTE;
				case 'f': return TTF;
				case 'g': return TTG;
				case 'h': return TTH;
				case 'i': return TTI;
				case 'j': return TTJ;
				case 'k': return TTK;
				case 'l': return TTL;
				case 'm': return TTM;
				case 'n': return TTN;
				case 'o': return TTO;
				case 'p': return TTP;
				case 'q': return TTQ;
				case 'r': return TTR;
				case 's': return TTS;
				case 't': return TTT;
				case 'u': return TTU;
				case 'v': return TTV;
				case 'w': return TTW;
				case 'y': return TTY;
				case 'z': return TTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TUA;
				case 'b': return TUB;
				case 'c': return TUC;
				case 'd': return TUD;
				case 'e': return TUE;
				case 'f': return TUF;
				case 'g': return TUG;
				case 'h': return TUH;
				case 'i': return TUI;
				case 'j': return TUJ;
				case 'l': return TUL;
				case 'm': return TUM;
				case 'n': return TUN;
				case 'o': return TUO;
				case 'p': return TUP;
				case 'q': return TUQ;
				case 's': return TUS;
				case 't': return TUT;
				case 'u': return TUU;
				case 'v': return TUV;
				case 'w': return TUW;
				case 'x': return TUX;
				case 'y': return TUY;
				case 'z': return TUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TVA;
				case 'd': return TVD;
				case 'e': return TVE;
				case 'k': return TVK;
				case 'l': return TVL;
				case 'm': return TVM;
				case 'n': return TVN;
				case 'o': return TVO;
				case 's': return TVS;
				case 't': return TVT;
				case 'u': return TVU;
				case 'w': return TVW;
				case 'x': return TVX;
				case 'y': return TVY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TWA;
				case 'b': return TWB;
				case 'c': return TWC;
				case 'd': return TWD;
				case 'e': return TWE;
				case 'f': return TWF;
				case 'g': return TWG;
				case 'h': return TWH;
				case 'l': return TWL;
				case 'm': return TWM;
				case 'n': return TWN;
				case 'o': return TWO;
				case 'p': return TWP;
				case 'q': return TWQ;
				case 'r': return TWR;
				case 't': return TWT;
				case 'u': return TWU;
				case 'w': return TWW;
				case 'x': return TWX;
				case 'y': return TWY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TXA;
				case 'b': return TXB;
				case 'c': return TXC;
				case 'e': return TXE;
				case 'g': return TXG;
				case 'h': return TXH;
				case 'i': return TXI;
				case 'j': return TXJ;
				case 'm': return TXM;
				case 'n': return TXN;
				case 'o': return TXO;
				case 'q': return TXQ;
				case 'r': return TXR;
				case 's': return TXS;
				case 't': return TXT;
				case 'u': return TXU;
				case 'x': return TXX;
				case 'y': return TXY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ty(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TYA;
				case 'e': return TYE;
				case 'h': return TYH;
				case 'i': return TYI;
				case 'j': return TYJ;
				case 'l': return TYL;
				case 'n': return TYN;
				case 'p': return TYP;
				case 'r': return TYR;
				case 's': return TYS;
				case 't': return TYT;
				case 'u': return TYU;
				case 'v': return TYV;
				case 'x': return TYX;
				case 'z': return TYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_tz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return TZA;
				case 'h': return TZH;
				case 'j': return TZJ;
				case 'l': return TZL;
				case 'm': return TZM;
				case 'n': return TZN;
				case 'o': return TZO;
				case 'x': return TZX;
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
				case 'm': return UAM;
				case 'n': return UAN;
				case 'r': return UAR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ub(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UBA;
				case 'i': return UBI;
				case 'l': return UBL;
				case 'r': return UBR;
				case 'u': return UBU;
				case 'y': return UBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ud(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UDA;
				case 'e': return UDE;
				case 'g': return UDG;
				case 'i': return UDI;
				case 'j': return UDJ;
				case 'l': return UDL;
				case 'm': return UDM;
				case 'u': return UDU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ue(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return UES;
			return null;
		}
		
		private static Language? tryParse_L3_uf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return UFI;
			return null;
		}
		
		private static Language? tryParse_L3_ug(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UGA;
				case 'b': return UGB;
				case 'e': return UGE;
				case 'n': return UGN;
				case 'o': return UGO;
				case 'y': return UGY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UHA;
				case 'n': return UHN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ui(StringSpan span)
		{
			switch(span[2])
			{
				case 's': return UIS;
				case 'v': return UIV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return UJI;
			return null;
		}
		
		private static Language? tryParse_L3_uk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UKA;
				case 'g': return UKG;
				case 'h': return UKH;
				case 'i': return UKI;
				case 'k': return UKK;
				case 'l': return UKL;
				case 'p': return UKP;
				case 'q': return UKQ;
				case 's': return UKS;
				case 'u': return UKU;
				case 'v': return UKV;
				case 'w': return UKW;
				case 'y': return UKY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ul(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ULA;
				case 'b': return ULB;
				case 'c': return ULC;
				case 'e': return ULE;
				case 'f': return ULF;
				case 'i': return ULI;
				case 'k': return ULK;
				case 'l': return ULL;
				case 'm': return ULM;
				case 'n': return ULN;
				case 'u': return ULU;
				case 'w': return ULW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_um(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UMA;
				case 'b': return UMB;
				case 'c': return UMC;
				case 'd': return UMD;
				case 'g': return UMG;
				case 'i': return UMI;
				case 'm': return UMM;
				case 'n': return UMN;
				case 'o': return UMO;
				case 'p': return UMP;
				case 'r': return UMR;
				case 's': return UMS;
				case 'u': return UMU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_un(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UNA;
				case 'd': return UND;
				case 'e': return UNE;
				case 'g': return UNG;
				case 'k': return UNK;
				case 'm': return UNM;
				case 'n': return UNN;
				case 'p': return UNP;
				case 'r': return UNR;
				case 'u': return UNU;
				case 'x': return UNX;
				case 'z': return UNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return EMA;
			return null;
		}
		
		private static Language? tryParse_L3_up(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return UPI;
				case 'v': return UPV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ur(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return URA;
				case 'b': return URB;
				case 'c': return URC;
				case 'e': return URE;
				case 'f': return URF;
				case 'g': return URG;
				case 'h': return URH;
				case 'i': return URI;
				case 'j': return URJ;
				case 'k': return URK;
				case 'l': return URL;
				case 'm': return URM;
				case 'n': return URN;
				case 'o': return URO;
				case 'p': return URP;
				case 'r': return URR;
				case 't': return URT;
				case 'u': return URU;
				case 'v': return URV;
				case 'w': return URW;
				case 'x': return URX;
				case 'y': return URY;
				case 'z': return URZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_us(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return USA;
				case 'h': return USH;
				case 'i': return USI;
				case 'k': return USK;
				case 'p': return USP;
				case 's': return USS;
				case 'u': return USU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ut(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return UTA;
				case 'e': return UTE;
				case 'h': return UTH;
				case 'p': return UTP;
				case 'r': return UTR;
				case 'u': return UTU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uu(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return UUM;
				case 'n': return UUN;
				case 'r': return UUR;
				case 'u': return UUU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uv(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return UVE;
				case 'h': return UVH;
				case 'l': return UVL;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_uw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return UWA;
			return null;
		}
		
		private static Language? tryParse_L3_uy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return UYA;
			return null;
		}
		
		private static Language? tryParse_L3_uz(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return UZN;
				case 's': return UZS;
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
				case 'a': return VAA;
				case 'e': return VAE;
				case 'f': return VAF;
				case 'g': return VAG;
				case 'h': return VAH;
				case 'i': return VAI;
				case 'j': return VAJ;
				case 'l': return VAL;
				case 'm': return VAM;
				case 'n': return VAN;
				case 'o': return VAO;
				case 'p': return VAP;
				case 'r': return VAR;
				case 's': return VAS;
				case 'u': return VAU;
				case 'v': return VAV;
				case 'y': return VAY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vb(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return VBB;
				case 'k': return VBK;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ve(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return VEC;
				case 'd': return VED;
				case 'l': return VEL;
				case 'm': return VEM;
				case 'o': return VEO;
				case 'p': return VEP;
				case 'r': return VER;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vg(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return VGR;
				case 't': return VGT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vi(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return VIC;
				case 'd': return VID;
				case 'f': return VIF;
				case 'g': return VIG;
				case 'l': return VIL;
				case 'n': return VIN;
				case 's': return VIS;
				case 't': return VIT;
				case 'v': return VIV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VKA;
				case 'i': return VKI;
				case 'j': return VKJ;
				case 'k': return VKK;
				case 'l': return VKL;
				case 'm': return VKM;
				case 'o': return VKO;
				case 'p': return VKP;
				case 't': return VKT;
				case 'u': return VKU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vl(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return VLP;
				case 's': return VLS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VMA;
				case 'b': return VMB;
				case 'c': return VMC;
				case 'd': return VMD;
				case 'e': return VME;
				case 'f': return VMF;
				case 'g': return VMG;
				case 'h': return VMH;
				case 'i': return VMI;
				case 'j': return VMJ;
				case 'k': return VMK;
				case 'l': return VML;
				case 'm': return VMM;
				case 'p': return VMP;
				case 'q': return VMQ;
				case 'r': return VMR;
				case 's': return VMS;
				case 'u': return VMU;
				case 'v': return VMV;
				case 'w': return VMW;
				case 'x': return VMX;
				case 'y': return VMY;
				case 'z': return VMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vn(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return VNK;
				case 'm': return VNM;
				case 'p': return VNP;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vo(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return VOR;
				case 't': return VOT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return VRA;
				case 'o': return VRO;
				case 's': return VRS;
				case 't': return VRT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vs(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return VSI;
				case 'l': return VSL;
				case 'v': return VSV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return VTO;
			return null;
		}
		
		private static Language? tryParse_L3_vu(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return VUM;
				case 'n': return VUN;
				case 't': return VUT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_vw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return VWA;
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
				case 'a': return WAA;
				case 'b': return WAB;
				case 'c': return WAC;
				case 'd': return WAD;
				case 'e': return WAE;
				case 'f': return WAF;
				case 'g': return WAG;
				case 'h': return WAH;
				case 'i': return WAI;
				case 'j': return WAJ;
				case 'k': return WAK;
				case 'l': return WAL;
				case 'm': return WAM;
				case 'n': return WAN;
				case 'o': return WAO;
				case 'p': return WAP;
				case 'q': return WAQ;
				case 'r': return WAR;
				case 's': return WAS;
				case 't': return WAT;
				case 'u': return WAU;
				case 'v': return WAV;
				case 'w': return WAW;
				case 'x': return WAX;
				case 'y': return WAY;
				case 'z': return WAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WBA;
				case 'b': return WBB;
				case 'e': return WBE;
				case 'f': return WBF;
				case 'h': return WBH;
				case 'i': return WBI;
				case 'j': return WBJ;
				case 'k': return WBK;
				case 'l': return WBL;
				case 'm': return WBM;
				case 'p': return WBP;
				case 'q': return WBQ;
				case 'r': return WBR;
				case 's': return WBS;
				case 't': return WBT;
				case 'v': return WBV;
				case 'w': return WBW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WCA;
				case 'i': return WCI;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wd(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return WDD;
				case 'g': return WDG;
				case 'j': return WDJ;
				case 'k': return WDK;
				case 'u': return WDU;
				case 'y': return WDY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_we(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WEA;
				case 'c': return WEC;
				case 'd': return WED;
				case 'g': return WEG;
				case 'h': return WEH;
				case 'i': return WEI;
				case 'm': return WEM;
				case 'n': return WEN;
				case 'o': return WEO;
				case 'p': return WEP;
				case 'r': return WER;
				case 's': return WES;
				case 't': return WET;
				case 'u': return WEU;
				case 'w': return WEW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return WFG;
			return null;
		}
		
		private static Language? tryParse_L3_wg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WGA;
				case 'b': return WGB;
				case 'g': return WGG;
				case 'i': return WGI;
				case 'o': return WGO;
				case 'u': return WGU;
				case 'w': return WGW;
				case 'y': return WGY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WHA;
				case 'g': return WHG;
				case 'k': return WHK;
				case 'u': return WHU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wi(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return WIB;
				case 'c': return WIC;
				case 'e': return WIE;
				case 'f': return WIF;
				case 'g': return WIG;
				case 'h': return WIH;
				case 'i': return WII;
				case 'j': return WIJ;
				case 'k': return WIK;
				case 'l': return WIL;
				case 'm': return WIM;
				case 'n': return WIN;
				case 'r': return WIR;
				case 't': return WIT;
				case 'u': return WIU;
				case 'v': return WIV;
				case 'w': return WIW;
				case 'y': return WIY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wj(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WJA;
				case 'i': return WJI;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WKA;
				case 'b': return WKB;
				case 'd': return WKD;
				case 'l': return WKL;
				case 'r': return WKR;
				case 'u': return WKU;
				case 'w': return WKW;
				case 'y': return WKY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WLA;
				case 'c': return WLC;
				case 'e': return WLE;
				case 'g': return WLG;
				case 'h': return WLH;
				case 'i': return WLI;
				case 'k': return WLK;
				case 'l': return WLL;
				case 'm': return WLM;
				case 'o': return WLO;
				case 'r': return WLR;
				case 's': return WLS;
				case 'u': return WLU;
				case 'v': return WLV;
				case 'w': return WLW;
				case 'x': return WLX;
				case 'y': return WLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WMA;
				case 'b': return WMB;
				case 'c': return WMC;
				case 'd': return WMD;
				case 'e': return WME;
				case 'h': return WMH;
				case 'i': return WMI;
				case 'm': return WMM;
				case 'n': return WMN;
				case 'o': return WMO;
				case 's': return WMS;
				case 't': return WMT;
				case 'w': return WMW;
				case 'x': return WMX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wn(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return WNB;
				case 'c': return WNC;
				case 'd': return WND;
				case 'e': return WNE;
				case 'g': return WNG;
				case 'i': return WNI;
				case 'k': return WNK;
				case 'm': return WNM;
				case 'n': return WNN;
				case 'o': return WNO;
				case 'p': return WNP;
				case 'u': return WNU;
				case 'w': return WNW;
				case 'y': return WNY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wo(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WOA;
				case 'b': return WOB;
				case 'c': return WOC;
				case 'd': return WOD;
				case 'e': return WOE;
				case 'f': return WOF;
				case 'g': return WOG;
				case 'i': return WOI;
				case 'k': return WOK;
				case 'm': return WOM;
				case 'n': return WON;
				case 'o': return WOO;
				case 'r': return WOR;
				case 's': return WOS;
				case 'w': return WOW;
				case 'y': return WOY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return WPC;
			return null;
		}
		
		private static Language? tryParse_L3_wr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WRA;
				case 'b': return WRB;
				case 'd': return WRD;
				case 'g': return WRG;
				case 'h': return WRH;
				case 'i': return WRI;
				case 'k': return WRK;
				case 'l': return WRL;
				case 'm': return WRM;
				case 'n': return WRN;
				case 'o': return WRO;
				case 'p': return WRP;
				case 'r': return WRR;
				case 's': return WRS;
				case 'u': return WRU;
				case 'v': return WRV;
				case 'w': return WRW;
				case 'x': return WRX;
				case 'y': return WRY;
				case 'z': return WRZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ws(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WSA;
				case 'g': return WSG;
				case 'i': return WSI;
				case 'k': return WSK;
				case 'r': return WSR;
				case 's': return WSS;
				case 'u': return WSU;
				case 'v': return WSV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wt(StringSpan span)
		{
			switch(span[2])
			{
				case 'f': return WTF;
				case 'h': return WTH;
				case 'i': return WTI;
				case 'k': return WTK;
				case 'm': return WTM;
				case 'w': return WTW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WUA;
				case 'b': return WUB;
				case 'd': return WUD;
				case 'h': return WUH;
				case 'l': return WUL;
				case 'm': return WUM;
				case 'n': return WUN;
				case 'r': return WUR;
				case 't': return WUT;
				case 'u': return WUU;
				case 'v': return WUV;
				case 'x': return WUX;
				case 'y': return WUY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ww(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WWA;
				case 'b': return WWB;
				case 'o': return WWO;
				case 'r': return WWR;
				case 'w': return WWW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WXA;
				case 'w': return WXW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_wy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return WYA;
				case 'b': return WYB;
				case 'i': return WYI;
				case 'm': return WYM;
				case 'r': return WYR;
				case 'y': return WYY;
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
				case 'a': return XAA;
				case 'b': return XAB;
				case 'c': return XAC;
				case 'd': return XAD;
				case 'e': return XAE;
				case 'g': return XAG;
				case 'i': return XAI;
				case 'j': return XAJ;
				case 'k': return XAK;
				case 'l': return XAL;
				case 'm': return XAM;
				case 'n': return XAN;
				case 'o': return XAO;
				case 'p': return XAP;
				case 'q': return XAQ;
				case 'r': return XAR;
				case 's': return XAS;
				case 't': return XAT;
				case 'u': return XAU;
				case 'v': return XAV;
				case 'w': return XAW;
				case 'y': return XAY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return CAX;
				case 'b': return XBB;
				case 'c': return XBC;
				case 'd': return XBD;
				case 'e': return XBE;
				case 'g': return XBG;
				case 'i': return XBI;
				case 'j': return XBJ;
				case 'm': return XBM;
				case 'n': return XBN;
				case 'o': return XBO;
				case 'p': return XBP;
				case 'r': return XBR;
				case 'w': return XBW;
				case 'x': return XBX;
				case 'y': return XBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xc(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XCB;
				case 'c': return XCC;
				case 'e': return XCE;
				case 'g': return XCG;
				case 'h': return XCH;
				case 'l': return XCL;
				case 'm': return XCM;
				case 'n': return XCN;
				case 'o': return XCO;
				case 'r': return XCR;
				case 't': return XCT;
				case 'u': return XCU;
				case 'v': return XCV;
				case 'w': return XCW;
				case 'y': return XCY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XDA;
				case 'c': return XDC;
				case 'k': return XDK;
				case 'm': return XDM;
				case 'o': return XDO;
				case 'y': return XDY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xe(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XEB;
				case 'd': return XED;
				case 'g': return XEG;
				case 'l': return XEL;
				case 'm': return XEM;
				case 'p': return XEP;
				case 'r': return XER;
				case 's': return XES;
				case 't': return XET;
				case 'u': return XEU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return XFA;
			return null;
		}
		
		private static Language? tryParse_L3_xg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XGA;
				case 'b': return XGB;
				case 'd': return XGD;
				case 'f': return XGF;
				case 'g': return XGG;
				case 'i': return XGI;
				case 'l': return XGL;
				case 'm': return XGM;
				case 'n': return XGN;
				case 'r': return XGR;
				case 'u': return XGU;
				case 'w': return XGW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XHA;
				case 'c': return XHC;
				case 'd': return XHD;
				case 'e': return XHE;
				case 'r': return XHR;
				case 't': return XHT;
				case 'u': return XHU;
				case 'v': return XHV;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ACN;
				case 'b': return XIB;
				case 'i': return XII;
				case 'l': return XIL;
				case 'n': return XIN;
				case 'p': return XIP;
				case 'r': return XIR;
				case 's': return XIS;
				case 'v': return XIV;
				case 'y': return XIY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xj(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XJB;
				case 't': return XJT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XKA;
				case 'b': return XKB;
				case 'c': return XKC;
				case 'd': return XKD;
				case 'e': return XKE;
				case 'f': return XKF;
				case 'g': return XKG;
				case 'h': return WAW;
				case 'i': return XKI;
				case 'j': return XKJ;
				case 'k': return XKK;
				case 'l': return XKL;
				case 'n': return XKN;
				case 'o': return XKO;
				case 'p': return XKP;
				case 'q': return XKQ;
				case 'r': return XKR;
				case 's': return XKS;
				case 't': return XKT;
				case 'u': return XKU;
				case 'v': return XKV;
				case 'w': return XKW;
				case 'x': return XKX;
				case 'y': return XKY;
				case 'z': return XKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XLA;
				case 'b': return XLB;
				case 'c': return XLC;
				case 'd': return XLD;
				case 'e': return XLE;
				case 'g': return XLG;
				case 'i': return XLI;
				case 'n': return XLN;
				case 'o': return XLO;
				case 'p': return XLP;
				case 's': return XLS;
				case 'u': return XLU;
				case 'y': return XLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XMA;
				case 'b': return XMB;
				case 'c': return XMC;
				case 'd': return XMD;
				case 'e': return XME;
				case 'f': return XMF;
				case 'g': return XMG;
				case 'h': return XMH;
				case 'j': return XMJ;
				case 'k': return XMK;
				case 'l': return XML;
				case 'm': return XMM;
				case 'n': return XMN;
				case 'o': return XMO;
				case 'p': return XMP;
				case 'q': return XMQ;
				case 'r': return XMR;
				case 's': return XMS;
				case 't': return XMT;
				case 'u': return XMU;
				case 'v': return XMV;
				case 'w': return XMW;
				case 'x': return XMX;
				case 'y': return XMY;
				case 'z': return XMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XNA;
				case 'b': return XNB;
				case 'd': return XND;
				case 'g': return XNG;
				case 'h': return XNH;
				case 'i': return XNI;
				case 'k': return XNK;
				case 'm': return XNM;
				case 'n': return XNN;
				case 'o': return XNO;
				case 'r': return XNR;
				case 's': return XNS;
				case 't': return XNT;
				case 'u': return XNU;
				case 'y': return XNY;
				case 'z': return XNZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xo(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return XOC;
				case 'd': return XOD;
				case 'g': return XOG;
				case 'i': return XOI;
				case 'k': return XOK;
				case 'm': return XOM;
				case 'n': return XON;
				case 'o': return XOO;
				case 'p': return XOP;
				case 'r': return XOR;
				case 'w': return XOW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XPA;
				case 'b': return XPB;
				case 'c': return XPC;
				case 'd': return XPD;
				case 'e': return XPE;
				case 'f': return XPF;
				case 'g': return XPG;
				case 'h': return XPH;
				case 'i': return XPI;
				case 'j': return XPJ;
				case 'k': return XPK;
				case 'l': return XPL;
				case 'm': return XPM;
				case 'n': return XPN;
				case 'o': return XPO;
				case 'p': return XPP;
				case 'q': return XPQ;
				case 'r': return XPR;
				case 's': return XPS;
				case 't': return XPT;
				case 'u': return XPU;
				case 'v': return XPV;
				case 'w': return XPW;
				case 'x': return XPX;
				case 'y': return XPY;
				case 'z': return XPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xq(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XQA;
				case 't': return XQT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XRA;
				case 'b': return XRB;
				case 'd': return XRD;
				case 'e': return XRE;
				case 'g': return XRG;
				case 'i': return XRI;
				case 'm': return XRM;
				case 'n': return XRN;
				case 'q': return DMW;
				case 'r': return XRR;
				case 't': return XRT;
				case 'u': return XRU;
				case 'w': return XRW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XSA;
				case 'b': return XSB;
				case 'c': return XSC;
				case 'd': return XSD;
				case 'e': return XSE;
				case 'h': return XSH;
				case 'i': return XSI;
				case 'j': return XSJ;
				case 'l': return XSL;
				case 'm': return XSM;
				case 'n': return XSN;
				case 'o': return XSO;
				case 'p': return XSP;
				case 'q': return XSQ;
				case 'r': return XSR;
				case 's': return XSS;
				case 'u': return XSU;
				case 'v': return XSV;
				case 'y': return XSY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XTA;
				case 'b': return XTB;
				case 'c': return XTC;
				case 'd': return XTD;
				case 'e': return XTE;
				case 'g': return XTG;
				case 'h': return XTH;
				case 'i': return XTI;
				case 'j': return XTJ;
				case 'l': return XTL;
				case 'm': return XTM;
				case 'n': return XTN;
				case 'o': return XTO;
				case 'p': return XTP;
				case 'q': return XTQ;
				case 'r': return XTR;
				case 's': return XTS;
				case 't': return XTT;
				case 'u': return XTU;
				case 'v': return XTV;
				case 'w': return XTW;
				case 'y': return XTY;
				case 'z': return XTZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XUA;
				case 'b': return XUB;
				case 'd': return XUD;
				case 'g': return XUG;
				case 'j': return XUJ;
				case 'l': return XUL;
				case 'm': return XUM;
				case 'n': return XUN;
				case 'o': return XUO;
				case 'p': return XUP;
				case 'r': return XUR;
				case 't': return XUT;
				case 'u': return XUU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xv(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return XVE;
				case 'i': return XVI;
				case 'n': return XVN;
				case 'o': return XVO;
				case 's': return XVS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XWA;
				case 'c': return XWC;
				case 'd': return XWD;
				case 'e': return XWE;
				case 'g': return XWG;
				case 'j': return XWJ;
				case 'k': return XWK;
				case 'l': return XWL;
				case 'o': return XWO;
				case 'r': return XWR;
				case 't': return XWT;
				case 'w': return XWW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xx(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return XXB;
				case 'k': return XXK;
				case 'm': return XXM;
				case 'r': return XXR;
				case 't': return XXT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xy(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return XYA;
				case 'b': return XYB;
				case 'j': return XYJ;
				case 'k': return XYK;
				case 'l': return XYL;
				case 't': return XYT;
				case 'y': return XYY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_xz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return XZH;
				case 'm': return XZM;
				case 'p': return XZP;
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
				case 'a': return YAA;
				case 'b': return YAB;
				case 'c': return YAC;
				case 'd': return YAD;
				case 'e': return YAE;
				case 'f': return YAF;
				case 'g': return YAG;
				case 'h': return YAH;
				case 'i': return YAI;
				case 'j': return YAJ;
				case 'k': return YAK;
				case 'l': return YAL;
				case 'm': return YAM;
				case 'n': return YAN;
				case 'o': return YAO;
				case 'p': return YAP;
				case 'q': return YAQ;
				case 'r': return YAR;
				case 's': return YAS;
				case 't': return YAT;
				case 'u': return YAU;
				case 'v': return YAV;
				case 'w': return YAW;
				case 'x': return YAX;
				case 'y': return YAY;
				case 'z': return YAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YBA;
				case 'b': return YBB;
				case 'd': return RKI;
				case 'e': return YBE;
				case 'h': return YBH;
				case 'i': return YBI;
				case 'j': return YBJ;
				case 'k': return YBK;
				case 'l': return YBL;
				case 'm': return YBM;
				case 'n': return YBN;
				case 'o': return YBO;
				case 'x': return YBX;
				case 'y': return YBY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yc(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return YCH;
				case 'l': return YCL;
				case 'n': return YCN;
				case 'p': return YCP;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yd(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YDA;
				case 'd': return YDD;
				case 'e': return YDE;
				case 'g': return YDG;
				case 'k': return YDK;
				case 's': return YDS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ye(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YEA;
				case 'c': return YEC;
				case 'e': return YEE;
				case 'i': return YEI;
				case 'j': return YEJ;
				case 'l': return YEL;
				case 'n': return YEN;
				case 'r': return YER;
				case 's': return YES;
				case 't': return YET;
				case 'u': return YEU;
				case 'v': return YEV;
				case 'y': return YEY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YGA;
				case 'i': return YGI;
				case 'l': return YGL;
				case 'm': return YGM;
				case 'p': return YGP;
				case 'r': return YGR;
				case 's': return YGS;
				case 'u': return YGU;
				case 'w': return YGW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YHA;
				case 'd': return YHD;
				case 'l': return YHL;
				case 's': return YHS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YIA;
				case 'f': return YIF;
				case 'g': return YIG;
				case 'h': return YIH;
				case 'i': return YII;
				case 'j': return YIJ;
				case 'k': return YIK;
				case 'l': return YIL;
				case 'm': return YIM;
				case 'n': return YIN;
				case 'p': return YIP;
				case 'q': return YIQ;
				case 'r': return YIR;
				case 's': return YIS;
				case 't': return YIT;
				case 'u': return YIU;
				case 'v': return YIV;
				case 'x': return YIX;
				case 'y': return YIY;
				case 'z': return YIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YKA;
				case 'g': return YKG;
				case 'i': return YKI;
				case 'k': return YKK;
				case 'l': return YKL;
				case 'm': return YKM;
				case 'n': return YKN;
				case 'o': return YKO;
				case 'r': return YKR;
				case 't': return YKT;
				case 'u': return YKU;
				case 'y': return YKY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yl(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YLA;
				case 'b': return YLB;
				case 'e': return YLE;
				case 'g': return YLG;
				case 'i': return YLI;
				case 'l': return YLL;
				case 'm': return YLM;
				case 'n': return YLN;
				case 'o': return YLO;
				case 'r': return YLR;
				case 'u': return YLU;
				case 'y': return YLY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ym(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return LRR;
				case 'b': return YMB;
				case 'c': return YMC;
				case 'd': return YMD;
				case 'e': return YME;
				case 'g': return YMG;
				case 'h': return YMH;
				case 'i': return YMI;
				case 'k': return YMK;
				case 'l': return YML;
				case 'm': return YMM;
				case 'n': return YMN;
				case 'o': return YMO;
				case 'p': return YMP;
				case 'q': return YMQ;
				case 'r': return YMR;
				case 's': return YMS;
				case 't': return MTM;
				case 'x': return YMX;
				case 'z': return YMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YNA;
				case 'd': return YND;
				case 'e': return YNE;
				case 'g': return YNG;
				case 'h': return YNH;
				case 'k': return YNK;
				case 'l': return YNL;
				case 'n': return YNN;
				case 'o': return YNO;
				case 'q': return YNQ;
				case 's': return YNS;
				case 'u': return YNU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yo(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return YOB;
				case 'g': return YOG;
				case 'i': return YOI;
				case 'k': return YOK;
				case 'l': return YOL;
				case 'm': return YOM;
				case 'n': return YON;
				case 's': return ZOM;
				case 't': return YOT;
				case 'x': return YOX;
				case 'y': return YOY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YPA;
				case 'b': return YPB;
				case 'g': return YPG;
				case 'h': return YPH;
				case 'k': return YPK;
				case 'm': return YPM;
				case 'n': return YPN;
				case 'o': return YPO;
				case 'p': return YPP;
				case 'z': return YPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YRA;
				case 'b': return YRB;
				case 'e': return YRE;
				case 'i': return YRI;
				case 'k': return YRK;
				case 'l': return YRL;
				case 'm': return YRM;
				case 'n': return YRN;
				case 'o': return YRO;
				case 's': return YRS;
				case 'w': return YRW;
				case 'y': return YRY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_ys(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return YSC;
				case 'd': return YSD;
				case 'g': return YSG;
				case 'l': return YSL;
				case 'n': return YSN;
				case 'o': return YSO;
				case 'p': return YSP;
				case 'r': return YSR;
				case 's': return YSS;
				case 'y': return YSY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yt(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YTA;
				case 'l': return YTL;
				case 'p': return YTP;
				case 'w': return YTW;
				case 'y': return YTY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YUA;
				case 'b': return YUB;
				case 'c': return YUC;
				case 'd': return YUD;
				case 'e': return YUE;
				case 'f': return YUF;
				case 'g': return YUG;
				case 'i': return YUI;
				case 'j': return YUJ;
				case 'k': return YUK;
				case 'l': return YUL;
				case 'm': return YUM;
				case 'n': return YUN;
				case 'p': return YUP;
				case 'q': return YUQ;
				case 'r': return YUR;
				case 't': return YUT;
				case 'u': return YUG;
				case 'w': return YUW;
				case 'x': return YUX;
				case 'y': return YUY;
				case 'z': return YUZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yv(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YVA;
				case 't': return YVT;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yw(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YWA;
				case 'g': return YWG;
				case 'l': return YWL;
				case 'n': return YWN;
				case 'q': return YWQ;
				case 'r': return YWR;
				case 't': return YWT;
				case 'u': return YWU;
				case 'w': return YWW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yx(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return YXA;
				case 'g': return YXG;
				case 'l': return YXL;
				case 'm': return YXM;
				case 'u': return YXU;
				case 'y': return YXY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yy(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return YYR;
				case 'u': return YYU;
				case 'z': return YYZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_yz(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return YZG;
				case 'k': return YZK;
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
				case 'a': return ZAA;
				case 'b': return ZAB;
				case 'c': return ZAC;
				case 'd': return ZAD;
				case 'e': return ZAE;
				case 'f': return ZAF;
				case 'g': return ZAG;
				case 'h': return ZAH;
				case 'i': return ZAI;
				case 'j': return ZAJ;
				case 'k': return ZAK;
				case 'l': return ZAL;
				case 'm': return ZAM;
				case 'o': return ZAO;
				case 'p': return ZAP;
				case 'q': return ZAQ;
				case 'r': return ZAR;
				case 's': return ZAS;
				case 't': return ZAT;
				case 'u': return ZAU;
				case 'v': return ZAV;
				case 'w': return ZAW;
				case 'x': return ZAX;
				case 'y': return ZAY;
				case 'z': return ZAZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zb(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZBA;
				case 'c': return ZBC;
				case 'e': return ZBE;
				case 'l': return ZBL;
				case 't': return ZBT;
				case 'w': return ZBW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zc(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZCA;
				case 'h': return ZCH;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'j')
				return ZDJ;
			return null;
		}
		
		private static Language? tryParse_L3_ze(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZEA;
				case 'g': return ZEG;
				case 'h': return ZEH;
				case 'n': return ZEN;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zg(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZGA;
				case 'b': return ZGB;
				case 'h': return ZGH;
				case 'm': return ZGM;
				case 'n': return ZGN;
				case 'r': return ZGR;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zh(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ZHB;
				case 'd': return ZHD;
				case 'i': return ZHI;
				case 'n': return ZHN;
				case 'w': return ZHW;
				case 'x': return ZHX;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zi(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZIA;
				case 'b': return ZIB;
				case 'k': return ZIK;
				case 'l': return ZIL;
				case 'm': return ZIM;
				case 'n': return ZIN;
				case 'r': return SCV;
				case 'w': return ZIW;
				case 'z': return ZIZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zk(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZKA;
				case 'b': return ZKB;
				case 'd': return ZKD;
				case 'g': return ZKG;
				case 'h': return ZKH;
				case 'k': return ZKK;
				case 'n': return ZKN;
				case 'o': return ZKO;
				case 'p': return ZKP;
				case 'r': return ZKR;
				case 't': return ZKT;
				case 'u': return ZKU;
				case 'v': return ZKV;
				case 'z': return ZKZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zl(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ZLE;
				case 'j': return ZLJ;
				case 'm': return ZLM;
				case 'n': return ZLN;
				case 'q': return ZLQ;
				case 's': return ZLS;
				case 'w': return ZLW;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zm(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZMA;
				case 'b': return ZMB;
				case 'c': return ZMC;
				case 'd': return ZMD;
				case 'e': return ZME;
				case 'f': return ZMF;
				case 'g': return ZMG;
				case 'h': return ZMH;
				case 'i': return ZMI;
				case 'j': return ZMJ;
				case 'k': return ZMK;
				case 'l': return ZML;
				case 'm': return ZMM;
				case 'n': return ZMN;
				case 'o': return ZMO;
				case 'p': return ZMP;
				case 'q': return ZMQ;
				case 'r': return ZMR;
				case 's': return ZMS;
				case 't': return ZMT;
				case 'u': return ZMU;
				case 'v': return ZMV;
				case 'w': return ZMW;
				case 'x': return ZMX;
				case 'y': return ZMY;
				case 'z': return ZMZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zn(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZNA;
				case 'd': return ZND;
				case 'e': return ZNE;
				case 'g': return ZNG;
				case 'k': return ZNK;
				case 's': return ZNS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zo(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return ZOC;
				case 'h': return ZOH;
				case 'm': return ZOM;
				case 'o': return ZOO;
				case 'q': return ZOQ;
				case 'r': return ZOR;
				case 's': return ZOS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zp(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZPA;
				case 'b': return ZPB;
				case 'c': return ZPC;
				case 'd': return ZPD;
				case 'e': return ZPE;
				case 'f': return ZPF;
				case 'g': return ZPG;
				case 'h': return ZPH;
				case 'i': return ZPI;
				case 'j': return ZPJ;
				case 'k': return ZPK;
				case 'l': return ZPL;
				case 'm': return ZPM;
				case 'n': return ZPN;
				case 'o': return ZPO;
				case 'p': return ZPP;
				case 'q': return ZPQ;
				case 'r': return ZPR;
				case 's': return ZPS;
				case 't': return ZPT;
				case 'u': return ZPU;
				case 'v': return ZPV;
				case 'w': return ZPW;
				case 'x': return ZPX;
				case 'y': return ZPY;
				case 'z': return ZPZ;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return ZQE;
			return null;
		}
		
		private static Language? tryParse_L3_zr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZRA;
				case 'g': return ZRG;
				case 'n': return ZRN;
				case 'o': return ZRO;
				case 'p': return ZRP;
				case 's': return ZRS;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zs(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZSA;
				case 'k': return ZSK;
				case 'l': return ZSL;
				case 'm': return ZSM;
				case 'r': return ZSR;
				case 'u': return ZSU;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zt(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return ZTE;
				case 'g': return ZTG;
				case 'l': return ZTL;
				case 'm': return ZTM;
				case 'n': return ZTN;
				case 'p': return ZTP;
				case 'q': return ZTQ;
				case 's': return ZTS;
				case 't': return ZTT;
				case 'u': return ZTU;
				case 'x': return ZTX;
				case 'y': return ZTY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zu(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZUA;
				case 'h': return ZUH;
				case 'm': return ZUM;
				case 'n': return ZUN;
				case 'y': return ZUY;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return ZWA;
			return null;
		}
		
		private static Language? tryParse_L3_zx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return ZXX;
			return null;
		}
		
		private static Language? tryParse_L3_zy(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return ZYB;
				case 'g': return ZYG;
				case 'j': return ZYJ;
				case 'n': return ZYN;
				case 'p': return ZYP;
				default: return null;
			}
		}
		
		private static Language? tryParse_L3_zz(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return ZZA;
				case 'j': return ZZJ;
				default: return null;
			}
		}
	}
}
