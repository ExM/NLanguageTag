using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class VariantTests
	{
		[Test]
		public void CheckCodes()
		{
			foreach (var code in Enum.GetValues(typeof(VariantCode)).Cast<VariantCode>())
			{
				var variant = Variant.ByCode(code);
				Assert.That(variant.EnumCode, Is.EqualTo(code));
			}
		}

		[Test]
		public void CheckParseSwitches()
		{
			foreach (var text in TestContent.GetVariants())
			{
				var variant = text.TryParseVariant();
				Assert.That(variant, Is.Not.Null);
			}
		}

		[TestCaseSource(nameof(parseCases))]
		public void ParseFromVariant(string text, Variant expected)
		{
			Assert.That(text.TryParseVariant(), Is.EqualTo(expected));
		}

		internal static IEnumerable<TestCaseData> parseCases()
		{
			yield return new TestCaseData("xxx", null);
			yield return new TestCaseData("aluku", Variant.Aluku);
			yield return new TestCaseData("1901", Variant.V1901);
		}

		[TestCase("sr-ekavsk")]
		[TestCase("sr-Cyrl-ekavsk")]
		[TestCase("sr-fonipa")]
		[TestCase("sr-Cyrl-fonipa")]
		[TestCase("sr-Hans-fonipa")]
		[TestCase("az-Baku1926")]
		[TestCase("en-fonipa-Scotland")]
		[TestCase("en-scotland-fonipa")]
		[TestCase("sl-rozaj-biske")]
		public void VariantCollectionCreate(string tagText)
		{
			var tag = LanguageTag.Parse(tagText);
			var variants = VariantCollection.Create(tag.Language, tag.Script, tag.Variants);

			Assert.That(variants, Is.EqualTo(tag.Variants));
		}

		[TestCaseSource(nameof(variantCollectionCreateCases))]
		public void VariantCollectionCreate(string tagText, Variant appendVariant)
		{
			Assert.Throws<FormatException>(() =>
			{
				var tag = LanguageTag.Parse(tagText);
				VariantCollection.Create(tag.Language, tag.Script, tag.Variants.Union(new [] { appendVariant }));
			});
		}

		internal static IEnumerable<TestCaseData> variantCollectionCreateCases()
		{
			yield return new TestCaseData("en",  Variant.Ekavsk);
			yield return new TestCaseData("sr-Hans", Variant.Ekavsk);
			yield return new TestCaseData("sl", Variant.V1994);
			yield return new TestCaseData("en", Variant.Baku1926);
			yield return new TestCaseData("sl-rozaj-biske-fonipa", Variant.V1994);
		}

		[Test]
		public void Equals()
		{
			var vc1 = new VariantCollection();
			var vc2 = new VariantCollection();

			var vc3 = VariantCollection.Create(Language.DJK, null, new[] { Variant.Alalc97, Variant.Aluku });
			var vc4 = VariantCollection.Create(Language.DJK, null, new[] { Variant.Alalc97, Variant.Aluku });

			var vc5 = VariantCollection.Create(null, null, new[] { Variant.Alalc97 });

			Assert.That(vc1.Equals(null), Is.False);
			Assert.That(vc1.Equals((object)vc2), Is.True);
			Assert.That(vc1, Is.EqualTo(vc1));
			Assert.That(vc2, Is.EqualTo(vc1));
			Assert.That(vc3, Is.Not.EqualTo(vc1));
			Assert.That(vc3, Is.EqualTo(vc3));
			Assert.That(vc4, Is.EqualTo(vc3));
			Assert.That(vc5, Is.Not.EqualTo(vc4));

			Assert.That(vc1 == vc2, Is.True);
			Assert.That(vc1 != vc2, Is.False);

			Assert.That(vc3 != vc5, Is.True);
			Assert.That(vc3 == vc5, Is.False);
		}

		[TestCaseSource(nameof(containsCases))]
		public void Contains(Variant[] variants, Variant tag, bool expected)
		{
			var collection = VariantCollection.Create(Language.DJK, null, variants);
			Assert.That(collection.Contains(tag), Is.EqualTo(expected));
		}

		internal static IEnumerable<TestCaseData> containsCases()
		{
			yield return new TestCaseData(new Variant[] { }, Variant.Alalc97, false);
			yield return new TestCaseData(new[] { Variant.Aluku }, Variant.Alalc97, false);
			yield return new TestCaseData(new[] { Variant.Aluku }, Variant.Aluku, true);
			yield return new TestCaseData(new[] { Variant.Aluku, Variant.Alalc97 }, Variant.Alalc97, true);
		}
	}
}