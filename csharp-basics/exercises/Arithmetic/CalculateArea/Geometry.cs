using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            double area = Math.PI * Convert.ToDouble(radius * radius);
            return Math.Round(area, 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return Convert.ToDouble(length * width);
        }
        
        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return Convert.ToDouble(ground * h / 2);
        }
        
    }
}
