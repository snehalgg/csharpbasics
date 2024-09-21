using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class breakandcont
    {
        static void Main()
        {
            int i;
            for (i=1; i<=10; i++)
            {
                if (i == 2)
                    break;
                Console.WriteLine(i);
            }
            Console.ReadLine();

            for (i = 1; i <= 10; i++)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
