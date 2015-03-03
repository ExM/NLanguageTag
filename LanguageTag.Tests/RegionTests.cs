using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class RegionTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetRegions())
			{
				var region = text.TryParseFromRegion().Value;
				
				Assert.NotNull(region.ToText());
			}
		}

		[Test]
		[ExpectedException(typeof(NotImplementedException))]
		public void ToTextFail()
		{
			var en = (Region)(-1);
			en.ToText();
		}

		[TestCase("xxx", null)]
		[TestCase("RU", Region.RU)]
		[TestCase("gb", Region.GB)]
		public void ParseFromRegion(string text, Region? expected)
		{
			Assert.AreEqual(expected, text.TryParseFromRegion());
		}
	}
}
