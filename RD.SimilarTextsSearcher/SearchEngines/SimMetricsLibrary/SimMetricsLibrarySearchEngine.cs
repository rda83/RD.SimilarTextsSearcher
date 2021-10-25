using SimMetrics.Net;
using SimMetrics.Net.API;
using SimMetrics.Net.Metric;
using RD.SimilarTextsSearcher.Models;

namespace RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary
{
    class SimMetricsLibrarySearchEngine : AbstractSearchEngine
    {
        private IStringMetric _stringMetric;

        public SimMetricsLibrarySearchEngine(ConfigurationSimMetricsLibrary conf)
        {

            switch (conf.SimMetricType)
            {
                case SimMetricType.BlockDistance:
                    _stringMetric = new BlockDistance();
                    break;
                case SimMetricType.ChapmanLengthDeviation:
                    _stringMetric = new ChapmanLengthDeviation();
                    break;
                case SimMetricType.CosineSimilarity:
                    _stringMetric = new CosineSimilarity();
                    break;
                case SimMetricType.DiceSimilarity:
                    _stringMetric = new DiceSimilarity();
                    break;
                case SimMetricType.EuclideanDistance:
                    _stringMetric = new EuclideanDistance();
                    break;
                case SimMetricType.JaccardSimilarity:
                    _stringMetric = new JaccardSimilarity();
                    break;
                case SimMetricType.Jaro:
                    _stringMetric = new Jaro();
                    break;
                case SimMetricType.JaroWinkler:
                    _stringMetric = new JaroWinkler();
                    break;
                case SimMetricType.MatchingCoefficient:
                    _stringMetric = new MatchingCoefficient();
                    break;
                case SimMetricType.MongeElkan:
                    _stringMetric = new MongeElkan();
                    break;
                case SimMetricType.NeedlemanWunch:
                    _stringMetric = new NeedlemanWunch();
                    break;
                case SimMetricType.OverlapCoefficient:
                    _stringMetric = new OverlapCoefficient();
                    break;
                case SimMetricType.QGramsDistance:
                    _stringMetric = new QGramsDistance();
                    break;
                case SimMetricType.SmithWaterman:
                    _stringMetric = new SmithWaterman();
                    break;
                case SimMetricType.SmithWatermanGotoh:
                    _stringMetric = new SmithWatermanGotoh();
                    break;
                case SimMetricType.SmithWatermanGotohWindowedAffine:
                    _stringMetric = new SmithWatermanGotohWindowedAffine();
                    break;
                case SimMetricType.ChapmanMeanLength:
                    _stringMetric = new ChapmanMeanLength();
                    break;
                case SimMetricType.Levenstein:
                    _stringMetric = new Levenstein();
                    break;
            }
        }

        public override double GetSimilarity(InputData textsForComparison)
        {
            double result = _stringMetric.GetSimilarity(textsForComparison.Text1,
                                                            textsForComparison.Text2);

            return result;
        }
    }
}
