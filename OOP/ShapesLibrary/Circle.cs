using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle: Point
    {
        public double Radius { get; set; }
        public Circle(int x, int y, double radius): base(x, y)
        {
            
            Radius = radius;
        }


    }
}
