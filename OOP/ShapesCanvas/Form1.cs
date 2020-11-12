using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;
using MyRectangle = ShapesLibrary.Rectangle;

namespace ShapesCanvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            

            Shape drawingShape = null;

            switch(cmbShapes.Text.Trim())
            {
                case "Circle":
                    if (txtRadius.Text == string.Empty)
                    {
                        MessageBox.Show("Please input radius");
                    }
                    else
                    {
                        drawingShape = new Circle(e.X, e.Y, Convert.ToDouble(txtRadius.Text), ShapesBorderColor);
                    }
                    break;

                case "Square":
                    if (txtLength.Text == string.Empty)
                    {
                        MessageBox.Show("Please input length");
                    }
                    else
                    {
                        drawingShape = new Square(e.X, e.Y, Convert.ToDouble(txtLength.Text));
                    }
                    break;

                case "Rectangle":

                    drawingShape = new MyRectangle(e.X, e.Y, Convert.ToDouble(txtLength.Text), Convert.ToDouble(txtLength.Text));
                    break;

                default:

                    break;
            }

            if (drawingShape != null)
            {
                drawingShape.Draw(pnlCanvas.CreateGraphics());
            }
        }

        public Color ShapesBorderColor { get; set; }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ShapesBorderColor = colorDialog1.Color;
            }
        }
    }
}
