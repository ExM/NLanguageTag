using System;
using System.Collections.Generic;
using System.Linq;

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
			var commentList = terms.OptionList("Comments");
			Comments = commentList.Any() ? string.Join(" ", commentList) : null;
			Prefixes = terms.OptionList("Prefix");
		}

		protected override string DigitPrefix => "V";
	}
}
