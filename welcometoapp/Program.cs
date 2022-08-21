using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcometoapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            String LastName = Console.ReadLine();

            Console.WriteLine("Welcome to App {0} {1}", FirstName, LastName);
            Console.WriteLine(  "Successfully login");
            
        }
    }
}
