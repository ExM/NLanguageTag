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
				Assert.That(region, Is.Not.Null);
				Assert.That(region!.PrivateUse, Is.False);
			}
		}

		[Test]
		public void CheckPublicCodes()
		{
			foreach (var code in Enum.GetValues(typeof(RegionCode)).Cast<RegionCode>()
				.Where(_ => _ != RegionCode.PrivateUse))
			{
				var region = Region.ByCode(code);
				Assert.That(region.EnumCode, Is.EqualTo(code));
			}
		}

		[TestCaseSource(nameof(parseCases))]
		public void Parse(string text, Region expected)
		{
			Assert.That(text.TryParseRegion(), Is.EqualTo(expected));
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

			Assert.That(region!.PrivateUse, Is.True);
			Assert.That(region.EnumCode, Is.EqualTo(RegionCode.PrivateUse));
			Assert.That(text.TryParseRegion(), Is.EqualTo(region));
		}

		internal static IEnumerable<TestCaseData> parseCases()
		{
			yield return new TestCaseData("xxx", null);
			yield return new TestCaseData("RU", Region.RU);
			yield return new TestCaseData("gb", Region.GB);
		}
	}
}