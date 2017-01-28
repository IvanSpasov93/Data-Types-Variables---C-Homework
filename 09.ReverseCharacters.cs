using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to ask the user for 3 letters and print them in reversed order.

namespace _09.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine()); //input of single char;

            Console.WriteLine();
            Console.WriteLine(c + " " + b + " " + a);
        }
    }
}
