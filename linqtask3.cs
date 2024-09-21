using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class linqtask3
    {
        static void Main(string[] args)
        {
            List<string> states = new List<string>();
            for (int i = 1; i < 6; i++)
            {
                string name;
                Console.WriteLine("Write names of five states : {0}", i );
                name = Console.ReadLine();

                states.Add(name);
            }
            var result = from s in states
                         where s.Contains("pradesh")
                         select s; foreach (var item in result)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(item);
            }
        }
    }
}
