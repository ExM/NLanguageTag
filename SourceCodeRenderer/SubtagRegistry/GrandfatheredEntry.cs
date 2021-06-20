using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class GrandfatheredEntry : HasDeprecatedRegEntry
	{
		public string? Comments { get; }
		public string Tag { get; }

		public GrandfatheredEntry(Terms terms) : base(EntryType.Grandfathered, terms)
		{
			Tag = terms.Single("Tag");
			Comments = terms.OptionSingle("Comments");
		}
	}
}
