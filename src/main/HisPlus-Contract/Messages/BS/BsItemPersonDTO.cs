using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemPersonDTO : DtoBase<int>
    {
        public BsItemPersonDTO()
        {
        }

        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int? PatId { get; set; }
        public System.DateTime? FromTime { get; set; }
        public System.DateTime? ToTime { get; set; }
        public bool? IsExcept { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
