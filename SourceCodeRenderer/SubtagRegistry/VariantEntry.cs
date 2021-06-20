using System;
using System.Collections.Generic;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class VariantEntry : HasDeprecatedRegEntry, IHaveComments, IHaveSubtag, IHavePreferredValue
	{
		public List<string> Prefixes { get; }
		public string Subtag { get; }
		public string? Comments { get; }

		public VariantEntry(Terms terms) : base(EntryType.Variant, terms)
		{
			Subtag = terms.Single("Subtag");
			Comments = terms.OptionSingle("Comments");
			Prefixes = terms.OptionList("Prefix");
		}

		protected override string DigitPrefix => "V";
	}
}
