using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbersLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal result = 0M;
            for (int i = 0; i < n; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                result += numbers;
            }
            Console.WriteLine(result);

        }
    }
}
