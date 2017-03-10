using System;
using System.Globalization;

namespace _31_Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal orderPrice = daysInMonth * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
