using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CsCostClassRela : EntityBase<int>
    {
        public CsCostClassRela()
        {    
        }

        public int? ClassId { get; set; }
        public int? CostSubjId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
