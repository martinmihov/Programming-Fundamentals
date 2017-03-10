using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_ExamFourth
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string pattern = @"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)";
            Regex regex = new Regex(pattern);


            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> armyWithLastActivity = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, long>> army = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = regex.Matches(input);

                int activity = 0;
                string legionName = string.Empty;
                string soldierType = string.Empty;
                long soldierCount = 0L;


                foreach (Match item in matches)
                {
                    activity = int.Parse(item.Groups[1].Value);
                    legionName = item.Groups[2].Value.ToString();
                    soldierType = item.Groups[3].Value.ToString();
                    soldierCount = long.Parse(item.Groups[4].Value);
                }


                if (!armyWithLastActivity.ContainsKey(legionName))
                {
                    armyWithLastActivity.Add(legionName, activity);
                    army.Add(legionName, new Dictionary<string, long>());
                }

                if (activity > armyWithLastActivity[legionName])
                {
                    armyWithLastActivity[legionName] = activity;
                }

                if (!army[legionName].ContainsKey(soldierType))
                {
                    army[legionName].Add(soldierType, 0L);
                }

                army[legionName][soldierType] += soldierCount;

            }

            string[] finalCommand = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (finalCommand.Length == 1)
            {
                string soldierType = finalCommand[0];

                foreach (var item in armyWithLastActivity.OrderByDescending(o => o.Value))
                {
                    if (army[item.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine("{0} : {1}",item.Value , item.Key);
                    }
                }
            }
            else if (finalCommand.Length == 2)
            {
                int activity = int.Parse(finalCommand[0]);
                string soldierType = finalCommand[1];


                foreach (var item in army.Where(o => o.Value.ContainsKey(soldierType))
                    .OrderByDescending(o => o.Value[soldierType]))

                {
                    if(activity > armyWithLastActivity[item.Key])
                    {
                        Console.WriteLine("{0} -> {1}",item.Key, army[item.Key][soldierType]);
                    }
                }
            }
        }
    }
}
