
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SimMetrics.Net;

namespace RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary
{
    public class ConfigurationSimMetricsLibrary
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SimMetricType simMetricType { set; get; }
    }
}
