using System;

namespace MaxMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber,secondNumber,thirdNumber);
        }

        public static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if(firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }else if(thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
            
        }
    }
}
