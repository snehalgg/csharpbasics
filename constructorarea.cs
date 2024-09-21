using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shubhalimam
{
    internal class Mobile
    {
        private long nolength;
        private string brand;

        public Mobile()
        {
            Console.WriteLine("Enter Mobile No");
            nolength=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Name");
            brand = Console.ReadLine();
        }
        

        public double getData()
        {
            return nolength;
                   }
        public string getBrand()
        {
            return brand;
        }


        public void putData()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Mobile Number: {0}", nolength);
            Console.WriteLine("Mobile Brand: {0}", brand);
        }
        class ExecuteMobile
        {
            static void Main(string[] args)
            {
                Mobile mobile = new Mobile();
               
                mobile.putData();
                
            }
        }
    }
}
