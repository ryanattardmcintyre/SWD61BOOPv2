using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Rectangle: Square
    {
        public double Width { get; set; }

        public Rectangle(int x, int y, double length, double width)
            :base(x, y, length)
        {
            Width = width;
        }
    }
}
