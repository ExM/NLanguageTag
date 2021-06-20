using System.Collections.Generic;

namespace NLanguageTag.SourceCodeRenderer.FixedCodes
{
	public interface ICodeMap
	{
		int? TryGet(string subtag);
		void Update(IEnumerable<string> subtags);
	}
}
