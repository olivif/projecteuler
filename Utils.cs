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
    }
}
