using Newtonsoft.Json;
using RD.SimilarTextsSearcher.SearchEngines.FuzzySharp;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;
using SimMetrics.Net;
using System.Text.Json;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public static class SearchEngineFactory
    {
        public static AbstractSearchEngine GetSearchEngine(SearchEngineType engineType, ConfigurationSearchEngine confEngine)
        {
            AbstractSearchEngine searchEngine;

            switch (engineType)
            {
                case SearchEngineType.SimMetricsLibrary:
                {
                    var conf = confEngine.GetConfiguration<ConfigurationSimMetricsLibrary>();    
                    searchEngine = new SimMetricsLibrarySearchEngine(conf);
                    break;
                }
                //case SearchEngineType.FuzzySharp:
                //{
                //    searchEngine = new FuzzySharpSearchEngine(conf);
                //    break;
                //}
                default: 
                { 
                    searchEngine = null;
                    break;
                }
            };
            return searchEngine;
        }
    }
}
