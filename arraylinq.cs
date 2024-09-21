using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class arraylinq
    {
        static void Main(string[] args)
        {
            string[] productList = new string[7]; productList[0] = "Hard Disk";
            productList[1] = "Monitor";
            productList[2] = "SSD Disk";
            productList[3] = "Ram";
            productList[4] = "Processor";
            productList[5] = "Bluetooth";
            productList[6] = "Keyboard"; 
            var search = from x in productList
                                                      where x.Contains("Disk")
                                                      select x; foreach (var item in search)
            {
                Console.WriteLine("Product Name:{0}", item);
            }
        }


    }
    }

