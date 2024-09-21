using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class dictonarytask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> accessories = new Dictionary<string, int>();
            for (int a= 1; a < 6; a++)
            {
                string name;
                int b;
                Console.WriteLine("Write names of five accessories : ", a);
                name = Console.ReadLine();
                Console.WriteLine("Write price of five accessories : ", a);
                b = int.Parse(Console.ReadLine());
                accessories.Add(name, a);
            }
            /* var result= frpm s in productList 
             where s.Contains{"Disk"}
            selest s;
            */
            //Method 1 Query Syntax
            var search = from x in accessories
                        where x.Key.Contains("hair")
                        select x;

            //Method 2 Method syntax
           // var search= accessories.Where(p => p.Key.Contains("hair"));
            foreach (var result in search)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Product NAme: {0}, Price: {1}", result.Key, result.Value);
            }
            Console.ReadKey();
        }
    }
}

