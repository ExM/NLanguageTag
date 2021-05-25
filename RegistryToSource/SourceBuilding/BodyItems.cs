using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.RegistryToSource
{
	public class BodyItems: IEnumerable<string>
	{
		private readonly List<string> _lines = new ();
		
		public void Add(string textBlock)
		{
			if (_lines.Any())
				_lines.Add(string.Empty);
			foreach(var line in textBlock.Split('\r', '\n').Where(x => !string.IsNullOrEmpty(x)))
				 _lines.Add(line);
		}
		
		public void Build(SourceWriter sw)
		{
			if (!_lines.Any())
				return;

			foreach (var line in _lines)
			{
				if(line == String.Empty)
					sw.AppendLine();
				else
					sw.AppendLine(line);
			}
		}
		
		public IEnumerator<string> GetEnumerator()
		{
			throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}