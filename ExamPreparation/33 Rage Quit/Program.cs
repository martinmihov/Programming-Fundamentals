using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _33_Rage_Quit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //digits

            string digitsPattern = @"\d+";
            Regex digits = new Regex(digitsPattern);
            MatchCollection digitsMatches = digits.Matches(input);
            int[] digitsArray = new int[digitsMatches.Count];

            for (int i = 0; i < digitsMatches.Count; i++)
            {
                digitsArray[i] = int.Parse(digitsMatches[i].ToString());
            }

            // symbols

            string symbolsPattern = @"\D+";
            Regex symbols = new Regex(symbolsPattern);
            MatchCollection symbolsMatches = symbols.Matches(input);
            string[] symbolArray = new string[symbolsMatches.Count];

            for (int i = 0; i < symbolsMatches.Count; i++)
            {
                symbolArray[i] = symbolsMatches[i].ToString().ToUpper();
            }

            // unique symbols

            //List<char> uniqueSymbols = new List<char>();

            //foreach (Match item in symbolsMatches)
            //{
            //    string message = item.Value.ToLower();
            //    for (int i = 0; i < message.Length; i++)
            //    {
            //        if (!uniqueSymbols.Contains(message[i]))
            //        {
            //            uniqueSymbols.Add(message[i]);
            //        }
            //    }
            //}
            //StringBuilder uniqueRaw = new StringBuilder();
            //HashSet<char> uniqueSymbols = new HashSet<char>();
            //var getUniqueChars = Regex.Replace(input, digitsPattern, "");

            //for (int i = 0; i < symbolsMatches.Count; i++)
            //{
            //    uniqueRaw.Append(symbolsMatches[i]);
            //}
            //foreach (var item in uniqueRaw.ToString())
            //{
            //    uniqueSymbols.Add(item);
            //}
            //var result = uniqueSymbols.Distinct();
            //foreach (var item in getUniqueChars)
            //{
            //    uniqueSymbols.Add(item);
            //}

            //result

           StringBuilder sb = new StringBuilder();
            for (int i = 0; i < digitsArray.Length; i++)
            {
                string empty = string.Empty;
                for (int k = 0; k < digitsArray[i]; k++)
                {
                    empty += symbolArray[i].ToString();
                }
                sb.Append(empty);
            }

            //output
            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine(sb.ToString());
        }
    }
}
