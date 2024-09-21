using Shubhalimam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shubhalimam
{
     class Employeebase
    {
        public int EmpId;
        public string Ename;
        public int sal;

        //Member methods
        public void getempdata()
        {
            Console.WriteLine("Enter Name: ");
            this.Ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Id: ");
            this.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee salary: ");
            this.sal = int.Parse(Console.ReadLine());
        }
        public void putempdata()
        {
            Console.WriteLine($"ID: {EmpId} Name:{Ename} Salary: {sal}");
        }


        //Derived class
        class Sale : Employeebase
        {

            public void getInc()
            {
             sal += (sal/10);
                Console.WriteLine("Salary After: " + sal);

            }
        }
        class Sales2
        {
            static void Main(string[] args)
            {
               Sale sale = new Sale();
                //Object of erived class

                sale.getempdata();
                sale.putempdata();
                sale.getInc();
                Console.ReadKey();
            }
        }
    }
}
