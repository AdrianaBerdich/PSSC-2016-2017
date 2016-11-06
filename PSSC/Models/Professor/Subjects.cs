using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.GenericEntities;

namespace Models.Professor
{
    //Aggregate Root  
    
    public class Subjects
    {
        private List<GenericEntities.Subject> _subjects;
        public ReadOnlyCollection<GenericEntities.Subject> AllSubjects { get { return _subjects.AsReadOnly(); } }

        public Subjects(List<GenericEntities.Subject> subjects)
        {
            Contract.Requires(subjects != null, "subjects");

            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(regNumber != null, "regNumber");
            Contract.Requires(grade != null, "grade");

            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddExamGrade(grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(regNumber != null, "regNumber");
            Contract.Requires(grade != null, "grade");

            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddActivityGrade(grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(regNumber != null, "regNumber");
            Contract.Requires(attendance != null, "attendance");

            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddAttendance(attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(proportion != null, "proportion");
            
            _subjects.Find(d => d.SubjectInfo.Name == subjectName).SubjectInfo.SetActivityProportion(proportion);
        }

        public void ModifyExamGrade(RegistrationNumber regNumber, Grade grade)
        {
            //Edit
        }
    }
}
