using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public abstract partial class RegEntry
	{
		public class Terms
		{
			private static readonly Regex _termRegex = new Regex(@"^(?<key>\w*(-\w+)*): (?<value>.*)$", RegexOptions.Compiled);

			private readonly Dictionary<string, List<string>> _terms;

			public Terms(string text)
			{
				var parts = text.Replace("\n  ", " ").Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);

				static (string key, string value) getTerm(string line)
				{
					var m = _termRegex.Match(line);
					if(!m.Success)
						throw new Exception($"unexpected line '{line}'");

					return (m.Groups["key"].Value, m.Groups["value"].Value);
				}

				_terms = parts.Select(getTerm)
					.GroupBy(x => x.key, StringComparer.Ordinal)
					.ToDictionary(x => x.Key, x => x.Select(y => y.value).ToList(), StringComparer.Ordinal);
			}

			public string Single(string key)
			{
				if(!_terms.TryGetValue(key, out var values))
					throw new Exception($"term with name {key} not found");

				if(values.Count != 1)
					throw new Exception($"found multiply values in {key} term");

				_terms.Remove(key);
				return values[0];
			}

			public string? OptionSingle(string key)
			{
				if (!_terms.TryGetValue(key, out var values))
					return null;

				if(values.Count > 1)
					throw new Exception($"found multiply values in {key} term");

				_terms.Remove(key);
				return values[0];
			}

			public List<string> List(string key)
			{
				if(!_terms.TryGetValue(key, out var values))
					throw new Exception($"term with name {key} not found");

				_terms.Remove(key);
				return values;
			}

			public List<string> OptionList(string key)
			{
				if (!_terms.TryGetValue(key, out var values))
					return new List<string>();

				_terms.Remove(key);
				return values;
			}

			public void EmptyAssert()
			{
				if(_terms.Keys.Any())
					throw new Exception($"found unexpected terms '{string.Join(", ", _terms.Keys)}'");
			}
		}
	}
}
