using System;
using System.Linq;

namespace CompareCharArrays
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int count = 1;
            int shorterArray = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < firstArray.Length - 1; i++) {

                if (firstArray[i] < secondArray[i]) {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                    break;
                }
                else if(firstArray[i] > secondArray[i]) {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                    break;
                }
                else {
                    count++;
                    if(count == shorterArray) {
                        if (firstArray.Length > secondArray.Length) {
                            Console.WriteLine(secondArray);
                            Console.WriteLine(firstArray);
                            break;
                        }
                        else if (firstArray.Length < secondArray.Length) {
                            Console.WriteLine(firstArray);
                            Console.WriteLine(secondArray);
                            break;
                        }
                    }
                }
            }
            if (firstArray.Length == secondArray.Length && firstArray.Length == count) {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
        }
    }
}
