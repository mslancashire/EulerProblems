using FluentAssertions;
using Problems.Problem003;

namespace ProblemTests
{
    public class Problem003Tests
    {
        [Fact]
        public void RunProblemTest3_check_example()
        {
            // arrange
            var sut = new Solution003();

            // act
            var largestPrimeFactor = sut.GatLargestPrimeFactor(13195);

            // assert
            largestPrimeFactor.Should().Be(29);
        }

        [Fact]
        public void RunProblemTest3_check_solution()
        {
            // arrange
            var sut = new Solution003();

            // act
            var largestPrimeFactor = sut.GatLargestPrimeFactor(600851475143);

            // assert
            largestPrimeFactor.Should().Be(6857);
        }

        [Fact]
        public void FindFactorsOf_should_return_correct_factors_for_10()
        {
            // arrange
            var sut = new Solution003();

            // act
            var factors = sut.FindFactorsOf(10);

            // assert
            factors.Should().NotBeEmpty();
            factors.Should().Equal(1, 2, 5, 10);
        }

        [Theory]        
        [InlineData(10)]
        public void FindFactorsOf_should_return_correct_factors_use_exclude(int numberToCheck)
        {
            // arrange
            var sut = new Solution003();

            // act
            var factors = sut.FindFactorsOf(numberToCheck, false);

            // assert
            factors.Should().NotBeEmpty();
            factors.Should().Equal(2,5);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void FindFactorsOf_should_return_empty_factors_using_exclude_when_prime_number(int numberToCheck)
        {
            // arrange
            var sut = new Solution003();

            // act
            var factors = sut.FindFactorsOf(numberToCheck, false);

            // assert
            factors.Should().BeEmpty();
        }

        [Fact]
        public void FindFactorsOf_should_return_correct_factors_for_13195()
        {
            // arrange
            var sut = new Solution003();

            // act
            var factors = sut.FindFactorsOf(13195);

            // assert
            factors.Should().NotBeEmpty();
            factors.Should().Equal(1, 5, 7, 13, 29, 35, 65, 91, 145, 203, 377, 455, 1015, 1885, 2639, 13195);
        }

        [Fact]
        public void FindFactorsOf_should_return_correct_factors_for_13195_use_exclude()
        {
            // arrange
            var sut = new Solution003();

            // act
            var factors = sut.FindFactorsOf(13195, false);

            // assert
            factors.Should().NotBeEmpty();
            factors.Should().Equal(5, 7, 13, 29, 35, 65, 91, 145, 203, 377, 455, 1015, 1885, 2639);
        }

        [Fact]
        public void FindPrimeFactors_should_return_correct_prime_factors_for_10()
        {
            // arrange
            var sut = new Solution003();

            // act
            var primeFactors = sut.FindPrimeFactors(10);

            // assert
            primeFactors.Should().NotBeEmpty();
            primeFactors.Should().Equal(2, 5);
        }

        [Fact]
        public void FindPrimeFactors_should_return_correct_prime_factors_for_13195()
        {
            // arrange
            var sut = new Solution003();

            // act
            var primeFactors = sut.FindPrimeFactors(13195);

            // assert
            primeFactors.Should().NotBeEmpty();
            primeFactors.Should().Equal(5, 7, 13, 29);
        }


    }
}
