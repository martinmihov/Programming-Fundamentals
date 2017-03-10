using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _21_Charity_Marathon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            short days = short.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            sbyte averageLapsPerRunner = sbyte.Parse(Console.ReadLine());
            int lapLengthInMeters = int.Parse(Console.ReadLine());
            short trackCapacity = short.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            decimal possibleRunnersAmount = days * trackCapacity;
            decimal numberOfRunnersOnTrack = Math.Min(possibleRunnersAmount, runners);
            decimal totalLaps = numberOfRunnersOnTrack * averageLapsPerRunner;
            decimal distanceRanByAllRunners = (totalLaps * lapLengthInMeters) / 1000;
            decimal moneyRaised = distanceRanByAllRunners * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
