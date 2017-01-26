using System;

namespace CenterPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPoint = GetClosestPoint(x1, y1);
            double secondPoint = GetClosestPoint(x2, y2);
            if(firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }

        public static double GetClosestPoint(double x, double y)
        {
            double closestPoint = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return closestPoint;
        }
    }
}
