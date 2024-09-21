
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{

    class ForEachclass
    {


        static void Main(String[] arg)
        {
            {
                int[] arr = new int[5];
                arr[1] = 10;
                arr[2] = 12;
                arr[3] = 9;
                arr[4] = 15;
               

                int highest_arr = maximum(arr);

                Console.WriteLine("The highest Number is " + highest_arr);
            }
        }


        static int maximum(int[] numbers)
        {
            int arr = numbers[0];


            foreach (int num in numbers)
            {
                if (num > arr)
                {
                    arr = num;
                }
            }
            return arr;
        }
    }
}
