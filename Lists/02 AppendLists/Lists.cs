using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AppendLists
{
    public class Lists
    {
        public static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split('|').ToList();

            input.Reverse();

            List<string> result = new List<string>();

            foreach (var element in input)
            {
                List<string> nums = element.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
