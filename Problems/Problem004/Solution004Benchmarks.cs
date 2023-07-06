﻿using BenchmarkDotNet.Attributes;

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
            var solution4 = new Solution004();
            
            var largestPalindromicProduct = solution4.GetLargestPalindrome_v1(3);

            Console.WriteLine($"Largest palindrome for a product of 3 digit numbers is {largestPalindromicProduct}.");
        }

        [Benchmark]
        public void RunSolution_v2()
        {
            var solution4 = new Solution004();

            var largestPalindromicProduct = solution4.GetLargestPalindrome_v2(3);

            Console.WriteLine($"Largest palindrome for a product of 3 digit numbers is {largestPalindromicProduct}.");
        }
    }
}
