using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class LanguageEntry : HasDeprecatedRegEntry, IHaveSubtag, IHavePreferredValue, IHaveComments
	{
		public string Subtag { get; }
		public string? Comments { get; }
		public string? SuppressScript { get; }
		public string? Scope { get; }
		public string? Macrolanguage { get; }

		public LanguageEntry(Terms terms): base(EntryType.Language, terms)
		{
			Subtag = terms.Single("Subtag");
			Comments = terms.OptionSingle("Comments");
			SuppressScript = terms.OptionSingle("Suppress-Script");
			Scope = terms.OptionSingle("Scope");
			Macrolanguage = terms.OptionSingle("Macrolanguage");
		}
	}
}
