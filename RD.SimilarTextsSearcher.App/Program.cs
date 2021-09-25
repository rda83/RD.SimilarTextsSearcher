using Newtonsoft.Json;
using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;
using System;
using System.Collections.Generic;


namespace RD.SimilarTextsSearcher.App
{
    class Program
    {
        static void Main(string[] args)
        {



            List<SimilarTextsSearcher> SimilarTextsSearchers = new List<SimilarTextsSearcher>();

            ConfigurationSearchEngine configurationSearchEngine
                    = new SearchEngines.ConfigurationSearchEngine 
                        { ConfigurationString = "{\"simMetricType\": \"Levenstein\"}" };

            SimilarTextsSearchers.Add(
                    new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary, configurationSearchEngine)
                    );

            //SimilarTextsSearchers.Add(new SimilarTextsSearcher(SearchEngineType.FuzzySharp));

            List<TextsForComparison> textsForComparison = new List<TextsForComparison>();

            textsForComparison.Add(new TextsForComparison { inputText1 = "Hello W1o2r3l4d", inputText2 = "Hello World" });
            textsForComparison.Add(new TextsForComparison { inputText1 = "Hello World123", inputText2 = "Hello World" });

            foreach (var searcher in SimilarTextsSearchers)
            {
                foreach (var textsForComparisonItem in textsForComparison)
                {
                    Console.WriteLine($"Engine type: {searcher.SearchEngineType} - result: [{searcher.GetSimilarity(textsForComparisonItem)}]");
                }
            }
        }
    }
}
