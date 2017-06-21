using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsPatMenuIndexDTO : DtoBase<int>
    {
        public BsPatMenuIndexDTO()
        {
        }

        public long PatId { get; set; }
        public int PatMenuId { get; set; }
        public string ParentId { get; set; }
        public int RecordId { get; set; }
        public string Tips { get; set; }
    }
}
