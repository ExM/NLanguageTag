using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	[TestFixture]
	public class RegionTests
	{
		[TestCaseSource("allRegions")]
		public void ToString_Parse(Region region)
		{
			var text = region.ToText();
			Assert.AreEqual(region, text.ParseFromRegion());
		}

		private IEnumerable<Region> allRegions()
		{
			return Enum.GetValues(typeof(Region)).Cast<Region>();
		}

		[TestCase("RU", Region.RU)]
		[TestCase("gb", Region.GB)]
		public void ParseFromRegion(string text, Region expected)
		{
			Assert.AreEqual(expected, text.ParseFromRegion());
		}

		[TestCase("xxx")]
		[TestCase("xxx-xxx")]
		[TestCase("xxx-")]
		[ExpectedException(typeof(FormatException))]
		public void ParseFromRegion_Fail(string text)
		{
			text.ParseFromRegion();
		}

		[TestCase("???-xxx-xx", 4, null, 4)]
		[TestCase("???-GB", 4, Region.GB, 6)]
		[TestCase("???-gb-", 4, Region.GB, 7)]
		[TestCase("???-GB-xx", 4, Region.GB, 7)]
		public void TryParseFromRegionToken(string text, int begin, Region? expected, int expNextToken)
		{
			int nextToken = begin;
			Assert.AreEqual(expected, text.TryParseFromRegionToken(ref nextToken));
			Assert.AreEqual(expNextToken, nextToken);
		}
	}
}
