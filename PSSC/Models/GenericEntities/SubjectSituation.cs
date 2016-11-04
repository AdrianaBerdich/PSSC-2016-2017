using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.GenericEntities
{
    public class SubjectSituation
    {
        public Attendance Attendance { get; internal set; }
        public List<Grade> ExamGrades { get; internal set; }
        public List<Grade> ActivityGrade { get; internal set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(Attendance attendance, List<Grade> examGrades, List<Grade> activityGrade)
        {
            Contract.Requires(attendance != null, "attendance");
            Contract.Requires(examGrades != null, "lista note examen");
            Contract.Requires(activityGrade != null, "activityGrade");

            Attendance = attendance;
            ExamGrades = examGrades;
            ActivityGrade = activityGrade;
        }

        public void AddExamGrade(Grade examGrade)
        {
            Contract.Requires(examGrade != null, "examGrade");

            ExamGrades.Add(examGrade);
        }

        public void AddActivityGrade(Grade activityGrade)
        {
            Contract.Requires(activityGrade != null, "activityGrade");

            ActivityGrade.Add(activityGrade);
        }

        public void AddAttendance(Attendance attendance)
        {
            Contract.Requires(attendance != null, "attendance");

            Attendance = attendance;
        }

        public decimal GetExamAverage(EvaluationType type)
        {
            Grade average;

            if(type.Equals(EvaluationType.Distributed))
            {
                average = new Grade((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
            } else
            {
                average = new Grade(ExamGrades[0].Value);
            }

            return average.Value;
        }
    }
}
