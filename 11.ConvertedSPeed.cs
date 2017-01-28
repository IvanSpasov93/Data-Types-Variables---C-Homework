using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program to ask the user for a distance(in meters) and the time
//taken(as three numbers: hours, minutes, seconds), and print the speed, in meters
//per second, kilometers per hour and miles per hour.
//Assume 1 mile = 1609 meters.


namespace _11.ConverSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in meters:");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("hours");
            float hours = float.Parse(Console.ReadLine());
            Console.WriteLine("minutes");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("seconds");
            float seconds = float.Parse(Console.ReadLine());
            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float kmSpeed = (distance / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distance / 1609.0f) / hourTime;

            Console.WriteLine("{0}", metersSpeed);
            Console.WriteLine("{0}", kmSpeed);
            Console.WriteLine("{0}", milesSpeed);
        }
    }
}
