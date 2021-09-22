
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public interface ISearchEngine
    {
       public double GetSimilarity(TextsForComparison textsForComparison);
    }
}
