using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.GenericEntities
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Student(RegistrationNumber regNumber, PlainText name)
        {
            Contract.Requires(regNumber != null, "registration number");
            Contract.Requires(name != null, "name");

            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(regNumber, name)
        {
            Contract.Requires(credits != null, "credits");
            Credits = credits;
        }
    }
}
