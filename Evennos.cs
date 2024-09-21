using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class Evennos
    {
        static void Main()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}