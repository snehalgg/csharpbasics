using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class continuearray
    {
        static void Main()
        {
            int[] arr = new int[10];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;
            arr[6] = 7;
            arr[7] = 8;
            arr[8] = 9;
            arr[9] = 10;

            int i;
            for (i = 0; i < 10; i++)
            {
                if (arr[i] == 3)
                    continue;
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
