using FluentAssertions;
using Problems.Problem005;

namespace ProblemTests
{
    public class Problem005Tests
    {
        [Fact]
        public void GetSmallestMultiple_v1_check_example()
        {
            // arrange
            var sut = new Solution005();

            // act
            var smallestMultiple = sut.GetSmallestMultiple_v1(1, 10);

            // assert
            smallestMultiple.Should().Be(2520);
        }

        [Fact]
        public void GetSmallestMultiple_v2_check_example()
        {
            // arrange
            var sut = new Solution005();

            // act
            var smallestMultiple = sut.GetSmallestMultiple_v2(1, 10);

            // assert
            smallestMultiple.Should().Be(2520);
        }

        [Fact]
        public void GetSmallestMultiple_v1_check_solution()
        {
            // arrange
            var sut = new Solution005();

            // act
            var smallestMultiple = sut.GetSmallestMultiple_v1(1, 20, 999999999);

            // assert
            smallestMultiple.Should().Be(232792560);
        }

        [Fact(Skip = "Too Slow")]
        public void GetSmallestMultiple_v2_check_solution()
        {
            // arrange
            var sut = new Solution005();

            // act
            var smallestMultiple = sut.GetSmallestMultiple_v2(1, 20, 999999999);

            // assert
            smallestMultiple.Should().Be(232792560);
        }
    }
}
