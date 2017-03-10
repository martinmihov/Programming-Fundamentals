using System;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        var htmlText = Console.ReadLine();
        var pattern = @"<p>(.+?)<\/p>";

        var currentMatch = string.Empty;

        foreach (Match match in Regex.Matches(htmlText, pattern))
        {
            currentMatch += match.Groups[1].Value.ToString();
        }

        currentMatch = Regex.Replace(currentMatch, @"[^a-z\d]", " ");
        currentMatch = Regex.Replace(currentMatch, @"\s+|\n+", " ");
        var result = new StringBuilder(currentMatch.Length);

        foreach (var ch in currentMatch)
        {
            if (ch >= 'a' && ch <= 'm')
            {
                result.Append((char)(ch + 13));
            }
            else if (ch >= 'n' && ch <= 'z')
            {
                result.Append((char)(ch - 13));
            }
            else
            {
                result.Append(ch);
            }
        }

        Console.WriteLine(string.Join(" ",result));
    }
}