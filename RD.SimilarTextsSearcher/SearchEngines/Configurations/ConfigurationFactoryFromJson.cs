using Newtonsoft.Json;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;

namespace RD.SimilarTextsSearcher.SearchEngines.Configurations
{
    public class ConfigurationFactoryFromJson : IConfigurationFactory
    {
        public string ConfigurationString { get; set; }

        public T GetConfiguration<T>() where T : ISearchEngineConfiguration
        {
            return JsonConvert.DeserializeObject<T>(ConfigurationString);
        }
    }
}