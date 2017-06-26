using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsDeptIncome : EntityBase<int>
    {
        public CsDeptIncome()
        {    
        }

        public string YearMonth { get; set; }
        public int? FeeHsId { get; set; }
        public int OperLocId { get; set; }
        public int ExcLocId { get; set; }
        public decimal Amount { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string Abstract { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
