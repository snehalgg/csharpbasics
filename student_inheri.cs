using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class studtask
    {
        class student
        {

            public int stuId;
            public string stuname;
            public int fees;

            //Member methods
            public void getstudentdata()
            {
                Console.WriteLine("Enter Student Name: ");
                this.stuname = Console.ReadLine();
                Console.WriteLine("Enter Student Id: ");
                this.stuId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fees: ");
                this.fees = int.Parse(Console.ReadLine());
            }
            public void putstudentdata()
            {
                Console.WriteLine($"ID: {stuId} Name:{stuname} Fees: {fees}");
            }


            //Derived class
            class Fees : student
            {

                public void getInc()
                {
                    fees = 1000;
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Lab fees: " + fees);
                    

                }

            }
            class Stud
            {
                static void Main(string[] args)
                {
                    Fees fee = new Fees();
                    //Object of erived class

                    fee.getstudentdata();
                    fee.putstudentdata();
                    fee.getInc();
                    Console.ReadKey();
                }
            }
        }
    }
}

