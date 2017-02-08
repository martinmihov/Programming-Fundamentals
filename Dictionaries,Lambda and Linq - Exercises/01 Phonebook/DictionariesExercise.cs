using System;
using System.Collections.Generic;

namespace _01_Phonebook
{
    public class DictionariesExercise
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            List<string> searchEngine = new List<string>();

            bool keepAdding = true;

            while (keepAdding) {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "END") {
                    keepAdding = false;
                }
                else if (input[0] == "A") {
                    phonebook[input[1]] = input[2];
                    searchEngine.Add(input[1]);
                }
                else if (input[0] == "S") {

                    if (searchEngine.Contains(input[1])) {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
            }
        }
    }
}
