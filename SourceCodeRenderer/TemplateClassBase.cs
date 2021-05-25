using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace NLanguageTag.SourceCodeRenderer
{
	public abstract class TemplateClassBase
	{
		private StringBuilder _builder;
		private IDictionary<string, object> _session;
		private CompilerErrorCollection _errors;
		private string _currentIndent = string.Empty;
		private Stack<int> _indents;
		private readonly ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();

		public abstract string TransformText();

		public virtual void Initialize()
		{
		}

		public virtual IDictionary<string, object> Session
		{
			get => _session;
			set => _session = value;
		}

		public StringBuilder GenerationEnvironment
		{
			get => _builder ??= new StringBuilder();
			set => _builder = value;
		}

		protected CompilerErrorCollection Errors => _errors ??= new CompilerErrorCollection();

		public string CurrentIndent => _currentIndent;

		private Stack<int> Indents => _indents ??= new Stack<int>();

		public ToStringInstanceHelper ToStringHelper => _toStringHelper;

		public void Error(string message)
		{
			Errors.Add(new CompilerError(null, -1, -1, null, message));
		}

		public void Warning(string message)
		{
			var val = new CompilerError(null, -1, -1, null, message);
			val.IsWarning = true;
			Errors.Add(val);
		}

		public string PopIndent()
		{
			if (Indents.Count == 0)
				return string.Empty;

			var lastPos = _currentIndent.Length - Indents.Pop();
			var last = _currentIndent.Substring(lastPos);
			_currentIndent = _currentIndent.Substring(0, lastPos);
			return last;
		}

		public void PushIndent(string indent)
		{
			Indents.Push(indent.Length);
			_currentIndent = _currentIndent + indent;
		}

		public void ClearIndent()
		{
			_currentIndent = string.Empty;
			Indents.Clear();
		}

		public void Write(string textToAppend)
		{
			GenerationEnvironment.Append(textToAppend);
		}

		public void Write(string format, params object[] args)
		{
			GenerationEnvironment.AppendFormat(format, args);
		}

		public void WriteLine(string textToAppend)
		{
			GenerationEnvironment.Append(_currentIndent);
			GenerationEnvironment.AppendLine(textToAppend);
		}

		public void WriteLine(string format, params object[] args)
		{
			GenerationEnvironment.Append(_currentIndent);
			GenerationEnvironment.AppendFormat(format, args);
			GenerationEnvironment.AppendLine();
		}

		public class ToStringInstanceHelper
		{
			private IFormatProvider _formatProvider = System.Globalization.CultureInfo.InvariantCulture;

			public IFormatProvider FormatProvider
			{
				get => _formatProvider;
				set {
					if (value != null) {
						_formatProvider = value;
					}
				}
			}

			public string ToStringWithCulture(object objectToConvert)
			{
				if (objectToConvert == null)
					throw new ArgumentNullException("objectToConvert");

				var type = objectToConvert.GetType();
				var iConvertibleType = typeof(IConvertible);
				if (iConvertibleType.IsAssignableFrom(type))
					return ((IConvertible) objectToConvert).ToString(_formatProvider);

				var methInfo = type.GetMethod("ToString", new [] { iConvertibleType});
				if (methInfo != null)
					return (string) methInfo.Invoke(objectToConvert, new object[] { _formatProvider });

				return objectToConvert.ToString();
			}
		}
	}
}
