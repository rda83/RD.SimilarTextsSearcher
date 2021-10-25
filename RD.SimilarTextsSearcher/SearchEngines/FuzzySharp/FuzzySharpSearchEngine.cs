
using FuzzySharp;
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.SearchEngines.FuzzySharp
{
    class FuzzySharpSearchEngine : AbstractSearchEngine
    {
        private SearchMethod _searchMethod;

        public FuzzySharpSearchEngine(ConfigurationFuzzySharpLibrary conf)
        {
            _searchMethod = conf.SearchMethod;
        }

        public override double GetSimilarity(InputData textsForComparison)
        {
            double result = new();

            switch (_searchMethod)
            {
                case SearchMethod.PartialRatio:
                    result = Fuzz.PartialRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.PartialTokenInitialismRatio:
                    result = Fuzz.PartialTokenInitialismRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.PartialTokenSetRatio:
                    result = Fuzz.PartialTokenSetRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.PartialTokenSortRatio:
                    result = Fuzz.PartialTokenSortRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.Ratio:
                    result = Fuzz.Ratio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.TokenInitialismRatio:
                    result = Fuzz.TokenInitialismRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.TokenSetRatio:
                    result = Fuzz.TokenSetRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.TokenSortRatio:
                    result = Fuzz.TokenSortRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
                case SearchMethod.WeightedRatio:
                    result = Fuzz.WeightedRatio(textsForComparison.Text1, textsForComparison.Text2);
                    break;
            }

            return result;
        }
    }
}
