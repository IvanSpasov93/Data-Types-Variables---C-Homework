using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program to convert a decimal number to hexadecimal and binary number and print it.

namespace _14.IntegerToHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            string toHexa = Convert.ToString(n, 16).ToUpper();
            string toBinary = Convert.ToString(n, 2).ToUpper();
            Console.WriteLine("Hexadecimal version: " + toHexa);
            Console.WriteLine("Binary version: " + toBinary);
        }
    }
}
