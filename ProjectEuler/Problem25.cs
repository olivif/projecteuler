namespace ProjectEuler
{
    using System;
    using System.Numerics;

    public class Problem25 : Problem
    {
        public override int Solve()
        {
            var closest = Utils.GetClosestFibbonnaci(BigInteger.Pow(10, 999));

            Console.WriteLine(closest);
            return 1;
        }
    }
}