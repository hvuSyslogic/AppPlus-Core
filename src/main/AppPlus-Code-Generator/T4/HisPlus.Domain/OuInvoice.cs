using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuInvoice : EntityBase<int>
    {
        public OuInvoice()
        {    
        }

        public string InvoNo { get; set; }
        public int MzRegId { get; set; }
        public int PatId { get; set; }
        public System.DateTime InvoTime { get; set; }
        public decimal Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal Insurance { get; set; }
        public decimal PaySelf { get; set; }
        public decimal AmountPay { get; set; }
        public decimal AddFee { get; set; }
        public string TallyNo { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
        public int? CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public int? InvoLastId { get; set; }
        public System.DateTime? TallyTime { get; set; }
        public System.DateTime? CancelTallyTime { get; set; }
        public decimal? ReAmount { get; set; }
        public System.DateTime? ReAmountDate { get; set; }
        public string ReAmountMemo { get; set; }
        public int? PatTypeId { get; set; }
        public int? HospitalId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public System.DateTime? CancelCheckTime { get; set; }
        public int? DocLocId { get; set; }
        public int? CancelHospital { get; set; }
    }
}
