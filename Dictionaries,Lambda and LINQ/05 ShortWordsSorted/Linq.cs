using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ShortWordsSorted
{
    public class Linq
    {
        public static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '/', '!', '?', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            //SortedDictionary<string,int> shortWordsSorted = new SortedDictionary<string, int>();
            
            //foreach (var word in words) {
            //    int counter = 0;

            //    foreach (var symbol in word) {
            //        counter++;
            //    }
            //    if(counter < 5) {
            //        shortWordsSorted[word] = 0;
            //    }
            //}

            Console.WriteLine(string.Join(", ",words));
        }
    }
}