using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsBphisIllRelationDTO : DtoBase<int>
    {
        public BsBphisIllRelationDTO()
        {
        }

        public int? BpIllId { get; set; }
        public int? HisIllId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
