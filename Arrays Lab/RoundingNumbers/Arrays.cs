using System;

namespace RoundingNumbers
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] inputRealNumbers = Console.ReadLine().Split(' ');
            double[] parsedNumbers = new double[inputRealNumbers.Length];

            for (int i = 0; i < inputRealNumbers.Length; i++)
            {
                parsedNumbers[i] = double.Parse(inputRealNumbers[i]);
            }

            for (int i = 0; i < inputRealNumbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}",parsedNumbers[i],Math.Round(parsedNumbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
