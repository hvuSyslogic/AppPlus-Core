using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InEmrRtf : EntityBase<int>
    {
        public InEmrRtf()
        {    
        }

        public int HospId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int CatalogId { get; set; }
        public string Rtf { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
