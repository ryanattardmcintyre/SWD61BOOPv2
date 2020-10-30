using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{

    //Static Polymorphism is when you overload the constructor/ methods
    //Dynamic Polymorphism 
    //  1. when you declare a method and allow the inherited class to change the method's implementation
    //  2. the ability to choose the proper method of the created instance

    public class Point
    {
        //constructor main role is to internally opens a memory space inside your RAM and it gives a name
        // once that memory location is open then you can start storing/reading values
        public Point()
        {
            X = 0;
            Y = 0;
        
        }
        

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

   

        public int X { get; set; }
        public int Y { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Drawing a point");
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a point at {x}, {y}");
        }

        
    }
}
