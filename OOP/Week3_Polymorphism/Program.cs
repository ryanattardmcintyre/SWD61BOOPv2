using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5, 5, 10);

            Cylinder cyl = new Cylinder(5, 5, 10, 20);
            Console.WriteLine($"Cylinder area: {cyl.FindArea()}");
            Console.WriteLine($"Circle area: {c.FindArea()}");

            Console.ReadKey();



        }
    }
}
