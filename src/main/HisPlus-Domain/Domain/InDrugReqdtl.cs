using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InDrugReqdtl : EntityBase<int>
    {
        public InDrugReqdtl()
        {    
        }

        public int RequestId { get; set; }
        public int ListNum { get; set; }
        public int HospId { get; set; }
        public System.DateTime ForDate { get; set; }
        public int ItemId { get; set; }
        public int AdviceId { get; set; }
        public short GroupNum { get; set; }
        public short LsMarkType { get; set; }
        public decimal? Dosage { get; set; }
        public int UnitReq { get; set; }
        public int? UnitTake { get; set; }
        public decimal Totality { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public bool IsPrint { get; set; }
        public bool IsIssued { get; set; }
        public bool IsConfirm { get; set; }
        public int? ConfirmOperId { get; set; }
        public System.DateTime? ConfirmOperTime { get; set; }
        public int? DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ExecuteId { get; set; }
        public string RegDate { get; set; }
        public int? LsSecMarkType { get; set; }
        public string BedName { get; set; }
        public bool? Refusal { get; set; }
        public bool? IsArrearage { get; set; }
        public int? DoctorId { get; set; }
        public int? OperId { get; set; }
        public decimal? PriceIn { get; set; }
        public bool? LsArrearage { get; set; }
    }
}
