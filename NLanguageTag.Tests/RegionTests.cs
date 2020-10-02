using NUnit.Framework;
using System;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class RegionTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetRegions())
			{
				var region = text.TryParseRegion();
				Assert.NotNull(region);
				Assert.NotNull(region!.Value.ToText());
			}
		}

		[Test]
		public void ToTextFail()
		{
			Assert.Throws<NotImplementedException>(() =>
			{
				var en = (Region)(-1);
				en.ToText();
			});
		}

		[TestCase("xxx", null)]
		[TestCase("RU", Region.RU)]
		[TestCase("gb", Region.GB)]
		public void ParseFromRegion(string text, Region? expected)
		{
			Assert.AreEqual(expected, text.TryParseRegion());
		}
	}
}
