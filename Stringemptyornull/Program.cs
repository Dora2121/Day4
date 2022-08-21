using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Stringemptyornull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("String is either null or empty");
            }
        }
    }
}
