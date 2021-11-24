using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class ComplexZeroException : DivideByZeroException
    {
        public ComplexZeroException() 
            :base()
        {

        }
    }
}
