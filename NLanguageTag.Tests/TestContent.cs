using System;
using System.Collections.Generic;
using System.Linq;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.Tests
{
	public static class TestContent
	{
		public static readonly Registry Registry = Registry.ReadCurrent();

		public static IEnumerable<string> GetLanguages() =>
			Registry.PrimaryLanguages.Select(_ => _.Subtag);

		public static IEnumerable<string> GetGrandfathered() =>
			Registry.Grandfathered.Where(_ => _.PreferredValue != null).Select(_ => _.Tag);

		public static IEnumerable<string> GetGrandfatheredNotSupported() =>
			Registry.Grandfathered.Where(_ => _.PreferredValue == null).Select(_ => _.Tag);

		public static IEnumerable<string> GetRegions() =>
			Registry.Regions.Select(_ => _.Subtag);

		public static IEnumerable<string> GetScripts() =>
			Registry.Scripts.Select(_ => _.Subtag);

		public static IEnumerable<string> GetVariants() =>
			Registry.Variants.Select(_ => _.Subtag);

		public static IEnumerable<string> GetExtLanguages() =>
			Registry.ExtLanguages.Where(_ => _.PreferredValue != null).Select(_ => _.Prefix + "-" + _.Subtag);
	}
}
