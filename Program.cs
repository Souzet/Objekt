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
            public double x, y;
            public Point (double X, double Y)
            {
                x = X; y = Y;
            }
            public Point() { }
        }
        static void Main(string[] args)
        {
            Point p, q;
            p = new Point() { x = 12.3, y = 17.5 };
            q = new Point(12.3, 17.5);
            Console.WriteLine($"p =<{p.x}, {p.y}>");
            Console.WriteLine($"q =<{q.x}, {q.y}>");

        }
    }
}
