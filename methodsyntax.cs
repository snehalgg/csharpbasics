using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class methodsyntax
    {
        static void Main(string[] args)
        {
            List<string> accessories = new List<string>();
            for (int i = 1; i < 6; i++)
            {
                string name;
                Console.WriteLine("Write names of five accessories : {0}", i);
                name = Console.ReadLine();

                accessories.Add(name);
            }
            var result = accessories.Where(p => p.Contains("hair"));

            foreach (string str in result)
            {
               
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(str.ToString());
                Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
