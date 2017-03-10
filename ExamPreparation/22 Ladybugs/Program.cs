using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ladybugs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string commands = Console.ReadLine();

            short[] arrayField = new short[fieldSize];

            for (int i = 0; i < arrayField.Length; i++)
            {
                if (indexLadybugs.Contains(i))
                {
                    arrayField[i] = 1;
                }
            }

            Console.WriteLine(string.Join(" ",arrayField));

            while (commands != "end")
            {
                string[] command = commands.Split();
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                

                if(direction == "right" && ladybugIndex < arrayField.Length && ladybugIndex >= 0)
                {
                    for (int i = ladybugIndex; i < arrayField.Length; i += flyLength) // i < arrayField.Length
                    {
                        int startIndex = ladybugIndex;
                        if (arrayField[i] == 0)
                        {
                            break;
                        }
                        else if (i + flyLength >= arrayField.Length)
                        {
                            arrayField[startIndex] = 0;
                            break;
                        }
                        else if (arrayField[i] == 1 && i + flyLength < arrayField.Length)
                        {
                            if(arrayField[i + flyLength] == 0)
                            {
                                arrayField[i + flyLength] = 1;
                                arrayField[startIndex] = 0;
                                break;
                            }
                            else if(arrayField[i + flyLength] == 1)
                            {
                                if (i + flyLength >= arrayField.Length)
                                {
                                    arrayField[startIndex] = 0;
                                    break;
                                }
                                else if(arrayField[i + flyLength] == 0)
                                {
                                    arrayField[i + flyLength] = 1;
                                    arrayField[startIndex] = 0;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (direction == "left" && ladybugIndex < arrayField.Length && ladybugIndex >= 0)
                {
                    for (int i = ladybugIndex; i >= 0; i -= flyLength) // i < arrayField.Length
                    {
                        int startIndex = ladybugIndex;
                        if (arrayField[i] == 0)
                        {
                            break;
                        }
                        else if (i + flyLength >= arrayField.Length)
                        {
                            arrayField[startIndex] = 0;
                            break;
                        }
                        else if (arrayField[i] == 1 && i + flyLength < arrayField.Length)
                        {
                            if (arrayField[i + flyLength] == 0)
                            {
                                arrayField[i + flyLength] = 1;
                                arrayField[startIndex] = 0;
                                break;
                            }
                            else if (arrayField[i + flyLength] == 1)
                            {
                                if (i + flyLength >= arrayField.Length)
                                {
                                    arrayField[startIndex] = 0;
                                    break;
                                }
                                else if (arrayField[i + flyLength] == 0)
                                {
                                    arrayField[i + flyLength] = 1;
                                    arrayField[startIndex] = 0;
                                    break;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(string.Join(" ", arrayField));
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arrayField));
        }
    }
}
