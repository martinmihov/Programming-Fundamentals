using System;
using System.Collections.Generic;
using System.Linq;

namespace _53_Matrix_Operator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());

            List<List<int>> rowList = new List<List<int>>();

            for (int i = 0; i < r; i++)
            {
                rowList.Add(Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList());
            }

            string inputCommands = Console.ReadLine();

            while (inputCommands != "end")
            {
                string[] commands = inputCommands
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commands[0])
                {
                    case "remove":
                        string type = commands[1];
                        string position = commands[2];
                        int index = int.Parse(commands[3]);
                        RemoveCommand(rowList, type, position, index);
                        break;

                    case "swap":
                        int swapThat = int.Parse(commands[1]);
                        int swapWithThat = int.Parse(commands[2]);
                        SwapCommand(rowList, swapThat, swapWithThat);
                        break;

                    case "insert":
                        int rowNumber = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        InsertCommand(rowList, rowNumber, element);
                        break;

                }
                inputCommands = Console.ReadLine();
            }

            foreach (var item in rowList)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
        
        private static void InsertCommand(List<List<int>> rowList, int rowNumber, int element)
        {
            rowList[rowNumber].Insert(0, element);
        }

        private static void SwapCommand(List<List<int>> rowList, int swapThat, int swapWithThat)
        {
            List<int> replaced = rowList[swapThat];
            rowList[swapThat] = rowList[swapWithThat];
            rowList[swapWithThat] = replaced;
        }

        private static void RemoveCommand(List<List<int>> rowList, string type, string position, int index)
        {

            switch (type)
            {
                case "positive":
                    switch (position)
                    {
                        case "row":
                            rowList[index] = rowList[index].Where(o => o < 0)
                                .ToList();

                            Console.WriteLine(string.Join(" ", rowList[index]));
                            break;

                        case "col":
                            int count = 0;
                            foreach (var item in rowList)
                            {
                                if(item.Count >= 0)
                                {
                                    rowList[count] = item.Where(o => o < 0).ToList();
                                }
                                count++;
                            }
                            break;
                    }
                    break;

                case "negative":
                    switch (position)
                    {
                        case "row":

                            rowList[index] = rowList[index].Where(o => o >= 0).ToList();
                            Console.WriteLine(string.Join(" ", rowList[index]));
                            break;

                        case "col":

                            int count = 0;
                            foreach (var item in rowList)
                            {
                                if (index < item.Count() && item[index] < 0)
                                {
                                    if (rowList[count].Contains(item[index]))
                                    {
                                        rowList[count] = rowList[count].Where(o => o != item[index]).ToList();
                                        Console.WriteLine(string.Join(" ", rowList[count]));
                                    }
                                }
                                count++;
                            }
                            break;
                    }
                    break;
                case "odd":
                    switch (position)
                    {
                        case "row":

                            rowList[index] = rowList[index].Where(o => Math.Abs(o) % 2 == 0).ToList();
                            Console.WriteLine(string.Join(" ", rowList[index]));
                            break;

                        case "col":

                            int count = 0;
                            foreach (var item in rowList)
                            {
                                if (index < item.Count() && Math.Abs(item[index]) % 2 == 1)
                                {
                                    if (rowList[count].Contains(item[index]))
                                    {
                                        rowList[count] = rowList[count].Where(o => o != item[index]).ToList();
                                        Console.WriteLine(string.Join(" ", rowList[count]));
                                    }
                                }
                                count++;
                            }
                            break;
                    }
                    break;

                case "even":

                    switch (position)
                    {
                        case "row":
                            rowList[index] = rowList[index].Where(o => Math.Abs(o) % 2 == 1).ToList(); // its working
                            Console.WriteLine(string.Join(" ", rowList[index]));
                            break;

                        case "col":

                            int count = 0;
                            foreach (var item in rowList)
                            {
                                if (index < item.Count() && Math.Abs(item[index]) % 2 == 0)
                                {
                                    if (rowList[count].Contains(item[index]))
                                    {
                                        rowList[count] = rowList[count].Where(o => o != item[index]).ToList();
                                        Console.WriteLine(string.Join(" ", rowList[count]));
                                    }
                                }
                                count++;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
