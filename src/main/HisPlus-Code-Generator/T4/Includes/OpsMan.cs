using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OpsMan : EntityBase<int>
    {
        public OpsMan()
        {    
        }

        public int ApplyId { get; set; }
        public int UserId { get; set; }
        public short LsRole { get; set; }
        public int? LocationId { get; set; }
        public int? DocLevId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
    }
}
