using Problems.Problem001;

namespace ProblemTests
{
    public class Problem001Tests
    {
        [Fact]
        public void RunProblem1Example_should_return_correct_result()
        {
            // arrange
            var upper = 10;
            var multiples = new int[] { 3, 5 };

            var sut = new Solution001();

            // act
            var natualNumbers = sut.FindMultiples(multiples, upper);

            // assert
            Assert.Equal(23, natualNumbers.Sum());
        }

        [Fact]
        public void RunProblem1_should_return_correct_result()
        {
            // arrange
            var upper = 1000;
            var multiples = new int[] { 3, 5 };

            var sut = new Solution001();

            // act
            var natualNumbers = sut.FindMultiples(multiples, upper);

            // assert
            Assert.Equal(233168, natualNumbers.Sum());
        }

        [Fact]
        public void RunProblem1_should_return_correct_number()
        {
            // arrange
            var upper = 1000;
            var multiples = new int[] { 3, 5 };

            var sut = new Solution001();

            // act
            var sum = sut.SumOfMultiples(multiples, upper);

            // assert
            Assert.Equal(233168, sum);
        }
    }
}