using System;
using System.Globalization;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Variant
	{
		/// <summary>
		/// Returns public Variant by VariantCode
		/// </summary>
		public static Variant ByCode(VariantCode code)
		{
			switch(code)
			{
				case VariantCode.V1606nict: return V1606nictCache.Instance;
				case VariantCode.V1694acad: return V1694acadCache.Instance;
				case VariantCode.V1901: return V1901Cache.Instance;
				case VariantCode.V1959acad: return V1959acadCache.Instance;
				case VariantCode.V1994: return V1994Cache.Instance;
				case VariantCode.V1996: return V1996Cache.Instance;
				case VariantCode.Abl1943: return Abl1943Cache.Instance;
				case VariantCode.Akuapem: return AkuapemCache.Instance;
				case VariantCode.Alalc97: return Alalc97Cache.Instance;
				case VariantCode.Aluku: return AlukuCache.Instance;
				case VariantCode.Ao1990: return Ao1990Cache.Instance;
				case VariantCode.Aranes: return AranesCache.Instance;
				case VariantCode.Arevela: return ArevelaCache.Instance;
				case VariantCode.Arevmda: return ArevmdaCache.Instance;
				case VariantCode.Arkaika: return ArkaikaCache.Instance;
				case VariantCode.Asante: return AsanteCache.Instance;
				case VariantCode.Auvern: return AuvernCache.Instance;
				case VariantCode.Baku1926: return Baku1926Cache.Instance;
				case VariantCode.Balanka: return BalankaCache.Instance;
				case VariantCode.Barla: return BarlaCache.Instance;
				case VariantCode.Basiceng: return BasicengCache.Instance;
				case VariantCode.Bauddha: return BauddhaCache.Instance;
				case VariantCode.Bciav: return BciavCache.Instance;
				case VariantCode.Bcizbl: return BcizblCache.Instance;
				case VariantCode.Biscayan: return BiscayanCache.Instance;
				case VariantCode.Biske: return BiskeCache.Instance;
				case VariantCode.Blasl: return BlaslCache.Instance;
				case VariantCode.Bohoric: return BohoricCache.Instance;
				case VariantCode.Boont: return BoontCache.Instance;
				case VariantCode.Bornholm: return BornholmCache.Instance;
				case VariantCode.Cisaup: return CisaupCache.Instance;
				case VariantCode.Colb1945: return Colb1945Cache.Instance;
				case VariantCode.Cornu: return CornuCache.Instance;
				case VariantCode.Creiss: return CreissCache.Instance;
				case VariantCode.Dajnko: return DajnkoCache.Instance;
				case VariantCode.Ekavsk: return EkavskCache.Instance;
				case VariantCode.Emodeng: return EmodengCache.Instance;
				case VariantCode.Fonipa: return FonipaCache.Instance;
				case VariantCode.Fonkirsh: return FonkirshCache.Instance;
				case VariantCode.Fonnapa: return FonnapaCache.Instance;
				case VariantCode.Fonupa: return FonupaCache.Instance;
				case VariantCode.Fonxsamp: return FonxsampCache.Instance;
				case VariantCode.Gallo: return GalloCache.Instance;
				case VariantCode.Gascon: return GasconCache.Instance;
				case VariantCode.Grclass: return GrclassCache.Instance;
				case VariantCode.Grital: return GritalCache.Instance;
				case VariantCode.Grmistr: return GrmistrCache.Instance;
				case VariantCode.Hepburn: return HepburnCache.Instance;
				case VariantCode.Heploc: return HeplocCache.Instance;
				case VariantCode.Hognorsk: return HognorskCache.Instance;
				case VariantCode.Hsistemo: return HsistemoCache.Instance;
				case VariantCode.Ijekavsk: return IjekavskCache.Instance;
				case VariantCode.Itihasa: return ItihasaCache.Instance;
				case VariantCode.Ivanchov: return IvanchovCache.Instance;
				case VariantCode.Jauer: return JauerCache.Instance;
				case VariantCode.Jyutping: return JyutpingCache.Instance;
				case VariantCode.Kkcor: return KkcorCache.Instance;
				case VariantCode.Kociewie: return KociewieCache.Instance;
				case VariantCode.Kscor: return KscorCache.Instance;
				case VariantCode.Laukika: return LaukikaCache.Instance;
				case VariantCode.Lemosin: return LemosinCache.Instance;
				case VariantCode.Lengadoc: return LengadocCache.Instance;
				case VariantCode.Lipaw: return LipawCache.Instance;
				case VariantCode.Ltg1929: return Ltg1929Cache.Instance;
				case VariantCode.Ltg2007: return Ltg2007Cache.Instance;
				case VariantCode.Luna1918: return Luna1918Cache.Instance;
				case VariantCode.Metelko: return MetelkoCache.Instance;
				case VariantCode.Monoton: return MonotonCache.Instance;
				case VariantCode.Ndyuka: return NdyukaCache.Instance;
				case VariantCode.Nedis: return NedisCache.Instance;
				case VariantCode.Newfound: return NewfoundCache.Instance;
				case VariantCode.Nicard: return NicardCache.Instance;
				case VariantCode.Njiva: return NjivaCache.Instance;
				case VariantCode.Nulik: return NulikCache.Instance;
				case VariantCode.Osojs: return OsojsCache.Instance;
				case VariantCode.Oxendict: return OxendictCache.Instance;
				case VariantCode.Pahawh2: return Pahawh2Cache.Instance;
				case VariantCode.Pahawh3: return Pahawh3Cache.Instance;
				case VariantCode.Pahawh4: return Pahawh4Cache.Instance;
				case VariantCode.Pamaka: return PamakaCache.Instance;
				case VariantCode.Peano: return PeanoCache.Instance;
				case VariantCode.Petr1708: return Petr1708Cache.Instance;
				case VariantCode.Pinyin: return PinyinCache.Instance;
				case VariantCode.Polyton: return PolytonCache.Instance;
				case VariantCode.Provenc: return ProvencCache.Instance;
				case VariantCode.Puter: return PuterCache.Instance;
				case VariantCode.Rigik: return RigikCache.Instance;
				case VariantCode.Rozaj: return RozajCache.Instance;
				case VariantCode.Rumgr: return RumgrCache.Instance;
				case VariantCode.Scotland: return ScotlandCache.Instance;
				case VariantCode.Scouse: return ScouseCache.Instance;
				case VariantCode.Simple: return SimpleCache.Instance;
				case VariantCode.Solba: return SolbaCache.Instance;
				case VariantCode.Sotav: return SotavCache.Instance;
				case VariantCode.Spanglis: return SpanglisCache.Instance;
				case VariantCode.Surmiran: return SurmiranCache.Instance;
				case VariantCode.Sursilv: return SursilvCache.Instance;
				case VariantCode.Sutsilv: return SutsilvCache.Instance;
				case VariantCode.Synnejyl: return SynnejylCache.Instance;
				case VariantCode.Tarask: return TaraskCache.Instance;
				case VariantCode.Tongyong: return TongyongCache.Instance;
				case VariantCode.Tunumiit: return TunumiitCache.Instance;
				case VariantCode.Uccor: return UccorCache.Instance;
				case VariantCode.Ucrcor: return UcrcorCache.Instance;
				case VariantCode.Ulster: return UlsterCache.Instance;
				case VariantCode.Unifon: return UnifonCache.Instance;
				case VariantCode.Vaidika: return VaidikaCache.Instance;
				case VariantCode.Valencia: return ValenciaCache.Instance;
				case VariantCode.Vallader: return ValladerCache.Instance;
				case VariantCode.Vecdruka: return VecdrukaCache.Instance;
				case VariantCode.Vivaraup: return VivaraupCache.Instance;
				case VariantCode.Wadegile: return WadegileCache.Instance;
				case VariantCode.Xsistemo: return XsistemoCache.Instance;
				default: throw new ArgumentException(nameof(code), $"the code '{code}' does not correspond to the public variant");
			}
		}
	}
}
