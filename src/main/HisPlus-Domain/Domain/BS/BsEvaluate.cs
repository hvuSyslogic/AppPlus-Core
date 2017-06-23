using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'BsEvaluate' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsEvaluate
    {
        public BsEvaluate()
        {    
        }

        public string EvaluateName { get; set; }
        public string Py { get; set; }
        public string Name { get; set; }
    }
}
