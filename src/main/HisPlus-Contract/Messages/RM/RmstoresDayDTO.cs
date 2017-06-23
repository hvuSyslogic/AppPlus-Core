using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmstoresDayDTO : DtoBase<int>
    {
        public RmstoresDayDTO()
        {
        }

        public int? CompId { get; set; }
    }
}
