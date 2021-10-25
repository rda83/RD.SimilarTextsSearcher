using BenchmarkDotNet.Running;
using System;

namespace RD.SimilarTextsSearcher.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SimilarTextsSearcherBenchmark>();
        }
    }
}
