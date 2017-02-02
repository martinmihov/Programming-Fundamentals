using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    public class ListExercises
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Console.ReadLine().Split().Select(a => int.Parse(new string(a.Reverse().ToArray()))).Sum());

            // Second Variant

            //string[] inputNumbers = Console.ReadLine().Split();

            //int sum = 0;

            //for (int i = 0; i < inputNumbers.Length; i++)
            //{
            //    string currentNumber = inputNumbers[i];

            //    string reversedNumber = string.Join("", currentNumber.Reverse());

            //    int parsedNumber = int.Parse(reversedNumber);

            //    sum += parsedNumber;

            //}
            //Console.WriteLine(sum);

            // Third Variant

            string[] inputnumbers = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < inputnumbers.Length; i++)
            {
                string currentnumber = inputnumbers[i];

                List<char> reversedNumber = currentnumber.Reverse().ToList();

                string reversedNumberString = string.Join("",reversedNumber);

                int resultNumber = int.Parse(reversedNumberString);
                sum += resultNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
