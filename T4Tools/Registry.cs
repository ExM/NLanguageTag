using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NLanguageTag.T4Tools
{
	public class Registry
	{
		public static Registry ReadCurrent()
		{
			return Read(typeof(Registry).Assembly.GetManifestResourceStream("NLanguageTag.T4Tools.language-subtag-registry"));
		}

		public static Registry Read(Stream registryFile)
		{
			return new Registry(new StreamReader(registryFile, Encoding.UTF8).ReadToEnd());
		}

		private Registry(string content)
		{
			var entryBlocks = content
				.Split(new string[]{"\n%%\n"}, StringSplitOptions.RemoveEmptyEntries)
				.Select(_ => _.Replace("\n  ", " "))
				.ToArray();

			parseFirstBlock(entryBlocks.First());

			AllEntries = entryBlocks.Skip(1).Select(RegEntry.Create).ToList();

			PrimaryLanguages = AllEntries.OfType<LanguageEntry>().Where(_ => !_.IsPrivateUse).ToList();
			PrivateUsePrimaryLanguages = AllEntries.OfType<LanguageEntry>().Single(_ => _.IsPrivateUse);

			ExtLanguages = AllEntries.OfType<ExtlangEntry>().ToList();

			Scripts = AllEntries.OfType<ScriptEntry>().Where(_ => !_.IsPrivateUse).ToList();
			PrivateUseScripts = AllEntries.OfType<ScriptEntry>().Single(_ => _.IsPrivateUse);

			Regions = AllEntries.OfType<RegionEntry>().Where(_ => !_.IsPrivateUse).ToList();
			PrivateUseRegions = AllEntries.OfType<RegionEntry>().Where(_ => _.IsPrivateUse).ToList();

			Variants = AllEntries.OfType<VariantEntry>().ToList();

			Grandfathered = AllEntries.OfType<GrandfatheredEntry>().ToList();

			Redundand = AllEntries.OfType<RedundantEntry>().ToList();
		}

		private void parseFirstBlock(string block)
		{
			var m = _fileDateRegex.Match(block);
			if(!m.Success)
				throw new FormatException("File-Date field not found");

			FileDate = m.Groups["date"].Value;
		}

		private static readonly Regex _fileDateRegex = new Regex(@"^File-Date: (?<date>\d\d\d\d-\d\d-\d\d)$", RegexOptions.Compiled);

		public string FileDate { get; private set; }

		public IReadOnlyList<RegEntry> AllEntries { get; private set; }

		public IReadOnlyList<GrandfatheredEntry> Grandfathered { get; private set; }
		public IReadOnlyList<VariantEntry> Variants { get; private set; }
		public IReadOnlyList<RegionEntry> Regions { get; private set; }
		public IReadOnlyList<RegionEntry> PrivateUseRegions { get; private set; }
		public IReadOnlyList<ScriptEntry> Scripts { get; private set; }
		public ScriptEntry PrivateUseScripts { get; private set; }
		public IReadOnlyList<ExtlangEntry> ExtLanguages { get; private set; }
		public IReadOnlyList<LanguageEntry> PrimaryLanguages { get; private set; }
		public LanguageEntry PrivateUsePrimaryLanguages { get; private set; }
		public IReadOnlyList<RedundantEntry> Redundand { get; private set; }
	}
}
