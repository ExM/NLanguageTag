using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NLanguageTag.Benchmark
{
	public static class SubtagSamples
	{
		public static IReadOnlyList<string> Languages = readSubtags("Languages").ToList();
		public static IReadOnlyList<string> Regions = readSubtags("Regions").ToList();
		public static IReadOnlyList<string> Scripts = readSubtags("Scripts").ToList();
		public static IReadOnlyList<string> Variants = readSubtags("Variants").ToList();
		public static IReadOnlyList<string> ExtLanguages = readSubtags("ExtLanguages").ToList();

		private static IEnumerable<string> readSubtags(string resourceName)
		{
			var fullResourceName = $"NLanguageTag.Benchmark.SubtagSamples.{resourceName}.txt";

			using var stream = typeof(SubtagSamples).Assembly.GetManifestResourceStream(fullResourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{fullResourceName}' not found");
			}

			using var reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
				{
					yield break;
				}

				yield return line;
			}
		}
	}
}