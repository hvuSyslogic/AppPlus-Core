using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemAttachDTO : DtoBase<int>
    {
        public BsItemAttachDTO()
        {
        }

        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public decimal? Totality { get; set; }
        public short? LsUseArea { get; set; }
        public int? LocationId { get; set; }
    }
}
