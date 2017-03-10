using System;
using System.Collections.Generic;

namespace Praktice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',', '.', '?', '!' };
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> output = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                bool palindrome = IsPalindrome(word);
                if (palindrome)
                {
                    if (!output.Contains(word))
                    {
                        output.Add(word);
                    }
                }
            }
            output.Sort();
            Console.WriteLine(string.Join(", ", output));
        }

        private static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}