using System;

namespace PrimeChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;


            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
