using System;

namespace RotateAndSum
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int rotationCount = int.Parse(Console.ReadLine());

            int[] parsedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(numbers[i]);
            }

            int[] sum = new int[parsedNumbers.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                int lastNumber = parsedNumbers[parsedNumbers.Length - 1];

                for (int j = parsedNumbers.Length - 1; j > 0; j--)
                {
                    parsedNumbers[j] = parsedNumbers[j - 1];
                }
                parsedNumbers[0] = lastNumber;

                for (int k = 0; k < parsedNumbers.Length; k++)
                {
                    sum[k] += parsedNumbers[k];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}