using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Real_Numbers
{
    public class Dictionaries
    {
        public static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var realNumber in input)
            {
                if (!count.ContainsKey(realNumber))
                {
                    count[realNumber] = 0;
                }
                count[realNumber]++;
            }

            foreach (var realNumber in count)
            {
                Console.WriteLine($"{realNumber.Key} -> {realNumber.Value}");
            }
        }
    }
}
