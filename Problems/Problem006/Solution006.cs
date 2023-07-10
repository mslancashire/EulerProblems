namespace Problems.Problem006
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    ///     2 sq + 2 sq + ... 10 sq = 385.
    /// 
    /// The square of the sim of the first ten natural numbers is,
    ///     (1 + 2 + ... + 10)  sq = 55 sq = 3025
    /// 
    /// Hence the difference between the sim of the squares of the first natural number and the square of the sum is
    /// 3025 - 385 = 2640.
    /// 
    /// Find the difference between the sum of the squares of the first one hunderes natural numbers and the sqaure of the sum.
    /// </summary>
    public class Solution006
    {
        public double GetDifferenceBetweenSqauresAndSumOfSquares(int from, int to, double power = 2)
        {
            var numbers = Enumerable.Range(from, to);

            double sumOfSqaures = CalculateSumOfSquares(numbers, power);

            var squareRootOfSum = CalculateSqaureRootOfSum(numbers, power);

            return squareRootOfSum - sumOfSqaures;
        }

        public double CalculateSumOfSquares(IEnumerable<int> numbers, double power = 2)
        {
            return numbers.Aggregate(0D, (total, next) => total += Math.Pow(next, power));
        }

        public double CalculateSqaureRootOfSum(IEnumerable<int> numbers, double power = 2)
        {
            return Math.Pow(numbers.Sum(), power);
        }
    }
}
