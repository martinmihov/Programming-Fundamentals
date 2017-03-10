using System;
using System.Text.RegularExpressions;

namespace _01__Exercise_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection result = regex.Matches(input);

            foreach (Match match in result)
            {
                string matchString = match.ToString();
                if (!(matchString.StartsWith("-") ||
                    matchString.StartsWith(".") ||
                    matchString.StartsWith("_") ||
                    matchString.EndsWith("-") ||
                    matchString.EndsWith(".") ||
                    matchString.EndsWith("_")))
                {
                    Console.WriteLine(matchString);
                }
            }
        }
    }
}
