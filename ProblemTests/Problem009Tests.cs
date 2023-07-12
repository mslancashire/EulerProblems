using FluentAssertions;
using Problems.Problem009;

namespace ProblemTests
{
    public class Problem009Tests
    {
        [Fact]
        public void CalculateProductOfSinglePythagoranTriplet_check_example()
        {
            // arrange
            var sut = new Solution009();

            // act
            var (A, B, C, Product) = sut.CalculateProductOfSinglePythagoranTriplet(12);

            // assert
            A.Should().Be(3);
            B.Should().Be(4);
            C.Should().Be(5);
            Product.Should().Be(60L);
        }

        [Fact]
        public void CalculateProductOfSinglePythagoranTriplet_check_solution()
        {
            // arrange
            var sut = new Solution009();

            // act
            var (A, B, C, Product) = sut.CalculateProductOfSinglePythagoranTriplet(1000);

            // assert
            A.Should().Be(200);
            B.Should().Be(375);
            C.Should().Be(425);
            Product.Should().Be(31875000L);
        }

        [Fact]
        public void CalculateProductOfSinglePythagoranTriplet_check_example_v2()
        {
            // arrange
            var sut = new Solution009();

            // act
            var (A, B, C, Product) = sut.CalculateProductOfSinglePythagoranTriplet_v2(12);

            // assert
            A.Should().Be(3);
            B.Should().Be(4);
            C.Should().Be(5);
            Product.Should().Be(60L);
        }

        [Fact]
        public void CalculateProductOfSinglePythagoranTriplet_check_solution_v2()
        {
            // arrange
            var sut = new Solution009();

            // act
            var (A, B, C, Product) = sut.CalculateProductOfSinglePythagoranTriplet_v2(1000);

            // assert
            A.Should().Be(200);
            B.Should().Be(375);
            C.Should().Be(425);
            Product.Should().Be(31875000L);
        }

        [Fact]
        public void IsPythagoranTriplet_should_return_true_for_example()
        {
            // arrange
            var sut = new Solution009();

            // act
            var isPythagoranTriplet = sut.IsPythagoranTriplet(3, 4, 5);

            // assert
            isPythagoranTriplet.Should().BeTrue();
        }

        [Fact]
        public void IsPythagoranTriplet_should_return_false()
        {
            // arrange
            var sut = new Solution009();

            // act
            var isPythagoranTriplet = sut.IsPythagoranTriplet(3, 6, 5);

            // assert
            isPythagoranTriplet.Should().BeFalse();
        }

        [Fact]
        public void CalculateC_should_return_5_when_a_and_b_are_3_and_4()
        {
            // arrange
            var sut = new Solution009();

            // act
            var c = sut.CalculateC(3, 4);

            // assert
            c.Should().Be(5);
        }
    }
}
