using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace constructermm
{
    internal class task2
    {
        class Employee
        {
            //Data members
            protected int EmpId;
            protected string Name;
            protected int Salary;
            public void GetEmpData()
            {
                Console.WriteLine("Enter Employee Id");
                this.EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name");
                this.Name = Console.ReadLine();
                Console.WriteLine("Enter the salary");
                this.Salary = int.Parse(Console.ReadLine());
            }
            public void PutEmpData()
            {
                Console.WriteLine($"ID:{EmpId}\nName:{Name}\nSalary:{Salary}");
            }
        }
        class Sales1 : Employee
        {
            public void Inc()
            {
                Salary += (Salary + 10) / 100;
                Console.WriteLine("Salary after Increment : " + Salary);
            }
        }
        static void Main()
        {
            Sales1 s1 = new Sales1();
            s1.GetEmpData();
            s1.PutEmpData();
            s1.Inc();
        }
    }
}
