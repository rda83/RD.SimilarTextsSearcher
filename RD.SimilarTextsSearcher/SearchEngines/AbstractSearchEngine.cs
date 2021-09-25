
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public abstract class AbstractSearchEngine
    {
        public abstract double GetSimilarity(TextsForComparison textsForComparison);
    }
}
