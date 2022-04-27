using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    public class IncorrectTriangleSidesValuesException : Exception
    {
        public IncorrectTriangleSidesValuesException() : base("Треугольника с данными сторонами не существует")
        {

        }
    }
}
