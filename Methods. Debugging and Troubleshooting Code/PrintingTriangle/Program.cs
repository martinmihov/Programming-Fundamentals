using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintLine(n);
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
        public static void PrintLine(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColumns(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
