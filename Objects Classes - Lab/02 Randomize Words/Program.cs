using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Randomize_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            var rnd = new Random();
            
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = rnd.Next(0, words.Length);

                var temp = words[randomIndex];
                words[i] = temp;
                words[randomIndex] = currentWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
