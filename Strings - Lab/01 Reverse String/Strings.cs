using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Reverse_String
{
    public class Strings
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = input.Reverse().ToArray();            
            Console.WriteLine(result);
        }
    }
}
