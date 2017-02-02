using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurrences
{
    public class Dictionaries
    {
        public static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            List<string> result = new List<string>();

            foreach (var word in inputWords)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }
                dictionary[word]++;
            }

            foreach (var item in dictionary)
            {
                if(item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
