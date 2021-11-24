using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    static class Calculator
    {
        static private double re1 = Convert.ToDouble(Console.ReadLine());
        static private double re2 = Convert.ToDouble(Console.ReadLine());
        static private double im1 = Convert.ToDouble(Console.ReadLine());
        static private double im2 = Convert.ToDouble(Console.ReadLine());
        static ComplexNumbers a = new ComplexNumbers(re1, im1);
        static ComplexNumbers b = new ComplexNumbers(re2, im2);
        public static void Addition()
        {
            Console.WriteLine(a + b);
        }
        public static void Subtraction()
        {
            Console.WriteLine(a - b);
        }
        public static void Division()
        {
            Console.WriteLine(a / b);
        }
        public static void Multiplication()
        {
            Console.WriteLine(a * b);
        }
    }
}
