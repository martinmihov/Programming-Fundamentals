using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string str1 = input[0];
        string str2 = input[1];

        int minLen = Math.Min(str1.Length, str2.Length);
        int maxLen = Math.Max(str1.Length, str2.Length);
        int sum = 0;

        for (int i = 0; i < minLen; i++)
        {
            sum += MultiplyCharsASCII(str1[i], str2[i]);
        }

        if (str1.Length != str2.Length)
        {
            string longerInput = str1.Length > str2.Length ? longerInput = str1 : longerInput = str2;
            for (int i = minLen; i < maxLen; i++)
            {
                sum += longerInput[i];
            }
        }
        Console.WriteLine(sum);
    }

    static int MultiplyCharsASCII(char let1, char let2)
    {
        int multiply = let1 * let2;
        return multiply;
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Numerics;
//using System.Threading.Tasks;

//namespace _04_Character_Multyplier
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split().ToArray();

//            char[] first = input[0].ToCharArray();
//            char[] second = input[1].ToCharArray();
//            int shortest = Math.Min(first.Length, second.Length);
//            int longest = Math.Max(first.Length, second.Length);
//            int difference = longest - shortest;

//            BigInteger result = new BigInteger();
//            for (int i = 0; i < shortest; i++)
//            {
//                result += Multiplier(first[i], second[i]);
//                if (i == shortest - 1)
//                {
//                    for (int k = shortest; k <= longest - 1; k++)
//                    {
//                        if (first.Length > second.Length)
//                        {
//                            result += first[i];
//                        }
//                        else if (second.Length > first.Length)
//                        {
//                            result += second[i];
//                        }
//                    }
//                }
//            }
//            Console.WriteLine(result);
//        }
//        public static int Multiplier(char first , char second)
//        {
//            int multy = first * second;
//            return multy;
//        }
//    }
//}
