using Newtonsoft.Json;
using RD.SimilarTextsSearcher.SearchEngines.SimMetricsLibrary;

namespace RD.SimilarTextsSearcher.SearchEngines
{
    public class ConfigurationSearchEngine 
    {
        public string ConfigurationString { set; get; }
        // сделать валидацию
        internal T GetConfiguration<T>()
        {
            return JsonConvert.DeserializeObject<T>(ConfigurationString);
        }
    }
}