using Models.Generics;
using System.Diagnostics.Contracts;
using Models.GenericEntities;

namespace Models.GenericEntities
{
    public class SubjectInformation 
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Professor Professor { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Contract.Requires(name != null, "name");
            Contract.Requires(credits != null, "credits");
            Contract.Requires(type != null, "type");
            Contract.Requires(activity != null, "activity");

            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, GenericEntities.Professor professor) 
            : this(name, credits, type, activity)
        {
            Contract.Requires(professor != null, "professor");

            Professor = professor;
        }

        public void SetProfessor(GenericEntities.Professor professor)
        {
            Contract.Requires(professor != null, "professor");

            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            Contract.Requires(proportion != null, "proportion");

            ActivityProportion = proportion;
        }
    }
}
