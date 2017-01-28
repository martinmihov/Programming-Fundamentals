using System;
namespace DayOfWeek
{
    public class Arrays 
    {
        public static void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] weekdays = {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if(dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(weekdays[dayNumber - 1]);
            }
        }
    }
}
