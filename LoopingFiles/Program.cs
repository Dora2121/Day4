using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter x value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("The number is maximum ");
            }
            else
            {
                Console.WriteLine("The number is minimum");
            }
            Console.ReadLine();
        }
    }
}
