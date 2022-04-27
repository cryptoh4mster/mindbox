using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    /// <summary>
    /// Exception при одном из значений фигуры меньше либо равной нулю
    /// </summary>
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException() : base ("Одно из значений меньше либо равно нулю")
        {

        }
    }
}
