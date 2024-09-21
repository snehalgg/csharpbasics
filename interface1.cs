﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class interface1
    {
        public interface ITransactions //interface
        {
            void showTransaction();
            double getAmount();

        }
        public interface ITrans //interface
        {
            void calAmount();
        }
        public class Transaction : ITransactions, ITrans //interface
        {
            private string tCode;
            private string date;
            private double amount;
            public Transaction() //default constructor
            { 
                tCode = "";
                date = "";
                amount = 0.0;
            }
            public Transaction(string c, string d, double a)
            { 
            tCode = c;
                date = d;
                amount = a;
            }
            public double getAmount()
            {
                return amount;
            }
            public void showTransaction()
            { Console.WriteLine("Transaction: {0}", tCode);

                Console.WriteLine("Date:{0}", date);
                Console.WriteLine("Amount: {0}", getAmount());
            }
            public void calAmount()
            {
                Console.WriteLine("Calculation: {0}", amount * 0.10);
            }

           
        }
        class Tester
        { 
            static void Main(string[] args)
            {
                Transaction t1 = new Transaction("001", "8/10/1012", 78900.00);
                Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

                t1.showTransaction();
                t2.showTransaction();

                t1.calAmount();
                t2.calAmount();

                Console.ReadKey();
            }
        }
    }
}
