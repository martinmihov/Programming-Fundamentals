using System;
using System.Linq;

namespace MaxSeqOfIncreasingElements
{
    public class program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCount = 0;
            int count = 0;
            int start = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                count = 0;
                    while (numbers[i + 1 + count] - numbers[i + count] == 1) // [i+1]  [i] == 1;
                {
                    count++;
                    if (i + 1 + count > numbers.Length - 1)
                    {
                        break;
                    }
                    
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    start = i;
                }
            }
                for (int i = start; i <= start + maxCount; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
