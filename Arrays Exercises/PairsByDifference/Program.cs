using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int inputDifference = int.Parse(Console.ReadLine());

            int count = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length  ; j++)
                {
                    if (Math.Abs(arr[j] - arr[i]) == inputDifference && i < j)
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
