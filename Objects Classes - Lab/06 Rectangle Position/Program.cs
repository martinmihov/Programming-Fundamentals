using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rectangle_Position
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");

        }

        public static Rectangle ReadRectangle()
        {
            int[] firstRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle r1 = new Rectangle
            {
                Left = firstRectangle[0],
                Top = firstRectangle[1],
                Width = firstRectangle[2],
                Height = firstRectangle[3]
            };
            return r1;
        }
    }
    

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
    

}

