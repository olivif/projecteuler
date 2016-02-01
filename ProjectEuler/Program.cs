using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var problem = new Problem23();
            var solution = problem.Solve();

            stopWatch.Stop();
            var elapsedSeconds = stopWatch.ElapsedMilliseconds / 1000.0;

            Console.WriteLine("Found solution " + solution + " in " + elapsedSeconds + " seconds");
            Console.ReadKey();
        }
    }
}
