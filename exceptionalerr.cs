using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class exceptionalerr
    {

        static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Divide Program. You Enter 2 number and we return result");
                Console.WriteLine("Enter 1st Numbers: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Divide :" + result.ToString());
                Console.ReadLine();
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("You have Entered o");
            }
            //Parent Exception Catch all type of exception
            catch (FormatException fex)
            {
                Console.WriteLine("Invalid Input");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other Exception raised");
            }
            //finally block: it always executes
            finally
            {
                Console.WriteLine("Finally Block: For continue press enter and for exit press ctrl +c");
                Console.ReadLine();
            }
        }
    
}
}
