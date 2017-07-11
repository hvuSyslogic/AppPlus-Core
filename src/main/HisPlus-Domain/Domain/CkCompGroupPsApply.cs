using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkCompGroupPsApply : EntityBase<int>
    {
        public CkCompGroupPsApply()
        {    
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public short XType { get; set; }
        public bool IsPre { get; set; }
        public int? ItemId { get; set; }
        public string ApplyMemo { get; set; }
        public string Summary { get; set; }
        public string Diagnose { get; set; }
        public int? CompGroupId { get; set; }
    }
}
