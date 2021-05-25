using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.SourceCodeRenderer.SubtagRegistry
{
	public class LinkNode
	{
		public Dictionary<char, LinkNode> Nested;
		public string Value;

		public static Dictionary<char, LinkNode> Convert(KeyValuePair<string, string>[] pairs)
		{
			if (pairs.Length == 0)
				return new Dictionary<char, LinkNode>();

			var result = new Dictionary<char, LinkNode>();

			foreach (var group in pairs.GroupBy(_ => _.Key[0]))
			{
				var nextLevel = group.Select(_ => new KeyValuePair<string, string>(_.Key.Substring(1), _.Value)).ToArray();

				result.Add(group.Key, new LinkNode()
				{
					Nested = Convert(nextLevel.Where(_ => _.Key != "").ToArray()),
					Value = nextLevel.Where(_ => _.Key == "").Select(_ => _.Value).FirstOrDefault()
				});
			}

			return result;
		}
	}
}