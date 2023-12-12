using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            //   pi * r^2
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
          
        }

        public override string GetShapeName()
        {
            return "Circle";
        }
    }
}
