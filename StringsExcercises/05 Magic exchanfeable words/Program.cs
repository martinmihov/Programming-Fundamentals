using System;
using System.Linq;

namespace _05_Magic_exchanfeable_words
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string first = input[0];
            string second = input[1];



            var result = IsExchangeable(first, second);

            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static bool IsExchangeable(string first, string second)
        {
            bool isExchangeable = false;

            char[] firstDistinct = first.Distinct().ToArray();
            char[] secondDistinct = second.Distinct().ToArray();

            if(firstDistinct.Length == secondDistinct.Length)
            {
                isExchangeable = true;
            }
            return isExchangeable;
        }
    }
}
