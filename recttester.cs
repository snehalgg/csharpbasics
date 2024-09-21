using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    class Shape
    {
        //Data Members
        public int width;
        public int height;

        //Member methods
        public void setWidth(int w)
        {
            width = w;

        }
        public void setHeight(int h)
        {
            height = h;
        }


        //Derived class
        class Rectangle :Shape
        {
            
            public int getArea()
            {
                return (width * height);

            }
        }
        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle Rect = new Rectangle();
                //Object of erived class

                Rect.setWidth(15);
                Rect.setHeight(27);
                //Print the area of the object.
                Console.WriteLine("Total area: {0}", Rect.getArea());
                Console.ReadKey();
            }
        }
    }
}
