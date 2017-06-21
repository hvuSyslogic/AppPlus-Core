using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLabSourceItemDTO : DtoBase<int>
    {
        public BsLabSourceItemDTO()
        {
        }

        public int SourceId { get; set; }
        public int? TubeTypeId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
