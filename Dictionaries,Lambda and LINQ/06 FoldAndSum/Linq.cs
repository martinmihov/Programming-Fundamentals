using System;
using System.Linq;

namespace _06_FoldAndSum
{
    public class Linq
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            int[] firstRowLeftSide = new int[k];
            int[] firstRowRightSide = new int[k];

            firstRowLeftSide = input
                .Take(k)
                .Reverse()
                .ToArray();

            firstRowRightSide = input
                .Reverse()
                .Take(k)
                .ToArray();

            int[] firstRow = firstRowLeftSide
                .Concat(firstRowRightSide)
                .ToArray();

            int[] secondRow = input
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            int[] sum = new int[firstRow.Length];

            for (int i = 0; i < firstRow.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
