using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class Eligibleage
    {
        static void Main()
        {

            int age;

            Console.WriteLine("Enter your Age");
            age = sbyte.Parse(Console.ReadLine());
            if (age < 18)
                {
                    Console.WriteLine("User is not eligible to vote");
                }
           
            else if (age >= 18)
            {
                Console.WriteLine("user is eligible to vote");
            }
           
        }
    }
}
