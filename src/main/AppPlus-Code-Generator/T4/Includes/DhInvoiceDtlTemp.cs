using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DhInvoiceDtlTemp : EntityBase<int>
    {
        public DhInvoiceDtlTemp()
        {    
        }

        public int? HospitalId { get; set; }
        public string InvoNo { get; set; }
        public short LsInOut { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal? Price { get; set; }
        public string LimitName { get; set; }
        public int? FeeId { get; set; }
        public string FeetyName { get; set; }
        public string InvFeetyName { get; set; }
        public string AccountName { get; set; }
        public string UnitName { get; set; }
        public decimal? Totality { get; set; }
        public decimal? AmountPay { get; set; }
        public decimal? Amount { get; set; }
        public string Location1 { get; set; }
        public string Location2 { get; set; }
        public string Location3 { get; set; }
        public string DoctorName { get; set; }
        public string DocLevel { get; set; }
        public System.DateTime? RegOperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
