namespace NLanguageTag.RegistryToSource
{
	public class TypeBuilder
	{
		public TypeBuilder()
		{
		}

		public Comments? Comments { get; set; }

		public MemberDefinition? Definition { get; set; }

		public Members? Members { get; set; }

		public void Build(SourceWriter sw)
		{
			Comments?.Build(sw);
			Definition?.Build(sw);
			sw.AppendLine("{");
			using (sw.Indent())
				Members?.Build(sw);
			sw.AppendLine("}");
		}
	}
}