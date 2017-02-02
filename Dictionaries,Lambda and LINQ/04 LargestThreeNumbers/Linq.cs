using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LargestThreeNumbers
{
    public class Linq
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(i => i)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
