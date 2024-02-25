using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle
    {
        public Triangle(double triangleHeight, double trangleBase)
        {
            TriangleHeight = triangleHeight;
            TriangleBase = trangleBase;
        }

        public double TriangleHeight { get; set; }
        public double TriangleBase { get; set; }
        public double Area()
        {
            var triangleArea = (TriangleHeight * TriangleBase) / 2;
            return triangleArea;
        }
    }
}
