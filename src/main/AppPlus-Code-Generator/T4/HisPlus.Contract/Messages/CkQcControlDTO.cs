using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkQcControlDTO : DtoBase<int>
    {
        public CkQcControlDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int MachineId { get; set; }
    }
}
