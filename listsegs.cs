using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class listsegs
    {
        class Linq
        {
            static void Main(string[] args)
            {
                //creating list
                List<string> productList = new List<string>()
            {
                "Hard Disk",
                    "Monitor",
                    "SSD Disk",
                    "RAM",
                    "Bluetooth",
                    "Keyboard & Mouse"
            };

                var result = from s in productList
                             select s;
                foreach (string str in result)
                {
                    Console.WriteLine(str.ToString());

                }
                Console.ReadKey();
            }
        }
    }
}
