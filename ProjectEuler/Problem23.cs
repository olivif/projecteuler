namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem23 : Problem
    {
        public override int Solve()
        {
            var limit = 28123;

            // Find all abundant numbers less than limit
            var abundantNumbers =
                Enumerable
                .Range(1, limit - 1)
                .Where(x => Utils.IsAbundantNumber(x))
                .ToList();

            Console.WriteLine("Found " + abundantNumbers.Count() + " abundant numbers");

            // Find all sums of two abundant numbers
            var sums = new List<int>();
            for (int i = 0; i < abundantNumbers.Count(); i++)
            {
                for (int j = i; j < abundantNumbers.Count(); j++)
                {
                    var sum = abundantNumbers[i] + abundantNumbers[j];

                    if (sum > limit)
                    {
                        break;
                    }
                    sums.Add(sum);
                }
            }

            Console.WriteLine("Found " + sums.Count() + " sums of abundant numbers");

            // Now get all numbers which are not sums of abundents and sum them up
            var nonSums = Enumerable.Range(0, limit + 1).Except(sums);

            Console.WriteLine("Found " + nonSums.Count() + " non sums of abundant numbers");

            return nonSums.Sum();
        }
    }
}