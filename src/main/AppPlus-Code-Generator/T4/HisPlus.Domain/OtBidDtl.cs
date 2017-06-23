using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OtBidDtl : EntityBase<int>
    {
        public OtBidDtl()
        {    
        }

        public int? BidId { get; set; }
        public string RoundNTime { get; set; }
        public int ItemId { get; set; }
        public int ExpOperId { get; set; }
        public byte? Point { get; set; }
        public bool? IsPass { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
