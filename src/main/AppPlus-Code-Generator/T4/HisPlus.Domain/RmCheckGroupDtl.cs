using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmCheckGroupDtl : EntityBase<int>
    {
        public RmCheckGroupDtl()
        {    
        }

        public int CheckId { get; set; }
        public int GroupId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public decimal CheckNum { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
