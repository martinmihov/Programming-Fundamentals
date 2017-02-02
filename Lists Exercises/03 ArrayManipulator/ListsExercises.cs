using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    public class Lists
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "print")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    var index = int.Parse(command[1]);
                    var element = int.Parse(command[2]);
                    input.Insert(index, element);
                }
                else if (command[0] == "remove")
                {
                    var index = int.Parse(command[1]);
                    input.RemoveAt(index);
                }
                else if (command[0] == "contains")
                {
                    var element = int.Parse(command[1]);
                    int index = input.FindIndex(a => a == element);
                    Console.WriteLine(index);
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < input.Count - 1; i++)
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                }
                else if (command[0] == "shift")
                {
                    var positions = int.Parse(command[1]);
                    RotateLeft(input, positions);
                }
                else if (command[0] == "addMany")
                {
                    var position = int.Parse(command[1]);
                    if (position > input.Count)
                    {
                        break;
                    }
                    for (int i = command.Length - 1; i >= 2; i--)
                    {
                        input.Insert(position, int.Parse(command[i]));
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
        public static void RotateLeftOnce(List<int> input)
        {
            var numToSwitch = input[0];
            for (var i = 0; i < input.Count; i += 1)
            {
                if (i + 1 < input.Count)
                {
                    var switcher = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = switcher;
                }
            }
        }
        public static void RotateLeft(List<int> input, int positions)
        {
            for (var i = 0; i < positions; i += 1)
            {
                RotateLeftOnce(input);
            }
        }
    }
}