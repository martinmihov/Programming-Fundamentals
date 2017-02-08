using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PopulationCounter
{
    public class DictionariesExercises
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> data = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] dataInput = input.Split('|');

                string country = dataInput[1];
                string city = dataInput[0];
                decimal population = decimal.Parse(dataInput[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, decimal>();
                }
                if (!data[country].ContainsKey(city))
                {
                    data[country].Add(city, population);
                }

                data[country][city] = population;
                input = Console.ReadLine();
            }
            Dictionary<string, decimal> dataCountryPopulation = new Dictionary<string, decimal>();

            foreach (var pair in data)
            {
                string currentCountry = pair.Key;
                dataCountryPopulation.Add(currentCountry, 0);
                foreach (var total in data[currentCountry])
                {
                    dataCountryPopulation[currentCountry] += total.Value;
                }

            }

            foreach (var country in dataCountryPopulation.OrderByDescending(o => o.Value))
            {
                Console.WriteLine ($"{country.Key} (total population: {dataCountryPopulation[country.Key]})");
                foreach (var city in data[country.Key].OrderByDescending(o=> o.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
