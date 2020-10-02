using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace NLanguageTag.Tests
{
	public static class TestContent
	{
		public static IEnumerable<string> GetLanguages()
		{
			const string resourceName = "NLanguageTag.Tests.Languages.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetGrandfathered()
		{
			const string resourceName = "NLanguageTag.Tests.Grandfathered.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetGrandfatheredNotSupported()
		{
			const string resourceName = "NLanguageTag.Tests.GrandfatheredNotSupported.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetRegions()
		{
			const string resourceName = "NLanguageTag.Tests.Regions.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetScripts()
		{
			const string resourceName = "NLanguageTag.Tests.Scripts.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetVariants()
		{
			const string resourceName = "NLanguageTag.Tests.Variants.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

		public static IEnumerable<string> GetExtLanguages()
		{
			const string resourceName = "NLanguageTag.Tests.ExtLanguages.txt";

			using var stream = typeof(TestContent).Assembly.GetManifestResourceStream(resourceName);
			if (stream is null)
			{
				throw new ApplicationException($"Resource '{resourceName}' not found");
			}

			using StreamReader reader = new StreamReader(stream, Encoding.UTF8);

			while (true)
			{
				var line = reader.ReadLine();
				if (string.IsNullOrEmpty(line))
					yield break;

				yield return line;
			}
		}

	}
}
