using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _03_Word_Count
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(new char[] { '\r', '\n', '-', ' ', ',', '\'', '.', '?', '!' },StringSplitOptions.RemoveEmptyEntries);

            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (var word in text)
            {
                output[word] = 0;
            }
            foreach (var word in words)
            {
                if (output.ContainsKey(word))
                {
                    output[word]++;
                }
            }

            string[] sortedOutput = output.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray();

            File.WriteAllLines("output.txt",sortedOutput);
        }
    }
}
