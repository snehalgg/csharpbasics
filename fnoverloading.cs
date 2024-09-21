using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class fnover
    {
        public class Area
        {

            public double area(double s)
            {
                double area = s * s;
                return area;
            }

            public double area(double l, double b)
            {
                double area = l * b;
                return area;
            }
        }

        class Programa
        {
            public static void Main(string[] args)
            {
                Area a = new Area();
                double length = 3;
                double breadth = 4;
                double rect = a.area(length, breadth);
                Console.WriteLine("Area of rectangle " + rect);

                double side = 5;
                double square = a.area(side);
                Console.WriteLine("Area of square: "+ square);
            }
        }
    }
}