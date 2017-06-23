using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsCostDetailDTO : DtoBase<int>
    {
        public CsCostDetailDTO()
        {
        }

        public System.DateTime? OperTime { get; set; }
        public System.DateTime PayDate { get; set; }
        public string Summary { get; set; }
        public int? LocId { get; set; }
        public int? CostSubjId { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Totality { get; set; }
        public string Unit { get; set; }
        public decimal? Amount { get; set; }
        public string VoucherType { get; set; }
        public string VoucherNo { get; set; }
        public int? OperId { get; set; }
        public bool? IsAcct { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
