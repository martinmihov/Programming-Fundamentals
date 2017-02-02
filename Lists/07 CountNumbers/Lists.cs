using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CountNumbers
{
    public class Lists
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.Sort();
            // input.Add(int.MaxValue); <- variant 1 or after the loop copy/paste last Console.WriteLine
            int count = 1;
            int previous = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                int currentIndex = input[i];

                if (currentIndex == previous)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{previous} -> {count}");
                    count = 1;
                }

                previous = currentIndex;
            }
            Console.WriteLine($"{previous} -> {count}");
        }
    }
}
