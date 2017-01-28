using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Georgi";
            string lastName = "Peev";
            sbyte age = 30;
            char geneder = 'm';
            long idNumber = 8306112507;
            int empNumber = 27569989;

            Console.WriteLine("Employee Data:");
            Console.WriteLine("{0} {1}, {2}, {3}, {4}, {5}", firstName, lastName, age, geneder, idNumber, empNumber);
        }
    }
}
