using System;

namespace GeometryCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            if(figureType == "triangle" || figureType == "rectangle")
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());
                if(figureType == "triangle")
                {
                    Console.WriteLine("{0:f2}", TriangleArea(firstParameter,secondParameter));
                }
                else
                {
                    Console.WriteLine("{0:f2}", RectangleArea(firstParameter,secondParameter));
                }
            }
            else
            {
                double onlyParameter = double.Parse(Console.ReadLine());
                switch (figureType)
                {
                    case "square":
                        Console.WriteLine("{0:f2}",SquareArea(onlyParameter));
                        break;
                    case "circle":
                        Console.WriteLine("{0:f2}", CircleArea(onlyParameter));
                        break;
                }
            }
        }

        public static double TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        public static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }

        public static double CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
