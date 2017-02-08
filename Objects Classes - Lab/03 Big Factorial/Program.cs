using System;
using System.Numerics;

namespace _03_Big_Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
