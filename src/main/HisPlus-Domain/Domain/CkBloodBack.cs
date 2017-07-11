using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkBloodBack : EntityBase<int>
    {
        public CkBloodBack()
        {    
        }

        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int BloodId { get; set; }
        public System.DateTime? BackTime { get; set; }
        public int? BackOperId { get; set; }
        public string BackReason { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
    }
}
