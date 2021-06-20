using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class TreeNode
	{
		public string Prefix { get; }
		public Dictionary<char, LinkNode> Nested { get; }
		public string? Value { get; }

		public TreeNode(string prefix, Dictionary<char, LinkNode> nested, string? value)
		{
			Prefix = prefix;
			Nested = nested;
			Value = value;
		}

		public static List<TreeNode> Convert(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			var result = new List<TreeNode>();
			var dic = LinkNode.Convert(pairs.ToArray());

			foreach(var pair in dic)
			{
				var node = new TreeNode(
					pair.Key.ToString(),
					pair.Value.Nested,
					pair.Value.Value);
				result.Add(node);
				result.AddRange(Convert(node.Prefix, pair.Value.Nested));
			}

			return result;
		}

		public static List<TreeNode> Convert(string prefix, Dictionary<char, LinkNode> dic)
		{
			var result = new List<TreeNode>();

			foreach(var pair in dic)
			{
				var node = new TreeNode(
					prefix + pair.Key,
					pair.Value.Nested,
					pair.Value.Value);
				result.Add(node);
				result.AddRange(Convert(node.Prefix, pair.Value.Nested));
			}

			return result;
		}
	}
}
