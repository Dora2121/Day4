using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("Enter value for i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j");
            j = Convert.ToInt32(Console.ReadLine());
            k = i - j;
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
