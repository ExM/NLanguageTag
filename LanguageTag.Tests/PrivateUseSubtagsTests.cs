using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class PrivateUseSubtagsTests
	{
		[TestCase(null, "")]
		[TestCase(new string[] {}, "")]
		[TestCase(new string[] { "aaa" }, "x-aaa")]
		[TestCase(new string[] { "aaa", "bbb" }, "x-aaa-bbb")]
		public void ToText(string[] args, string expected)
		{
			Assert.That(new PrivateUseSubtags(args).ToString(), Is.EqualTo(expected));
		}


	}
}
