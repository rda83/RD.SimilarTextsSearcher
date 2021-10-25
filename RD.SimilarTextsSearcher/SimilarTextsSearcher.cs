using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;

namespace RD.SimilarTextsSearcher
{
    public class SimilarTextsSearcher
    {
        private AbstractSearchEngine _searchEngine;
        public SearchEngineType SearchEngineType { get; }
        
        public SimilarTextsSearcher(SearchEngineType searchEngineType, IConfigurationFactory conf)
        {
            SearchEngineType = searchEngineType;
            _searchEngine = SearchEngineFactory.GetSearchEngine(SearchEngineType, conf);
        }

        public OutputData GetSimilarity(InputData textsForComparison)
        {
            double similarity = _searchEngine.GetSimilarity(textsForComparison);
            return new OutputData() { Value = textsForComparison, Similarity = similarity };
        }
    }
}
