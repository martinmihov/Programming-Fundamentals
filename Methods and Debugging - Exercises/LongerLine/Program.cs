using System;

namespace LongerLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstPair = GetLineLength(x1, y1, x2, y2);
            double secondPair = GetLineLength(x3, y3, x4, y4);

            if(firstPair < secondPair)
            {
                if (GetClosestPoint(x3, y3) > GetClosestPoint(x4, y4))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
            else
            {
                if (GetClosestPoint(x1, y1) > GetClosestPoint(x2, y2))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
        }

        public static double GetClosestPoint(double x, double y)
        {
            double closestPoint = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return closestPoint;
        }

        private static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return lineLength;
        }
    }
}
