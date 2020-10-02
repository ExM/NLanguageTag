using System;

namespace NLanguageTag
{
	/// <summary>
	/// Result of parsing part of language tag
	/// </summary>
	internal readonly struct PartialParseResult<T> where T : struct
	{
		private PartialParseResult(T result, bool errorOccured, bool nothingToParse)
		{
			_result = result;
			ErrorOccured = errorOccured;
			NothingToParse = nothingToParse;
		}

		/// <summary>
		/// Creates successful parsing result
		/// </summary>
		/// <param name="result">parsed value</param>
		public static PartialParseResult<T> Success(T result)
		{
			return new PartialParseResult<T>(result, false, false);
		}

		/// <summary>
		/// Result indicating that input contains error
		/// </summary>
		public static PartialParseResult<T> Error { get; } = new PartialParseResult<T>(default, true, false);

		/// <summary>
		/// Result indicating that this part of language tag is missing in the input text
		/// </summary>
		public static PartialParseResult<T> Empty { get; } = new PartialParseResult<T>(default, false, true);

		public T Result => !ErrorOccured && !NothingToParse
			? _result
			: throw new InvalidOperationException("There is no result in this value");

		/// <summary>
		/// Indicates whether input contains error
		/// </summary>
		public bool ErrorOccured { get; }

		/// <summary>
		/// Indicates whether this part of language tag is missing in the input text
		/// </summary>
		public bool NothingToParse { get; }

		private readonly T _result;
	}
}