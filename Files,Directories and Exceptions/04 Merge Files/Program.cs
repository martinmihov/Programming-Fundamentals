using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _04_Merge_Files
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllLines("firstInput.txt");
            string[] secondFile = File.ReadAllLines("secondInput.txt");
            File.WriteAllText("result.txt", "");

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }
        }
    }
}
