using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsLogisticServeDetail : EntityBase<int>
    {
        public CsLogisticServeDetail()
        {    
        }

        public System.DateTime ServeDate { get; set; }
        public string Abstract { get; set; }
        public int LogisticServeId { get; set; }
        public int BenefitLocId { get; set; }
        public int ServeLocId { get; set; }
        public decimal? Totality { get; set; }
        public decimal? Equivalent { get; set; }
        public string ServeNo { get; set; }
        public int? OperId { get; set; }
        public bool? IsAcctMark { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
