using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = Convert.ToChar(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u') {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9') {
                Console.WriteLine("digit");
            }
            else {
                Console.WriteLine("other");
            }
        }
    }
}
