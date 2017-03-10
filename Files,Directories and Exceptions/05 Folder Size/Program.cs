using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _05_Folder_Size
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var files = Directory.GetFiles("FindMySize").Select(f => new FileInfo(f)).Sum(f => f.Length / 1024.0 / 1024.0); // Total Size of all files in that folder in bytes
            var files = Directory.GetFiles("FindMySize");

            long totalLength = 0L;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalLength += fileInfo.Length;
            }

            Console.WriteLine(totalLength / 1024.0 / 1024.0);
        }
    }
}
