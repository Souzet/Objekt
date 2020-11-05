using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt
{
    class Program
    {
        class Point
        {
            public int x, y;
            public Point (int X, int Y)
            {
                x = X; y = Y;
            }
           
        }
        static void Main(string[] args)
        {
            Point[] tria = new Point[3];

            tria[0] = new Point(0, 0);
            tria[1] = new Point(10, 0);
            tria[2] = new Point(0, 10);
            for (int i= 0; i< tria.Length; i++)
            {
                Console.WriteLine($"<{tria[i].x}, {tria[i].y}>");

            }
            List<Point> tria2 = new List<Point>(3);
            tria2.Add(new Point(0, 0));
            tria2.Add(new Point(0, 10));
            tria2.Add(new Point(10, 0));
            for (int i = 0; i < tria2.Count; i++)
            {
                Console.WriteLine($"<{tria2[i].x}, {tria2[i].y}>");
            }



        }
    }
}
