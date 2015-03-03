using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization.Bcp47
{
	[TestFixture]
	public class VariantTests
	{
		[Test]
		public void CheckSwitches()
		{
			foreach (var text in TestContent.GetVariants())
			{
				var variant = text.TryParseFromVariant().Value;
				variant.GetPrefixes();
				Assert.NotNull(variant.ToText());
			}
		}

		[Test]
		[ExpectedException(typeof(NotImplementedException))]
		public void GetPrefixesFail()
		{
			var variant = (Variant)(-1);
			variant.GetPrefixes();
		}

		[Test]
		[ExpectedException(typeof(NotImplementedException))]
		public void ToTextFail()
		{
			var variant = (Variant)(-1);
			variant.ToText();
		}

		[TestCase("xxx", null)]
		[TestCase("aluku", Variant.Aluku)]
		[TestCase("1901", Variant.V1901)]
		public void ParseFromVariant(string text, Variant? expected)
		{
			Assert.AreEqual(expected, text.TryParseFromVariant());
		}

		[TestCase("sr", Variant.Ekavsk, true)]
		[TestCase("sr-Cyrl", Variant.Ekavsk, true)]
		[TestCase("sr-Hans", Variant.Ekavsk, null)]
		[TestCase("en", Variant.Ekavsk, null)]
		[TestCase("sr", Variant.Fonipa, false)]
		[TestCase("sr-Cyrl", Variant.Fonipa, false)]
		[TestCase("sr-Hans", Variant.Fonipa, false)]
		[TestCase("az", Variant.Baku1926, true)]
		[TestCase("en", Variant.Baku1926, null)]
		[TestCase("en-fonipa", Variant.Scotland, true)]
		[TestCase("sl", Variant.V1994, null)]
		[TestCase("en-scotland", Variant.Fonipa, false)]
		[TestCase("sl-rozaj-biske-fonipa", Variant.V1994, null)]
		[TestCase("sl-rozaj-biske", Variant.V1994, true)]
		public void RestrictiveAcceptableFor(string tagText, Variant variant, bool? expected)
		{
			var tag = new LanguageTag(tagText);
			Assert.AreEqual(expected, variant.RestrictiveAcceptableFor(tag.Language, tag.Script, tag.Variants));
		}

		[Test]
		public void Equals()
		{
			var vc1 = new VariantCollection();
			var vc2 = new VariantCollection();

			var vc3 = new VariantCollection(Variant.Alalc97, Variant.Aluku);
			var vc4 = new VariantCollection(Variant.Alalc97, Variant.Aluku);

			var vc5 = new VariantCollection(Variant.Alalc97);

			Assert.IsFalse(vc1.Equals(null));
			Assert.IsTrue(vc1.Equals((object)vc2));
			Assert.AreEqual(vc1, vc1);
			Assert.AreEqual(vc1, vc2);
			Assert.AreNotEqual(vc1, vc3);
			Assert.AreEqual(vc3, vc3);
			Assert.AreEqual(vc3, vc4);
			Assert.AreNotEqual(vc4, vc5);

			Assert.IsTrue(vc1 == vc2);
			Assert.IsFalse(vc1 != vc2);

			Assert.IsTrue(vc3 != vc5);
			Assert.IsFalse(vc3 == vc5);
		}

		[TestCase(new Variant[] { }, Variant.Alalc97, false)]
		[TestCase(new Variant[] { Variant.Aluku }, Variant.Alalc97, false)]
		[TestCase(new Variant[] { Variant.Aluku }, Variant.Aluku, true)]
		[TestCase(new Variant[] { Variant.Aluku, Variant.Alalc97 }, Variant.Alalc97, true)]
		public void Contains(Variant[] variants, Variant tag, bool expected)
		{
			Assert.That(new VariantCollection(variants).Contains(tag), Is.EqualTo(expected));
		}
	}
}
