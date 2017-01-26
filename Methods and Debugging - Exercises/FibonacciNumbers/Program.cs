using System;

namespace FibonacciNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciSequance(input));
        }

        public static int GetFibonacciSequance(int number)
        {
            int currentNumber = 1;
            int lastNumber = 0;
            int result = 0;

            for (int i = 0; i <= number; i++)
            {
                result = currentNumber + lastNumber;
                currentNumber = lastNumber;
                lastNumber = result;
            }

            return result;
        }
    }
}
