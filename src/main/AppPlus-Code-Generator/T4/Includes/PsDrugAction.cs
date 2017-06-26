using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class PsDrugAction : EntityBase<int>
    {
        public PsDrugAction()
        {    
        }

        public string ApplyNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public int PatId { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public int? ItemId { get; set; }
        public System.DateTime? ReactTime { get; set; }
        public short? LsTransType { get; set; }
        public string ClincHandle { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
