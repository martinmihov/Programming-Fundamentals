using System;

namespace SumArrays
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] firstArrayNumberOfElements = Console.ReadLine().Split(' ');
            string[] secondArrayNumberOfElements = Console.ReadLine().Split(' ');

            int[] firstArray = new int[firstArrayNumberOfElements.Length];
            int[] secondArray = new int[secondArrayNumberOfElements.Length];


            for (int i = 0; i < firstArrayNumberOfElements.Length; i++)
            {
                firstArray[i] = int.Parse(firstArrayNumberOfElements[i]);
            }

            for (int i = 0; i < secondArrayNumberOfElements.Length; i++)
            {
                secondArray[i] = int.Parse(secondArrayNumberOfElements[i]);
            }

            int[] sumOfArrays = new int[Math.Max(firstArray.Length , secondArray.Length)];

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                sumOfArrays[i] = firstArray[i % firstArrayNumberOfElements.Length] + secondArray[i % secondArrayNumberOfElements.Length];
            }
            Console.WriteLine(string.Join(" ",sumOfArrays));

        }
    }
}
