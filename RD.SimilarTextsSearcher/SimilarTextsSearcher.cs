using RD.SimilarTextsSearcher.Models;
using RD.SimilarTextsSearcher.SearchEngines;

namespace RD.SimilarTextsSearcher
{
    public class SimilarTextsSearcher
    {
        private ISearchEngine _searchEngine;
        public SearchEngineType SearchEngineType { get; }
        
        public SimilarTextsSearcher(SearchEngineType searchEngineType)
        {
            SearchEngineType = searchEngineType;
            _searchEngine = SearchEngineFactory.GetSearchEngine(SearchEngineType);
        }

        public double GetSimilarity(TextsForComparison textsForComparison)
        {
            
            double result = _searchEngine.GetSimilarity(textsForComparison);

            return result;
        }

        // точка входа
        // демо приложение
        // Разные движки поиска SearchEngines (SimMetrics library, FuzzySharp)
        // Модель входящих данных (разные источники входящих данных)
        // Модель ответа
        // Визуализация (объект, json, таблица(библиотека TUI))
        // Многопоточность
        // Бенчмарки (Benchmarkdotnet)
    }
}
