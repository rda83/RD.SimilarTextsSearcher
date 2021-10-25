namespace RD.SimilarTextsSearcher.SearchEngines.Configurations
{
    public interface IConfigurationFactory
    {
        string ConfigurationString { set; get; }
        T GetConfiguration<T>() where T: ISearchEngineConfiguration;
    }
}