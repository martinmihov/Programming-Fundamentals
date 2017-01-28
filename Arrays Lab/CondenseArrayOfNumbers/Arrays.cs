using System;

namespace CondenseArrayOfNumbers
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] numberOfIntegers = Console.ReadLine().Split(' ');
            int[] arrayOfInts = new int[numberOfIntegers.Length];

            for (int i = 0; i < numberOfIntegers.Length; i++)
            {
                arrayOfInts[i] = int.Parse(numberOfIntegers[i]);
            }
            
            while (arrayOfInts.Length > 1)
            {
                int[] condensed = new int[arrayOfInts.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arrayOfInts[i] + arrayOfInts[i + 1];
                }
                arrayOfInts = condensed;
            }
            Console.WriteLine(string.Join(" ",arrayOfInts));
        }
    }
}
