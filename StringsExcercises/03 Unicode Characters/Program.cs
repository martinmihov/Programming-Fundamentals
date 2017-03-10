using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Unicode_Characters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.Write($"\\u{(int)letter:x4}");
            }
            Console.WriteLine();
        }
    }
}
