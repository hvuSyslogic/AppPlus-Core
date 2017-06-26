using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OtBid : EntityBase<int>
    {
        public OtBid()
        {    
        }

        public string RecNo { get; set; }
        public System.DateTime? BitTime { get; set; }
        public System.DateTime? NotifyDate { get; set; }
        public string DispUnit { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public short? LsStatus { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsSign { get; set; }
    }
}
