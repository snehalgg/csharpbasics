using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class inheritance
    {
        class Shape
        {
            //public Members
            public int width;
            public int height;
            public Shape(int w, int h)
            { 
                this.width = w;
                this.height = h;
            }
            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
        }
        //Derived class
        class Rectangle : Shape
        {
            public Rectangle(int w, int h) : base(w, h)//Derived class constructor
            { }
            public int getArea()
            {
                return (width * height);
            }
            class RectangleTester
            {
                static void Main(string[] args)
                {
                    Rectangle Rect = new Rectangle(5,7);
                    //Object of erived class

                    //Rect.setWidth(15);
                    //Rect.setHeight(27);
                    //Print the area of the object.
                    Console.WriteLine("Total area: {0}", Rect.getArea());
                    Console.ReadKey();
                }
            }
        }
    }
}
