using NUnit.Framework;
using System;

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
			Assert.Throws<InvalidOperationException>(() => empty.ToString());
			Assert.Throws<InvalidOperationException>(() => empty.Singleton.GetHashCode());
		}

		[TestCase("a-bbb", 'a', new[] { "bbb" })]
		[TestCase("a-bbb-ccc", 'a', new[] { "bbb", "ccc" })]
		public void ParseFromExtensionSubtag(string text, char singleton, string[] subtags)
		{
			foreach (var language in TestContent.GetLanguages())
			{
				var languageTag = LanguageTag.TryParse($"{language}-{text}");
				Assert.IsNotNull(languageTag);
				CollectionAssert.AreEqual(
					languageTag!.Value.Extensions,
					new[] { new ExtensionSubtag(singleton, subtags) });
			}
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
			foreach (var language in TestContent.GetLanguages())
			{
				var languageTag = LanguageTag.TryParse($"{language}-{text}");
				if (languageTag.HasValue)
				{
					CollectionAssert.IsEmpty(languageTag.Value.Extensions);
				}
			}
		}

		[TestCase(new[] { "aaa" }, "a-aaa")]
		[TestCase(new[] { "aaa", "bbb" }, "a-aaa-bbb")]
		public void ToString(string[] subtags, string expected)
		{
			var ext = new ExtensionSubtag('a', subtags);
			Assert.AreEqual(expected, ext.ToString());
		}

		[TestCase((object)new[] { "aaa" })]
		[TestCase((object)new[] { "aaa", "bbb" })]
		public void Enumerate(string[] subtags)
		{
			var ext = new ExtensionSubtag('a', subtags);
			Assert.That(ext, Is.EquivalentTo(subtags));
		}

		[Test]
		public void Equals()
		{
			var ext1 = new ExtensionSubtag('a', "aaa");
			var ext2 = new ExtensionSubtag('a', "aaa");

			var ext3 = new ExtensionSubtag('b', "aaa");
			var ext4 = new ExtensionSubtag('b', "bbb");

			Assert.IsTrue(ext1.Equals(ext1));
			Assert.IsTrue(ext1.Equals(ext2));
			Assert.IsFalse(ext2.Equals(ext3));
			Assert.IsFalse(ext3.Equals(ext4));

			Assert.IsTrue(ext1 != ext3);
			Assert.IsFalse(ext1 == ext3);
		}
	}
}