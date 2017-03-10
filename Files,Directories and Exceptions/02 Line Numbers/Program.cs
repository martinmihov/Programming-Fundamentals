using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _02_Line_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var file = "LineNumbers.txt";
            var input = File.ReadAllLines(file);
            var newFile = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                newFile.Add($"{i + 1}. {input[i]}");
            }

            File.WriteAllLines("result.txt", newFile);
            
        }
    }
}
