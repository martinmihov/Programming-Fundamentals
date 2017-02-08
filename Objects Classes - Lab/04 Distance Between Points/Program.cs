 using System;

namespace _04_Distance_Between_Points
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstPointCoords = Console.ReadLine().Split();

            Point firstPoint = new Point
            {
                x = double.Parse(firstPointCoords[0]),
                y = double.Parse(firstPointCoords[1])
            };

            string[] secondPointCoords = Console.ReadLine().Split();

            Point secondPoint = new Point
            {
                x = double.Parse(secondPointCoords[0]),
                y = double.Parse(secondPointCoords[1])
            };

            var result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine(result);

        }

        public static double CalcDistance(Point firstPoint,Point secondPoint)
        {
            double diffX = firstPoint.x - secondPoint.x;
            double diffY = firstPoint.y - secondPoint.y;
            double result = Math.Sqrt(Math.Pow(diffX,2) + Math.Pow(diffY,2));
            return result;
        }
    }
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
