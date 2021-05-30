using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class ScriptEntry : RegEntry, IHaveSubtag, IHaveComments
	{
		private string _subtag;
		private string _comments;

		public string Subtag => _subtag;
		public string Comments => _comments;

		public ScriptEntry(string[] body): base(EntryType.Script, body)
		{
			if (Subtag == null)
				throw new Exception("can't contain subtag");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Subtag: ", ref _subtag) ||
				Set(line, "Comments: ", ref _comments);
		}
	}
}