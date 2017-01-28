using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program to calculate rectangle’s perimeter, area and 
//diagonal by given its width and height.

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("height:");
            float height = int.Parse(Console.ReadLine());
            Console.WriteLine("width:");
            float width = int.Parse(Console.ReadLine());

            float perimeter = 2 * height + 2 * width;
            float area = width * height;
            double diagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine("Perimeter: "+ perimeter);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Diagonal: " + diagonal);

        }
    }
}
