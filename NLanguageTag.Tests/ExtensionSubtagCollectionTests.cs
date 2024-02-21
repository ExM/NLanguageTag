using NUnit.Framework;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class ExtensionSubtagCollectionTests
	{
		[Test]
		public void Equals()
		{
			var ext1 = new ExtensionSubtagCollection();
			var ext2 = new ExtensionSubtagCollection();

			var ext3 = new ExtensionSubtagCollection(new ExtensionSubtag('a', "aaa"));
			var ext4 = new ExtensionSubtagCollection(new ExtensionSubtag('a', "aaa"));

			var ext5 = new ExtensionSubtagCollection(new ExtensionSubtag('a', "aaa"), new ExtensionSubtag('b', "aaa"));

			Assert.That(ext1.Equals(null), Is.False);
			Assert.That(ext1.Equals((object)ext2), Is.True);
			Assert.That(ext1, Is.EqualTo(ext1));
			Assert.That(ext2, Is.EqualTo(ext1));
			Assert.That(ext3, Is.Not.EqualTo(ext1));
			Assert.That(ext3, Is.EqualTo(ext3));
			Assert.That(ext4, Is.EqualTo(ext3));
			Assert.That(ext5, Is.Not.EqualTo(ext4));

			Assert.That(ext1 == ext2, Is.True);
			Assert.That(ext1 != ext2, Is.False);

			Assert.That(ext3 != ext5, Is.True);
			Assert.That(ext3 == ext5, Is.False);
		}
	}
}