using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsPatTypeYbIllDTO : DtoBase<int>
    {
        public BsPatTypeYbIllDTO()
        {
        }

        public int? TallyTypeId { get; set; }
        public int? PatTypeId { get; set; }
        public string YbCode { get; set; }
        public string YbDesc { get; set; }
        public string IllIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
