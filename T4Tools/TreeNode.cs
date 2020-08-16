using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.T4Tools
{
	public class TreeNode
	{
		public string Prefix;
		public Dictionary<char, LinkNode> Nested;
		public string Value;

		public static List<TreeNode> Convert(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			var result = new List<TreeNode>();
			var dic = LinkNode.Convert(pairs.ToArray());

			foreach(var pair in dic)
			{
				var node = new TreeNode();
				node.Prefix = pair.Key.ToString();
				node.Value = pair.Value.Value;
				node.Nested = pair.Value.Nested;
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
				var node = new TreeNode();
				node.Prefix = prefix + pair.Key.ToString();
				node.Value = pair.Value.Value;
				node.Nested = pair.Value.Nested;
				result.Add(node);
				result.AddRange(Convert(node.Prefix, pair.Value.Nested));
			}


			return result;
		}
	}
}