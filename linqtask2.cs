using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class linqtask2
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>();
            for (int i = 1; i < 6; i++)
            {
                string name;
                Console.WriteLine("Write names of five students: {0}", i );
                name = Console.ReadLine();

                student.Add(name);
            }
            var result = from s in student
                         where s.Contains("patil")
                         select s; foreach (var item in result)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(item);
            }
        }
    }
}
