using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfaRectangle = double.Parse(Console.ReadLine());
            double heighOfaRectangle = double.Parse(Console.ReadLine());

            double perimeter = (2 * widthOfaRectangle) + (2 * heighOfaRectangle);
            double area = widthOfaRectangle * heighOfaRectangle;
            double diagonal = Math.Sqrt((widthOfaRectangle * widthOfaRectangle) + (heighOfaRectangle * heighOfaRectangle));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
