using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUsageItemDTO : DtoBase<int>
    {
        public BsUsageItemDTO()
        {
        }

        public int UsageId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
        public int? LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public bool? IsBaby { get; set; }
        public bool? IsWomen { get; set; }
        public bool? IsMen { get; set; }
        public bool? IsOlder { get; set; }
        public string Memo { get; set; }
        public bool? IsDrugTwoDay { get; set; }
    }
}
