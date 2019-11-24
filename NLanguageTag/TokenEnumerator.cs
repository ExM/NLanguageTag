using System;

namespace NLanguageTag
{
	internal sealed class TokenEnumerator
	{
		public TokenEnumerator(string text)
		{
			_source = text;

			if (string.IsNullOrEmpty(text))
			{
				Token = null;
				_nextTokenPosition = null;
			}
			else
			{
				_nextTokenPosition = 0;
				ToNextToken();
			}
		}

		public string Token { get; private set; }

		public bool NextTokenAvailable => _nextTokenPosition.HasValue;

		public bool CurrentTokenAvailable => Token != null;

		public bool TokenIs(string token)
		{
			return string.Equals(Token, token, StringComparison.OrdinalIgnoreCase);
		}

		public void ToNextToken()
		{
			if (!_nextTokenPosition.HasValue)
			{
				Token = null;
				return;
			}

			var pos = _source.IndexOf(LanguageTag.TagSeparator, _nextTokenPosition.Value);

			if (pos == -1)
			{
				Token = _source.Substring(_nextTokenPosition.Value);
				_nextTokenPosition = null;
			}
			else
			{
				Token = _source.Substring(_nextTokenPosition.Value, pos - _nextTokenPosition.Value);
				_nextTokenPosition = pos + 1;
			}
		}

		private int? _nextTokenPosition;
		private readonly string _source;
	}
}