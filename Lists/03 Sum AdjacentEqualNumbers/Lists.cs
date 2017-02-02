using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Sum_AdjacentEqualNumbers
{
    public class Lists
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
            for (int i = 1; i < input.Count; i++)
            {
                if(input[i] == input[i - 1]) {
                    input[i] = input[i] + input[i - 1];
                    input.RemoveAt(i - 1);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
