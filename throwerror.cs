using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class throwerror
    {
        static void Main()
        {
            long accountno;
            string custName;
            int balance;

            Console.WriteLine("Enter Account No");
            accountno = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            custName = Console.ReadLine();
            Console.WriteLine("Enter Amount to withdraw");
            balance = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (balance == 1000 || balance < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Arigatto! You have withdrawn {0} rupees", balance);
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw (new OutofBalanceException("OutofBalanceException Generated: Not enough balance in account"));
                }
            }
            catch (OutofBalanceException oex)
            {
                Console.WriteLine(oex.Message.ToString());
                Console.ReadLine();
            }


        }
    }

    public class OutofBalanceException : Exception
    {
        public OutofBalanceException(string message)

            : base(message) { }
    }
}

