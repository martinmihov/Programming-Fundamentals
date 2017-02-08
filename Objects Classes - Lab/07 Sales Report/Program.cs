using System;
using System.Collections.Generic;

namespace _07_Sales_Report
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Sale> totalSalesByTown = new List<Sale>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                Sale sale = new Sale
                {
                    Town = text[0],
                    Product = text[1],
                    Price = decimal.Parse(text[2]),
                    Quantity = decimal.Parse(text[3])
                };
                totalSalesByTown.Add(sale);
            }

            SortedDictionary<string,decimal> result = new SortedDictionary<string, decimal>();

            foreach (var sale in totalSalesByTown)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                result[sale.Town] += sale.Quantity * sale.Price;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal Sales
        {
            get
            {
                return Price * Quantity;
            }
        }

    }
}


