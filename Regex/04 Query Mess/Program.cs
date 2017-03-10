//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _04_Query_Mess
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string input = Console.ReadLine();

//            Dictionary<string, List<string>> line = new Dictionary<string, List<string>>();

//            while (input != "END")
//            {
//                string pattern = @".*\?|(\+|\+%20\+|%20)";

//                Regex regex = new Regex(pattern);

//                string replaced = regex.Replace(input, "");

//                string[] lines = replaced.Split(new[] { '&', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

//                for (int i = 0; i < lines.Length; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        if (!line.ContainsKey(lines[i]))
//                        {
//                            line[lines[i]] = new List<string>();
//                        }
//                        line[lines[i]].Add(lines[i + 1]);
//                    }
//                }

//                foreach (var item in line)
//                {
//                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
//                    Console.WriteLine();
//                }
//                line.Clear();
//                input = Console.ReadLine();
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        // regex patterns
        string pattern = @"([^&=?]*)=([^&=]*)";
        string regex = @"((%20|\+)+)";

        // input and matching
        string inputLine;

        while (!((inputLine = Console.ReadLine()) == "END"))
        {
            Regex pairs = new Regex(pattern);
            MatchCollection matches = pairs.Matches(inputLine);

            // storing matching fields and values into a dictionary, per line of input
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
            for (int i = 0; i < matches.Count; i++)
            {
                string field = matches[i].Groups[1].Value;
                field = Regex.Replace(field, regex, word => " ").Trim();

                string value = matches[i].Groups[2].Value;
                value = Regex.Replace(value, regex, word => " ").Trim();

                if (!results.ContainsKey(field))
                {
                    List<string> values = new List<string>();
                    values.Add(value);
                    results.Add(field, values);
                }
                else if (results.ContainsKey(field))
                {
                    results[field].Add(value);
                }
            }

            // printing
            foreach (var pair in results)
            {
                Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
            }
            Console.WriteLine();
        }
    }
}
