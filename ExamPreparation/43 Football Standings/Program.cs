using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _43_Football_Standings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);

            string lines = Console.ReadLine();

            Regex regex = new Regex($@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)");
            Dictionary<string, BigInteger> leagueStandings = new Dictionary<string, BigInteger>();

            Dictionary<string, BigInteger> scoredGoals = new Dictionary<string, BigInteger>();

            while (lines != "final")
            {
                string teamA = string.Empty;
                string teamB = string.Empty;
                BigInteger scoreA = 0;
                BigInteger scoreB = 0;
                MatchCollection matches = regex.Matches(lines);

                foreach (Match item in matches)
                {
                    teamA = item.Groups[1].ToString().ToUpper(); // teamA = new string(item.Groups[1].Reverse().ToArray()).//ToUpper();
                    teamB = item.Groups[2].ToString().ToUpper(); // teamB = new string(item.Groups[2].Reverse().ToArray()).//ToUpper();
                    scoreA = BigInteger.Parse(item.Groups[3].ToString()); // scoreA = int.Parse(item.Groups[3].Value);
                    scoreB = BigInteger.Parse(item.Groups[4].ToString()); // scoreB = int.Parse(item.Groups[4].Value);
                }
                char[] aTeam = teamA.Reverse().ToArray();
                char[] bTeam = teamB.Reverse().ToArray();

                string aTeamString = string.Empty.ToUpper();
                string bTeamString = string.Empty.ToUpper();

                for (int i = 0; i < aTeam.Length; i++)
                {
                    aTeamString += aTeam[i];
                }
                for (int i = 0; i < bTeam.Length; i++)
                {
                    bTeamString += bTeam[i];
                }

                if (!leagueStandings.ContainsKey(aTeamString))
                {
                    if (scoreA == scoreB)
                    {
                        leagueStandings.Add(aTeamString, 1);
                        scoredGoals.Add(aTeamString, scoreA);
                    }
                    else if (scoreA > scoreB)
                    {
                        leagueStandings.Add(aTeamString, 3);
                        scoredGoals.Add(aTeamString, scoreA);
                    }
                    else
                    {
                        leagueStandings.Add(aTeamString, 0);
                        scoredGoals.Add(aTeamString, scoreA);
                    }
                }
                else
                {
                    if (scoreA == scoreB)
                    {
                        leagueStandings[aTeamString] += 1;
                        scoredGoals[aTeamString] += scoreA;
                    }
                    else if (scoreA > scoreB)
                    {
                        leagueStandings[aTeamString] += 3;
                        scoredGoals[aTeamString] += scoreA;
                    }
                    else
                    {
                        leagueStandings[aTeamString] += 0;
                        scoredGoals[aTeamString] += scoreA;
                    }
                }
                if (!leagueStandings.ContainsKey(bTeamString))
                {
                    if (scoreA == scoreB)
                    {
                        leagueStandings.Add(bTeamString, 1);
                        scoredGoals.Add(bTeamString, scoreB);
                    }
                    else if (scoreA < scoreB)
                    {
                        leagueStandings.Add(bTeamString, 3);
                        scoredGoals.Add(bTeamString, scoreB);
                    }
                    else
                    {
                        leagueStandings.Add(bTeamString, 0);
                        scoredGoals.Add(bTeamString, scoreB);
                    }
                }
                else
                {
                    if (scoreA == scoreB)
                    {
                        leagueStandings[bTeamString] += 1;
                        scoredGoals[bTeamString] += scoreB;
                    }
                    else if (scoreA < scoreB)
                    {
                        leagueStandings[bTeamString] += 3;
                        scoredGoals[bTeamString] += scoreB;
                    }
                    else
                    {
                        leagueStandings[bTeamString] += 0;
                        scoredGoals[bTeamString] += scoreB;
                    }
                }
                
                lines = Console.ReadLine();
            }
            BigInteger count = 0;

            Console.WriteLine("League standings:");
            foreach (var kvp in leagueStandings.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                count++;
                Console.WriteLine($"{count}. {kvp.Key} {kvp.Value}");
            }
            Console.WriteLine("Top 3 scored goals:");

            foreach (var kvp in scoredGoals.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
