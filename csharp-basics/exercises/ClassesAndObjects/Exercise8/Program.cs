using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(p1, p2);

            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        }

        static void SwapPoints(Point p1, Point p2)
        {
            int p1X = p1.x;
            int p1Y = p1.y;

            int p2X = p2.x;
            int p2Y = p2.y;

            p1.x = p2X;
            p1.y = p2Y;

            p2.x = p1X;
            p2.y = p2Y;
        }
    }
}
