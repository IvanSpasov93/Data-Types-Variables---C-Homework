using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a new C# project and create a program that assigns floating point values to 
//variables. Be sure that each value is stored in the correct variable type (try to find the 
//most suitable variable type in order to save memory). 
//Finally, you need to print all variables to the console.

namespace _02.FloatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 1.1234567f;
            double num2 = 1.123456789d;
            decimal num3 = 2.123456789101112m;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
