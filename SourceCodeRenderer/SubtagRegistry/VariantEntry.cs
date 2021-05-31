using System;
using System.Collections.Generic;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class VariantEntry : RegEntry, IHaveComments, IHaveSubtag, IHavePreferredValue
	{
		private string _subtag;
		private List<string> _prefixes = new List<string>();
		private string _comments;
		private string _deprecated;
		private string _preferredValue;

		public List<string> Prefixes => _prefixes;
		public string Subtag => _subtag;
		public string Comments => _comments;
		public string? Deprecated => _deprecated;
		public string PreferredValue => _preferredValue;

		public VariantEntry(string[] body): base(EntryType.Variant, body)
		{

			if ((PreferredValue != null) && (Deprecated == null))
				throw new FormatException($"PreferredValue without Deprecated");
		}

		public override bool CustomParse(string line)
		{
			return
				Set(line, "Deprecated: ", ref _deprecated) ||
				Set(line, "Preferred-Value: ", ref _preferredValue) ||
				Set(line, "Subtag: ", ref _subtag) ||
				Set(line, "Comments: ", ref _comments) ||
				Set(line, "Prefix: ", ref _prefixes);
		}

		protected override string DigitPrefix => "V";
	}
}
