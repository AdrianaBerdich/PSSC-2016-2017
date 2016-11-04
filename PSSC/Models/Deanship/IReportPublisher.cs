using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using Models.GenericEntities;

namespace Models.Deanship
{
    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(List<GenericEntities.Student> students);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
