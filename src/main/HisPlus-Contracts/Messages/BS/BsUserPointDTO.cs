using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserPointDTO : DtoBase<int>
    {
        public BsUserPointDTO()
        {
        }

        public string Type { get; set; }
        public int UserId { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
