using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmUnderLineDTO : DtoBase<int>
    {
        public RmUnderLineDTO()
        {
        }

        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public decimal UnderLine { get; set; }
        public decimal UperLine { get; set; }
        public decimal Normal { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsActive { get; set; }
        public short? OrderBy { get; set; }
    }
}