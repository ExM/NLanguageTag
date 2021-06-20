using System;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public abstract class HasDeprecatedRegEntry : RegEntry
	{
		public string? Deprecated { get; }
		public string? PreferredValue { get; }

		protected HasDeprecatedRegEntry(string type, Terms terms) : base(type, terms)
		{
			Deprecated = terms.OptionSingle("Deprecated");
			PreferredValue = terms.OptionSingle("Preferred-Value");

			if ((PreferredValue != null) && (Deprecated == null))
				throw new FormatException($"PreferredValue without Deprecated");
		}
	}
}
