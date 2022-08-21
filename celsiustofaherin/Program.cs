using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiustofaherin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            Console.WriteLine("Enter the celsius");
            double celsius =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}
