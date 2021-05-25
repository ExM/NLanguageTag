namespace NLanguageTag.RegistryToSource
{
	public class SourceBuilder
	{
		private readonly string _ns;

		public SourceBuilder(string ns)
		{
			_ns = ns;
		}

		public string[]? Usings { get; set; }

		public TypeBuilder[]? Types { get; set; }

		public string Build()
		{
			using var sw = new SourceWriter();

			if(Usings != null)
				foreach (var usingItem in Usings)
					sw.AppendLine($"using {usingItem};");
			sw.AppendLine();

			sw.AppendLine($"namespace {_ns}");
			sw.AppendLine("{");

			if(Types != null)
				using (sw.Indent())
				{
					var firstBlock = true;
					foreach (var typeBuilder in Types)
					{
						if (!firstBlock)
							sw.AppendLine();
						firstBlock = false;
						typeBuilder.Build(sw);
					}
				}

			sw.AppendLine("}");
			return sw.ToString();
		}

	}
}