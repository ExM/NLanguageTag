using System;
using System.IO;

namespace NLanguageTag.RegistryToSource.CodeTemplates
{
	public static class Resources
	{
		public static string Read(string name)
		{
			var resourceName = $"NLanguageTag.RegistryToSource.CodeTemplates.{name}.tt";
			using var stream = typeof(Resources).Assembly.GetManifestResourceStream(resourceName);
			if (stream == null)
				throw new Exception($"resource {resourceName} not found");
			using var reader = new StreamReader(stream);
			return reader.ReadToEnd();
		}
	}
}
