using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.GenericEntities;
using Models.Generics;
using System.Diagnostics.Contracts;

namespace Models.Deanship
{
     //entity

    class ForStudentCalculation : Subject
    {
       

         public SubjectInformation SubjectInfo { get; internal set; }

        private Dictionary<GenericEntities.Student, SubjectSituation> _signedUpStudentsGrades;
        public Dictionary<GenericEntities.Student, SubjectSituation> SignedUpStudentsGrades { get { return _signedUpStudentsGrades; } }

        public ForStudentCalculation()
        {
            _signedUpStudentsGrades = new Dictionary<GenericEntities.Student, SubjectSituation>();
        }

        public ForStudentCalculation(Dictionary<GenericEntities.Student, SubjectSituation> signedUpStudentsGrades, SubjectInformation subjectInfo)
        {
            _signedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }

        public ForStudentCalculation(SubjectInformation subjectInfo)
            : this()
        {
            Contract.Requires(subjectInfo != null, "subjectInfo");
            SubjectInfo = subjectInfo;
        }

        public void SignUpStudent(GenericEntities.Student student)
        {
            _signedUpStudentsGrades.Add(student, new SubjectSituation());
        }



        public SubjectSituation GetSituationForStudent(RegistrationNumber regNumber)
        {
            return _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }

        internal Situation GetStudentSituation(RegistrationNumber regNr)
        {
            throw new NotImplementedException();
        }
    }
}
