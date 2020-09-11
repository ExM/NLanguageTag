using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NLanguageTag.Benchmark
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Parse>();
		}
	}

	[RPlotExporter]
	[HtmlExporter]
	[MinColumn, MaxColumn, MeanColumn, MedianColumn]
	[InvocationCount(1000000, 1000)]
	public class Parse
	{
		private int _languageIndex = 0;
		private int _regionIndex = 0;
		private int _scriptIndex = 0;
		private string _text;

		[GlobalSetup]
		public void GlobalSetup()
		{
		}

		[IterationSetup]
		public void IterationSetup()
		{
			_text = string.Join("-",
				SubtagSamples.Languages[_languageIndex],
				SubtagSamples.Scripts[_scriptIndex],
				SubtagSamples.Regions[_regionIndex]);

			_languageIndex = (_languageIndex + 17) % SubtagSamples.Languages.Count;
			_regionIndex = (_regionIndex + 19) % SubtagSamples.Regions.Count;
			_scriptIndex = (_scriptIndex + 23) % SubtagSamples.Scripts.Count;
		}

		[Benchmark]
		public LanguageTag LanguageScriptAndRegion() => LanguageTag.Parse(_text);
	}
}
