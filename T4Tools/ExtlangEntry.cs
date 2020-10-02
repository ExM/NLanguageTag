using System;

namespace NLanguageTag.T4Tools
{
	public class ExtlangEntry : RegEntry
	{
		private string _subtag;
		private string _prefix;
		private string _macrolanguage;
		private string _deprecated;
		private string _preferredValue;

		public string Prefix => _prefix;
		public string Subtag => _subtag;
		public string Macrolanguage => _macrolanguage;
		public string Deprecated => _deprecated;
		public string PreferredValue => _preferredValue;

		public ExtlangEntry(string[] body): base(EntryType.Extlang, body)
		{

			if (PreferredValue == null)
				throw new FormatException($"PreferredValue not found");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Deprecated: ", ref _deprecated) ||
				Set(line, "Preferred-Value: ", ref _preferredValue) ||
				Set(line, "Subtag: ", ref _subtag) ||
				Set(line, "Macrolanguage: ", ref _macrolanguage) ||
				Set(line, "Prefix: ", ref _prefix);
		}
	}
}