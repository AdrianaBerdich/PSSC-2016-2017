﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    class ArgumentInvalidValue : ArgumentException
    {
        public ArgumentInvalidValue(string message)
            :base(message)
        {

        }
    }
}
