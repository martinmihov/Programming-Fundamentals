using System;

namespace LargestCommonEnd
{
    public class ArraysExercises
    {
        public static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int maxCountLeft = ScanFromLeft(firstArray, secondArray);
            int maxCountRight = ScanFromRight(firstArray, secondArray);

            if (maxCountLeft > maxCountRight) {
                Console.WriteLine(maxCountLeft);
            }
            else if (maxCountLeft == 0 && maxCountRight == 0) {
                Console.WriteLine(0);
            }
            else {
                Console.WriteLine(maxCountRight);
            }
        }
        public static int ScanFromRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;

            if(firstArray.Length > secondArray.Length)
            {
                int longArrayIndex = firstArray.Length - 1;

                for (int i = secondArray.Length - 1; i >= 0; i--)
                {
                    if (firstArray[longArrayIndex] == secondArray[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longArrayIndex--;
                }
            }
            else
            {
                int longArrayIndex = secondArray.Length - 1;

                for (int i = firstArray.Length - 1; i >= 0; i--)
                {
                    if (secondArray[longArrayIndex] == firstArray[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longArrayIndex--;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            count = 0;

            return maxCount;
        }
        public static int ScanFromLeft(string[] firstArray, string[] secondArray)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            count = 0;
            
            return maxCount;
        }
    }
}
