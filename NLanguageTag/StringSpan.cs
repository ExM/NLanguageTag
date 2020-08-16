using System;

namespace NLanguageTag
{
	internal struct StringSpan
	{
		private int _start;
		private readonly string _source;

		public StringSpan(string source)
		{
			_source = source ?? throw new FormatException();
			_start = 0;
			Length = source.Length;
		}

		public char this[int index]
		{
			get
			{
				if(index >= Length)
					throw new IndexOutOfRangeException();
				return _source[_start + index];
			}
		}

		public int Length { get; private set; }

		public void Update(int start, int length)
		{
			_start = start;
			Length = length;
		}

		public string AsText()
		{
			return Length == 0
				? string.Empty
				: _source.Substring(_start, Length);
		}

		public static bool operator <=(string a, StringSpan b)
		{
			return string.CompareOrdinal(a, 0, b._source, b._start, b.Length) <= 0;
		}

		public static bool operator >=(string a, StringSpan b)
		{
			return string.CompareOrdinal(a, 0, b._source, b._start, b.Length) >= 0;
		}

		public static bool operator <=(StringSpan a, string b)
		{
			return string.CompareOrdinal(a._source, a._start, b, 0, a.Length) <= 0;
		}

		public static bool operator >=(StringSpan a, string b)
		{
			return string.CompareOrdinal(a._source, a._start, b, 0, a.Length) >= 0;
		}
	}
}
