using System;
using System.Globalization;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Language
	{

		internal static Language? tryParseFromExtLanguage_AR(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_AR_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3(StringSpan span)
		{
			switch(span[0])
			{
				case 'a': return tryParseFromExtLanguage_AR_L3_a(span);
				case 'b': return tryParseFromExtLanguage_AR_L3_b(span);
				case 'p': return tryParseFromExtLanguage_AR_L3_p(span);
				case 's': return tryParseFromExtLanguage_AR_L3_s(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParseFromExtLanguage_AR_L3_aa(span);
				case 'b': return tryParseFromExtLanguage_AR_L3_ab(span);
				case 'c': return tryParseFromExtLanguage_AR_L3_ac(span);
				case 'd': return tryParseFromExtLanguage_AR_L3_ad(span);
				case 'e': return tryParseFromExtLanguage_AR_L3_ae(span);
				case 'f': return tryParseFromExtLanguage_AR_L3_af(span);
				case 'j': return tryParseFromExtLanguage_AR_L3_aj(span);
				case 'p': return tryParseFromExtLanguage_AR_L3_ap(span);
				case 'r': return tryParseFromExtLanguage_AR_L3_ar(span);
				case 'u': return tryParseFromExtLanguage_AR_L3_au(span);
				case 'v': return tryParseFromExtLanguage_AR_L3_av(span);
				case 'y': return tryParseFromExtLanguage_AR_L3_ay(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_aa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return Language.AAO;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ab(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return Language.ABH;
				case 'v': return Language.ABV;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ac(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return Language.ACM;
				case 'q': return Language.ACQ;
				case 'w': return Language.ACW;
				case 'x': return Language.ACX;
				case 'y': return Language.ACY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'f')
				return Language.ADF;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ae(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.AEB;
				case 'c': return Language.AEC;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_af(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'b')
				return Language.AFB;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_aj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return Language.AJP;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ap(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return Language.APC;
				case 'd': return Language.APD;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ar(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.ARB;
				case 'q': return Language.ARQ;
				case 's': return Language.ARS;
				case 'y': return Language.ARY;
				case 'z': return Language.ARZ;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_au(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return Language.AUZ;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_av(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.AVL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ay(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return Language.AYH;
				case 'l': return Language.AYL;
				case 'n': return Language.AYN;
				case 'p': return Language.AYP;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_b(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'b')
				return tryParseFromExtLanguage_AR_L3_bb(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_bb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return Language.BBZ;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_p(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'g')
				return tryParseFromExtLanguage_AR_L3_pg(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_pg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return Language.PGA;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'h': return tryParseFromExtLanguage_AR_L3_sh(span);
				case 's': return tryParseFromExtLanguage_AR_L3_ss(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_sh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return Language.SHU;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_AR_L3_ss(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return Language.SSH;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_SGN(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_SGN_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3(StringSpan span)
		{
			switch(span[0])
			{
				case 'a': return tryParseFromExtLanguage_SGN_L3_a(span);
				case 'b': return tryParseFromExtLanguage_SGN_L3_b(span);
				case 'c': return tryParseFromExtLanguage_SGN_L3_c(span);
				case 'd': return tryParseFromExtLanguage_SGN_L3_d(span);
				case 'e': return tryParseFromExtLanguage_SGN_L3_e(span);
				case 'f': return tryParseFromExtLanguage_SGN_L3_f(span);
				case 'g': return tryParseFromExtLanguage_SGN_L3_g(span);
				case 'h': return tryParseFromExtLanguage_SGN_L3_h(span);
				case 'i': return tryParseFromExtLanguage_SGN_L3_i(span);
				case 'j': return tryParseFromExtLanguage_SGN_L3_j(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_k(span);
				case 'l': return tryParseFromExtLanguage_SGN_L3_l(span);
				case 'm': return tryParseFromExtLanguage_SGN_L3_m(span);
				case 'n': return tryParseFromExtLanguage_SGN_L3_n(span);
				case 'o': return tryParseFromExtLanguage_SGN_L3_o(span);
				case 'p': return tryParseFromExtLanguage_SGN_L3_p(span);
				case 'r': return tryParseFromExtLanguage_SGN_L3_r(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_s(span);
				case 't': return tryParseFromExtLanguage_SGN_L3_t(span);
				case 'u': return tryParseFromExtLanguage_SGN_L3_u(span);
				case 'v': return tryParseFromExtLanguage_SGN_L3_v(span);
				case 'w': return tryParseFromExtLanguage_SGN_L3_w(span);
				case 'x': return tryParseFromExtLanguage_SGN_L3_x(span);
				case 'y': return tryParseFromExtLanguage_SGN_L3_y(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_z(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_ad(span);
				case 'e': return tryParseFromExtLanguage_SGN_L3_ae(span);
				case 'f': return tryParseFromExtLanguage_SGN_L3_af(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_as(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.ADS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ae(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return Language.AED;
				case 'n': return Language.AEN;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_af(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return Language.AFG;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_as(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.ASE;
				case 'f': return Language.ASF;
				case 'p': return Language.ASP;
				case 'q': return Language.ASQ;
				case 'w': return Language.ASW;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'f': return tryParseFromExtLanguage_SGN_L3_bf(span);
				case 'o': return tryParseFromExtLanguage_SGN_L3_bo(span);
				case 'q': return tryParseFromExtLanguage_SGN_L3_bq(span);
				case 'v': return tryParseFromExtLanguage_SGN_L3_bv(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_bz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_bf(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return Language.BFI;
				case 'k': return Language.BFK;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_bo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return Language.BOG;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_bq(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return Language.BQN;
				case 'y': return Language.BQY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_bv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.BVL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_bz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.BZS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_cd(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_cs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_cd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.CDS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_cs(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return Language.CSC;
				case 'd': return Language.CSD;
				case 'e': return Language.CSE;
				case 'f': return Language.CSF;
				case 'g': return Language.CSG;
				case 'l': return Language.CSL;
				case 'n': return Language.CSN;
				case 'q': return Language.CSQ;
				case 'r': return Language.CSR;
				case 'x': return Language.CSX;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'o': return tryParseFromExtLanguage_SGN_L3_do(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ds(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_do(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'q')
				return Language.DOQ;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ds(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.DSE;
				case 'l': return Language.DSL;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParseFromExtLanguage_SGN_L3_ec(span);
				case 'h': return tryParseFromExtLanguage_SGN_L3_eh(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_es(span);
				case 't': return tryParseFromExtLanguage_SGN_L3_et(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ec(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.ECS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_eh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.EHS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_es(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.ESL;
				case 'n': return Language.ESN;
				case 'o': return Language.ESO;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_et(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return Language.ETH;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_f(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParseFromExtLanguage_SGN_L3_fc(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_fs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_fc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.FCS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_fs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.FSE;
				case 'l': return Language.FSL;
				case 's': return Language.FSS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_gd(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_gs(span);
				case 'u': return tryParseFromExtLanguage_SGN_L3_gu(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_gd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.GDS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_gs(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.GSE;
				case 'g': return Language.GSG;
				case 'm': return Language.GSM;
				case 's': return Language.GSS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_gu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.GUS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParseFromExtLanguage_SGN_L3_ha(span);
				case 'd': return tryParseFromExtLanguage_SGN_L3_hd(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_hk(span);
				case 'o': return tryParseFromExtLanguage_SGN_L3_ho(span);
				case 'p': return tryParseFromExtLanguage_SGN_L3_hp(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_hs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ha(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.HAB;
				case 'f': return Language.HAF;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_hd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.HDS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_hk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.HKS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.HOS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_hp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.HPS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_hs(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return Language.HSH;
				case 'l': return Language.HSL;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParseFromExtLanguage_SGN_L3_ic(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_ik(span);
				case 'l': return tryParseFromExtLanguage_SGN_L3_il(span);
				case 'n': return tryParseFromExtLanguage_SGN_L3_in(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_is(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ic(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.ICL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ik(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.IKS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_il(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.ILS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_in(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.INL;
				case 's': return Language.INS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_is(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.ISE;
				case 'g': return Language.ISG;
				case 'r': return Language.ISR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParseFromExtLanguage_SGN_L3_jc(span);
				case 'h': return tryParseFromExtLanguage_SGN_L3_jh(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_jk(span);
				case 'l': return tryParseFromExtLanguage_SGN_L3_jl(span);
				case 'o': return tryParseFromExtLanguage_SGN_L3_jo(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_js(span);
				case 'u': return tryParseFromExtLanguage_SGN_L3_ju(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_jc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JCS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_jh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JHS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_jk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JKS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_jl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JLS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_jo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JOS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_js(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.JSL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ju(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.JUS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParseFromExtLanguage_SGN_L3_kg(span);
				case 'v': return tryParseFromExtLanguage_SGN_L3_kv(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_kg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.KGI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_kv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return Language.KVK;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'b': return tryParseFromExtLanguage_SGN_L3_lb(span);
				case 'l': return tryParseFromExtLanguage_SGN_L3_ll(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ls(span);
				case 'w': return tryParseFromExtLanguage_SGN_L3_lw(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_lb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.LBS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ll(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.LLS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ls(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.LSB;
				case 'g': return Language.LSG;
				case 'l': return Language.LSL;
				case 'n': return Language.LSN;
				case 'o': return Language.LSO;
				case 'p': return Language.LSP;
				case 't': return Language.LST;
				case 'v': return Language.LSV;
				case 'y': return Language.LSY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_lw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.LWS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_md(span);
				case 'f': return tryParseFromExtLanguage_SGN_L3_mf(span);
				case 'r': return tryParseFromExtLanguage_SGN_L3_mr(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ms(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_mz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_md(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.MDL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_mf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.MFS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_mr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return Language.MRE;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ms(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return Language.MSD;
				case 'r': return Language.MSR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_mz(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return Language.MZC;
				case 'g': return Language.MZG;
				case 'y': return Language.MZY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'b': return tryParseFromExtLanguage_SGN_L3_nb(span);
				case 'c': return tryParseFromExtLanguage_SGN_L3_nc(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ns(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_nz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_nb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.NBS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_nc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.NCS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ns(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return Language.NSI;
				case 'l': return Language.NSL;
				case 'p': return Language.NSP;
				case 'r': return Language.NSR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_nz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.NZS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'k')
				return tryParseFromExtLanguage_SGN_L3_ok(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ok(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.OKL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParseFromExtLanguage_SGN_L3_pg(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_pk(span);
				case 'r': return tryParseFromExtLanguage_SGN_L3_pr(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ps(span);
				case 'y': return tryParseFromExtLanguage_SGN_L3_py(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_pg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return Language.PGZ;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_pk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.PKS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_pr(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.PRL;
				case 'z': return Language.PRZ;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ps(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return Language.PSC;
				case 'd': return Language.PSD;
				case 'g': return Language.PSG;
				case 'l': return Language.PSL;
				case 'o': return Language.PSO;
				case 'p': return Language.PSP;
				case 'r': return Language.PSR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_py(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.PYS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'm': return tryParseFromExtLanguage_SGN_L3_rm(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_rs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_rm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.RMS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_rs(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return Language.RSI;
				case 'l': return Language.RSL;
				case 'm': return Language.RSM;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_sd(span);
				case 'f': return tryParseFromExtLanguage_SGN_L3_sf(span);
				case 'g': return tryParseFromExtLanguage_SGN_L3_sg(span);
				case 'l': return tryParseFromExtLanguage_SGN_L3_sl(span);
				case 'q': return tryParseFromExtLanguage_SGN_L3_sq(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ss(span);
				case 'v': return tryParseFromExtLanguage_SGN_L3_sv(span);
				case 'w': return tryParseFromExtLanguage_SGN_L3_sw(span);
				case 'y': return tryParseFromExtLanguage_SGN_L3_sy(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_sz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.SDL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sf(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.SFB;
				case 's': return Language.SFS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sg(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return Language.SGG;
				case 'x': return Language.SGX;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sl(StringSpan span)
		{
			switch(span[2])
			{
				case 'f': return Language.SLF;
				case 's': return Language.SLS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sq(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return Language.SQK;
				case 's': return Language.SQS;
				case 'x': return Language.SQX;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ss(StringSpan span)
		{
			switch(span[2])
			{
				case 'p': return Language.SSP;
				case 'r': return Language.SSR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return Language.SVK;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.SWL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return Language.SYY;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_sz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.SZS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_t(StringSpan span)
		{
			switch(span[1])
			{
				case 's': return tryParseFromExtLanguage_SGN_L3_ts(span);
				case 'z': return tryParseFromExtLanguage_SGN_L3_tz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ts(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.TSE;
				case 'm': return Language.TSM;
				case 'q': return Language.TSQ;
				case 's': return Language.TSS;
				case 'y': return Language.TSY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_tz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return Language.TZA;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParseFromExtLanguage_SGN_L3_ug(span);
				case 'k': return tryParseFromExtLanguage_SGN_L3_uk(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ug(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return Language.UGN;
				case 'y': return Language.UGY;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_uk(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.UKL;
				case 's': return Language.UKS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParseFromExtLanguage_SGN_L3_vg(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_vs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_vg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return Language.VGT;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_vs(StringSpan span)
		{
			switch(span[2])
			{
				case 'i': return Language.VSI;
				case 'l': return Language.VSL;
				case 'v': return Language.VSV;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_w(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'b')
				return tryParseFromExtLanguage_SGN_L3_wb(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_wb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.WBS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_x(StringSpan span)
		{
			switch(span[1])
			{
				case 'k': return tryParseFromExtLanguage_SGN_L3_xk(span);
				case 'm': return tryParseFromExtLanguage_SGN_L3_xm(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_xk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.XKI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_xm(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.XML;
				case 's': return Language.XMS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_SGN_L3_yd(span);
				case 'g': return tryParseFromExtLanguage_SGN_L3_yg(span);
				case 'h': return tryParseFromExtLanguage_SGN_L3_yh(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_ys(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_yd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.YDS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_yg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.YGS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_yh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.YHS;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_ys(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return Language.YSL;
				case 'm': return Language.YSM;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return tryParseFromExtLanguage_SGN_L3_zi(span);
				case 's': return tryParseFromExtLanguage_SGN_L3_zs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_zi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'b')
				return Language.ZIB;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SGN_L3_zs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.ZSL;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_MS(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_MS_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3(StringSpan span)
		{
			switch(span[0])
			{
				case 'b': return tryParseFromExtLanguage_MS_L3_b(span);
				case 'c': return tryParseFromExtLanguage_MS_L3_c(span);
				case 'd': return tryParseFromExtLanguage_MS_L3_d(span);
				case 'h': return tryParseFromExtLanguage_MS_L3_h(span);
				case 'j': return tryParseFromExtLanguage_MS_L3_j(span);
				case 'k': return tryParseFromExtLanguage_MS_L3_k(span);
				case 'l': return tryParseFromExtLanguage_MS_L3_l(span);
				case 'm': return tryParseFromExtLanguage_MS_L3_m(span);
				case 'o': return tryParseFromExtLanguage_MS_L3_o(span);
				case 'p': return tryParseFromExtLanguage_MS_L3_p(span);
				case 't': return tryParseFromExtLanguage_MS_L3_t(span);
				case 'u': return tryParseFromExtLanguage_MS_L3_u(span);
				case 'v': return tryParseFromExtLanguage_MS_L3_v(span);
				case 'x': return tryParseFromExtLanguage_MS_L3_x(span);
				case 'z': return tryParseFromExtLanguage_MS_L3_z(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'j': return tryParseFromExtLanguage_MS_L3_bj(span);
				case 't': return tryParseFromExtLanguage_MS_L3_bt(span);
				case 'v': return tryParseFromExtLanguage_MS_L3_bv(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_bj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.BJN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_bt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'j')
				return Language.BTJ;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_bv(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.BVE;
				case 'u': return Language.BVU;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_c(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParseFromExtLanguage_MS_L3_co(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_co(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return Language.COA;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_d(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return tryParseFromExtLanguage_MS_L3_du(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_du(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return Language.DUP;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_h(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'j')
				return tryParseFromExtLanguage_MS_L3_hj(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_hj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.HJI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_j(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParseFromExtLanguage_MS_L3_ja(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_ja(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return Language.JAK;
				case 'x': return Language.JAX;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'v': return tryParseFromExtLanguage_MS_L3_kv(span);
				case 'x': return tryParseFromExtLanguage_MS_L3_kx(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_kv(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return Language.KVB;
				case 'r': return Language.KVR;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_kx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return Language.KXD;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParseFromExtLanguage_MS_L3_lc(span);
				case 'i': return tryParseFromExtLanguage_MS_L3_li(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_lc(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return Language.LCE;
				case 'f': return Language.LCF;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_li(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'w')
				return Language.LIW;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParseFromExtLanguage_MS_L3_ma(span);
				case 'e': return tryParseFromExtLanguage_MS_L3_me(span);
				case 'f': return tryParseFromExtLanguage_MS_L3_mf(span);
				case 'i': return tryParseFromExtLanguage_MS_L3_mi(span);
				case 'q': return tryParseFromExtLanguage_MS_L3_mq(span);
				case 's': return tryParseFromExtLanguage_MS_L3_ms(span);
				case 'u': return tryParseFromExtLanguage_MS_L3_mu(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_ma(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return Language.MAX;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_me(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return Language.MEO;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_mf(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return Language.MFA;
				case 'b': return Language.MFB;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_mi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.MIN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_mq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return Language.MQG;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_ms(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.MSI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_mu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.MUI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'r')
				return tryParseFromExtLanguage_MS_L3_or(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_or(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return Language.ORN;
				case 's': return Language.ORS;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParseFromExtLanguage_MS_L3_pe(span);
				case 's': return tryParseFromExtLanguage_MS_L3_ps(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_pe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return Language.PEL;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_ps(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return Language.PSE;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_t(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'm')
				return tryParseFromExtLanguage_MS_L3_tm(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_tm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'w')
				return Language.TMW;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_u(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'r')
				return tryParseFromExtLanguage_MS_L3_ur(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_ur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return Language.URK;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_v(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'k')
				return tryParseFromExtLanguage_MS_L3_vk(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_vk(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return Language.VKK;
				case 't': return Language.VKT;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_x(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'm')
				return tryParseFromExtLanguage_MS_L3_xm(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_xm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return Language.XMM;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'l': return tryParseFromExtLanguage_MS_L3_zl(span);
				case 'm': return tryParseFromExtLanguage_MS_L3_zm(span);
				case 's': return tryParseFromExtLanguage_MS_L3_zs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_zl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return Language.ZLM;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_zm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return Language.ZMI;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_MS_L3_zs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return Language.ZSM;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_ZH(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_ZH_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3(StringSpan span)
		{
			switch(span[0])
			{
				case 'c': return tryParseFromExtLanguage_ZH_L3_c(span);
				case 'g': return tryParseFromExtLanguage_ZH_L3_g(span);
				case 'h': return tryParseFromExtLanguage_ZH_L3_h(span);
				case 'l': return tryParseFromExtLanguage_ZH_L3_l(span);
				case 'm': return tryParseFromExtLanguage_ZH_L3_m(span);
				case 'n': return tryParseFromExtLanguage_ZH_L3_n(span);
				case 'w': return tryParseFromExtLanguage_ZH_L3_w(span);
				case 'y': return tryParseFromExtLanguage_ZH_L3_y(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParseFromExtLanguage_ZH_L3_cd(span);
				case 'j': return tryParseFromExtLanguage_ZH_L3_cj(span);
				case 'm': return tryParseFromExtLanguage_ZH_L3_cm(span);
				case 'n': return tryParseFromExtLanguage_ZH_L3_cn(span);
				case 'p': return tryParseFromExtLanguage_ZH_L3_cp(span);
				case 's': return tryParseFromExtLanguage_ZH_L3_cs(span);
				case 'z': return tryParseFromExtLanguage_ZH_L3_cz(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return Language.CDO;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return Language.CJY;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.CMN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return Language.CNP;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return Language.CPX;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return Language.CSP;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_cz(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return Language.CZH;
				case 'o': return Language.CZO;
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_g(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParseFromExtLanguage_ZH_L3_ga(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_ga(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.GAN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParseFromExtLanguage_ZH_L3_ha(span);
				case 's': return tryParseFromExtLanguage_ZH_L3_hs(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_ha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return Language.HAK;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_hs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.HSN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_l(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'z')
				return tryParseFromExtLanguage_ZH_L3_lz(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_lz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return Language.LZH;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_m(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'n')
				return tryParseFromExtLanguage_ZH_L3_mn(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_mn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return Language.MNP;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_n(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParseFromExtLanguage_ZH_L3_na(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_na(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.NAN;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_w(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return tryParseFromExtLanguage_ZH_L3_wu(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_wu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return Language.WUU;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_y(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return tryParseFromExtLanguage_ZH_L3_yu(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_ZH_L3_yu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return Language.YUE;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_KOK(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_KOK_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_KOK_L3(StringSpan span)
		{
			switch(span[0])
			{
				case 'g': return tryParseFromExtLanguage_KOK_L3_g(span);
				case 'k': return tryParseFromExtLanguage_KOK_L3_k(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_KOK_L3_g(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParseFromExtLanguage_KOK_L3_go(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_KOK_L3_go(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return Language.GOM;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_KOK_L3_k(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'n')
				return tryParseFromExtLanguage_KOK_L3_kn(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_KOK_L3_kn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return Language.KNN;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_LV(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_LV_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_LV_L3(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[0]) == 'l')
				return tryParseFromExtLanguage_LV_L3_l(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_LV_L3_l(StringSpan span)
		{
			switch(span[1])
			{
				case 't': return tryParseFromExtLanguage_LV_L3_lt(span);
				case 'v': return tryParseFromExtLanguage_LV_L3_lv(span);
				default: return null;
			}
		}
		
		private static Language? tryParseFromExtLanguage_LV_L3_lt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return Language.LTG;
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_LV_L3_lv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return Language.LVS;
			return null;
		}

		internal static Language? tryParseFromExtLanguage_SW(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_SW_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SW_L3(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[0]) == 's')
				return tryParseFromExtLanguage_SW_L3_s(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SW_L3_s(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'w')
				return tryParseFromExtLanguage_SW_L3_sw(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_SW_L3_sw(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return Language.SWC;
				case 'h': return Language.SWH;
				default: return null;
			}
		}

		internal static Language? tryParseFromExtLanguage_UZ(StringSpan span)
		{
			if(span.Length == 3)
				return tryParseFromExtLanguage_UZ_L3(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_UZ_L3(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[0]) == 'u')
				return tryParseFromExtLanguage_UZ_L3_u(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_UZ_L3_u(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'z')
				return tryParseFromExtLanguage_UZ_L3_uz(span);
			return null;
		}
		
		private static Language? tryParseFromExtLanguage_UZ_L3_uz(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return Language.UZN;
				case 's': return Language.UZS;
				default: return null;
			}
		}
	}
}
