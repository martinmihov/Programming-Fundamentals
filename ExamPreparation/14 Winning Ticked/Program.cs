using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _14_Winning_Ticked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([@#$^]{6,10})";

            Regex regex = new Regex(pattern);
            

            for (int i = 0; i < input.Length; i++)
            {
                string result = string.Empty;

                int lenght = 0;
                int minLenght = 0;
                int maxLenght = 0;
                char symbol = new char();

                MatchCollection matches = regex.Matches(input[i].Trim());

                string left = string.Empty;
                string right = string.Empty;
                
                foreach (var match in matches)
                {
                    if(matches.Count % 2 == 1)
                    {
                        left = match.ToString();
                    }
                    else
                    {
                        right = match.ToString();
                    }
                    maxLenght = Math.Max(left.Length, right.Length);
                    minLenght = Math.Min(maxLenght, right.Length);
                    result = match.ToString();
                    symbol = result.First();
                }
                if (input[i].Trim().Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                }
                else if(matches.Count == 2)
                {
                    if(minLenght == 10 && maxLenght == 10)
                    {
                        Console.WriteLine($"ticket \"{input[i].Trim()}\" - {minLenght}{symbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i].Trim()}\" - {minLenght}{symbol}");
                    }
                }
                else if (matches.Count != 2)
                {
                    Console.WriteLine($"ticket \"{input[i].Trim()}\" - no match");
                }
            }
        }
    }
}