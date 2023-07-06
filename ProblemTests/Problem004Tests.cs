using FluentAssertions;
using Problems.Problem004;

namespace ProblemTests
{
    public class Problem004Tests
    {
        [Fact]
        public void RunProblemTest4_check_example()
        {
            // arrange
            var sut = new Solution004();

            // act
            var largestPalindrome = sut.GetLargestPalindrome_v1(2);

            // assert
            largestPalindrome.Should().Be(9009);
        }

        [Fact]
        public void RunProblemTest4_check_solution_v1()
        {
            // arrange
            var sut = new Solution004();

            // act
            var largestPalindrome = sut.GetLargestPalindrome_v1(3);

            // assert
            largestPalindrome.Should().Be(906609);
        }

        [Fact]
        public void RunProblemTest4_check_solution_v2()
        {
            // arrange
            var sut = new Solution004();

            // act
            var largestPalindrome = sut.GetLargestPalindrome_v2(3);

            // assert
            largestPalindrome.Should().Be(906609);
        }

        [Fact]
        public void IsPalindrome_should_return_false_when_text_is_empty()
        {
            // arrange
            var sut = new Solution004();

            // act
            var isPalindrome = sut.IsPalindrome("");

            // assert
            isPalindrome.Should().BeFalse();
        }

        [Fact]
        public void IsPalindrome_should_throw_execption_when_text_contains_whitesapce()
        {
            // arrange
            var sut = new Solution004();

            // act // assert
            Assert.Throws<Exception>(() => sut.IsPalindrome("sdfs sds"));
        }

        [Fact]
        public void IsPalindrome_should_return_false_when_text_is_not_a_palindrome()
        {
            // arrange
            var sut = new Solution004();

            // act
            var isPalindrome = sut.IsPalindrome("dfdsfs");

            // assert
            isPalindrome.Should().BeFalse();
        }

        [Theory]
        [InlineData("a")]
        [InlineData("aa")]
        [InlineData("aba")]
        [InlineData("aaaa")]
        [InlineData("cabac")]
        public void IsPalindrome_should_return_true_when_text_is_a_palindrome(string textToCheck)
        {
            // arrange
            var sut = new Solution004();

            // act
            var isPalindrome = sut.IsPalindrome(textToCheck);

            // assert
            isPalindrome.Should().BeTrue();
        }

        [Theory]
        [InlineData(1, 9)]
        [InlineData(2, 99)]
        [InlineData(3, 999)]
        [InlineData(4, 9999)]
        public void GenerateMaxNumber_should_generate_a_max_number_of_lenght_of_provided_digits(short digits, int expectedNumber)
        {
            // arrange
            var sut = new Solution004();

            // act
            var generatedMaxNumber = sut.GenerateMaxNumber(digits);

            // assert
            generatedMaxNumber.Should().Be(expectedNumber);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 10)]
        [InlineData(3, 100)]
        [InlineData(4, 1000)]
        public void GenerateMinNumber_should_generate_a_min_number_of_lenght_of_provided_digits(short digits, int expectedNumber)
        {
            // arrange
            var sut = new Solution004();

            // act
            var generatedMaxNumber = sut.GenerateMinNumber(digits);

            // assert
            generatedMaxNumber.Should().Be(expectedNumber);
        }
    }
}
