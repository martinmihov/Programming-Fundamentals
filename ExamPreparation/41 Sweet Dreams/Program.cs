using System;

namespace _41_Sweet_Dreams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = int.Parse(Console.ReadLine());
            decimal aBanana = decimal.Parse(Console.ReadLine());
            decimal anEgg = decimal.Parse(Console.ReadLine());
            decimal kgBerries = decimal.Parse(Console.ReadLine());

            decimal groupsOfGuests = Math.Ceiling(guests / 6);
            decimal bananas = ((groupsOfGuests * 2) * aBanana);
            decimal eggs = ((groupsOfGuests * 4) * anEgg);
            decimal berries = (groupsOfGuests * ( kgBerries / 5));
            decimal groceriesSum = bananas + eggs + berries;

            if(groceriesSum <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {groceriesSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(groceriesSum-cash):f2}lv more.");
            }
        }
    }
}
