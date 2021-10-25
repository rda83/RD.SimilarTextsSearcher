
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;
using SimMetrics.Net;

namespace RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary
{
    public class ConfigurationSimMetricsLibrary : ISearchEngineConfiguration
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SimMetricType SimMetricType { set; get; }
    }
}
