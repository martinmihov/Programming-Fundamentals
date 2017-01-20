using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(firstLine,16));
        }
    }
}
