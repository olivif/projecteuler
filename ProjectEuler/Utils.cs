namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public class Utils
    {
        /// <summary>
        /// Get all divisors of a number including 1 and excluding itself
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static IEnumerable<int> GetDivisors(int number)
        {
            for (int potentialDivisor = 1; potentialDivisor <= number / 2; potentialDivisor++)
            {
                if (number % potentialDivisor == 0)
                {
                    yield return potentialDivisor;
                }
            }
        }

        /// <summary>
        /// Get factorial of x
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetFactorial(int number)
        {
            return Enumerable.Range(1, number).Aggregate((f, s) => f * s);
        }

        /// <summary>
        /// Get combinations - n!/ k!(n-k)!
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetCombinations(int n, int k)
        {
            return Utils.GetFactorial(n) / (Utils.GetFactorial(k) * Utils.GetFactorial(n - k));
        }

        /// <summary>
        /// A number is perfect if it is equal to the sum of its divisors
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPerfectNumber(int x)
        {
            return x == Utils.GetDivisors(x).Sum();
        }

        /// <summary>
        /// A number n is called deficient if the sum of its proper divisors is less than n
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsDeficientNumber(int x)
        {
            return Utils.GetDivisors(x).Sum() < x;
        }

        /// <summary>
        /// A number n is called abundant if the sum of its proper divisors exceeds n
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsAbundantNumber(int x)
        {
            return Utils.GetDivisors(x).Sum() > x;
        }
    }
}
