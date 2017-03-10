using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Winning_Ticked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

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

/* 
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var result = new StringBuilder();

        var tickets = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim());

        var pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
        var reg = new Regex(pattern);

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                result.Append($"invalid ticket{Environment.NewLine}");
                continue;
            }

            var leftMatch = reg.Match(ticket.Substring(0, 10));
            var rightMatch = reg.Match(ticket.Substring(10));
            var minLen = Math.Min(leftMatch.Length, rightMatch.Length);

            if (!leftMatch.Success || !rightMatch.Success)
            {
                result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
                continue;
            }

            var leftPart = leftMatch.Value.Substring(0, minLen);
            var rightPart = rightMatch.Value.Substring(0, minLen);

            if (leftPart.Equals(rightPart))
            {
                if (leftPart.Length == 10)
                {
                    result.Append($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                }
                else
                {
                    result.Append($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)}{Environment.NewLine}");
                }                             
            }
            else
            {
                result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
            }
        }

        Console.Write(result.ToString());
    }
} */
