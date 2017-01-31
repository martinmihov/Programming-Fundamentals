using System;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = 1;
            int start = 0;
            int bestLength = 1;
            int bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}