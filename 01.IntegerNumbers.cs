using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a new C# project and create a program that assigns integer values to variables. Be sure 
//that each value is stored in the correct variable type (try to find the most suitable variable
//type in order to save memory). 
//Finally, you need to print all variables to the console.

class Program
{
    static void Main()
    {
        byte num1 = 128;
        sbyte num2 = -100;
        int num3 = 1323234;

        Console.WriteLine(num1 + " " + num2 + " " + num3);
    }
}

