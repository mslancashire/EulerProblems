namespace Problems.Problem009
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, $a < b < c$, for which,
    /// $a^2 + b^2 = c^2.
    /// 
    /// For example, $3^2 + 4^2 = 9 + 16 = 25 = 5^2$.
    /// 
    /// There exists exactly one Pythagorean triplet for which $a + b + c = 1000$.
    /// Find the product $abc$.
    /// </summary>
    public class Solution009
    {
        public (int A, int B, int C, long Product) CalculateProductOfSinglePythagoranTriplet(int target)
        {
            var boundary = target / 2;

            bool check(int a, int b, int c) => a + b + c == target;

            var pythagoranTriplets = FindPythagoranTriplets((int) boundary, check);

            var foundTarget = pythagoranTriplets.First(pt => pt.A + pt.B + pt.C == target);

            return (foundTarget.A, foundTarget.B, foundTarget.C, foundTarget.A * foundTarget.B * foundTarget.C);
        }

        public (int A, int B, int C, long Product) CalculateProductOfSinglePythagoranTriplet_v2(int target)
        {
            var boundary = target / 2;

            for (int a = 1; a < boundary; a++)
            {
                for (int b = a + 1; b < boundary; b++)
                {
                    //if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(target - a - b, 2))
                    if (a * a + b * b == (target - a - b) * (target - a - b))
                    {
                        int c = (int) CalculateC(a, b);

                        return (a, b, c, a * b * c);
                    }
                }
            }

            throw new Exception("Not found pt");
        }

        public IEnumerable<(int A, int B, int C)> FindPythagoranTriplets(int boundary, Func<int, int, int, bool>? check = null)
        {
            var pythagoranTriplents = new List<(int A, int B, int C)>();

            for (int a = 1; a < boundary; a++)
            {
                for (int b = a + 1; b < boundary; b++)
                {
                    for (int c = b + 1; c < boundary; c++)
                    {
                        if (IsPythagoranTriplet(a, b, c) && (check == null || check(a, b, c)))
                        {
                            pythagoranTriplents.Add((a, b, c));
                        }
                    }
                }
            }

            return pythagoranTriplents;
        }

        public bool IsPythagoranTriplet(int a, int b, int c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && a < b && b < c;
        }

        public double CalculateC(int a, int b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
