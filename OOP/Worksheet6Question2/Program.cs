using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] myShapes = new IShape[2];

            myShapes[0] = new Circle(10);
            myShapes[1] = new Rectangle(10, 20);

            foreach (IShape item in myShapes)
            {
                Console.WriteLine($"type : {item.PrintType()}");
                Console.WriteLine($"area : {item.Area()}");
                Console.WriteLine();

            }


            Console.ReadLine();
        }
    }
}
