using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Advertisement_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfmessages = int.Parse(Console.ReadLine());

            string[] phrasesAll = File.ReadAllLines("Phrases.txt");
            string[] eventsAll = File.ReadAllLines("Events.txt");
            string[] authorAll = File.ReadAllLines("Author.txt");
            string[] citiesAll = File.ReadAllLines("Cities.txt");

            Random rnd = new Random(309);
            List<string> preOutput = new List<string>(); 

            for (int i = 0; i < numberOfmessages; i++)
            {
                string phrase = phrasesAll[rnd.Next(0, phrasesAll.Length)];
                string events = eventsAll[rnd.Next(0, eventsAll.Length)];
                string author = authorAll[rnd.Next(0, authorAll.Length)];
                string city = citiesAll[rnd.Next(0, citiesAll.Length)];

                preOutput.Add(phrase);
                preOutput.Add(events);
                preOutput.Add(author);
                preOutput.Add(city);

                File.WriteAllLines("output.txt", preOutput);
            }
        }
    }
}
