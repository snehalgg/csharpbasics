using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class add
    {
        static void Main()
        {
            double i , n , sum;
            Console.WriteLine("Enter two numbers");
            i = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                sum = n + i;
                if (i <0 | n<0)
                    break;
                Console.WriteLine("{0} + {1} = {2}", n, i, sum);
                
            } while (i <= 1);
        }
    }
}
