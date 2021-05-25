using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class LanguageEntry : RegEntry, IHaveSubtag, IHavePreferredValue, IHaveComments
	{
		private string _subtag;
		private string _comments;
		private string _suppressScript;
		private string _scope;
		private string _macrolanguage;
		private string _deprecated;
		private string _preferredValue;

		public string Subtag => _subtag;
		public string? Comments => _comments;
		public string? SuppressScript => _suppressScript;
		public string? Scope => _scope;
		public string? Macrolanguage => _macrolanguage;
		public string? Deprecated => _deprecated;
		public string? PreferredValue => _preferredValue;

		public LanguageEntry(string[] body): base(EntryType.Language, body)
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
				Set(line, "Suppress-Script: ", ref _suppressScript) ||
				Set(line, "Comments: ", ref _comments) ||
				Set(line, "Scope: ", ref _scope) ||
				Set(line, "Macrolanguage: ", ref _macrolanguage);
		}
	}
}
