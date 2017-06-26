using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsStatu : EntityBase<int>
    {
        public CsStatu()
        {    
        }

        public string YearMonth { get; set; }
        public string WorkItem { get; set; }
        public short LsWorkStatus { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
