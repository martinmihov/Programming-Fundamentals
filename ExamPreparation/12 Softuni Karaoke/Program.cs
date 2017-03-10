using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Softuni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] songList = Console.ReadLine().Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string dawn = Console.ReadLine();

            Dictionary<string, List<string>> awardsWinners = new Dictionary<string, List<string>>();

            List<string> allSongs = new List<string>(songList.Length);
            List<string> allParticipants = new List<string>(participants.Length);

            foreach (var item in songList)
            {
                allSongs.Add(item.Trim());
            }

            foreach (var item in participants)
            {
                allParticipants.Add(item.Trim());
            }

            while (dawn != "dawn")
            {
                string[] stagePerformance = dawn.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string performer = stagePerformance[0].Trim();
                string song = stagePerformance[1].Trim();
                string award = stagePerformance[2].Trim();
                
                if (allParticipants.Contains(performer) && allSongs.Contains(song))
                {
                    if (!awardsWinners.ContainsKey(performer))
                    {
                        awardsWinners[performer] = new List<string>();
                    }
                    var awards = awardsWinners[performer];

                    if (!awards.Contains(award) && allSongs.Contains(song))
                    {
                        awardsWinners[performer].Add(award);
                    }
                }
                dawn = Console.ReadLine();
            }
            if (awardsWinners.Count == 0) // if(!awardsWinners.Any())
            {
                Console.WriteLine("No awards");
            }
            var result = awardsWinners.OrderByDescending(v => v.Value.Count).ThenBy(p => p.Key);
            
            foreach (var performer in result)
            {
                var awards = performer.Value;
                Console.WriteLine($"{performer.Key}: {performer.Value.Count()} awards");
                foreach (var item in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
