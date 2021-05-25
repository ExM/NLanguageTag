namespace NLanguageTag.RegistryToSource
{
	public class MemberBuilder
	{
		public Comments? Comments { get; set; }

		public MemberDefinition? Definition { get; set; }

		public void Build(SourceWriter sw)
		{
			Comments?.Build(sw);
			Definition?.Build(sw);

			sw.AppendLine("{");
			sw.AppendLine("}");
		}
	}
}