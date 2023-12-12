using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Rectangle : Shape
    {
        private double length;
        private double height;

        public Rectangle(double l, double h)
        {
            length = l;
            height = h;
        }
        public override double GetArea()
        {
            //  l * h

            double area = length * height;
            return area;
        }

        public override string GetShapeName()
        {
            return "Rectangle"; 
        }
    }
}
