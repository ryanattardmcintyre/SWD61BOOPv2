using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) ->> object is when you create a space in memory and you start assigning values to the template you created earlier
            Circle c = new Circle(5, "black"); //e.g. of an object --> c


            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}, Perimeter is {Math.Round(c.GetPerimeter(), 2)}");
            //Console.WriteLine(String.Format("Area is {0}, Perimeter is {1}", c.GetArea(), c.GetPerimeter()));


            Console.WriteLine("Press a key to terminate");
            Console.ReadKey();

        }
    }
}
