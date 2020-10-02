using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.T4Tools
{
	public abstract class RegEntry
	{
		private readonly List<string> _descriptions = new List<string>();
		private readonly string _added;

		public List<string> Descriptions => _descriptions;
		public string Added => _added;

		public static RegEntry Create(string text)
		{
			var parts = text.Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);

			try
			{
				var type = getType(parts.First());
				var body = parts.Skip(1).ToArray();

				return type switch
				{
					EntryType.Language => new LanguageEntry(body),
					EntryType.Extlang => new ExtlangEntry(body),
					EntryType.Script => new ScriptEntry(body),
					EntryType.Region => new RegionEntry(body),
					EntryType.Variant => new VariantEntry(body),
					EntryType.Grandfathered => new GrandfatheredEntry(body),
					EntryType.Redundant => new RedundantEntry(body),
					_ => throw new FormatException($"unexpected type {type}")
				};
			}
			catch (Exception e)
			{
				throw new FormatException($"Validate fail in entry:\n{text}", e);
			}
		}

		public bool IsPrivateUse => Descriptions.Count == 1 && Descriptions[0] == "Private use";

		protected RegEntry(string type, string[] body)
		{
			Type = type;

			foreach(var line in body)
			{
				if(Set(line, "Added: ", ref _added) ||
				   Set(line, "Description: ", ref _descriptions)) continue;

				if (CustomParse(line)) continue;

				throw new Exception($"unexpected line '{line}'");
			}
		}

		public string Type { get; }

		public abstract bool CustomParse(string line);

		public string FixDigitStart(string text)
		{
			if (!char.IsDigit(text[0]))
				return text;

			return DigitPrefix + text;
		}

		protected virtual string DigitPrefix => throw new NotSupportedException($"unexpected type '{Type}'");

		protected bool Set(string line, string prefix, ref List<string> field)
		{
			if(!line.StartsWith(prefix))
				return false;

			field.Add(line.Substring(prefix.Length));

			return true;
		}

		protected bool Set(string line, string prefix, ref string field)
		{
			if(!line.StartsWith(prefix))
				return false;

			if(field != null)
				throw new Exception($"field {prefix} already contains value '{field}'");

			field = line.Substring(prefix.Length);
			return true;
		}

		private const string _typePrefix = "Type: ";

		private static string getType(string line)
		{
			if(line.StartsWith(_typePrefix))
				return line.Substring(_typePrefix.Length);

			throw new Exception($"field {_typePrefix} not found in '{line}'");
		}
	}
}