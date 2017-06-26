using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InLocNoPay : EntityBase<int>
    {
        public InLocNoPay()
        {    
        }

        public System.DateTime ReportDate { get; set; }
        public int LocationId { get; set; }
        public int ExecLocId { get; set; }
        public int FeeId { get; set; }
        public short LsInStatus { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Opertime { get; set; }
    }
}
