using RD.SimilarTextsSearcher.SearchEngines.Configurations;
using RD.SimilarTextsSearcher.SearchEngines.FuzzySharp;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public static class SearchEngineFactory
    {
        public static AbstractSearchEngine GetSearchEngine(SearchEngineType engineType, IConfigurationFactory confEngine)
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
                case SearchEngineType.FuzzySharp:
                {
                    var conf = confEngine.GetConfiguration<ConfigurationFuzzySharpLibrary>();
                    searchEngine = new FuzzySharpSearchEngine(conf);
                    break;
                    }
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
