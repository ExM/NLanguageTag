using System;

#pragma warning disable 618
namespace NLanguageTag
{
	public partial class Region
	{
		/// <summary>
		/// World
		/// added: 2005-10-16
		/// </summary>
		public static Region M001 => M001Cache.Instance;

		private static class M001Cache
		{
			public static readonly Region Instance = new Region("001",  RegionCode.M001, false);
		}

		/// <summary>
		/// Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M002 => M002Cache.Instance;

		private static class M002Cache
		{
			public static readonly Region Instance = new Region("002",  RegionCode.M002, false);
		}

		/// <summary>
		/// North America
		/// Includes Northern America (021), Caribbean (029), and Central America (013); see also 021
		/// added: 2010-08-16
		/// </summary>
		public static Region M003 => M003Cache.Instance;

		private static class M003Cache
		{
			public static readonly Region Instance = new Region("003",  RegionCode.M003, false);
		}

		/// <summary>
		/// South America
		/// added: 2005-10-16
		/// </summary>
		public static Region M005 => M005Cache.Instance;

		private static class M005Cache
		{
			public static readonly Region Instance = new Region("005",  RegionCode.M005, false);
		}

		/// <summary>
		/// Oceania
		/// added: 2005-10-16
		/// </summary>
		public static Region M009 => M009Cache.Instance;

		private static class M009Cache
		{
			public static readonly Region Instance = new Region("009",  RegionCode.M009, false);
		}

		/// <summary>
		/// Western Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M011 => M011Cache.Instance;

		private static class M011Cache
		{
			public static readonly Region Instance = new Region("011",  RegionCode.M011, false);
		}

		/// <summary>
		/// Central America
		/// added: 2005-10-16
		/// </summary>
		public static Region M013 => M013Cache.Instance;

		private static class M013Cache
		{
			public static readonly Region Instance = new Region("013",  RegionCode.M013, false);
		}

		/// <summary>
		/// Eastern Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M014 => M014Cache.Instance;

		private static class M014Cache
		{
			public static readonly Region Instance = new Region("014",  RegionCode.M014, false);
		}

		/// <summary>
		/// Northern Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M015 => M015Cache.Instance;

		private static class M015Cache
		{
			public static readonly Region Instance = new Region("015",  RegionCode.M015, false);
		}

		/// <summary>
		/// Middle Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M017 => M017Cache.Instance;

		private static class M017Cache
		{
			public static readonly Region Instance = new Region("017",  RegionCode.M017, false);
		}

		/// <summary>
		/// Southern Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region M018 => M018Cache.Instance;

		private static class M018Cache
		{
			public static readonly Region Instance = new Region("018",  RegionCode.M018, false);
		}

		/// <summary>
		/// Americas
		/// added: 2005-10-16
		/// </summary>
		public static Region M019 => M019Cache.Instance;

		private static class M019Cache
		{
			public static readonly Region Instance = new Region("019",  RegionCode.M019, false);
		}

		/// <summary>
		/// Northern America
		/// Does not include Caribbean (029) or Central America (013); see also 003
		/// added: 2005-10-16
		/// </summary>
		public static Region M021 => M021Cache.Instance;

		private static class M021Cache
		{
			public static readonly Region Instance = new Region("021",  RegionCode.M021, false);
		}

		/// <summary>
		/// Caribbean
		/// added: 2005-10-16
		/// </summary>
		public static Region M029 => M029Cache.Instance;

		private static class M029Cache
		{
			public static readonly Region Instance = new Region("029",  RegionCode.M029, false);
		}

		/// <summary>
		/// Eastern Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M030 => M030Cache.Instance;

		private static class M030Cache
		{
			public static readonly Region Instance = new Region("030",  RegionCode.M030, false);
		}

		/// <summary>
		/// Southern Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M034 => M034Cache.Instance;

		private static class M034Cache
		{
			public static readonly Region Instance = new Region("034",  RegionCode.M034, false);
		}

		/// <summary>
		/// South-Eastern Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M035 => M035Cache.Instance;

		private static class M035Cache
		{
			public static readonly Region Instance = new Region("035",  RegionCode.M035, false);
		}

		/// <summary>
		/// Southern Europe
		/// added: 2005-10-16
		/// </summary>
		public static Region M039 => M039Cache.Instance;

		private static class M039Cache
		{
			public static readonly Region Instance = new Region("039",  RegionCode.M039, false);
		}

		/// <summary>
		/// Australia and New Zealand
		/// added: 2005-10-16
		/// </summary>
		public static Region M053 => M053Cache.Instance;

		private static class M053Cache
		{
			public static readonly Region Instance = new Region("053",  RegionCode.M053, false);
		}

		/// <summary>
		/// Melanesia
		/// added: 2005-10-16
		/// </summary>
		public static Region M054 => M054Cache.Instance;

		private static class M054Cache
		{
			public static readonly Region Instance = new Region("054",  RegionCode.M054, false);
		}

		/// <summary>
		/// Micronesia
		/// added: 2005-10-16
		/// </summary>
		public static Region M057 => M057Cache.Instance;

		private static class M057Cache
		{
			public static readonly Region Instance = new Region("057",  RegionCode.M057, false);
		}

		/// <summary>
		/// Polynesia
		/// added: 2005-10-16
		/// </summary>
		public static Region M061 => M061Cache.Instance;

		private static class M061Cache
		{
			public static readonly Region Instance = new Region("061",  RegionCode.M061, false);
		}

		/// <summary>
		/// Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M142 => M142Cache.Instance;

		private static class M142Cache
		{
			public static readonly Region Instance = new Region("142",  RegionCode.M142, false);
		}

		/// <summary>
		/// Central Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M143 => M143Cache.Instance;

		private static class M143Cache
		{
			public static readonly Region Instance = new Region("143",  RegionCode.M143, false);
		}

		/// <summary>
		/// Western Asia
		/// added: 2005-10-16
		/// </summary>
		public static Region M145 => M145Cache.Instance;

		private static class M145Cache
		{
			public static readonly Region Instance = new Region("145",  RegionCode.M145, false);
		}

		/// <summary>
		/// Europe
		/// added: 2005-10-16
		/// </summary>
		public static Region M150 => M150Cache.Instance;

		private static class M150Cache
		{
			public static readonly Region Instance = new Region("150",  RegionCode.M150, false);
		}

		/// <summary>
		/// Eastern Europe
		/// added: 2005-10-16
		/// </summary>
		public static Region M151 => M151Cache.Instance;

		private static class M151Cache
		{
			public static readonly Region Instance = new Region("151",  RegionCode.M151, false);
		}

		/// <summary>
		/// Northern Europe
		/// added: 2005-10-16
		/// </summary>
		public static Region M154 => M154Cache.Instance;

		private static class M154Cache
		{
			public static readonly Region Instance = new Region("154",  RegionCode.M154, false);
		}

		/// <summary>
		/// Western Europe
		/// added: 2005-10-16
		/// </summary>
		public static Region M155 => M155Cache.Instance;

		private static class M155Cache
		{
			public static readonly Region Instance = new Region("155",  RegionCode.M155, false);
		}

		/// <summary>
		/// Sub-Saharan Africa
		/// added: 2017-04-18
		/// </summary>
		public static Region M202 => M202Cache.Instance;

		private static class M202Cache
		{
			public static readonly Region Instance = new Region("202",  RegionCode.M202, false);
		}

		/// <summary>
		/// Latin America and the Caribbean
		/// added: 2005-10-16
		/// </summary>
		public static Region M419 => M419Cache.Instance;

		private static class M419Cache
		{
			public static readonly Region Instance = new Region("419",  RegionCode.M419, false);
		}

		/// <summary>
		/// Ascension Island
		/// added: 2009-07-29
		/// </summary>
		public static Region AC => ACCache.Instance;

		private static class ACCache
		{
			public static readonly Region Instance = new Region("AC",  RegionCode.AC, false);
		}

		/// <summary>
		/// Andorra
		/// added: 2005-10-16
		/// </summary>
		public static Region AD => ADCache.Instance;

		private static class ADCache
		{
			public static readonly Region Instance = new Region("AD",  RegionCode.AD, false);
		}

		/// <summary>
		/// United Arab Emirates
		/// added: 2005-10-16
		/// </summary>
		public static Region AE => AECache.Instance;

		private static class AECache
		{
			public static readonly Region Instance = new Region("AE",  RegionCode.AE, false);
		}

		/// <summary>
		/// Afghanistan
		/// added: 2005-10-16
		/// </summary>
		public static Region AF => AFCache.Instance;

		private static class AFCache
		{
			public static readonly Region Instance = new Region("AF",  RegionCode.AF, false);
		}

		/// <summary>
		/// Antigua and Barbuda
		/// added: 2005-10-16
		/// </summary>
		public static Region AG => AGCache.Instance;

		private static class AGCache
		{
			public static readonly Region Instance = new Region("AG",  RegionCode.AG, false);
		}

		/// <summary>
		/// Anguilla
		/// added: 2005-10-16
		/// </summary>
		public static Region AI => AICache.Instance;

		private static class AICache
		{
			public static readonly Region Instance = new Region("AI",  RegionCode.AI, false);
		}

		/// <summary>
		/// Albania
		/// added: 2005-10-16
		/// </summary>
		public static Region AL => ALCache.Instance;

		private static class ALCache
		{
			public static readonly Region Instance = new Region("AL",  RegionCode.AL, false);
		}

		/// <summary>
		/// Armenia
		/// added: 2005-10-16
		/// </summary>
		public static Region AM => AMCache.Instance;

		private static class AMCache
		{
			public static readonly Region Instance = new Region("AM",  RegionCode.AM, false);
		}

		/// <summary>
		/// Netherlands Antilles
		/// see BQ, CW, and SX
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("see BQ, CW, and SX, deprecated from 2011-01-07")]
		public static Region AN => ANCache.Instance;

		private static class ANCache
		{
			public static readonly Region Instance = new Region("AN",  RegionCode.AN, true);
		}

		/// <summary>
		/// Angola
		/// added: 2005-10-16
		/// </summary>
		public static Region AO => AOCache.Instance;

		private static class AOCache
		{
			public static readonly Region Instance = new Region("AO",  RegionCode.AO, false);
		}

		/// <summary>
		/// Antarctica
		/// added: 2005-10-16
		/// </summary>
		public static Region AQ => AQCache.Instance;

		private static class AQCache
		{
			public static readonly Region Instance = new Region("AQ",  RegionCode.AQ, false);
		}

		/// <summary>
		/// Argentina
		/// added: 2005-10-16
		/// </summary>
		public static Region AR => ARCache.Instance;

		private static class ARCache
		{
			public static readonly Region Instance = new Region("AR",  RegionCode.AR, false);
		}

		/// <summary>
		/// American Samoa
		/// added: 2005-10-16
		/// </summary>
		public static Region AS => ASCache.Instance;

		private static class ASCache
		{
			public static readonly Region Instance = new Region("AS",  RegionCode.AS, false);
		}

		/// <summary>
		/// Austria
		/// added: 2005-10-16
		/// </summary>
		public static Region AT => ATCache.Instance;

		private static class ATCache
		{
			public static readonly Region Instance = new Region("AT",  RegionCode.AT, false);
		}

		/// <summary>
		/// Australia
		/// added: 2005-10-16
		/// </summary>
		public static Region AU => AUCache.Instance;

		private static class AUCache
		{
			public static readonly Region Instance = new Region("AU",  RegionCode.AU, false);
		}

		/// <summary>
		/// Aruba
		/// added: 2005-10-16
		/// </summary>
		public static Region AW => AWCache.Instance;

		private static class AWCache
		{
			public static readonly Region Instance = new Region("AW",  RegionCode.AW, false);
		}

		/// <summary>
		/// Åland Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region AX => AXCache.Instance;

		private static class AXCache
		{
			public static readonly Region Instance = new Region("AX",  RegionCode.AX, false);
		}

		/// <summary>
		/// Azerbaijan
		/// added: 2005-10-16
		/// </summary>
		public static Region AZ => AZCache.Instance;

		private static class AZCache
		{
			public static readonly Region Instance = new Region("AZ",  RegionCode.AZ, false);
		}

		/// <summary>
		/// Bosnia and Herzegovina
		/// added: 2005-10-16
		/// </summary>
		public static Region BA => BACache.Instance;

		private static class BACache
		{
			public static readonly Region Instance = new Region("BA",  RegionCode.BA, false);
		}

		/// <summary>
		/// Barbados
		/// added: 2005-10-16
		/// </summary>
		public static Region BB => BBCache.Instance;

		private static class BBCache
		{
			public static readonly Region Instance = new Region("BB",  RegionCode.BB, false);
		}

		/// <summary>
		/// Bangladesh
		/// added: 2005-10-16
		/// </summary>
		public static Region BD => BDCache.Instance;

		private static class BDCache
		{
			public static readonly Region Instance = new Region("BD",  RegionCode.BD, false);
		}

		/// <summary>
		/// Belgium
		/// added: 2005-10-16
		/// </summary>
		public static Region BE => BECache.Instance;

		private static class BECache
		{
			public static readonly Region Instance = new Region("BE",  RegionCode.BE, false);
		}

		/// <summary>
		/// Burkina Faso
		/// added: 2005-10-16
		/// </summary>
		public static Region BF => BFCache.Instance;

		private static class BFCache
		{
			public static readonly Region Instance = new Region("BF",  RegionCode.BF, false);
		}

		/// <summary>
		/// Bulgaria
		/// added: 2005-10-16
		/// </summary>
		public static Region BG => BGCache.Instance;

		private static class BGCache
		{
			public static readonly Region Instance = new Region("BG",  RegionCode.BG, false);
		}

		/// <summary>
		/// Bahrain
		/// added: 2005-10-16
		/// </summary>
		public static Region BH => BHCache.Instance;

		private static class BHCache
		{
			public static readonly Region Instance = new Region("BH",  RegionCode.BH, false);
		}

		/// <summary>
		/// Burundi
		/// added: 2005-10-16
		/// </summary>
		public static Region BI => BICache.Instance;

		private static class BICache
		{
			public static readonly Region Instance = new Region("BI",  RegionCode.BI, false);
		}

		/// <summary>
		/// Benin
		/// added: 2005-10-16
		/// </summary>
		public static Region BJ => BJCache.Instance;

		private static class BJCache
		{
			public static readonly Region Instance = new Region("BJ",  RegionCode.BJ, false);
		}

		/// <summary>
		/// Saint Barthélemy
		/// added: 2007-11-02
		/// </summary>
		public static Region BL => BLCache.Instance;

		private static class BLCache
		{
			public static readonly Region Instance = new Region("BL",  RegionCode.BL, false);
		}

		/// <summary>
		/// Bermuda
		/// added: 2005-10-16
		/// </summary>
		public static Region BM => BMCache.Instance;

		private static class BMCache
		{
			public static readonly Region Instance = new Region("BM",  RegionCode.BM, false);
		}

		/// <summary>
		/// Brunei Darussalam
		/// added: 2005-10-16
		/// </summary>
		public static Region BN => BNCache.Instance;

		private static class BNCache
		{
			public static readonly Region Instance = new Region("BN",  RegionCode.BN, false);
		}

		/// <summary>
		/// Bolivia
		/// added: 2005-10-16
		/// </summary>
		public static Region BO => BOCache.Instance;

		private static class BOCache
		{
			public static readonly Region Instance = new Region("BO",  RegionCode.BO, false);
		}

		/// <summary>
		/// Bonaire, Sint Eustatius and Saba
		/// added: 2011-01-07
		/// </summary>
		public static Region BQ => BQCache.Instance;

		private static class BQCache
		{
			public static readonly Region Instance = new Region("BQ",  RegionCode.BQ, false);
		}

		/// <summary>
		/// Brazil
		/// added: 2005-10-16
		/// </summary>
		public static Region BR => BRCache.Instance;

		private static class BRCache
		{
			public static readonly Region Instance = new Region("BR",  RegionCode.BR, false);
		}

		/// <summary>
		/// Bahamas
		/// added: 2005-10-16
		/// </summary>
		public static Region BS => BSCache.Instance;

		private static class BSCache
		{
			public static readonly Region Instance = new Region("BS",  RegionCode.BS, false);
		}

		/// <summary>
		/// Bhutan
		/// added: 2005-10-16
		/// </summary>
		public static Region BT => BTCache.Instance;

		private static class BTCache
		{
			public static readonly Region Instance = new Region("BT",  RegionCode.BT, false);
		}

		/// <summary>
		/// Burma
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use MM, deprecated from 1989-12-05")]
		public static Region BU => BUCache.Instance;

		private static class BUCache
		{
			public static readonly Region Instance = new Region("BU",  RegionCode.BU, true);
		}

		/// <summary>
		/// Bouvet Island
		/// added: 2005-10-16
		/// </summary>
		public static Region BV => BVCache.Instance;

		private static class BVCache
		{
			public static readonly Region Instance = new Region("BV",  RegionCode.BV, false);
		}

		/// <summary>
		/// Botswana
		/// added: 2005-10-16
		/// </summary>
		public static Region BW => BWCache.Instance;

		private static class BWCache
		{
			public static readonly Region Instance = new Region("BW",  RegionCode.BW, false);
		}

		/// <summary>
		/// Belarus
		/// added: 2005-10-16
		/// </summary>
		public static Region BY => BYCache.Instance;

		private static class BYCache
		{
			public static readonly Region Instance = new Region("BY",  RegionCode.BY, false);
		}

		/// <summary>
		/// Belize
		/// added: 2005-10-16
		/// </summary>
		public static Region BZ => BZCache.Instance;

		private static class BZCache
		{
			public static readonly Region Instance = new Region("BZ",  RegionCode.BZ, false);
		}

		/// <summary>
		/// Canada
		/// added: 2005-10-16
		/// </summary>
		public static Region CA => CACache.Instance;

		private static class CACache
		{
			public static readonly Region Instance = new Region("CA",  RegionCode.CA, false);
		}

		/// <summary>
		/// Cocos (Keeling) Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region CC => CCCache.Instance;

		private static class CCCache
		{
			public static readonly Region Instance = new Region("CC",  RegionCode.CC, false);
		}

		/// <summary>
		/// The Democratic Republic of the Congo
		/// added: 2005-10-16
		/// </summary>
		public static Region CD => CDCache.Instance;

		private static class CDCache
		{
			public static readonly Region Instance = new Region("CD",  RegionCode.CD, false);
		}

		/// <summary>
		/// Central African Republic
		/// added: 2005-10-16
		/// </summary>
		public static Region CF => CFCache.Instance;

		private static class CFCache
		{
			public static readonly Region Instance = new Region("CF",  RegionCode.CF, false);
		}

		/// <summary>
		/// Congo
		/// added: 2005-10-16
		/// </summary>
		public static Region CG => CGCache.Instance;

		private static class CGCache
		{
			public static readonly Region Instance = new Region("CG",  RegionCode.CG, false);
		}

		/// <summary>
		/// Switzerland
		/// added: 2005-10-16
		/// </summary>
		public static Region CH => CHCache.Instance;

		private static class CHCache
		{
			public static readonly Region Instance = new Region("CH",  RegionCode.CH, false);
		}

		/// <summary>
		/// Côte d'Ivoire
		/// added: 2005-10-16
		/// </summary>
		public static Region CI => CICache.Instance;

		private static class CICache
		{
			public static readonly Region Instance = new Region("CI",  RegionCode.CI, false);
		}

		/// <summary>
		/// Cook Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region CK => CKCache.Instance;

		private static class CKCache
		{
			public static readonly Region Instance = new Region("CK",  RegionCode.CK, false);
		}

		/// <summary>
		/// Chile
		/// added: 2005-10-16
		/// </summary>
		public static Region CL => CLCache.Instance;

		private static class CLCache
		{
			public static readonly Region Instance = new Region("CL",  RegionCode.CL, false);
		}

		/// <summary>
		/// Cameroon
		/// added: 2005-10-16
		/// </summary>
		public static Region CM => CMCache.Instance;

		private static class CMCache
		{
			public static readonly Region Instance = new Region("CM",  RegionCode.CM, false);
		}

		/// <summary>
		/// China
		/// added: 2005-10-16
		/// </summary>
		public static Region CN => CNCache.Instance;

		private static class CNCache
		{
			public static readonly Region Instance = new Region("CN",  RegionCode.CN, false);
		}

		/// <summary>
		/// Colombia
		/// added: 2005-10-16
		/// </summary>
		public static Region CO => COCache.Instance;

		private static class COCache
		{
			public static readonly Region Instance = new Region("CO",  RegionCode.CO, false);
		}

		/// <summary>
		/// Clipperton Island
		/// added: 2009-07-29
		/// </summary>
		public static Region CP => CPCache.Instance;

		private static class CPCache
		{
			public static readonly Region Instance = new Region("CP",  RegionCode.CP, false);
		}

		/// <summary>
		/// Costa Rica
		/// added: 2005-10-16
		/// </summary>
		public static Region CR => CRCache.Instance;

		private static class CRCache
		{
			public static readonly Region Instance = new Region("CR",  RegionCode.CR, false);
		}

		/// <summary>
		/// Serbia and Montenegro
		/// see RS for Serbia or ME for Montenegro
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("see RS for Serbia or ME for Montenegro, deprecated from 2006-10-05")]
		public static Region CS => CSCache.Instance;

		private static class CSCache
		{
			public static readonly Region Instance = new Region("CS",  RegionCode.CS, true);
		}

		/// <summary>
		/// Cuba
		/// added: 2005-10-16
		/// </summary>
		public static Region CU => CUCache.Instance;

		private static class CUCache
		{
			public static readonly Region Instance = new Region("CU",  RegionCode.CU, false);
		}

		/// <summary>
		/// Cabo Verde
		/// Cape Verde
		/// added: 2005-10-16
		/// </summary>
		public static Region CV => CVCache.Instance;

		private static class CVCache
		{
			public static readonly Region Instance = new Region("CV",  RegionCode.CV, false);
		}

		/// <summary>
		/// Curaçao
		/// added: 2011-01-07
		/// </summary>
		public static Region CW => CWCache.Instance;

		private static class CWCache
		{
			public static readonly Region Instance = new Region("CW",  RegionCode.CW, false);
		}

		/// <summary>
		/// Christmas Island
		/// added: 2005-10-16
		/// </summary>
		public static Region CX => CXCache.Instance;

		private static class CXCache
		{
			public static readonly Region Instance = new Region("CX",  RegionCode.CX, false);
		}

		/// <summary>
		/// Cyprus
		/// added: 2005-10-16
		/// </summary>
		public static Region CY => CYCache.Instance;

		private static class CYCache
		{
			public static readonly Region Instance = new Region("CY",  RegionCode.CY, false);
		}

		/// <summary>
		/// Czechia
		/// Czech Republic
		/// added: 2005-10-16
		/// </summary>
		public static Region CZ => CZCache.Instance;

		private static class CZCache
		{
			public static readonly Region Instance = new Region("CZ",  RegionCode.CZ, false);
		}

		/// <summary>
		/// German Democratic Republic
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use DE, deprecated from 1990-10-30")]
		public static Region DD => DDCache.Instance;

		private static class DDCache
		{
			public static readonly Region Instance = new Region("DD",  RegionCode.DD, true);
		}

		/// <summary>
		/// Germany
		/// added: 2005-10-16
		/// </summary>
		public static Region DE => DECache.Instance;

		private static class DECache
		{
			public static readonly Region Instance = new Region("DE",  RegionCode.DE, false);
		}

		/// <summary>
		/// Diego Garcia
		/// added: 2009-07-29
		/// </summary>
		public static Region DG => DGCache.Instance;

		private static class DGCache
		{
			public static readonly Region Instance = new Region("DG",  RegionCode.DG, false);
		}

		/// <summary>
		/// Djibouti
		/// added: 2005-10-16
		/// </summary>
		public static Region DJ => DJCache.Instance;

		private static class DJCache
		{
			public static readonly Region Instance = new Region("DJ",  RegionCode.DJ, false);
		}

		/// <summary>
		/// Denmark
		/// added: 2005-10-16
		/// </summary>
		public static Region DK => DKCache.Instance;

		private static class DKCache
		{
			public static readonly Region Instance = new Region("DK",  RegionCode.DK, false);
		}

		/// <summary>
		/// Dominica
		/// added: 2005-10-16
		/// </summary>
		public static Region DM => DMCache.Instance;

		private static class DMCache
		{
			public static readonly Region Instance = new Region("DM",  RegionCode.DM, false);
		}

		/// <summary>
		/// Dominican Republic
		/// added: 2005-10-16
		/// </summary>
		public static Region DO => DOCache.Instance;

		private static class DOCache
		{
			public static readonly Region Instance = new Region("DO",  RegionCode.DO, false);
		}

		/// <summary>
		/// Algeria
		/// added: 2005-10-16
		/// </summary>
		public static Region DZ => DZCache.Instance;

		private static class DZCache
		{
			public static readonly Region Instance = new Region("DZ",  RegionCode.DZ, false);
		}

		/// <summary>
		/// Ceuta, Melilla
		/// added: 2009-07-29
		/// </summary>
		public static Region EA => EACache.Instance;

		private static class EACache
		{
			public static readonly Region Instance = new Region("EA",  RegionCode.EA, false);
		}

		/// <summary>
		/// Ecuador
		/// added: 2005-10-16
		/// </summary>
		public static Region EC => ECCache.Instance;

		private static class ECCache
		{
			public static readonly Region Instance = new Region("EC",  RegionCode.EC, false);
		}

		/// <summary>
		/// Estonia
		/// added: 2005-10-16
		/// </summary>
		public static Region EE => EECache.Instance;

		private static class EECache
		{
			public static readonly Region Instance = new Region("EE",  RegionCode.EE, false);
		}

		/// <summary>
		/// Egypt
		/// added: 2005-10-16
		/// </summary>
		public static Region EG => EGCache.Instance;

		private static class EGCache
		{
			public static readonly Region Instance = new Region("EG",  RegionCode.EG, false);
		}

		/// <summary>
		/// Western Sahara
		/// added: 2005-10-16
		/// </summary>
		public static Region EH => EHCache.Instance;

		private static class EHCache
		{
			public static readonly Region Instance = new Region("EH",  RegionCode.EH, false);
		}

		/// <summary>
		/// Eritrea
		/// added: 2005-10-16
		/// </summary>
		public static Region ER => ERCache.Instance;

		private static class ERCache
		{
			public static readonly Region Instance = new Region("ER",  RegionCode.ER, false);
		}

		/// <summary>
		/// Spain
		/// added: 2005-10-16
		/// </summary>
		public static Region ES => ESCache.Instance;

		private static class ESCache
		{
			public static readonly Region Instance = new Region("ES",  RegionCode.ES, false);
		}

		/// <summary>
		/// Ethiopia
		/// added: 2005-10-16
		/// </summary>
		public static Region ET => ETCache.Instance;

		private static class ETCache
		{
			public static readonly Region Instance = new Region("ET",  RegionCode.ET, false);
		}

		/// <summary>
		/// European Union
		/// added: 2009-07-29
		/// </summary>
		public static Region EU => EUCache.Instance;

		private static class EUCache
		{
			public static readonly Region Instance = new Region("EU",  RegionCode.EU, false);
		}

		/// <summary>
		/// Eurozone
		/// added: 2016-07-14
		/// </summary>
		public static Region EZ => EZCache.Instance;

		private static class EZCache
		{
			public static readonly Region Instance = new Region("EZ",  RegionCode.EZ, false);
		}

		/// <summary>
		/// Finland
		/// added: 2005-10-16
		/// </summary>
		public static Region FI => FICache.Instance;

		private static class FICache
		{
			public static readonly Region Instance = new Region("FI",  RegionCode.FI, false);
		}

		/// <summary>
		/// Fiji
		/// added: 2005-10-16
		/// </summary>
		public static Region FJ => FJCache.Instance;

		private static class FJCache
		{
			public static readonly Region Instance = new Region("FJ",  RegionCode.FJ, false);
		}

		/// <summary>
		/// Falkland Islands (Malvinas)
		/// added: 2005-10-16
		/// </summary>
		public static Region FK => FKCache.Instance;

		private static class FKCache
		{
			public static readonly Region Instance = new Region("FK",  RegionCode.FK, false);
		}

		/// <summary>
		/// Federated States of Micronesia
		/// added: 2005-10-16
		/// </summary>
		public static Region FM => FMCache.Instance;

		private static class FMCache
		{
			public static readonly Region Instance = new Region("FM",  RegionCode.FM, false);
		}

		/// <summary>
		/// Faroe Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region FO => FOCache.Instance;

		private static class FOCache
		{
			public static readonly Region Instance = new Region("FO",  RegionCode.FO, false);
		}

		/// <summary>
		/// France
		/// added: 2005-10-16
		/// </summary>
		public static Region FR => FRCache.Instance;

		private static class FRCache
		{
			public static readonly Region Instance = new Region("FR",  RegionCode.FR, false);
		}

		/// <summary>
		/// Metropolitan France
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use FR, deprecated from 1997-07-14")]
		public static Region FX => FXCache.Instance;

		private static class FXCache
		{
			public static readonly Region Instance = new Region("FX",  RegionCode.FX, true);
		}

		/// <summary>
		/// Gabon
		/// added: 2005-10-16
		/// </summary>
		public static Region GA => GACache.Instance;

		private static class GACache
		{
			public static readonly Region Instance = new Region("GA",  RegionCode.GA, false);
		}

		/// <summary>
		/// United Kingdom
		/// as of 2006-03-29 GB no longer includes the Channel Islands and Isle of Man; see GG, JE, IM
		/// added: 2005-10-16
		/// </summary>
		public static Region GB => GBCache.Instance;

		private static class GBCache
		{
			public static readonly Region Instance = new Region("GB",  RegionCode.GB, false);
		}

		/// <summary>
		/// Grenada
		/// added: 2005-10-16
		/// </summary>
		public static Region GD => GDCache.Instance;

		private static class GDCache
		{
			public static readonly Region Instance = new Region("GD",  RegionCode.GD, false);
		}

		/// <summary>
		/// Georgia
		/// added: 2005-10-16
		/// </summary>
		public static Region GE => GECache.Instance;

		private static class GECache
		{
			public static readonly Region Instance = new Region("GE",  RegionCode.GE, false);
		}

		/// <summary>
		/// French Guiana
		/// added: 2005-10-16
		/// </summary>
		public static Region GF => GFCache.Instance;

		private static class GFCache
		{
			public static readonly Region Instance = new Region("GF",  RegionCode.GF, false);
		}

		/// <summary>
		/// Guernsey
		/// added: 2006-03-29
		/// </summary>
		public static Region GG => GGCache.Instance;

		private static class GGCache
		{
			public static readonly Region Instance = new Region("GG",  RegionCode.GG, false);
		}

		/// <summary>
		/// Ghana
		/// added: 2005-10-16
		/// </summary>
		public static Region GH => GHCache.Instance;

		private static class GHCache
		{
			public static readonly Region Instance = new Region("GH",  RegionCode.GH, false);
		}

		/// <summary>
		/// Gibraltar
		/// added: 2005-10-16
		/// </summary>
		public static Region GI => GICache.Instance;

		private static class GICache
		{
			public static readonly Region Instance = new Region("GI",  RegionCode.GI, false);
		}

		/// <summary>
		/// Greenland
		/// added: 2005-10-16
		/// </summary>
		public static Region GL => GLCache.Instance;

		private static class GLCache
		{
			public static readonly Region Instance = new Region("GL",  RegionCode.GL, false);
		}

		/// <summary>
		/// Gambia
		/// added: 2005-10-16
		/// </summary>
		public static Region GM => GMCache.Instance;

		private static class GMCache
		{
			public static readonly Region Instance = new Region("GM",  RegionCode.GM, false);
		}

		/// <summary>
		/// Guinea
		/// added: 2005-10-16
		/// </summary>
		public static Region GN => GNCache.Instance;

		private static class GNCache
		{
			public static readonly Region Instance = new Region("GN",  RegionCode.GN, false);
		}

		/// <summary>
		/// Guadeloupe
		/// added: 2005-10-16
		/// </summary>
		public static Region GP => GPCache.Instance;

		private static class GPCache
		{
			public static readonly Region Instance = new Region("GP",  RegionCode.GP, false);
		}

		/// <summary>
		/// Equatorial Guinea
		/// added: 2005-10-16
		/// </summary>
		public static Region GQ => GQCache.Instance;

		private static class GQCache
		{
			public static readonly Region Instance = new Region("GQ",  RegionCode.GQ, false);
		}

		/// <summary>
		/// Greece
		/// added: 2005-10-16
		/// </summary>
		public static Region GR => GRCache.Instance;

		private static class GRCache
		{
			public static readonly Region Instance = new Region("GR",  RegionCode.GR, false);
		}

		/// <summary>
		/// South Georgia and the South Sandwich Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region GS => GSCache.Instance;

		private static class GSCache
		{
			public static readonly Region Instance = new Region("GS",  RegionCode.GS, false);
		}

		/// <summary>
		/// Guatemala
		/// added: 2005-10-16
		/// </summary>
		public static Region GT => GTCache.Instance;

		private static class GTCache
		{
			public static readonly Region Instance = new Region("GT",  RegionCode.GT, false);
		}

		/// <summary>
		/// Guam
		/// added: 2005-10-16
		/// </summary>
		public static Region GU => GUCache.Instance;

		private static class GUCache
		{
			public static readonly Region Instance = new Region("GU",  RegionCode.GU, false);
		}

		/// <summary>
		/// Guinea-Bissau
		/// added: 2005-10-16
		/// </summary>
		public static Region GW => GWCache.Instance;

		private static class GWCache
		{
			public static readonly Region Instance = new Region("GW",  RegionCode.GW, false);
		}

		/// <summary>
		/// Guyana
		/// added: 2005-10-16
		/// </summary>
		public static Region GY => GYCache.Instance;

		private static class GYCache
		{
			public static readonly Region Instance = new Region("GY",  RegionCode.GY, false);
		}

		/// <summary>
		/// Hong Kong
		/// added: 2005-10-16
		/// </summary>
		public static Region HK => HKCache.Instance;

		private static class HKCache
		{
			public static readonly Region Instance = new Region("HK",  RegionCode.HK, false);
		}

		/// <summary>
		/// Heard Island and McDonald Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region HM => HMCache.Instance;

		private static class HMCache
		{
			public static readonly Region Instance = new Region("HM",  RegionCode.HM, false);
		}

		/// <summary>
		/// Honduras
		/// added: 2005-10-16
		/// </summary>
		public static Region HN => HNCache.Instance;

		private static class HNCache
		{
			public static readonly Region Instance = new Region("HN",  RegionCode.HN, false);
		}

		/// <summary>
		/// Croatia
		/// added: 2005-10-16
		/// </summary>
		public static Region HR => HRCache.Instance;

		private static class HRCache
		{
			public static readonly Region Instance = new Region("HR",  RegionCode.HR, false);
		}

		/// <summary>
		/// Haiti
		/// added: 2005-10-16
		/// </summary>
		public static Region HT => HTCache.Instance;

		private static class HTCache
		{
			public static readonly Region Instance = new Region("HT",  RegionCode.HT, false);
		}

		/// <summary>
		/// Hungary
		/// added: 2005-10-16
		/// </summary>
		public static Region HU => HUCache.Instance;

		private static class HUCache
		{
			public static readonly Region Instance = new Region("HU",  RegionCode.HU, false);
		}

		/// <summary>
		/// Canary Islands
		/// added: 2009-07-29
		/// </summary>
		public static Region IC => ICCache.Instance;

		private static class ICCache
		{
			public static readonly Region Instance = new Region("IC",  RegionCode.IC, false);
		}

		/// <summary>
		/// Indonesia
		/// added: 2005-10-16
		/// </summary>
		public static Region ID => IDCache.Instance;

		private static class IDCache
		{
			public static readonly Region Instance = new Region("ID",  RegionCode.ID, false);
		}

		/// <summary>
		/// Ireland
		/// added: 2005-10-16
		/// </summary>
		public static Region IE => IECache.Instance;

		private static class IECache
		{
			public static readonly Region Instance = new Region("IE",  RegionCode.IE, false);
		}

		/// <summary>
		/// Israel
		/// added: 2005-10-16
		/// </summary>
		public static Region IL => ILCache.Instance;

		private static class ILCache
		{
			public static readonly Region Instance = new Region("IL",  RegionCode.IL, false);
		}

		/// <summary>
		/// Isle of Man
		/// added: 2006-03-29
		/// </summary>
		public static Region IM => IMCache.Instance;

		private static class IMCache
		{
			public static readonly Region Instance = new Region("IM",  RegionCode.IM, false);
		}

		/// <summary>
		/// India
		/// added: 2005-10-16
		/// </summary>
		public static Region IN => INCache.Instance;

		private static class INCache
		{
			public static readonly Region Instance = new Region("IN",  RegionCode.IN, false);
		}

		/// <summary>
		/// British Indian Ocean Territory
		/// added: 2005-10-16
		/// </summary>
		public static Region IO => IOCache.Instance;

		private static class IOCache
		{
			public static readonly Region Instance = new Region("IO",  RegionCode.IO, false);
		}

		/// <summary>
		/// Iraq
		/// added: 2005-10-16
		/// </summary>
		public static Region IQ => IQCache.Instance;

		private static class IQCache
		{
			public static readonly Region Instance = new Region("IQ",  RegionCode.IQ, false);
		}

		/// <summary>
		/// Islamic Republic of Iran
		/// added: 2005-10-16
		/// </summary>
		public static Region IR => IRCache.Instance;

		private static class IRCache
		{
			public static readonly Region Instance = new Region("IR",  RegionCode.IR, false);
		}

		/// <summary>
		/// Iceland
		/// added: 2005-10-16
		/// </summary>
		public static Region IS => ISCache.Instance;

		private static class ISCache
		{
			public static readonly Region Instance = new Region("IS",  RegionCode.IS, false);
		}

		/// <summary>
		/// Italy
		/// added: 2005-10-16
		/// </summary>
		public static Region IT => ITCache.Instance;

		private static class ITCache
		{
			public static readonly Region Instance = new Region("IT",  RegionCode.IT, false);
		}

		/// <summary>
		/// Jersey
		/// added: 2006-03-29
		/// </summary>
		public static Region JE => JECache.Instance;

		private static class JECache
		{
			public static readonly Region Instance = new Region("JE",  RegionCode.JE, false);
		}

		/// <summary>
		/// Jamaica
		/// added: 2005-10-16
		/// </summary>
		public static Region JM => JMCache.Instance;

		private static class JMCache
		{
			public static readonly Region Instance = new Region("JM",  RegionCode.JM, false);
		}

		/// <summary>
		/// Jordan
		/// added: 2005-10-16
		/// </summary>
		public static Region JO => JOCache.Instance;

		private static class JOCache
		{
			public static readonly Region Instance = new Region("JO",  RegionCode.JO, false);
		}

		/// <summary>
		/// Japan
		/// added: 2005-10-16
		/// </summary>
		public static Region JP => JPCache.Instance;

		private static class JPCache
		{
			public static readonly Region Instance = new Region("JP",  RegionCode.JP, false);
		}

		/// <summary>
		/// Kenya
		/// added: 2005-10-16
		/// </summary>
		public static Region KE => KECache.Instance;

		private static class KECache
		{
			public static readonly Region Instance = new Region("KE",  RegionCode.KE, false);
		}

		/// <summary>
		/// Kyrgyzstan
		/// added: 2005-10-16
		/// </summary>
		public static Region KG => KGCache.Instance;

		private static class KGCache
		{
			public static readonly Region Instance = new Region("KG",  RegionCode.KG, false);
		}

		/// <summary>
		/// Cambodia
		/// added: 2005-10-16
		/// </summary>
		public static Region KH => KHCache.Instance;

		private static class KHCache
		{
			public static readonly Region Instance = new Region("KH",  RegionCode.KH, false);
		}

		/// <summary>
		/// Kiribati
		/// added: 2005-10-16
		/// </summary>
		public static Region KI => KICache.Instance;

		private static class KICache
		{
			public static readonly Region Instance = new Region("KI",  RegionCode.KI, false);
		}

		/// <summary>
		/// Comoros
		/// added: 2005-10-16
		/// </summary>
		public static Region KM => KMCache.Instance;

		private static class KMCache
		{
			public static readonly Region Instance = new Region("KM",  RegionCode.KM, false);
		}

		/// <summary>
		/// Saint Kitts and Nevis
		/// added: 2005-10-16
		/// </summary>
		public static Region KN => KNCache.Instance;

		private static class KNCache
		{
			public static readonly Region Instance = new Region("KN",  RegionCode.KN, false);
		}

		/// <summary>
		/// Democratic People's Republic of Korea
		/// added: 2005-10-16
		/// </summary>
		public static Region KP => KPCache.Instance;

		private static class KPCache
		{
			public static readonly Region Instance = new Region("KP",  RegionCode.KP, false);
		}

		/// <summary>
		/// Republic of Korea
		/// added: 2005-10-16
		/// </summary>
		public static Region KR => KRCache.Instance;

		private static class KRCache
		{
			public static readonly Region Instance = new Region("KR",  RegionCode.KR, false);
		}

		/// <summary>
		/// Kuwait
		/// added: 2005-10-16
		/// </summary>
		public static Region KW => KWCache.Instance;

		private static class KWCache
		{
			public static readonly Region Instance = new Region("KW",  RegionCode.KW, false);
		}

		/// <summary>
		/// Cayman Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region KY => KYCache.Instance;

		private static class KYCache
		{
			public static readonly Region Instance = new Region("KY",  RegionCode.KY, false);
		}

		/// <summary>
		/// Kazakhstan
		/// added: 2005-10-16
		/// </summary>
		public static Region KZ => KZCache.Instance;

		private static class KZCache
		{
			public static readonly Region Instance = new Region("KZ",  RegionCode.KZ, false);
		}

		/// <summary>
		/// Lao People's Democratic Republic
		/// added: 2005-10-16
		/// </summary>
		public static Region LA => LACache.Instance;

		private static class LACache
		{
			public static readonly Region Instance = new Region("LA",  RegionCode.LA, false);
		}

		/// <summary>
		/// Lebanon
		/// added: 2005-10-16
		/// </summary>
		public static Region LB => LBCache.Instance;

		private static class LBCache
		{
			public static readonly Region Instance = new Region("LB",  RegionCode.LB, false);
		}

		/// <summary>
		/// Saint Lucia
		/// added: 2005-10-16
		/// </summary>
		public static Region LC => LCCache.Instance;

		private static class LCCache
		{
			public static readonly Region Instance = new Region("LC",  RegionCode.LC, false);
		}

		/// <summary>
		/// Liechtenstein
		/// added: 2005-10-16
		/// </summary>
		public static Region LI => LICache.Instance;

		private static class LICache
		{
			public static readonly Region Instance = new Region("LI",  RegionCode.LI, false);
		}

		/// <summary>
		/// Sri Lanka
		/// added: 2005-10-16
		/// </summary>
		public static Region LK => LKCache.Instance;

		private static class LKCache
		{
			public static readonly Region Instance = new Region("LK",  RegionCode.LK, false);
		}

		/// <summary>
		/// Liberia
		/// added: 2005-10-16
		/// </summary>
		public static Region LR => LRCache.Instance;

		private static class LRCache
		{
			public static readonly Region Instance = new Region("LR",  RegionCode.LR, false);
		}

		/// <summary>
		/// Lesotho
		/// added: 2005-10-16
		/// </summary>
		public static Region LS => LSCache.Instance;

		private static class LSCache
		{
			public static readonly Region Instance = new Region("LS",  RegionCode.LS, false);
		}

		/// <summary>
		/// Lithuania
		/// added: 2005-10-16
		/// </summary>
		public static Region LT => LTCache.Instance;

		private static class LTCache
		{
			public static readonly Region Instance = new Region("LT",  RegionCode.LT, false);
		}

		/// <summary>
		/// Luxembourg
		/// added: 2005-10-16
		/// </summary>
		public static Region LU => LUCache.Instance;

		private static class LUCache
		{
			public static readonly Region Instance = new Region("LU",  RegionCode.LU, false);
		}

		/// <summary>
		/// Latvia
		/// added: 2005-10-16
		/// </summary>
		public static Region LV => LVCache.Instance;

		private static class LVCache
		{
			public static readonly Region Instance = new Region("LV",  RegionCode.LV, false);
		}

		/// <summary>
		/// Libya
		/// added: 2005-10-16
		/// </summary>
		public static Region LY => LYCache.Instance;

		private static class LYCache
		{
			public static readonly Region Instance = new Region("LY",  RegionCode.LY, false);
		}

		/// <summary>
		/// Morocco
		/// added: 2005-10-16
		/// </summary>
		public static Region MA => MACache.Instance;

		private static class MACache
		{
			public static readonly Region Instance = new Region("MA",  RegionCode.MA, false);
		}

		/// <summary>
		/// Monaco
		/// added: 2005-10-16
		/// </summary>
		public static Region MC => MCCache.Instance;

		private static class MCCache
		{
			public static readonly Region Instance = new Region("MC",  RegionCode.MC, false);
		}

		/// <summary>
		/// Moldova
		/// added: 2005-10-16
		/// </summary>
		public static Region MD => MDCache.Instance;

		private static class MDCache
		{
			public static readonly Region Instance = new Region("MD",  RegionCode.MD, false);
		}

		/// <summary>
		/// Montenegro
		/// added: 2006-10-05
		/// </summary>
		public static Region ME => MECache.Instance;

		private static class MECache
		{
			public static readonly Region Instance = new Region("ME",  RegionCode.ME, false);
		}

		/// <summary>
		/// Saint Martin (French part)
		/// added: 2007-11-02
		/// </summary>
		public static Region MF => MFCache.Instance;

		private static class MFCache
		{
			public static readonly Region Instance = new Region("MF",  RegionCode.MF, false);
		}

		/// <summary>
		/// Madagascar
		/// added: 2005-10-16
		/// </summary>
		public static Region MG => MGCache.Instance;

		private static class MGCache
		{
			public static readonly Region Instance = new Region("MG",  RegionCode.MG, false);
		}

		/// <summary>
		/// Marshall Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region MH => MHCache.Instance;

		private static class MHCache
		{
			public static readonly Region Instance = new Region("MH",  RegionCode.MH, false);
		}

		/// <summary>
		/// North Macedonia
		/// added: 2005-10-16
		/// </summary>
		public static Region MK => MKCache.Instance;

		private static class MKCache
		{
			public static readonly Region Instance = new Region("MK",  RegionCode.MK, false);
		}

		/// <summary>
		/// Mali
		/// added: 2005-10-16
		/// </summary>
		public static Region ML => MLCache.Instance;

		private static class MLCache
		{
			public static readonly Region Instance = new Region("ML",  RegionCode.ML, false);
		}

		/// <summary>
		/// Myanmar
		/// added: 2005-10-16
		/// </summary>
		public static Region MM => MMCache.Instance;

		private static class MMCache
		{
			public static readonly Region Instance = new Region("MM",  RegionCode.MM, false);
		}

		/// <summary>
		/// Mongolia
		/// added: 2005-10-16
		/// </summary>
		public static Region MN => MNCache.Instance;

		private static class MNCache
		{
			public static readonly Region Instance = new Region("MN",  RegionCode.MN, false);
		}

		/// <summary>
		/// Macao
		/// added: 2005-10-16
		/// </summary>
		public static Region MO => MOCache.Instance;

		private static class MOCache
		{
			public static readonly Region Instance = new Region("MO",  RegionCode.MO, false);
		}

		/// <summary>
		/// Northern Mariana Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region MP => MPCache.Instance;

		private static class MPCache
		{
			public static readonly Region Instance = new Region("MP",  RegionCode.MP, false);
		}

		/// <summary>
		/// Martinique
		/// added: 2005-10-16
		/// </summary>
		public static Region MQ => MQCache.Instance;

		private static class MQCache
		{
			public static readonly Region Instance = new Region("MQ",  RegionCode.MQ, false);
		}

		/// <summary>
		/// Mauritania
		/// added: 2005-10-16
		/// </summary>
		public static Region MR => MRCache.Instance;

		private static class MRCache
		{
			public static readonly Region Instance = new Region("MR",  RegionCode.MR, false);
		}

		/// <summary>
		/// Montserrat
		/// added: 2005-10-16
		/// </summary>
		public static Region MS => MSCache.Instance;

		private static class MSCache
		{
			public static readonly Region Instance = new Region("MS",  RegionCode.MS, false);
		}

		/// <summary>
		/// Malta
		/// added: 2005-10-16
		/// </summary>
		public static Region MT => MTCache.Instance;

		private static class MTCache
		{
			public static readonly Region Instance = new Region("MT",  RegionCode.MT, false);
		}

		/// <summary>
		/// Mauritius
		/// added: 2005-10-16
		/// </summary>
		public static Region MU => MUCache.Instance;

		private static class MUCache
		{
			public static readonly Region Instance = new Region("MU",  RegionCode.MU, false);
		}

		/// <summary>
		/// Maldives
		/// added: 2005-10-16
		/// </summary>
		public static Region MV => MVCache.Instance;

		private static class MVCache
		{
			public static readonly Region Instance = new Region("MV",  RegionCode.MV, false);
		}

		/// <summary>
		/// Malawi
		/// added: 2005-10-16
		/// </summary>
		public static Region MW => MWCache.Instance;

		private static class MWCache
		{
			public static readonly Region Instance = new Region("MW",  RegionCode.MW, false);
		}

		/// <summary>
		/// Mexico
		/// added: 2005-10-16
		/// </summary>
		public static Region MX => MXCache.Instance;

		private static class MXCache
		{
			public static readonly Region Instance = new Region("MX",  RegionCode.MX, false);
		}

		/// <summary>
		/// Malaysia
		/// added: 2005-10-16
		/// </summary>
		public static Region MY => MYCache.Instance;

		private static class MYCache
		{
			public static readonly Region Instance = new Region("MY",  RegionCode.MY, false);
		}

		/// <summary>
		/// Mozambique
		/// added: 2005-10-16
		/// </summary>
		public static Region MZ => MZCache.Instance;

		private static class MZCache
		{
			public static readonly Region Instance = new Region("MZ",  RegionCode.MZ, false);
		}

		/// <summary>
		/// Namibia
		/// added: 2005-10-16
		/// </summary>
		public static Region NA => NACache.Instance;

		private static class NACache
		{
			public static readonly Region Instance = new Region("NA",  RegionCode.NA, false);
		}

		/// <summary>
		/// New Caledonia
		/// added: 2005-10-16
		/// </summary>
		public static Region NC => NCCache.Instance;

		private static class NCCache
		{
			public static readonly Region Instance = new Region("NC",  RegionCode.NC, false);
		}

		/// <summary>
		/// Niger
		/// added: 2005-10-16
		/// </summary>
		public static Region NE => NECache.Instance;

		private static class NECache
		{
			public static readonly Region Instance = new Region("NE",  RegionCode.NE, false);
		}

		/// <summary>
		/// Norfolk Island
		/// added: 2005-10-16
		/// </summary>
		public static Region NF => NFCache.Instance;

		private static class NFCache
		{
			public static readonly Region Instance = new Region("NF",  RegionCode.NF, false);
		}

		/// <summary>
		/// Nigeria
		/// added: 2005-10-16
		/// </summary>
		public static Region NG => NGCache.Instance;

		private static class NGCache
		{
			public static readonly Region Instance = new Region("NG",  RegionCode.NG, false);
		}

		/// <summary>
		/// Nicaragua
		/// added: 2005-10-16
		/// </summary>
		public static Region NI => NICache.Instance;

		private static class NICache
		{
			public static readonly Region Instance = new Region("NI",  RegionCode.NI, false);
		}

		/// <summary>
		/// Netherlands
		/// added: 2005-10-16
		/// </summary>
		public static Region NL => NLCache.Instance;

		private static class NLCache
		{
			public static readonly Region Instance = new Region("NL",  RegionCode.NL, false);
		}

		/// <summary>
		/// Norway
		/// added: 2005-10-16
		/// </summary>
		public static Region NO => NOCache.Instance;

		private static class NOCache
		{
			public static readonly Region Instance = new Region("NO",  RegionCode.NO, false);
		}

		/// <summary>
		/// Nepal
		/// added: 2005-10-16
		/// </summary>
		public static Region NP => NPCache.Instance;

		private static class NPCache
		{
			public static readonly Region Instance = new Region("NP",  RegionCode.NP, false);
		}

		/// <summary>
		/// Nauru
		/// added: 2005-10-16
		/// </summary>
		public static Region NR => NRCache.Instance;

		private static class NRCache
		{
			public static readonly Region Instance = new Region("NR",  RegionCode.NR, false);
		}

		/// <summary>
		/// Neutral Zone
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("deprecated from 1993-07-12")]
		public static Region NT => NTCache.Instance;

		private static class NTCache
		{
			public static readonly Region Instance = new Region("NT",  RegionCode.NT, true);
		}

		/// <summary>
		/// Niue
		/// added: 2005-10-16
		/// </summary>
		public static Region NU => NUCache.Instance;

		private static class NUCache
		{
			public static readonly Region Instance = new Region("NU",  RegionCode.NU, false);
		}

		/// <summary>
		/// New Zealand
		/// added: 2005-10-16
		/// </summary>
		public static Region NZ => NZCache.Instance;

		private static class NZCache
		{
			public static readonly Region Instance = new Region("NZ",  RegionCode.NZ, false);
		}

		/// <summary>
		/// Oman
		/// added: 2005-10-16
		/// </summary>
		public static Region OM => OMCache.Instance;

		private static class OMCache
		{
			public static readonly Region Instance = new Region("OM",  RegionCode.OM, false);
		}

		/// <summary>
		/// Panama
		/// added: 2005-10-16
		/// </summary>
		public static Region PA => PACache.Instance;

		private static class PACache
		{
			public static readonly Region Instance = new Region("PA",  RegionCode.PA, false);
		}

		/// <summary>
		/// Peru
		/// added: 2005-10-16
		/// </summary>
		public static Region PE => PECache.Instance;

		private static class PECache
		{
			public static readonly Region Instance = new Region("PE",  RegionCode.PE, false);
		}

		/// <summary>
		/// French Polynesia
		/// added: 2005-10-16
		/// </summary>
		public static Region PF => PFCache.Instance;

		private static class PFCache
		{
			public static readonly Region Instance = new Region("PF",  RegionCode.PF, false);
		}

		/// <summary>
		/// Papua New Guinea
		/// added: 2005-10-16
		/// </summary>
		public static Region PG => PGCache.Instance;

		private static class PGCache
		{
			public static readonly Region Instance = new Region("PG",  RegionCode.PG, false);
		}

		/// <summary>
		/// Philippines
		/// added: 2005-10-16
		/// </summary>
		public static Region PH => PHCache.Instance;

		private static class PHCache
		{
			public static readonly Region Instance = new Region("PH",  RegionCode.PH, false);
		}

		/// <summary>
		/// Pakistan
		/// added: 2005-10-16
		/// </summary>
		public static Region PK => PKCache.Instance;

		private static class PKCache
		{
			public static readonly Region Instance = new Region("PK",  RegionCode.PK, false);
		}

		/// <summary>
		/// Poland
		/// added: 2005-10-16
		/// </summary>
		public static Region PL => PLCache.Instance;

		private static class PLCache
		{
			public static readonly Region Instance = new Region("PL",  RegionCode.PL, false);
		}

		/// <summary>
		/// Saint Pierre and Miquelon
		/// added: 2005-10-16
		/// </summary>
		public static Region PM => PMCache.Instance;

		private static class PMCache
		{
			public static readonly Region Instance = new Region("PM",  RegionCode.PM, false);
		}

		/// <summary>
		/// Pitcairn
		/// added: 2005-10-16
		/// </summary>
		public static Region PN => PNCache.Instance;

		private static class PNCache
		{
			public static readonly Region Instance = new Region("PN",  RegionCode.PN, false);
		}

		/// <summary>
		/// Puerto Rico
		/// added: 2005-10-16
		/// </summary>
		public static Region PR => PRCache.Instance;

		private static class PRCache
		{
			public static readonly Region Instance = new Region("PR",  RegionCode.PR, false);
		}

		/// <summary>
		/// State of Palestine
		/// added: 2005-10-16
		/// </summary>
		public static Region PS => PSCache.Instance;

		private static class PSCache
		{
			public static readonly Region Instance = new Region("PS",  RegionCode.PS, false);
		}

		/// <summary>
		/// Portugal
		/// added: 2005-10-16
		/// </summary>
		public static Region PT => PTCache.Instance;

		private static class PTCache
		{
			public static readonly Region Instance = new Region("PT",  RegionCode.PT, false);
		}

		/// <summary>
		/// Palau
		/// added: 2005-10-16
		/// </summary>
		public static Region PW => PWCache.Instance;

		private static class PWCache
		{
			public static readonly Region Instance = new Region("PW",  RegionCode.PW, false);
		}

		/// <summary>
		/// Paraguay
		/// added: 2005-10-16
		/// </summary>
		public static Region PY => PYCache.Instance;

		private static class PYCache
		{
			public static readonly Region Instance = new Region("PY",  RegionCode.PY, false);
		}

		/// <summary>
		/// Qatar
		/// added: 2005-10-16
		/// </summary>
		public static Region QA => QACache.Instance;

		private static class QACache
		{
			public static readonly Region Instance = new Region("QA",  RegionCode.QA, false);
		}

		/// <summary>
		/// Réunion
		/// added: 2005-10-16
		/// </summary>
		public static Region RE => RECache.Instance;

		private static class RECache
		{
			public static readonly Region Instance = new Region("RE",  RegionCode.RE, false);
		}

		/// <summary>
		/// Romania
		/// added: 2005-10-16
		/// </summary>
		public static Region RO => ROCache.Instance;

		private static class ROCache
		{
			public static readonly Region Instance = new Region("RO",  RegionCode.RO, false);
		}

		/// <summary>
		/// Serbia
		/// added: 2006-10-05
		/// </summary>
		public static Region RS => RSCache.Instance;

		private static class RSCache
		{
			public static readonly Region Instance = new Region("RS",  RegionCode.RS, false);
		}

		/// <summary>
		/// Russian Federation
		/// added: 2005-10-16
		/// </summary>
		public static Region RU => RUCache.Instance;

		private static class RUCache
		{
			public static readonly Region Instance = new Region("RU",  RegionCode.RU, false);
		}

		/// <summary>
		/// Rwanda
		/// added: 2005-10-16
		/// </summary>
		public static Region RW => RWCache.Instance;

		private static class RWCache
		{
			public static readonly Region Instance = new Region("RW",  RegionCode.RW, false);
		}

		/// <summary>
		/// Saudi Arabia
		/// added: 2005-10-16
		/// </summary>
		public static Region SA => SACache.Instance;

		private static class SACache
		{
			public static readonly Region Instance = new Region("SA",  RegionCode.SA, false);
		}

		/// <summary>
		/// Solomon Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region SB => SBCache.Instance;

		private static class SBCache
		{
			public static readonly Region Instance = new Region("SB",  RegionCode.SB, false);
		}

		/// <summary>
		/// Seychelles
		/// added: 2005-10-16
		/// </summary>
		public static Region SC => SCCache.Instance;

		private static class SCCache
		{
			public static readonly Region Instance = new Region("SC",  RegionCode.SC, false);
		}

		/// <summary>
		/// Sudan
		/// added: 2005-10-16
		/// </summary>
		public static Region SD => SDCache.Instance;

		private static class SDCache
		{
			public static readonly Region Instance = new Region("SD",  RegionCode.SD, false);
		}

		/// <summary>
		/// Sweden
		/// added: 2005-10-16
		/// </summary>
		public static Region SE => SECache.Instance;

		private static class SECache
		{
			public static readonly Region Instance = new Region("SE",  RegionCode.SE, false);
		}

		/// <summary>
		/// Singapore
		/// added: 2005-10-16
		/// </summary>
		public static Region SG => SGCache.Instance;

		private static class SGCache
		{
			public static readonly Region Instance = new Region("SG",  RegionCode.SG, false);
		}

		/// <summary>
		/// Saint Helena, Ascension and Tristan da Cunha
		/// added: 2005-10-16
		/// </summary>
		public static Region SH => SHCache.Instance;

		private static class SHCache
		{
			public static readonly Region Instance = new Region("SH",  RegionCode.SH, false);
		}

		/// <summary>
		/// Slovenia
		/// added: 2005-10-16
		/// </summary>
		public static Region SI => SICache.Instance;

		private static class SICache
		{
			public static readonly Region Instance = new Region("SI",  RegionCode.SI, false);
		}

		/// <summary>
		/// Svalbard and Jan Mayen
		/// added: 2005-10-16
		/// </summary>
		public static Region SJ => SJCache.Instance;

		private static class SJCache
		{
			public static readonly Region Instance = new Region("SJ",  RegionCode.SJ, false);
		}

		/// <summary>
		/// Slovakia
		/// added: 2005-10-16
		/// </summary>
		public static Region SK => SKCache.Instance;

		private static class SKCache
		{
			public static readonly Region Instance = new Region("SK",  RegionCode.SK, false);
		}

		/// <summary>
		/// Sierra Leone
		/// added: 2005-10-16
		/// </summary>
		public static Region SL => SLCache.Instance;

		private static class SLCache
		{
			public static readonly Region Instance = new Region("SL",  RegionCode.SL, false);
		}

		/// <summary>
		/// San Marino
		/// added: 2005-10-16
		/// </summary>
		public static Region SM => SMCache.Instance;

		private static class SMCache
		{
			public static readonly Region Instance = new Region("SM",  RegionCode.SM, false);
		}

		/// <summary>
		/// Senegal
		/// added: 2005-10-16
		/// </summary>
		public static Region SN => SNCache.Instance;

		private static class SNCache
		{
			public static readonly Region Instance = new Region("SN",  RegionCode.SN, false);
		}

		/// <summary>
		/// Somalia
		/// added: 2005-10-16
		/// </summary>
		public static Region SO => SOCache.Instance;

		private static class SOCache
		{
			public static readonly Region Instance = new Region("SO",  RegionCode.SO, false);
		}

		/// <summary>
		/// Suriname
		/// added: 2005-10-16
		/// </summary>
		public static Region SR => SRCache.Instance;

		private static class SRCache
		{
			public static readonly Region Instance = new Region("SR",  RegionCode.SR, false);
		}

		/// <summary>
		/// South Sudan
		/// added: 2011-08-25
		/// </summary>
		public static Region SS => SSCache.Instance;

		private static class SSCache
		{
			public static readonly Region Instance = new Region("SS",  RegionCode.SS, false);
		}

		/// <summary>
		/// Sao Tome and Principe
		/// added: 2005-10-16
		/// </summary>
		public static Region ST => STCache.Instance;

		private static class STCache
		{
			public static readonly Region Instance = new Region("ST",  RegionCode.ST, false);
		}

		/// <summary>
		/// Union of Soviet Socialist Republics
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("deprecated from 1992-08-30")]
		public static Region SU => SUCache.Instance;

		private static class SUCache
		{
			public static readonly Region Instance = new Region("SU",  RegionCode.SU, true);
		}

		/// <summary>
		/// El Salvador
		/// added: 2005-10-16
		/// </summary>
		public static Region SV => SVCache.Instance;

		private static class SVCache
		{
			public static readonly Region Instance = new Region("SV",  RegionCode.SV, false);
		}

		/// <summary>
		/// Sint Maarten (Dutch part)
		/// added: 2011-01-07
		/// </summary>
		public static Region SX => SXCache.Instance;

		private static class SXCache
		{
			public static readonly Region Instance = new Region("SX",  RegionCode.SX, false);
		}

		/// <summary>
		/// Syrian Arab Republic
		/// added: 2005-10-16
		/// </summary>
		public static Region SY => SYCache.Instance;

		private static class SYCache
		{
			public static readonly Region Instance = new Region("SY",  RegionCode.SY, false);
		}

		/// <summary>
		/// Eswatini
		/// eSwatini
		/// Swaziland
		/// added: 2005-10-16
		/// </summary>
		public static Region SZ => SZCache.Instance;

		private static class SZCache
		{
			public static readonly Region Instance = new Region("SZ",  RegionCode.SZ, false);
		}

		/// <summary>
		/// Tristan da Cunha
		/// added: 2009-07-29
		/// </summary>
		public static Region TA => TACache.Instance;

		private static class TACache
		{
			public static readonly Region Instance = new Region("TA",  RegionCode.TA, false);
		}

		/// <summary>
		/// Turks and Caicos Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region TC => TCCache.Instance;

		private static class TCCache
		{
			public static readonly Region Instance = new Region("TC",  RegionCode.TC, false);
		}

		/// <summary>
		/// Chad
		/// added: 2005-10-16
		/// </summary>
		public static Region TD => TDCache.Instance;

		private static class TDCache
		{
			public static readonly Region Instance = new Region("TD",  RegionCode.TD, false);
		}

		/// <summary>
		/// French Southern Territories
		/// added: 2005-10-16
		/// </summary>
		public static Region TF => TFCache.Instance;

		private static class TFCache
		{
			public static readonly Region Instance = new Region("TF",  RegionCode.TF, false);
		}

		/// <summary>
		/// Togo
		/// added: 2005-10-16
		/// </summary>
		public static Region TG => TGCache.Instance;

		private static class TGCache
		{
			public static readonly Region Instance = new Region("TG",  RegionCode.TG, false);
		}

		/// <summary>
		/// Thailand
		/// added: 2005-10-16
		/// </summary>
		public static Region TH => THCache.Instance;

		private static class THCache
		{
			public static readonly Region Instance = new Region("TH",  RegionCode.TH, false);
		}

		/// <summary>
		/// Tajikistan
		/// added: 2005-10-16
		/// </summary>
		public static Region TJ => TJCache.Instance;

		private static class TJCache
		{
			public static readonly Region Instance = new Region("TJ",  RegionCode.TJ, false);
		}

		/// <summary>
		/// Tokelau
		/// added: 2005-10-16
		/// </summary>
		public static Region TK => TKCache.Instance;

		private static class TKCache
		{
			public static readonly Region Instance = new Region("TK",  RegionCode.TK, false);
		}

		/// <summary>
		/// Timor-Leste
		/// added: 2005-10-16
		/// </summary>
		public static Region TL => TLCache.Instance;

		private static class TLCache
		{
			public static readonly Region Instance = new Region("TL",  RegionCode.TL, false);
		}

		/// <summary>
		/// Turkmenistan
		/// added: 2005-10-16
		/// </summary>
		public static Region TM => TMCache.Instance;

		private static class TMCache
		{
			public static readonly Region Instance = new Region("TM",  RegionCode.TM, false);
		}

		/// <summary>
		/// Tunisia
		/// added: 2005-10-16
		/// </summary>
		public static Region TN => TNCache.Instance;

		private static class TNCache
		{
			public static readonly Region Instance = new Region("TN",  RegionCode.TN, false);
		}

		/// <summary>
		/// Tonga
		/// added: 2005-10-16
		/// </summary>
		public static Region TO => TOCache.Instance;

		private static class TOCache
		{
			public static readonly Region Instance = new Region("TO",  RegionCode.TO, false);
		}

		/// <summary>
		/// East Timor
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use TL, deprecated from 2002-05-20")]
		public static Region TP => TPCache.Instance;

		private static class TPCache
		{
			public static readonly Region Instance = new Region("TP",  RegionCode.TP, true);
		}

		/// <summary>
		/// Turkey
		/// added: 2005-10-16
		/// </summary>
		public static Region TR => TRCache.Instance;

		private static class TRCache
		{
			public static readonly Region Instance = new Region("TR",  RegionCode.TR, false);
		}

		/// <summary>
		/// Trinidad and Tobago
		/// added: 2005-10-16
		/// </summary>
		public static Region TT => TTCache.Instance;

		private static class TTCache
		{
			public static readonly Region Instance = new Region("TT",  RegionCode.TT, false);
		}

		/// <summary>
		/// Tuvalu
		/// added: 2005-10-16
		/// </summary>
		public static Region TV => TVCache.Instance;

		private static class TVCache
		{
			public static readonly Region Instance = new Region("TV",  RegionCode.TV, false);
		}

		/// <summary>
		/// Taiwan, Province of China
		/// added: 2005-10-16
		/// </summary>
		public static Region TW => TWCache.Instance;

		private static class TWCache
		{
			public static readonly Region Instance = new Region("TW",  RegionCode.TW, false);
		}

		/// <summary>
		/// United Republic of Tanzania
		/// added: 2005-10-16
		/// </summary>
		public static Region TZ => TZCache.Instance;

		private static class TZCache
		{
			public static readonly Region Instance = new Region("TZ",  RegionCode.TZ, false);
		}

		/// <summary>
		/// Ukraine
		/// added: 2005-10-16
		/// </summary>
		public static Region UA => UACache.Instance;

		private static class UACache
		{
			public static readonly Region Instance = new Region("UA",  RegionCode.UA, false);
		}

		/// <summary>
		/// Uganda
		/// added: 2005-10-16
		/// </summary>
		public static Region UG => UGCache.Instance;

		private static class UGCache
		{
			public static readonly Region Instance = new Region("UG",  RegionCode.UG, false);
		}

		/// <summary>
		/// United States Minor Outlying Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region UM => UMCache.Instance;

		private static class UMCache
		{
			public static readonly Region Instance = new Region("UM",  RegionCode.UM, false);
		}

		/// <summary>
		/// United Nations
		/// added: 2016-07-14
		/// </summary>
		public static Region UN => UNCache.Instance;

		private static class UNCache
		{
			public static readonly Region Instance = new Region("UN",  RegionCode.UN, false);
		}

		/// <summary>
		/// United States
		/// added: 2005-10-16
		/// </summary>
		public static Region US => USCache.Instance;

		private static class USCache
		{
			public static readonly Region Instance = new Region("US",  RegionCode.US, false);
		}

		/// <summary>
		/// Uruguay
		/// added: 2005-10-16
		/// </summary>
		public static Region UY => UYCache.Instance;

		private static class UYCache
		{
			public static readonly Region Instance = new Region("UY",  RegionCode.UY, false);
		}

		/// <summary>
		/// Uzbekistan
		/// added: 2005-10-16
		/// </summary>
		public static Region UZ => UZCache.Instance;

		private static class UZCache
		{
			public static readonly Region Instance = new Region("UZ",  RegionCode.UZ, false);
		}

		/// <summary>
		/// Holy See (Vatican City State)
		/// added: 2005-10-16
		/// </summary>
		public static Region VA => VACache.Instance;

		private static class VACache
		{
			public static readonly Region Instance = new Region("VA",  RegionCode.VA, false);
		}

		/// <summary>
		/// Saint Vincent and the Grenadines
		/// added: 2005-10-16
		/// </summary>
		public static Region VC => VCCache.Instance;

		private static class VCCache
		{
			public static readonly Region Instance = new Region("VC",  RegionCode.VC, false);
		}

		/// <summary>
		/// Venezuela
		/// added: 2005-10-16
		/// </summary>
		public static Region VE => VECache.Instance;

		private static class VECache
		{
			public static readonly Region Instance = new Region("VE",  RegionCode.VE, false);
		}

		/// <summary>
		/// British Virgin Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region VG => VGCache.Instance;

		private static class VGCache
		{
			public static readonly Region Instance = new Region("VG",  RegionCode.VG, false);
		}

		/// <summary>
		/// U.S. Virgin Islands
		/// added: 2005-10-16
		/// </summary>
		public static Region VI => VICache.Instance;

		private static class VICache
		{
			public static readonly Region Instance = new Region("VI",  RegionCode.VI, false);
		}

		/// <summary>
		/// Viet Nam
		/// added: 2005-10-16
		/// </summary>
		public static Region VN => VNCache.Instance;

		private static class VNCache
		{
			public static readonly Region Instance = new Region("VN",  RegionCode.VN, false);
		}

		/// <summary>
		/// Vanuatu
		/// added: 2005-10-16
		/// </summary>
		public static Region VU => VUCache.Instance;

		private static class VUCache
		{
			public static readonly Region Instance = new Region("VU",  RegionCode.VU, false);
		}

		/// <summary>
		/// Wallis and Futuna
		/// added: 2005-10-16
		/// </summary>
		public static Region WF => WFCache.Instance;

		private static class WFCache
		{
			public static readonly Region Instance = new Region("WF",  RegionCode.WF, false);
		}

		/// <summary>
		/// Samoa
		/// added: 2005-10-16
		/// </summary>
		public static Region WS => WSCache.Instance;

		private static class WSCache
		{
			public static readonly Region Instance = new Region("WS",  RegionCode.WS, false);
		}

		/// <summary>
		/// Democratic Yemen
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use YE, deprecated from 1990-08-14")]
		public static Region YD => YDCache.Instance;

		private static class YDCache
		{
			public static readonly Region Instance = new Region("YD",  RegionCode.YD, true);
		}

		/// <summary>
		/// Yemen
		/// added: 2005-10-16
		/// </summary>
		public static Region YE => YECache.Instance;

		private static class YECache
		{
			public static readonly Region Instance = new Region("YE",  RegionCode.YE, false);
		}

		/// <summary>
		/// Mayotte
		/// added: 2005-10-16
		/// </summary>
		public static Region YT => YTCache.Instance;

		private static class YTCache
		{
			public static readonly Region Instance = new Region("YT",  RegionCode.YT, false);
		}

		/// <summary>
		/// Yugoslavia
		/// see BA, HR, ME, MK, RS, or SI
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("see BA, HR, ME, MK, RS, or SI, deprecated from 2003-07-23")]
		public static Region YU => YUCache.Instance;

		private static class YUCache
		{
			public static readonly Region Instance = new Region("YU",  RegionCode.YU, true);
		}

		/// <summary>
		/// South Africa
		/// added: 2005-10-16
		/// </summary>
		public static Region ZA => ZACache.Instance;

		private static class ZACache
		{
			public static readonly Region Instance = new Region("ZA",  RegionCode.ZA, false);
		}

		/// <summary>
		/// Zambia
		/// added: 2005-10-16
		/// </summary>
		public static Region ZM => ZMCache.Instance;

		private static class ZMCache
		{
			public static readonly Region Instance = new Region("ZM",  RegionCode.ZM, false);
		}

		/// <summary>
		/// Zaire
		/// added: 2005-10-16
		/// </summary>
		[Obsolete("use CD, deprecated from 1997-07-14")]
		public static Region ZR => ZRCache.Instance;

		private static class ZRCache
		{
			public static readonly Region Instance = new Region("ZR",  RegionCode.ZR, true);
		}

		/// <summary>
		/// Zimbabwe
		/// added: 2005-10-16
		/// </summary>
		public static Region ZW => ZWCache.Instance;

		private static class ZWCache
		{
			public static readonly Region Instance = new Region("ZW",  RegionCode.ZW, false);
		}

	}
}