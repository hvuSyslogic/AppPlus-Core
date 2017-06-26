using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkBldFree : EntityBase<int>
    {
        public CkBldFree()
        {    
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public string TransType { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
