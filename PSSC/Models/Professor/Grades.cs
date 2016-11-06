using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.GenericEntities;
using Models.Generics;


namespace Models.Professor
{
     //entity witch create list of grades

    public class Grades : SubjectSituation
    {
        public Attendance Attendance { get { return Attendance; } set { Attendance = value; } }
        public List<Grade> ExamGrades { get { return ExamGrades; } set { ExamGrades = value; } }
        public List<Grade> ActivityGrades { get { return ActivityGrades; } set { ActivityGrades = value; } }

        public Grades(Attendance att, List<Grade> examGrades, List<Grade> activityGrades)
            : base(att, examGrades, activityGrades)
        {

        }
    }
}
