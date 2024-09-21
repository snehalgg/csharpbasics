using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class polimorphisiomappln
    {
        abstract class shape
        {
            public abstract int area();
        }
        class rectangle : shape
        {
            private int length;
            private int width;
            public rectangle(int a = 0, int b = 0)
            {
                length = a;
                width = b;
            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area:");
                return (width * length);
            }
        }
        internal class Rectangletester
        {
            static void Main()
            {
                rectangle r = new rectangle(10, 7);
                double a = r.area();
                Console.WriteLine("Area: {0}", a);
                Console.ReadKey();
            }
        }
    }
}
