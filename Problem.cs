namespace ProjectEuler
{
    /// <summary>
    /// Abstract base class for every problem
    /// </summary>
    public abstract class Problem
    {
        /// <summary>
        /// Solve method which returns the result of the problem.
        /// </summary>
        /// <returns>An integer result</returns>
        public abstract int Solve();
    }
}
