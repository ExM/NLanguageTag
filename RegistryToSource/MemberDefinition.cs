using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.RegistryToSource
{
	public class MemberDefinition: IEnumerable<string>
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

			sw.AppendLine(_lines.First());
			using (sw.Indent())
				foreach (var line in _lines.Skip(1))
					sw.AppendLine(line);
		}
	}
}