using System;
using System.Collections.Generic;
using System.IO;

namespace NLanguageTag.RegistryToSource
{
	public class SourceWriter: IDisposable
	{
		private readonly StringWriter _writer = new StringWriter() {NewLine = "\r\n"};
		private int _currentIndentLevel = 0;
		private readonly List<string> _indentMasks = new List<string>();

		public void AppendLine()
		{
			_writer.WriteLine();
		}

		public void AppendLine(string line)
		{
			_writer.Write(CurrentIndent);
			_writer.WriteLine(line);
		}

		public string CurrentIndent => _currentIndentLevel == 0
			? string.Empty
			: _indentMasks[_currentIndentLevel - 1];

		public IDisposable Indent()
		{
			_currentIndentLevel++;
			if(_indentMasks.Count < _currentIndentLevel)
				_indentMasks.Add(new string('\t', _currentIndentLevel));
			return new IndentHolder(this);
		}

		private void UnIndent()
		{
			_currentIndentLevel--;
		}

		public override string ToString()
		{
			return _writer.ToString();
		}

		public void Dispose()
		{
			_writer.Dispose();
		}

		private class IndentHolder: IDisposable
		{
			private readonly SourceWriter _owner;

			public IndentHolder(SourceWriter owner)
			{
				_owner = owner;
			}

			public void Dispose()
			{
				_owner.UnIndent();
			}
		}
	}
}
