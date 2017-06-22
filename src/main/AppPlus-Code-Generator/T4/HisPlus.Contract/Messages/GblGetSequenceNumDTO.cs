using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblGetSequenceNumDTO : DtoBase<int>
    {
        public GblGetSequenceNumDTO()
        {
        }

        public long NextSequenceNum { get; set; }
        public bool IsDayBegin { get; set; }
        public string GetdateStr { get; private set; }
        public string NextSequenceStr { get; private set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
