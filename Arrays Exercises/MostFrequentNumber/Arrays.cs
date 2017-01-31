using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            int maxCount = int.MinValue;
            int currentCount = 1;
            int mostFrequentNumber = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentNumber = numbers[i];
                }
            }
            if (numbers.Length == 1)
            {
                maxCount = 1;
                mostFrequentNumber = numbers[0];
            }
            Console.WriteLine(mostFrequentNumber);
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    count = 0;
            //    while (numbers[i + count] == numbers[i + 1 + count])
            //    {
            //        count++;
            //        if (i + 1 + count > numbers.Length - 1)
            //        {
            //            break;
            //        }
            //    }
            //    if (count > maxCount)
            //    {
            //        maxCount = count;
            //        start = i;
            //    }
            //}
            //for (int i = start; i <= start + maxCount; i++)
            //{
            //    Console.WriteLine($"{numbers[i]}");
            //    break;
            //}
        }
    }
}
