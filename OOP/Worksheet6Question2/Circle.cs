using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6Question2
{
    public class Circle : IShape
    {
        public Circle(double r)
        { Radius = r; }

        public double Radius { get; set; }


        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public string PrintType()
        {
            return "I am a circle";
        }
    }
}
