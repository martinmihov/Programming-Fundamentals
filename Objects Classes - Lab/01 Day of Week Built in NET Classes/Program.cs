using System;
using System.Globalization;

namespace _01_Day_of_Week_Built_in_NET_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
