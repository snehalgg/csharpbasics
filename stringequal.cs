using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class stringequal
    {
        static void Main()
        {
            string username;
            string password;
            Console.Write("Input a username: ");
            username = Console.ReadLine();

            Console.Write("Input a password: ");
            password = Console.ReadLine();

            if (String.Compare(username, password) == 0)
            {
                Console.WriteLine(username + " and " + password + " are equal ");
            }
            else
            {
                Console.WriteLine(username + " and " + password + " are not equal ");
            }
            Console.ReadLine();
        }
    }
}
