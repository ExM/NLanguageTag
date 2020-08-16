using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace NLanguageTag.Tests
{
	[TestFixture]
	public class PerfomanceTests
	{
		[Test]
		public void ParseLSR()
		{
			List<string> tagText = new List<string>();

			foreach (var lang in Reduce(TestContent.GetLanguages(), 10))
				foreach (var script in Reduce(TestContent.GetScripts(), 10))
					foreach (var region in Reduce(TestContent.GetRegions(), 10))
						tagText.Add(string.Join("-", lang, script, region));

			Console.WriteLine("Parse {0} samples.", tagText.Count);

			for (int i = 0; i <= 2; i++)
			{
				var sw = Stopwatch.StartNew();
				foreach (var text in tagText)
					LanguageTag.Parse(text);

				var elapsed = sw.Elapsed;

				var parseTimeS = elapsed.TotalSeconds / tagText.Count;

				Console.WriteLine("Elapsed: {0} Parse time: {1:0.000} ns", elapsed, parseTimeS * 1000 * 1000);
			}
		}

		public IEnumerable<string> Reduce(IEnumerable<string> source, int range)
		{
			var count = 0;

			foreach (var item in source)
			{
				if (count == 0)
				{
					yield return item;
					count = range;
				}
				else
					count--;
			}
		}
	}
}
