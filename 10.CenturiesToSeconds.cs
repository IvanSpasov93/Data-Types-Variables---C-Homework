using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write program to enter an integer number of centuries and
//convert it to years, days, hours, minutes, seconds

namespace _10.CenturesToNanoseconds
{
    class CenturiesToSeconds
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter centuries:");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = years * 365;
            int hours = days * 24;
            int sec = hours * 60;

            Console.WriteLine(sec + " seconds.");

        }
    }
}
