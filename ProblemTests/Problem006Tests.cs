using FluentAssertions;
using Problems.Problem006;

namespace ProblemTests
{
    public class Problem006Tests
    {
        [Fact]
        public void GetDifferenceBetweenSumOfSqauresAndSqaureOfSum_check_example()
        {
            // arrange
            var sut = new Solution006();

            // act
            var difference = sut.GetDifferenceBetweenSqauresAndSumOfSquares(1, 10);

            // assert
            difference.Should().Be(2640D);
        }

        [Fact]
        public void GetDifferenceBetweenSumOfSqauresAndSqaureOfSum_check_solution()
        {
            // arrange
            var sut = new Solution006();

            // act
            var difference = sut.GetDifferenceBetweenSqauresAndSumOfSquares(1, 100);

            // assert
            difference.Should().Be(25164150);
        }

        [Fact]
        public void CalculateSumOfSquares_should_return_385_when_using_from_1_to_10()
        {
            // arrange
            var sut = new Solution006();

            // act
            var sumOfSqaures = sut.CalculateSumOfSquares(Enumerable.Range(1, 10));

            // assert
            sumOfSqaures.Should().Be(385);
        }

        [Fact]
        public void CalculateSqaureRootOfSum_should_return_3025_when_using_from_1_to_10()
        {
            // arrange
            var sut = new Solution006();

            // act
            var sumOfSqaures = sut.CalculateSqaureRootOfSum(Enumerable.Range(1, 10));

            // assert
            sumOfSqaures.Should().Be(3025);
        }
    }
}
