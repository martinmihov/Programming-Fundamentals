using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Count_substring_occurrences
{
    public class Strings
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string pattern = Console.ReadLine().ToLower();

            int index = 0;
            int count = 0;

            while (true)
            {
                int found = text.IndexOf(pattern, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
