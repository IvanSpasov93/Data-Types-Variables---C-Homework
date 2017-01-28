using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string, converts it to Boolean variable and prints “Yes” 
//if the variable is true and “No” if the variable is false.

namespace _05.Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            bool converted = Convert.ToBoolean(string1);

            if(string1 == "true")
            {
                Console.WriteLine("Yes");
            }
            else if(string1 == "false")
            {
                Console.WriteLine("No");
            }

        }
    }
}
