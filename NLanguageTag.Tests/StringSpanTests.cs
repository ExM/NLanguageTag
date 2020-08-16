using NUnit.Framework;

namespace NLanguageTag.Tests
{
	public class StringSpanTests
	{
		[TestCase("XA", "XZ")]
		[TestCase("A", "B")]
		[TestCase("a", "x")]
		public void Operators(string spanText, string text)
		{
			var span = new StringSpan(spanText);
			Assert.Multiple(() =>
			{
				Assert.IsTrue(span <= text);
				Assert.IsFalse(text <= span);
				Assert.IsFalse(span >= text);
				Assert.IsTrue(text >= span);
			});
		}
	}
}