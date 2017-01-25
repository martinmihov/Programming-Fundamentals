using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopAndBottomLines(n);
            SquareBodyLines(n);
            TopAndBottomLines(n);
        }
        public static void TopAndBottomLines(int input)
        {
            Console.WriteLine(new string('-', 2 * input));
        }
        public static void SquareBodyLines(int input)
        {
            for (int j = 1; j < input - 1; j++)
            {
                Console.Write('-');
                for (int i = 1; i <= input - 1; i++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
