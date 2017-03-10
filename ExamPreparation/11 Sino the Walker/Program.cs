using System;
using System.Linq;
using System.Numerics;

namespace _11_Sino_the_Walker
{
    public class Program
    {
        public static void Main()
        {
            //DateTime leavesAt = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            int[] leavesAt = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int hours = leavesAt[0];
            int minutes = leavesAt[1];
            int seconds = leavesAt[2];

            int departureSeconds = (hours * 3600) + (minutes * 60) + seconds;

            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger eachStepInSeconds = BigInteger.Parse(Console.ReadLine());

            BigInteger inHomeFor = steps * eachStepInSeconds;
            BigInteger total = inHomeFor + departureSeconds;

            BigInteger hoursHome = (total / 3600) % 24;
            BigInteger minutesHome = (total % 3600) / 60;
            BigInteger secondsHome = total % 60;

            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", hoursHome, minutesHome, secondsHome);

            //var result = leavesAt.AddSeconds((int)inHomeFor);

            //Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
