using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Logs_Aggregator
{
    public class DictionariesExercises
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, decimal>> logsAggregator = new SortedDictionary<string, SortedDictionary<string, decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string userName = input[1];
                string IP = input[0];
                decimal duration = decimal.Parse(input[2]);


                if (!logsAggregator.ContainsKey(userName))
                {
                    logsAggregator[userName] = new SortedDictionary<string, decimal>();
                }
                if (!logsAggregator[userName].ContainsKey(IP))
                {
                    logsAggregator[userName][IP] = 0;
                }
                logsAggregator[userName][IP] += duration;
            }

            foreach (var user in logsAggregator)
            {
                var sum = user.Value.Values.Sum();
                Console.WriteLine($"{user.Key}: {sum} [{string.Join(", ",user.Value.Keys)}]");

            }
        }
    }
}
