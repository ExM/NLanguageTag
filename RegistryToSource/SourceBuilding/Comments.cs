using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.RegistryToSource
{
	public class Comments: IEnumerable<string>
	{
		private readonly List<string> _lines = new ();

		public void Add(string line)
		{
			_lines.Add(line);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _lines.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Build(SourceWriter sw)
		{
			if (!_lines.Any())
				return;

			foreach (var line in _lines)
				sw.AppendLine($"/// {line}");
		}
	}
}