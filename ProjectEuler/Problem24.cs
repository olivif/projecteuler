namespace ProjectEuler
{
    using System;

    public class Problem24 : Problem
    {
        public override int Solve()
        {
            var list = "0123456789".ToCharArray();
            var permutationIndex = 1000000 - 1;

            var permutation = Utils.GetPermutation(list, permutationIndex);           

            Console.WriteLine("Permutation {0}", permutation);

            return 0;
        }
    }
}