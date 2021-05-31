using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class FixedNumbers
	{
		static FixedNumbers()
		{
			LanguageCode = new CodeMap("Language.csv");
			RegionCode = new CodeMap("Region.csv");
			ScriptCode = new CodeMap("Script.csv");
			VariantCode = new CodeMap("Variant.csv");
		}

		public static CodeMap LanguageCode { get; }
		public static CodeMap RegionCode { get; }
		public static CodeMap ScriptCode { get; }
		public static CodeMap VariantCode { get; }

		public class CodeMap
		{
			private readonly IDictionary<string, int> _codeMap;

			public int? TryGet(string subtag)
			{
				if (_codeMap.TryGetValue(subtag, out var number))
					return number;

				return null;
			}

			public int Count => _codeMap.Count;

			internal CodeMap(string fileName)
			{
				try
				{
					using var resourceStream = typeof(Registry).Assembly.GetManifestResourceStream("NLanguageTag.SourceCodeRenderer.SubtagRegistry.FixedEnumCodes." + fileName);
					using var textReader = new StreamReader(resourceStream!, Encoding.UTF8);

					_codeMap = new Dictionary<string, int>(StringComparer.Ordinal);
					foreach(var line in textReader.ReadToEnd().Split(new []{"\n"}, StringSplitOptions.RemoveEmptyEntries))
					{
						var cells = line.Split(',');
						if(cells.Length != 2)
							throw new Exception($"Unexpected cells in '{line}'");

						_codeMap.Add(cells[0], int.Parse(cells[1]));
					}
				}
				catch (Exception e)
				{
					throw new Exception($"Fail parsing file {fileName}", e);
				}
			}
		}
	}
}
