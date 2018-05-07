using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProblemTests
{
    public class Problem2Tests
    {
        [Fact]
        public void RunProblem2Test_check_fibonacci_numbers()
        {
            // arrange
            var expectedFibonacciNumbers = new List<Int64> { 1, 2, 3, 5, 8 };

            var sut = new Solution0002();

            // act
            var fibonacciNumbers = sut.FibonacciNumbers(10);

            // assert
            Assert.True(fibonacciNumbers.Max() <= 10, "Exceeded max value of 10.");
            Assert.Equal(expectedFibonacciNumbers, fibonacciNumbers);
        }

        [Fact]
        public void RunProblem2Test_check_even_fibonacci_numbers()
        {
            // arrange
            var expectedFibonacciNumbers = new List<Int64> { 2, 8 };

            var sut = new Solution0002();

            // act
            var evenFibonacciNumbers = sut.EvenFibonacciNumbers(10);

            // assert
            Assert.Equal(expectedFibonacciNumbers, evenFibonacciNumbers);
        }

        [Fact]
        public void RunProblem2Test_check_small_example()
        {
            // arrange
            var sut = new Solution0002();

            // act
            var sum = sut.SumOfEvenFibonacciNumbers(10);

            // assert
            Assert.Equal(10, sum);
        }

        [Fact]
        public void RunProblem2Test_check_solution()
        {
            // arrange
            var sut = new Solution0002();

            // act
            var sum = sut.SumOfEvenFibonacciNumbers(4000000);

            // assert
            Assert.Equal(4613732, sum);
        }
    }
}
