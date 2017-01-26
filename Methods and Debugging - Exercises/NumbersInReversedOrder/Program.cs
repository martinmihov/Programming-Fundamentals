using System;

namespace NumbersInReversedOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            string result = ReversedNum(num);
            Console.WriteLine(result);
        }
        
        public static string ReversedNum(double num)
        {
            var numString = num.ToString();

            string reversedString = string.Empty;

            for (int i = numString.Length - 1; i >= 0; i--) 
            {
                reversedString += numString[i];
            }

            return reversedString;
        }
    }
}
