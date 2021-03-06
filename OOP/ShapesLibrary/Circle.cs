﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle(int x, int y, double radius): base(x, y)
        {
            Radius = radius;
        }

        public Circle(int x, int y, double radius, Color borderColor): this(x, y, radius)
        {
            BorderColor = borderColor;

        }

        public override double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double FindArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw(Graphics g)
        {  
            g.DrawEllipse(new Pen(BorderColor),  X,  Y, (float)  (Radius * 2), (float) (Radius * 2));
        }
    }
}
