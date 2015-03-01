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

		[TestCase("", "aaa", false)]
		[TestCase("x-aaa-bbb", "x", false)]
		[TestCase("x-aaa-bbb", "aaa", true)]
		[TestCase("x-aaa-bbb", "bbb", true)]
		public void Contains(string subtagText, string tag, bool expected)
		{
			Assert.That(PrivateUseSubtags.Parse(subtagText).Contains(tag), Is.EqualTo(expected));
		}

		[TestCase("", new string[] {})]
		[TestCase("x-aaa", new string[] { "aaa" })]
		[TestCase("x-aaa-bbb", new string[] { "aaa", "bbb" })]
		public void TryParse(string text, string[] subtags)
		{
			var pu1 = PrivateUseSubtags.TryParse(text);
			Assert.That(pu1.Value, Is.EquivalentTo(subtags));

			PrivateUseSubtags pu2;
			Assert.That(PrivateUseSubtags.TryParse(text, out pu2), Is.True);
			Assert.That(pu2, Is.EquivalentTo(subtags));

			Assert.That(pu1, Is.EqualTo(pu2));
		}

		[TestCase("x-aaa-")]
		[TestCase("x-")]
		[TestCase("x")]
		[ExpectedException(typeof(FormatException))]
		public void ParseFail(string text)
		{
			var pu1 = PrivateUseSubtags.TryParse(text);
			Assert.That(pu1.HasValue, Is.False);

			PrivateUseSubtags pu2;
			Assert.That(PrivateUseSubtags.TryParse(text, out pu2), Is.False);

			PrivateUseSubtags.Parse(text);
		}

		[Test]
		public void Equals()
		{
			var tag1 = new PrivateUseSubtags();
			var tag2 = PrivateUseSubtags.Parse("");

			var tag3 = PrivateUseSubtags.Parse("x-aaa");
			var tag4 = PrivateUseSubtags.Parse("x-aaa");

			var tag5 = PrivateUseSubtags.Parse("x-aaa-bbb");

			Assert.IsFalse(tag1.Equals(null));
			Assert.IsTrue(tag1.Equals((object)tag2));
			Assert.AreEqual(tag1, tag1);
			Assert.AreEqual(tag1, tag2);
			Assert.AreNotEqual(tag1, tag3);
			Assert.AreEqual(tag3, tag3);
			Assert.AreEqual(tag3, tag4);
			Assert.AreNotEqual(tag4, tag5);
		}
	}
}
