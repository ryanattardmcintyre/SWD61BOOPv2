using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Square: Point
    {

        public double Length { get; set; }

        public Square(int x, int y, double length): base(x, y)
        {
            Length = length;
        
        }
    }
}
