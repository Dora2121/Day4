using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping2numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5, b = 6;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=30 (5*6)      
            b = a / b; //b=5 (30/6)      
            a = a / b; //a=6 (30/5)    
            Console.Write("After swap a= " + a + " b= " + b);


                
                
             



          
        }


        }
    }

