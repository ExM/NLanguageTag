using System;

namespace NLanguageTag.T4Tools
{
	public class GrandfatheredEntry : RegEntry
	{
		private string _comments;
		private string _deprecated;
		private string _preferredValue;
		private string _tag;

		public string Comments => _comments;
		public string Deprecated => _deprecated;
		public string PreferredValue => _preferredValue;
		public string Tag => _tag;

		public GrandfatheredEntry(string[] body) : base(EntryType.Grandfathered, body)
		{

			if ((PreferredValue != null) && (Deprecated == null))
				throw new FormatException($"PreferredValue without Deprecated");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Deprecated: ", ref _deprecated) ||
				Set(line, "Preferred-Value: ", ref _preferredValue) ||
				Set(line, "Comments: ", ref _comments) ||
				Set(line, "Tag: ", ref _tag);
		}
	}
}