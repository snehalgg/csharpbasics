using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class add1
    {
        static void Main()
        {
            int a = 0;
            int b = 0; do
            {
                Console.WriteLine("Enter a number");
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                    break;
                b += a;
            }
            while (true);
            Console.WriteLine(b);
        }
    }
}
