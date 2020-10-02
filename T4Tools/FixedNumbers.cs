using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NLanguageTag.T4Tools
{
	public class FixedNumbers
	{
		static FixedNumbers()
		{
			LanguageCode = new CodeMap("LanguageCode.fixedNumbers.csv");
			RegionCode = new CodeMap("RegionCode.fixedNumbers.csv");
			ScriptCode = new CodeMap("ScriptCode.fixedNumbers.csv");
			VariantCode = new CodeMap("VariantCode.fixedNumbers.csv");
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
					using var resourceStream = typeof(Registry).Assembly.GetManifestResourceStream("NLanguageTag.T4Tools." + fileName);
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