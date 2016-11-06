using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Generics
{
    //value object for Proportion

    public class Proportion
    {
        private int _numerator;
        private int _denominator;
        public decimal Fraction { get { return _numerator / _denominator; } }

        public Proportion(int numerator, int denominator)
        {
            Contract.Requires<ArgumentException>(numerator > 0, "numarator");
            Contract.Requires<ArgumentException>(denominator > 0, "numitor");
            Contract.Requires<ArgumentException>(numerator < denominator, "nu este subunitar");
           
            _numerator = numerator;
            _denominator = denominator;
        }
    }
}
