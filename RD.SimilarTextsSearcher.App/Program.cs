using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;
using System;
using System.Collections.Generic;


namespace RD.SimilarTextsSearcher.App
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SimilarTextsSearcher> SimilarTextsSearchers = new List<SimilarTextsSearcher>();

            IConfigurationFactory configurationSearchEngineSimMetricsLibrary
                    = new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"Levenstein\"}" };

            SimilarTextsSearchers.Add(
                    new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary, configurationSearchEngineSimMetricsLibrary)
                    );

            IConfigurationFactory configurationSearchEngineFuzzySharp
                    = new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"Ratio\"}" };

            SimilarTextsSearchers.Add(
                    new SimilarTextsSearcher(SearchEngineType.FuzzySharp, configurationSearchEngineFuzzySharp)
                    );


            List<InputData> textsForComparison = new List<InputData>();

            textsForComparison.Add(new InputData { Text1 = "Hello W1o2r3l4d", Text2 = "Hello World", Text1Id = "1", Text2Id = "2" });
            textsForComparison.Add(new InputData { Text1 = "Hello World123", Text2 = "Hello World", Text1Id = "1", Text2Id = "2" });

            foreach (var searcher in SimilarTextsSearchers)
            {
                foreach (var textsForComparisonItem in textsForComparison)
                {
                    var result = searcher.GetSimilarity(textsForComparisonItem);
                    Console.WriteLine($"Engine type: {searcher.SearchEngineType}");
                    Console.WriteLine($"  [{ result.Value.Text1Id}] [{ result.Value.Text1valueMD5}] *** [{ result.Value.Text2Id}] [{ result.Value.Text2valueMD5}] == [{ result.Similarity}]");
                }
            }
        }
    }
}
