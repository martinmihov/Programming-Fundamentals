using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstVariable = "Hello";
            string secondVariable = "World";
            object concatenator = firstVariable + " " + secondVariable;
            string cast = (string)concatenator;
            Console.WriteLine(cast);
        }
    }
}
