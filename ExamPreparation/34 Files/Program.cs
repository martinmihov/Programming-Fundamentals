using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _34_Files
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, BigInteger>> files = new Dictionary<string, Dictionary<string, BigInteger>>();

            for (int i = 0; i < n; i++)
            {
                string[] routeParams = Console.ReadLine()
                    .Split(new[] { '\\' }
                    .ToArray());

                string root = routeParams[0];

                string[] fileWithSize = routeParams[routeParams.Length - 1].Split(';');

                string fileNameWithExtension = fileWithSize[0];

                BigInteger fileSize = BigInteger.Parse(fileWithSize[1]);

                if (!files.ContainsKey(root))
                {
                    files.Add(root, new Dictionary<string, BigInteger>());
                }
                if (!files[root].ContainsKey(fileNameWithExtension))
                {
                    files[root].Add(fileNameWithExtension, fileSize);
                }
                else
                {
                    files[root][fileNameWithExtension] = fileSize;
                }
            }

            string[] extensionInRoot = Console.ReadLine()
                .Split(new[] { ' ' });

            string extensionCheck = extensionInRoot[0];
            string rootCheck = extensionInRoot[2];

            if (files.ContainsKey(rootCheck))
            {
                Dictionary<string, BigInteger> query = files[rootCheck];

                foreach (var aFile in query.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (aFile.Key.EndsWith(extensionCheck))
                    {
                        Console.WriteLine("{0} - {1} KB", aFile.Key, aFile.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
