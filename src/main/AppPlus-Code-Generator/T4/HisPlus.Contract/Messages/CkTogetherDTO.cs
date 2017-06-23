using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkTogetherDTO : DtoBase<int>
    {
        public CkTogetherDTO()
        {
        }

        public int TestId1 { get; set; }
        public int? TestId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
