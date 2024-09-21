
using System;
namespace ParameterizedConstructorExample
{

    class Contact
    {

        
        String brand;
        long mobno;

        
        Contact(String name, long mobno)
        {
            this.brand = name;
            this.mobno = mobno;
        }
        public Contact()
        {
            Console.WriteLine("Enter Mobile No");
            mobno = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Name");
            brand = Console.ReadLine();
        }

        ~Contact()
        {
            Console.WriteLine("Destructor is called");
        }


        public static void Main()
        {

            
            Contact contact = new Contact();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Brand Name = " + contact.brand);
            Console.WriteLine("Mobile Number = " + contact.mobno);
        }
    }
}
