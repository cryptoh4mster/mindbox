using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    /// <summary>
    /// Exception при несуществующем с введенными сторонами треугольнике
    /// </summary>
    public class IncorrectTriangleSidesValuesException : Exception
    {
        public IncorrectTriangleSidesValuesException() : base("Треугольника с данными сторонами не существует")
        {

        }
    }
}
