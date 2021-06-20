using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public abstract partial class RegEntry
	{
		public List<string> Descriptions { get; }
		public string? Added { get; }

		public static RegEntry Parse(string text)
		{
			var terms = new Terms(text);

			try
			{
				var type = terms.Single("Type");

				RegEntry result = type switch
				{
					EntryType.Language => new LanguageEntry(terms),
					EntryType.Extlang => new ExtlangEntry(terms),
					EntryType.Script => new ScriptEntry(terms),
					EntryType.Region => new RegionEntry(terms),
					EntryType.Variant => new VariantEntry(terms),
					EntryType.Grandfathered => new GrandfatheredEntry(terms),
					EntryType.Redundant => new RedundantEntry(terms),
					_ => throw new FormatException($"unexpected type {type}")
				};

				terms.EmptyAssert();

				return result;
			}
			catch (Exception e)
			{
				throw new FormatException($"Validate fail in entry:\n{text}", e);
			}
		}

		public bool IsPrivateUse => Descriptions.Count == 1 && Descriptions[0] == "Private use";

		protected RegEntry(string type, Terms terms)
		{
			Type = type;
			Added = terms.Single("Added");
			Descriptions = terms.OptionList("Description");
		}

		public string Type { get; }

		public string FixDigitStart(string text)
		{
			if (!char.IsDigit(text[0]))
				return text;

			return DigitPrefix + text;
		}

		protected virtual string DigitPrefix => throw new NotSupportedException($"unexpected type '{Type}'");
	}
}
