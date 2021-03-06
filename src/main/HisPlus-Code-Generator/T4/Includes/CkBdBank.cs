using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkBdBank : EntityBase<int>
    {
        public CkBdBank()
        {    
        }

        public string SerialNo { get; set; }
        public short BloodTypeId { get; set; }
        public string BloodGroup { get; set; }
        public string Rhd { get; set; }
        public System.DateTime RecieveDate { get; set; }
        public int RecieveOperId { get; set; }
        public short LsSource { get; set; }
        public string Account { get; set; }
        public System.DateTime? ExpireDate { get; set; }
        public string OfferMan { get; set; }
        public System.DateTime? CollectDate { get; set; }
        public string CollectMan { get; set; }
        public decimal? Vollume { get; set; }
        public decimal? Price { get; set; }
        public short LsStatus { get; set; }
        public System.DateTime? BackDate { get; set; }
        public int? BackOperId { get; set; }
        public string BackMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Unit { get; set; }
        public string DiscardReason { get; set; }
        public System.DateTime? DiscardTime { get; set; }
        public int? DiscardOperId { get; set; }
    }
}
