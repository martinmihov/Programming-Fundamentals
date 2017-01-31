using System;

namespace IndexLetters
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string charString = Console.ReadLine().ToLower();

            char[] parsedChars = new char[charString.Length];

            int charToIntValueCorrector = 97;

            for (int i = 0; i < charString.Length; i++)
            {
                parsedChars[i] = charString[i];
                Console.WriteLine("{0} -> {1}",parsedChars[i],parsedChars[i] - charToIntValueCorrector);
            }
        }
    }
}
