using FluentAssertions;
using Problems.Problem007;

namespace ProblemTests
{
    public class Problem007Tests
    {
        [Fact]
        public void FindNthPrimaryNumber_check_example()
        {
            // arrange
            var sut = new Solution007();

            // act
            var primeNumber = sut.FindNthPrimaryNumber(6);

            // assert
            primeNumber.Should().Be(13);
        }

        [Fact]
        public void FindNthPrimaryNumber_check_solution()
        {
            // arrange
            var sut = new Solution007();

            // act
            var primeNumber = sut.FindNthPrimaryNumber(10001);

            // assert
            primeNumber.Should().Be(104743L);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        public void FindNthPrimaryNumber_should_return_correct_value(long nthPrimeNumberToFind, long expectedPrimeNumber)
        {
            // arrange
            var sut = new Solution007();

            // act
            var primeNumber = sut.FindNthPrimaryNumber(nthPrimeNumberToFind);

            // assert
            primeNumber.Should().Be(expectedPrimeNumber);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(15)]
        public void IsPrime_should_return_false_when_not_a_prime_number(long numberToCheck)
        {
            // arrange
            var sut = new Solution007();

            // act
            var isPrimeNumber = sut.IsPrime(numberToCheck);

            // assert
            isPrimeNumber.Should().BeFalse();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        public void IsPrime_should_return_true_when_is_a_prime_number(long numberToCheck)
        {
            // arrange
            var sut = new Solution007();

            // act
            var isPrimeNumber = sut.IsPrime(numberToCheck);

            // assert
            isPrimeNumber.Should().BeTrue();
        }
    }
}
