using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class functionadd
    {
        public static int Sum(int a, int b, int c)
        {
            int total;
            total = a+b+c;
            return total;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of three numbers is : {0} ", Sum(n1, n2, n3));
        }
    }
}
