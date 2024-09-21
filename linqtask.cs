using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class linqtask
    {
        private static int n;

        static void Main(string[] args)
        {


            List<string> student = new List<string>();
            for(int i =0; i<5; i++) 
            {
                string name;
                Console.WriteLine("Write names of five students", i*1);
                name = Console.ReadLine();

                student.Add(name);
            } 


            

            var result = from name in student
                         select name;
            foreach (string str in result)
            {
                Console.WriteLine(str.ToString());

            }
            Console.ReadKey();
        }
}
    }
