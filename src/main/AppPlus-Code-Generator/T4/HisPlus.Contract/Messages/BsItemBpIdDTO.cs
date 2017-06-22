using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemBpIdDTO : DtoBase<int>
    {
        public BsItemBpIdDTO()
        {
        }

        public int? BpItemId { get; set; }
        public int? HisItemId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? UserId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
