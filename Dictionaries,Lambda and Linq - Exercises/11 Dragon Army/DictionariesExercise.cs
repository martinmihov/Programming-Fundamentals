using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Dragon_Army
{
    public class DictionariesExercise
    {
        public static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, decimal[]>> dragons = new Dictionary <string, SortedDictionary<string,decimal[]>>();

            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonCounter = Console.ReadLine().Split(' ');
                string type = dragonCounter[0];
                string name = dragonCounter[1];

                decimal damage = 0m;
                decimal health = 0m;
                decimal armor = 0m;

                if (dragonCounter[2] != "null")
                {
                    damage = decimal.Parse(dragonCounter[2]);
                }
                else
                {
                    damage = 45m;
                }
                if (dragonCounter[3] != "null")
                {
                    health = decimal.Parse(dragonCounter[3]);
                }
                else
                {
                    health = 250m;
                }
                if (dragonCounter[4] != "null")
                {
                    armor = decimal.Parse(dragonCounter[4]);
                }
                else
                {
                    armor = 10m;
                }

                decimal[] stats = new decimal[3] { damage, health, armor };

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }
                dragons[type][name] = stats;
            }

            foreach (var type in dragons)
            {
                var nameType = type.Key;
                var dragonsByType = type.Value;
                var averageDamage = dragonsByType.Values.Average(a => a[0]);
                var averageHealth = dragonsByType.Values.Average(h => h[1]);
                var averageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{nameType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonsByType)
                {
                    var dragonName = dragon.Key;
                    var dragonDamage = dragon.Value[0];
                    var dragonHealth = dragon.Value[1];
                    var dragonArmor = dragon.Value[2];
                    Console.WriteLine($"-{dragonName} -> damage: {dragonDamage}, health: {dragonHealth}, armor: {dragonArmor}");
                }
            }

        }
    }
}
