using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NLanguageTag.RegistryToSource
{
	public class Members: IEnumerable<MemberBuilder>
	{
		private readonly List<MemberBuilder> _members = new ();

		public void Add(MemberBuilder line)
		{
			_members.Add(line);
		}

		public IEnumerator<MemberBuilder> GetEnumerator()
		{
			return _members.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Build(SourceWriter sw)
		{
			if (!_members.Any())
				return;

			_members.First().Build(sw);

			foreach (var member in _members.Skip(1))
			{
				sw.AppendLine();
				member.Build(sw);
			}
		}
	}
}