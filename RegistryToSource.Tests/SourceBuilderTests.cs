using System;
using NUnit.Framework;

namespace NLanguageTag.RegistryToSource
{
	public class SourceBuilderTests
	{
		[Test]
		public void Demo()
		{
			var src = new SourceBuilder("NLanguageTag")
				{
					Usings = new [] { "System" },
					Types = new []
					{
						new TypeBuilder()
						{
							Definition = new MemberDefinition() { "public readonly partial struct LanguageTag" },
							Members = new Members()
							{
								new MemberBuilder()
								{
									Comments = new Comments()
									{
										@"<summary>",
										@"Initializes new value of <see cref=""LanguageTag""/>",
										@"</summary>",
										@"<param name=""lang"">primary language</param>"
									},
									Definition = new MemberDefinition()
									{
										"public LanguageTag(Language lang)",
										": this(lang, null, null, default, default, default)"
									}
								},
								new MemberBuilder()
								{
									Comments = new Comments()
									{
										@"<summary>",
										@"Initializes new value of <see cref=""LanguageTag""/>",
										@"</summary>",
										@"<param name=""lang"">primary language</param>"
									},
									Definition = new MemberDefinition()
									{
										"public LanguageTag(Language lang2)",
										": this(lang, null, null, default, default, default)"
									}
								}


							}
						}


					}
				}
				.Build();

			Console.WriteLine(src);
		}

		[Test]
		public void Demo2()
		{
			var b = new MemberBuilder()
			{
				Comments = new Comments()
				{
					@"<summary>",
					@"Initializes new value of <see cref=""LanguageTag""/>",
					@"</summary>",
					@"<param name=""lang"">primary language</param>"
				},
				Definition = new MemberDefinition()
				{
					"public LanguageTag(Language lang)",
					": this(lang, null, null, default, default, default)"
				}
			};

			using var sw = new SourceWriter();

			b.Build(sw);

			Console.WriteLine(sw.ToString());
		}

		[Test]
		public void Demo3()
		{
			Console.WriteLine(CtorsBuilder.Create().Build());
		}
	}
}
