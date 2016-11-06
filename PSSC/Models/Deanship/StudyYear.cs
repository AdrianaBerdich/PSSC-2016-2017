using Models.Generics;
using Models.GenericEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Deanship
{
    //Aggregate Root 
         
    public class StudyYear
    {
        private List<ForStudentCalculation> _definedSubjects;
        public ReadOnlyCollection<ForStudentCalculation> Subjects { get { return _definedSubjects.AsReadOnly(); } }

        public StudyYear()
        {

        }

        public StudyYear(List<ForStudentCalculation> definedSubjects)
        {
            Contract.Requires(definedSubjects != null, "definedSubjects");

            _definedSubjects = definedSubjects;
        }

        public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(credits != null, "credits");
            Contract.Requires(type != null, "type");
            Contract.Requires(activity != null, "activity");

            _definedSubjects.Add(new ForStudentCalculation(new SubjectInformation(name, credits, type, activity)));
        }
        
        public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity, GenericEntities.Professor professor)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(credits != null, "credits");
            Contract.Requires(type != null, "type");
            Contract.Requires(activity != null, "activity");
            Contract.Requires(professor != null, "professor");

            _definedSubjects.Add(new ForStudentCalculation(new SubjectInformation(name, credits, type, activity)));
        }

        public void SignUpStudentToSubject(PlainText subjectName, GenericEntities.Student student)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(student != null, "student");

            _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).SignUpStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            Contract.Requires(subjectName != null, "subjectName");
            Contract.Requires(regNumber != null, "regNumber");

            return _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).GetAverageForStudent(regNumber);
        }

        public void PublishGradeReports(IReportPublisher publisher)
        {

        }


        public Situation GetStudSituation(PlainText subject, RegistrationNumber regNr)
        {
            return _definedSubjects.Find(d => d.Name == subject).GetStudentSituation(regNr);
        }




        public PlainText name { get; set; }
    }
}
