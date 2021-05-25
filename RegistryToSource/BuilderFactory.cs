using System.Collections.Generic;

namespace NLanguageTag.RegistryToSource
{
	public class BuilderFactory
	{
		public static readonly string BaseNamespace = "NLanguageTag";

		public static SourceBuilder Ctors()
		{
			var members = new Members();

			foreach (var s in new []{false, true})
			foreach (var r in new []{false, true})
			foreach (var v in new []{false, true})
			foreach (var e in new []{false, true})
			foreach (var p in new []{false, true})
			{
				var comments = new Comments()
				{
					@"<summary>",
					@"Initializes new value of <see cref=""LanguageTag""/>",
					@"</summary>",
					@"<param name=""lang"">primary language</param>"
				};
				if(s) comments.Add(@"<param name=""script"">script subtag</param>");
				if(r) comments.Add(@"<param name=""region"">region subtag</param>");
				if(v) comments.Add(@"<param name=""variants"">enumerate of variant subtags</param>");
				if(e) comments.Add(@"<param name=""extSubtags"">enumerate of extensions subtags</param>");
				if(p) comments.Add(@"<param name=""privateUseSubtags"">private use subtag</param>");

				var ctorArgs = new List<string>() { "Language lang" };
				if(s) ctorArgs.Add("Script? script");
				if(r) ctorArgs.Add("Region? region");
				if(v) ctorArgs.Add("IEnumerable<Variant>? variants");
				if(e) ctorArgs.Add("IEnumerable<ExtensionSubtag>? extSubtags");
				if(p) ctorArgs.Add("ExtensionSubtag privateUseSubtags");

				var thisArgs = new List<string>() { "lang"};
				thisArgs.Add(s ? "script" : "null");
				thisArgs.Add(r ? "region" : "null");
				thisArgs.Add(v ? $"VariantCollection.Create(lang, { (s ? "script": "null") }, variants)" : "default");
				thisArgs.Add(e ? "new ExtensionSubtagCollection(extSubtags)" : "default");
				thisArgs.Add(p ? "privateUseSubtags" : "default");

				members.Add(new MemberBuilder()
				{
					Comments = comments,
					Definition = new MemberDefinition()
					{
						$"public LanguageTag({string.Join(", ", ctorArgs)})",
						$": this({string.Join(", ", thisArgs)})"
					}
				});
			}

			var type = new TypeBuilder()
			{
				Definition = new MemberDefinition() { "public readonly partial struct LanguageTag" },
				Members = members
			};

			return new SourceBuilder(BaseNamespace)
			{
				Usings = new []{"System", "System.Collections.Generic"},
				Types = new [] { type }
			};
		}
		
		public static SourceBuilder Take()
		{
			var body = new BodyItems()
			{
				@"
if (fields == Field.All)
	return this;",
				"",
				@"
if (Language is null)
{
	return fields.HasFlag(Field.PrivateUse)
		? new LanguageTag(PrivateUse)
		: new LanguageTag(null, null, null, default, default, default);
}",
				"",
				@"
switch(fields)
{",
				@"
	case Field.PrivateUse:
		return new LanguageTag(PrivateUse);
	default:
		return new LanguageTag();
}"
			};

			var type = new TypeBuilder()
			{
				Definition = new MemberDefinition() { "public readonly partial struct LanguageTag" },
				Members = new Members()
				{
					new MemberBuilder()
					{
						Comments = new Comments()
						{
							"<summary>",
							"Creates language tag that consists of specified fields of this language tag",
							"</summary>"
						},
						Definition = new MemberDefinition()
						{
							$"public LanguageTag Take(Field fields)"
						},
						Body = body
					}
				}
			};

			return new SourceBuilder(BaseNamespace)
			{
				Usings = new [] { "System" },
				Types = new [] { type }
			};
		}
	}
}
