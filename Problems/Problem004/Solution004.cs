namespace Problems.Problem004
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product to two 2-digit numbers is 9009 = 91 x 99.
    /// 
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Solution004
    {
        public int GetLargestPalindrome_v2(short digits)
        {
            var startingAt = GenerateMaxNumber(digits);
            var endingAt = GenerateMinNumber(digits);
            int largestPalindromicProduct = -1;

            for (var i = startingAt; i >= endingAt; i--)
            {
                var firstNumber = i;

                for (var j = startingAt; j >= endingAt; j--)
                {
                    var secondNumber = j;
                    var product = firstNumber * secondNumber;

                    if (IsPalindrome(product.ToString()) && product > largestPalindromicProduct)
                    {
                        largestPalindromicProduct = product;
                    }

                    // we can exit early if the product is no longer greater than the current largest palindromic product
                    if (product < largestPalindromicProduct)
                    {
                        break;
                    }
                }
            }

            if (largestPalindromicProduct != -1)
            {
                return largestPalindromicProduct;
            }

            throw new Exception($"A palindromic number was not found from the product start at {startingAt} and ending at {endingAt}.");
        }

        public int GetLargestPalindrome_v1(short digits)
        {
            var startingAt = GenerateMaxNumber(digits);
            var endingAt = GenerateMinNumber(digits);

            var palindromicProducts = new List<(int Product, int FirstNumber, int SecoundNumber)>();

            for (var i = 0; startingAt - i >= endingAt; i++)
            {
                var firstNumber = startingAt - i;

                for (var j = 0; startingAt - j >= endingAt; j++)
                {
                    var secondNumber = startingAt - j;
                    var product = firstNumber * secondNumber;

                    if (IsPalindrome(product.ToString()))
                    {
                        palindromicProducts.Add((product, firstNumber, secondNumber));
                    }
                }
            }

            if (palindromicProducts.Any())
            {
                return palindromicProducts.OrderByDescending(p => p.Product).First().Product;
            }

            throw new Exception($"A palindromic number was not found from the product start at {startingAt} and ending at {endingAt}.");
        }

        public int GenerateMaxNumber(short numOfDigits)
        {
            int generatedNumber = (int)(Math.Pow(10, numOfDigits) - 1);

            return generatedNumber;
        }

        public int GenerateMinNumber(short numOfDigits)
        {
            int generatedNumber = (int)(Math.Pow(10, numOfDigits - 1));

            return generatedNumber;
        }

        public bool IsPalindrome(string textToCheck)
        {
            if (string.IsNullOrWhiteSpace(textToCheck))
            {
                return false;
            }

            if (textToCheck.Any(c => char.IsWhiteSpace(c)))
            {
                throw new Exception($"{nameof(textToCheck)} must not contain any white space.");
            }

            for (var i = 0; i < textToCheck.Length; i++)
            {
                var endIndex = (textToCheck.Length - 1) - i;

                if (i > endIndex)
                {
                    break;
                }

                if (textToCheck[i] != textToCheck[endIndex])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
