using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

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
