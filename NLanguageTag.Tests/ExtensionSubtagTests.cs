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
			Assert.Throws<InvalidOperationException>(() => empty.Singleton.GetHashCode());
		}

		[TestCase("a-12", 'a', new[] { "12" })]
		[TestCase("a-12345678", 'a', new[] { "12345678" })]
		[TestCase("a-bbb", 'a', new[] { "bbb" })]
		[TestCase("a-bbb-ccc", 'a', new[] { "bbb", "ccc" })]
		[TestCase("x-1", 'x', new [] { "1" })]
		[TestCase("x-12345678", 'x', new [] { "12345678" })]
		[TestCase("x-aaa", 'x', new [] { "aaa" })]
		[TestCase("x-aaa-bbb", 'x', new [] { "aaa", "bbb" })]
		public void TryParse(string text, char singleton, string[] subtags)
		{
			var pu1 = ExtensionSubtag.TryParse(text);
			Assert.IsTrue(pu1.HasValue);
			Assert.That(pu1!.Value.Singleton, Is.EqualTo(singleton));
			Assert.That(pu1, Is.EquivalentTo(subtags));

			Assert.That(ExtensionSubtag.TryParse(text, out var pu2), Is.True);
			Assert.That(pu2.Singleton, Is.EqualTo(singleton));
			Assert.That(pu2, Is.EquivalentTo(subtags));

			Assert.That(pu1, Is.EqualTo(pu2));

			foreach (var language in TestContent.GetLanguages())
			{
				var languageTag = LanguageTag.TryParse($"{language}-{text}");
				Assert.IsNotNull(languageTag);

				if (singleton == 'x')
					Assert.AreEqual(
						languageTag!.Value.PrivateUse,
						new ExtensionSubtag(singleton, subtags));
				else
					CollectionAssert.AreEqual(
						languageTag!.Value.Extensions,
						new[] { new ExtensionSubtag(singleton, subtags) });
			}
		}

		[TestCase("x-aaa-")]
		[TestCase("x-123456789")]
		[TestCase("x-")]
		[TestCase("x")]
		[TestCase("")]
		[TestCase("a-123456789")]
		[TestCase("a-bbb-")]
		[TestCase("a-b")]
		[TestCase("a-")]
		[TestCase("a-a?a")]
		[TestCase("aaa")]
		public void ParseFail(string text)
		{
			var pu1 = ExtensionSubtag.TryParse(text);
			Assert.That(pu1.HasValue, Is.False);

			Assert.That(ExtensionSubtag.TryParse(text, out _), Is.False);

			Assert.Throws<FormatException>(() => ExtensionSubtag.Parse(text));
		}

		[TestCase("")]
		[TestCase("a-123456789")]
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

		[TestCase('a', new[] { "aaa" }, "a-aaa")]
		[TestCase('a', new[] { "aaa", "bbb" }, "a-aaa-bbb")]
		[TestCase('x', new[] { "aaa" }, "x-aaa")]
		public void ToString(char singleton, string[] subtags, string expected)
		{
			var ext = new ExtensionSubtag(singleton, subtags);
			Assert.AreEqual(expected, ext.ToString());
		}

		[Test]
		public void PrivateUse()
		{
			var ext = ExtensionSubtag.ForPrivateUse("aaa");
			Assert.IsTrue(ext.PrivateUse);
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
			var e1 = new ExtensionSubtag();
			var e2 = (object)e1;

			var ext1 = new ExtensionSubtag('a', "aaa");
			var ext2 = new ExtensionSubtag('a', "aaa");

			var ext3 = new ExtensionSubtag('b', "aaa");
			var ext4 = new ExtensionSubtag('x', "bbb");

			Assert.IsFalse(e1.Equals(null));
			Assert.IsTrue(e1.Equals(e2));
			Assert.AreEqual(e1, e1);
			Assert.AreNotEqual(e1, ext1);

			Assert.IsTrue(ext1.Equals(ext1));
			Assert.IsTrue(ext1.Equals(ext2));
			Assert.IsFalse(ext2.Equals(ext3));
			Assert.IsFalse(ext3.Equals(ext4));

			Assert.IsTrue(ext1 != ext3);
			Assert.IsFalse(ext1 == ext3);
		}

		[TestCase(null, "aaa", false)]
		[TestCase("x-aaa-bbb", null, false)]
		[TestCase("x-aaa-bbb", "x", false)]
		[TestCase("x-aaa-bbb", "aaa", true)]
		[TestCase("x-aaa-bbb", "bbb", true)]
		[TestCase("a-aaa-bbb", null, false)]
		[TestCase("a-aaa-bbb", "a", false)]
		[TestCase("a-aaa-bbb", "aaa", true)]
		[TestCase("a-aaa-bbb", "bbb", true)]
		public void Contains(string? subtagText, string tag, bool expected)
		{
			var pu = subtagText == null ? new ExtensionSubtag() : ExtensionSubtag.Parse(subtagText);
			Assert.That(pu.Contains(tag), Is.EqualTo(expected));
		}
	}
}