using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23_Nether_Realms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Demon[] inputConsole = Console.ReadLine()
                .Split(", ".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .ToArray();


            foreach (var item in inputConsole.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Damage:f2} damage");
            }
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();

            demon.Name = demonName;
            demon.Health = CalculateHealth(demonName);
            demon.Damage = CalculateDamage(demonName);

            return demon;
        }

        private static decimal CalculateDamage(string demonName)
        {
            string damagePattern = @"[+-]?\d+(?:\.?\d+)?";

            MatchCollection damageChars = Regex.Matches(demonName, damagePattern);

            decimal damageSum = 0m;
             

            foreach (Match item in damageChars)
            {
                damageSum += decimal.Parse(item.Value.ToString());
            }
            char[] demonChars = new char[demonName.Length];

            var modifiers = demonName.Where(a => a == '*' || a == '/').ToArray();

            foreach (var item in modifiers)
            {
                switch (item)
                {
                    case '*':
                        damageSum *= 2;
                        break;
                    case '/':
                        damageSum /= 2;
                        break;
                }
            }
            
            
            return damageSum;
        }

        private static decimal CalculateHealth(string demonName)
        {
            string healthPattern = @"[^0-9-+.*\/]";

            MatchCollection healthChars = Regex.Matches(demonName, healthPattern);

            List<decimal> healthValues = new List<decimal>();

            foreach (Match characters in healthChars)
            {
                healthValues.Add(char.Parse(characters.Value));
            }

            decimal health = healthValues.Sum();
            return health;
        }
    }
}
