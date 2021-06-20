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

			Assert.IsFalse(ext1.Equals(null));
			Assert.IsTrue(ext1.Equals((object)ext2));
			Assert.AreEqual(ext1, ext1);
			Assert.AreEqual(ext1, ext2);
			Assert.AreNotEqual(ext1, ext3);
			Assert.AreEqual(ext3, ext3);
			Assert.AreEqual(ext3, ext4);
			Assert.AreNotEqual(ext4, ext5);

			Assert.IsTrue(ext1 == ext2);
			Assert.IsFalse(ext1 != ext2);

			Assert.IsTrue(ext3 != ext5);
			Assert.IsFalse(ext3 == ext5);
		}
	}
}