using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Extract_Sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string particularWord = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = "\\b" + particularWord + "\\b";
            Regex regex = new Regex(pattern);
            foreach (var item in text)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.TrimStart());
                }
            }
        }
    }
}
