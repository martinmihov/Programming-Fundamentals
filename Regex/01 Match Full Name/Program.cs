using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01_Match_Full_Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = @"<ul><li><a href=""http://softuni.bg"">SoftUni</a></li></ul>";

            string pattern = @"<a(.*?)>(.*?)<\/a>";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(input, "[URL$1]$2[/URL]");
            Console.WriteLine(result);

            // WHITESPACE SYMBOLS COMBO : \t\r\s\n SPACE : \s
        }
    }
}
