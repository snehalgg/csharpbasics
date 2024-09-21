using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class monthno
    {
        static void Main()
        {
            int wday;


            Console.Write("Enter Month number (1-12): ");
            wday = Convert.ToInt32(Console.ReadLine());


            switch (wday)
            {
                case 1:
                    Console.WriteLine("It's Jan");
                    break;
                case 2:
                    Console.WriteLine("It's Feb");
                    break;
                case 3:
                    Console.WriteLine("It's Mar");
                    break;
                case 4:
                    Console.WriteLine("It's Apr");
                    break;
                case 5:
                    Console.WriteLine("It's May");
                    break;
                case 6:
                    Console.WriteLine("It's June");
                    break;
                case 7:
                    Console.WriteLine("It's July");
                    break;
                case 8:
                    Console.WriteLine("It's Aug");
                    break;
                    case 9:
                    Console.WriteLine("It's Sept");
                    break;
                case 10:
                    Console.WriteLine("It's Oct");
                    break;
                case 11:
                    Console.WriteLine("It's Nov");
                    break;
                case 12:
                    Console.WriteLine("It's Dec");
                    break;


                default:
                    Console.WriteLine("Enter Correct Month");
                    break;
            }
            Console.ReadLine();
        }
    }
}

