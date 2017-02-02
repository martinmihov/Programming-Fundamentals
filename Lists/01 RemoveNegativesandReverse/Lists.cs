using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemoveNegativesandReverse
{
    public class Lists
    {
        public  static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.RemoveAll(x => x < 0);
            input.Reverse();

            if(input.Count == 0) {
                Console.WriteLine("empty");
            }
            else {
                for (int i = 0; i < input.Count; i++) {
                    Console.Write($"{input[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
