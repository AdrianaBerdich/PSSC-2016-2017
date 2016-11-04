using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            Contract.Requires<ArgumentException>(value > 0, "value");
            Contract.Requires<ArgumentException>(value <= 10, "value");
            
            _value = value;
        }
    }
}
