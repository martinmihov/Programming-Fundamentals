using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _02_ConvertFromNtoBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();

            int first = int.Parse(numbers[0]);
            BigInteger second = BigInteger.Parse(numbers[1]);
            StringBuilder sb = new StringBuilder(10);

            var result = ConvertFromBaseNToDecimal(second, first);
            Console.WriteLine(result);
        }

        static BigInteger ConvertFromBaseNToDecimal(BigInteger second, int first)
        {
            string numberAsString = second.ToString();

            BigInteger sum = new BigInteger(0);

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int num = int.Parse(numberAsString[numberAsString.Length - 1 - i].ToString());

                var result = num * BigInteger.Pow(first, i);

                sum += result;
            }
            return sum;
        }


    }
}
