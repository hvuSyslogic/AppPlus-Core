using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuIllReport : EntityBase<int>
    {
        public OuIllReport()
        {    
        }

        public int MzRegId { get; set; }
        public string Xml { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
