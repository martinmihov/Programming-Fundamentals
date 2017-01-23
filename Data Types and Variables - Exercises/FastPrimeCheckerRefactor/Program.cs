using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int number = 2; number <= input; number++)
            {
                bool prime = true;
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if(number % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {prime}");
            }
        }
    }
}
