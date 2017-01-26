using System;
using System.Collections.Generic;

namespace PrimeInGivenRange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimeInRange(startNumber, endNumber);
            Console.WriteLine(string.Join(", ",primesInRange));
        }

        public static List<int> FindPrimeInRange(int startNumber, int endNumber)
        {
            var primes = new List<int>();

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                if (IsPrime(currentNumber))
                {
                    primes.Add(currentNumber);
                }
            }

            return primes;
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
