using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuInvoiceDtlA : EntityBase<System.DateTime>
    {
        public OuInvoiceDtlA()
        {    
        }

        public decimal? AmountPay { get; set; }
        public int? LimitGroupId { get; set; }
        public int? FeeHsId { get; set; }
        public int? XdRpId { get; set; }
        public short? LsReportType { get; set; }
        public int? RecipeItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? RecipeGroupId { get; set; }
        public int? DocLocId { get; set; }
    }
}
