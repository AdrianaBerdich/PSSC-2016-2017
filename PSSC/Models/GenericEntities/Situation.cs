using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Models.Generics;
using Models.GenericEntities;


namespace Models.GenericEntities
{
    public class Situation : SubjectSituation
    {
        
        public int Attendance { get { return Attendance; } }
        public ReadOnlyCollection<Grade> ExamGrades { get { return ExamGrades; } }
        public ReadOnlyCollection<Grade> ActivityGrades { get { return ActivityGrades; } }

        public Situation(Attendance att, List<Grade> examGrades, List<Grade> activityGrades) 
            : base(att, examGrades, activityGrades)
        {

        }

        public Situation()
        {

        }
    }
}
