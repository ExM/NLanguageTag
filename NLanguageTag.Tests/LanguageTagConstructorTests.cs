﻿using NUnit.Framework;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class LanguageTagConstructorTests
	{
		[Test]
		public void Constructor_Lang()
		{
			var tag1 = new LanguageTag(Language.RU);
			var tag2 = new LanguageTag(Language.RU, null, null, new Variant[]{}, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangPr()
		{
			var tag1 = new LanguageTag(Language.RU, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, null, new Variant[]{}, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangExr()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, null, null, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, null, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangVar()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ Variant.Petr1708 });
			var tag2 = new LanguageTag(Language.RU, null, null, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Petr1708");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangVarPr()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ Variant.Petr1708 }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, null, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Petr1708-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangVarExr()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, null, null, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Petr1708-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangVarExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, null, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Petr1708-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangReg()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU);
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new Variant[]{}, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-RU");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegPr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new Variant[]{}, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-RU-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegExr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-RU-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-RU-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegVar()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ Variant.Petr1708 });
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-RU-Petr1708");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegVarPr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ Variant.Petr1708 }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-RU-Petr1708-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegVarExr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-RU-Petr1708-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangRegVarExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, null, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-RU-Petr1708-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn);
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new Variant[]{}, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new Variant[]{}, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrExr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrVar()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ Variant.Petr1708 });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-Petr1708");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrVarPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ Variant.Petr1708 }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-Petr1708-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrVarExr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-Petr1708-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrVarExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, null, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-Petr1708-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrReg()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU);
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new Variant[]{}, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-RU");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new Variant[]{}, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-RU-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegExr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-RU-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new Variant[]{}, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-RU-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegVar()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-RU-Petr1708");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegVarPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new ExtensionSubtag[]{}, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-RU-Petr1708-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegVarExr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") });
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, new ExtensionSubtag());
			var expected = LanguageTag.Parse("ru-Latn-RU-Petr1708-a-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}

		[Test]
		public void Constructor_LangScrRegVarExrPr()
		{
			var tag1 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var tag2 = new LanguageTag(Language.RU, Script.Latn, Region.RU, new []{ Variant.Petr1708 }, new []{ new ExtensionSubtag('a', "aaa") }, ExtensionSubtag.ForPrivateUse("aaa"));
			var expected = LanguageTag.Parse("ru-Latn-RU-Petr1708-a-aaa-x-aaa");
			Assert.That(tag1, Is.EqualTo(expected));
			Assert.That(tag2, Is.EqualTo(expected));
		}
	}
}
