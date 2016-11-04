using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.GenericEntities
{
    //Entity
    public class Subject
    {
        public SubjectInformation InfoSubject { get; set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public SubjectInformation SubjectInfo { get; internal set; }

        private Dictionary<Student, SubjectSituation> _signedUpStudentsGrades;
        public Dictionary<Student, SubjectSituation> SignedUpStudentsGrades { get { return _signedUpStudentsGrades; } }


        public Subject(PlainText name, Credits credits)
        {
            Name = name;
            Credits = credits;
        }

        public Subject()
        {
            _signedUpStudentsGrades = new Dictionary<Student, SubjectSituation>();
        }

        public Subject(Dictionary<Student, SubjectSituation> signedUpStudentsGrades, SubjectInformation subjectInfo)
        {
            _signedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }

        public Subject(SubjectInformation subjectInfo) 
        {
            Contract.Requires(subjectInfo != null, "subjectInfo");
            SubjectInfo = subjectInfo;
        }

        public void SignUpStudent(Student student)
        {
            _signedUpStudentsGrades.Add(student, new SubjectSituation());
        }

        public Grade GetAverageForStudent(RegistrationNumber regNumber)
        {
            SubjectSituation situation = _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;

            decimal activityGrade = situation.ActivityGrade.Count;
            decimal examAverage = situation.GetExamAverage(SubjectInfo.Evaluation);
            decimal proportion = SubjectInfo.ActivityProportion.Fraction;

            return new Grade(activityGrade * proportion + (1 - proportion) * examAverage);
        }

        public SubjectSituation GetSituationForStudent(RegistrationNumber regNumber)
        {
            return _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }
    }
}
