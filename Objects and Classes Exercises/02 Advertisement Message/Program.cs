using System;
using System.Collections.Generic;

namespace _02_Advertisement_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string> {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            List<string> events = new List<string> {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            List<string> author = new List<string> { "Diana", "Petya",
                "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string> { "Burgas",
                "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random shuffle = new Random();
            for (int i = 0; i < n; i++)
            {
                var phrasesIndex = shuffle.Next(0, phrases.Count);
                var eventsIndex = shuffle.Next(0, events.Count);
                var authorIndex = shuffle.Next(0, author.Count);
                var citiesIndex = shuffle.Next(0, cities.Count);

                string phraseRandom = phrases[phrasesIndex];
                string eventsRandom = events[eventsIndex];
                string authorRandom = author[authorIndex];
                string citiesRandom = cities[citiesIndex];

                Console.WriteLine($"{phraseRandom} {eventsRandom} {authorRandom} - {citiesRandom}");
            }
        }
    }
}
