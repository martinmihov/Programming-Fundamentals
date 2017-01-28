using System;
// using System.Text;

namespace ReverseArrayOfStrigs
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputStrings.Length / 2; i++)
            {
                string temp = inputStrings[i];
                var reverseIndex = inputStrings.Length - 1 - i;
                inputStrings[i] = inputStrings[reverseIndex];
                inputStrings[reverseIndex] = temp;
            }
            Console.WriteLine(string.Join(" ",inputStrings));

            // Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').ToArray().Reverse().ToArray()));
        }
    }
}
