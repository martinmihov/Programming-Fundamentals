using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Valid_Username
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"\b[a-zA-Z]\w{2,24}\b";

            Regex regex = new Regex(pattern);
            
            List<string> collection = new List<string>();

            foreach (var item in input)
            {
                if (regex.IsMatch(item))
                {
                    collection.Add(item);
                }
            }

            List<string> resultCouple = new List<string>();

            int wordsLength = 0;
            int sum = 0;
            for (int i = 1; i < collection.Count; i++)
            {
                sum = collection[i - 1].Length + collection[i].Length;

                if(sum > wordsLength)
                {
                    resultCouple.Clear();
                    resultCouple.Add(collection[i - 1]);
                    resultCouple.Add(collection[i]);
                    wordsLength = sum;
                }
            }
            foreach (var item in resultCouple)
            {
                Console.WriteLine(item);
            }
        }
    }
}
