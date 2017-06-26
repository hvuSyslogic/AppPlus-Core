using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OulInvoiceReg : EntityBase<int>
    {
        public OulInvoiceReg()
        {    
        }

        public string InvoNo { get; set; }
        public int MzRegId { get; set; }
        public System.DateTime InvoTime { get; set; }
        public decimal RegFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public int? InvoLastId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? HospitalId { get; set; }
        public int? RegTypeId { get; set; }
        public int? DoctorId { get; set; }
        public int? PatTypeId { get; set; }
        public int? LocationId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public System.DateTime? CancelCheckTime { get; set; }
        public int? DocLocId { get; set; }
        public string OrderWxid { get; set; }
    }
}
