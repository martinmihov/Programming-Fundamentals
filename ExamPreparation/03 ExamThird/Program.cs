using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_ExamThird
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();

            List<long> hornetsGroups = Console.ReadLine().Split().Select(long.Parse).ToList();

            StringBuilder beesLeft = new StringBuilder();

            foreach (var beehive in beehives)
            {
                long hornetPower = hornetsGroups.Sum();
                long result = beehive - hornetPower;

                if(result > 0)
                {
                    beesLeft.Append(result + " ");
                    hornetsGroups.Remove(hornetsGroups[0]);
                }
                else if (result == 0)
                {
                    hornetsGroups.Remove(hornetsGroups[0]);
                }
            }
            if(beesLeft.Length == 0)
            {
                Console.WriteLine(string.Join(" ",hornetsGroups));
            }
            else
            {
                Console.WriteLine(beesLeft.ToString().Trim());
            }
            
        }
    }
}
