namespace ProjectEuler
{
    using System;

    public class Problem19 : Problem
    {
        public override int Solve()
        {
            var sundaysCount = 0;

            var startDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 1);

            var currentDate = startDate;

            while(currentDate <= endDate)
            {
                // Check if it's a Sunday
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundaysCount++;
                }

                // Go to next month
                currentDate = currentDate.AddMonths(1);
            }

            return sundaysCount;
        }
    }
}
