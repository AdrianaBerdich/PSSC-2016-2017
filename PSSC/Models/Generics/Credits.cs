using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;


namespace Models.Generics
{
    public class Credits
    {
        private const int _maxCredits = 60;
        public static int MAX { get { return _maxCredits; } }

        private int _credits;
        public int Count { get { return _credits; } set { _credits = value; } }

        public Credits()
        {
        }

        public Credits(int credits)
        {
            //Contract.Requires<InvalidCreditsValue>(credits!=60, "text");
            //Contract.Requires<ArgumentException>(credits > 60, "maxim 60 de credite");
            Contract.Requires<ArgumentNullException>(credits != null, "text");
            

            _credits = credits;
        }
    }
}
