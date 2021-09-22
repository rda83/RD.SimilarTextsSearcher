
using FuzzySharp;
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.SearchEngines.FuzzySharp
{
    class FuzzySharpSearchEngine : ISearchEngine
    {
        public double GetSimilarity(TextsForComparison textsForComparison)
        {
            //https://github.com/JakeBayer/FuzzySharp
            double result = Levenshtein.GetRatio(textsForComparison.inputText1,
                                                    textsForComparison.inputText2);

            return result;
        }
    }
}
