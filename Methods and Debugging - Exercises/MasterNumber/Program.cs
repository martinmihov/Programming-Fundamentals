using System;

namespace MasterNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                if (ReversedNum(currentNumber) == true && SumOfDigitsDivBySeven(currentNumber) == true && ContainsEvenDigit(currentNumber) == true)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        public static bool ReversedNum(double num)
        {
            string numString = num.ToString();

            string reversedString = string.Empty;

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }

            bool isPalindrome = reversedString == numString;

            return isPalindrome;
        }
        public static bool SumOfDigitsDivBySeven(int number)
        {
            int newSumOfDigits = 0;
            bool isDivisibleBySeven = false;
            while (number / 10 != 0)
            {
                newSumOfDigits += number % 10;
                number = number / 10;
            }
            int sumOfDigits = newSumOfDigits + number;
            if (sumOfDigits % 7 == 0)
            {
                isDivisibleBySeven = true;
            }

            return isDivisibleBySeven;
        }

        public static bool ContainsEvenDigit(int number)
        {
            bool isThereEvenDigit = false;

            while (number / 10 != 0)
            {
                int lastDigit = number % 10;
                number = number / 10;
                if (lastDigit % 2 == 0)
                {
                    isThereEvenDigit = true;
                }
            }

            return isThereEvenDigit;
        }
    }
}
