using FluentAssertions;
using Problems;

namespace ProblemTests;

public class Problem008Tests
{
    [Fact]
    public void FindLargestProduct_check_example()
    {
        // arrange
        var sut = new Solution008();
        
        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(4);

        // assert
        LargestProduct.Should().Be(5832);
        AdjacentDigits.Should().Be(9989);
        AdjacentDigits.ToString().Length.Should().Be(4);
    }

    [Fact]
    public void FindLargestProduct_check_solution()
    {
        // arrange
        var sut = new Solution008();
        
        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(13);

        // assert
        LargestProduct.Should().Be(23514624000);
        AdjacentDigits.Should().Be(5576689664895);
        AdjacentDigits.ToString().Length.Should().Be(13);

        // old short / int conversion issue
        //LargestProduct.Should().Be(2091059712);        
        //AdjacentDigits.Should().Be(9781797784617);
        //AdjacentDigits.ToString().Length.Should().Be(13);
    }

    [Fact]
    public void FindLargestProduct_should_return_4_when_provided_with_test_source_and_result_is_at_the_start()
    {
        // arrange
        var sut = new Solution008
        {
            Source = "2211"
        };

        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(2);

        // assert
        LargestProduct.Should().Be(4);
        AdjacentDigits.Should().Be(22);
        AdjacentDigits.ToString().Length.Should().Be(2);
    }

    [Fact]
    public void FindLargestProduct_should_return_4_when_provided_with_test_source_and_result_is_in_the_middle()
    {
        // arrange
        var sut = new Solution008
        {
            Source = "1221"
        };

        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(2);

        // assert
        LargestProduct.Should().Be(4);
        AdjacentDigits.Should().Be(22);
        AdjacentDigits.ToString().Length.Should().Be(2);
    }

    [Fact]
    public void FindLargestProduct_should_return_25_when_provided_with_test_source_and_result_is_at_the_end_with_white_space()
    {
        // arrange
        var sut = new Solution008
        {
            Source = @"1221 
                        1155 "
        };

        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(2);

        // assert
        LargestProduct.Should().Be(25);
        AdjacentDigits.Should().Be(55);
        AdjacentDigits.ToString().Length.Should().Be(2);
    }

    [Fact]
    public void FindLargestProduct_should_return_25_when_provided_with_test_source_and_result_is_at_the_end()
    {
        // arrange
        var sut = new Solution008
        {
            Source = @"12211155"
        };

        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(2);

        // assert
        LargestProduct.Should().Be(25);
        AdjacentDigits.Should().Be(55);
        AdjacentDigits.ToString().Length.Should().Be(2);
    }

    [Fact]
    public void FindLargestProduct_should_return_x_when_provided_with_test_source_and_result_is_at_the_end()
    {
        // arrange
        var sut = new Solution008
        {
            Source = @"111111111111111111111111111111511191111111111111111111111111111111111111111"
        };

        // act
        var (LargestProduct, AdjacentDigits) = sut.FindLargestProductOf(13);

        // assert
        LargestProduct.Should().Be(45);
        AdjacentDigits.Should().Be(1111111151119);
        AdjacentDigits.ToString().Length.Should().Be(13);
    }
}
