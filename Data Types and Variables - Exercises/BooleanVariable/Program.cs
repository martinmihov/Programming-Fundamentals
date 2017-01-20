using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "true")
            {
                Console.WriteLine("Yes");
            }
            if(input == "false")
            {
                Console.WriteLine("No");
            }
        }
    }
}
