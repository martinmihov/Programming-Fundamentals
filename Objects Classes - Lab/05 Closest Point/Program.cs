using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_Point
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                double[] currentPoint = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();


                Point aPoint = new Point
                {
                    x = currentPoint[0],
                    y = currentPoint[1]
                };

                points.Add(aPoint);
            }

            double minDistancesoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    double currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if(currentDistance < minDistancesoFar)
                    {
                        minDistancesoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine(minDistancesoFar);
            Console.WriteLine($"({firstPointMax.x}, {firstPointMax.y})");
            Console.WriteLine($"({secondPointMax.x}, {secondPointMax.y})");

        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = firstPoint.x - secondPoint.x;
            double diffY = firstPoint.y - secondPoint.y;
            double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return result;
        }
    }
   

    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }



}
