using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SumMinMaxAverage
{
    public class Linq
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            List<double> listOfNumbers = new List<double>();

            for (int i = 0; i < inputNumber; i++)
            {
                double number = double.Parse(Console.ReadLine());
                listOfNumbers.Add(number);
            }

            listOfNumbers.Sort();

            Console.WriteLine("Sum = {0}",listOfNumbers.Sum());
            Console.WriteLine("Min = {0}", listOfNumbers.Min());
            Console.WriteLine("Max = {0}", listOfNumbers.Max());
            Console.WriteLine("Average = {0}", listOfNumbers.Average());
        }
    }
}
