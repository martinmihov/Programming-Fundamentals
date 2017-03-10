using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_LadyBUGSLady
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string commands = Console.ReadLine();

            int[] arrayField = new int[fieldSize];

            for (int i = 0; i < arrayField.Length; i++)
            {
                if (indexLadybugs.Contains(i))
                {
                    arrayField[i] = 1;
                }
            }
            while (commands != "end")
            {
                string[] command = commands.Split();
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladybugIndex < 0 || ladybugIndex >= arrayField.Length)
                {
                    commands = Console.ReadLine();
                    continue;
                }

                if (arrayField[ladybugIndex] == 0)
                {
                    commands = Console.ReadLine();
                    continue;
                }
                MoveLadybug(arrayField, ladybugIndex, flyLength, direction);

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arrayField));
        }


        public static void MoveLadybug(int[] arrayField, int ladybugIndex, int flyLength, string direction)
        {
            arrayField[ladybugIndex] = 0;

            bool isGone = false;
            while (!isGone)
            {
                switch (direction)
                {
                    case "left":
                        ladybugIndex -= flyLength;
                        break;
                    case "right":
                        ladybugIndex += flyLength;
                        break;
                }

                if (ladybugIndex < 0 || ladybugIndex >= arrayField.Length)
                {
                    isGone = true;
                    continue;
                }
                if (arrayField[ladybugIndex] == 1)
                {
                    continue;
                }

                if(arrayField[ladybugIndex] == 0)
                {
                    arrayField[ladybugIndex] = 1;
                    isGone = true;
                    continue;
                }
            }
        }
    }
}
