using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class ComplexNumbers
    {
        private const double EPS = 0.000000001;
        private double re;
        private double im;
        public ComplexNumbers Conj
        {
            get
            {
                ComplexNumbers c = new ComplexNumbers();
                c.re = re;
                c.im = -im;
                return c;
            }
        }

        public ComplexNumbers()
        {
            re = 0;
            im = 0;
        }
        public ComplexNumbers(double re1, double im1)
        {
            re = re1;
            im = im1;
        }
        public static ComplexNumbers operator+(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = a.re - b.re;
            c.im = a.im - b.im;
            return c;
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = (a.re * b.re) - (a.im * b.im);
            c.im = (a.re * b.im) + (a.im * b.re);
            return c;
        }
        public static ComplexNumbers operator /(ComplexNumbers a, ComplexNumbers b)
        {
            try
            {
                if(a.re == 0 || a.im == 0 || b.re == 0 || b.im == 0)
                {
                    throw new ComplexZeroException();
                }
            }
            catch(ComplexZeroException ex)
            {
                throw ex;
            }
            ComplexNumbers c = new ComplexNumbers();
            c.re = ((a.re * b.re) + (a.im * b.im)) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2));
            c.im = ((a.im * b.re) - (a.re * b.im)) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2));
            return c;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Math.Abs(re) >= EPS)
            {
                if (Math.Abs(im) > EPS)
                {
                    sb.Append($"{re} + i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"{re} - i * {-im}");
                }
            }
            else if (Math.Abs(re) < EPS)
            {
                if (Math.Abs(im) > EPS)
                {
                    sb.Append($" i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"- i * {-im}");
                }
            }
            return sb.ToString();
        }
    }
}
