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
				case 'c': return AC;
				case 'd': return AD;
				case 'e': return AE;
				case 'f': return AF;
				case 'g': return AG;
				case 'i': return AI;
				case 'l': return AL;
				case 'm': return AM;
				case 'n': return AN;
				case 'o': return AO;
				case 'q': return AQ;
				case 'r': return AR;
				case 's': return AS;
				case 't': return AT;
				case 'u': return AU;
				case 'w': return AW;
				case 'x': return AX;
				case 'z': return AZ;
				case 'a': return forPrivateUse("aa");
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return BA;
				case 'b': return BB;
				case 'd': return BD;
				case 'e': return BE;
				case 'f': return BF;
				case 'g': return BG;
				case 'h': return BH;
				case 'i': return BI;
				case 'j': return BJ;
				case 'l': return BL;
				case 'm': return BM;
				case 'n': return BN;
				case 'o': return BO;
				case 'q': return BQ;
				case 'r': return BR;
				case 's': return BS;
				case 't': return BT;
				case 'u': return MM;
				case 'v': return BV;
				case 'w': return BW;
				case 'y': return BY;
				case 'z': return BZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return CA;
				case 'c': return CC;
				case 'd': return CD;
				case 'f': return CF;
				case 'g': return CG;
				case 'h': return CH;
				case 'i': return CI;
				case 'k': return CK;
				case 'l': return CL;
				case 'm': return CM;
				case 'n': return CN;
				case 'o': return CO;
				case 'p': return CP;
				case 'r': return CR;
				case 's': return CS;
				case 'u': return CU;
				case 'v': return CV;
				case 'w': return CW;
				case 'x': return CX;
				case 'y': return CY;
				case 'z': return CZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return DE;
				case 'e': return DE;
				case 'g': return DG;
				case 'j': return DJ;
				case 'k': return DK;
				case 'm': return DM;
				case 'o': return DO;
				case 'z': return DZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return EA;
				case 'c': return EC;
				case 'e': return EE;
				case 'g': return EG;
				case 'h': return EH;
				case 'r': return ER;
				case 's': return ES;
				case 't': return ET;
				case 'u': return EU;
				case 'z': return EZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return FI;
				case 'j': return FJ;
				case 'k': return FK;
				case 'm': return FM;
				case 'o': return FO;
				case 'r': return FR;
				case 'x': return FR;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return GA;
				case 'b': return GB;
				case 'd': return GD;
				case 'e': return GE;
				case 'f': return GF;
				case 'g': return GG;
				case 'h': return GH;
				case 'i': return GI;
				case 'l': return GL;
				case 'm': return GM;
				case 'n': return GN;
				case 'p': return GP;
				case 'q': return GQ;
				case 'r': return GR;
				case 's': return GS;
				case 't': return GT;
				case 'u': return GU;
				case 'w': return GW;
				case 'y': return GY;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'k': return HK;
				case 'm': return HM;
				case 'n': return HN;
				case 'r': return HR;
				case 't': return HT;
				case 'u': return HU;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return IC;
				case 'd': return ID;
				case 'e': return IE;
				case 'l': return IL;
				case 'm': return IM;
				case 'n': return IN;
				case 'o': return IO;
				case 'q': return IQ;
				case 'r': return IR;
				case 's': return IS;
				case 't': return IT;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return JE;
				case 'm': return JM;
				case 'o': return JO;
				case 'p': return JP;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return KE;
				case 'g': return KG;
				case 'h': return KH;
				case 'i': return KI;
				case 'm': return KM;
				case 'n': return KN;
				case 'p': return KP;
				case 'r': return KR;
				case 'w': return KW;
				case 'y': return KY;
				case 'z': return KZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return LA;
				case 'b': return LB;
				case 'c': return LC;
				case 'i': return LI;
				case 'k': return LK;
				case 'r': return LR;
				case 's': return LS;
				case 't': return LT;
				case 'u': return LU;
				case 'v': return LV;
				case 'y': return LY;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return MA;
				case 'c': return MC;
				case 'd': return MD;
				case 'e': return ME;
				case 'f': return MF;
				case 'g': return MG;
				case 'h': return MH;
				case 'k': return MK;
				case 'l': return ML;
				case 'm': return MM;
				case 'n': return MN;
				case 'o': return MO;
				case 'p': return MP;
				case 'q': return MQ;
				case 'r': return MR;
				case 's': return MS;
				case 't': return MT;
				case 'u': return MU;
				case 'v': return MV;
				case 'w': return MW;
				case 'x': return MX;
				case 'y': return MY;
				case 'z': return MZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return NA;
				case 'c': return NC;
				case 'e': return NE;
				case 'f': return NF;
				case 'g': return NG;
				case 'i': return NI;
				case 'l': return NL;
				case 'o': return NO;
				case 'p': return NP;
				case 'r': return NR;
				case 't': return NT;
				case 'u': return NU;
				case 'z': return NZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'm')
				return OM;
			return null;
		}
		
		private static Region? tryParse_L2_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return PA;
				case 'e': return PE;
				case 'f': return PF;
				case 'g': return PG;
				case 'h': return PH;
				case 'k': return PK;
				case 'l': return PL;
				case 'm': return PM;
				case 'n': return PN;
				case 'r': return PR;
				case 's': return PS;
				case 't': return PT;
				case 'w': return PW;
				case 'y': return PY;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_q(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return QA;
			return null;
		}
		
		private static Region? tryParse_L2_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return RE;
				case 'o': return RO;
				case 's': return RS;
				case 'u': return RU;
				case 'w': return RW;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return SA;
				case 'b': return SB;
				case 'c': return SC;
				case 'd': return SD;
				case 'e': return SE;
				case 'g': return SG;
				case 'h': return SH;
				case 'i': return SI;
				case 'j': return SJ;
				case 'k': return SK;
				case 'l': return SL;
				case 'm': return SM;
				case 'n': return SN;
				case 'o': return SO;
				case 'r': return SR;
				case 's': return SS;
				case 't': return ST;
				case 'u': return SU;
				case 'v': return SV;
				case 'x': return SX;
				case 'y': return SY;
				case 'z': return SZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return TA;
				case 'c': return TC;
				case 'd': return TD;
				case 'f': return TF;
				case 'g': return TG;
				case 'h': return TH;
				case 'j': return TJ;
				case 'k': return TK;
				case 'l': return TL;
				case 'm': return TM;
				case 'n': return TN;
				case 'o': return TO;
				case 'p': return TL;
				case 'r': return TR;
				case 't': return TT;
				case 'v': return TV;
				case 'w': return TW;
				case 'z': return TZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return UA;
				case 'g': return UG;
				case 'm': return UM;
				case 'n': return UN;
				case 's': return US;
				case 'y': return UY;
				case 'z': return UZ;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return VA;
				case 'c': return VC;
				case 'e': return VE;
				case 'g': return VG;
				case 'i': return VI;
				case 'n': return VN;
				case 'u': return VU;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'f': return WF;
				case 's': return WS;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return YE;
				case 'e': return YE;
				case 't': return YT;
				case 'u': return YU;
				default: return null;
			}
		}
		
		private static Region? tryParse_L2_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return ZA;
				case 'm': return ZM;
				case 'r': return CD;
				case 'w': return ZW;
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
				case '1': return M001;
				case '2': return M002;
				case '3': return M003;
				case '5': return M005;
				case '9': return M009;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_01(StringSpan span)
		{
			switch(span[2])
			{
				case '1': return M011;
				case '3': return M013;
				case '4': return M014;
				case '5': return M015;
				case '7': return M017;
				case '8': return M018;
				case '9': return M019;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_02(StringSpan span)
		{
			switch(span[2])
			{
				case '1': return M021;
				case '9': return M029;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_03(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return M030;
				case '4': return M034;
				case '5': return M035;
				case '9': return M039;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_05(StringSpan span)
		{
			switch(span[2])
			{
				case '3': return M053;
				case '4': return M054;
				case '7': return M057;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_06(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '1')
				return M061;
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
				case '2': return M142;
				case '3': return M143;
				case '5': return M145;
				default: return null;
			}
		}
		
		private static Region? tryParse_L3_15(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return M150;
				case '1': return M151;
				case '4': return M154;
				case '5': return M155;
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
				return M202;
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
				return M419;
			return null;
		}
	}
}
