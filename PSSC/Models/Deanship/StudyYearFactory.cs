using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics;
using Models.Generics.Exceptions;
using Models.GenericEntities;

namespace Models.Deanship
{
    class StudyYearFactory
    {
        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        {

        }

        public StudyYear CreeazaDisciplina(string nume, int credits, string activity, string type)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");

            var disciplina = new StudyYear();

            return disciplina;
        }
    }
}
