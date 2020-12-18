using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6Question2
{
    public class Rectangle: IShape
    {

        public Rectangle (double w, double h)
        {
            Width = w;
            Height = h;
        }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public string PrintType()
        {
            return "I am a rectangle";
        }
    }
}
