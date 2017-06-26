using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsStLogisticServe : EntityBase<int>
    {
        public CsStLogisticServe()
        {    
        }

        public string YearMonth { get; set; }
        public int LogisticServeId { get; set; }
        public int BenefitLocId { get; set; }
        public int ServeLocId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Money { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? InputTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
