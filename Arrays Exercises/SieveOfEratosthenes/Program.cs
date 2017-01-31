using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int p = 2; p <= n; p++)
            {
                if (primes[p] == true)
                {
                    Console.Write($"{p} ");

                    for (int j = 2; j < n; j++)
                    {
                        if (j * p <= n && j * p >= 0)
                        {
                            primes[j * p] = false;
                        }
                    }
                }
            }


        }
    }
}
