using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class collections1
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList(); //arrayList Collection
            data.Add("Demo");       //add element
            data.Add(1);
            data.Add(5);
            data.Add(6);
            data.Add(7);
            data.Add(8);
            data.Remove(5);         //remoove element
            foreach (object obj in data)        //iteration
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }
    }
}
