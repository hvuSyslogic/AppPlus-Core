using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InEmrChange : EntityBase<int>
    {
        public InEmrChange()
        {    
        }

        public int? EmrId { get; set; }
        public byte[] Content { get; set; }
        public string Modified { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public int? IsUse { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
