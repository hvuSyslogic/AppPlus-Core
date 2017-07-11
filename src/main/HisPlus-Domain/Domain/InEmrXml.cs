using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InEmrXml : EntityBase<int>
    {
        public InEmrXml()
        {    
        }

        public int HospId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public string XmlValue { get; set; }
        public int? InEmrId { get; set; }
    }
}
