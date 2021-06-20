using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class ExtlangEntry : RegEntry
	{
		public string Prefix { get; }
		public string Subtag { get; }
		public string? Macrolanguage { get; }
		public string? Deprecated { get; }
		public string PreferredValue { get; }

		public ExtlangEntry(Terms terms): base(EntryType.Extlang, terms)
		{
			Subtag = terms.Single("Subtag");
			Prefix = terms.Single("Prefix");
			Deprecated = terms.OptionSingle("Deprecated");
			PreferredValue = terms.Single("Preferred-Value");
			Macrolanguage = terms.OptionSingle("Macrolanguage");
		}
	}
}
