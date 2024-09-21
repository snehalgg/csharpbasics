using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            sbyte age;


            //Ask users name
            Console.WriteLine("Enter name?");
            name= Console.ReadLine();

            Console.WriteLine("Enter your Age");
            age=sbyte.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Name- " + name);
            Console.WriteLine("Age- " + age);
        }
        
    }
}
