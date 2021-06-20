using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class RedundantEntry : HasDeprecatedRegEntry
	{
		public string Tag { get; }

		public RedundantEntry(Terms terms) : base(EntryType.Redundant, terms)
		{
			Tag = terms.Single("Tag");
		}
	}
}
