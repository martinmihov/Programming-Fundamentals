using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_HandsOfCards
{
    public class DictionariesExercise
    {
        public static void Main(string[] args)
        {
            Dictionary<string,int> cardPowers = GetCardPowers();
            Dictionary<string,int> cardTypes = GetCardTypes();

            Dictionary<string, HashSet<int>> cards = new Dictionary<string,HashSet<int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] tokens = input.Split(':');

                string name = tokens[0];
                string[] playerCards = tokens[1]
                    .Split(new char[] { ',', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card.Substring(card.Length - 1);

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    int sum = cardPowers[cardPower] * cardTypes[cardType];
                    cards[name].Add(sum);
                }
                input = Console.ReadLine();
            }
            
            foreach (var player in cards)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }
            
        }
        public  static Dictionary<string, int> GetCardTypes()
        {
            Dictionary<string, int> type = new Dictionary<string, int>();

            type["S"] = 4;
            type["H"] = 3;
            type["D"] = 2;
            type["C"] = 1;

            return type;
        }

        public static Dictionary<string, int> GetCardPowers()
        {
            Dictionary<string, int> power = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;
            }

            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;
        }
    }
}
