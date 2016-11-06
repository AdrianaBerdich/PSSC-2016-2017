using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.GenericEntities;
using Models.Generics;

namespace Models.Student
{
    //entity

    public class RegisterSubjects : Subject
    {
        public GenericEntities.Professor Professor { get; set; }
        public Situation Situation { get; set; }

        public RegisterSubjects(Situation situation, GenericEntities.Professor professor, PlainText subjectName, Credits credits)
            : base(subjectName, credits)
        {
            Situation = situation;
            Professor = professor;
        }
    }
}
