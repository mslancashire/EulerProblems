using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// 
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Solution0001
    {        
        public int SumOfMultiples(int[] of, int under)
        {
            return FindMultiples(of, under).Sum();
        }

        public List<int> FindMultiples(int[] of, int under)
        {
            var foundMultiples = new List<int>();
            var i = 1;

            do
            {
                if (of.Any(m => i % m == 0))
                {
                    foundMultiples.Add(i);
                }
                i++;
            }
            while (i < under);

            return foundMultiples;
        }
    }
}
