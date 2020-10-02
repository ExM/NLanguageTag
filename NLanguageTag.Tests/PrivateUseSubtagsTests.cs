using NUnit.Framework;
using System;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class PrivateUseSubtagsTests
	{
		[Test]
		public void Empty()
		{
			var empty = new PrivateUseSubtags();
			Assert.IsTrue(empty.IsEmpty);
			Assert.AreEqual("", empty.ToString());
			Assert.That(empty.ToArray(), Is.Empty);
		}

		[TestCase(new [] { "aaa" }, "x-aaa")]
		[TestCase(new [] { "aaa", "bbb" }, "x-aaa-bbb")]
		public void ToText(string[] args, string expected)
		{
			Assert.That(new PrivateUseSubtags(args).ToString(), Is.EqualTo(expected));
		}

		[TestCase(null, "aaa", false)]
		[TestCase("x-aaa-bbb", null, false)]
		[TestCase("x-aaa-bbb", "x", false)]
		[TestCase("x-aaa-bbb", "aaa", true)]
		[TestCase("x-aaa-bbb", "bbb", true)]
		public void Contains(string? subtagText, string tag, bool expected)
		{
			var pu = subtagText is null ? new PrivateUseSubtags() : PrivateUseSubtags.Parse(subtagText);
			Assert.That(pu.Contains(tag), Is.EqualTo(expected));
		}

		[TestCase("x-aaa", new [] { "aaa" })]
		[TestCase("x-aaa-bbb", new [] { "aaa", "bbb" })]
		public void TryParse(string text, string[] subtags)
		{
			var pu1 = PrivateUseSubtags.TryParse(text);
			Assert.That(pu1, Is.EquivalentTo(subtags));

			Assert.That(PrivateUseSubtags.TryParse(text, out var pu2), Is.True);
			Assert.That(pu2, Is.EquivalentTo(subtags));

			Assert.That(pu1, Is.EqualTo(pu2));
		}

		[TestCase("x-aaa-")]
		[TestCase("x-")]
		[TestCase("x")]
		public void ParseFail(string text)
		{
			var pu1 = PrivateUseSubtags.TryParse(text);
			Assert.That(pu1.HasValue, Is.False);

			Assert.That(PrivateUseSubtags.TryParse(text, out _), Is.False);

			Assert.Throws<FormatException>(() => PrivateUseSubtags.Parse(text));
		}

		[Test]
		public void Equals()
		{
			var tag1 = new PrivateUseSubtags();
			var tag2 = (object)tag1;

			var tag3 = PrivateUseSubtags.Parse("x-aaa");
			var tag4 = (object)PrivateUseSubtags.Parse("x-aaa");

			var tag5 = PrivateUseSubtags.Parse("x-aaa-bbb");

			Assert.IsFalse(tag1.Equals(null));
			Assert.IsTrue(tag1.Equals(tag2));
			Assert.AreEqual(tag1, tag1);
			Assert.AreNotEqual(tag1, tag3);
			Assert.AreEqual(tag3, tag3);
			Assert.AreEqual(tag3, tag4);
			Assert.AreNotEqual(tag4, tag5);
		}
	}
}
