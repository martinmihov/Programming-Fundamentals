using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int input = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input,secondInput));
            }else if(type == "char")
            {
                char input = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input,secondInput));
            }else if(type == "string")
            {
                string input = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(input,secondInput));
            }
        }
        public static int GetMax(int input, int secondInput)
        {
            if(input >= secondInput)
            {
                return input;
            }else
            {
                return secondInput;
            }
        }
        public static char GetMax(char input, char secondInput)
        {
            if (input >= secondInput)
            {
                return input;
            }
            else
            {
                return secondInput;
            }
        }
        public static string GetMax(string input, string secondInput)
        {
            if (input.CompareTo(secondInput) >= 0)
            {
                return input;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
