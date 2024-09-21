using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class weekday
    {
        static void Main()
        {
            int wday;

            
            Console.Write("Enter weekday number (1-7): ");
            wday = Convert.ToInt32(Console.ReadLine());

            
            switch (wday)
            {
                case 1:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 2:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 3:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 5:
                    Console.WriteLine("It's THURSDAY");
                    break;
                case 6:
                    Console.WriteLine("It's FRIDAY");
                    break;
                case 7:
                    Console.WriteLine("It's SATURDAY");
                    break;

               
                default:
                    Console.WriteLine("It's wrong input");
                    break;
            }
            Console.ReadLine();
        }
    }
    }

