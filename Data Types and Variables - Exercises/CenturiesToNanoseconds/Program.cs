using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong milliseconds = (ulong)(seconds * 1000);
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);
        }
    }
}
