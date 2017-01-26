using System;

namespace HelloName
{
    public class HelloName
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        public static string PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            return name;
        }
    }
}
