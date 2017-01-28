using System;

namespace Reverse_an_Array_of_Integers
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] arrOfInts = new int[numberOfElements];

            for (int i = 0; i < arrOfInts.Length; i++)
            {
                arrOfInts[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numberOfElements - 1; i >= 0; i--)
            {
                Console.Write("{0} ",arrOfInts[i]);
            }
        }
    }
}
