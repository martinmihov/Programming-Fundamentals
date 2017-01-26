using System;
using System.Numerics;

namespace FactorialTrailingZeroez
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetZeroes(n));
        }

        public static int GetZeroes(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            BigInteger zeroesMetaporhosa = factorial;
            int zeroCount = 0;
            while (zeroesMetaporhosa % 10 == 0)
            {
                factorial = zeroesMetaporhosa / 10;
                zeroesMetaporhosa = factorial;
                zeroCount++;
            }
            return zeroCount;
        }
    }
}
