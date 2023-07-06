namespace Problems.Problem005
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// 
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Solution005
    {
        public int GetSmallestMultiple_v1(short from, short to, long max = 9999)
        {   
            for (int numberToCheck = to; numberToCheck <= max; numberToCheck++)
            {
                for (var currentDivisbleNumber = from; currentDivisbleNumber <= to; currentDivisbleNumber++)
                {
                    if (numberToCheck % currentDivisbleNumber != 0)
                    {
                        break;
                    }

                    if (currentDivisbleNumber == to)
                    {
                        return numberToCheck;
                    }
                }
            }

            throw new Exception($"Could not find smallest muliple using all numbers from {from} to {to} .");
        }

        public int GetSmallestMultiple_v2(short from, short to, long max = 9999)
        {
            var divisibleNumbers = Enumerable.Range(from, (to - from) + 1);

            for (int numberToCheck = to; numberToCheck <= max; numberToCheck++)
            {
                if (divisibleNumbers.All(n => numberToCheck % n == 0))
                {
                    return numberToCheck;
                }
            }

            throw new Exception($"Could not find smallest muliple using all numbers from {from} to {to} .");
        }
    }
}
