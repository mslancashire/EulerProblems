using BenchmarkDotNet.Attributes;

namespace Problems.Problem005
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Solution005Benchmarks
    {
        public Solution005Benchmarks()
        {
        }

        [Benchmark(Baseline = true)]
        public void RunSolution_005_v1()
        {
            new Solution005().GetSmallestMultiple_v1(1, 20, 999999999);
        }

        [Benchmark]
        public void RunSolution_005_v2()
        {
            new Solution005().GetSmallestMultiple_v1(1, 20, 999999999);
        }
    }
}
