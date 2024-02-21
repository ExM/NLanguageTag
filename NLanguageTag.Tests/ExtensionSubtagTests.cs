using NUnit.Framework;
using System;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ExtensionSubtagTests
	{
		[Test]
		public void CtorWithEmptyArgs()
		{
			Assert.Throws<FormatException>(() => new ExtensionSubtag('a'));
		}
		
		[Test]
		public void CtorWithNull()
		{
			string[] args = null!;
			Assert.Throws<FormatException>(() => new ExtensionSubtag('a', args));
		}

		[Test]
		public void Empty()
		{
			var empty = new ExtensionSubtag();
			Assert.That(empty.IsEmpty, Is.True);
			Assert.That(empty.ToString(), Is.EqualTo(""));
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
			Assert.That(pu1.HasValue, Is.True);
			Assert.That(pu1!.Value.Singleton, Is.EqualTo(singleton));
			Assert.That(pu1, Is.EquivalentTo(subtags));

			Assert.That(ExtensionSubtag.TryParse(text, out var pu2), Is.True);
			Assert.That(pu2.Singleton, Is.EqualTo(singleton));
			Assert.That(pu2, Is.EquivalentTo(subtags));

			Assert.That(pu1, Is.EqualTo(pu2));

			foreach (var language in TestContent.GetLanguages())
			{
				var languageTag = LanguageTag.TryParse($"{language}-{text}");
				Assert.That(languageTag, Is.Not.Null);

				if (singleton == 'x')
					Assert.That(new ExtensionSubtag(singleton, subtags), Is.EqualTo(languageTag!.Value.PrivateUse));
				else
					Assert.That(new[] { new ExtensionSubtag(singleton, subtags) }, Is.EqualTo(languageTag!.Value.Extensions));
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
					Assert.That(languageTag.Value.Extensions, Is.Empty);
				}
			}
		}

		[TestCase('a', new[] { "aaa" }, "a-aaa")]
		[TestCase('a', new[] { "aaa", "bbb" }, "a-aaa-bbb")]
		[TestCase('x', new[] { "aaa" }, "x-aaa")]
		public void ToString(char singleton, string[] subtags, string expected)
		{
			var ext = new ExtensionSubtag(singleton, subtags);
			Assert.That(ext.ToString(), Is.EqualTo(expected));
		}

		[Test]
		public void PrivateUse()
		{
			var ext = ExtensionSubtag.ForPrivateUse("aaa");
			Assert.That(ext.PrivateUse, Is.True);
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

			Assert.That(e1.Equals(null), Is.False);
			Assert.That(e1.Equals(e2), Is.True);
			Assert.That(e1, Is.EqualTo(e1));
			Assert.That(ext1, Is.Not.EqualTo(e1));

			Assert.That(ext1.Equals(ext1), Is.True);
			Assert.That(ext1.Equals(ext2), Is.True);
			Assert.That(ext2.Equals(ext3), Is.False);
			Assert.That(ext3.Equals(ext4), Is.False);

			Assert.That(ext1 != ext3, Is.True);
			Assert.That(ext1 == ext3, Is.False);
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