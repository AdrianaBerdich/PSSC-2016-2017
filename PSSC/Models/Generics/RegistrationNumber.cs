using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Generics
{
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires<ArgumentNullException>(number != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(number), "text");
            Contract.Requires<ArgumentException>(number.Length == 7, "Registration Number have 7 characters");
           
            _number = number;
        }
    }
}
