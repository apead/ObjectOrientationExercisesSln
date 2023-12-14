using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            double area= side * side;

            return area;
        }

        public override string GetShapeName()
        {
            return "Square";
        }
    }
}
