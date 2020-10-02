using System;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.T4Tools
{
	public class PrefixTreeSelector
	{
		private readonly string _privateFunctionName;
		private readonly string _internalFunctionName;
		private readonly string _typeName;
		private readonly IDictionary<string, string> _map;
		private readonly IList<Interval> _intervals = new List<Interval>();

		public PrefixTreeSelector(string functionName, string typeName, IDictionary<string, string> map)
		{
			_internalFunctionName = functionName;
			_typeName = typeName;
			_map = map;

			_privateFunctionName = char.ToLowerInvariant(functionName[0]) + functionName.Substring(1);

		}

		public void Add(string key, string value)
		{
			_map.Add(key, value);
		}

		public void AddInterval(string minKey, string maxKey, string value)
		{
			if(minKey.Length != maxKey.Length)
				throw new ArgumentException("mismatch key length");

			_intervals.Add(new Interval()
			{
				MinKey = minKey,
				MaxKey = maxKey,
				Value = value
			});
		}

		private class Interval
		{
			public string MinKey;
			public string MaxKey;
			public string Value;
		}

		public IEnumerable<string> Render()
		{
			var lengthList = _map.Keys.GroupBy(_ => _.Length).Select(_ => _.Key).OrderBy(_ => _).ToList();

			var result = renderLengthSelector(lengthList);

			foreach (var length in lengthList)
				result = result.Append("").Concat(renderCharSelectors(length));

			return result;
		}

		private IEnumerable<string> renderLengthSelector(List<int> lengthList)
		{
			yield return $"internal static {_typeName} {_internalFunctionName}(StringSpan span)";
			yield return "{";
			if (lengthList.Count == 1)
			{
				yield return $"	if(span.Length == {lengthList[0]})";
					yield return $"		return {_privateFunctionName}_L{lengthList[0]}(span);";
				yield return "	return null;";
			}
			else
			{
				yield return "	switch(span.Length)";
				yield return "	{";
				foreach (var length in lengthList)
					yield return $"		case {length}: return {_privateFunctionName}_L{length}(span);";
				yield return "		default: return null;";
				yield return "	}";
			}
			yield return "}";
		}

		private IEnumerable<string> renderCharSelectors(int length)
		{
			var keysGroup = _map.Keys.Where(_ => _.Length == length);
			var nodes = TreeNode.Convert(keysGroup.Select(_ => new KeyValuePair<string, string>(_, _map[_])));

			var result = renderCharSelector(length, "",
				nodes.Where(_ => _.Prefix.Length == 1).ToDictionary(_ => _.Prefix[0], _ => _.Value));
			foreach (var tailNode in nodes.Where(_ => _.Nested.Any()))
				result = result.Append("").Concat(renderCharSelector(length, tailNode.Prefix, tailNode.Nested.ToDictionary(_ => _.Key, _ => _.Value.Value)));

			return result;
		}

		private IEnumerable<string> renderCharSelector(int lengthGroup, string prefix, IDictionary<char, string> nested)
		{
			var methodSuffix = prefix == "" ? "" : "_" + prefix;
			yield return $"private static {_typeName} {_privateFunctionName}_L{lengthGroup}{methodSuffix}(StringSpan span)";
			yield return "{";
			if (prefix == "" && _intervals.Any(_ => _.MinKey.Length == lengthGroup))
			{
				foreach (var interval in _intervals.Where(_ => _.MinKey.Length == lengthGroup))
					yield return $"	if (\"{interval.MinKey}\" <= span && span <= \"{interval.MaxKey}\") return {interval.Value};";
				yield return "";
			}
			if (nested.Count == 1)
			{
				var pair = nested.First();
				yield return $"	if(Char.ToLowerInvariant(span[{prefix.Length}]) == '{pair.Key}')";
				if (prefix.Length < lengthGroup - 1)
					yield return
						$"		return {_privateFunctionName}_L{lengthGroup}_{prefix}{pair.Key}(span);";
				else
					yield return
						$"		return {pair.Value};";
				yield return "	return null;";
			}
			else
			{
				yield return $"	switch(span[{prefix.Length}])";
				yield return "	{";
				foreach (var pair in nested)
				{
					if (prefix.Length < lengthGroup - 1)
						yield return
							$"		case '{pair.Key}': return {_privateFunctionName}_L{lengthGroup}_{prefix}{pair.Key}(span);";
					else
						yield return
							$"		case '{pair.Key}': return {pair.Value};";
				}
				yield return "		default: return null;";
				yield return "	}";
			}
			yield return "}";
		}
	}
}