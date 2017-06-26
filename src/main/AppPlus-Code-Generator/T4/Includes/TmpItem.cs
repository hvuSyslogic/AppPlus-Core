using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class TmpItem : EntityBase<int>
    {
        public TmpItem()
        {    
        }

        public int? MenuId { get; set; }
        public string CKey { get; set; }
        public string CType { get; set; }
        public string Value { get; set; }
        public int? LsType { get; set; }
        public int? OperId { get; set; }
        public string TempName { get; set; }
    }
}
