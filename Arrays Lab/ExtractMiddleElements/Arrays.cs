using System;

namespace ExtractMiddleElements
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] numberOfElements = Console.ReadLine().Split(' ');
            int[] parsedElements = new int[numberOfElements.Length];

            for (int i = 0; i < numberOfElements.Length; i++)
            {
                parsedElements[i] = int.Parse(numberOfElements[i]);
            }

            if (numberOfElements.Length == 1) {
                Console.Write("{ ");
                Console.Write($"{parsedElements[0]}");
                Console.WriteLine(" }");
            }
            else if (numberOfElements.Length % 2 == 0) {
                Console.Write("{ ");
                Console.Write($"{parsedElements[numberOfElements.Length / 2 - 1]}, {parsedElements[numberOfElements.Length / 2]}");
                Console.WriteLine(" }");
            }
            else if(numberOfElements.Length % 2 != 0) {
                Console.Write("{ ");
                Console.Write($"{parsedElements[numberOfElements.Length / 2 - 1]}, {parsedElements[numberOfElements.Length / 2]}, {parsedElements[numberOfElements.Length / 2 + 1]}");
                Console.WriteLine(" }");
            }
        }
    }
}
