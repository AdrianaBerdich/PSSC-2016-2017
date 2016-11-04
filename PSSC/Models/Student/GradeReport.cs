using Models.Generics;
using Models.GenericEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Aggregate Root
    public class GradeReport
    {
        private ReadOnlyCollection<RegisterSubjects> _gradeReport;
        private PlainText plainText;
        private Grade grade;

        public GradeReport(ReadOnlyCollection<RegisterSubjects> gradeReport)
        {
            _gradeReport = gradeReport;
        }

        public GradeReport(PlainText plainText, Grade grade)
        {
            // TODO: Complete member initialization
            this.plainText = plainText;
            this.grade = grade;
        }

        public Situation GetSubjectSituation(PlainText name)
        {
            return _gradeReport.First(d => d.Name == name).Situation; 
        }
    }
}