using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    public class ListsExercises
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int number = specialNumbers[0];
            int power = specialNumbers[1];

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == specialNumbers[0])
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, inputNumbers.Count - 1);

                    int lenght = right - left + 1;
                    inputNumbers.RemoveRange(left, lenght);
                    i = 0;
                    //inputNumbers.RemoveRange(inputNumbers[(i - 1) - specialNumbers[1]], specialNumbers[1]);
                    //inputNumbers.RemoveRange(inputNumbers[i], specialNumbers[1]);
                }
            }

            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
