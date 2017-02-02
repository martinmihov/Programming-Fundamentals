using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SortNumbers
{
    public class Lists
    {
        public static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ",input));
        }
    }
}
