using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class foreachsmall
    {
        static void Main()
        {
            int[] a = { 23, 434, 234, 543, 350, -23, 133, 54, 3, -34, -124 };

            var ans = a.Max();
            Console.WriteLine(ans);

            int min = a[0];
            int max = a[0];

            foreach (int i in a)
            {
                if (i < min) 
                    min = i; 
            }

            foreach (int i in a)
            {
                if (i > max)
                    max = i;
            }

            Console.WriteLine("The minimum value is: " +min);
            Console.WriteLine("The maximum value is: " + max);
        }
    }
    }

