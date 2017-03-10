using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01_ConvertFromBase10ToBaseN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger first = numbers[0];
            BigInteger second = numbers[1];
            StringBuilder sb = new StringBuilder(10);

            while(second != 0)
            {
                sb.Append(second % first);
                second = second / first;
            }

            Console.WriteLine(sb.ToString().Reverse().ToArray());
        }
    }
}
