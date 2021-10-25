using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;
using System.Collections.Generic;
using Xunit;

namespace RD.SimilarTextsSearcher.Tests
{

    public class SimilarTextsSearcherTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { SearchEngineType.SimMetricsLibrary, "{\"SimMetricType\": \"Levenstein\"}" };
                yield return new object[] { SearchEngineType.FuzzySharp, "{\"SearchMethod\": \"Ratio\"}" };
            }
        }
    }

    public class SimilarTextsSearcherShould
    {
        [Trait("Category", "SimilarTextsSearcher")]
        [Theory]
        [MemberData(nameof(SimilarTextsSearcherTestData.TestData), 
            MemberType = typeof(SimilarTextsSearcherTestData))]
        public void SameMetricsForSameSetsOfIncomingData(SearchEngineType searchEngineType, 
            string configurationString) 
        {
            var sut = new SimilarTextsSearcher(
                searchEngineType,
                new ConfigurationFactoryFromJson
                {
                    ConfigurationString = configurationString
                });

            var inputData1 = new InputData 
            {
                Text1 = "Test text", 
                Text2 = "T1e2s3t t4e5x6t", 
                Text1Id = "1", 
                Text2Id = "2" 
            };

            var inputData2 = new InputData
            {
                Text1 = "Test text",
                Text2 = "T1e2s3t t4e5x6t",
                Text1Id = "1",
                Text2Id = "2"
            };

            var outputData1 = sut.GetSimilarity(inputData1);
            var outputData2 = sut.GetSimilarity(inputData2);

            Assert.True(outputData1.Similarity == outputData2.Similarity);
        }
    }
}
