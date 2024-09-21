using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class Student
    {
        public int roll;
        public string name;
        public int marks1;
        public int marks2;
        public int marks3;
        public int total;
        public int Avg;

        public void Accept()
        {
            Console.WriteLine("Enter Name: ");
            name= Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            roll= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Subject 1");
            marks1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Subject 2");
            marks2= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Subject 3");
            marks3= int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your Roll No is: " + roll);
           
        }

        public void Marks()
        {
            Console.WriteLine("Total Marks: " + (total = marks1+marks2+marks3));
            Console.WriteLine("Average Marks: " + (Avg = (marks1 + marks2 + marks3)/3));
        }


        static void Main()
        { 
            Student student= new Student();
            student.Accept();
            student.Display();
            student.Marks();
        }

    }
}
