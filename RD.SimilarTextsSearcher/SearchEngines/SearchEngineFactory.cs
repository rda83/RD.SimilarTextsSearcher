using RD.SimilarTextsSearcher.SearchEngines.FuzzySharp;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public static class SearchEngineFactory
    {
        public static ISearchEngine GetSearchEngine(SearchEngineType engineType)
        {
            ISearchEngine searchEngine;

            switch (engineType)
            {
                case SearchEngineType.SimMetricsLibrary:
                {
                    searchEngine = new SimMetricsLibrarySearchEngine();
                    break;
                }
                case SearchEngineType.FuzzySharp:
                {
                    searchEngine = new FuzzySharpSearchEngine();
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
