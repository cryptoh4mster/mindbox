using System;
using System.Collections.Generic;
using System.Text;
using Figures.Exceptions;

namespace Figures
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new IncorrectValueException();

            _radius = radius;
        }
        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
