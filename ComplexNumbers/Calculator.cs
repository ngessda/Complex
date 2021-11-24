using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    static class Calculator
    {
        public static ComplexNumbers Addition(ComplexNumbers a, ComplexNumbers b)
        {
            return a + b;
        }
        public static ComplexNumbers Subtraction(ComplexNumbers a, ComplexNumbers b)
        {
            return a - b;
        }
        public static ComplexNumbers Division(ComplexNumbers a, ComplexNumbers b)
        {
            return a / b;
        }
        public static ComplexNumbers Multiplication(ComplexNumbers a, ComplexNumbers b)
        {
            return a * b;
        }
    }
}
