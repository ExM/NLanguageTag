using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class ScriptEntry : RegEntry, IHaveSubtag, IHaveComments
	{
		public string Subtag { get; }
		public string? Comments { get; }

		public ScriptEntry(Terms terms): base(EntryType.Script, terms)
		{
			Subtag = terms.Single("Subtag");
			Comments = terms.OptionSingle("Comments");
		}
	}
}
