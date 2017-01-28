using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.

namespace _04.HexaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal number code:");
            string hexa = Console.ReadLine();
            int converted = Convert.ToInt32(hexa, 16);

            Console.WriteLine(converted);
        }
    }
}
