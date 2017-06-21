using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserPointDtlDTO : DtoBase<int>
    {
        public BsUserPointDtlDTO()
        {
        }

        public int UserId { get; set; }
        public decimal Point { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
