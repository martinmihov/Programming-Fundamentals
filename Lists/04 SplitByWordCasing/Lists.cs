using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                                                    StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }
                if (isAllLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _04_SplitByWordCasing
//{
//    public class Lists
//    {
//        public static void Main(string[] args)
//        {
//            List<string> input = Console.ReadLine().Split(new char[] {
//                ' ', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ',' }
//            ,StringSplitOptions.RemoveEmptyEntries).ToList();

//            List<string> lowercase = new List<string>();
//            List<string> uppercase = new List<string>();
//            List<string> mixedcase = new List<string>();

//            for (int i = 0; i < input.Count; i++)
//            {
//                if (input[i] == input[i].ToUpper())
//                {
//                    uppercase.Add(input[i]);
//                }
//                else if (input[i] == input[i].ToLower())
//                {
//                    lowercase.Add(input[i]);
//                }
//                else
//                {
//                    mixedcase.Add(input[i]);
//                }
//            }
//            for (int i = 0; i < 1; i++)
//            {
//                Console.Write("Lower-case:");
//                for (int k = 0; k < lowercase.Count; k++)
//                {
//                    Console.Write($" ,{lowercase[k]}");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 0; i < 1; i++)
//            {
//                Console.Write("Mixed-case:");
//                for (int k = 0; k < mixedcase.Count; k++)
//                {
//                    Console.Write($" ,{mixedcase[k]}");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 0; i < 1; i++)
//            {
//                Console.Write("Upper-case:");
//                for (int k = 0; k < uppercase.Count; k++)
//                {
//                    Console.Write($" ,{uppercase[k]}");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
