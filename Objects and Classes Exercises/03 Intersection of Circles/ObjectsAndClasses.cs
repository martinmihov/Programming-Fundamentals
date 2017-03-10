using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intersection_of_Circles
{
    public class ObjectsAndClasses
    {
        public static void Main(string[] args)
        {
            int[] firstCircleData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCircleData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstCenter = new Point(firstCircleData[0], firstCircleData[1]);
            Point secondCenter = new Point(secondCircleData[0], secondCircleData[1]);

            Circle firstCircle = new Circle(firstCenter, firstCircleData[2]);
            Circle secondCircle = new Circle(secondCenter, secondCircleData[2]);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}


