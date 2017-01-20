using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < n; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < n; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < n; thirdLetter++)
                    {
                        char firstLetterPosition = (char)('a' + firstLetter);
                        char secondLetterPosition = (char)('a' + secondLetter);
                        char thirdLetterPosition = (char)('a' + thirdLetter);
                        Console.WriteLine("{0}{1}{2}",firstLetterPosition,secondLetterPosition,thirdLetterPosition);
                    }
                }
            }
        }
    }
}
