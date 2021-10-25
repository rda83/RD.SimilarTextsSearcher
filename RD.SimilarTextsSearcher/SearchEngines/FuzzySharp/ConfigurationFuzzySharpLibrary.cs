using Newtonsoft.Json.Converters;
using RD.SimilarTextsSearcher.SearchEngines.Configurations;
using System.Text.Json.Serialization;

namespace RD.SimilarTextsSearcher.SearchEngines.FuzzySharp
{
    class ConfigurationFuzzySharpLibrary : ISearchEngineConfiguration
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SearchMethod SearchMethod { set; get; }
    }
}
