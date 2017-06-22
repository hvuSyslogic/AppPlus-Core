using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsXdRpDtlDTO : DtoBase<int>
    {
        public BsXdRpDtlDTO()
        {
        }

        public int XdRpId { get; set; }
        public short GroupNum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public int? ExecLocId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? FeeTotality { get; set; }
        public int? UnitId { get; set; }
    }
}
