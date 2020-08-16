using System;

namespace NLanguageTag.T4Tools
{
	public class RedundantEntry : RegEntry
	{
		private string _deprecated;
		private string _preferredValue;
		private string _tag;

		public string Deprecated => _deprecated;
		public string PreferredValue => _preferredValue;
		public string Tag => _tag;

		public RedundantEntry(string[] body): base(EntryType.Redundant, body)
		{

			if ((PreferredValue != null) && (Deprecated == null))
				throw new FormatException($"PreferredValue without Deprecated");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Deprecated: ", ref _deprecated) ||
				Set(line, "Preferred-Value: ", ref _preferredValue) ||
				Set(line, "Tag: ", ref _tag);
		}
	}
}