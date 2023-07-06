namespace Problems.Problem003
{
    /// <summary>
    /// The price factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143?
    /// </summary>
    public class Solution003
    {
        public long GatLargestPrimeFactor(long number)
        {
            return FindPrimeFactors(number).OrderDescending().First();
        }

        public IEnumerable<long> FindPrimeFactors(long number)
        {
            var factors = FindFactorsOf(number, false);

            var resolvedFactors = factors.ToDictionary(k => k, v => FindFactorsOf(v, false));

            var primeFactors = resolvedFactors.Where(rf => rf.Value.Any() == false);

            return primeFactors.Select(pf => pf.Key);
        }

        public IEnumerable<long> FindFactorsOf(long number, bool includeDivisonOfOne = true)
        {
            long ending = (long) Math.Sqrt(number);
            
            var factors = new List<long>();

            for (int factor = 1; factor <= ending; factor++)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);

                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }

            if (includeDivisonOfOne == false)
            {
                factors.Remove(1);
                factors.Remove(number);
            }

            return factors.Order();
        }
    }
}
