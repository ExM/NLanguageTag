using NLanguageTag.SourceCodeRenderer.FixedCodes;
using NLanguageTag.SourceCodeRenderer.SubtagRegistry;

namespace NLanguageTag.SourceCodeRenderer
{
	public abstract class RenderContext: TemplateClassBase
	{
		public Registry? Registry { get; set; }
		public ICodeMap? LanguageCode { get; set; }
		public ICodeMap? RegionCode { get; set; }
		public ICodeMap? ScriptCode { get; set; }
		public ICodeMap? VariantCode { get; set; }
	}
}
