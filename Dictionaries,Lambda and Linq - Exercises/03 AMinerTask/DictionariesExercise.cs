using System;
using System.Collections.Generic;

namespace _03_AMinerTask
{
    public class DictionariesExercise
    {
        public static void Main(string[] args)
        {
            Dictionary<string, decimal> resourcesAndQuantities = new Dictionary<string, decimal>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var resource = input;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resourcesAndQuantities.ContainsKey(resource))
                {
                    resourcesAndQuantities[resource] = 0;
                }
                resourcesAndQuantities[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,decimal> resource in resourcesAndQuantities)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
