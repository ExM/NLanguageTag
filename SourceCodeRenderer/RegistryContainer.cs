using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.SourceCodeRenderer
{
	public abstract class RegistryContainer: TemplateClassBase
	{
		public Registry Registry { get; set; }
	}
}
