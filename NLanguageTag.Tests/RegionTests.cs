using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class RegionTests
	{
		[Test]
		public void CheckParseSwitches()
		{
			foreach (var text in TestContent.GetRegions())
			{
				var region = text.TryParseRegion();
				Assert.NotNull(region);
				Assert.IsFalse(region!.PrivateUse);
			}
		}

		[Test]
		public void CheckPublicCodes()
		{
			foreach (var code in Enum.GetValues(typeof(RegionCode)).Cast<RegionCode>()
				.Where(_ => _ != RegionCode.PrivateUse))
			{
				var region = Region.ByCode(code);
				Assert.AreEqual(code, region.EnumCode);
			}
		}

		[TestCaseSource(nameof(parseCases))]
		public void Parse(string text, Region expected)
		{
			Assert.AreEqual(expected, text.TryParseRegion());
		}

		[TestCase("XB")]
		[TestCase("Xb")]
		[TestCase("aa")]
		[TestCase("zz")]
		[TestCase("qz")]
		[TestCase("XZ")]
		public void ParsePrivateUse(string text)
		{
			var region = text.TryParseRegion();

			Assert.IsTrue(region!.PrivateUse);
			Assert.AreEqual(RegionCode.PrivateUse, region.EnumCode);
			Assert.AreEqual(region, text.TryParseRegion());
		}

		internal static IEnumerable<TestCaseData> parseCases()
		{
			yield return new TestCaseData("xxx", null);
			yield return new TestCaseData("RU", Region.RU);
			yield return new TestCaseData("gb", Region.GB);
		}
	}
}