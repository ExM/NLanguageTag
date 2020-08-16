using System;

namespace NLanguageTag
{
	internal sealed class TokenEnumerator
	{
		public TokenEnumerator(string text)
		{
			text = text.ToLowerInvariant();
			_source = text;

			_currentToken = new StringSpan(text);

			if (string.IsNullOrEmpty(text))
			{
				_nextTokenPosition = null;
			}
			else
			{
				_nextTokenPosition = 0;
				ToNextToken();
			}
		}

		public bool NextTokenAvailable => _nextTokenPosition.HasValue;

		public bool CurrentTokenAvailable { get; private set; }

		public bool TokenIsPrivateUseSingleton()
		{
			if(_currentToken.Length != 1)
				return false;

			return char.ToLowerInvariant(_currentToken[0]) == 'x';
		}

		public void ToNextToken()
		{
			if (!_nextTokenPosition.HasValue)
			{
				_currentToken.Update(0, 0);
				CurrentTokenAvailable = false;
				return;
			}

			CurrentTokenAvailable = true;
			var pos = _source.IndexOf(LanguageTag.TagSeparator, _nextTokenPosition.Value);

			if (pos == -1)
			{
				_currentToken.Update(_nextTokenPosition.Value, _source.Length - _nextTokenPosition.Value);
				_nextTokenPosition = null;
			}
			else
			{
				_currentToken.Update(_nextTokenPosition.Value, pos - _nextTokenPosition.Value);
				_nextTokenPosition = pos + 1;
			}
		}

		private int? _nextTokenPosition;
		private readonly string _source;

		private StringSpan _currentToken;

		public StringSpan CurrentToken => _currentToken;
	}
}
