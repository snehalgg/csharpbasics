using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class methodintax
    {
        static void Main(string[] args)
        {
            //Creating lists
            IList<string> productList = new List<string>()
            {
                "HDDisk",
                "SDD",
                "RAM",
                "BT",
                "Keyboard",
            };
            var result = productList.Where(p => p.Contains("Disk"));

            foreach (string str in result)
            {
                Console.WriteLine(str.ToString());
            }
            Console.ReadKey();
        }
    }
}
