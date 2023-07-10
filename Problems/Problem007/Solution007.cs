using Problems.Problem003;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems.Problem007
{
    /// <summary>
    /// By listing the first six prime numbers 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number.
    /// </summary>
    public class Solution007
    {
        public long FindNthPrimaryNumber(long nthPrimaryNumber)
        {
            var currentNumber = 1L;
            var currentPrimeIndex = 0L;
            var currentPrimeNumber = 0L;
            //var helper = new Solution003();
            
            do
            {
                currentNumber++;

                if (IsPrime(currentNumber))
                {
                    currentPrimeIndex++;
                    currentPrimeNumber = currentNumber;
                }
            } while (currentPrimeIndex < nthPrimaryNumber);

            return currentPrimeNumber;
        }

        public bool IsPrime(long numberToCheck)
        {
            if (numberToCheck <= 1)
            {
                return false;
            }
            if (numberToCheck == 2)
            {
                return true;
            }
            if (numberToCheck % 2 == 0)
            {
                return false;
            }

            long ending = (long) Math.Floor(Math.Sqrt(numberToCheck));

            for (long factor = 3; factor <= ending; factor += 2)
            {
                if (numberToCheck % factor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
