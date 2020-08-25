using System;
using System.Globalization;

namespace NLanguageTag
{
	public partial class Script
	{

		internal static Script? TryParse(StringSpan span)
		{
			if(span.Length == 4)
				return tryParse_L4(span);
			return null;
		}
		
		private static Script? tryParse_L4(StringSpan span)
		{
			if ("qaaa" <= span && span <= "qabx") return forPrivateUse(span.AsText());
		
			switch(span[0])
			{
				case 'a': return tryParse_L4_a(span);
				case 'b': return tryParse_L4_b(span);
				case 'c': return tryParse_L4_c(span);
				case 'd': return tryParse_L4_d(span);
				case 'e': return tryParse_L4_e(span);
				case 'g': return tryParse_L4_g(span);
				case 'h': return tryParse_L4_h(span);
				case 'i': return tryParse_L4_i(span);
				case 'j': return tryParse_L4_j(span);
				case 'k': return tryParse_L4_k(span);
				case 'l': return tryParse_L4_l(span);
				case 'm': return tryParse_L4_m(span);
				case 'n': return tryParse_L4_n(span);
				case 'o': return tryParse_L4_o(span);
				case 'p': return tryParse_L4_p(span);
				case 'r': return tryParse_L4_r(span);
				case 's': return tryParse_L4_s(span);
				case 't': return tryParse_L4_t(span);
				case 'u': return tryParse_L4_u(span);
				case 'v': return tryParse_L4_v(span);
				case 'w': return tryParse_L4_w(span);
				case 'x': return tryParse_L4_x(span);
				case 'y': return tryParse_L4_y(span);
				case 'z': return tryParse_L4_z(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_a(StringSpan span)
		{
			switch(span[1])
			{
				case 'd': return tryParse_L4_ad(span);
				case 'f': return tryParse_L4_af(span);
				case 'g': return tryParse_L4_ag(span);
				case 'h': return tryParse_L4_ah(span);
				case 'r': return tryParse_L4_ar(span);
				case 'v': return tryParse_L4_av(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ad(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L4_adl(span);
			return null;
		}
		
		private static Script? tryParse_L4_adl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Adlm;
			return null;
		}
		
		private static Script? tryParse_L4_af(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_afa(span);
			return null;
		}
		
		private static Script? tryParse_L4_afa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return Afak;
			return null;
		}
		
		private static Script? tryParse_L4_ag(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L4_agh(span);
			return null;
		}
		
		private static Script? tryParse_L4_agh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Aghb;
			return null;
		}
		
		private static Script? tryParse_L4_ah(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L4_aho(span);
			return null;
		}
		
		private static Script? tryParse_L4_aho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Ahom;
			return null;
		}
		
		private static Script? tryParse_L4_ar(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_ara(span);
				case 'm': return tryParse_L4_arm(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ara(StringSpan span)
		{
			switch(span[3])
			{
				case 'b': return Arab;
				case 'n': return Aran;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_arm(StringSpan span)
		{
			switch(span[3])
			{
				case 'i': return Armi;
				case 'n': return Armn;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_av(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L4_avs(span);
			return null;
		}
		
		private static Script? tryParse_L4_avs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Avst;
			return null;
		}
		
		private static Script? tryParse_L4_b(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ba(span);
				case 'e': return tryParse_L4_be(span);
				case 'h': return tryParse_L4_bh(span);
				case 'l': return tryParse_L4_bl(span);
				case 'o': return tryParse_L4_bo(span);
				case 'r': return tryParse_L4_br(span);
				case 'u': return tryParse_L4_bu(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ba(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L4_bal(span);
				case 'm': return tryParse_L4_bam(span);
				case 's': return tryParse_L4_bas(span);
				case 't': return tryParse_L4_bat(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_bal(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Bali;
			return null;
		}
		
		private static Script? tryParse_L4_bam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return Bamu;
			return null;
		}
		
		private static Script? tryParse_L4_bas(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Bass;
			return null;
		}
		
		private static Script? tryParse_L4_bat(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return Batk;
			return null;
		}
		
		private static Script? tryParse_L4_be(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_ben(span);
			return null;
		}
		
		private static Script? tryParse_L4_ben(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Beng;
			return null;
		}
		
		private static Script? tryParse_L4_bh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return tryParse_L4_bhk(span);
			return null;
		}
		
		private static Script? tryParse_L4_bhk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Bhks;
			return null;
		}
		
		private static Script? tryParse_L4_bl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L4_bli(span);
			return null;
		}
		
		private static Script? tryParse_L4_bli(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Blis;
			return null;
		}
		
		private static Script? tryParse_L4_bo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L4_bop(span);
			return null;
		}
		
		private static Script? tryParse_L4_bop(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Bopo;
			return null;
		}
		
		private static Script? tryParse_L4_br(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_bra(span);
			return null;
		}
		
		private static Script? tryParse_L4_bra(StringSpan span)
		{
			switch(span[3])
			{
				case 'h': return Brah;
				case 'i': return Brai;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_bu(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return tryParse_L4_bug(span);
				case 'h': return tryParse_L4_buh(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_bug(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Bugi;
			return null;
		}
		
		private static Script? tryParse_L4_buh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Buhd;
			return null;
		}
		
		private static Script? tryParse_L4_c(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ca(span);
				case 'h': return tryParse_L4_ch(span);
				case 'i': return tryParse_L4_ci(span);
				case 'o': return tryParse_L4_co(span);
				case 'p': return tryParse_L4_cp(span);
				case 'y': return tryParse_L4_cy(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ca(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return tryParse_L4_cak(span);
				case 'n': return tryParse_L4_can(span);
				case 'r': return tryParse_L4_car(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_cak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Cakm;
			return null;
		}
		
		private static Script? tryParse_L4_can(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Cans;
			return null;
		}
		
		private static Script? tryParse_L4_car(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Cari;
			return null;
		}
		
		private static Script? tryParse_L4_ch(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_cha(span);
				case 'e': return tryParse_L4_che(span);
				case 'r': return tryParse_L4_chr(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_cha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Cham;
			return null;
		}
		
		private static Script? tryParse_L4_che(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Cher;
			return null;
		}
		
		private static Script? tryParse_L4_chr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Chrs;
			return null;
		}
		
		private static Script? tryParse_L4_ci(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_cir(span);
			return null;
		}
		
		private static Script? tryParse_L4_cir(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Cirt;
			return null;
		}
		
		private static Script? tryParse_L4_co(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L4_cop(span);
			return null;
		}
		
		private static Script? tryParse_L4_cop(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Copt;
			return null;
		}
		
		private static Script? tryParse_L4_cp(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return tryParse_L4_cpm(span);
				case 'r': return tryParse_L4_cpr(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_cpm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return Cpmn;
			return null;
		}
		
		private static Script? tryParse_L4_cpr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Cprt;
			return null;
		}
		
		private static Script? tryParse_L4_cy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_cyr(span);
			return null;
		}
		
		private static Script? tryParse_L4_cyr(StringSpan span)
		{
			switch(span[3])
			{
				case 'l': return Cyrl;
				case 's': return Cyrs;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_d(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L4_de(span);
				case 'i': return tryParse_L4_di(span);
				case 'o': return tryParse_L4_do(span);
				case 's': return tryParse_L4_ds(span);
				case 'u': return tryParse_L4_du(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_de(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'v')
				return tryParse_L4_dev(span);
			return null;
		}
		
		private static Script? tryParse_L4_dev(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Deva;
			return null;
		}
		
		private static Script? tryParse_L4_di(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_dia(span);
			return null;
		}
		
		private static Script? tryParse_L4_dia(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return Diak;
			return null;
		}
		
		private static Script? tryParse_L4_do(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'g')
				return tryParse_L4_dog(span);
			return null;
		}
		
		private static Script? tryParse_L4_dog(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Dogr;
			return null;
		}
		
		private static Script? tryParse_L4_ds(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_dsr(span);
			return null;
		}
		
		private static Script? tryParse_L4_dsr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Dsrt;
			return null;
		}
		
		private static Script? tryParse_L4_du(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'p')
				return tryParse_L4_dup(span);
			return null;
		}
		
		private static Script? tryParse_L4_dup(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return Dupl;
			return null;
		}
		
		private static Script? tryParse_L4_e(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParse_L4_eg(span);
				case 'l': return tryParse_L4_el(span);
				case 't': return tryParse_L4_et(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_eg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return tryParse_L4_egy(span);
			return null;
		}
		
		private static Script? tryParse_L4_egy(StringSpan span)
		{
			switch(span[3])
			{
				case 'd': return Egyd;
				case 'h': return Egyh;
				case 'p': return Egyp;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_el(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return tryParse_L4_elb(span);
				case 'y': return tryParse_L4_ely(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_elb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Elba;
			return null;
		}
		
		private static Script? tryParse_L4_ely(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Elym;
			return null;
		}
		
		private static Script? tryParse_L4_et(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L4_eth(span);
			return null;
		}
		
		private static Script? tryParse_L4_eth(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Ethi;
			return null;
		}
		
		private static Script? tryParse_L4_g(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L4_ge(span);
				case 'l': return tryParse_L4_gl(span);
				case 'o': return tryParse_L4_go(span);
				case 'r': return tryParse_L4_gr(span);
				case 'u': return tryParse_L4_gu(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ge(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L4_geo(span);
			return null;
		}
		
		private static Script? tryParse_L4_geo(StringSpan span)
		{
			switch(span[3])
			{
				case 'k': return Geok;
				case 'r': return Geor;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_gl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_gla(span);
			return null;
		}
		
		private static Script? tryParse_L4_gla(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Glag;
			return null;
		}
		
		private static Script? tryParse_L4_go(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return tryParse_L4_gon(span);
				case 't': return tryParse_L4_got(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_gon(StringSpan span)
		{
			switch(span[3])
			{
				case 'g': return Gong;
				case 'm': return Gonm;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_got(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return Goth;
			return null;
		}
		
		private static Script? tryParse_L4_gr(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_gra(span);
				case 'e': return tryParse_L4_gre(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_gra(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return Gran;
			return null;
		}
		
		private static Script? tryParse_L4_gre(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return Grek;
			return null;
		}
		
		private static Script? tryParse_L4_gu(StringSpan span)
		{
			switch(span[2])
			{
				case 'j': return tryParse_L4_guj(span);
				case 'r': return tryParse_L4_gur(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_guj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Gujr;
			return null;
		}
		
		private static Script? tryParse_L4_gur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return Guru;
			return null;
		}
		
		private static Script? tryParse_L4_h(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ha(span);
				case 'e': return tryParse_L4_he(span);
				case 'i': return tryParse_L4_hi(span);
				case 'l': return tryParse_L4_hl(span);
				case 'm': return tryParse_L4_hm(span);
				case 'r': return tryParse_L4_hr(span);
				case 'u': return tryParse_L4_hu(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ha(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return tryParse_L4_han(span);
				case 't': return tryParse_L4_hat(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_han(StringSpan span)
		{
			switch(span[3])
			{
				case 'b': return Hanb;
				case 'g': return Hang;
				case 'i': return Hani;
				case 'o': return Hano;
				case 's': return Hans;
				case 't': return Hant;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_hat(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Hatr;
			return null;
		}
		
		private static Script? tryParse_L4_he(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'b')
				return tryParse_L4_heb(span);
			return null;
		}
		
		private static Script? tryParse_L4_heb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Hebr;
			return null;
		}
		
		private static Script? tryParse_L4_hi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_hir(span);
			return null;
		}
		
		private static Script? tryParse_L4_hir(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Hira;
			return null;
		}
		
		private static Script? tryParse_L4_hl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L4_hlu(span);
			return null;
		}
		
		private static Script? tryParse_L4_hlu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'w')
				return Hluw;
			return null;
		}
		
		private static Script? tryParse_L4_hm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_hmn(span);
			return null;
		}
		
		private static Script? tryParse_L4_hmn(StringSpan span)
		{
			switch(span[3])
			{
				case 'g': return Hmng;
				case 'p': return Hmnp;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_hr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'k')
				return tryParse_L4_hrk(span);
			return null;
		}
		
		private static Script? tryParse_L4_hrk(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Hrkt;
			return null;
		}
		
		private static Script? tryParse_L4_hu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_hun(span);
			return null;
		}
		
		private static Script? tryParse_L4_hun(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Hung;
			return null;
		}
		
		private static Script? tryParse_L4_i(StringSpan span)
		{
			switch(span[1])
			{
				case 'n': return tryParse_L4_in(span);
				case 't': return tryParse_L4_it(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_in(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return tryParse_L4_ind(span);
			return null;
		}
		
		private static Script? tryParse_L4_ind(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 's')
				return Inds;
			return null;
		}
		
		private static Script? tryParse_L4_it(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_ita(span);
			return null;
		}
		
		private static Script? tryParse_L4_ita(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return Ital;
			return null;
		}
		
		private static Script? tryParse_L4_j(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ja(span);
				case 'p': return tryParse_L4_jp(span);
				case 'u': return tryParse_L4_ju(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ja(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return tryParse_L4_jam(span);
				case 'v': return tryParse_L4_jav(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_jam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Jamo;
			return null;
		}
		
		private static Script? tryParse_L4_jav(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Java;
			return null;
		}
		
		private static Script? tryParse_L4_jp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_jpa(span);
			return null;
		}
		
		private static Script? tryParse_L4_jpa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return Jpan;
			return null;
		}
		
		private static Script? tryParse_L4_ju(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_jur(span);
			return null;
		}
		
		private static Script? tryParse_L4_jur(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return Jurc;
			return null;
		}
		
		private static Script? tryParse_L4_k(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ka(span);
				case 'h': return tryParse_L4_kh(span);
				case 'i': return tryParse_L4_ki(span);
				case 'n': return tryParse_L4_kn(span);
				case 'o': return tryParse_L4_ko(span);
				case 'p': return tryParse_L4_kp(span);
				case 't': return tryParse_L4_kt(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ka(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L4_kal(span);
				case 'n': return tryParse_L4_kan(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_kal(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Kali;
			return null;
		}
		
		private static Script? tryParse_L4_kan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Kana;
			return null;
		}
		
		private static Script? tryParse_L4_kh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_kha(span);
				case 'm': return tryParse_L4_khm(span);
				case 'o': return tryParse_L4_kho(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_kha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Khar;
			return null;
		}
		
		private static Script? tryParse_L4_khm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Khmr;
			return null;
		}
		
		private static Script? tryParse_L4_kho(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'j')
				return Khoj;
			return null;
		}
		
		private static Script? tryParse_L4_ki(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L4_kit(span);
			return null;
		}
		
		private static Script? tryParse_L4_kit(StringSpan span)
		{
			switch(span[3])
			{
				case 'l': return Kitl;
				case 's': return Kits;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_kn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'd')
				return tryParse_L4_knd(span);
			return null;
		}
		
		private static Script? tryParse_L4_knd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Knda;
			return null;
		}
		
		private static Script? tryParse_L4_ko(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_kor(span);
			return null;
		}
		
		private static Script? tryParse_L4_kor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return Kore;
			return null;
		}
		
		private static Script? tryParse_L4_kp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L4_kpe(span);
			return null;
		}
		
		private static Script? tryParse_L4_kpe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return Kpel;
			return null;
		}
		
		private static Script? tryParse_L4_kt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L4_kth(span);
			return null;
		}
		
		private static Script? tryParse_L4_kth(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Kthi;
			return null;
		}
		
		private static Script? tryParse_L4_l(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_la(span);
				case 'e': return tryParse_L4_le(span);
				case 'i': return tryParse_L4_li(span);
				case 'o': return tryParse_L4_lo(span);
				case 'y': return tryParse_L4_ly(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_la(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return tryParse_L4_lan(span);
				case 'o': return tryParse_L4_lao(span);
				case 't': return tryParse_L4_lat(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_lan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Lana;
			return null;
		}
		
		private static Script? tryParse_L4_lao(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Laoo;
			return null;
		}
		
		private static Script? tryParse_L4_lat(StringSpan span)
		{
			switch(span[3])
			{
				case 'f': return Latf;
				case 'g': return Latg;
				case 'n': return Latn;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_le(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return tryParse_L4_lek(span);
				case 'p': return tryParse_L4_lep(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_lek(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return Leke;
			return null;
		}
		
		private static Script? tryParse_L4_lep(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return Lepc;
			return null;
		}
		
		private static Script? tryParse_L4_li(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return tryParse_L4_lim(span);
				case 'n': return tryParse_L4_lin(span);
				case 's': return tryParse_L4_lis(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_lim(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Limb;
			return null;
		}
		
		private static Script? tryParse_L4_lin(StringSpan span)
		{
			switch(span[3])
			{
				case 'a': return Lina;
				case 'b': return Linb;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_lis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return Lisu;
			return null;
		}
		
		private static Script? tryParse_L4_lo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L4_lom(span);
			return null;
		}
		
		private static Script? tryParse_L4_lom(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Loma;
			return null;
		}
		
		private static Script? tryParse_L4_ly(StringSpan span)
		{
			switch(span[2])
			{
				case 'c': return tryParse_L4_lyc(span);
				case 'd': return tryParse_L4_lyd(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_lyc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Lyci;
			return null;
		}
		
		private static Script? tryParse_L4_lyd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Lydi;
			return null;
		}
		
		private static Script? tryParse_L4_m(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ma(span);
				case 'e': return tryParse_L4_me(span);
				case 'l': return tryParse_L4_ml(span);
				case 'o': return tryParse_L4_mo(span);
				case 'r': return tryParse_L4_mr(span);
				case 't': return tryParse_L4_mt(span);
				case 'u': return tryParse_L4_mu(span);
				case 'y': return tryParse_L4_my(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ma(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return tryParse_L4_mah(span);
				case 'k': return tryParse_L4_mak(span);
				case 'n': return tryParse_L4_man(span);
				case 'r': return tryParse_L4_mar(span);
				case 'y': return tryParse_L4_may(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_mah(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'j')
				return Mahj;
			return null;
		}
		
		private static Script? tryParse_L4_mak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Maka;
			return null;
		}
		
		private static Script? tryParse_L4_man(StringSpan span)
		{
			switch(span[3])
			{
				case 'd': return Mand;
				case 'i': return Mani;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_mar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return Marc;
			return null;
		}
		
		private static Script? tryParse_L4_may(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Maya;
			return null;
		}
		
		private static Script? tryParse_L4_me(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return tryParse_L4_med(span);
				case 'n': return tryParse_L4_men(span);
				case 'r': return tryParse_L4_mer(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_med(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'f')
				return Medf;
			return null;
		}
		
		private static Script? tryParse_L4_men(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Mend;
			return null;
		}
		
		private static Script? tryParse_L4_mer(StringSpan span)
		{
			switch(span[3])
			{
				case 'c': return Merc;
				case 'o': return Mero;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ml(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return tryParse_L4_mly(span);
			return null;
		}
		
		private static Script? tryParse_L4_mly(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Mlym;
			return null;
		}
		
		private static Script? tryParse_L4_mo(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return tryParse_L4_mod(span);
				case 'n': return tryParse_L4_mon(span);
				case 'o': return tryParse_L4_moo(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_mod(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Modi;
			return null;
		}
		
		private static Script? tryParse_L4_mon(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Mong;
			return null;
		}
		
		private static Script? tryParse_L4_moo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'n')
				return Moon;
			return null;
		}
		
		private static Script? tryParse_L4_mr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'o')
				return tryParse_L4_mro(span);
			return null;
		}
		
		private static Script? tryParse_L4_mro(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Mroo;
			return null;
		}
		
		private static Script? tryParse_L4_mt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L4_mte(span);
			return null;
		}
		
		private static Script? tryParse_L4_mte(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Mtei;
			return null;
		}
		
		private static Script? tryParse_L4_mu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L4_mul(span);
			return null;
		}
		
		private static Script? tryParse_L4_mul(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Mult;
			return null;
		}
		
		private static Script? tryParse_L4_my(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'm')
				return tryParse_L4_mym(span);
			return null;
		}
		
		private static Script? tryParse_L4_mym(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Mymr;
			return null;
		}
		
		private static Script? tryParse_L4_n(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_na(span);
				case 'b': return tryParse_L4_nb(span);
				case 'e': return tryParse_L4_ne(span);
				case 'k': return tryParse_L4_nk(span);
				case 's': return tryParse_L4_ns(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_na(StringSpan span)
		{
			switch(span[2])
			{
				case 'n': return tryParse_L4_nan(span);
				case 'r': return tryParse_L4_nar(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_nan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Nand;
			return null;
		}
		
		private static Script? tryParse_L4_nar(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Narb;
			return null;
		}
		
		private static Script? tryParse_L4_nb(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_nba(span);
			return null;
		}
		
		private static Script? tryParse_L4_nba(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Nbat;
			return null;
		}
		
		private static Script? tryParse_L4_ne(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'w')
				return tryParse_L4_new(span);
			return null;
		}
		
		private static Script? tryParse_L4_new(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Newa;
			return null;
		}
		
		private static Script? tryParse_L4_nk(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return tryParse_L4_nkd(span);
				case 'g': return tryParse_L4_nkg(span);
				case 'o': return tryParse_L4_nko(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_nkd(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Nkdb;
			return null;
		}
		
		private static Script? tryParse_L4_nkg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Nkgb;
			return null;
		}
		
		private static Script? tryParse_L4_nko(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Nkoo;
			return null;
		}
		
		private static Script? tryParse_L4_ns(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L4_nsh(span);
			return null;
		}
		
		private static Script? tryParse_L4_nsh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return Nshu;
			return null;
		}
		
		private static Script? tryParse_L4_o(StringSpan span)
		{
			switch(span[1])
			{
				case 'g': return tryParse_L4_og(span);
				case 'l': return tryParse_L4_ol(span);
				case 'r': return tryParse_L4_or(span);
				case 's': return tryParse_L4_os(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_og(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_oga(span);
			return null;
		}
		
		private static Script? tryParse_L4_oga(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Ogam;
			return null;
		}
		
		private static Script? tryParse_L4_ol(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'c')
				return tryParse_L4_olc(span);
			return null;
		}
		
		private static Script? tryParse_L4_olc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'k')
				return Olck;
			return null;
		}
		
		private static Script? tryParse_L4_or(StringSpan span)
		{
			switch(span[2])
			{
				case 'k': return tryParse_L4_ork(span);
				case 'y': return tryParse_L4_ory(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ork(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return Orkh;
			return null;
		}
		
		private static Script? tryParse_L4_ory(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Orya;
			return null;
		}
		
		private static Script? tryParse_L4_os(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return tryParse_L4_osg(span);
				case 'm': return tryParse_L4_osm(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_osg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return Osge;
			return null;
		}
		
		private static Script? tryParse_L4_osm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Osma;
			return null;
		}
		
		private static Script? tryParse_L4_p(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_pa(span);
				case 'e': return tryParse_L4_pe(span);
				case 'h': return tryParse_L4_ph(span);
				case 'i': return tryParse_L4_pi(span);
				case 'l': return tryParse_L4_pl(span);
				case 'r': return tryParse_L4_pr(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_pa(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L4_pal(span);
				case 'u': return tryParse_L4_pau(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_pal(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Palm;
			return null;
		}
		
		private static Script? tryParse_L4_pau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'c')
				return Pauc;
			return null;
		}
		
		private static Script? tryParse_L4_pe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_per(span);
			return null;
		}
		
		private static Script? tryParse_L4_per(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'm')
				return Perm;
			return null;
		}
		
		private static Script? tryParse_L4_ph(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_pha(span);
				case 'l': return tryParse_L4_phl(span);
				case 'n': return tryParse_L4_phn(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_pha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Phag;
			return null;
		}
		
		private static Script? tryParse_L4_phl(StringSpan span)
		{
			switch(span[3])
			{
				case 'i': return Phli;
				case 'p': return Phlp;
				case 'v': return Phlv;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_phn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'x')
				return Phnx;
			return null;
		}
		
		private static Script? tryParse_L4_pi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'q')
				return tryParse_L4_piq(span);
			return null;
		}
		
		private static Script? tryParse_L4_piq(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Piqd;
			return null;
		}
		
		private static Script? tryParse_L4_pl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_plr(span);
			return null;
		}
		
		private static Script? tryParse_L4_plr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Plrd;
			return null;
		}
		
		private static Script? tryParse_L4_pr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L4_prt(span);
			return null;
		}
		
		private static Script? tryParse_L4_prt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Prti;
			return null;
		}
		
		private static Script? tryParse_L4_r(StringSpan span)
		{
			switch(span[1])
			{
				case 'j': return tryParse_L4_rj(span);
				case 'o': return tryParse_L4_ro(span);
				case 'u': return tryParse_L4_ru(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_rj(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_rjn(span);
			return null;
		}
		
		private static Script? tryParse_L4_rjn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Rjng;
			return null;
		}
		
		private static Script? tryParse_L4_ro(StringSpan span)
		{
			switch(span[2])
			{
				case 'h': return tryParse_L4_roh(span);
				case 'r': return tryParse_L4_ror(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_roh(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Rohg;
			return null;
		}
		
		private static Script? tryParse_L4_ror(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Roro;
			return null;
		}
		
		private static Script? tryParse_L4_ru(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_run(span);
			return null;
		}
		
		private static Script? tryParse_L4_run(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Runr;
			return null;
		}
		
		private static Script? tryParse_L4_s(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_sa(span);
				case 'g': return tryParse_L4_sg(span);
				case 'h': return tryParse_L4_sh(span);
				case 'i': return tryParse_L4_si(span);
				case 'o': return tryParse_L4_so(span);
				case 'u': return tryParse_L4_su(span);
				case 'y': return tryParse_L4_sy(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sa(StringSpan span)
		{
			switch(span[2])
			{
				case 'm': return tryParse_L4_sam(span);
				case 'r': return tryParse_L4_sar(span);
				case 'u': return tryParse_L4_sau(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Samr;
			return null;
		}
		
		private static Script? tryParse_L4_sar(StringSpan span)
		{
			switch(span[3])
			{
				case 'a': return Sara;
				case 'b': return Sarb;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sau(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Saur;
			return null;
		}
		
		private static Script? tryParse_L4_sg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_sgn(span);
			return null;
		}
		
		private static Script? tryParse_L4_sgn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'w')
				return Sgnw;
			return null;
		}
		
		private static Script? tryParse_L4_sh(StringSpan span)
		{
			switch(span[2])
			{
				case 'a': return tryParse_L4_sha(span);
				case 'r': return tryParse_L4_shr(span);
				case 'u': return tryParse_L4_shu(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sha(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'w')
				return Shaw;
			return null;
		}
		
		private static Script? tryParse_L4_shr(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Shrd;
			return null;
		}
		
		private static Script? tryParse_L4_shu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Shui;
			return null;
		}
		
		private static Script? tryParse_L4_si(StringSpan span)
		{
			switch(span[2])
			{
				case 'd': return tryParse_L4_sid(span);
				case 'n': return tryParse_L4_sin(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sid(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Sidd;
			return null;
		}
		
		private static Script? tryParse_L4_sin(StringSpan span)
		{
			switch(span[3])
			{
				case 'd': return Sind;
				case 'h': return Sinh;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_so(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return tryParse_L4_sog(span);
				case 'r': return tryParse_L4_sor(span);
				case 'y': return tryParse_L4_soy(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sog(StringSpan span)
		{
			switch(span[3])
			{
				case 'd': return Sogd;
				case 'o': return Sogo;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_sor(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Sora;
			return null;
		}
		
		private static Script? tryParse_L4_soy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Soyo;
			return null;
		}
		
		private static Script? tryParse_L4_su(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_sun(span);
			return null;
		}
		
		private static Script? tryParse_L4_sun(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'd')
				return Sund;
			return null;
		}
		
		private static Script? tryParse_L4_sy(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L4_syl(span);
				case 'r': return tryParse_L4_syr(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_syl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Sylo;
			return null;
		}
		
		private static Script? tryParse_L4_syr(StringSpan span)
		{
			switch(span[3])
			{
				case 'c': return Syrc;
				case 'e': return Syre;
				case 'j': return Syrj;
				case 'n': return Syrn;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_t(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_ta(span);
				case 'e': return tryParse_L4_te(span);
				case 'f': return tryParse_L4_tf(span);
				case 'g': return tryParse_L4_tg(span);
				case 'h': return tryParse_L4_th(span);
				case 'i': return tryParse_L4_ti(span);
				case 'o': return tryParse_L4_to(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ta(StringSpan span)
		{
			switch(span[2])
			{
				case 'g': return tryParse_L4_tag(span);
				case 'k': return tryParse_L4_tak(span);
				case 'l': return tryParse_L4_tal(span);
				case 'm': return tryParse_L4_tam(span);
				case 'n': return tryParse_L4_tan(span);
				case 'v': return tryParse_L4_tav(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_tag(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Tagb;
			return null;
		}
		
		private static Script? tryParse_L4_tak(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Takr;
			return null;
		}
		
		private static Script? tryParse_L4_tal(StringSpan span)
		{
			switch(span[3])
			{
				case 'e': return Tale;
				case 'u': return Talu;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_tam(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'l')
				return Taml;
			return null;
		}
		
		private static Script? tryParse_L4_tan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Tang;
			return null;
		}
		
		private static Script? tryParse_L4_tav(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Tavt;
			return null;
		}
		
		private static Script? tryParse_L4_te(StringSpan span)
		{
			switch(span[2])
			{
				case 'l': return tryParse_L4_tel(span);
				case 'n': return tryParse_L4_ten(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_tel(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'u')
				return Telu;
			return null;
		}
		
		private static Script? tryParse_L4_ten(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Teng;
			return null;
		}
		
		private static Script? tryParse_L4_tf(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_tfn(span);
			return null;
		}
		
		private static Script? tryParse_L4_tfn(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Tfng;
			return null;
		}
		
		private static Script? tryParse_L4_tg(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L4_tgl(span);
			return null;
		}
		
		private static Script? tryParse_L4_tgl(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'g')
				return Tglg;
			return null;
		}
		
		private static Script? tryParse_L4_th(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_tha(span);
			return null;
		}
		
		private static Script? tryParse_L4_tha(StringSpan span)
		{
			switch(span[3])
			{
				case 'a': return Thaa;
				case 'i': return Thai;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ti(StringSpan span)
		{
			switch(span[2])
			{
				case 'b': return tryParse_L4_tib(span);
				case 'r': return tryParse_L4_tir(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_tib(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 't')
				return Tibt;
			return null;
		}
		
		private static Script? tryParse_L4_tir(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return Tirh;
			return null;
		}
		
		private static Script? tryParse_L4_to(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L4_tot(span);
			return null;
		}
		
		private static Script? tryParse_L4_tot(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Toto;
			return null;
		}
		
		private static Script? tryParse_L4_u(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[1]) == 'g')
				return tryParse_L4_ug(span);
			return null;
		}
		
		private static Script? tryParse_L4_ug(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'a')
				return tryParse_L4_uga(span);
			return null;
		}
		
		private static Script? tryParse_L4_uga(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'r')
				return Ugar;
			return null;
		}
		
		private static Script? tryParse_L4_v(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_va(span);
				case 'i': return tryParse_L4_vi(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_va(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L4_vai(span);
			return null;
		}
		
		private static Script? tryParse_L4_vai(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Vaii;
			return null;
		}
		
		private static Script? tryParse_L4_vi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 's')
				return tryParse_L4_vis(span);
			return null;
		}
		
		private static Script? tryParse_L4_vis(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'p')
				return Visp;
			return null;
		}
		
		private static Script? tryParse_L4_w(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_wa(span);
				case 'c': return tryParse_L4_wc(span);
				case 'o': return tryParse_L4_wo(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_wa(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'r')
				return tryParse_L4_war(span);
			return null;
		}
		
		private static Script? tryParse_L4_war(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'a')
				return Wara;
			return null;
		}
		
		private static Script? tryParse_L4_wc(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'h')
				return tryParse_L4_wch(span);
			return null;
		}
		
		private static Script? tryParse_L4_wch(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Wcho;
			return null;
		}
		
		private static Script? tryParse_L4_wo(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'l')
				return tryParse_L4_wol(span);
			return null;
		}
		
		private static Script? tryParse_L4_wol(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'e')
				return Wole;
			return null;
		}
		
		private static Script? tryParse_L4_x(StringSpan span)
		{
			switch(span[1])
			{
				case 'p': return tryParse_L4_xp(span);
				case 's': return tryParse_L4_xs(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_xp(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'e')
				return tryParse_L4_xpe(span);
			return null;
		}
		
		private static Script? tryParse_L4_xpe(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'o')
				return Xpeo;
			return null;
		}
		
		private static Script? tryParse_L4_xs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'u')
				return tryParse_L4_xsu(span);
			return null;
		}
		
		private static Script? tryParse_L4_xsu(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'x')
				return Xsux;
			return null;
		}
		
		private static Script? tryParse_L4_y(StringSpan span)
		{
			switch(span[1])
			{
				case 'e': return tryParse_L4_ye(span);
				case 'i': return tryParse_L4_yi(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_ye(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return tryParse_L4_yez(span);
			return null;
		}
		
		private static Script? tryParse_L4_yez(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Yezi;
			return null;
		}
		
		private static Script? tryParse_L4_yi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'i')
				return tryParse_L4_yii(span);
			return null;
		}
		
		private static Script? tryParse_L4_yii(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'i')
				return Yiii;
			return null;
		}
		
		private static Script? tryParse_L4_z(StringSpan span)
		{
			switch(span[1])
			{
				case 'a': return tryParse_L4_za(span);
				case 'i': return tryParse_L4_zi(span);
				case 'm': return tryParse_L4_zm(span);
				case 's': return tryParse_L4_zs(span);
				case 'x': return tryParse_L4_zx(span);
				case 'y': return tryParse_L4_zy(span);
				case 'z': return tryParse_L4_zz(span);
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_za(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_zan(span);
			return null;
		}
		
		private static Script? tryParse_L4_zan(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'b')
				return Zanb;
			return null;
		}
		
		private static Script? tryParse_L4_zi(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'n')
				return tryParse_L4_zin(span);
			return null;
		}
		
		private static Script? tryParse_L4_zin(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return Zinh;
			return null;
		}
		
		private static Script? tryParse_L4_zm(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 't')
				return tryParse_L4_zmt(span);
			return null;
		}
		
		private static Script? tryParse_L4_zmt(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'h')
				return Zmth;
			return null;
		}
		
		private static Script? tryParse_L4_zs(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return tryParse_L4_zsy(span);
			return null;
		}
		
		private static Script? tryParse_L4_zsy(StringSpan span)
		{
			switch(span[3])
			{
				case 'e': return Zsye;
				case 'm': return Zsym;
				default: return null;
			}
		}
		
		private static Script? tryParse_L4_zx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'x')
				return tryParse_L4_zxx(span);
			return null;
		}
		
		private static Script? tryParse_L4_zxx(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'x')
				return Zxxx;
			return null;
		}
		
		private static Script? tryParse_L4_zy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'y')
				return tryParse_L4_zyy(span);
			return null;
		}
		
		private static Script? tryParse_L4_zyy(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'y')
				return Zyyy;
			return null;
		}
		
		private static Script? tryParse_L4_zz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[2]) == 'z')
				return tryParse_L4_zzz(span);
			return null;
		}
		
		private static Script? tryParse_L4_zzz(StringSpan span)
		{
			if(Char.ToLowerInvariant(span[3]) == 'z')
				return Zzzz;
			return null;
		}
	}
}
