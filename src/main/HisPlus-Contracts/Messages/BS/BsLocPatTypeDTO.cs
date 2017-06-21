using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsLocPatTypeDTO : DtoBase<int>
    {
        public BsLocPatTypeDTO()
        {
        }

        public int LocationId { get; set; }
        public int PatTypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
