using System;
using System.Collections.Generic;
using System.Linq;

namespace _32_Command_Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] aCommand = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstWord = aCommand[0];

                switch (firstWord)
                {
                    case "reverse":
                        int reverseStart = int.Parse(aCommand[2]);
                        int reverseCount = int.Parse(aCommand[4]);

                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            Reversed(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "sort":
                        int sortStart = int.Parse(aCommand[2]);
                        int sortCount = int.Parse(aCommand[4]);

                        if (IsValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":

                        int rollLeftCount = int.Parse(aCommand[1]);
                        if (rollLeftCount >= 0)
                        {
                            RollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":

                        int rollRightCount = int.Parse(aCommand[1]);

                        if (rollRightCount >= 0)
                        {
                            RollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ", array));
        }

        private static void RollRight(List<string> array, int rollRightCount)
        {
            for (int i = 0; i < rollRightCount % array.Count; i++)
            {
                string lastNumber = array[array.Count - 1];

                array.RemoveAt(array.Count - 1);
                array.Insert(0, lastNumber);
            }
        }

        private static void RollLeft(List<string> array,int rollLeftCount)
        {
            for (int i = 0; i < rollLeftCount % array.Count; i++)
            {
                string firstNumber = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = firstNumber;
            }
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            List<string> resultArray = array.Skip(sortStart).Take(sortCount).OrderBy(a => a).ToList();

            array.RemoveRange(sortStart, sortCount);
            array.InsertRange(sortStart, resultArray);
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            if (start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count)
            {
                return true;
            }
            return false;
        }

        private static void Reversed(List<string> array,int reverseStart, int reverseCount)
        {
            List<string> resultArray = array.Skip(reverseStart).Take(reverseCount).Reverse().ToList();

            array.RemoveRange(reverseStart, reverseCount);
            array.InsertRange(reverseStart, resultArray);
        }
    }
}
