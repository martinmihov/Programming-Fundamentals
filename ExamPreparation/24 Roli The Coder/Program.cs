using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace _24_Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            const string inputPattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";

            var events = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                Match matches = Regex.Match(input,inputPattern);

                if (matches.Success)
                {
                    var ID = int.Parse(matches.Groups["id"].Value);
                    var eventName = matches.Groups["eventName"].Value;

                    var participants = new string[0];

                    var eventHasParticipants = input.Contains("@");

                    if (eventHasParticipants)
                    {
                        participants = input.Substring(input.IndexOf('@')).Split().Where(a=> a != string.Empty).ToArray();
                    }

                    if (!events.ContainsKey(ID))
                    {
                        events[ID] = new Event();
                        {
                            events[ID].Name = eventName;
                            events[ID].Participants = new List<string>(new string[0]);
                        };
                    }
                    if(events[ID].Name == eventName)
                    {
                        events[ID].Participants.AddRange(participants);
                        events[ID].Participants = events[ID].Participants.Distinct().ToList();
                    }
                }
                input = Console.ReadLine();
            }

            var sortedEvents = events.OrderByDescending(a => a.Value.Participants.Count)
                .ThenBy(a => a.Value.Name).ToArray();

            foreach (var item in sortedEvents)
            {
                var eventName = item.Value.Name;
                var participantsCount = item.Value.Participants.Count();
                Console.WriteLine($"{eventName} - {participantsCount}");

                var sortedParticipants = item.Value.Participants.OrderBy(a => a);
                foreach (var participant in sortedParticipants)
                {
                    Console.WriteLine(participant);
                }
            }
        }

        
    }
    class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}
