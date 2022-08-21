using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(  "Enter a,b,c,d values\n");
           int a = Convert.ToInt32(Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());
           int c= Convert.ToInt32(Console.ReadLine());
           int d = Convert.ToInt32(Console.ReadLine());

            var avg = (a + b + c + d) / 4;
            Console.WriteLine("average of four is"+avg);
            Console.ReadLine();


        }
    }
}
