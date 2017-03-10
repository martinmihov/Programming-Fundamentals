using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Text_Filter
{
    public class Strings
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new [] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var banword in bannedWords)
            {
                text = text.Replace(banword, new string('*', banword.Length));
            }

            Console.WriteLine(text);
        }
    }
}
