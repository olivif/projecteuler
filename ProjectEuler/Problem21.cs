namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem21 : Problem
    {
        //Evaluate the sum of all the amicable numbers under 10000.
        public override int Solve()
        {
            var maxX = 10000;

            // build a list of x -> d(x)
            var dXList = new List<Tuple<int, int>>();

            for (int x = 1; x < maxX; x++)
            {
                var dX = Utils.GetDivisors(x).Sum();

                dXList.Add(new Tuple<int, int>(x, dX));
            }

            var amicableNumbers = dXList
                .Where(tuple => 
                    tuple.Item1 != tuple.Item2 && 
                    dXList.Any(t => t.Item1 == tuple.Item2 && t.Item2 == tuple.Item1));

            Console.WriteLine(String.Join(" ", amicableNumbers));

            var amicableNumbersSum = amicableNumbers.Sum(t => t.Item1);

            return amicableNumbersSum;
        }
    }
}