using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Triangle : Shape
    {
        private double triangleBase;
        private double triangleHeight;
        public Triangle(double b, double h)
        {
            triangleBase = b;
            triangleHeight = h;
        }

        public override double GetArea()
        {
            //0.5 * b * h
            double area = 0.5 * triangleBase * triangleHeight;

            return area;
        }

        public override string GetShapeName()
        {
            return "Triangle";
        }
    }
}
