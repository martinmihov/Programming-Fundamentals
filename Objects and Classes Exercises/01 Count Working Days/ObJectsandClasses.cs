using System;
using System.Globalization;
using System.Collections.Generic;

namespace _01_Count_Working_Days
{
    public class ObjectsAndClasses
    {
        public static void Main(string[] args)
        {

            DateTime startDate = DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            List<DateTime> officialHolidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            int workingDays = 0;

            for (DateTime currentDate = startDate;
                currentDate <= endDate;
                currentDate = currentDate.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, currentDate.Month, currentDate.Day);

                workingDays++;
                if (currentDate.DayOfWeek == DayOfWeek.Saturday ||
                    currentDate.DayOfWeek == DayOfWeek.Sunday ||
                    officialHolidays.Contains(checkDate))
                {
                    workingDays -= 1;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}
