using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class RegionEntry : HasDeprecatedRegEntry, IHaveSubtag, IHaveComments, IHavePreferredValue
	{
		public string Subtag { get; }
		public string? Comments { get; }

		public RegionEntry(Terms terms): base(EntryType.Region, terms)
		{
			Subtag = terms.Single("Subtag");
			Comments = terms.OptionSingle("Comments");
		}

		protected override string DigitPrefix => "M";
	}
}
