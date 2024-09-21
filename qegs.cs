using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class linq2
    {
        static void Main()
        {
            List<string> productList = new List<string>()
 {
 "hard disk",
 "monitor",
 "ssd disk",
 "ram",
 "processor",
 "bluetooth",
 "keyboard & mouse"
 };
            var result = from s in productList
                         where s.Contains("disk")
                         select s; foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
