using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NLanguageTag.SourceCodeRenderer.FixedCodes
{
	public class CodeMap: ICodeMap
	{
		private readonly IDictionary<string, int> _codeMap = new Dictionary<string, int>(StringComparer.Ordinal);
		private readonly string _fileName;

		internal CodeMap(string fileName)
		{
			_fileName = fileName;
			LoadFile();
		}

		public int? TryGet(string subtag)
		{
			if (_codeMap.TryGetValue(subtag, out var number))
				return number;

			return null;
		}

		public void Update(IEnumerable<string> subtags)
		{
			var nextCode = _codeMap.Values.Max() + 1;
			var sb = new StringBuilder();
			foreach (var subtag in subtags.Where(x => !_codeMap.ContainsKey(x)))
			{
				sb.Append($"{subtag},{nextCode++}\n");
			}

			if (sb.Length == 0)
				return;

			using (var resourceStream = File.AppendText(_fileName))
			{
				resourceStream.Write(sb.ToString());
			}

			LoadFile();
		}

		private void LoadFile()
		{
			_codeMap.Clear();
			try
			{
				using var resourceStream = File.OpenRead(_fileName);
				using var textReader = new StreamReader(resourceStream!, Encoding.UTF8);

				foreach (var line in textReader.ReadToEnd().Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries))
				{
					var cells = line.Split(',');
					if (cells.Length != 2)
						throw new Exception($"Unexpected cells in '{line}'");

					_codeMap.Add(cells[0], int.Parse(cells[1]));
				}
			}
			catch (Exception e)
			{
				throw new Exception($"Fail parsing file {_fileName}", e);
			}
		}
	}
}
