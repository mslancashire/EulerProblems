using BenchmarkDotNet.Attributes;

namespace Problems.Problem004
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Solution004Benchmarks
    {
        public Solution004Benchmarks()
        {
        }

        [Benchmark(Baseline = true)]
        public void RunSolution_v1()
        {
            new Solution004().GetLargestPalindrome_v1(3);
        }

        [Benchmark]
        public void RunSolution_v2()
        {
            new Solution004().GetLargestPalindrome_v2(3);
        }
    }
}
