using System;
using System.Globalization;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Variant
	{

		internal static Variant? TryParse(StringSpan span)
		{
			switch(span.Length)
			{
				case 4: return tryParse_L4(span);
				case 5: return tryParse_L5(span);
				case 6: return tryParse_L6(span);
				case 7: return tryParse_L7(span);
				case 8: return tryParse_L8(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L4(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[0]) == '1')
				return tryParse_L4_1(span);
			return null;
		}
		
		private static Variant? tryParse_L4_1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == '9')
				return tryParse_L4_19(span);
			return null;
		}
		
		private static Variant? tryParse_L4_19(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return tryParse_L4_190(span);
				case '9': return tryParse_L4_199(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L4_190(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '1')
				return V1901Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L4_199(StringSpan span)
		{
			switch(span[3])
			{
				case '4': return V1994Cache.Instance;
				case '6': return V1996Cache.Instance;
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5(StringSpan span)
		{
			switch(span[0])
			{
				case 'a': return tryParse_L5_a(span);
				case 'b': return tryParse_L5_b(span);
				case 'c': return tryParse_L5_c(span);
				case 'j': return tryParse_L5_j(span);
				case 'k': return tryParse_L5_k(span);
				case 'l': return tryParse_L5_l(span);
				case 'n': return tryParse_L5_n(span);
				case 'o': return tryParse_L5_o(span);
				case 'p': return tryParse_L5_p(span);
				case 'r': return tryParse_L5_r(span);
				case 's': return tryParse_L5_s(span);
				case 'u': return tryParse_L5_u(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_a(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'l')
				return tryParse_L5_al(span);
			return null;
		}
		
		private static Variant? tryParse_L5_al(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L5_alu(span);
			return null;
		}
		
		private static Variant? tryParse_L5_alu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return tryParse_L5_aluk(span);
			return null;
		}
		
		private static Variant? tryParse_L5_aluk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'u')
				return AlukuCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L5_ba(span);
				case 'i': return tryParse_L5_bi(span);
				case 'o': return tryParse_L5_bo(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_ba(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L5_bar(span);
			return null;
		}
		
		private static Variant? tryParse_L5_bar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return tryParse_L5_barl(span);
			return null;
		}
		
		private static Variant? tryParse_L5_barl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return BarlaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_bi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L5_bis(span);
			return null;
		}
		
		private static Variant? tryParse_L5_bis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return tryParse_L5_bisk(span);
			return null;
		}
		
		private static Variant? tryParse_L5_bisk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return BiskeCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_bo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L5_boo(span);
			return null;
		}
		
		private static Variant? tryParse_L5_boo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L5_boon(span);
			return null;
		}
		
		private static Variant? tryParse_L5_boon(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return BoontCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_c(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L5_co(span);
			return null;
		}
		
		private static Variant? tryParse_L5_co(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L5_cor(span);
			return null;
		}
		
		private static Variant? tryParse_L5_cor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L5_corn(span);
			return null;
		}
		
		private static Variant? tryParse_L5_corn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'u')
				return CornuCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_j(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParse_L5_ja(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ja(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L5_jau(span);
			return null;
		}
		
		private static Variant? tryParse_L5_jau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return tryParse_L5_jaue(span);
			return null;
		}
		
		private static Variant? tryParse_L5_jaue(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return JauerCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'k': return tryParse_L5_kk(span);
				case 's': return tryParse_L5_ks(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_kk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L5_kkc(span);
			return null;
		}
		
		private static Variant? tryParse_L5_kkc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L5_kkco(span);
			return null;
		}
		
		private static Variant? tryParse_L5_kkco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return KkcorCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_ks(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L5_ksc(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ksc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L5_ksco(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ksco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return KscorCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_l(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'i')
				return tryParse_L5_li(span);
			return null;
		}
		
		private static Variant? tryParse_L5_li(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L5_lip(span);
			return null;
		}
		
		private static Variant? tryParse_L5_lip(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L5_lipa(span);
			return null;
		}
		
		private static Variant? tryParse_L5_lipa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'w')
				return LipawCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L5_ne(span);
				case 'j': return tryParse_L5_nj(span);
				case 'u': return tryParse_L5_nu(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_ne(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return tryParse_L5_ned(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ned(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L5_nedi(span);
			return null;
		}
		
		private static Variant? tryParse_L5_nedi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return NedisCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_nj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L5_nji(span);
			return null;
		}
		
		private static Variant? tryParse_L5_nji(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'v')
				return tryParse_L5_njiv(span);
			return null;
		}
		
		private static Variant? tryParse_L5_njiv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return NjivaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_nu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L5_nul(span);
			return null;
		}
		
		private static Variant? tryParse_L5_nul(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L5_nuli(span);
			return null;
		}
		
		private static Variant? tryParse_L5_nuli(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'k')
				return NulikCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 's')
				return tryParse_L5_os(span);
			return null;
		}
		
		private static Variant? tryParse_L5_os(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L5_oso(span);
			return null;
		}
		
		private static Variant? tryParse_L5_oso(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'j')
				return tryParse_L5_osoj(span);
			return null;
		}
		
		private static Variant? tryParse_L5_osoj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return OsojsCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L5_pe(span);
				case 'u': return tryParse_L5_pu(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_pe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L5_pea(span);
			return null;
		}
		
		private static Variant? tryParse_L5_pea(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L5_pean(span);
			return null;
		}
		
		private static Variant? tryParse_L5_pean(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return PeanoCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_pu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L5_put(span);
			return null;
		}
		
		private static Variant? tryParse_L5_put(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return tryParse_L5_pute(span);
			return null;
		}
		
		private static Variant? tryParse_L5_pute(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return PuterCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return tryParse_L5_ri(span);
				case 'o': return tryParse_L5_ro(span);
				case 'u': return tryParse_L5_ru(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_ri(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return tryParse_L5_rig(span);
			return null;
		}
		
		private static Variant? tryParse_L5_rig(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L5_rigi(span);
			return null;
		}
		
		private static Variant? tryParse_L5_rigi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'k')
				return RigikCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_ro(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return tryParse_L5_roz(span);
			return null;
		}
		
		private static Variant? tryParse_L5_roz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L5_roza(span);
			return null;
		}
		
		private static Variant? tryParse_L5_roza(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'j')
				return RozajCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_ru(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L5_rum(span);
			return null;
		}
		
		private static Variant? tryParse_L5_rum(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return tryParse_L5_rumg(span);
			return null;
		}
		
		private static Variant? tryParse_L5_rumg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return RumgrCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_s(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L5_so(span);
			return null;
		}
		
		private static Variant? tryParse_L5_so(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L5_sol(span);
				case 't': return tryParse_L5_sot(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L5_sol(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return tryParse_L5_solb(span);
			return null;
		}
		
		private static Variant? tryParse_L5_solb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return SolbaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_sot(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L5_sota(span);
			return null;
		}
		
		private static Variant? tryParse_L5_sota(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'v')
				return SotavCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L5_u(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'c')
				return tryParse_L5_uc(span);
			return null;
		}
		
		private static Variant? tryParse_L5_uc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L5_ucc(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ucc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L5_ucco(span);
			return null;
		}
		
		private static Variant? tryParse_L5_ucco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return UccorCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6(StringSpan span)
		{
			switch(span[0])
			{
				case 'a': return tryParse_L6_a(span);
				case 'c': return tryParse_L6_c(span);
				case 'd': return tryParse_L6_d(span);
				case 'e': return tryParse_L6_e(span);
				case 'f': return tryParse_L6_f(span);
				case 'g': return tryParse_L6_g(span);
				case 'h': return tryParse_L6_h(span);
				case 'n': return tryParse_L6_n(span);
				case 'p': return tryParse_L6_p(span);
				case 's': return tryParse_L6_s(span);
				case 't': return tryParse_L6_t(span);
				case 'u': return tryParse_L6_u(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'o': return tryParse_L6_ao(span);
				case 'r': return tryParse_L6_ar(span);
				case 's': return tryParse_L6_as(span);
				case 'u': return tryParse_L6_au(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_ao(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '1')
				return tryParse_L6_ao1(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ao1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '9')
				return tryParse_L6_ao19(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ao19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '9')
				return tryParse_L6_ao199(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ao199(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '0')
				return Ao1990Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_ar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L6_ara(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ara(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L6_aran(span);
			return null;
		}
		
		private static Variant? tryParse_L6_aran(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return tryParse_L6_arane(span);
			return null;
		}
		
		private static Variant? tryParse_L6_arane(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 's')
				return AranesCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_as(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L6_asa(span);
			return null;
		}
		
		private static Variant? tryParse_L6_asa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L6_asan(span);
			return null;
		}
		
		private static Variant? tryParse_L6_asan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return tryParse_L6_asant(span);
			return null;
		}
		
		private static Variant? tryParse_L6_asant(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return AsanteCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_au(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'v')
				return tryParse_L6_auv(span);
			return null;
		}
		
		private static Variant? tryParse_L6_auv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return tryParse_L6_auve(span);
			return null;
		}
		
		private static Variant? tryParse_L6_auve(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return tryParse_L6_auver(span);
			return null;
		}
		
		private static Variant? tryParse_L6_auver(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return AuvernCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'i': return tryParse_L6_ci(span);
				case 'r': return tryParse_L6_cr(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_ci(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L6_cis(span);
			return null;
		}
		
		private static Variant? tryParse_L6_cis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L6_cisa(span);
			return null;
		}
		
		private static Variant? tryParse_L6_cisa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'u')
				return tryParse_L6_cisau(span);
			return null;
		}
		
		private static Variant? tryParse_L6_cisau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'p')
				return CisaupCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_cr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L6_cre(span);
			return null;
		}
		
		private static Variant? tryParse_L6_cre(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L6_crei(span);
			return null;
		}
		
		private static Variant? tryParse_L6_crei(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L6_creis(span);
			return null;
		}
		
		private static Variant? tryParse_L6_creis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 's')
				return CreissCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_d(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParse_L6_da(span);
			return null;
		}
		
		private static Variant? tryParse_L6_da(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'j')
				return tryParse_L6_daj(span);
			return null;
		}
		
		private static Variant? tryParse_L6_daj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L6_dajn(span);
			return null;
		}
		
		private static Variant? tryParse_L6_dajn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'k')
				return tryParse_L6_dajnk(span);
			return null;
		}
		
		private static Variant? tryParse_L6_dajnk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'o')
				return DajnkoCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_e(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'k')
				return tryParse_L6_ek(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ek(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L6_eka(span);
			return null;
		}
		
		private static Variant? tryParse_L6_eka(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'v')
				return tryParse_L6_ekav(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ekav(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L6_ekavs(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ekavs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return EkavskCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_f(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L6_fo(span);
			return null;
		}
		
		private static Variant? tryParse_L6_fo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L6_fon(span);
			return null;
		}
		
		private static Variant? tryParse_L6_fon(StringSpan span)
		{
			switch(span[3])
			{
				case 'i': return tryParse_L6_foni(span);
				case 'u': return tryParse_L6_fonu(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_foni(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'p')
				return tryParse_L6_fonip(span);
			return null;
		}
		
		private static Variant? tryParse_L6_fonip(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return FonipaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_fonu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'p')
				return tryParse_L6_fonup(span);
			return null;
		}
		
		private static Variant? tryParse_L6_fonup(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return FonupaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L6_ga(span);
				case 'r': return tryParse_L6_gr(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_ga(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L6_gas(span);
			return null;
		}
		
		private static Variant? tryParse_L6_gas(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return tryParse_L6_gasc(span);
			return null;
		}
		
		private static Variant? tryParse_L6_gasc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L6_gasco(span);
			return null;
		}
		
		private static Variant? tryParse_L6_gasco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return GasconCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_gr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L6_gri(span);
			return null;
		}
		
		private static Variant? tryParse_L6_gri(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return tryParse_L6_grit(span);
			return null;
		}
		
		private static Variant? tryParse_L6_grit(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L6_grita(span);
			return null;
		}
		
		private static Variant? tryParse_L6_grita(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'l')
				return GritalCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_h(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'e')
				return tryParse_L6_he(span);
			return null;
		}
		
		private static Variant? tryParse_L6_he(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L6_hep(span);
			return null;
		}
		
		private static Variant? tryParse_L6_hep(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return tryParse_L6_hepl(span);
			return null;
		}
		
		private static Variant? tryParse_L6_hepl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L6_heplo(span);
			return null;
		}
		
		private static Variant? tryParse_L6_heplo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'c')
				return Alalc97Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParse_L6_nd(span);
				case 'i': return tryParse_L6_ni(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_nd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return tryParse_L6_ndy(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ndy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return tryParse_L6_ndyu(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ndyu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'k')
				return tryParse_L6_ndyuk(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ndyuk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return NdyukaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_ni(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L6_nic(span);
			return null;
		}
		
		private static Variant? tryParse_L6_nic(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L6_nica(span);
			return null;
		}
		
		private static Variant? tryParse_L6_nica(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return tryParse_L6_nicar(span);
			return null;
		}
		
		private static Variant? tryParse_L6_nicar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'd')
				return NicardCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L6_pa(span);
				case 'i': return tryParse_L6_pi(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_pa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L6_pam(span);
			return null;
		}
		
		private static Variant? tryParse_L6_pam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L6_pama(span);
			return null;
		}
		
		private static Variant? tryParse_L6_pama(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'k')
				return tryParse_L6_pamak(span);
			return null;
		}
		
		private static Variant? tryParse_L6_pamak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return PamakaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_pi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L6_pin(span);
			return null;
		}
		
		private static Variant? tryParse_L6_pin(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'y')
				return tryParse_L6_piny(span);
			return null;
		}
		
		private static Variant? tryParse_L6_piny(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L6_pinyi(span);
			return null;
		}
		
		private static Variant? tryParse_L6_pinyi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return PinyinCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParse_L6_sc(span);
				case 'i': return tryParse_L6_si(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_sc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L6_sco(span);
			return null;
		}
		
		private static Variant? tryParse_L6_sco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return tryParse_L6_scou(span);
			return null;
		}
		
		private static Variant? tryParse_L6_scou(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L6_scous(span);
			return null;
		}
		
		private static Variant? tryParse_L6_scous(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return ScouseCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_si(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L6_sim(span);
			return null;
		}
		
		private static Variant? tryParse_L6_sim(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'p')
				return tryParse_L6_simp(span);
			return null;
		}
		
		private static Variant? tryParse_L6_simp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'l')
				return tryParse_L6_simpl(span);
			return null;
		}
		
		private static Variant? tryParse_L6_simpl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return SimpleCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_t(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParse_L6_ta(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ta(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L6_tar(span);
			return null;
		}
		
		private static Variant? tryParse_L6_tar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L6_tara(span);
			return null;
		}
		
		private static Variant? tryParse_L6_tara(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L6_taras(span);
			return null;
		}
		
		private static Variant? tryParse_L6_taras(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return TaraskCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_u(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParse_L6_uc(span);
				case 'l': return tryParse_L6_ul(span);
				case 'n': return tryParse_L6_un(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L6_uc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L6_ucr(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ucr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return tryParse_L6_ucrc(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ucrc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L6_ucrco(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ucrco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return UcrcorCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_ul(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L6_uls(span);
			return null;
		}
		
		private static Variant? tryParse_L6_uls(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return tryParse_L6_ulst(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ulst(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return tryParse_L6_ulste(span);
			return null;
		}
		
		private static Variant? tryParse_L6_ulste(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return UlsterCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L6_un(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L6_uni(span);
			return null;
		}
		
		private static Variant? tryParse_L6_uni(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'f')
				return tryParse_L6_unif(span);
			return null;
		}
		
		private static Variant? tryParse_L6_unif(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L6_unifo(span);
			return null;
		}
		
		private static Variant? tryParse_L6_unifo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return UnifonCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7(StringSpan span)
		{
			switch(span[0])
			{
				case 'a': return tryParse_L7_a(span);
				case 'b': return tryParse_L7_b(span);
				case 'e': return tryParse_L7_e(span);
				case 'f': return tryParse_L7_f(span);
				case 'g': return tryParse_L7_g(span);
				case 'h': return tryParse_L7_h(span);
				case 'i': return tryParse_L7_i(span);
				case 'l': return tryParse_L7_l(span);
				case 'm': return tryParse_L7_m(span);
				case 'p': return tryParse_L7_p(span);
				case 's': return tryParse_L7_s(span);
				case 'v': return tryParse_L7_v(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'b': return tryParse_L7_ab(span);
				case 'k': return tryParse_L7_ak(span);
				case 'l': return tryParse_L7_al(span);
				case 'r': return tryParse_L7_ar(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_ab(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L7_abl(span);
			return null;
		}
		
		private static Variant? tryParse_L7_abl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '1')
				return tryParse_L7_abl1(span);
			return null;
		}
		
		private static Variant? tryParse_L7_abl1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '9')
				return tryParse_L7_abl19(span);
			return null;
		}
		
		private static Variant? tryParse_L7_abl19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '4')
				return tryParse_L7_abl194(span);
			return null;
		}
		
		private static Variant? tryParse_L7_abl194(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '3')
				return Abl1943Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_ak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L7_aku(span);
			return null;
		}
		
		private static Variant? tryParse_L7_aku(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L7_akua(span);
			return null;
		}
		
		private static Variant? tryParse_L7_akua(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'p')
				return tryParse_L7_akuap(span);
			return null;
		}
		
		private static Variant? tryParse_L7_akuap(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return tryParse_L7_akuape(span);
			return null;
		}
		
		private static Variant? tryParse_L7_akuape(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'm')
				return AkuapemCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_al(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L7_ala(span);
			return null;
		}
		
		private static Variant? tryParse_L7_ala(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return tryParse_L7_alal(span);
			return null;
		}
		
		private static Variant? tryParse_L7_alal(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'c')
				return tryParse_L7_alalc(span);
			return null;
		}
		
		private static Variant? tryParse_L7_alalc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '9')
				return tryParse_L7_alalc9(span);
			return null;
		}
		
		private static Variant? tryParse_L7_alalc9(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '7')
				return Alalc97Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_ar(StringSpan span)
		{
			switch(span[2])
			{
				case 'e': return tryParse_L7_are(span);
				case 'k': return tryParse_L7_ark(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_are(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'v')
				return tryParse_L7_arev(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arev(StringSpan span)
		{
			switch(span[4])
			{
				case 'e': return tryParse_L7_areve(span);
				case 'm': return tryParse_L7_arevm(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_areve(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'l')
				return tryParse_L7_arevel(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arevel(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return ArevelaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_arevm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'd')
				return tryParse_L7_arevmd(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arevmd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return ArevmdaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_ark(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L7_arka(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arka(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L7_arkai(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arkai(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return tryParse_L7_arkaik(span);
			return null;
		}
		
		private static Variant? tryParse_L7_arkaik(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return ArkaikaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L7_ba(span);
				case 'o': return tryParse_L7_bo(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_ba(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L7_bal(span);
				case 'u': return tryParse_L7_bau(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_bal(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L7_bala(span);
			return null;
		}
		
		private static Variant? tryParse_L7_bala(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'n')
				return tryParse_L7_balan(span);
			return null;
		}
		
		private static Variant? tryParse_L7_balan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return tryParse_L7_balank(span);
			return null;
		}
		
		private static Variant? tryParse_L7_balank(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return BalankaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_bau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return tryParse_L7_baud(span);
			return null;
		}
		
		private static Variant? tryParse_L7_baud(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'd')
				return tryParse_L7_baudd(span);
			return null;
		}
		
		private static Variant? tryParse_L7_baudd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'h')
				return tryParse_L7_bauddh(span);
			return null;
		}
		
		private static Variant? tryParse_L7_bauddh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return BauddhaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_bo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L7_boh(span);
			return null;
		}
		
		private static Variant? tryParse_L7_boh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L7_boho(span);
			return null;
		}
		
		private static Variant? tryParse_L7_boho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return tryParse_L7_bohor(span);
			return null;
		}
		
		private static Variant? tryParse_L7_bohor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L7_bohori(span);
			return null;
		}
		
		private static Variant? tryParse_L7_bohori(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'c')
				return BohoricCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_e(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'm')
				return tryParse_L7_em(span);
			return null;
		}
		
		private static Variant? tryParse_L7_em(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L7_emo(span);
			return null;
		}
		
		private static Variant? tryParse_L7_emo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return tryParse_L7_emod(span);
			return null;
		}
		
		private static Variant? tryParse_L7_emod(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return tryParse_L7_emode(span);
			return null;
		}
		
		private static Variant? tryParse_L7_emode(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return tryParse_L7_emoden(span);
			return null;
		}
		
		private static Variant? tryParse_L7_emoden(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'g')
				return EmodengCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_f(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L7_fo(span);
			return null;
		}
		
		private static Variant? tryParse_L7_fo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L7_fon(span);
			return null;
		}
		
		private static Variant? tryParse_L7_fon(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L7_fonn(span);
			return null;
		}
		
		private static Variant? tryParse_L7_fonn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L7_fonna(span);
			return null;
		}
		
		private static Variant? tryParse_L7_fonna(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'p')
				return tryParse_L7_fonnap(span);
			return null;
		}
		
		private static Variant? tryParse_L7_fonnap(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return FonnapaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_g(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'r')
				return tryParse_L7_gr(span);
			return null;
		}
		
		private static Variant? tryParse_L7_gr(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return tryParse_L7_grc(span);
				case 'm': return tryParse_L7_grm(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_grc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return tryParse_L7_grcl(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grcl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L7_grcla(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grcla(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 's')
				return tryParse_L7_grclas(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grclas(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 's')
				return GrclassCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_grm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L7_grmi(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grmi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L7_grmis(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grmis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 't')
				return tryParse_L7_grmist(span);
			return null;
		}
		
		private static Variant? tryParse_L7_grmist(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'r')
				return GrmistrCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_h(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'e')
				return tryParse_L7_he(span);
			return null;
		}
		
		private static Variant? tryParse_L7_he(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L7_hep(span);
			return null;
		}
		
		private static Variant? tryParse_L7_hep(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return tryParse_L7_hepb(span);
			return null;
		}
		
		private static Variant? tryParse_L7_hepb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'u')
				return tryParse_L7_hepbu(span);
			return null;
		}
		
		private static Variant? tryParse_L7_hepbu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return tryParse_L7_hepbur(span);
			return null;
		}
		
		private static Variant? tryParse_L7_hepbur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return HepburnCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_i(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 't')
				return tryParse_L7_it(span);
			return null;
		}
		
		private static Variant? tryParse_L7_it(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L7_iti(span);
			return null;
		}
		
		private static Variant? tryParse_L7_iti(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return tryParse_L7_itih(span);
			return null;
		}
		
		private static Variant? tryParse_L7_itih(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L7_itiha(span);
			return null;
		}
		
		private static Variant? tryParse_L7_itiha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 's')
				return tryParse_L7_itihas(span);
			return null;
		}
		
		private static Variant? tryParse_L7_itihas(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return ItihasaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L7_la(span);
				case 'e': return tryParse_L7_le(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_la(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L7_lau(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return tryParse_L7_lauk(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lauk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L7_lauki(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lauki(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return tryParse_L7_laukik(span);
			return null;
		}
		
		private static Variant? tryParse_L7_laukik(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return LaukikaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_le(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L7_lem(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lem(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L7_lemo(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lemo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L7_lemos(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lemos(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L7_lemosi(span);
			return null;
		}
		
		private static Variant? tryParse_L7_lemosi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return LemosinCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L7_me(span);
				case 'o': return tryParse_L7_mo(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_me(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L7_met(span);
			return null;
		}
		
		private static Variant? tryParse_L7_met(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return tryParse_L7_mete(span);
			return null;
		}
		
		private static Variant? tryParse_L7_mete(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'l')
				return tryParse_L7_metel(span);
			return null;
		}
		
		private static Variant? tryParse_L7_metel(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return tryParse_L7_metelk(span);
			return null;
		}
		
		private static Variant? tryParse_L7_metelk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'o')
				return MetelkoCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_mo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L7_mon(span);
			return null;
		}
		
		private static Variant? tryParse_L7_mon(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return tryParse_L7_mono(span);
			return null;
		}
		
		private static Variant? tryParse_L7_mono(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return tryParse_L7_monot(span);
			return null;
		}
		
		private static Variant? tryParse_L7_monot(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'o')
				return tryParse_L7_monoto(span);
			return null;
		}
		
		private static Variant? tryParse_L7_monoto(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return MonotonCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L7_pa(span);
				case 'o': return tryParse_L7_po(span);
				case 'r': return tryParse_L7_pr(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_pa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L7_pah(span);
			return null;
		}
		
		private static Variant? tryParse_L7_pah(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L7_paha(span);
			return null;
		}
		
		private static Variant? tryParse_L7_paha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'w')
				return tryParse_L7_pahaw(span);
			return null;
		}
		
		private static Variant? tryParse_L7_pahaw(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'h')
				return tryParse_L7_pahawh(span);
			return null;
		}
		
		private static Variant? tryParse_L7_pahawh(StringSpan span)
		{
			switch(span[6])
			{
				case '2': return Pahawh2Cache.Instance;
				case '3': return Pahawh3Cache.Instance;
				case '4': return Pahawh4Cache.Instance;
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_po(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L7_pol(span);
			return null;
		}
		
		private static Variant? tryParse_L7_pol(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'y')
				return tryParse_L7_poly(span);
			return null;
		}
		
		private static Variant? tryParse_L7_poly(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return tryParse_L7_polyt(span);
			return null;
		}
		
		private static Variant? tryParse_L7_polyt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'o')
				return tryParse_L7_polyto(span);
			return null;
		}
		
		private static Variant? tryParse_L7_polyto(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return PolytonCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_pr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L7_pro(span);
			return null;
		}
		
		private static Variant? tryParse_L7_pro(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'v')
				return tryParse_L7_prov(span);
			return null;
		}
		
		private static Variant? tryParse_L7_prov(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return tryParse_L7_prove(span);
			return null;
		}
		
		private static Variant? tryParse_L7_prove(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'n')
				return tryParse_L7_proven(span);
			return null;
		}
		
		private static Variant? tryParse_L7_proven(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'c')
				return ProvencCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_s(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'u')
				return tryParse_L7_su(span);
			return null;
		}
		
		private static Variant? tryParse_L7_su(StringSpan span)
		{
			switch(span[2])
			{
				case 'r': return tryParse_L7_sur(span);
				case 't': return tryParse_L7_sut(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L7_sur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return tryParse_L7_surs(span);
			return null;
		}
		
		private static Variant? tryParse_L7_surs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L7_sursi(span);
			return null;
		}
		
		private static Variant? tryParse_L7_sursi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'l')
				return tryParse_L7_sursil(span);
			return null;
		}
		
		private static Variant? tryParse_L7_sursil(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'v')
				return SursilvCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_sut(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return tryParse_L7_suts(span);
			return null;
		}
		
		private static Variant? tryParse_L7_suts(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L7_sutsi(span);
			return null;
		}
		
		private static Variant? tryParse_L7_sutsi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'l')
				return tryParse_L7_sutsil(span);
			return null;
		}
		
		private static Variant? tryParse_L7_sutsil(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'v')
				return SutsilvCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L7_v(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParse_L7_va(span);
			return null;
		}
		
		private static Variant? tryParse_L7_va(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L7_vai(span);
			return null;
		}
		
		private static Variant? tryParse_L7_vai(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return tryParse_L7_vaid(span);
			return null;
		}
		
		private static Variant? tryParse_L7_vaid(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L7_vaidi(span);
			return null;
		}
		
		private static Variant? tryParse_L7_vaidi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'k')
				return tryParse_L7_vaidik(span);
			return null;
		}
		
		private static Variant? tryParse_L7_vaidik(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return VaidikaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8(StringSpan span)
		{
			switch(span[0])
			{
				case '1': return tryParse_L8_1(span);
				case 'b': return tryParse_L8_b(span);
				case 'c': return tryParse_L8_c(span);
				case 'f': return tryParse_L8_f(span);
				case 'h': return tryParse_L8_h(span);
				case 'i': return tryParse_L8_i(span);
				case 'j': return tryParse_L8_j(span);
				case 'k': return tryParse_L8_k(span);
				case 'l': return tryParse_L8_l(span);
				case 'n': return tryParse_L8_n(span);
				case 'o': return tryParse_L8_o(span);
				case 'p': return tryParse_L8_p(span);
				case 's': return tryParse_L8_s(span);
				case 't': return tryParse_L8_t(span);
				case 'v': return tryParse_L8_v(span);
				case 'w': return tryParse_L8_w(span);
				case 'x': return tryParse_L8_x(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_1(StringSpan span)
		{
			switch(span[1])
			{
				case '6': return tryParse_L8_16(span);
				case '9': return tryParse_L8_19(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_16(StringSpan span)
		{
			switch(span[2])
			{
				case '0': return tryParse_L8_160(span);
				case '9': return tryParse_L8_169(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_160(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '6')
				return tryParse_L8_1606(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1606(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'n')
				return tryParse_L8_1606n(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1606n(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L8_1606ni(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1606ni(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'c')
				return tryParse_L8_1606nic(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1606nic(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 't')
				return V1606nictCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_169(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '4')
				return tryParse_L8_1694(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1694(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_1694a(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1694a(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'c')
				return tryParse_L8_1694ac(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1694ac(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return tryParse_L8_1694aca(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1694aca(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'd')
				return V1694acadCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == '5')
				return tryParse_L8_195(span);
			return null;
		}
		
		private static Variant? tryParse_L8_195(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == '9')
				return tryParse_L8_1959(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1959(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_1959a(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1959a(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'c')
				return tryParse_L8_1959ac(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1959ac(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return tryParse_L8_1959aca(span);
			return null;
		}
		
		private static Variant? tryParse_L8_1959aca(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'd')
				return V1959acadCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L8_ba(span);
				case 'i': return tryParse_L8_bi(span);
				case 'o': return tryParse_L8_bo(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_ba(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return tryParse_L8_bak(span);
				case 's': return tryParse_L8_bas(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_bak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return tryParse_L8_baku(span);
			return null;
		}
		
		private static Variant? tryParse_L8_baku(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '1')
				return tryParse_L8_baku1(span);
			return null;
		}
		
		private static Variant? tryParse_L8_baku1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '9')
				return tryParse_L8_baku19(span);
			return null;
		}
		
		private static Variant? tryParse_L8_baku19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '2')
				return tryParse_L8_baku192(span);
			return null;
		}
		
		private static Variant? tryParse_L8_baku192(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == '6')
				return Baku1926Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_bas(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L8_basi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_basi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'c')
				return tryParse_L8_basic(span);
			return null;
		}
		
		private static Variant? tryParse_L8_basic(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return tryParse_L8_basice(span);
			return null;
		}
		
		private static Variant? tryParse_L8_basice(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return tryParse_L8_basicen(span);
			return null;
		}
		
		private static Variant? tryParse_L8_basicen(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'g')
				return BasicengCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_bi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L8_bis(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return tryParse_L8_bisc(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bisc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_bisca(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bisca(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'y')
				return tryParse_L8_biscay(span);
			return null;
		}
		
		private static Variant? tryParse_L8_biscay(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return tryParse_L8_biscaya(span);
			return null;
		}
		
		private static Variant? tryParse_L8_biscaya(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'n')
				return BiscayanCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_bo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L8_bor(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L8_born(span);
			return null;
		}
		
		private static Variant? tryParse_L8_born(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'h')
				return tryParse_L8_bornh(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bornh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'o')
				return tryParse_L8_bornho(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bornho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'l')
				return tryParse_L8_bornhol(span);
			return null;
		}
		
		private static Variant? tryParse_L8_bornhol(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'm')
				return BornholmCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_c(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L8_co(span);
			return null;
		}
		
		private static Variant? tryParse_L8_co(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L8_col(span);
			return null;
		}
		
		private static Variant? tryParse_L8_col(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return tryParse_L8_colb(span);
			return null;
		}
		
		private static Variant? tryParse_L8_colb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '1')
				return tryParse_L8_colb1(span);
			return null;
		}
		
		private static Variant? tryParse_L8_colb1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '9')
				return tryParse_L8_colb19(span);
			return null;
		}
		
		private static Variant? tryParse_L8_colb19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '4')
				return tryParse_L8_colb194(span);
			return null;
		}
		
		private static Variant? tryParse_L8_colb194(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == '5')
				return Colb1945Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_f(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L8_fo(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L8_fon(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fon(StringSpan span)
		{
			switch(span[3])
			{
				case 'k': return tryParse_L8_fonk(span);
				case 'x': return tryParse_L8_fonx(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_fonk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L8_fonki(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonki(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return tryParse_L8_fonkir(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonkir(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 's')
				return tryParse_L8_fonkirs(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonkirs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'h')
				return FonkirshCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_fonx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 's')
				return tryParse_L8_fonxs(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonxs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return tryParse_L8_fonxsa(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonxsa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'm')
				return tryParse_L8_fonxsam(span);
			return null;
		}
		
		private static Variant? tryParse_L8_fonxsam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'p')
				return FonxsampCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'o': return tryParse_L8_ho(span);
				case 's': return tryParse_L8_hs(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_ho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return tryParse_L8_hog(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hog(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L8_hogn(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hogn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L8_hogno(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hogno(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return tryParse_L8_hognor(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hognor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 's')
				return tryParse_L8_hognors(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hognors(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'k')
				return HognorskCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_hs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L8_hsi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hsi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return tryParse_L8_hsis(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hsis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return tryParse_L8_hsist(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hsist(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return tryParse_L8_hsiste(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hsiste(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'm')
				return tryParse_L8_hsistem(span);
			return null;
		}
		
		private static Variant? tryParse_L8_hsistem(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'o')
				return HsistemoCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'j': return tryParse_L8_ij(span);
				case 'v': return tryParse_L8_iv(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_ij(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L8_ije(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ije(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return tryParse_L8_ijek(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ijek(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_ijeka(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ijeka(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'v')
				return tryParse_L8_ijekav(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ijekav(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 's')
				return tryParse_L8_ijekavs(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ijekavs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'k')
				return IjekavskCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_iv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L8_iva(span);
			return null;
		}
		
		private static Variant? tryParse_L8_iva(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L8_ivan(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ivan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'c')
				return tryParse_L8_ivanc(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ivanc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'h')
				return tryParse_L8_ivanch(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ivanch(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'o')
				return tryParse_L8_ivancho(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ivancho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'v')
				return IvanchovCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_j(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'y')
				return tryParse_L8_jy(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L8_jyu(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jyu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return tryParse_L8_jyut(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jyut(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'p')
				return tryParse_L8_jyutp(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jyutp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L8_jyutpi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jyutpi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return tryParse_L8_jyutpin(span);
			return null;
		}
		
		private static Variant? tryParse_L8_jyutpin(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'g')
				return JyutpingCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_k(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'o')
				return tryParse_L8_ko(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ko(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L8_koc(span);
			return null;
		}
		
		private static Variant? tryParse_L8_koc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return tryParse_L8_koci(span);
			return null;
		}
		
		private static Variant? tryParse_L8_koci(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'e')
				return tryParse_L8_kocie(span);
			return null;
		}
		
		private static Variant? tryParse_L8_kocie(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'w')
				return tryParse_L8_kociew(span);
			return null;
		}
		
		private static Variant? tryParse_L8_kociew(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'i')
				return tryParse_L8_kociewi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_kociewi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'e')
				return KociewieCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L8_le(span);
				case 'u': return tryParse_L8_lu(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_le(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L8_len(span);
			return null;
		}
		
		private static Variant? tryParse_L8_len(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return tryParse_L8_leng(span);
			return null;
		}
		
		private static Variant? tryParse_L8_leng(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_lenga(span);
			return null;
		}
		
		private static Variant? tryParse_L8_lenga(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'd')
				return tryParse_L8_lengad(span);
			return null;
		}
		
		private static Variant? tryParse_L8_lengad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'o')
				return tryParse_L8_lengado(span);
			return null;
		}
		
		private static Variant? tryParse_L8_lengado(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'c')
				return LengadocCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_lu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L8_lun(span);
			return null;
		}
		
		private static Variant? tryParse_L8_lun(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L8_luna(span);
			return null;
		}
		
		private static Variant? tryParse_L8_luna(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '1')
				return tryParse_L8_luna1(span);
			return null;
		}
		
		private static Variant? tryParse_L8_luna1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '9')
				return tryParse_L8_luna19(span);
			return null;
		}
		
		private static Variant? tryParse_L8_luna19(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '1')
				return tryParse_L8_luna191(span);
			return null;
		}
		
		private static Variant? tryParse_L8_luna191(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == '8')
				return Luna1918Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_n(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'e')
				return tryParse_L8_ne(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ne(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'w')
				return tryParse_L8_new(span);
			return null;
		}
		
		private static Variant? tryParse_L8_new(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'f')
				return tryParse_L8_newf(span);
			return null;
		}
		
		private static Variant? tryParse_L8_newf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'o')
				return tryParse_L8_newfo(span);
			return null;
		}
		
		private static Variant? tryParse_L8_newfo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'u')
				return tryParse_L8_newfou(span);
			return null;
		}
		
		private static Variant? tryParse_L8_newfou(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return tryParse_L8_newfoun(span);
			return null;
		}
		
		private static Variant? tryParse_L8_newfoun(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'd')
				return NewfoundCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_o(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'x')
				return tryParse_L8_ox(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ox(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L8_oxe(span);
			return null;
		}
		
		private static Variant? tryParse_L8_oxe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L8_oxen(span);
			return null;
		}
		
		private static Variant? tryParse_L8_oxen(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'd')
				return tryParse_L8_oxend(span);
			return null;
		}
		
		private static Variant? tryParse_L8_oxend(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L8_oxendi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_oxendi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'c')
				return tryParse_L8_oxendic(span);
			return null;
		}
		
		private static Variant? tryParse_L8_oxendic(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 't')
				return OxendictCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_p(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'e')
				return tryParse_L8_pe(span);
			return null;
		}
		
		private static Variant? tryParse_L8_pe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L8_pet(span);
			return null;
		}
		
		private static Variant? tryParse_L8_pet(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return tryParse_L8_petr(span);
			return null;
		}
		
		private static Variant? tryParse_L8_petr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == '1')
				return tryParse_L8_petr1(span);
			return null;
		}
		
		private static Variant? tryParse_L8_petr1(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == '7')
				return tryParse_L8_petr17(span);
			return null;
		}
		
		private static Variant? tryParse_L8_petr17(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == '0')
				return tryParse_L8_petr170(span);
			return null;
		}
		
		private static Variant? tryParse_L8_petr170(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == '8')
				return Petr1708Cache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'c': return tryParse_L8_sc(span);
				case 'p': return tryParse_L8_sp(span);
				case 'u': return tryParse_L8_su(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_sc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L8_sco(span);
			return null;
		}
		
		private static Variant? tryParse_L8_sco(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return tryParse_L8_scot(span);
			return null;
		}
		
		private static Variant? tryParse_L8_scot(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'l')
				return tryParse_L8_scotl(span);
			return null;
		}
		
		private static Variant? tryParse_L8_scotl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return tryParse_L8_scotla(span);
			return null;
		}
		
		private static Variant? tryParse_L8_scotla(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return tryParse_L8_scotlan(span);
			return null;
		}
		
		private static Variant? tryParse_L8_scotlan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'd')
				return ScotlandCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_sp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L8_spa(span);
			return null;
		}
		
		private static Variant? tryParse_L8_spa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return tryParse_L8_span(span);
			return null;
		}
		
		private static Variant? tryParse_L8_span(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'g')
				return tryParse_L8_spang(span);
			return null;
		}
		
		private static Variant? tryParse_L8_spang(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'l')
				return tryParse_L8_spangl(span);
			return null;
		}
		
		private static Variant? tryParse_L8_spangl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'i')
				return tryParse_L8_spangli(span);
			return null;
		}
		
		private static Variant? tryParse_L8_spangli(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 's')
				return SpanglisCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_su(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L8_sur(span);
			return null;
		}
		
		private static Variant? tryParse_L8_sur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return tryParse_L8_surm(span);
			return null;
		}
		
		private static Variant? tryParse_L8_surm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'i')
				return tryParse_L8_surmi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_surmi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'r')
				return tryParse_L8_surmir(span);
			return null;
		}
		
		private static Variant? tryParse_L8_surmir(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'a')
				return tryParse_L8_surmira(span);
			return null;
		}
		
		private static Variant? tryParse_L8_surmira(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'n')
				return SurmiranCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'o': return tryParse_L8_to(span);
				case 'u': return tryParse_L8_tu(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_to(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L8_ton(span);
			return null;
		}
		
		private static Variant? tryParse_L8_ton(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return tryParse_L8_tong(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tong(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'y')
				return tryParse_L8_tongy(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tongy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'o')
				return tryParse_L8_tongyo(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tongyo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'n')
				return tryParse_L8_tongyon(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tongyon(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'g')
				return TongyongCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_tu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L8_tun(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tun(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return tryParse_L8_tunu(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tunu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'm')
				return tryParse_L8_tunum(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tunum(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L8_tunumi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tunumi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'i')
				return tryParse_L8_tunumii(span);
			return null;
		}
		
		private static Variant? tryParse_L8_tunumii(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 't')
				return TunumiitCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L8_va(span);
				case 'e': return tryParse_L8_ve(span);
				case 'i': return tryParse_L8_vi(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_va(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L8_val(span);
			return null;
		}
		
		private static Variant? tryParse_L8_val(StringSpan span)
		{
			switch(span[3])
			{
				case 'e': return tryParse_L8_vale(span);
				case 'l': return tryParse_L8_vall(span);
				default: return null;
			}
		}
		
		private static Variant? tryParse_L8_vale(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'n')
				return tryParse_L8_valen(span);
			return null;
		}
		
		private static Variant? tryParse_L8_valen(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'c')
				return tryParse_L8_valenc(span);
			return null;
		}
		
		private static Variant? tryParse_L8_valenc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'i')
				return tryParse_L8_valenci(span);
			return null;
		}
		
		private static Variant? tryParse_L8_valenci(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'a')
				return ValenciaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_vall(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'a')
				return tryParse_L8_valla(span);
			return null;
		}
		
		private static Variant? tryParse_L8_valla(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'd')
				return tryParse_L8_vallad(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vallad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'e')
				return tryParse_L8_vallade(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vallade(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'r')
				return ValladerCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_ve(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L8_vec(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vec(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return tryParse_L8_vecd(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vecd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return tryParse_L8_vecdr(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vecdr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'u')
				return tryParse_L8_vecdru(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vecdru(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'k')
				return tryParse_L8_vecdruk(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vecdruk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'a')
				return VecdrukaCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_vi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'v')
				return tryParse_L8_viv(span);
			return null;
		}
		
		private static Variant? tryParse_L8_viv(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return tryParse_L8_viva(span);
			return null;
		}
		
		private static Variant? tryParse_L8_viva(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'r')
				return tryParse_L8_vivar(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vivar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'a')
				return tryParse_L8_vivara(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vivara(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'u')
				return tryParse_L8_vivarau(span);
			return null;
		}
		
		private static Variant? tryParse_L8_vivarau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'p')
				return VivaraupCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_w(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'a')
				return tryParse_L8_wa(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return tryParse_L8_wad(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return tryParse_L8_wade(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wade(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 'g')
				return tryParse_L8_wadeg(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wadeg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'i')
				return tryParse_L8_wadegi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wadegi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'l')
				return tryParse_L8_wadegil(span);
			return null;
		}
		
		private static Variant? tryParse_L8_wadegil(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'e')
				return WadegileCache.Instance;
			return null;
		}
		
		private static Variant? tryParse_L8_x(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 's')
				return tryParse_L8_xs(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L8_xsi(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xsi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return tryParse_L8_xsis(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xsis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[4]) == 't')
				return tryParse_L8_xsist(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xsist(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[5]) == 'e')
				return tryParse_L8_xsiste(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xsiste(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[6]) == 'm')
				return tryParse_L8_xsistem(span);
			return null;
		}
		
		private static Variant? tryParse_L8_xsistem(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[7]) == 'o')
				return XsistemoCache.Instance;
			return null;
		}
	}
}
