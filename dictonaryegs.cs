using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class dictonaryegs
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("Hard Disk", 1289);
            productList.Add("Monitor",3000);
            productList.Add("SSD Disk", 1420);
            productList.Add("Bluetooth", 540);

            /* var result= frpm s in productList 
             where s.Contains{"Disk"}
            selest s;
            */
            //Method 1 Query Syntax
            var search = from x in productList
                         where x.Key.Contains("Disk")
                         select x;

            //Method 2 Method syntax
            //var search= productList.Where(p => p.Key.Contains("Disk"));
            foreach(var result in search)
            {
                Console.WriteLine("Product NAme: {0}, Price: {1}", result.Key,result.Value);
            }
            Console.ReadKey();
        }
    }
}
