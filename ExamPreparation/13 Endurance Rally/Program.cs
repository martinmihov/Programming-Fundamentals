using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Endurance_Rally
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split().ToArray();
            decimal[] zones = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<string, decimal> fuelTanks = new Dictionary<string, decimal>();

            foreach (var driver in drivers)
            {
                decimal fuel = driver.First();

                for (int i = 0; i < zones.Length; i++)
                {
                    var currentZone = zones[i];
                    if (checkpoints.Contains(i))
                    {
                        fuel += currentZone;
                    }
                    else
                    {
                        fuel -= currentZone;
                    }
                    if(fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }

        }
    }
}
