using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Array_Manipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string lines = Console.ReadLine();

            while (lines != "end")
            {
                string[] line = lines.Split().ToArray();
                string keyWord = line[0];

                switch (keyWord)
                {
                    case "exchange":
                        input = Exchange(input, int.Parse(line[1]));
                        break;

                    case "max":
                        MaxAndMin(input, line[0], line[1]);
                        break;
                    case "min":
                        MaxAndMin(input, line[0], line[1]);
                        break;
                    case "first":
                        FirstOrLast(input, line[0], int.Parse(line[1]), line[2]);
                        break;
                    case "last":
                        FirstOrLast(input, line[0], int.Parse(line[1]), line[2]);
                        break;
                }

                lines = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        private static void FirstOrLast(int[] input, string firstOrLast, int count, string evenOrOdd)
        {

            if (input.Length < count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var filter = FilterEvenOrOdd(input, evenOrOdd);

            int[] result;

            if (firstOrLast == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
        public static int[] FilterEvenOrOdd(int[] input, string evenOrOdd)
        {
            return input.Where(n => evenOrOdd == "even" ? n % 2 == 0 : n % 2 == 1).ToArray();
        }
        private static void MaxAndMin(int[] input, string maxOrMin, string evenOrOdd)
        {
            var filter = FilterEvenOrOdd(input, evenOrOdd);
            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }
            var result = maxOrMin == "max" ? filter.Max() : filter.Min();
            Console.WriteLine(Array.LastIndexOf(input, result));
        }

        private static int[] Exchange(int[] input, int exchangeIndex)
        {
            if (exchangeIndex < 0 || exchangeIndex >= input.Length)
            {
                Console.WriteLine("Invalid index");
                return input;
            }
            var left = input.Take(exchangeIndex + 1);
            var right = input.Skip(exchangeIndex + 1);

            return right.Concat(left).ToArray();
        }
    }
}
