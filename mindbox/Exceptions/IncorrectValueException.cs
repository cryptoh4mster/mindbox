using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException() : base ("Одно из значений меньше либо равно нулю")
        {

        }
    }
}
