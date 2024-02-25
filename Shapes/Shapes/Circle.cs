using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double Area()
        {
            var pi = Math.PI;
            var circleArea = pi * (Radius * Radius);
            return circleArea;
        }
    }
}
