using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CsOuWorkLog : EntityBase<int>
    {
        public CsOuWorkLog()
        {    
        }

        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public int OutpNum { get; set; }
        public int OperatedNum { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? InputTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
