using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class employee
    {
        public int empid;
        public string name;
        public int Basic;
        public int HRA;
        public int rent;

        public void getdetails()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Id: ");
            empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Basic Pay: ");
            Basic = int.Parse(Console.ReadLine());
            
        }

        public void putdetails()
        {
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your employee id is: " + empid);

        }
        public void Salary()
        {
            Console.WriteLine("Your HRA is: " + ((Basic*10))/100);
        }

        static void Main()
        {
            employee Emp = new employee();
            Emp.getdetails();
            Emp.putdetails();
            Emp.Salary();
        }
    }
}