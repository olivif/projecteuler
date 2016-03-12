namespace ProjectEuler
{
    using Combinatorics.Collections;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

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

        /// <summary>
        /// Get permutations of a list of chars
        /// </summary>
        /// <param name="list"></param>
        public static List<string> GetPermutations(char[] list)
        {
            var rawPermutations = new Permutations<char>(list);
            var permutations = rawPermutations.Select(chars => string.Join("", chars));
            
            return permutations.ToList();
        }

        /// <summary>
        /// Get a specific permutation
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetPermutation(char[] list, int index)
        {
            var rawPermutations = new Permutations<char>(list);
            var permutations = rawPermutations.Select(chars => string.Join("", chars)).ToList();

            if (permutations.Count <= index)
            {
                throw new ArgumentException("Index is beyond the number of permutations");
            }

            return permutations[index];
        }

        /// <summary>
        /// Gets the closest Fibonnaci term index that is larger than the limit
        /// </summary>
        /// <param name="limit">The limit of the fibbonnaci value</param>
        /// <returns>The index of the fibonnaci term</returns>
        public static ulong GetClosestFibbonnaci(BigInteger limit)
        {
            BigInteger previous = 1;
            BigInteger current = 1;
            ulong n = 2;

            while(current <= limit)
            {
                BigInteger temp = current;
                current = BigInteger.Add(current, previous);
                previous = temp;
                n++;

                Console.WriteLine("Term {0} is {1}", n, current);
            }

            return n;
        }

    }
}
