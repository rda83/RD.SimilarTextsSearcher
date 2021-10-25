using BenchmarkDotNet.Attributes;
using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;

namespace RD.SimilarTextsSearcher.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class SimilarTextsSearcherBenchmark
    {
        private InputData _textsForComparisonItem 
            = new InputData { Text1 = "Hello W1o2r3l4d", Text2 = "Hello World", Text1Id = "1", Text2Id = "2" };

        private SimilarTextsSearcher _simMetricsLibrary_Levenstein;
        private SimilarTextsSearcher _simMetricsLibrary_ChapmanMeanLength;
        private SimilarTextsSearcher _simMetricsLibrary_SmithWatermanGotohWindowedAffine;
        private SimilarTextsSearcher _simMetricsLibrary_SmithWatermanGotoh;
        private SimilarTextsSearcher _simMetricsLibrary_SmithWaterman;
        private SimilarTextsSearcher _simMetricsLibrary_QGramsDistance;
        private SimilarTextsSearcher _simMetricsLibrary_OverlapCoefficient;
        private SimilarTextsSearcher _simMetricsLibrary_NeedlemanWunch;
        private SimilarTextsSearcher _simMetricsLibrary_MongeElkan;
        private SimilarTextsSearcher _simMetricsLibrary_MatchingCoefficient;
        private SimilarTextsSearcher _simMetricsLibrary_JaroWinkler;
        private SimilarTextsSearcher _simMetricsLibrary_Jaro;
        private SimilarTextsSearcher _simMetricsLibrary_JaccardSimilarity;
        private SimilarTextsSearcher _simMetricsLibrary_EuclideanDistance;
        private SimilarTextsSearcher _simMetricsLibrary_DiceSimilarity;
        private SimilarTextsSearcher _simMetricsLibrary_CosineSimilarity;
        private SimilarTextsSearcher _simMetricsLibrary_ChapmanLengthDeviation;
        private SimilarTextsSearcher _simMetricsLibrary_BlockDistance;

        private SimilarTextsSearcher _fuzzySharp_Ratio;
        private SimilarTextsSearcher _fuzzySharp_PartialRatio;
        private SimilarTextsSearcher _fuzzySharp_TokenSortRatio;
        private SimilarTextsSearcher _fuzzySharp_PartialTokenSortRatio;
        private SimilarTextsSearcher _fuzzySharp_TokenSetRatio;
        private SimilarTextsSearcher _fuzzySharp_PartialTokenSetRatio;
        private SimilarTextsSearcher _fuzzySharp_TokenInitialismRatio;
        private SimilarTextsSearcher _fuzzySharp_PartialTokenInitialismRatio;
        private SimilarTextsSearcher _fuzzySharp_WeightedRatio;

        public SimilarTextsSearcherBenchmark()
        {
            #region SimMetricsLibrary

            _simMetricsLibrary_Levenstein = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary, 
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"Levenstein\"}" });

            _simMetricsLibrary_ChapmanMeanLength = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"ChapmanMeanLength\"}" });

            _simMetricsLibrary_SmithWatermanGotohWindowedAffine = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"SmithWatermanGotohWindowedAffine\"}" });

            _simMetricsLibrary_SmithWatermanGotoh = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"SmithWatermanGotoh\"}" });

            _simMetricsLibrary_SmithWaterman = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"SmithWaterman\"}" });

            _simMetricsLibrary_QGramsDistance = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"QGramsDistance\"}" });

            _simMetricsLibrary_OverlapCoefficient = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"OverlapCoefficient\"}" });

            _simMetricsLibrary_NeedlemanWunch = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"NeedlemanWunch\"}" });

            _simMetricsLibrary_MongeElkan = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"MongeElkan\"}" });

            _simMetricsLibrary_MatchingCoefficient = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"MatchingCoefficient\"}" });

            _simMetricsLibrary_JaroWinkler = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"JaroWinkler\"}" });

            _simMetricsLibrary_Jaro = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"Jaro\"}" });

            _simMetricsLibrary_JaccardSimilarity = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"JaccardSimilarity\"}" });

            _simMetricsLibrary_EuclideanDistance = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"EuclideanDistance\"}" });

            _simMetricsLibrary_DiceSimilarity = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"DiceSimilarity\"}" });

            _simMetricsLibrary_CosineSimilarity = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"CosineSimilarity\"}" });

            _simMetricsLibrary_ChapmanLengthDeviation = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"ChapmanLengthDeviation\"}" });

            _simMetricsLibrary_BlockDistance = new SimilarTextsSearcher(SearchEngineType.SimMetricsLibrary,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SimMetricType\": \"BlockDistance\"}" });

            #endregion

            #region FuzzySharp

            _fuzzySharp_Ratio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp, 
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"Ratio\"}" });

            _fuzzySharp_PartialRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"PartialRatio\"}" });

            _fuzzySharp_TokenSortRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"TokenSortRatio\"}" });

            _fuzzySharp_PartialTokenSortRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"PartialTokenSortRatio\"}" });

            _fuzzySharp_TokenSetRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"TokenSetRatio\"}" });

            _fuzzySharp_PartialTokenSetRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"PartialTokenSetRatio\"}" });

            _fuzzySharp_TokenInitialismRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"TokenInitialismRatio\"}" });

            _fuzzySharp_PartialTokenInitialismRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"PartialTokenInitialismRatio\"}" });

            _fuzzySharp_WeightedRatio = new SimilarTextsSearcher(SearchEngineType.FuzzySharp,
                 new ConfigurationFactoryFromJson { ConfigurationString = "{\"SearchMethod\": \"WeightedRatio\"}" });

            #endregion
        }

        #region SimMetricsLibrary

        [Benchmark]
        public void SimMetricsLibrary_Levenstein() {_simMetricsLibrary_Levenstein.GetSimilarity(_textsForComparisonItem);}

        [Benchmark]
        public void SimMetricsLibrary_ChapmanMeanLength() { _simMetricsLibrary_ChapmanMeanLength.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_SmithWatermanGotohWindowedAffine() { _simMetricsLibrary_SmithWatermanGotohWindowedAffine.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_SmithWatermanGotoh() { _simMetricsLibrary_SmithWatermanGotoh.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_SmithWaterman() { _simMetricsLibrary_SmithWaterman.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_QGramsDistance() { _simMetricsLibrary_QGramsDistance.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_OverlapCoefficient() { _simMetricsLibrary_OverlapCoefficient.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_NeedlemanWunch() { _simMetricsLibrary_NeedlemanWunch.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_MongeElkan() { _simMetricsLibrary_MongeElkan.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_MatchingCoefficient() { _simMetricsLibrary_MatchingCoefficient.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_JaroWinkler() { _simMetricsLibrary_JaroWinkler.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_Jaro() { _simMetricsLibrary_Jaro.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_JaccardSimilarity() { _simMetricsLibrary_JaccardSimilarity.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_EuclideanDistance() { _simMetricsLibrary_EuclideanDistance.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_DiceSimilarity() { _simMetricsLibrary_DiceSimilarity.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_CosineSimilarity() { _simMetricsLibrary_CosineSimilarity.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_ChapmanLengthDeviation() { _simMetricsLibrary_ChapmanLengthDeviation.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void SimMetricsLibrary_BlockDistance() { _simMetricsLibrary_BlockDistance.GetSimilarity(_textsForComparisonItem); }

        #endregion

        #region FuzzySharp

        [Benchmark]
        public void FuzzySharp_Ratio() { var result = _fuzzySharp_Ratio.GetSimilarity(_textsForComparisonItem);}

        [Benchmark]
        public void FuzzySharp_PartialRatio() { var result = _fuzzySharp_PartialRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_TokenSortRatio() { var result = _fuzzySharp_TokenSortRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_PartialTokenSortRatio() { var result = _fuzzySharp_PartialTokenSortRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_TokenSetRatio() { var result = _fuzzySharp_TokenSetRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_PartialTokenSetRatio() { var result = _fuzzySharp_PartialTokenSetRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_TokenInitialismRatio() { var result = _fuzzySharp_TokenInitialismRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_PartialTokenInitialismRatio() { var result = _fuzzySharp_PartialTokenInitialismRatio.GetSimilarity(_textsForComparisonItem); }

        [Benchmark]
        public void FuzzySharp_WeightedRatio() { var result = _fuzzySharp_WeightedRatio.GetSimilarity(_textsForComparisonItem); }

        #endregion
    }
}
