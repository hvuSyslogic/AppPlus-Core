using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InInvoiceDtlA : EntityBase<System.DateTime>
    {
        public InInvoiceDtlA()
        {    
        }

        public int? InvoId { get; set; }
        public int? LimitGroupId { get; set; }
        public decimal? LimitFee { get; set; }
        public int? FeeHsId { get; set; }
        public int? LsReportType { get; set; }
        public string Memo { get; set; }
        public int? CancelId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string HostName { get; set; }
        public int? ExecuteId { get; set; }
        public string RegDate { get; set; }
        public int? GroupItemId { get; set; }
        public int? XdRpId { get; set; }
        public string AdviceName { get; set; }
        public int? MainDoctorId { get; set; }
    }
}
