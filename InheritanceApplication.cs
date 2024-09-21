using System;
using System.Security.Policy;

namespace InheritanceApplication
{
    class shape1
    {
        public virtual int area()
        {
            Console.WriteLine("Parent class area:");
            return 0;
        }
    }
    class Triangle : shape1
    {
        public override int area()
        {
            Console.WriteLine("Triangle class area:");
            return 0;
        }
    }
    class Rectangle1 : shape1
    {
        public override int area()
        {
            Console.WriteLine("Rectangle class area:");
            return 0;
        }
    }
    internal class RectangleArea2
    {
        static void Main(string[] args)
        {
            shape1 s = new shape1();
            s.area(); Rectangle1 r = new Rectangle1();
            r.area();
            Triangle t = new Triangle();
            t.area();
            Console.ReadKey();
        }
    }
}
