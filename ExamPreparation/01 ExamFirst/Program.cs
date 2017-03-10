using System;
using System.Numerics;

namespace _01_ExamFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ulong wingFlaps = ulong.Parse(Console.ReadLine());
            decimal distancePer1000Meters = decimal.Parse(Console.ReadLine());
            ulong endurance = ulong.Parse(Console.ReadLine());

            ulong distanceMeters = (wingFlaps / 1000);
            decimal distance = distanceMeters * distancePer1000Meters;

            BigInteger timeHornetFlied = wingFlaps / 100;

            BigInteger timeRested = wingFlaps / endurance;

            BigInteger timeInSecondsRested = timeRested * 5;

            BigInteger total = timeHornetFlied + timeInSecondsRested;

            
            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.",total);


        }
    }
}
