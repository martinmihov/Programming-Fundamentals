using System;

namespace _51_SoftUni_Airline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal overallIncome = 0M;
            decimal overallExpenses = 0M;

            for (int i = 0; i < n; i++)
            {
                int adultPassangersCount = int.Parse(Console.ReadLine());
                decimal adultPassangersTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassangersCount = int.Parse(Console.ReadLine());
                decimal youthPassangersTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                byte flightDuration = byte.Parse(Console.ReadLine());

                decimal incomeOfTickets = (adultPassangersCount * adultPassangersTicketPrice) + (youthPassangersCount * youthPassangersTicketPrice);
                decimal expensesOfFuel = (fuelPricePerHour * fuelConsumptionPerHour * flightDuration);

                overallExpenses += expensesOfFuel;
                overallIncome += incomeOfTickets;
                
                if(incomeOfTickets - expensesOfFuel < 0)
                {

                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", incomeOfTickets - expensesOfFuel);
                }
                else
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", incomeOfTickets - expensesOfFuel);
                }
            }
            
            decimal overallProfit = overallIncome - overallExpenses;
            decimal averageProfit = overallProfit / n;

            Console.WriteLine("Overall profit -> {0:f3}$.",overallProfit);
            Console.WriteLine("Average profit -> {0:f3}$.",averageProfit);
        }
    }
}
