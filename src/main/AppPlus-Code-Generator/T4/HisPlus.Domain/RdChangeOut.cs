using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RdChangeOut : EntityBase<int>
    {
        public RdChangeOut()
        {    
        }

        public int PatId { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public System.DateTime? ChangeTime { get; set; }
        public string Reason { get; set; }
        public string ToHospital { get; set; }
        public System.DateTime? BackTime { get; set; }
        public string BackDiagnose { get; set; }
        public string Disposal { get; set; }
        public string Memo { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
