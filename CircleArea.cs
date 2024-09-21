using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class CircleArea
    {
        static void Main()
        {
            double radius, area ;

            Console.WriteLine("Enter radius");
            radius= Convert.ToInt32(Console.ReadLine());

            area = (Math.PI * radius *radius);
            Console.WriteLine("Area of circle is  " +area);
            Console.ReadLine();
        }
    }
}
