using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics;
using Models.Generics.Exceptions;

namespace Models.Professor
{
    public class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();

        private SubjectsFactory()
        {

        }

        //public Subjects CreeazaDisciplina(string nume)
        //{
        //    Contract.Requires<ArgumentNullException>(nume != null, "text");
        //    Contract.Requires<ArgumentInvalidLengthException>(
        //            nume.Length >= 2 && nume.Length <= 50, 
        //            "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");
            
        // //   var disciplina = new Subjects();
            
        //   // return disciplina;
        //}
    }
}
