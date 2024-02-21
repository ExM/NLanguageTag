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
				Assert.That(span <= text, Is.True);
				Assert.That(text <= span, Is.False);
				Assert.That(span >= text, Is.False);
				Assert.That(text >= span, Is.True);
			});
		}
	}
}