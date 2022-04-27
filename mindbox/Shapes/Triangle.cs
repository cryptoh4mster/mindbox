using System;
using System.Collections.Generic;
using System.Text;
using Figures.Exceptions;

namespace Figures
{
    public class Triangle : Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new IncorrectValueException();

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new IncorrectTriangleSidesValuesException();

            _a = a;
            _b = b;
            _c = c;
        }
        public override double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
        public bool IsRightTriangle()
        {
            return Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2);
        }
    }
}
