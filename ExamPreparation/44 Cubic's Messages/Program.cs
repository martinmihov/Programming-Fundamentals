using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _44_Cubic_s_Messages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Over!")
            {
                string message = input;
                int n = int.Parse(Console.ReadLine());

                string pattern = $@"^(\d+)([A-Za-z]{{{n}}})([^A-Za-z]*)$";

                Regex regex = new Regex(pattern);

                Match match = regex.Match(message);

                StringBuilder sb = new StringBuilder();

                if (match.Success)
                {
                    var leftSide = match.Groups[1].Value;
                    var middle = match.Groups[2].Value;
                    var rightSide = match.Groups[3].Value;

                    var indexes = string.Concat(leftSide, rightSide)
                        .Where(s => char.IsDigit(s))
                        .Select(s => s - '0'); // foreach (var index in indexes) var digit = index - '0';

                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= middle.Length)
                        {
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(middle[index]);
                        }
                    }
                    Console.WriteLine($"{middle} == {sb.ToString()}");
                }
                else 
                {
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
        }
    }
}
