using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	public static class TestContent
	{
		public static IEnumerable<string> GetLanguages()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.Languages.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetGrandfathered()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.Grandfathered.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetGrandfatheredNotSupported()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.GrandfatheredNotSupported.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetRegions()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.Regions.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetScripts()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.Scripts.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetVariants()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.Variants.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

		public static IEnumerable<string> GetExtLanguages()
		{
			var assembly = typeof(TestContent).Assembly;
			var resourceName = "AbbyyLS.Globalization.Bcp47.ExtLanguages.txt";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				while(true)
				{
					var line = reader.ReadLine();
					if(string.IsNullOrEmpty(line))
						yield break;
					else
						yield return line;
				}
			}
		}

	}
}
