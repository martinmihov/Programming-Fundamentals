using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Softuni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalAmountOfWater = decimal.Parse(Console.ReadLine());

            decimal[] bottlesToFill = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            decimal bottleCapacity = decimal.Parse(Console.ReadLine());

            decimal waterUsed = 0M;

            List<long> indexesToFill = new List<long>();

            if(totalAmountOfWater % 2 == 0)
            {
                waterUsed = 0M;
                for (long i = 0; i < bottlesToFill.Length; i++)
                {
                    var currentBottleWaterFill = bottleCapacity - bottlesToFill[i];

                    waterUsed += currentBottleWaterFill;

                    if(totalAmountOfWater - waterUsed < 0m)
                    {
                        indexesToFill.Add(i);
                    }
                }
            }
            else
            {
                for (long i = bottlesToFill.Length - 1; i >= 0; i--)
                {
                    var currentBottleWaterFill = bottleCapacity - bottlesToFill[i];

                    waterUsed += currentBottleWaterFill;

                    if (totalAmountOfWater - waterUsed < 0m)
                    {
                        indexesToFill.Add(i);
                    }
                }
            }
            decimal water = totalAmountOfWater - waterUsed;

            if (totalAmountOfWater - waterUsed > 0m)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.", water);
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", indexesToFill.Count);
                Console.Write($"With indexes: ");
                Console.WriteLine("{0}", string.Join(", ",indexesToFill));
                Console.WriteLine($"We need {Math.Abs(totalAmountOfWater - waterUsed)} more liters!");
            }
        }
    }
}
