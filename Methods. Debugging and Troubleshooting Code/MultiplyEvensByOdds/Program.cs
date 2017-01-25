using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int OddMultipliedByEven = (GetOdd(n) * GetEven(n));
            Console.WriteLine(OddMultipliedByEven);
        }
        public static int GetEven(int n)
        {
            int sumOfEvenDigits = 0;
            do
            {
                int lastDigit = n % 10;
                int newDigit = n / 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                }
                n = newDigit;
            } while (n > 0);
            return sumOfEvenDigits;
        }
        public static int GetOdd(int n)
        {
            int sumOfOddDigits = 0;
            do
            {
                int lastDigit = n % 10;
                int newDigit = n / 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOddDigits += lastDigit;
                }
                n = newDigit;
            } while (n > 0);
            return sumOfOddDigits;
        }
    }
}
