using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsBigConsumeDTO : DtoBase<int>
    {
        public CsBigConsumeDTO()
        {
        }

        public int SubjId { get; set; }
        public int LocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
