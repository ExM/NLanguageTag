using NUnit.Framework;
using System;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ExtensionSubtagTests
	{
		[TestCase(null)]
		[TestCase((object)(new string[0]))]
		public void EmptyCtor(string[] sequence)
		{
			Assert.Throws<FormatException>(() => new ExtensionSubtag('a', sequence));
		}

		[Test]
		public void Empty()
		{
			var empty = new ExtensionSubtag();
			Assert.IsTrue(empty.IsEmpty);
			Assert.AreEqual("", empty.ToString());
			Assert.That(empty.ToArray(), Is.Empty);
		}

		[TestCase("a-bbb", 'a', new string[] { "bbb" })]
		[TestCase("a-bbb-ccc", 'a', new string[] { "bbb", "ccc" })]
		public void ParseFromExtensionSubtag(string text, char singleton, string[] subtags)
		{
			Assert.AreEqual(new ExtensionSubtag(singleton, subtags), text.ParseFromExtensionSubtag());
		}

		[TestCase("")]
		[TestCase("a-bbbbbbbbbbbbbbbbbbbbb")]
		[TestCase("a-bbb-")]
		[TestCase("a-b")]
		[TestCase("a-")]
		[TestCase("a-a?a")]
		[TestCase("x-aaa")]
		[TestCase("aaa")]
		public void ParseFromExtensionSubtagFail(string text)
		{
			Assert.Throws<FormatException>(() => text.ParseFromExtensionSubtag());
		}

		[TestCase(new string[] { "aaa" }, "a-aaa")]
		[TestCase(new string[] { "aaa", "bbb" }, "a-aaa-bbb")]
		public void ToString(string[] subtags, string expected)
		{
			var ext = new ExtensionSubtag('a', subtags);
			Assert.AreEqual(expected, ext.ToString());
		}

		[TestCase((object)new string[] { "aaa" })]
		[TestCase((object)new string[] { "aaa", "bbb" })]
		public void Enumerate(string[] subtags)
		{
			var ext = new ExtensionSubtag('a', subtags);
			Assert.That(ext, Is.EquivalentTo(subtags));
		}

		[Test]
		public void Equals()
		{
			var ext1 = new ExtensionSubtag();
			var ext2 = new ExtensionSubtag();

			var ext3 = new ExtensionSubtag('a', "aaa");
			var ext4 = new ExtensionSubtag('a', "aaa");

			var ext5 = new ExtensionSubtag('b', "aaa");
			var ext6 = new ExtensionSubtag('b', "bbb");

			Assert.IsFalse(ext1.Equals(null));
			Assert.IsTrue(ext1.Equals((object)ext2));
			Assert.IsTrue(ext1.Equals(ext1));
			Assert.IsTrue(ext1.Equals(ext2));
			Assert.IsFalse(ext1.Equals(ext3));
			Assert.IsTrue(ext3.Equals(ext3));
			Assert.IsTrue(ext3.Equals(ext4));
			Assert.IsFalse(ext4.Equals(ext5));
			Assert.IsFalse(ext5.Equals(ext6));

			Assert.IsTrue(ext1 == ext2);
			Assert.IsFalse(ext1 != ext2);

			Assert.IsTrue(ext3 != ext5);
			Assert.IsFalse(ext3 == ext5);
		}
	}
}
