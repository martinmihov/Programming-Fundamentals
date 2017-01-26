using System;

namespace CubeProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameterOfCube = Console.ReadLine().ToLower();

            switch (parameterOfCube)
            {
                case "face":
                    Console.WriteLine(GetFace(sideOfCube));
                    break;
                case "space":
                    Console.WriteLine(GetSpace(sideOfCube));
                    break;
                case "volume":
                    Console.WriteLine(GetVolume(sideOfCube));
                    break;
                case "area":
                    Console.WriteLine(GetArea(sideOfCube));
                    break;

            }
        }

        public static double GetArea(double givenSide)
        {
            double side = Math.Round((givenSide * givenSide) * 6, 2);
            return side;
        }

        public static double GetVolume(double givenSide)
        {
            double side = Math.Round(givenSide * givenSide * givenSide, 2);
            return side;
        }

        public static double GetFace(double givenSide)
        {
            double side = Math.Round(Math.Sqrt((Math.Pow(givenSide, 2) * 2)), 2);
            return side;
        }

        public static double GetSpace(double givenSide)
        {
            double side = Math.Round(Math.Sqrt((Math.Pow(givenSide, 2) * 3)), 2);
            return side;
        }
    }
}
