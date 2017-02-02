using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MaxSequance_of_Equal_Elements
{
    public class ListsExercises
    {
        public void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0;
            int bestStart = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }
                if(length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestLength + bestStart; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
