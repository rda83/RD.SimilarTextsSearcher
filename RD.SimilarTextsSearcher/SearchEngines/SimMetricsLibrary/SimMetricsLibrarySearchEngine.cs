using RD.SimilarTextsSearcher.Models;
using SimMetrics.Net.API;
using SimMetrics.Net.Metric;

namespace RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary
{
    class SimMetricsLibrarySearchEngine : ISearchEngine
    {
        private IStringMetric _stringMetric;

        public SimMetricsLibrarySearchEngine()
        {
            _stringMetric = new Levenstein();
        }

        public double GetSimilarity(TextsForComparison textsForComparison)
        {
            double result = _stringMetric.GetSimilarity(textsForComparison.inputText1,
                                                            textsForComparison.inputText2);

            return result;
        }
    }
}
