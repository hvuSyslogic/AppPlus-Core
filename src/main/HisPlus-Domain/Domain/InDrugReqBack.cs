using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InDrugReqBack : EntityBase<int>
    {
        public InDrugReqBack()
        {    
        }

        public int ReqDtlId { get; set; }
        public short ListNum { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsBack { get; set; }
        public int? DetailId { get; set; }
        public System.DateTime? BackTime { get; set; }
        public int? AdviceId { get; set; }
        public short? LsMarkType { get; set; }
        public bool? IsPrint { get; set; }
        public int? HospId { get; set; }
        public int? RequestId { get; set; }
        public string Memo { get; set; }
        public int? BackOperId { get; set; }
    }
}
