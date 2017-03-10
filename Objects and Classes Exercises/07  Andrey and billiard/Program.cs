using System;
using System.Collections.Generic;
using System.Linq;

namespace _07__Andrey_and_billiard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int amountOfEntities = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> merchandise = new Dictionary<string, decimal>();

            for (int i = 0; i < amountOfEntities; i++)
            {
                string[] products = Console.ReadLine().Split('-');

                string product = products[0];
                decimal priceOfProduct = decimal.Parse(products[1]);

                if (!merchandise.ContainsKey(product))
                {
                    merchandise[product] = 0;
                }
                merchandise[product] = priceOfProduct;
            }

            List<Customer> customers = new List<Customer>();
            
            while(true)
            {
                string clients = Console.ReadLine();
                if(clients == "end of clients")
                {
                    break;
                }
                string[] aClient = clients.Split(new char[] { '-', ',' });
                Customer student = new Customer();
                student.ShopList = new Dictionary<string, int>();
                string name = aClient[0];
                string wantsToBuy = aClient[1];
                int quantity = int.Parse(aClient[2]);
                if (!customers.Contains(student))
                {
                    student.Name = name;
                }
                else
                {
                    break;
                }
                if (student.ShopList.ContainsKey(wantsToBuy))
                {
                    student.ShopList[wantsToBuy] += quantity;
                }
                else
                {
                    student.ShopList.Add(wantsToBuy, quantity);
                }
                customers.Add(student);
            }
            foreach (var student in customers)
            {
                foreach (var item in student.ShopList)
                {

                    foreach (var product in merchandise)
                    {
                        if (item.Key == product.Key) { student.Bill += item.Value * product.Value; }
                    }
                }
            }
            decimal TotalBill = 0m;
            foreach (Customer student in customers.OrderBy(o => o.Name).ThenBy(o=> o.Bill))
            {
                Console.WriteLine(student.Name);
                foreach (var item in student.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {student.Bill:f2}");
                TotalBill += student.Bill;
            }
            Console.WriteLine($"Total bill: {TotalBill:f2}");

        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

}
