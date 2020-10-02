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
				_currentToken = null;
				_nextTokenPosition = null;
			}
			else
			{
				_nextTokenPosition = 0;
				ToNextToken();
			}
		}

		public string Token => _currentToken ?? throw new InvalidOperationException("Current token is not available");

		public bool NextTokenAvailable => _nextTokenPosition.HasValue;

		public bool CurrentTokenAvailable => _currentToken != null;

		public bool TokenIs(string token)
		{
			return string.Equals(_currentToken, token, StringComparison.OrdinalIgnoreCase);
		}

		public void ToNextToken()
		{
			if (!_nextTokenPosition.HasValue)
			{
				_currentToken = null;
				return;
			}

			var pos = _source.IndexOf(LanguageTag.TagSeparator, _nextTokenPosition.Value);

			if (pos == -1)
			{
				_currentToken = _source.Substring(_nextTokenPosition.Value);
				_nextTokenPosition = null;
			}
			else
			{
				_currentToken = _source.Substring(_nextTokenPosition.Value, pos - _nextTokenPosition.Value);
				_nextTokenPosition = pos + 1;
			}
		}

		private string? _currentToken;
		private int? _nextTokenPosition;
		private readonly string _source;
	}
}