using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemoveNegativesandReverse
{
    public class Lists
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    squareNumbers.Add(input[i]);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < squareNumbers.Count; i++)
            {
                Console.Write("{0} ", squareNumbers[i]);
            }
            Console.WriteLine();
        }
    }
}
