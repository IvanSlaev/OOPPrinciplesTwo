namespace RangeExceptions
{
    using System;

    public class RangeExceptionSystem
    {
        static void Main(string[] args)
        {
            int number = 1242;
            DateTime date = new DateTime(2016, 6, 24);

            int start = 1;
            int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("The number do not belong to the predefined range of numbers", start, end);
            }
            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("The date do not belong to the predefined period", startDate, endDate);
            }
        }
    }
}
