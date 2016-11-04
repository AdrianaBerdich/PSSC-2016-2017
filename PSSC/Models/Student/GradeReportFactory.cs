using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;
using Models.Generics;

namespace Models.Student
{
    public class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        private GradeReportFactory()
        {

        }

        public GradeReport CreeazaGradeReport(string nume, int nota)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentNullException>(nota != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50, 
                    "Numele studeentului trebuie sa contina intre 2 si 50 de caractere.");
            Contract.Requires<ArgumentInvalidValueExceptions>(
                    nota >= 1 && nota <= 10,
                    "Nota trebuie sa fie intr 1 si 10.");

            var report = new GradeReport( 
                                        new PlainText(nume), 
                                        new Grade(nota));

            return report;
        }
    }
}
