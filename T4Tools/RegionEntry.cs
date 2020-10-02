using System;

namespace NLanguageTag.T4Tools
{
	public class RegionEntry : RegEntry, IHaveSubtag, IHaveComments, IHavePreferredValue
	{
		private string _subtag;
		private string _comments;
		private string _deprecated;
		private string _preferredValue;

		public string Subtag => _subtag;
		public string Comments => _comments;
		public string Deprecated => _deprecated;
		public string PreferredValue => _preferredValue;

		public RegionEntry(string[] body): base(EntryType.Region, body)
		{
			if (Subtag == null)
				throw new Exception("can't contain subtag");

			if ((PreferredValue != null) && (Deprecated == null))
				throw new FormatException($"PreferredValue without Deprecated");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Deprecated: ", ref _deprecated) ||
				Set(line, "Preferred-Value: ", ref _preferredValue) ||
				Set(line, "Subtag: ", ref _subtag) ||
				Set(line, "Comments: ", ref _comments);
		}

		protected override string DigitPrefix => "M";
	}
}